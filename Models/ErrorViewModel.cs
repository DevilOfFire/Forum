using System;

namespace Forum.Models
{
    // Model do przesy�ania informacji o b��dzie z kontrolki HomeController do ~/Views/Shared/Error
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}