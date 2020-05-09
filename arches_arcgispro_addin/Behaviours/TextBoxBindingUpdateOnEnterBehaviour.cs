/*

   Copyright 2020 Esri

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.

   See the License for the specific language governing permissions and
   limitations under the License.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Interactivity;
using System.Windows.Controls;
using System.Windows.Input;

namespace arches_arcgispro_addin.Behaviours
{
	/// <summary>
	/// From https://github.com/cefsharp/CefSharp.MinimalExample/blob/master/CefSharp.MinimalExample.Wpf/Behaviours/TextBoxBindingUpdateOnEnterBehaviour.cs
	/// </summary>
	public class TextBoxBindingUpdateOnEnterBehaviour : Behavior<TextBox>
	{
		protected override void OnAttached()
		{
			AssociatedObject.KeyDown += OnTextBoxKeyDown;
		}

		protected override void OnDetaching()
		{
			AssociatedObject.KeyDown -= OnTextBoxKeyDown;
		}

		private void OnTextBoxKeyDown(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.Enter)
			{
				var txtBox = sender as TextBox;
				txtBox.GetBindingExpression(TextBox.TextProperty).UpdateSource();
			}
		}
	}
}
