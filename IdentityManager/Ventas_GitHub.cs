int filasel= tabla2.getSelectedRow();
        int confirmado = JOptionPane.showConfirmDialog(this,"Estaras seguro");
        if (JOptionPane.OK_OPTION == confirmado){
           String  cod=(String)tabla2.getValueAt(filasel, 0);
             String eliminarSQL="DELETE FROM ventas WHERE codigo_inscripcion= '"+cod+"'";
               String eliminarSQL1="DELETE FROM segundoB WHERE codigo_inscripcion= '"+cod+"'";
            String eliminarSQL2="DELETE FROM datosAlumnos WHERE codigo_inscripcion= '"+cod+"'";
                   try {
             PreparedStatement pst  = cn.prepareStatement(eliminarSQL);
                 PreparedStatement ps = cn.prepareStatement(eliminarSQL2);
                   PreparedStatement psM = cn.prepareStatement(eliminarSQL1);
                          
          pst.executeUpdate();
           ps.executeUpdate();
           psM.executeUpdate();
     
            JOptionPane.showMessageDialog(null, "Borrado");
         
            } 
            catch (Exception e) {
            JOptionPane.showMessageDialog(null, e);
            }
        }else{
            System.out.println("Eliminación cancelada.");
        }
