﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YeeOfficeSDK.Interfaces;
using YeeOfficeSDK.Models;
using YeeOfficeSDK.Tools;

namespace YeeOfficeSDK.Repository
{
    public partial class AkmiiRepository : IAkmiiRepository
    {
        #region Admin User API
        public Task<ResponseMessage<string>> UserInfoAddAsync(UserInfoAddRequest request)
        {
            var apiUrl = new AkmiiApiUrl
            {
                Method = "POST",
                Url = _context.DomainUrl + "/YeeOfficeSettings/_api/ver(3.0)/admin/userinfo"
            };
            return GetResponseAsync<ResponseMessage<string>>(apiUrl, request.Convert2Json());
        }
        public Task<ResponseMessage<string>> UserInfoChangeAsync(UserInfoChangeRequest request)
        {
            var apiUrl = new AkmiiApiUrl
            {
                Method = "PUT",
                Url = _context.DomainUrl + "/YeeOfficeSettings/_api/ver(3.0)/admin/userinfo"
            };
            return GetResponseAsync<ResponseMessage<string>>(apiUrl, request.Convert2Json());
        }
        public Task<ResponseMessage<string>> UserInfoRemoveAsync(List<UserInfoRemoveRequest> list)
        {
            var apiUrl = new AkmiiApiUrl
            {
                Method = "PUT",
                Url = _context.DomainUrl + "/YeeOfficeSettings/_api/ver(3.0)/admin/userinfo/Remove"
            };
            var request = new UserInfoRemovesRequest(list);
            return GetResponseAsync<ResponseMessage<string>>(apiUrl, request.Convert2Json());
        }
        public Task<ResponseMessage<bool>> UserInfoEnableAsync(UserInfoAccountIDsRequest request)
        {
            var apiUrl = new AkmiiApiUrl
            {
                Method = "PUT",
                Url = _context.DomainUrl + "/YeeOfficeSettings/_api/ver(3.0)/admin/userinfo/enable"
            };
            return GetResponseAsync<ResponseMessage<bool>>(apiUrl, request.Convert2Json());
        }
        public Task<ResponseMessage<bool>> UserInfoDisableAsync(UserInfoAccountIDsRequest request)
        {
            var apiUrl = new AkmiiApiUrl
            {
                Method = "PUT",
                Url = _context.DomainUrl + "/YeeOfficeSettings/_api/ver(3.0)/admin/userinfo/disable"
            };
            return GetResponseAsync<ResponseMessage<bool>>(apiUrl, request.Convert2Json());
        }
        public Task<ResponseMessage<string>> UserInfoMoveOrgAsync(UserInfoMoveOrgRequest data)
        {
            var apiUrl = new AkmiiApiUrl
            {
                Method = "PUT",
                Url = _context.DomainUrl + "/YeeOfficeSettings/_api/ver(3.0)/admin/userinfo/move"
            };
            var request = new UserInfoMoveRequest(data);
            return GetResponseAsync<ResponseMessage<string>>(apiUrl, request.Convert2Json());
        }
        #endregion

        #region User API
        public Task<ResponseMessage<List<UserInfo>>> UserInfoSearchAsync(UserInfoSearchRequest request)
        {
            var apiUrl = new AkmiiApiUrl
            {
                Method = "GET",
                Url = _context.DomainUrl + "/YeeOfficeSettings/_api/ver(3.0)/userinfo/V4/search"
            };
            return GetResponseAsync<ResponseMessage<List<UserInfo>>>(apiUrl, request.Convert2Json());
        }
        public Task<ResponseMessage<List<UserInfo>>> UserInfoSearchByWhereAsync(UserInfoSearchByWhereRequest request)
        {
            var apiUrl = new AkmiiApiUrl
            {
                Method = "POST",
                Url = _context.DomainUrl + "/YeeOfficeSettings/_api/ver(3.0)/userinfo/V4/search"
            };
            return GetResponseAsync<ResponseMessage<List<UserInfo>>>(apiUrl, request.Convert2Json());
        }
        public Task<ResponseMessage<UserInfo>> UserInfoGetByAccountIDAsync(long accountID)
        {
            var apiUrl = new AkmiiApiUrl
            {
                Method = "GET",
                Url = _context.DomainUrl + "/YeeOfficeSettings/_api/ver(3.0)/userinfo/V4?accountID=" + accountID
            };
            return GetResponseAsync<ResponseMessage<UserInfo>>(apiUrl, null);
        }
        public Task<ResponseMessage<UserInfo>> UserInfoGetByEmployeeNoAsync(string employeeNo)
        {
            var apiUrl = new AkmiiApiUrl
            {
                Method = "GET",
                Url = _context.DomainUrl + "/YeeOfficeSettings/_api/ver(3.0)/userinfo/V4/employeeno?employeeno=" + employeeNo
            };
            return GetResponseAsync<ResponseMessage<UserInfo>>(apiUrl, null);
        }
        public Task<ResponseMessage<UserInfo>> UserInfoGetByspAccountAsync(string spAccount)
        {
            var apiUrl = new AkmiiApiUrl
            {
                Method = "GET",
                Url = _context.DomainUrl + "/YeeOfficeSettings/_api/ver(3.0)/userinfo/V4/spAccount?spAccount=" + spAccount
            };
            return GetResponseAsync<ResponseMessage<UserInfo>>(apiUrl, null);
        }
        public Task<ResponseMessage<UserInfo>> UserInfoGetByEmailAsync(string email)
        {
            var apiUrl = new AkmiiApiUrl
            {
                Method = "GET",
                Url = _context.DomainUrl + "/YeeOfficeSettings/_api/ver(3.0)/userinfo/V4/email?email=" + email
            };
            return GetResponseAsync<ResponseMessage<UserInfo>>(apiUrl, null);
        }
        #endregion
    }
}
