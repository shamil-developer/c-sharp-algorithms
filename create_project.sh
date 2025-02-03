mkdir $1
mkdir $1/src
cd $1
touch README.md
cd src
dotnet new sln --name $1
dotnet new console -n $1 -f net9.0 -o .
dotnet sln add $1.csproj
touch $1.cs
echo -e "namespace SelectionSort;\n\npublic class $1Algorithm\n{\n\n}" > $1Algorithm.cs
