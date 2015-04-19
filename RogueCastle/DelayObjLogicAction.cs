using DS2DEngine;
using Microsoft.Xna.Framework;

namespace RogueCastle
{
	public class DelayObjLogicAction : LogicAction
	{
		private GameObj m_delayObj;
		private float m_delayCounter;
		public DelayObjLogicAction(GameObj delayObj)
		{
			m_delayObj = delayObj;
			m_delayCounter = 0f;
		}
		public override void Execute()
		{
			if (ParentLogicSet != null && ParentLogicSet.IsActive)
			{
				SequenceType = Types.Sequence.Serial;
				m_delayCounter = m_delayObj.X;
				base.Execute();
			}
		}
		public override void Update(GameTime gameTime)
		{
			m_delayCounter -= (float)gameTime.ElapsedGameTime.TotalSeconds;
			ExecuteNext();
			base.Update(gameTime);
		}
		public override void ExecuteNext()
		{
			if (m_delayCounter <= 0f)
			{
				base.ExecuteNext();
			}
		}
		public override void Stop()
		{
			base.Stop();
		}
		public override object Clone()
		{
			return new DelayObjLogicAction(m_delayObj);
		}
		public override void Dispose()
		{
			if (!IsDisposed)
			{
				m_delayObj = null;
				base.Dispose();
			}
		}
	}
}
