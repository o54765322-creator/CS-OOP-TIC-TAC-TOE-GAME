using System;
using System.Collections.Generic;

class P {
    public string n;
    public string s;
    public int c;
    
    public P(string name, string symbol) {
        n = name;
        s = symbol;
        c = 0;
    }
}

class B {
    public string[] b = new string[9] {" ", " ", " ", " ", " ", " ", " ", " ", " "};
    
    public void p() {
        Console.WriteLine("\n");
        for (int i = 0; i < 9; i += 3) {
            Console.WriteLine($" {b[i]} | {b[i+1]} | {b[i+2]} ");
            if (i < 6) {
                Console.WriteLine("-----------");
            }
        }
    }
    
    public bool m(int i, string s) {
        if (b[i] == " ") {
            b[i] = s;
            return true;
        }
        return false;
    }
    
    public string w() {
        int[][] c = new int[][] {
            new int[] {0,1,2}, new int[] {3,4,5}, new int[] {6,7,8},
            new int[] {0,3,6}, new int[] {1,4,7}, new int[] {2,5,8},
            new int[] {0,4,8}, new int[] {2,4,6}
        };
        
        foreach (int[] x in c) {
            if (b[x[0]] != " " && 
                b[x[0]] == b[x[1]] && 
                b[x[1]] == b[x[2]]) {
                return b[x[0]];
            }
        }
        return null;
    }
    
    public bool f() {
        foreach (string cell in b) {
            if (cell == " ") return false;
        }
        return true;
    }
    
    public void r() {
        for (int i = 0; i < 9; i++) {
            b[i] = " ";
        }
    }
}

class G {
    public B b = new B();
    public List<P> p = new List<P>();
    public int t = 0;
    
    public void s() {
        Console.WriteLine("=== TIC TAC TOE ===");
        
        Console.Write("P1 name: ");
        string n1 = Console.ReadLine();
        Console.Write("P2 name: ");
        string n2 = Console.ReadLine();
        
        p.Add(new P(n1, "X"));
        p.Add(new P(n2, "O"));
        
        Console.WriteLine($"\n{n1} = X, {n2} = O");
    }
    
    public void g() {
        s();
        
        while (true) {
            b.p();
            
            P x = p[t];
            Console.WriteLine($"\n{x.n}'s turn ({x.s})");
            
            try {
                Console.Write("Pos (1-9): ");
                int i = int.Parse(Console.ReadLine()) - 1;
                
                if (i < 0 || i > 8) {
                    Console.WriteLine("Use 1-9!");
                    continue;
                }
                
                if (b.m(i, x.s)) {
                    string win = b.w();
                    
                    if (win != null) {
                        b.p();
                        Console.WriteLine($"\n🎉 {x.n} wins! 🎉");
                        x.c++;
                        sc();
                        break;
                    }
                    else if (b.f()) {
                        b.p();
                        Console.WriteLine("\nTie!");
                        sc();
                        break;
                    }
                    
                    t = 1 - t;
                }
                else {
                    Console.WriteLine("Spot taken!");
                }
            }
            catch {
                Console.WriteLine("Enter number!");
            }
        }
    }
    
    public void sc() {
        Console.WriteLine("\n--- SCORE ---");
        foreach (P x in p) {
            Console.WriteLine($"{x.n}: {x.c}");
        }
    }
    
    public bool rep() {
        while (true) {
            Console.Write("\nAgain? (y/n): ");
            string a = Console.ReadLine().ToLower();
            if (a == "y") {
                b.r();
                t = 0;
                return true;
            }
            else if (a == "n") {
                Console.WriteLine("Thanks!");
                return false;
            }
            else {
                Console.WriteLine("y or n only");
            }
        }
    }
    
    static void Main() {
        G g = new G();
        g.g();
        
        while (g.rep()) {
            g.g();
        }
    }
}