using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapColoring
{
    class ForwardChecking
    {
        bool isMapColoringPossible = true;
        bool isMapColored = false;
        List<Node> coloredNodes = new List<Node>();
        int noOfSteps = 0;
        Random rnd = new Random();
        public void setupDomain(List<Node> nodes)
        {
            List<string> colors = new List<string>();
            colors.Add("red");
            colors.Add("green");
            colors.Add("blue");

            for (int i = 0; i < nodes.Count; i++)
            {
                nodes[i].domain = colors;
                for (int j = 0; j < nodes[i].neighbor.Count; j++)
                {
                    nodes[i].neighbor[j].domain = colors;
                }
            }
        }
        public List<Node> Color(List<Node> nodes)
        {
            setupDomain(nodes);

            int r = rnd.Next(nodes.Count);
            List<Node> output = mapColoring(r, nodes);
            return output;
        }

        public List<Node> mapColoring(int index, List<Node> nodes)
        {
            noOfSteps++;
            if (isMapColored == false && noOfSteps < 100000 && isMapColoringPossible == true)
            {
                if (nodes[index].color.Equals("null"))
                {
                    if (nodes[index].domain.Count != 0)
                    {
                        int r = rnd.Next(nodes[index].domain.Count);
                        nodes[index].color = nodes[index].domain[r];
                        for (int j = 0; j < nodes[index].neighbor.Count; j++)
                        {
                            for (int k = 0; k < nodes.Count; k++)
                            {
                                if (index != k)
                                {
                                    if (nodes[index].neighbor[j].name.Equals(nodes[k].name))
                                        nodes[index].neighbor[j].color = nodes[k].color;
                                }
                            }
                        }

                        for (int i = 0; i < nodes[index].neighbor.Count; i++)
                        {
                            if (nodes[index].neighbor[i].color.Equals("null"))
                            {
                                List<string> originalDomain = new List<string>();
                                List<string> updatedDomain = new List<string>();

                                originalDomain = nodes[index].neighbor[i].domain;
                                updatedDomain = originalDomain.Where(d => (d.Equals(nodes[index].color) == false)).ToList();
                                nodes[index].neighbor[i].domain = updatedDomain;

                                for (int k = 0; k < nodes.Count; k++)
                                {
                                    string name = nodes[index].neighbor[i].name;
                                    if (nodes[k].name.Equals(name))
                                    {
                                        nodes[k].domain = updatedDomain;
                                    }
                                    for (int j = 0; j < nodes[k].neighbor.Count; j++)
                                    {
                                        if (nodes[k].neighbor[j].name.Equals(name))
                                        {
                                            nodes[k].neighbor[j].domain = updatedDomain;
                                        }
                                    }
                                }
                            }
                        }

                        nodes = nodes.OrderBy(n => n.domain.Count).ToList();
                        mapColoring(0, nodes);

                    }
                    else
                    {
                        isMapColoringPossible = false;
                    }
                }
                else if (index < nodes.Count - 1)
                {
                    mapColoring(index + 1, nodes);
                }
                else
                {
                    for (int i = 0; i < nodes.Count; i++)
                    {
                        if (!(nodes[i].color.Equals("null")))
                        {
                            isMapColored = true;
                        }
                        else
                        {
                            isMapColored = false;
                            break;
                        }
                    }
                }
            }

            return nodes;
        }
    }
}
