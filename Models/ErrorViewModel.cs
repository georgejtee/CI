using System;

namespace jenkins.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

          public bool ShowRequestId2 => !string.IsNullOrEmpty(RequestId);
    }
}