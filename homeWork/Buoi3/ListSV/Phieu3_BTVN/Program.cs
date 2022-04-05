using System;
using System.Collections.Generic;
using System.IO;

namespace Phieu3_BTVN
{
    class Program
    {

        static List<SinhVien> list = new List<SinhVien>();
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int n;
            string ck;
            ReadForm("Student.txt");
            do
            {
                
                Console.WriteLine("\t\t-----------------------------------------------------------------");
                Console.WriteLine("\t\t|" + "\t1. Thêm sinh viên" + "\t\t\t\t\t|");
                Console.WriteLine("\t\t|" + "\t2. Cập nhật thông tin sinh viên theo ID" + "\t\t\t|");
                Console.WriteLine("\t\t|" + "\t3. Xóa sinh viên theo ID" + "\t\t\t\t|");
                Console.WriteLine("\t\t|" + "\t4. Tìm kiếm sinh vien theo tên" + "\t\t\t\t|");
                Console.WriteLine("\t\t|" + "\t5. Sắp xếp sinh viên theo điểm trung bình" + "\t\t|");
                Console.WriteLine("\t\t|" + "\t6. Sắp xếp sinh viên theo tên" + "\t\t\t\t|");
                Console.WriteLine("\t\t|" + "\t7. In danh sách sinh viên" + "\t\t\t\t|");
                Console.WriteLine("\t\t|" + "\t8. Ghi danh sách sinh viên vào file" + "\t\t\t|");
                Console.WriteLine("\t\t|" + "\t9. Thoát chương trình" + "\t\t\t\t\t|");
                Console.WriteLine("\t\t-----------------------------------------------------------------");

                Console.Write("Nhập lựa chọn của bạn: "); n = int.Parse(Console.ReadLine());
                Console.WriteLine("\t\t---------------------Danh sách ban đầu---------------------");
                foreach (SinhVien i in list)
                {
                    i.Xuat();
                }

                switch (n)
                    {
                        case 1:
                            {
                                ADD_SinhVien();
                                break;
                            }
                        case 2:
                            {
                                Update_InFO_By_ID();
                                break;
                            }
                        case 3:
                            {
                                Delete_SV_By_ID();
                                break;
                            }
                        case 4:
                            {
                                Find_SV_By_Name();
                                break;
                            }
                        case 5:
                            {
                                Sort_By_DiemTB();
                                break;
                            }
                        case 6:
                            {
                                Sort_By_Name();
                                break;
                            }
                        case 7:
                            {
                                Show_List_SV();
                                break;
                            }
                        case 8:
                            {
                                StramWriter_SV();
                                break;
                            }
                        case 9:
                            {
                                return;
                            }
                    }
               
                Console.Write("\nBạn có muốn tiếp tục không? (c/k): ");
                ck = Console.ReadLine();
                if (ck == "k")
                    Console.WriteLine("-----------BYE------------");
            } while (n < 0 || n > 9 || ck != "k");
        }

        struct SinhVien
        {
            int id, age;
            string name, sex, hocLuc;
            float diemToan, diemLy, diemHoa, diemTB;
            public SinhVien(int id, string name, int age, string sex, float diemToan, float diemLy, float diemHoa, float diemTB, string hocLuc)
            {
                this.id = id;
                this.name = name;
                this.age = age;
                this.sex = sex;
                this.hocLuc = hocLuc;
                this.diemToan = diemToan;
                this.diemLy = diemLy;
                this.diemHoa = diemHoa;
                this.diemTB = diemTB;
            }

            public int getID()
            {
                return this.id;
            }

            public int setID(int v) => this.id = v;

            public string getName()
            {
                return this.name;
            }
            public string setName(string v) => this.name = v;

            public float getDiemTB()
            {
                return this.diemTB;
            }

            public void Nhap()
            {
                Console.Write("Nhập tên: ");    this.name = Console.ReadLine();
                Console.Write("Nhập tuổi: ");    this.age = int.Parse(Console.ReadLine());
                Console.Write("Nhập giới tính: ");    this.sex = Console.ReadLine();
                Console.Write("Nhập điểm toán: ");    this.diemToan = float.Parse(Console.ReadLine());
                Console.Write("Nhập điểm lý: ");    this.diemLy = float.Parse(Console.ReadLine());
                Console.Write("Nhập điểm hóa: ");    this.diemHoa = float.Parse(Console.ReadLine());
            }

