﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppAmalt.Dto
{
    public class GraphPoliticalDto
    {

        public int Communists { get; set; }
        public int Socialists { get; set; }
        public int Moderate { get; set; }
        public int Liberals { get; set; }
        public int Conservatives { get; set; }
        public int Indifferents { get; set; }

        public GraphPoliticalDto(int communists, int socialists, int moderate, int liberals, int conservatives, int indifferents)
        {
            Communists = communists;
            Socialists = socialists;
            Moderate = moderate;
            Liberals = liberals;
            Conservatives = conservatives;
            Indifferents = indifferents;
        }
    }
}
