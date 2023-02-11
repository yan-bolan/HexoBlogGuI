using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using Blog;
using System.Security.Policy;
using static System.Runtime.InteropServices.JavaScript.JSType;
using YamlDotNet.Serialization;
using Markdig;
using Markdig.Extensions.Yaml;
using Markdig.Syntax;
//using Blog.Properties;

namespace ChiSaTo
{
    internal class Blog_Main
    {
        MyService service;
        public string Base_addr;
        public string Base_post_addr;
        public string Post_Content=string.Empty;

        public Blog_Main() {
            service = ServiceProviderFactory.ServiceProvider.GetRequiredService<MyService>(); // use namespace   static class 
            Base_addr =  service.getBlogAddr();
            Base_post_addr = Path.Combine(Base_addr, "source", "_posts");//multi arg avoid linux and window different
        }
       public  void main(Enum_Blog value, string title )
        { 
            //Console.OutputEncoding = System.Text.Encoding.UTF8;//输出编码;
            //Console.InputEncoding = System.Text.Encoding.Unicode;//输入编码
            Console.WriteLine($"Blog addr:{Base_addr}");
            //var value = Prompt.Select<Enum_Blog>("Select  journey");
            Console.WriteLine($"You selected {value}");
            switch (value)
            {
                case Enum_Blog.New_Post:
                    {
                        #region new_post
                        #region input info
                        //string? title = string.Empty;
                        //while (true)
                        //{
                        //    Console.WriteLine("Please input article title (press enter confirm): ");//输入文章标题：
                        //    title = Console.ReadLine();
                        //    if (!string.IsNullOrWhiteSpace(title))
                        //    {
                        //        break;
                        //    }
                        //}

                        #endregion

                        string command = $" hexo new \"{title}\" &exit";
                        Process process = new Process();
                        process.StartInfo.WorkingDirectory = Base_addr;
                        process.StartInfo.FileName = "CMD.exe";
                        process.StartInfo.Arguments = " /k " + command;
                        process.Start();
                        process.WaitForExit();


                        string[] files = GetLatestFiles(Base_post_addr, 1);

                        string fullfilename = files[0];// Path.Combine(Base_addr, "source\\_posts", title + ".md");
                        open_md_file(fullfilename);// open md file;

                        #endregion
                    }
                    break;
                case Enum_Blog.open_dir:
                    Process.Start("explorer.exe", Base_post_addr);

                    break;
                case Enum_Blog.ls_post:
                      //md_file_latest = GetLatestFiles(Base_post_addr, 100).Select(x => Path.GetFileName(x)).ToList();
                    //string file_name = Prompt.Select("Select/Search your  file to continue", md_file_latest, 5);
                    //Process.Start("explorer.exe", Path.Combine(Base_post_addr, file_name));
                    break;
                case Enum_Blog.New_Post_by_file:
                    {
                        string folderName = this.Base_post_addr;

                        string pathString =  Path.Combine(folderName,title+".md" );
                        File.Create(pathString).Close();
                        if (File.Exists(pathString))
                        {
                            File.WriteAllLines(pathString, new string[] { Post_Content });
                            open_md_file(pathString); 
                        }
                        
                    }
                    break;
                default:
                    break;
            }

            Console.WriteLine("😊 Enjoy your writing ☆*: .｡. o(≧▽≦)o .｡.:*☆ \n Good bye!");

        }

        

        void open_md_file(string path)
        {
            Console.WriteLine($"open the file {path}");
            Process.Start(service.getmdEditor(), path);

            //Process p = new Process();
            //p.StartInfo.UseShellExecute = false;
            //p.StartInfo = new ProcessStartInfo(path);
            //p.Start();
        }

       public string[] GetLatestFiles(string Path, int count)
        {

            if (!Directory.Exists(Path))
            {

                return new string[] { }; 
            }
            var query = (from f in Directory.GetFiles(Path)
                         let fi = new FileInfo(f)
                         orderby fi.CreationTime descending
                         select fi.FullName).Take(count);
            return query.ToArray();
        }


       
    }
    public enum Enum_Blog
    {
        [Display(Name = "New post")]
        New_Post,
        [Display(Name = "Open article directory")]
        open_dir,
        [Display(Name = "Open recent file")]
        ls_post,
        [Display(Name = "New post by file")]
        New_Post_by_file
    }
    public static class MarkdownExtensions
    {
        private static readonly IDeserializer YamlDeserializer =
            new DeserializerBuilder()
            .IgnoreUnmatchedProperties()
            .Build();

        private static readonly MarkdownPipeline Pipeline
            = new MarkdownPipelineBuilder()
            .UseYamlFrontMatter()
            .Build();

        public static T GetFrontMatter<T>(this string markdown)
        {
            var document = Markdown.Parse(markdown, Pipeline);
            var block = document
                .Descendants<YamlFrontMatterBlock>()
                .FirstOrDefault();

            if (block == null)
                return default;

            var yaml =
                block
                // this is not a mistake
                // we have to call .Lines 2x
                .Lines // StringLineGroup[]
                .Lines // StringLine[]
                .OrderByDescending(x => x.Line)
                .Select(x => $"{x}\n")
                .ToList()
                .Select(x => x.Replace("---", string.Empty))
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .Aggregate((s, agg) => agg + s);

            return YamlDeserializer.Deserialize<T>(yaml);
        }
   
    }
}
