﻿// Visual Pinball Engine
// Copyright (C) 2020 freezy and VPE Team
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program. If not, see <https://www.gnu.org/licenses/>.

namespace VisualPinball.Unity.Hdrp
{
	public class HDRenderPipeline : IRenderPipeline
	{
		public string Name { get; } = "High Definition Render Pipeline";

		public RenderPipelineType Type { get; } = RenderPipelineType.Hdrp;
		public IMaterialConverter MaterialConverter { get; }
		public ILightConverter LightConverter { get; }

		public HDRenderPipeline()
		{
			MaterialConverter = new MaterialConverter();
			LightConverter = new LightConverter();
		}
	}
}
