﻿//------------------------------------------------------------------------------
// <auto-generated> BusinessObject.cst
//     此代码由工具生成.
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将丢失.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using SmallShop.Utilities;

namespace SmallShop.Entities
{
    /// <summary>
    /// 实体类 UserInfo
	/// </summary>
    [Serializable]
    public partial class UserInfo 
    {	
        /// <summary>
        /// 获取或设置 Id,不可空 
        /// </summary>
        public int Id { get; set; }
		
        /// <summary>
        /// 获取或设置 LoginName,Nulla,长度N20 
        /// </summary>
        public string LoginName { get; set; }
		
        /// <summary>
        /// 获取或设置 Password,可空,长度32 
        /// </summary>
        public string Password { get; set; }
		
        /// <summary>
        /// 获取或设置 Type,可空 
        /// enum=UserType
        /// </summary>
        public UserType Type { get; set; }
		
        /// <summary>
        /// 获取或设置 Balance,可空 
        /// </summary>
        public decimal Balance { get; set; }
		
        /// <summary>
        /// 获取或设置 Depth,不可空 
        /// </summary>
        public int Depth { get; set; }
		
        /// <summary>
        /// 获取或设置 ParentId,可空 
        /// </summary>
        public int ParentId { get; set; }
		
        /// <summary>
        /// 获取或设置 WeiXinOpenId,可空,长度32 
        /// </summary>
        public string WeiXinOpenId { get; set; }
		
        /// <summary>
        /// 获取或设置 CreateTime,可空 
        /// </summary>
        public DateTime CreateTime { get; set; }
		
    }
}
