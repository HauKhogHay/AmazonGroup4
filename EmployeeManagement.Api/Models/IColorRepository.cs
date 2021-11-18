using Amazon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon.Api
{
    public interface IColorRepository
    {
        IEnumerable<Color> GetColors();
        Color GetColor(int colorId);
    }
}