            public float DiemTB()
            {
                this.diemTB = (this.diemToan + this.diemLy + this.diemHoa) / 3;
                return this.diemTB;
            }

            public string HocLuc()
            {
                if (diemTB >= 8)
                {
                    return this.hocLuc = "Gioi";
                }
                else if (diemTB >= 6.5 && diemTB < 8)
                {
                    return this.hocLuc = "Kha";
                }
                else if (diemTB >= 5 && diemTB < 6.5)
                {
                    return this.hocLuc = "Trung binh";
                }
                else return this.hocLuc = "Yeu";
            }
            public void Xuat()
            {
                Console.Write("\nID: " + this.id + "  Name: " + this.name + "  Age: " + this.age + "  Sex: " + this.sex + "  PointMath: " + this.diemToan + "  PointPhysic: " + this.diemLy + "  PointChemistry: " + this.diemHoa + "  PointTB: " + DiemTB() + "  HocLuc: " + HocLuc() + "\n");
            }
            public string WiterForm()
            {
                return this.id + "|" + this.name + "|" + this.age + "|" + this.sex + "|" + this.diemToan + "|" + this.diemLy + "|" + this.diemHoa + "|" + this.diemTB + "|" + this.hocLuc;
        }
        };

        // Đọc file với form định dạng và gắn vào list
        public static  void  ReadForm(string fileName)
        {
            try
            {
                string[] data;
                StreamReader sd = new StreamReader(fileName);
                string line = "";
                SinhVien sv;
                while ((line = sd.ReadLine()) != null)
                {
                    data = line.Split("|");
                    // Đọc file và tạo đối tượng sinh viên với các trường dữ liệu tương ứng
                    sv = new SinhVien(int.Parse(data[0]), data[1], int.Parse(data[2]), data[3], float.Parse(data[4]), float.Parse(data[5]), float.Parse(data[6]), float.Parse(data[7]), data[8]);
                    list.Add(sv);
                }
                sd.Close();
            }
            catch (FileNotFoundException e)
            {

                Console.WriteLine("Sai đường dẫn file: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi đọc file: " + e.Message);
            }
        }

        //ID tự động tăng
        public static int GenerateID()
        {
            
            int max = 1;
            if (list != null && list.Count > 0)
            {
                max = list[0].getID(); ;
                foreach (SinhVien sv in list)
                {
                    if (max < sv.getID())
                    {
                        max = sv.getID();
                    }
                }
                max++;
            }
            return max;
        }

        //Thêm sinh viên với vào list với ID tự động tăng
        public static void ADD_SinhVien()
        {
            int n;
            Console.Write("Nhập số sinh viên cần thêm: ");      n = int.Parse(Console.ReadLine());
            for(int i = 0; i<n; i++)
            {
                SinhVien x = new SinhVien();
                Console.WriteLine("Nhập sinh viên thứ " + (i + 1));
                // tạo ID tự động tăng
                x.setID(GenerateID());
                x.Nhap();
                // Thêm sinh viên vừa tạo vào list
                list.Add(x);
            }
            Console.WriteLine("\n\t\t------------------Danh sách sau thêm---------------------");
            foreach(SinhVien i in list)
            {
                i.Xuat();
            }    
        }

        //Tìm kiếm sinh viên bằng ID
        public static Boolean checkID(int ID)
        {
            int count = 0;
            for(int i=0; i<list.Count; i++)
            {
                if(list[i].getID() == ID)
                {
                    count++;
                }    
            }    
            if(count != 0)
            {
                return true;
            }
            return false;
        }

