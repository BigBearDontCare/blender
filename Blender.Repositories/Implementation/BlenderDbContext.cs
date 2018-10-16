using System;
using Blender.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Blender.Repositories.Implementation
{
  public class BlenderDbContext : DbContext, IBlenderDbContext
  {
  }
}
