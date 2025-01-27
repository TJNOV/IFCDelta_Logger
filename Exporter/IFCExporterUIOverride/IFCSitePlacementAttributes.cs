﻿//
// BIM IFC export alternate UI library: this library works with Autodesk(R) Revit(R) to provide an alternate user interface for the export of IFC files from Revit.
// Copyright (C) 2016  Autodesk, Inc.
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
//
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA
//

using BIM.IFC.Export.UI.Properties;
using Revit.IFC.Common.Enums;

namespace BIM.IFC.Export.UI
{

   public class IFCSitePlacementAttributes
   {

      public SiteTransformBasis TransformBasis { get; set; }

      public IFCSitePlacementAttributes(SiteTransformBasis transformBasis)
      {
         TransformBasis = transformBasis;
      }

      public override string ToString()
      {
         switch (TransformBasis)
         {
            case SiteTransformBasis.Shared:
               return Resources.SharedCoordinates;
            case SiteTransformBasis.Site:
               return Resources.SiteSurveyPoint;
            case SiteTransformBasis.Project:
               return Resources.ProjectBasePoint;
            case SiteTransformBasis.ProjectInTN:
               return Resources.ProjectInTN;
            case SiteTransformBasis.InternalInTN:
               return Resources.InternalCoordinatesInTN;
            default:
               return Resources.InternalCoordinates;
         }
      }
   }
}
