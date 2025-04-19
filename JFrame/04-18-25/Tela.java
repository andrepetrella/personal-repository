import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class Tela extends JFrame{
    
    JTextField num1;
    JTextField num2;
    
    public Tela() {
        setVisible(true);
        setTitle("Tela 01");
        setSize(800, 500);
        setDefaultCloseOperator(JFrame.EXIT_ON_CLOSE);
        setResizable(false);
        setLocationRelativeTo(null);
        setLayout(null);
        
        JButton jButton = new JButton();
        jButton.setText("Somar");
        jButton.setBounds(300, 100, 250, 100); // (dist x, dist y, width, height)
        jButton.setFont(new Font("Arial", Font.BOLD, 30)); // (font family, type, size)
        jButton.setForeground(new Color(10, 10, 10)); // (r, g, b)
        jButton.setBackground(new Color(100, 50, 40));
        
        add(jButton);
        jButton.addActionListener(this::somar);
        
        Font italic_30_font = new Font("Arial", Font.ITALIC, 30);
        
        num1 = new JTextField("Número 1...");
        num1.setBounds(200, 300, 200, 120);
        num1.setFont(italic_30_font);
        
        num2 = new JTextField("Número 2...");
        num2.setBounds(600, 300, 200, 120);
        num2.setFont(italic_30_font);
        
        add(num1);
        add(num2);
    }
    
    private void somar(ActionEvent actionEvent) {
        try {
            Integer numero1 = Integer.parseInt(num1.getText());
            Integer numero2 = Integer.parseInt(num2.getText());
            Integer soma = numero1 + numero2;
            JOptionPane.showMessageDialog(null, "Soma: " + soma, "Soma", JOptionPane.INFORMATION_MESSAGE);
        } catch (NumberFormatException e) {
            JOptionPane.showMessageDialog(null, "Insira números válidos...", "Erro!", JOptionPane.ERROR_MESSAGE);
        }
    }
          }
