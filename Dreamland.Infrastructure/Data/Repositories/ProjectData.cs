using Dreamland.Domain.Enums;
using Dreamland.Domain.Models.MasterData;
using Dreamland.Domain.Models.Project;
using Dreamland.Infrastructure.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dreamland.Infrastructure.Data.Repositories
{
    public class ProjectData : IProjectData
    {
        public List<ProjectList> GetProjectList(ProjectTypes type)
        {
            List<ProjectList> listProject = new List<ProjectList>();
            if (type.Equals(ProjectTypes.TownHome))
            {
                listProject.Add(new ProjectList { Id = new Guid("0338dcc9-9db1-42fd-9c89-6aa3884bb52f"), Name = "DREAM PRIVA", Image = "/images/townhome/projectlist/02 Townhome_01 Summary_ThumbnailDream Priva - New.jpg", Caption = "Privately Yours<br />พรีเมียมทาวน์โฮมที่ให้คุณมากกว่าใคร", Price = "3.49", IsSoldOut = false, IsShow = true, IsActive = true });
                listProject.Add(new ProjectList { Id = new Guid("e7cd08ef-10b4-4a99-bcb0-5a0debaa4560"), Name = "DREAM DELUXE", Image = "/images/townhome/projectlist/02 Townhome_01 Summary_ThumbnailDream Deluxe - Sold out.jpg", Caption = "\"Sense of Living\"<br />สุนทรียภาพของการอยู่อาศัย", Price = "3.49", IsSoldOut = true, IsShow = false, IsActive = true });
                listProject.Add(new ProjectList { Id = new Guid("6022c88b-9a00-4bff-9199-8a32ad72a6d7"), Name = "DREAM VILLE 3", Image = "/images/townhome/projectlist/02 Townhome_01 Summary_ThumbnailDream Ville 3 - Sold out.jpg", Caption = "Modern Townhome<br />ขยายความสบายของคุณ", Price = "3.49", IsSoldOut = true, IsShow = false, IsActive = true });
                listProject.Add(new ProjectList { Id = new Guid("9186f867-3a72-4a55-9e54-9a810aa4eb2d"), Name = "DREAM VILLE 2", Image = "/images/townhome/projectlist/02 Townhome_01 Summary_ThumbnailDream Ville 2 - Sold out.jpg", Caption = "The Privacy<br />เขียนชีวิตใหม่ ที่กว้างกว่า ด้วยตัวคุณ", Price = "3.49", IsSoldOut = true, IsShow = false, IsActive = true });
                listProject.Add(new ProjectList { Id = new Guid("8397b74b-2ce9-42c4-97fc-24d4dc49943b"), Name = "DREAM VILLE", Image = "/images/townhome/projectlist/02 Townhome_01 Summary_ThumbnailDream Ville - Sold out.jpg", Caption = "Write yours Own DREAM<br /> \"บ้าน\"ที่คุณจะเอนกายได้ทั้งวัน", Price = "3.49", IsSoldOut = true, IsShow = false, IsActive = true });
                listProject.Add(new ProjectList { Id = new Guid("c4eebf7e-c769-4945-bf46-c35a38ce7792"), Name = "A DREAM", Image = "/images/townhome/projectlist/02 Townhome_01 Summary_ThumbnailA Dream - Sold out.jpg", Caption = "A Dream - Touch the COZY, Live the MODERN<br />\"เอ ดรีม\" ตอบรับแนวคิดใหม่ของการใช้ชีวิต", Price = "3.49", IsSoldOut = true, IsShow = false, IsActive = true });
                listProject.Add(new ProjectList { Id = new Guid("22b81537-1be6-4580-b65c-27b02b8cead2"), Name = "DREAM VILLAGE", Image = "/images/townhome/projectlist/02 Townhome_01 Summary_ThumbnailDream Village - Sold out.jpg", Caption = "TOWNHOUSE XL<br />เมื่อความสุขถูกขยาย....ความสบายก็เหลือเฟือ", Price = "3.49", IsSoldOut = true, IsShow = false, IsActive = true });
                listProject.Add(new ProjectList { Id = new Guid("f0956b64-281e-4cf1-b256-fda8e59ccb59"), Name = "DREAM PLACE", Image = "/images/townhome/projectlist/02 Townhome_01 Summary_ThumbnailDream Place - Sold out.jpg", Caption = "Make you home your Dream Place<br />ครบสมบูรณ์ทุกฟังก์ชัน ครบคุณค่าของคำว่า \"บ้านที่ดี\"", Price = "3.49", IsSoldOut = true, IsShow = false, IsActive = true });
                listProject.Add(new ProjectList { Id = new Guid("046c38ed-a58e-486f-9440-8ff899fd4896"), Name = "DREAM TOWN", Image = "/images/townhome/projectlist/02 Townhome_01 Summary_ThumbnailDream Town - Sold out.jpg", Caption = "Good Life begins here<br />ทาวน์โฮมหน้ากว้าง ลงตัวทุกฟังก์ชันครบคุณค่าของคำว่า \"บ้านที่ดี\"", Price = "3.49", IsSoldOut = true, IsShow = false, IsActive = true });
                listProject.Add(new ProjectList { Id = new Guid("9a6b79e1-5715-4038-99cd-1a30801927cf"), Name = "DREAM HOME", Image = "/images/townhome/projectlist/02 Townhome_01 Summary_ThumbnailDream Home - Sold out.jpg", Caption = "Your Happiness, Your Dream<br />ครบสมบูรณ์ทุกฟังก์ชัน ครบคุณค่าของคำว่า \"บ้านที่ดี\"", Price = "3.49", IsSoldOut = true, IsShow = false, IsActive = true });
                listProject.Add(new ProjectList { Id = new Guid("3844bb3e-0191-4b62-b434-89688d4a12bb"), Name = "RATIROM VILLE", Image = "/images/townhome/projectlist/02 Townhome_01 Summary_ThumbnailRatirom Ville - Sold out.jpg", Caption = "Convenience at your step<br />ครบสมบูรณ์ทุกฟังก์ชัน ครบคุณค่าของคำว่า \"บ้านที่ดี\"", Price = "3.49", IsSoldOut = true, IsShow = false, IsActive = true });
                listProject.Add(new ProjectList { Id = new Guid("8bcbeb0b-9272-460f-8dfb-40c44bcafe69"), Name = "RATIROM 4", Image = "/images/townhome/projectlist/02 Townhome_01 Summary_ThumbnailRatirom 4 - Sold out.jpg", Caption = "Convenience at your step<br />ทาวน์โฮมติดถนน สะดวกสบายในทุกการเดินทาง", Price = "3.49", IsSoldOut = true, IsShow = false, IsActive = true });
                listProject.Add(new ProjectList { Id = new Guid("35110639-929c-4a40-940c-ecd48067a4fb"), Name = "RATIROM 3", Image = "/images/townhome/projectlist/02 Townhome_01 Summary_ThumbnailRatirom 3 - Sold out.jpg", Caption = "Convenience at your step<br />ทาวน์โฮมติดถนน สะดวกสบายในทุกการเดินทาง", Price = "3.49", IsSoldOut = true, IsShow = false, IsActive = true });
            }
            else if (type.Equals(ProjectTypes.House))
            {
                listProject.Add(new ProjectList { Id = new Guid("00e4ed1f-0dde-4265-9f22-f82ca08e32e6"), Name = "RATIROM DELUXE", Image = "/images/house/projectlist/03 Detached House_01 Summary_ThumbnailRatirom Deluxe - New.jpg", Caption = "Exclusively Private Residences<br />ชีวิตส่วนตัว กับ \"บ้าน\" ใจกลางความสะดวกสบาย", Price = "3.49", IsSoldOut = false, IsShow = true, IsActive = true });
                listProject.Add(new ProjectList { Id = new Guid("6c439e12-c08b-40db-8744-faa374452e9b"), Name = "RATIROM FIFTH", Image = "/images/house/projectlist/03 Detached House_01 Summary_ThumbnailRatirom Fifth - Sold out.jpg", Caption = "Pride of Living Modernity<br />จุดบรรจบของความภูมิฐานและสง่างามสำหรับครอบครัวคุณ", Price = "3.49", IsSoldOut = true, IsShow = false, IsActive = true });
                listProject.Add(new ProjectList { Id = new Guid("3a72ca58-f83d-4f9a-b896-bea37bc5b450"), Name = "RATIROM PARK", Image = "/images/house/projectlist/03 Detached House_01 Summary_ThumbnailRatirom Park - Sold out.jpg", Caption = "Make Everyday Feels Like Vacation<br />บ้านบรรยากาศในสวน ร่มรื่นดุจอยู่ใจกลางธรรมชาติ", Price = "3.49", IsSoldOut = true, IsShow = false, IsActive = true });
                listProject.Add(new ProjectList { Id = new Guid("2d739859-189a-4647-a6a6-78dc3061b628"), Name = "RATIROM PLACE", Image = "/images/house/projectlist/03 Detached House_01 Summary_ThumbnailRatirom Place - Sold out.jpg", Caption = "Endless Dream<br />ตอบโจทย์ความฝันของคุณ", Price = "3.49", IsSoldOut = true, IsShow = false, IsActive = true });
                listProject.Add(new ProjectList { Id = new Guid("548bcf6f-b70f-43d2-977c-51f05f56a960"), Name = "RATIROM 2", Image = "/images/house/projectlist/03 Detached House_01 Summary_ThumbnailRatirom 2 - Sold out.jpg", Caption = "Make Every Minute Worthwhile<br />ให้ทุกนาทีสะท้อนความภาคภูมิใจในตัวคุณ", Price = "3.49", IsSoldOut = true, IsShow = false, IsActive = true });
            }
            return listProject;
        }

        public ProjectItem GetProjectById(Guid id)
        {
            ProjectItem project = new ProjectItem();
            if (id.Equals("0338dcc9-9db1-42fd-9c89-6aa3884bb52f"))
            {
                project.Id = new Guid("0338dcc9-9db1-42fd-9c89-6aa3884bb52f");
                project.Name = "Ratiron Deluxe";
                project.Content = "";
                project.CreatedAt = DateTime.Parse("2021-03-19T05:20:12.0000000Z");
                project.CreateBy = "Administartor";
            }
            else if (id.Equals("00e4ed1f-0dde-4265-9f22-f82ca08e32e6"))
            {
                project.Id = new Guid("00e4ed1f-0dde-4265-9f22-f82ca08e32e6");
                project.Name = "Dream Priva";
                project.Content = "";
                project.CreatedAt = DateTime.Parse("2021-03-19T05:20:12.0000000Z");
                project.CreateBy = "Administrator";
            }
            return project;
        }
    }
}
