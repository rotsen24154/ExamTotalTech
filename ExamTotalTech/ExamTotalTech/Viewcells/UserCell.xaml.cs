﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamTotalTech.Viewcells
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UserCell : ViewCell
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="T:ExamTotalTech.Viewcells.UserCell"/> class.
        /// </summary>
		public UserCell ()
		{
			InitializeComponent ();
		}
	}
}