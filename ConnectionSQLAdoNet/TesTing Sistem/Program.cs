using TesTing_Sistem;

ProjectsDBConnect projectsDB = new();
//projectsDB.SelectAll("Names");
projectsDB.DeleteByID(4, "Names");