        //Cập nhật sinh viên theo ID
        public static void Update_InFO_By_ID()
        {
            try
            {
                int ID;
                Console.Write("Nhập ID sinh viên cần chỉnh sửa: "); ID = int.Parse(Console.ReadLine());
                SinhVien svNew = new SinhVien();
                if(checkID(ID))
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].getID() == ID)
                        {
                            svNew.setID(ID);
                            svNew.Nhap();
                            list[i] = svNew;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("ID sinh viên không tồn tại");
                    Update_InFO_By_ID();
                }
                Console.WriteLine("\n\t\t-----------------------Danh sách sau cập nhật--------------------");
                foreach (SinhVien i in list)
                {
                    i.Xuat();
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("===>Sai định dạng dữ liệu: " + e.Message);
                // Đệ quy lại phương thức khi truyền sai dữ liệu vào
                Update_InFO_By_ID();
            }   
        }

        //Xóa sinh viên theo ID
        public static void Delete_SV_By_ID()
        {
            try
            {
                int ID, index = 0;
                Console.Write("Nhập ID sinh viên cần chỉnh sửa: "); ID = int.Parse(Console.ReadLine());
                if (checkID(ID))
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].getID() == ID)
                        {
                            list.Remove(list[i]);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("ID sinh viên không tồn tại");
                    Delete_SV_By_ID();
                }
                Console.WriteLine("\n\t\t---------------------------Danh sách sau xóa--------------------------");
                foreach (SinhVien i in list)
                {
                    i.Xuat();
                }
            }
            catch (FormatException e)
            {

                Console.WriteLine("Sai dữ liệu truyền vào: " + e.Message);
                // Đệ quy lại phương thức khi truyền sai dữ liệu vào
                Delete_SV_By_ID();
            }
        }

        //Tìm sinh viên theo tên
        public static void Find_SV_By_Name()
        {
            int count = 0;
            Console.Write("Nhập tên sinh viên cần tìm: ");
            string Name = Console.ReadLine();
            foreach (SinhVien i in list)
            {
                if (i.getName() == Name)
                {
                    count++;
                }
            }
            if(count != 0)
            {
                Console.WriteLine("\n\t\t-----------------Sinh viên có tên cần tìm--------------------");
                foreach (SinhVien i in list)
                {
                    if (i.getName() == Name)
                    {
                        i.Xuat();
                    }
                }
            }
            else
            {
                Console.WriteLine("Không có sinh viên nào có tên là " + Name);
            }    
        }

        //Sắp xếp thep điểm trung bình
        public static void Sort_By_DiemTB()
        {
            List<SinhVien> sv = list;
            for (int i = 0; i < sv.Count - 1; i++)
            {
                for (int j = i + 1; j < sv.Count; j++)
                {
                    if (sv[i].getDiemTB() > sv[j].getDiemTB())
                    {
                        SinhVien temp = sv[i];
                        sv[i] = sv[j];
                        sv[j] = temp;
                    }
                }
            }
            Console.WriteLine("\n\t\t--------------Danh sách sau sắp xếp theo điểm trung bình-----------------");
            foreach(SinhVien x in sv)
            {
                x.Xuat();
            }    
        }

        public static void Sort_By_Name()
        {
            int x = list.Count;
            string[] arrayName = new string[x];
            for (int i = 0; i < x; i++)
            {
                string[] arrayNameTemp = list[i].getName().Split(' ');
                for (int j = 0; j < arrayNameTemp.Length; j++)
                {
                    arrayName[i] = arrayNameTemp[arrayNameTemp.Length - 1];
                }
            }
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    if ((arrayName[i].CompareTo(arrayName[j])) < 0)
                    {
                        string temp1 = arrayName[i];
                        arrayName[i] = arrayName[j];
                        arrayName[j] = temp1;
                        SinhVien temp2 = list[i];
                        list[i] = list[j];
                        list[j] = temp2;
                    }
                }
            }
            Console.WriteLine("\n\t\t---------------Danh sách sau sắp sếp theo tên-----------------");
            foreach(SinhVien i in list)
            {
                i.Xuat();
            }    
        }

        public static void Show_List_SV()
        {
            foreach(SinhVien i in list)
            {
                i.Xuat();
            }    
        }

        public static void StramWriter_SV()
        {
            try
            {
                StreamWriter sw = new StreamWriter("Student.txt");
                foreach (SinhVien i in list)
                {
                    sw.WriteLine(i.WiterForm());
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi ghi file" + e.Message);
            }
        }

        
    }
}
