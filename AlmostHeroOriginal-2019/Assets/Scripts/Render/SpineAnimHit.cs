using System;
using Spine;
using UnityEngine;

namespace Render
{
	public class SpineAnimHit : SpineAnim
	{
		public SpineAnimHit() : base(SpineAnimHit.Prefab)
		{
		}

		public static GameObject Prefab;

		public static Spine.Animation anim;
	}
}
