using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Models;


namespace Models
{
    public class dlbtmodel
    {
        public ObservableCollection<Record> DataList { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public dlbtmodel()
        {
            // Dữ liệu mẫu
            DataList = new ObservableCollection<Record>
            {
                new Record { Id = 1, Name = "Công ty TNHH SX - TM MEBIPHA", Address = "Số 22 Khâm Thiên, Phường Khâm Thiên", Phone = "19006505" },
                new Record { Id = 2, Name = "Đại lý thuốc thú y Hương Lực", Address = "248A Nơ Trang Long, P.12, Q. Bình Thạnh", Phone = "18006821" },
                new Record { Id = 3, Name = "Cửa hàng thuốc thú y Nice Pet", Address = "128 Trần Quang Khải, P. Tân Định, Quận 1", Phone = "19001572" }
            };

            // Command xử lý chỉnh sửa và xóa
            //EditCommand = new RelayCommand(EditRecord);
            //DeleteCommand = new RelayCommand(DeleteRecord);
        }
        private void Insert(object record)
        {
            if (record is Record selectedRecord)
            {
                // Logic chỉnh sửa dữ liệu
                System.Windows.MessageBox.Show($"Chỉnh sửa: {selectedRecord.Name}");
            }
        }

        private void Edit(object record)
        {
            if (record is Record selectedRecord)
            {
                // Logic chỉnh sửa dữ liệu
                System.Windows.MessageBox.Show($"Chỉnh sửa: {selectedRecord.Name}");
            }
        }

        private void Delete(object record)
        {
            if (record is Record selectedRecord)
            {
                DataList.Remove(selectedRecord);
            }
        }
    }

    public class Record
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }

}
