﻿using System.Data.Entity.Spatial;
using GeoJSON.Net.Contrib.EntityFramework.WkbConversions;
using GeoJSON.Net.Geometry;

namespace GeoJSON.Net.Contrib.EntityFramework
{
    public static partial class EntityFrameworkConvert
    {
        public static DbGeography ToDbGeography(this IGeometryObject geometryObject)
        {
            return DbGeography.FromBinary(WkbEncode.Encode(geometryObject));
        }
    }
}
