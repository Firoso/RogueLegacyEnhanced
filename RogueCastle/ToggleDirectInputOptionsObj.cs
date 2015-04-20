/*
  Rogue Legacy Enhanced

  This project is based on modified disassembly of Rogue Legacy's engine, with permission to do so by its creators..
  Therefore, former creators copyright notice applies to the original disassembly and its modifications. 

  Copyright(C) 2011-2015, Cellar Door Games Inc.
  Rogue Legacy(TM) is a trademark or registered trademark of Cellar Door Games Inc. All Rights Reserved.
*/

using DS2DEngine;
using InputSystem;
using Microsoft.Xna.Framework;

namespace RogueCastle
{
	public class ToggleDirectInputOptionsObj : OptionsObj
	{
		private TextObj m_toggleText;
		public override bool IsActive
		{
			get
			{
				return base.IsActive;
			}
			set
			{
				base.IsActive = value;
				if (value)
				{
					m_toggleText.TextureColor = Color.Yellow;
					return;
				}
				m_toggleText.TextureColor = Color.White;
			}
		}
		public ToggleDirectInputOptionsObj(OptionsScreen parentScreen) : base(parentScreen, "Use DInput Gamepads")
		{
			m_toggleText = (m_nameText.Clone() as TextObj);
			m_toggleText.X = m_optionsTextOffset;
			m_toggleText.Text = "No";
			AddChild(m_toggleText);
		}
		public override void Initialize()
		{
			if (InputManager.UseDirectInput)
			{
				m_toggleText.Text = "Yes";
			}
			else
			{
				m_toggleText.Text = "No";
			}
			base.Initialize();
		}
		public override void HandleInput()
		{
			if (Game.GlobalInput.JustPressed(20) || Game.GlobalInput.JustPressed(21) || Game.GlobalInput.JustPressed(22) || Game.GlobalInput.JustPressed(23))
			{
				SoundManager.PlaySound("frame_swap");
				if (m_toggleText.Text == "No")
				{
					m_toggleText.Text = "Yes";
				}
				else
				{
					m_toggleText.Text = "No";
				}
			}
			if (Game.GlobalInput.JustPressed(0) || Game.GlobalInput.JustPressed(1))
			{
				SoundManager.PlaySound("Option_Menu_Select");
				if (m_toggleText.Text == "No")
				{
					InputManager.UseDirectInput = false;
					Game.GameConfig.EnableDirectInput = false;
				}
				else
				{
					InputManager.UseDirectInput = true;
					Game.GameConfig.EnableDirectInput = true;
				}
				IsActive = false;
			}
			if (Game.GlobalInput.JustPressed(2) || Game.GlobalInput.JustPressed(3))
			{
				if (InputManager.UseDirectInput)
				{
					m_toggleText.Text = "Yes";
				}
				else
				{
					m_toggleText.Text = "No";
				}
				IsActive = false;
			}
			base.HandleInput();
		}
		public override void Dispose()
		{
			if (!IsDisposed)
			{
				m_toggleText = null;
				base.Dispose();
			}
		}
	}
}