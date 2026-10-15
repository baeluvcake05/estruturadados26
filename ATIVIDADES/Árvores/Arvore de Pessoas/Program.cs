using Arvores_de_Pessoas;

Console.WriteLine("Organograma da Empresa!");

Tree<string> tree = new Tree<string>();

// Raiz: CEO
tree.Root = new TreeNode<string>()
{
    Data = "Marcin Jamro - CEO"
};

// Funcionarios diretamente ligados ao CEO
tree.Root.Children = new List<TreeNode<string>>
{
    new TreeNode<string>()
    {
        Data = "John Smith - Head of Development",
        Parent = tree.Root
    },

    new TreeNode<string>()
    {
        Data = "Mary Fox - Head of Research",
        Parent = tree.Root
    },

    new TreeNode<string>()
    {
        Data = "Lily Smith - Head of Sales",
        Parent = tree.Root
    }
};

// Departamento de Desenvolvimento
tree.Root.Children[0].Children = new List<TreeNode<string>>
{
    new TreeNode<string>()
    {
        Data = "Chris Morris - Senior Developer",
        Parent = tree.Root.Children[0]
    }
};

tree.Root.Children[0].Children[0].Children =
    new List<TreeNode<string>>
{
    new TreeNode<string>()
    {
        Data = "Eric Green - Junior Developer",
        Parent = tree.Root.Children[0].Children[0]
    },

    new TreeNode<string>()
    {
        Data = "Ashley Lopez - Junior Developer",
        Parent = tree.Root.Children[0].Children[0]
    }
};

tree.Root.Children[0].Children[0].Children[1].Children =
    new List<TreeNode<string>>
{
    new TreeNode<string>()
    {
        Data = "Emily Young - Developer Intern",
        Parent = tree.Root.Children[0].Children[0].Children[1]
    }
};

// Departamento de Pesquisa
tree.Root.Children[1].Children = new List<TreeNode<string>>
{
    new TreeNode<string>()
    {
        Data = "Jimmy Stewart - Senior Researcher",
        Parent = tree.Root.Children[1]
    },

    new TreeNode<string>()
    {
        Data = "Andy Wood - Senior Researcher",
        Parent = tree.Root.Children[1]
    }
};

// Departamento de Vendas
tree.Root.Children[2].Children = new List<TreeNode<string>>
{
    new TreeNode<string>()
    {
        Data = "Anthony Black - Senior Sales Specialist",
        Parent = tree.Root.Children[2]
    },

    new TreeNode<string>()
    {
        Data = "Angela Evans - Senior Sales Specialist",
        Parent = tree.Root.Children[2]
    },

    new TreeNode<string>()
    {
        Data = "Tommy Butler - Senior Account Manager",
        Parent = tree.Root.Children[2]
    }
};

// Funcionarios subordinados a Anthony Black
tree.Root.Children[2].Children[0].Children =
    new List<TreeNode<string>>
{
    new TreeNode<string>()
    {
        Data = "Paula Scott - Junior Sales Specialist",
        Parent = tree.Root.Children[2].Children[0]
    },

    new TreeNode<string>()
    {
        Data = "Sarah Watson - Junior Sales Specialist",
        Parent = tree.Root.Children[2].Children[0]
    }
};