﻿// Copyright (c) Argo Zhang (argo@163.com). All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// Website: https://www.blazor.zone or https://argozhang.github.io/

namespace Undersoft.SDK.Blazor.Components;

/// <summary>
/// IValidComponent 接口
/// </summary>
public interface IValidateComponent
{
    /// <summary>
    /// 获得/设置 是否不进行验证 默认为 false
    /// </summary>
    bool IsNeedValidate { get; }

    /// <summary>
    /// 判断是否需要进行复杂类验证
    /// </summary>
    /// <returns></returns>
    bool IsComplexValue(object? value);

    /// <summary>
    /// 数据验证方法
    /// </summary>
    /// <param name="propertyValue"></param>
    /// <param name="context"></param>
    /// <param name="results"></param>
    Task ValidatePropertyAsync(object? propertyValue, ValidationContext context, List<ValidationResult> results);

    /// <summary>
    /// 显示或者隐藏提示信息方法
    /// </summary>
    /// <param name="results"></param>
    /// <param name="validProperty">是否为模型验证 true 为属性验证 false 为整个模型验证</param>
    void ToggleMessage(IEnumerable<ValidationResult> results, bool validProperty);
}
