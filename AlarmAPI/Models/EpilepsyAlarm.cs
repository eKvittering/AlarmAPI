namespace AlarmAPI.Models
{
    public class EpilepsyAlarm
    {
        public string Product { get; set; }
        public string Code { get; set; }
        public string SerialNumber { get; set; }
        public string ReceiveEmployee { get; set; }
        public string ReceiveDate { get; set; }
        public string Customer { get; set; }
        public int SaleId { get; set; }
        public int DeviceId { get; set; }
        public bool IsAvalible { get; set; }
        public bool IsMedicalDevice { get; set; }

        public EpilepsyAlarm(string product, string code, string serialNumber, string receiveEmployee, string receiveDate, string customer, int saleId, int deviceId, bool isAvalible, bool isMedicalDevice)
        {
            Product = product;
            Code = code;
            SerialNumber = serialNumber;
            ReceiveEmployee = receiveEmployee;
            ReceiveDate = receiveDate;
            Customer = customer;
            SaleId = saleId;
            DeviceId = deviceId;
            IsAvalible = isAvalible;
            IsMedicalDevice = isMedicalDevice;
        }
        public EpilepsyAlarm()
        {

        }
    }
}
