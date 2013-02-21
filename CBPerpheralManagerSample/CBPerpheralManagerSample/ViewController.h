//
//  ViewController.h
//  CBPerpheralManagerSample
//
//  Created by 伊藤 伸裕 on 2013/02/02.
//  Copyright (c) 2013年 伊藤 伸裕. All rights reserved.
//

#import <UIKit/UIKit.h>
#import <CoreBluetooth/CoreBluetooth.h>

@interface ViewController : UIViewController <CBPeripheralManagerDelegate>

@property (strong, nonatomic) CBPeripheralManager *manager ;
@property (strong, nonatomic) CBMutableCharacteristic *updatableCharacteristic;
@property (weak, nonatomic) IBOutlet UITextField *textField;

@end
