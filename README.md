ObjectRec
=========

Application for object recognition using the Eigen value methodology with an histogram equalize image filter

Instructions:
Please download and use the Emgu OpenCV x86 files to ObjectRec/ObjectRecApp/x86 before running the application.
These files couldn't be included as there is an upload limit on GitHub.


Object recognition - in computer vision is the task of finding and identifying objects in an image or video sequence. Humans recognize a multitude of objects in images with little effort, despite the fact that the image of the objects may vary somewhat in different view points, in many different sizes / scale or even when they are translated or rotated. Objects can even be recognized when they are partially obstructed from view. This task is still a challenge for computer vision systems.

The project processes what we call eigenimages containing eigenvales. Compared to traditional approaches which use object geometry only (shape invariants), the implementation described uses the eigenspace deter-mined by processing the eigenvalues and eigenvectors of the image set. The image set is obtained by varying pose whilst maintaining a constant level of illumination in space, and the eigenspace is computed for each object of inter-est. For an unknown input image, the recognition algorithm projects this image to each eigenspace and the object is recognised using space partitioning meth-ods which determine the object and the position in space. Several experimen-tal results have been obtained to demonstrate the robustness of this method when applied to the robotic task. 
