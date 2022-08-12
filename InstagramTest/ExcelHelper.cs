using IronXL;

namespace InstagramTest
{
	public class ExcelHelper
	{
		public void CreateExcelFile(ProfileDto profile)
		{
			var workbook = WorkBook.Create(ExcelFileFormat.XLSX);
			var sheet = workbook.CreateWorkSheet("Instagram Account Info");

			sheet["A1"].Value = "Account name";
			sheet["B1"].Value = "Number of post";
			sheet["C1"].Value = "Number of follower";
			sheet["D1"].Value = "Number of Follows";
			sheet["E1"].Value = "Bio description";
			sheet["F1"].Value = "Email";
			sheet["G1"].Value = "Phone number";
			sheet["H1"].Value = "Place";

			sheet["A2"].Value = profile.AccountName;
			sheet["B2"].Value = profile.NumberOfPost;
			sheet["C2"].Value = profile.NumberOfFollower;
			sheet["D2"].Value = profile.NumberOfFollows;
			sheet["E2"].Value = profile.BioDescription;
			sheet["F2"].Value = profile.Email;
			sheet["G2"].Value = profile.PhoneNumber;
			sheet["H2"].Value = profile.Place;

			workbook.SaveAs("instagram-info.xlsx");
		}
	}
}
