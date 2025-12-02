using System;

namespace StudentManager
{
    public class Student
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        // Localized fields used by the main form
        public string MaSV { get; set; }
        public string TenSV { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string QueQuan { get; set; }
        public DateTime NgayNhapHoc { get; set; }
        public string MaLop { get; set; }
        public string MaKhoa { get; set; }
        public string MaCoVan { get; set; }

        // Backwards-compatible properties used by StudentForm (and older code)
        // Map Name to TenSV so both APIs stay in sync.
        public string Name
        {
            get => TenSV;
            set => TenSV = value;
        }

        // Keep Age and Email for StudentForm; Age may be computed elsewhere if needed.
        public int Age { get; set; }
        public string Email { get; set; }

        public Student() { }

        public Student Clone()
        {
            return new Student
            {
                Id = this.Id,
                MaSV = this.MaSV,
                TenSV = this.TenSV,
                NgaySinh = this.NgaySinh,
                GioiTinh = this.GioiTinh,
                QueQuan = this.QueQuan,
                NgayNhapHoc = this.NgayNhapHoc,
                MaLop = this.MaLop,
                MaKhoa = this.MaKhoa,
                MaCoVan = this.MaCoVan,
                Age = this.Age,
                Email = this.Email
            };
        }
    }
}//thang34