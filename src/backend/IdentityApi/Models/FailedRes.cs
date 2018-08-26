using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IdentityApi.Models
{
    public class FailedRes
    {
        // [Display(Name = "code")]
        public byte Code { get; set; } = 1;

        // [Display(Name = "msg")]
        public string Msg { get; set; } = "request:failed";

        public FailedRes(byte code, string msg)
        {
            Code = code;
            Msg = msg;
        }

        public FailedRes(string msg)
        {
            Msg = msg;
        }

        public FailedRes()
        {
        }
    }
}
