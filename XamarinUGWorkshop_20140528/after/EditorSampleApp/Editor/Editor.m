//
//  Editor.m
//  Editor
//
//  Created by Nobuhiro Ito on 2014/05/27.
//  Copyright (c) 2014年 Nobuhiro Ito. All rights reserved.
//

#import "Editor.h"
#import "EditorViewController.h"

@implementation Editor

+ (UIViewController *) editorViewController
{
    return [[EditorViewController alloc] initWithNibName:@"EditorViewController" bundle:[self bundle]];
}

static NSBundle *editor_SharedBundle = nil;

+(NSBundle *)bundle
{
    static dispatch_once_t onceToken;
    dispatch_once(&onceToken, ^{
        editor_SharedBundle = [NSBundle bundleWithURL:[[NSBundle mainBundle] URLForResource:@"EditorResources"
                                                                              withExtension:@"bundle"]];
    });
    return editor_SharedBundle;
}


@end
