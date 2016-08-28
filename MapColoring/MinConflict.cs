using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapColoring
{
    class MinConflict
    {
        List<Node> sortedNodes = new List<Node>();
        Random rnd = new Random();
        string[] colors = { "red", "green", "blue" };
        bool isMapColored = false;
        int noOfSteps = 0;
        string getRandomColor(string[] colors)
        {

            int r = rnd.Next(colors.Length);
            return colors[r];
        }
        public void setupData(List<Node> nodes)
        {
            for (int i = 0; i < nodes.Count; i++)
            {
                string color = getRandomColor(colors);
                nodes[i].color = color;

            }
        }
        public List<Node> Color(List<Node> nodes)
        {
            if (isMapColored == false && noOfSteps <= 10000)
            {
                for (int i = 0; i < sortedNodes.Count; i++)
                {
                    sortedNodes[i].noOfConflicts = 0;
                }

                if (noOfSteps == 0)
                {
                    setupData(nodes);
                }
                noOfSteps++;
                for (int i = 0; i < nodes.Count; i++)
                {
                    for (int j = 0; j < nodes[i].neighbor.Count; j++)
                    {
                        for (int k = 0; k < nodes.Count; k++)
                        {
                            if (i != k)
                            {
                                if (nodes[i].neighbor[j].name.Equals(nodes[k].name))
                                    nodes[i].neighbor[j].color = nodes[k].color;
                            }
                        }
                    }
                }


                for (int i = 0; i < nodes.Count; i++)
                {
                    for (int j = 0; j < nodes[i].neighbor.Count; j++)
                    {
                        if (nodes[i].color.Equals(nodes[i].neighbor[j].color))
                        {
                            nodes[i].noOfConflicts++;
                        }
                    }

                }
                for (int i = 0; i < nodes.Count; i++)
                {
                    if (nodes[i].noOfConflicts == 0)
                        isMapColored = true;
                    else
                    {
                        isMapColored = false;
                        break;
                    }
                }
                if (isMapColored == false)
                {
                    int minConflictNode = 0;
                    sortedNodes = nodes.OrderBy(n => n.noOfConflicts).ToList();
                    for (int i = 0; i < sortedNodes.Count; i++)
                    {
                        if (sortedNodes[i].noOfConflicts != 0)
                        {
                            minConflictNode = i;
                            break;
                        }
                    }
                    string minConflictNodeColor = sortedNodes[minConflictNode].color;
                    string[] colorsModified = new string[3];
                    foreach (var item in colorsModified)
                    {

                        colorsModified = colors.Where(c => (c.Equals(minConflictNodeColor) == false)).ToArray();


                    }
                    sortedNodes[minConflictNode].color = getRandomColor(colorsModified);
                    for (int i = 0; i < sortedNodes.Count; i++)
                    {
                        for (int j = 0; j < sortedNodes[i].neighbor.Count; j++)
                        {
                            for (int k = 0; k < sortedNodes.Count; k++)
                            {
                                if (i != k)
                                {
                                    if (sortedNodes[i].neighbor[j].name.Equals(sortedNodes[k].name))
                                        sortedNodes[i].neighbor[j].color = sortedNodes[k].color;
                                }
                            }
                        }
                    }

                    Color(sortedNodes);
                }

            }
            return sortedNodes;
        }
    }
}
