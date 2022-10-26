from pickle import FALSE
import numpy as np
import matplotlib.pyplot as plt
y = np.linspace(0, 2*np.pi, 101)
x1 = np.sin(y)
x2 = np.sinh(y)
ynumbers = np.linspace(0, 7, 15)
xnumbers = np.linspace(-1, 1, 11)
xnumbers = np.linspace(0, 300, 7)
fig, ax1 = plt.subplots()
ax2 = ax1.twiny()
curve1, =  ax1.plot(x1, y, label="sin", color='r')
curve2, = ax2.plot(x2, y, label="sinh", color='b')
curves = [curve1, curve2]
ax2.legend(curves, [curve.get_label() for curve in curves])
ax1.set_xlabel("Magnitude", color=curve1.get_color())
ax2.set_xlabel("Magnitude", color=curve2.get_color())
ax1.set_ylabel("angle/value", color=curve1.get_color())
ax1.tick_params(axis='y', color=curve1.get_color())
ax1.tick_params(axis='x', color=curve1.get_color())
ax2.tick_params(axis='x', color=curve2.get_color())
ax1.set_xticks(xnumbers)
ax2.set_xticks(xnumbers)
ax1.set_yticks(ynumbers)
ax1.grid(color=curve2.get_color())
ax2.grid(color=curve2.get_color())
ax1.xaxis.grid(FALSE)
plt.title("lester example graph")
plt.show()



