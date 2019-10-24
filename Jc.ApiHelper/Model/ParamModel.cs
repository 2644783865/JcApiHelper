﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Jc.ApiHelper
{
    /// <summary>
    /// 参数对象
    /// </summary>
    public class ParamModel
    {
        #region Properties

        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 参数名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 类型Id
        /// </summary>
        public string TypeId { get { return PType.Id; } }

        /// <summary>
        /// 类型名称
        /// </summary>
        public string TypeName { get { return PType.TypeName; } }

        /// <summary>
        /// 是否为枚举类型
        /// </summary>
        public bool IsEnum { get { return PType.IsEnum; } }

        /// <summary>
        /// 是否为泛型
        /// </summary>
        public bool IsGeneric { get { return PType.IsGeneric; } }

        /// <summary>
        /// 是否实现了IEnumerable接口
        /// </summary>
        public bool IsIEnumerable { get { return PType.IsIEnumerable; } }

        /// <summary>
        /// 枚举Item类型Id
        /// </summary>
        public string EnumItemId { get { return PType.EnumItemId; } }

        /// <summary>
        /// 枚举Item类型Name
        /// </summary>
        public string EnumItemName { get { return PType.EnumItemName; } }

        /// <summary>
        /// 是否为Json序列化忽略属性
        /// </summary>
        [JsonIgnore]
        public bool? IsJsonIgnore
        {
            get
            {
                return CustomerAttrList?.Any(attr=>attr.Name.ToLower().Contains("jsonignore"));
            }
        }

        /// <summary>
        /// 类型包含属性List
        /// </summary>
        public bool? HasPiList { get { return PType.PiList?.Count>0; } }

        /// <summary>
        /// Summary
        /// </summary>
        public string Summary { get; set; }
        
        /// <summary>
        /// 值
        /// </summary>
        public object ParamValue { get; set; }

        /// <summary>
        /// 位置
        /// </summary>
        public int Position { get; set; }

        /// <summary>
        /// 是否可选
        /// </summary>
        public bool? IsOptional { get; set; } = null;

        /// <summary>
        /// 默认值
        /// </summary>
        public string DefaultValue { get; set; }

        /// <summary>
        /// 特性列表
        /// </summary>
        [JsonIgnore]
        public List<CustomerAttrModel> CustomerAttrList { get; set; }

        /// <summary>
        /// 类型信息对象
        /// </summary>
        [JsonIgnore]
        public PTypeModel PType { get; set; }
        #endregion

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        public ParamModel()
        {
        }
        #endregion
    }
}
