﻿namespace CryptoMarket.Desktop.Forms
{
	public partial class MarketForm : Form
	{
		static FlowLayoutPanel _currenciesFlowLayoutPanel;
		public class Student
		{
			public string Name { get; set; }
			public int Age { get; set; }

		}
		public class Book
		{
			public string Name { get; set; }
			public string Author { get; set; }
		}
		public MarketForm()
		{
			InitializeComponent();
			_currenciesFlowLayoutPanel = currenciesFlowLayoutPanel;
			AddStudentsToForm();

			//currenciesFlowLayoutPanel;
		}
		public static void AddStudentsToForm()
		{
			List<Student> students = GetStudents();
			for (int i = 0; i < students.Count; i++)
			{
				Label NameText = new Label()
				{
					// label1
					// 
					AutoSize = true,
					Location = new System.Drawing.Point(7, 32),
					Name = "label1",
					Size = new System.Drawing.Size(43, 17),
					TabIndex = 0,
					Text = "Name",
				};
				Label AgeText = new Label()
				{
					AutoSize = true,
					Location = new System.Drawing.Point(7, 61),
					Name = "label4",
					Size = new System.Drawing.Size(31, 17),
					TabIndex = 2,
					Text = "Age",
				};
				Label namelabel = new Label()
				{
					AutoSize = true,
					Location = new System.Drawing.Point(56, 32),
					Name = "label2",
					Size = new System.Drawing.Size(43, 17),
					TabIndex = 1,
					Text = students[i].Name
				};
				Label ageLabel = new Label
				{
					AutoSize = true,
					Location = new System.Drawing.Point(56, 61),
					Name = "label3",
					Size = new System.Drawing.Size(43, 17),
					TabIndex = 3,
					Text = students[i].Age.ToString()
				};

				GroupBox groupBox = new GroupBox()
				{
				   
					Location = new Point(3, 3),
					Size = new System.Drawing.Size(320, 200),
					//Padding = new Padding(64,64,64,64),
					Margin = new Padding(5, 5, 5, 5),
					Name = "groupBox",
					Text = students[i].Name, //"groupBox",
					Controls = { namelabel, ageLabel, NameText, AgeText }
				};
				
				_currenciesFlowLayoutPanel.Controls.Add(groupBox);
			}
		}
		public static void AddBooksToForm()
		{
			List<Book> bookL = GetBooks();
			for (int i = 0; i < bookL.Count; i++)
			{
				Label NameText = new Label()
				{
					// label1
					// 
					AutoSize = true,
					Location = new System.Drawing.Point(7, 32),
					Name = "label1",
					Size = new System.Drawing.Size(43, 17),
					TabIndex = 0,
					Text = "Book Name",
				};
				Label AgeText = new Label()
				{
					AutoSize = true,
					Location = new System.Drawing.Point(7, 61),
					Name = "label4",
					Size = new System.Drawing.Size(31, 17),
					TabIndex = 2,
					Text = "Author",
				};
				Label namelabel = new Label()
				{
					AutoSize = true,
					Location = new System.Drawing.Point(56, 32),
					Name = "label2",
					Size = new System.Drawing.Size(43, 17),
					TabIndex = 1,
					Text = bookL[i].Name
				};
				Label authorLabel = new Label
				{
					AutoSize = true,
					Location = new System.Drawing.Point(56, 61),
					Name = "label3",
					Size = new System.Drawing.Size(43, 17),
					TabIndex = 3,
					Text = bookL[i].Author
				};

				GroupBox groupBox = new GroupBox()
				{

					Location = new Point(3, 3),
					Size = new System.Drawing.Size(320, 200),
					//Padding = new Padding(64,64,64,64),
					Margin = new Padding(5, 5, 5, 5),
					Name = "groupBox",
					Text = bookL[i].Name, //"groupBox",
					Controls = { namelabel, authorLabel, NameText, AgeText }
				};
			
				_currenciesFlowLayoutPanel.Controls.Add(groupBox);
			}
		}
		public static List<Student> GetStudents()
		{
			List<Student> studentsList = new List<Student>();
			for (int i = 1; i <= 101; i++)
			{
				studentsList.Add(new Student() { Name = "Name_" + i.ToString(), Age = i });
			}
			return studentsList;
		}
		public static List<Book> GetBooks()
		{
			List<Book> booksList = new List<Book>();
			for(int i = 1; i <= 101; i++)
			{
				booksList.Add(new Book() { Name = "BookName_" + i.ToString(), Author = "Author_" + i.ToString() });
			}
			return booksList;
		}

		private void exchangesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_currenciesFlowLayoutPanel.Controls.Clear();
			AddBooksToForm();
		}

		private void coinsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_currenciesFlowLayoutPanel.Controls.Clear();
			AddStudentsToForm();
		}
	}
}
