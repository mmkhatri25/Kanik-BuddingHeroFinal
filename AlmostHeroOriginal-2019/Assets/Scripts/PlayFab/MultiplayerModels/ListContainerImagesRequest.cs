using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class ListContainerImagesRequest : PlayFabRequestCommon
	{
		public int? PageSize;

		public string SkipToken;
	}
}
