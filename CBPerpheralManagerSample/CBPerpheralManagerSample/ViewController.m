//
//  ViewController.m
//  CBPerpheralManagerSample
//
//  Created by 伊藤 伸裕 on 2013/02/02.
//  Copyright (c) 2013年 伊藤 伸裕. All rights reserved.
//

#import "ViewController.h"

@interface ViewController ()


@end

@implementation ViewController

- (void)viewDidLoad
{
    [super viewDidLoad];
    
    // CBPeripheralManager を作る
    self.manager = [[CBPeripheralManager alloc]
                    initWithDelegate:self
                    queue:dispatch_get_main_queue()];
    
    // 提供するサービス (CBMutableService) を作る
    CBMutableService *service = [[CBMutableService alloc]
                                 initWithType:[CBUUID UUIDWithString:@"08437F15-F119-445F-8C80-16CC1757C0D0"]
                                 primary:YES];
    
    // サービスに含まれるCharacteristic (CBMutableCharacteristic サービスが持ってる値) を作る
    self.updatableCharacteristic = [[CBMutableCharacteristic alloc]
                                    initWithType:[CBUUID UUIDWithString:@"F653CDDA-F8E4-4A46-9AD3-1AD3D5367641"]
                                    properties:CBCharacteristicPropertyRead
                                    value:nil // 動的な値を定義するときは nil
                                    permissions:CBAttributePermissionsReadable];
    CBMutableCharacteristic *staticCharacteristic = [[CBMutableCharacteristic alloc]
                                                     initWithType:[CBUUID UUIDWithString:@"FCC21B35-4CF6-4AE3-BE29-D3B64BB681AE"]
                                                     properties:CBCharacteristicPropertyRead
                                                     value:[@"TestTest" dataUsingEncoding:NSUTF8StringEncoding]
                                                     permissions:CBAttributePermissionsReadable];
    
    // サービスにCharacteristicを登録する
    service.characteristics = @[
        staticCharacteristic,
        self.updatableCharacteristic
    ];
    
    // PeripheralManager にサービスを登録する
    [self.manager addService:service];
    
    // サービスを公開して電波にのっける
    [self.manager startAdvertising:@{
        CBAdvertisementDataLocalNameKey : @"TestApp"
     }];
}

-(void)peripheralManagerDidUpdateState:(CBPeripheralManager *)peripheral {
    
}

-(void)peripheralManager:(CBPeripheralManager *)peripheral didReceiveReadRequest:(CBATTRequest *)request {
    
    // 動的な値を要求された場合、request に値をセットする
    request.value = [self.textField.text dataUsingEncoding:NSUTF8StringEncoding];
    
    // 結果を返す
    [peripheral respondToRequest:request withResult:CBATTErrorSuccess];
}

@end
