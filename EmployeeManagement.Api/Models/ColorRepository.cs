using Amazon.Api.Models;
using Amazon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon.Api
{
    public class ColorRepository : IColorRepository
    {
        private readonly AppDbContext appDbContext;

        public ColorRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public Color GetColor(int colorId)
        {
            return appDbContext.Colors
                .FirstOrDefault(d => d.ColorId == colorId);
        }

        public IEnumerable<Color> GetColors()
        {
            return appDbContext.Colors;
        }
    }
}
