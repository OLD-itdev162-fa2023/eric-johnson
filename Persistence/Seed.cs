using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if (!context.Posts.Any())
            {
                var Posts = new List<Post>
                {
                    new Post {
                        Title = "First Post",
                        Body = "In hac habitasse platea dictumst. Nullam vulputate ligula non ante posuere, ac vulputate nisi fermentum. Mauris cursus ex et lectus egestas, consectetur dignissim magna elementum. Sed odio erat, elementum vehicula luctus eget, cursus quis nisi. Vestibulum quis libero maximus, ornare dui ac, aliquam enim. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Donec leo nibh, tincidunt mattis dui eget, iaculis congue nisi. Aenean a lorem quis dolor consequat hendrerit ac sit amet nibh.",
                        Date = DateTime.Now.AddDays(-10)
                        },
                    new Post {
                        Title = "Second Post",
                        Body = "Nunc et egestas nulla. Donec at ornare enim. Sed convallis, libero sit amet viverra viverra, ligula orci tempor elit, vitae hendrerit ipsum enim vitae ante. Duis feugiat, orci sed accumsan mollis, ante risus vehicula nisi, sed vehicula ipsum sapien sit amet lacus. Suspendisse iaculis nisl nec quam maximus tempor. Nunc efficitur mauris nec felis lacinia fermentum. Curabitur efficitur ligula vitae vehicula maximus. Aenean purus diam, dictum eu purus a, interdum iaculis sapien. Integer id tortor eu sapien dapibus aliquam. Sed dictum magna eu justo placerat, id sodales leo cursus. Etiam sodales at magna mattis faucibus.",
                        Date = DateTime.Now.AddDays(-7)
                        },
                    new Post {
                        Title = "Third Post",
                        Body = "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Pellentesque cursus, lorem finibus luctus aliquam, metus ligula volutpat massa, sed euismod elit nibh sit amet elit. Nulla posuere nibh nec quam luctus varius. Curabitur eu aliquam felis. Vivamus vestibulum semper tortor nec feugiat. Mauris congue scelerisque quam eleifend dictum. Donec vel convallis risus, et ullamcorper quam. Duis eu bibendum tellus. Integer lectus lacus, feugiat ac dui vel, semper pharetra turpis.",
                        Date = DateTime.Now.AddDays(-4)
                        }
                };

                context.Posts.AddRange(Posts);
                context.SaveChanges();
            }
        }
    }
}