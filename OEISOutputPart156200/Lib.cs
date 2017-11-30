using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A199305
{
public static readonly long[] Value={ 5L,11L,101L,151L,1151L,1511L,10151L,10501L,11551L,15101L,15511L,15551L,100511L,110051L,115001L,150011L,150151L,151051L,1001551L,1051051L,1055501L,1115551L,1150151L,1150511L,1501501L,1510511L,1550551L,1551001L,1551551L,1555111L,10000511L,10011101L,10011511L,10055011L,10101551L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199305Inst : IEnumerable<long>
{
public static readonly long[] Value=A199305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199305.Bytes);
public long this[int i]=>Value[i];

public static A199305Inst Instance=new A199305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199306
{
public static readonly long[] Value={ 11L,101L,1061L,1601L,10061L,10601L,11161L,16001L,16061L,16111L,16661L,101611L,106661L,116101L,166601L,1011601L,1016011L,1016611L,1061101L,1066111L,1106101L,1110611L,1111661L,1116601L,1160111L,1160611L,1166101L,1600061L,1611161L,1616161L,1660661L,1661111L,10011101L,10100161L,10106111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199306Inst : IEnumerable<long>
{
public static readonly long[] Value=A199306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199306.Bytes);
public long this[int i]=>Value[i];

public static A199306Inst Instance=new A199306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199307
{
public static readonly long[] Value={ 5L,109L,257L,1373L,2917L,4001L,27437L,62501L,157217L,202613L,237277L,296353L,470597L,629857L,665501L,1492993L,1556069L,1898209L,2456501L,2634013L,3217429L,3322337L,4244833L,5038849L,5180117L,6572129L,10512289L,11453153L,12706093L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199307Inst : IEnumerable<long>
{
public static readonly long[] Value=A199307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199307.Bytes);
public long this[int i]=>Value[i];

public static A199307Inst Instance=new A199307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199308
{
public static readonly long[] Value={ 2L,9L,44L,219L,1094L,5469L,27344L,136719L,683594L,3417969L,17089844L,85449219L,427246094L,2136230469L,10681152344L,53405761719L,267028808594L,1335144042969L,6675720214844L,33378601074219L,166893005371094L,834465026855469L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199308Inst : IEnumerable<long>
{
public static readonly long[] Value=A199308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199308.Bytes);
public long this[int i]=>Value[i];

public static A199308Inst Instance=new A199308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199309
{
public static readonly long[] Value={ 4L,18L,88L,438L,2188L,10938L,54688L,273438L,1367188L,6835938L,34179688L,170898438L,854492188L,4272460938L,21362304688L,106811523438L,534057617188L,2670288085938L,13351440429688L,66757202148438L,333786010742188L,1668930053710938L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199309Inst : IEnumerable<long>
{
public static readonly long[] Value=A199309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199309.Bytes);
public long this[int i]=>Value[i];

public static A199309Inst Instance=new A199309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199310
{
public static readonly long[] Value={ 8L,36L,176L,876L,4376L,21876L,109376L,546876L,2734376L,13671876L,68359376L,341796876L,1708984376L,8544921876L,42724609376L,213623046876L,1068115234376L,5340576171876L,26702880859376L,133514404296876L,667572021484376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199310Inst : IEnumerable<long>
{
public static readonly long[] Value=A199310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199310.Bytes);
public long this[int i]=>Value[i];

public static A199310Inst Instance=new A199310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199311
{
public static readonly long[] Value={ 9L,41L,201L,1001L,5001L,25001L,125001L,625001L,3125001L,15625001L,78125001L,390625001L,1953125001L,9765625001L,48828125001L,244140625001L,1220703125001L,6103515625001L,30517578125001L,152587890625001L,762939453125001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199311Inst : IEnumerable<long>
{
public static readonly long[] Value=A199311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199311.Bytes);
public long this[int i]=>Value[i];

public static A199311Inst Instance=new A199311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199312
{
public static readonly long[] Value={ 5L,23L,113L,563L,2813L,14063L,70313L,351563L,1757813L,8789063L,43945313L,219726563L,1098632813L,5493164063L,27465820313L,137329101563L,686645507813L,3433227539063L,17166137695313L,85830688476563L,429153442382813L,2145767211914063L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199312Inst : IEnumerable<long>
{
public static readonly long[] Value=A199312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199312.Bytes);
public long this[int i]=>Value[i];

public static A199312Inst Instance=new A199312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199313
{
public static readonly long[] Value={ 10L,46L,226L,1126L,5626L,28126L,140626L,703126L,3515626L,17578126L,87890626L,439453126L,2197265626L,10986328126L,54931640626L,274658203126L,1373291015626L,6866455078126L,34332275390626L,171661376953126L,858306884765626L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199313Inst : IEnumerable<long>
{
public static readonly long[] Value=A199313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199313.Bytes);
public long this[int i]=>Value[i];

public static A199313Inst Instance=new A199313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199314
{
public static readonly long[] Value={ 3L,14L,69L,344L,1719L,8594L,42969L,214844L,1074219L,5371094L,26855469L,134277344L,671386719L,3356933594L,16784667969L,83923339844L,419616699219L,2098083496094L,10490417480469L,52452087402344L,262260437011719L,1311302185058594L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199314Inst : IEnumerable<long>
{
public static readonly long[] Value=A199314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199314.Bytes);
public long this[int i]=>Value[i];

public static A199314Inst Instance=new A199314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199315
{
public static readonly long[] Value={ 6L,28L,138L,688L,3438L,17188L,85938L,429688L,2148438L,10742188L,53710938L,268554688L,1342773438L,6713867188L,33569335938L,167846679688L,839233398438L,4196166992188L,20980834960938L,104904174804688L,524520874023438L,2622604370117188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199315Inst : IEnumerable<long>
{
public static readonly long[] Value=A199315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199315.Bytes);
public long this[int i]=>Value[i];

public static A199315Inst Instance=new A199315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199316
{
public static readonly long[] Value={ 12L,56L,276L,1376L,6876L,34376L,171876L,859376L,4296876L,21484376L,107421876L,537109376L,2685546876L,13427734376L,67138671876L,335693359376L,1678466796876L,8392333984376L,41961669921876L,209808349609376L,1049041748046876L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199316Inst : IEnumerable<long>
{
public static readonly long[] Value=A199316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199316.Bytes);
public long this[int i]=>Value[i];

public static A199316Inst Instance=new A199316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199317
{
public static readonly long[] Value={ 3L,13L,73L,433L,2593L,15553L,93313L,559873L,3359233L,20155393L,120932353L,725594113L,4353564673L,26121388033L,156728328193L,940369969153L,5642219814913L,33853318889473L,203119913336833L,1218719480020993L,7312316880125953L,43873901280755713L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199317Inst : IEnumerable<long>
{
public static readonly long[] Value=A199317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199317.Bytes);
public long this[int i]=>Value[i];

public static A199317Inst Instance=new A199317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199318
{
public static readonly long[] Value={ 4L,19L,109L,649L,3889L,23329L,139969L,839809L,5038849L,30233089L,181398529L,1088391169L,6530347009L,39182082049L,235092492289L,1410554953729L,8463329722369L,50779978334209L,304679870005249L,1828079220031489L,10968475320188929L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199318Inst : IEnumerable<long>
{
public static readonly long[] Value=A199318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199318.Bytes);
public long this[int i]=>Value[i];

public static A199318Inst Instance=new A199318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199319
{
public static readonly long[] Value={ 5L,25L,145L,865L,5185L,31105L,186625L,1119745L,6718465L,40310785L,241864705L,1451188225L,8707129345L,52242776065L,313456656385L,1880739938305L,11284439629825L,67706637778945L,406239826673665L,2437438960041985L,14624633760251905L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199319Inst : IEnumerable<long>
{
public static readonly long[] Value=A199319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199319.Bytes);
public long this[int i]=>Value[i];

public static A199319Inst Instance=new A199319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199320
{
public static readonly long[] Value={ 6L,31L,181L,1081L,6481L,38881L,233281L,1399681L,8398081L,50388481L,302330881L,1813985281L,10883911681L,65303470081L,391820820481L,2350924922881L,14105549537281L,84633297223681L,507799783342081L,3046798700052481L,18280792200314881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199320Inst : IEnumerable<long>
{
public static readonly long[] Value=A199320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199320.Bytes);
public long this[int i]=>Value[i];

public static A199320Inst Instance=new A199320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199321
{
public static readonly long[] Value={ 8L,43L,253L,1513L,9073L,54433L,326593L,1959553L,11757313L,70543873L,423263233L,2539579393L,15237476353L,91424858113L,548549148673L,3291294892033L,19747769352193L,118486616113153L,710919696678913L,4265518180073473L,25593109080440833L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199321Inst : IEnumerable<long>
{
public static readonly long[] Value=A199321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199321.Bytes);
public long this[int i]=>Value[i];

public static A199321Inst Instance=new A199321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199322
{
public static readonly long[] Value={ 1L,1L,2L,0L,1L,1L,1L,1L,2L,0L,2L,1L,2L,1L,2L,1L,1L,1L,0L,2L,1L,1L,1L,3L,1L,0L,1L,3L,1L,0L,3L,2L,1L,1L,4L,0L,2L,2L,2L,2L,2L,2L,2L,2L,5L,1L,3L,1L,0L,2L,4L,2L,0L,2L,2L,3L,4L,3L,3L,2L,2L,4L,4L,5L,1L,4L,2L,3L,2L,3L,1L,1L,5L,3L,2L,2L,2L,3L,2L,2L,6L,4L,1L,2L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199322Inst : IEnumerable<long>
{
public static readonly long[] Value=A199322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199322.Bytes);
public long this[int i]=>Value[i];

public static A199322Inst Instance=new A199322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199323
{
public static readonly long[] Value={ 1L,2L,3L,2L,3L,4L,3L,4L,5L,3L,5L,5L,5L,5L,6L,5L,6L,6L,6L,8L,8L,5L,7L,10L,7L,8L,7L,10L,7L,9L,11L,10L,8L,9L,13L,5L,11L,12L,14L,8L,12L,11L,8L,13L,14L,10L,13L,15L,9L,11L,19L,13L,12L,12L,12L,13L,16L,14L,16L,16L,13L,18L,15L,16L,12L,17L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199323Inst : IEnumerable<long>
{
public static readonly long[] Value=A199323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199323.Bytes);
public long this[int i]=>Value[i];

public static A199323Inst Instance=new A199323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199324
{
public static readonly long[] Value={ 1L,-1L,1L,0L,-1L,1L,1L,-1L,-1L,1L,-1L,3L,-2L,-1L,1L,0L,-2L,5L,-3L,-1L,1L,1L,-2L,-2L,7L,-4L,-1L,1L,-1L,5L,-7L,-1L,9L,-5L,-1L,1L,0L,-3L,12L,-15L,1L,11L,-6L,-1L,1L,1L,-3L,-3L,21L,-26L,4L,13L,-7L,-1L,1L,-1L,7L,-15L,3L,31L,-40L,8L,15L,-8L,-1L,1L,0L,-4L,22L,-42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199324Inst : IEnumerable<long>
{
public static readonly long[] Value=A199324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199324.Bytes);
public long this[int i]=>Value[i];

public static A199324Inst Instance=new A199324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199325
{
public static readonly long[] Value={ 5L,11L,101L,151L,1051L,1151L,1511L,5011L,5051L,5101L,5501L,10111L,10151L,10501L,11551L,15101L,15511L,15551L,50051L,50101L,50111L,50551L,51001L,51151L,51511L,51551L,55001L,55051L,55501L,55511L,100151L,100501L,100511L,101051L,101111L,101501L,110051L,110501L,115001L,115151L,150001L,150011L,150151L,150551L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199325Inst : IEnumerable<long>
{
public static readonly long[] Value=A199325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199325.Bytes);
public long this[int i]=>Value[i];

public static A199325Inst Instance=new A199325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199326
{
public static readonly long[] Value={ 11L,61L,101L,601L,661L,1061L,1601L,6011L,6101L,6661L,10061L,10111L,10601L,11161L,16001L,16061L,16111L,16661L,60101L,60161L,60601L,60611L,60661L,61001L,66161L,66601L,101111L,101161L,101611L,106661L,110161L,111611L,116101L,160001L,161611L,166601L,600011L,600101L,600601L,601061L,610661L,611011L,611101L,611111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199326Inst : IEnumerable<long>
{
public static readonly long[] Value=A199326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199326.Bytes);
public long this[int i]=>Value[i];

public static A199326Inst Instance=new A199326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199327
{
public static readonly long[] Value={ 7L,11L,17L,71L,101L,107L,701L,1117L,1171L,1777L,7001L,7177L,7717L,10007L,10111L,10177L,10711L,10771L,11071L,11117L,11171L,11177L,11701L,11717L,11777L,17011L,17077L,17107L,17117L,17707L,70001L,70111L,70117L,70177L,70717L,71011L,71171L,71707L,71711L,71777L,77017L,77101L,77171L,77711L,101107L,101111L,101117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199327Inst : IEnumerable<long>
{
public static readonly long[] Value=A199327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199327.Bytes);
public long this[int i]=>Value[i];

public static A199327Inst Instance=new A199327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199328
{
public static readonly long[] Value={ 11L,101L,181L,1181L,1811L,18181L,108881L,110881L,118081L,180181L,180811L,181081L,188011L,188801L,1008001L,1088081L,1110881L,1180811L,1181881L,1808801L,1880111L,1880881L,1881811L,1881881L,10001081L,10001801L,10011101L,10080011L,10101181L,10111001L,10111081L,10180801L,10188811L,10808101L,10810001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199328Inst : IEnumerable<long>
{
public static readonly long[] Value=A199328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199328.Bytes);
public long this[int i]=>Value[i];

public static A199328Inst Instance=new A199328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199329
{
public static readonly long[] Value={ 11L,19L,101L,109L,191L,199L,911L,919L,991L,1009L,1019L,1091L,1109L,1901L,1999L,9001L,9011L,9091L,9109L,9199L,9901L,10009L,10091L,10099L,10111L,10909L,11119L,11909L,19001L,19009L,19919L,19991L,90001L,90011L,90019L,90191L,90199L,90901L,90911L,91009L,91019L,91099L,91199L,91909L,99109L,99119L,99191L,99901L,99991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199329Inst : IEnumerable<long>
{
public static readonly long[] Value=A199329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199329.Bytes);
public long this[int i]=>Value[i];

public static A199329Inst Instance=new A199329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199330
{
public static readonly long[] Value={ 0L,1L,484L,1156L,2116L,4900L,16900L,30625L,41209L,765625L,12027024L,45346756L,94303521L,1188939361L,2144430864L,3475809936L,6168531600L,26159180644L,211618400400L,483560298225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199330Inst : IEnumerable<long>
{
public static readonly long[] Value=A199330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199330.Bytes);
public long this[int i]=>Value[i];

public static A199330Inst Instance=new A199330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199331
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,2L,0L,1L,2L,2L,2L,2L,0L,3L,4L,3L,2L,0L,2L,4L,4L,2L,2L,3L,4L,5L,6L,4L,0L,2L,6L,6L,4L,2L,6L,6L,4L,5L,8L,7L,4L,2L,8L,10L,6L,5L,2L,5L,6L,4L,10L,6L,4L,4L,10L,12L,12L,2L,6L,10L,6L,7L,8L,9L,6L,5L,12L,14L,10L,6L,6L,7L,8L,7L,10L,10L,6L,4L,14L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199331Inst : IEnumerable<long>
{
public static readonly long[] Value=A199331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199331.Bytes);
public long this[int i]=>Value[i];

public static A199331Inst Instance=new A199331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199332
{
public static readonly long[] Value={ 1L,2L,3L,4L,4L,4L,5L,6L,7L,8L,9L,9L,9L,9L,9L,10L,11L,12L,13L,14L,15L,16L,16L,16L,16L,16L,16L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,25L,25L,25L,25L,25L,25L,25L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,37L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199332Inst : IEnumerable<long>
{
public static readonly long[] Value=A199332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199332.Bytes);
public long this[int i]=>Value[i];

public static A199332Inst Instance=new A199332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199333
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,5L,7L,5L,1L,1L,7L,13L,13L,7L,1L,1L,11L,23L,29L,23L,11L,1L,1L,13L,37L,53L,53L,37L,13L,1L,1L,17L,53L,97L,107L,97L,53L,17L,1L,1L,19L,71L,151L,211L,211L,151L,71L,19L,1L,1L,23L,97L,223L,367L,431L,367L,223L,97L,23L,1L,1L,29L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199333Inst : IEnumerable<long>
{
public static readonly long[] Value=A199333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199333.Bytes);
public long this[int i]=>Value[i];

public static A199333Inst Instance=new A199333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199334
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,3L,2L,3L,5L,8L,3L,5L,8L,13L,21L,5L,8L,13L,21L,34L,55L,8L,13L,21L,34L,55L,89L,144L,13L,21L,34L,55L,89L,144L,233L,377L,21L,34L,55L,89L,144L,233L,377L,610L,987L,34L,55L,89L,144L,233L,377L,610L,987L,1597L,2584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199334Inst : IEnumerable<long>
{
public static readonly long[] Value=A199334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199334.Bytes);
public long this[int i]=>Value[i];

public static A199334Inst Instance=new A199334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199335
{
public static readonly long[] Value={ 1L,0L,2L,0L,2L,4L,0L,2L,14L,8L,0L,2L,36L,66L,16L,0L,2L,82L,342L,262L,32L,0L,2L,176L,1436L,2416L,946L,64L,0L,2L,366L,5364L,16844L,14394L,3222L,128L,0L,2L,748L,18654L,99560L,156190L,76908L,10562L,256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199335Inst : IEnumerable<long>
{
public static readonly long[] Value=A199335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199335.Bytes);
public long this[int i]=>Value[i];

public static A199335Inst Instance=new A199335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199336
{
public static readonly long[] Value={ 1L,3L,5L,23L,39L,181L,307L,1425L,2417L,11219L,19029L,88327L,149815L,695397L,1179491L,5474849L,9286113L,43103395L,73109413L,339352311L,575589191L,2671715093L,4531604115L,21034368433L,35677243729L,165603232371L,280886345717L,1303791490535L,2211413522007L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199336Inst : IEnumerable<long>
{
public static readonly long[] Value=A199336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199336.Bytes);
public long this[int i]=>Value[i];

public static A199336Inst Instance=new A199336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199337
{
public static readonly long[] Value={ 0L,1L,3L,3L,8L,3L,14L,9L,12L,8L,26L,4L,37L,14L,8L,18L,53L,12L,67L,8L,14L,26L,86L,9L,54L,37L,40L,14L,107L,8L,122L,51L,26L,53L,14L,12L,145L,67L,37L,11L,163L,14L,180L,26L,13L,86L,202L,18L,107L,54L,53L,37L,222L,40L,26L,15L,67L,107L,252L,8L,275L,122L,16L,79L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199337Inst : IEnumerable<long>
{
public static readonly long[] Value=A199337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199337.Bytes);
public long this[int i]=>Value[i];

public static A199337Inst Instance=new A199337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199338
{
public static readonly long[] Value={ 1L,11L,19L,89L,151L,701L,1189L,5519L,9361L,43451L,73699L,342089L,580231L,2693261L,4568149L,21203999L,35964961L,166938731L,283151539L,1314305849L,2229247351L,10347508061L,17550827269L,81465758639L,138177370801L,641378561051L,1087868139139L,5049562729769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199338Inst : IEnumerable<long>
{
public static readonly long[] Value=A199338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199338.Bytes);
public long this[int i]=>Value[i];

public static A199338Inst Instance=new A199338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199339
{
public static readonly long[] Value={ 1L,0L,-1L,-2L,-1L,0L,1L,2L,1L,0L,1L,2L,1L,0L,-1L,0L,1L,0L,-1L,0L,1L,2L,1L,0L,1L,2L,3L,4L,5L,4L,5L,4L,3L,2L,3L,2L,1L,2L,3L,2L,1L,2L,1L,0L,-1L,-2L,-1L,-2L,-3L,-4L,-3L,-2L,-3L,-2L,-1L,-2L,-3L,-2L,-1L,-2L,-3L,-2L,-1L,-2L,-3L,-4L,-5L,-6L,-5L,-4L,-5L,-6L,-5L,-6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199339Inst : IEnumerable<long>
{
public static readonly long[] Value=A199339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199339.Bytes);
public long this[int i]=>Value[i];

public static A199339Inst Instance=new A199339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199340
{
public static readonly long[] Value={ 3L,43L,433L,443L,3343L,3433L,4003L,30403L,33343L,33403L,34033L,34303L,34403L,40343L,40433L,43003L,43403L,300043L,300343L,304033L,304303L,304433L,330433L,333433L,334043L,334333L,334403L,343303L,343333L,343433L,400033L,403003L,403043L,403433L,430303L,430333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199340Inst : IEnumerable<long>
{
public static readonly long[] Value=A199340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199340.Bytes);
public long this[int i]=>Value[i];

public static A199340Inst Instance=new A199340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199341
{
public static readonly long[] Value={ 3L,11L,13L,31L,41L,43L,113L,131L,311L,313L,331L,431L,433L,443L,1433L,3313L,3331L,3343L,3413L,3433L,4111L,4133L,4441L,11113L,11131L,11311L,11411L,11443L,13313L,13331L,13411L,13441L,14143L,14341L,14411L,14431L,31333L,33113L,33311L,33331L,33343L,33413L,34141L,34313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199341Inst : IEnumerable<long>
{
public static readonly long[] Value=A199341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199341.Bytes);
public long this[int i]=>Value[i];

public static A199341Inst Instance=new A199341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199342
{
public static readonly long[] Value={ 2L,3L,23L,43L,223L,233L,433L,443L,2243L,2333L,2423L,3323L,3343L,3433L,4243L,4423L,22343L,22433L,23333L,24223L,24443L,32233L,32323L,32423L,32443L,33223L,33343L,42223L,42323L,42433L,42443L,43223L,222323L,223243L,223423L,224233L,224423L,224443L,232333L,232433L,233323L,233423L,234323L,234343L,242243L,243233L,243343L,243433L,244243L,244333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199342Inst : IEnumerable<long>
{
public static readonly long[] Value=A199342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199342.Bytes);
public long this[int i]=>Value[i];

public static A199342Inst Instance=new A199342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199343
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,18L,11L,12L,13L,14L,15L,16L,17L,18L,19L,28L,21L,22L,23L,24L,25L,26L,27L,28L,29L,38L,31L,32L,33L,34L,35L,36L,37L,38L,39L,48L,41L,42L,43L,44L,45L,46L,47L,48L,49L,58L,51L,52L,53L,54L,55L,56L,57L,58L,59L,68L,61L,62L,63L,64L,65L,66L,67L,68L,69L,78L,71L,72L,73L,74L,75L,76L,77L,78L,79L,88L,81L,82L,83L,84L,85L,86L,87L,88L,89L,98L,91L,92L,93L,94L,95L,96L,97L,98L,99L,189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199343Inst : IEnumerable<long>
{
public static readonly long[] Value=A199343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199343.Bytes);
public long this[int i]=>Value[i];

public static A199343Inst Instance=new A199343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199344
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,19L,11L,12L,13L,14L,15L,16L,17L,18L,19L,29L,21L,22L,23L,24L,25L,26L,27L,28L,29L,39L,31L,32L,33L,34L,35L,36L,37L,38L,39L,49L,41L,42L,43L,44L,45L,46L,47L,48L,49L,59L,51L,52L,53L,54L,55L,56L,57L,58L,59L,69L,61L,62L,63L,64L,65L,66L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199344Inst : IEnumerable<long>
{
public static readonly long[] Value=A199344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199344.Bytes);
public long this[int i]=>Value[i];

public static A199344Inst Instance=new A199344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199345
{
public static readonly long[] Value={ 3L,5L,43L,53L,353L,433L,443L,3343L,3433L,3533L,5333L,5443L,33343L,33353L,33533L,34543L,35353L,35533L,35543L,43543L,44453L,44533L,44543L,45343L,45433L,45533L,45553L,53353L,53453L,54443L,55333L,55343L,333433L,333533L,334333L,335453L,343333L,343433L,343543L,344353L,344453L,344543L,345533L,353333L,353443L,353453L,354353L,354443L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199345Inst : IEnumerable<long>
{
public static readonly long[] Value=A199345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199345.Bytes);
public long this[int i]=>Value[i];

public static A199345Inst Instance=new A199345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199346
{
public static readonly long[] Value={ 3L,43L,433L,443L,463L,643L,3343L,3433L,3463L,3643L,4363L,4463L,4643L,4663L,6343L,33343L,36343L,36433L,36643L,43633L,44633L,46633L,46643L,46663L,63443L,63463L,64333L,64433L,64633L,64663L,66343L,66463L,66643L,333433L,334333L,334363L,334643L,336463L,336643L,343333L,343433L,344363L,346433L,363343L,363463L,364333L,364433L,364643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199346Inst : IEnumerable<long>
{
public static readonly long[] Value=A199346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199346.Bytes);
public long this[int i]=>Value[i];

public static A199346Inst Instance=new A199346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199347
{
public static readonly long[] Value={ 3L,7L,37L,43L,47L,73L,337L,347L,373L,433L,443L,733L,743L,773L,3343L,3347L,3373L,3433L,3733L,4337L,4373L,4447L,4733L,7333L,7433L,7477L,33343L,33347L,33377L,33773L,34337L,34747L,37337L,37447L,37747L,43777L,44773L,44777L,47737L,47743L,47777L,73433L,73477L,74377L,74747L,77347L,77377L,77447L,77477L,77743L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199347Inst : IEnumerable<long>
{
public static readonly long[] Value=A199347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199347.Bytes);
public long this[int i]=>Value[i];

public static A199347Inst Instance=new A199347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199348
{
public static readonly long[] Value={ 3L,43L,83L,383L,433L,443L,883L,3343L,3433L,3833L,4483L,8443L,33343L,34483L,34843L,34883L,38333L,38833L,44383L,44483L,44843L,48383L,48883L,83383L,83443L,83833L,83843L,84443L,88843L,88883L,333383L,333433L,334333L,334843L,338383L,343333L,343433L,344483L,344843L,348433L,348443L,348833L,348883L,383483L,383833L,384343L,384383L,388483L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199348Inst : IEnumerable<long>
{
public static readonly long[] Value=A199348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199348.Bytes);
public long this[int i]=>Value[i];

public static A199348Inst Instance=new A199348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199349
{
public static readonly long[] Value={ 3L,43L,349L,433L,439L,443L,449L,499L,3343L,3433L,3449L,3499L,3943L,4339L,4349L,4493L,4933L,4943L,4993L,4999L,9343L,9349L,9433L,9439L,9949L,33343L,33349L,33493L,34439L,34499L,34939L,34949L,39343L,39439L,39443L,39499L,43399L,43499L,43933L,43943L,44449L,44939L,49333L,49339L,49393L,49433L,49499L,49939L,49943L,49993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199349Inst : IEnumerable<long>
{
public static readonly long[] Value=A199349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199349.Bytes);
public long this[int i]=>Value[i];

public static A199349Inst Instance=new A199349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199350
{
public static readonly long[] Value={ 1L,1L,1L,1L,10L,45L,105L,105L,1155L,5505L,13080L,12861L,154461L,769156L,1854541L,1809031L,22802779L,116526114L,283442460L,275058672L,3579775668L,18616654026L,45557997404L,44051920784L,586402520543L,3088257174951L,7590707929300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199350Inst : IEnumerable<long>
{
public static readonly long[] Value=A199350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199350.Bytes);
public long this[int i]=>Value[i];

public static A199350Inst Instance=new A199350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199351
{
public static readonly long[] Value={ 1L,1L,45L,105L,4251L,9175L,447916L,958259L,50233308L,106354160L,5897448012L,12409253763L,715649665145L,1498983975673L,89063549460702L,185913744482294L,11306002322078532L,23537550026903929L,1458334886366979145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199351Inst : IEnumerable<long>
{
public static readonly long[] Value=A199351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199351.Bytes);
public long this[int i]=>Value[i];

public static A199351Inst Instance=new A199351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199352
{
public static readonly BigInteger[] Value={ 1L,45L,930L,7945L,808721L,36379420L,821116806L,7583425311L,911983726469L,45130187288722L,1066404844359923L,10007712190029813L,1299200253416601860L,BigInteger.Parse("67226145153865158217"),BigInteger.Parse("1626281528857502520213"),BigInteger.Parse("15397791355704316162481") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199352Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199352.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199352Inst Instance=new A199352Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199353
{
public static readonly long[] Value={ 1L,105L,7945L,705263L,66367192L,6518500460L,661357976129L,68780790321431L,7293552029780267L,785674669296654053L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199353Inst : IEnumerable<long>
{
public static readonly long[] Value=A199353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199353.Bytes);
public long this[int i]=>Value[i];

public static A199353Inst Instance=new A199353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199354
{
public static readonly long[] Value={ 10L,4251L,808721L,66367192L,71245512532L,32990481786550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199354Inst : IEnumerable<long>
{
public static readonly long[] Value=A199354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199354.Bytes);
public long this[int i]=>Value[i];

public static A199354Inst Instance=new A199354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199355
{
public static readonly long[] Value={ 45L,9175L,36379420L,6518500460L,32990481786550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199355Inst : IEnumerable<long>
{
public static readonly long[] Value=A199355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199355.Bytes);
public long this[int i]=>Value[i];

public static A199355Inst Instance=new A199355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199356
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,45L,45L,1L,10L,105L,930L,105L,10L,45L,4251L,7945L,7945L,4251L,45L,105L,9175L,808721L,705263L,808721L,9175L,105L,105L,447916L,36379420L,66367192L,66367192L,36379420L,447916L,105L,1155L,958259L,821116806L,6518500460L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199356Inst : IEnumerable<long>
{
public static readonly long[] Value=A199356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199356.Bytes);
public long this[int i]=>Value[i];

public static A199356Inst Instance=new A199356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199357
{
public static readonly BigInteger[] Value={ 1L,12L,112L,102L,11112L,123L,1111112L,10002L,1012L,11122L,11111111112L,1123L,1111111111112L,10000002L,111122L,10112L,11111111111111112L,1023L,1111111111111111112L,11123L,1111122L,100000000002L,BigInteger.Parse("11111111111111111111112") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199357Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199357.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199357Inst Instance=new A199357Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199358
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,4L,6L,4L,1L,10L,45L,105L,105L,735L,1935L,2270L,1001L,8854L,30961L,50669L,32706L,268440L,834720L,1164240L,614040L,5334840L,17805870L,27047395L,15771356L,135370824L,441296296L,646979039L,359653541L,3137738964L,10425704337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199358Inst : IEnumerable<long>
{
public static readonly long[] Value=A199358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199358.Bytes);
public long this[int i]=>Value[i];

public static A199358Inst Instance=new A199358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199359
{
public static readonly long[] Value={ 0L,0L,0L,5L,35L,11L,455L,2645L,32075L,21689L,904145L,2158685L,43508750L,36780344L,1476986472L,2347455892L,64539882234L,62222755553L,2415617534402L,3140426826416L,101999195453788L,105327949061765L,4032779888481758L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199359Inst : IEnumerable<long>
{
public static readonly long[] Value=A199359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199359.Bytes);
public long this[int i]=>Value[i];

public static A199359Inst Instance=new A199359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199360
{
public static readonly long[] Value={ 0L,0L,20L,23L,1655L,39597L,336788L,2130707L,97253704L,2328983293L,27777628803L,109663812046L,7330508486557L,181851333483598L,2032109646360324L,8979878533633165L,588003317861300327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199360Inst : IEnumerable<long>
{
public static readonly long[] Value=A199360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199360.Bytes);
public long this[int i]=>Value[i];

public static A199360Inst Instance=new A199360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199361
{
public static readonly long[] Value={ 0L,5L,23L,2857L,37995L,2838998L,76784986L,4127669738L,153225233815L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199361Inst : IEnumerable<long>
{
public static readonly long[] Value=A199361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199361.Bytes);
public long this[int i]=>Value[i];

public static A199361Inst Instance=new A199361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199362
{
public static readonly long[] Value={ 0L,35L,1655L,37995L,21988792L,3215936151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199362Inst : IEnumerable<long>
{
public static readonly long[] Value=A199362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199362.Bytes);
public long this[int i]=>Value[i];

public static A199362Inst Instance=new A199362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199363
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,5L,20L,5L,0L,0L,35L,23L,23L,35L,0L,0L,11L,1655L,2857L,1655L,11L,0L,1L,455L,39597L,37995L,37995L,39597L,455L,1L,4L,2645L,336788L,2838998L,21988792L,2838998L,336788L,2645L,4L,6L,32075L,2130707L,76784986L,3215936151L,3215936151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199363Inst : IEnumerable<long>
{
public static readonly long[] Value=A199363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199363.Bytes);
public long this[int i]=>Value[i];

public static A199363Inst Instance=new A199363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199364
{
public static readonly long[] Value={ 0L,1L,5L,10L,14L,20L,28L,34L,38L,49L,55L,59L,61L,80L,98L,103L,118L,133L,145L,146L,154L,160L,185L,196L,206L,224L,229L,241L,245L,250L,251L,320L,325L,334L,376L,383L,385L,388L,398L,416L,418L,440L,451L,454L,475L,476L,481L,488L,490L,493L,496L,500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199364Inst : IEnumerable<long>
{
public static readonly long[] Value=A199364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199364.Bytes);
public long this[int i]=>Value[i];

public static A199364Inst Instance=new A199364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199365
{
public static readonly long[] Value={ 3L,7L,503L,4003L,10979L,32003L,87811L,157219L,219491L,470599L,665503L,821519L,907927L,2048003L,3764771L,4370911L,6572131L,9410551L,12194503L,12448547L,14609059L,16384003L,25326503L,30118147L,34967267L,44957699L,48035959L,55990087L,58824503L,62500003L,63253007L,131072003L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199365Inst : IEnumerable<long>
{
public static readonly long[] Value=A199365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199365.Bytes);
public long this[int i]=>Value[i];

public static A199365Inst Instance=new A199365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199366
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,11L,12L,15L,18L,30L,32L,45L,48L,51L,63L,66L,87L,90L,98L,101L,113L,116L,122L,125L,132L,150L,153L,155L,156L,161L,170L,171L,173L,183L,195L,198L,203L,213L,233L,237L,243L,246L,260L,266L,282L,288L,291L,297L,300L,302L,305L,308L,321L,335L,341L,342L,347L,366L,371L,377L,381L,386L,393L,398L,401L,402L,407L,408L,411L,423L,425L,426L,437L,443L,452L,455L,456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199366Inst : IEnumerable<long>
{
public static readonly long[] Value=A199366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199366.Bytes);
public long this[int i]=>Value[i];

public static A199366Inst Instance=new A199366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199367
{
public static readonly long[] Value={ 3L,31L,107L,499L,863L,5323L,6911L,13499L,23327L,107999L,131071L,364499L,442367L,530603L,1000187L,1149983L,2634011L,2915999L,3764767L,4121203L,5771587L,6243583L,7263391L,7812499L,9199871L,13499999L,14326307L,14895499L,15185663L,16693123L,19651999L,20000843L,20710867L,24513947L,29659499L,31049567L,33461707L,38654387L,50597347L,53248211L,57395627L,59547743L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199367Inst : IEnumerable<long>
{
public static readonly long[] Value=A199367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199367.Bytes);
public long this[int i]=>Value[i];

public static A199367Inst Instance=new A199367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199368
{
public static readonly long[] Value={ 2L,14L,16L,22L,25L,29L,49L,64L,74L,77L,86L,91L,112L,121L,127L,134L,137L,140L,151L,161L,179L,197L,214L,221L,226L,254L,259L,284L,287L,296L,302L,305L,310L,347L,361L,364L,365L,380L,382L,392L,394L,401L,406L,407L,415L,469L,497L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199368Inst : IEnumerable<long>
{
public static readonly long[] Value=A199368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199368.Bytes);
public long this[int i]=>Value[i];

public static A199368Inst Instance=new A199368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199369
{
public static readonly long[] Value={ 29L,10973L,16381L,42589L,62497L,97553L,470593L,1048573L,1620893L,1826129L,2544221L,3014281L,5619709L,7086241L,8193529L,9624413L,10285409L,10975997L,13771801L,16693121L,22941353L,30581489L,39201373L,43175441L,46172701L,65548253L,69495913L,91625213L,94559609L,103737341L,110174429L,113490497L,119163997L,167127689L,188183521L,192914173L,194508497L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199369Inst : IEnumerable<long>
{
public static readonly long[] Value=A199369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199369.Bytes);
public long this[int i]=>Value[i];

public static A199369Inst Instance=new A199369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199370
{
public static readonly long[] Value={ 7L,2L,2L,5L,8L,7L,5L,4L,9L,9L,2L,2L,5L,2L,4L,7L,6L,8L,3L,5L,5L,9L,3L,2L,8L,7L,2L,8L,7L,7L,1L,9L,6L,7L,5L,5L,1L,5L,9L,6L,4L,5L,9L,2L,1L,1L,4L,3L,9L,4L,2L,6L,9L,8L,0L,7L,7L,6L,5L,1L,4L,7L,6L,0L,2L,5L,9L,0L,9L,4L,2L,5L,0L,7L,3L,1L,6L,0L,1L,8L,3L,0L,3L,4L,3L,5L,6L,2L,9L,4L,1L,8L,7L,2L,7L,9L,8L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199370Inst : IEnumerable<long>
{
public static readonly long[] Value=A199370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199370.Bytes);
public long this[int i]=>Value[i];

public static A199370Inst Instance=new A199370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199371
{
public static readonly long[] Value={ 1L,0L,4L,6L,1L,8L,6L,2L,2L,9L,5L,0L,6L,2L,9L,1L,9L,7L,7L,8L,9L,9L,6L,4L,8L,5L,7L,8L,3L,5L,9L,6L,9L,6L,3L,7L,9L,0L,8L,6L,7L,8L,8L,1L,2L,4L,8L,0L,0L,3L,0L,3L,7L,2L,5L,6L,6L,4L,1L,1L,9L,8L,6L,7L,3L,7L,8L,8L,6L,9L,9L,0L,5L,9L,2L,4L,3L,7L,8L,2L,2L,0L,8L,9L,8L,6L,0L,4L,9L,1L,9L,9L,0L,1L,1L,4L,3L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199371Inst : IEnumerable<long>
{
public static readonly long[] Value=A199371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199371.Bytes);
public long this[int i]=>Value[i];

public static A199371Inst Instance=new A199371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199372
{
public static readonly long[] Value={ 1L,3L,1L,4L,6L,3L,4L,1L,7L,1L,9L,8L,5L,6L,7L,8L,9L,4L,9L,0L,3L,3L,6L,4L,1L,2L,8L,2L,5L,8L,7L,7L,6L,6L,9L,2L,2L,1L,4L,3L,0L,4L,9L,5L,3L,4L,9L,4L,1L,8L,8L,2L,4L,9L,3L,6L,9L,2L,4L,1L,0L,2L,5L,7L,2L,5L,6L,5L,9L,9L,6L,9L,1L,5L,4L,7L,0L,9L,3L,7L,1L,3L,2L,9L,1L,9L,7L,5L,0L,1L,1L,2L,7L,8L,7L,8L,8L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199372Inst : IEnumerable<long>
{
public static readonly long[] Value=A199372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199372.Bytes);
public long this[int i]=>Value[i];

public static A199372Inst Instance=new A199372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199373
{
public static readonly long[] Value={ 5L,8L,8L,5L,9L,1L,4L,1L,0L,8L,1L,7L,1L,5L,4L,5L,0L,6L,4L,3L,1L,7L,7L,3L,6L,2L,3L,7L,1L,2L,7L,8L,6L,7L,0L,5L,4L,4L,1L,7L,7L,2L,9L,6L,6L,5L,6L,1L,2L,7L,9L,9L,0L,6L,4L,8L,0L,6L,0L,5L,9L,6L,1L,9L,5L,6L,4L,5L,9L,4L,8L,1L,3L,4L,2L,1L,9L,5L,0L,8L,3L,2L,0L,1L,2L,6L,3L,1L,4L,5L,2L,9L,6L,9L,4L,7L,6L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199373Inst : IEnumerable<long>
{
public static readonly long[] Value=A199373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199373.Bytes);
public long this[int i]=>Value[i];

public static A199373Inst Instance=new A199373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199374
{
public static readonly long[] Value={ 8L,5L,0L,0L,7L,4L,7L,5L,9L,9L,6L,3L,1L,0L,1L,7L,0L,7L,4L,5L,0L,5L,8L,0L,6L,1L,6L,8L,2L,6L,7L,8L,1L,3L,9L,4L,1L,9L,9L,6L,6L,9L,7L,0L,2L,3L,0L,0L,2L,6L,2L,7L,3L,2L,3L,7L,6L,5L,4L,3L,7L,7L,7L,1L,4L,3L,0L,3L,2L,7L,6L,0L,1L,5L,6L,8L,7L,3L,9L,4L,2L,2L,2L,3L,9L,8L,9L,3L,2L,7L,4L,6L,7L,9L,5L,3L,0L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199374Inst : IEnumerable<long>
{
public static readonly long[] Value=A199374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199374.Bytes);
public long this[int i]=>Value[i];

public static A199374Inst Instance=new A199374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199375
{
public static readonly long[] Value={ 1L,0L,6L,5L,5L,0L,3L,7L,7L,3L,5L,3L,6L,3L,2L,9L,2L,2L,3L,6L,9L,1L,1L,4L,3L,4L,0L,4L,8L,5L,4L,4L,2L,5L,6L,2L,5L,6L,6L,8L,6L,9L,5L,5L,7L,6L,1L,8L,5L,7L,2L,9L,5L,2L,6L,5L,9L,0L,5L,8L,5L,7L,6L,4L,6L,6L,5L,2L,5L,5L,9L,4L,7L,3L,1L,0L,7L,4L,9L,3L,7L,0L,2L,6L,5L,5L,6L,3L,9L,7L,0L,9L,8L,3L,9L,9L,2L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199375Inst : IEnumerable<long>
{
public static readonly long[] Value=A199375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199375.Bytes);
public long this[int i]=>Value[i];

public static A199375Inst Instance=new A199375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199376
{
public static readonly long[] Value={ 5L,0L,8L,1L,6L,1L,6L,5L,6L,9L,6L,8L,3L,9L,1L,9L,1L,8L,1L,2L,7L,7L,6L,7L,6L,2L,9L,3L,4L,0L,9L,9L,2L,4L,4L,6L,1L,3L,6L,4L,6L,2L,2L,3L,5L,6L,6L,3L,4L,8L,5L,0L,7L,9L,3L,7L,3L,5L,3L,6L,0L,4L,4L,1L,9L,7L,0L,5L,4L,8L,3L,2L,4L,5L,5L,9L,7L,4L,7L,6L,4L,0L,3L,1L,3L,4L,8L,5L,0L,1L,5L,8L,1L,2L,5L,5L,9L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199376Inst : IEnumerable<long>
{
public static readonly long[] Value=A199376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199376.Bytes);
public long this[int i]=>Value[i];

public static A199376Inst Instance=new A199376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199377
{
public static readonly long[] Value={ 7L,3L,1L,3L,0L,6L,0L,7L,2L,6L,9L,9L,4L,8L,0L,6L,1L,6L,8L,6L,0L,5L,5L,7L,1L,0L,6L,4L,2L,2L,8L,8L,1L,9L,4L,9L,9L,4L,3L,4L,4L,4L,5L,0L,8L,8L,9L,0L,1L,4L,8L,9L,2L,6L,0L,2L,0L,0L,4L,4L,3L,1L,9L,6L,9L,7L,5L,9L,7L,8L,8L,3L,8L,1L,3L,5L,6L,3L,5L,4L,1L,3L,4L,6L,0L,2L,2L,8L,2L,9L,3L,8L,5L,0L,1L,6L,6L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199377Inst : IEnumerable<long>
{
public static readonly long[] Value=A199377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199377.Bytes);
public long this[int i]=>Value[i];

public static A199377Inst Instance=new A199377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199378
{
public static readonly long[] Value={ 9L,1L,2L,8L,2L,0L,7L,1L,7L,4L,4L,6L,3L,9L,5L,3L,5L,1L,1L,5L,3L,5L,0L,7L,0L,7L,9L,7L,7L,8L,2L,2L,8L,0L,5L,2L,8L,8L,3L,9L,3L,5L,5L,9L,6L,6L,5L,9L,6L,1L,3L,6L,7L,9L,3L,7L,1L,5L,5L,7L,9L,9L,2L,1L,9L,4L,8L,9L,3L,1L,3L,7L,9L,3L,5L,6L,0L,7L,1L,4L,5L,1L,6L,7L,8L,4L,2L,9L,4L,0L,6L,2L,2L,6L,8L,3L,1L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199378Inst : IEnumerable<long>
{
public static readonly long[] Value=A199378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199378.Bytes);
public long this[int i]=>Value[i];

public static A199378Inst Instance=new A199378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199379
{
public static readonly long[] Value={ 5L,8L,2L,7L,8L,1L,0L,7L,2L,5L,1L,9L,8L,0L,9L,7L,6L,1L,0L,6L,7L,1L,4L,0L,6L,0L,6L,2L,2L,3L,0L,5L,7L,2L,5L,4L,5L,3L,9L,9L,5L,2L,7L,7L,4L,4L,8L,6L,2L,8L,8L,8L,0L,0L,5L,1L,3L,3L,2L,8L,7L,1L,9L,4L,1L,4L,4L,6L,5L,4L,3L,9L,2L,8L,8L,0L,3L,9L,7L,3L,8L,7L,4L,7L,5L,6L,2L,2L,5L,0L,7L,1L,4L,6L,4L,3L,1L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199379Inst : IEnumerable<long>
{
public static readonly long[] Value=A199379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199379.Bytes);
public long this[int i]=>Value[i];

public static A199379Inst Instance=new A199379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199380
{
public static readonly long[] Value={ 8L,3L,2L,1L,0L,1L,8L,4L,8L,7L,9L,2L,1L,4L,9L,1L,5L,3L,6L,4L,7L,9L,4L,0L,4L,7L,8L,9L,1L,7L,9L,8L,7L,1L,6L,5L,2L,1L,5L,6L,1L,9L,1L,3L,8L,1L,9L,9L,0L,3L,3L,1L,5L,2L,9L,0L,9L,5L,2L,5L,9L,1L,2L,4L,9L,4L,2L,7L,0L,0L,7L,6L,9L,6L,8L,7L,1L,5L,1L,3L,4L,9L,5L,0L,5L,4L,6L,6L,2L,5L,8L,1L,3L,1L,9L,4L,8L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199380Inst : IEnumerable<long>
{
public static readonly long[] Value=A199380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199380.Bytes);
public long this[int i]=>Value[i];

public static A199380Inst Instance=new A199380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199381
{
public static readonly long[] Value={ 1L,0L,2L,9L,1L,2L,4L,9L,2L,1L,9L,6L,6L,9L,0L,6L,9L,8L,6L,1L,7L,1L,3L,5L,9L,2L,3L,7L,7L,8L,9L,1L,1L,6L,4L,0L,8L,4L,8L,1L,1L,7L,1L,1L,8L,4L,1L,1L,8L,6L,4L,2L,6L,8L,0L,4L,2L,9L,8L,1L,5L,5L,2L,1L,4L,5L,3L,3L,8L,7L,2L,1L,8L,6L,1L,3L,6L,2L,0L,6L,4L,7L,3L,3L,0L,4L,8L,4L,2L,2L,9L,1L,5L,4L,8L,2L,8L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199381Inst : IEnumerable<long>
{
public static readonly long[] Value=A199381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199381.Bytes);
public long this[int i]=>Value[i];

public static A199381Inst Instance=new A199381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199382
{
public static readonly long[] Value={ 5L,0L,5L,3L,3L,6L,8L,3L,9L,3L,7L,9L,1L,7L,2L,1L,1L,8L,3L,1L,9L,6L,2L,7L,1L,0L,4L,7L,5L,9L,3L,7L,9L,6L,8L,7L,2L,8L,0L,4L,2L,3L,4L,0L,6L,0L,2L,0L,5L,9L,7L,6L,5L,5L,8L,4L,6L,7L,0L,4L,0L,0L,5L,3L,8L,1L,2L,5L,4L,7L,0L,3L,2L,7L,6L,7L,1L,7L,8L,6L,7L,3L,0L,2L,4L,6L,5L,9L,5L,2L,3L,9L,4L,4L,6L,4L,8L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199382Inst : IEnumerable<long>
{
public static readonly long[] Value=A199382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199382.Bytes);
public long this[int i]=>Value[i];

public static A199382Inst Instance=new A199382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199383
{
public static readonly long[] Value={ 8L,9L,5L,2L,1L,9L,7L,4L,4L,4L,3L,5L,8L,2L,0L,0L,1L,2L,9L,7L,0L,8L,7L,2L,7L,4L,6L,3L,6L,1L,9L,6L,5L,9L,6L,7L,4L,8L,9L,0L,5L,6L,5L,3L,0L,4L,3L,5L,7L,4L,1L,0L,0L,1L,8L,6L,6L,7L,9L,3L,6L,9L,1L,0L,6L,5L,5L,4L,5L,5L,2L,3L,7L,6L,2L,5L,2L,8L,2L,2L,5L,9L,2L,7L,6L,5L,9L,5L,5L,5L,9L,1L,4L,5L,1L,6L,2L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199383Inst : IEnumerable<long>
{
public static readonly long[] Value=A199383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199383.Bytes);
public long this[int i]=>Value[i];

public static A199383Inst Instance=new A199383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199384
{
public static readonly long[] Value={ 4L,5L,1L,8L,0L,1L,2L,3L,4L,3L,3L,3L,7L,3L,7L,4L,0L,6L,1L,3L,1L,3L,3L,7L,2L,4L,2L,9L,8L,3L,0L,8L,1L,3L,6L,6L,9L,8L,9L,3L,2L,6L,6L,9L,2L,4L,2L,7L,1L,7L,1L,5L,3L,1L,1L,3L,6L,6L,5L,4L,2L,3L,3L,9L,6L,9L,5L,4L,6L,0L,8L,2L,7L,9L,8L,0L,4L,3L,6L,4L,6L,3L,1L,9L,3L,2L,6L,5L,7L,0L,6L,5L,5L,1L,7L,3L,1L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199384Inst : IEnumerable<long>
{
public static readonly long[] Value=A199384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199384.Bytes);
public long this[int i]=>Value[i];

public static A199384Inst Instance=new A199384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199385
{
public static readonly long[] Value={ 6L,4L,5L,7L,8L,0L,5L,7L,5L,3L,1L,6L,3L,3L,7L,5L,4L,1L,7L,5L,6L,0L,6L,6L,8L,8L,8L,2L,6L,2L,7L,3L,6L,3L,2L,4L,5L,9L,5L,5L,7L,5L,1L,7L,5L,0L,0L,8L,6L,3L,8L,1L,5L,8L,4L,9L,0L,3L,0L,0L,1L,1L,7L,0L,8L,5L,0L,7L,0L,8L,3L,3L,8L,9L,5L,0L,9L,6L,7L,1L,2L,3L,4L,0L,1L,1L,4L,6L,0L,4L,0L,3L,0L,2L,4L,5L,8L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199385Inst : IEnumerable<long>
{
public static readonly long[] Value=A199385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199385.Bytes);
public long this[int i]=>Value[i];

public static A199385Inst Instance=new A199385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199386
{
public static readonly long[] Value={ 7L,9L,9L,7L,6L,4L,4L,1L,3L,6L,2L,7L,4L,4L,7L,3L,8L,5L,1L,1L,7L,6L,8L,7L,7L,1L,4L,9L,9L,8L,7L,4L,4L,7L,2L,1L,3L,0L,0L,1L,3L,2L,8L,8L,2L,8L,7L,3L,6L,7L,3L,5L,9L,6L,3L,8L,0L,2L,4L,5L,1L,9L,5L,3L,5L,3L,9L,0L,5L,9L,8L,6L,2L,2L,6L,4L,6L,1L,3L,3L,4L,5L,2L,3L,0L,0L,1L,4L,8L,8L,9L,4L,4L,3L,6L,8L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199386Inst : IEnumerable<long>
{
public static readonly long[] Value=A199386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199386.Bytes);
public long this[int i]=>Value[i];

public static A199386Inst Instance=new A199386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199387
{
public static readonly long[] Value={ 5L,0L,2L,6L,1L,8L,9L,1L,1L,5L,3L,2L,6L,5L,2L,2L,1L,2L,7L,7L,8L,6L,8L,6L,3L,1L,1L,9L,2L,1L,3L,7L,4L,4L,6L,1L,3L,0L,5L,5L,0L,5L,5L,8L,8L,6L,4L,4L,9L,4L,2L,7L,4L,3L,4L,1L,1L,0L,2L,1L,8L,2L,9L,2L,9L,4L,8L,6L,1L,1L,7L,0L,0L,3L,5L,3L,1L,0L,1L,2L,7L,1L,2L,5L,7L,8L,9L,6L,0L,5L,6L,6L,4L,9L,7L,3L,6L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199387Inst : IEnumerable<long>
{
public static readonly long[] Value=A199387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199387.Bytes);
public long this[int i]=>Value[i];

public static A199387Inst Instance=new A199387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199388
{
public static readonly long[] Value={ 7L,1L,4L,5L,5L,4L,7L,9L,9L,6L,0L,8L,4L,7L,7L,0L,3L,9L,1L,2L,2L,3L,9L,8L,5L,6L,4L,7L,7L,0L,8L,2L,5L,9L,8L,4L,8L,5L,7L,5L,9L,8L,7L,4L,4L,8L,9L,5L,1L,3L,0L,5L,0L,9L,4L,8L,9L,7L,4L,0L,9L,6L,9L,5L,1L,4L,8L,1L,0L,8L,3L,3L,4L,8L,3L,1L,3L,5L,9L,7L,9L,9L,8L,9L,5L,1L,3L,1L,2L,7L,8L,0L,0L,9L,6L,2L,5L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199388Inst : IEnumerable<long>
{
public static readonly long[] Value=A199388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199388.Bytes);
public long this[int i]=>Value[i];

public static A199388Inst Instance=new A199388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199389
{
public static readonly long[] Value={ 8L,7L,9L,7L,8L,0L,6L,2L,6L,6L,2L,1L,0L,3L,3L,4L,8L,6L,7L,1L,5L,9L,0L,0L,2L,7L,0L,5L,5L,5L,0L,2L,6L,6L,9L,9L,6L,2L,3L,7L,9L,2L,8L,8L,5L,5L,9L,9L,9L,1L,1L,9L,2L,4L,8L,0L,8L,0L,5L,6L,6L,2L,1L,7L,2L,3L,9L,3L,9L,6L,7L,2L,7L,6L,5L,3L,0L,3L,1L,7L,7L,6L,4L,8L,1L,1L,9L,1L,5L,2L,1L,3L,8L,9L,2L,1L,2L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199389Inst : IEnumerable<long>
{
public static readonly long[] Value=A199389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199389.Bytes);
public long this[int i]=>Value[i];

public static A199389Inst Instance=new A199389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199390
{
public static readonly long[] Value={ 4L,5L,0L,2L,3L,5L,3L,1L,6L,4L,0L,0L,3L,2L,0L,4L,4L,6L,9L,8L,0L,7L,5L,5L,7L,4L,5L,3L,7L,6L,0L,7L,5L,4L,9L,5L,0L,4L,8L,6L,0L,6L,9L,0L,2L,8L,4L,7L,2L,6L,6L,4L,8L,6L,1L,4L,5L,6L,6L,2L,4L,1L,2L,5L,1L,3L,8L,1L,4L,5L,4L,2L,4L,3L,0L,1L,2L,2L,0L,7L,1L,4L,4L,5L,5L,7L,5L,2L,8L,3L,1L,8L,7L,5L,1L,0L,7L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199390Inst : IEnumerable<long>
{
public static readonly long[] Value=A199390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199390.Bytes);
public long this[int i]=>Value[i];

public static A199390Inst Instance=new A199390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199391
{
public static readonly long[] Value={ 6L,4L,1L,1L,1L,9L,3L,6L,3L,7L,7L,9L,7L,5L,0L,6L,6L,4L,3L,8L,3L,1L,3L,2L,0L,4L,6L,0L,5L,7L,2L,6L,0L,2L,2L,8L,8L,3L,8L,4L,5L,3L,4L,0L,9L,1L,0L,2L,7L,9L,8L,9L,6L,9L,2L,1L,4L,9L,7L,2L,2L,8L,3L,0L,1L,0L,5L,9L,6L,2L,4L,7L,5L,3L,4L,4L,2L,4L,2L,2L,8L,0L,4L,3L,2L,1L,4L,8L,2L,2L,9L,0L,0L,4L,0L,0L,4L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199391Inst : IEnumerable<long>
{
public static readonly long[] Value=A199391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199391.Bytes);
public long this[int i]=>Value[i];

public static A199391Inst Instance=new A199391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199392
{
public static readonly long[] Value={ 7L,9L,0L,7L,3L,4L,2L,1L,0L,9L,6L,7L,2L,3L,6L,9L,7L,8L,3L,5L,7L,1L,7L,1L,8L,5L,1L,4L,6L,1L,2L,8L,7L,9L,3L,6L,3L,0L,0L,4L,6L,6L,3L,7L,0L,0L,7L,4L,8L,1L,3L,2L,5L,9L,5L,0L,2L,2L,1L,8L,1L,4L,6L,0L,8L,0L,7L,7L,1L,0L,5L,2L,8L,4L,8L,5L,2L,2L,5L,1L,2L,9L,7L,5L,1L,2L,2L,2L,4L,0L,5L,8L,3L,4L,7L,2L,0L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199392Inst : IEnumerable<long>
{
public static readonly long[] Value=A199392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199392.Bytes);
public long this[int i]=>Value[i];

public static A199392Inst Instance=new A199392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199393
{
public static readonly long[] Value={ 4L,1L,1L,1L,2L,9L,5L,2L,1L,5L,0L,2L,6L,0L,0L,4L,6L,8L,5L,7L,4L,2L,7L,8L,6L,4L,7L,1L,6L,9L,1L,8L,4L,1L,2L,8L,9L,3L,0L,9L,8L,1L,1L,2L,5L,5L,0L,7L,1L,2L,2L,7L,4L,1L,7L,5L,8L,5L,2L,4L,4L,6L,1L,2L,1L,6L,6L,6L,4L,7L,8L,7L,4L,1L,2L,2L,8L,7L,3L,0L,2L,7L,3L,8L,5L,2L,1L,0L,2L,4L,3L,7L,7L,3L,6L,1L,9L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199393Inst : IEnumerable<long>
{
public static readonly long[] Value=A199393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199393.Bytes);
public long this[int i]=>Value[i];

public static A199393Inst Instance=new A199393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199394
{
public static readonly long[] Value={ 11L,90L,357L,996L,2255L,4446L,7945L,13192L,20691L,31010L,44781L,62700L,85527L,114086L,149265L,192016L,243355L,304362L,376181L,460020L,557151L,668910L,796697L,941976L,1106275L,1291186L,1498365L,1729532L,1986471L,2271030L,2585121L,2930720L,3309867L,3724666L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199394Inst : IEnumerable<long>
{
public static readonly long[] Value=A199394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199394.Bytes);
public long this[int i]=>Value[i];

public static A199394Inst Instance=new A199394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199395
{
public static readonly long[] Value={ 5L,8L,5L,6L,3L,5L,4L,7L,6L,4L,9L,1L,1L,1L,7L,7L,7L,8L,2L,0L,0L,5L,9L,9L,5L,4L,4L,5L,5L,9L,5L,9L,2L,3L,2L,4L,9L,0L,9L,9L,8L,7L,7L,8L,4L,7L,4L,5L,6L,3L,3L,2L,8L,8L,2L,7L,8L,4L,2L,1L,7L,7L,4L,8L,8L,1L,2L,4L,5L,4L,0L,1L,1L,4L,7L,5L,5L,0L,2L,1L,7L,2L,6L,1L,5L,7L,1L,7L,0L,6L,6L,5L,0L,2L,1L,1L,2L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199395Inst : IEnumerable<long>
{
public static readonly long[] Value=A199395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199395.Bytes);
public long this[int i]=>Value[i];

public static A199395Inst Instance=new A199395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199396
{
public static readonly long[] Value={ 1L,5L,8L,32L,89L,309L,1392L,2464L,12241L,23685L,66936L,329856L,598377L,2972885L,4204000L,17321536L,47254689L,156943365L,737779176L,1276350496L,6369950073L,12290868597L,35051319632L,175157734688L,319624706161L,1569854375813L,2311734655064L,9333158201280L,25600877525257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199396Inst : IEnumerable<long>
{
public static readonly long[] Value=A199396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199396.Bytes);
public long this[int i]=>Value[i];

public static A199396Inst Instance=new A199396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199397
{
public static readonly long[] Value={ 1L,2L,11L,16L,65L,178L,619L,2784L,4929L,24482L,47371L,133872L,659713L,1196754L,5945771L,8408000L,34643073L,94509378L,313886731L,1475558352L,2552700993L,12739900146L,24581737195L,70102639264L,350315469377L,639249412322L,3139708751627L,4623469310128L,18666316402561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199397Inst : IEnumerable<long>
{
public static readonly long[] Value=A199397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199397.Bytes);
public long this[int i]=>Value[i];

public static A199397Inst Instance=new A199397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199398
{
public static readonly long[] Value={ 1L,2L,7L,0L,9L,2L,15L,0L,17L,2L,23L,0L,25L,2L,31L,0L,33L,2L,39L,0L,41L,2L,47L,0L,49L,2L,55L,0L,57L,2L,63L,0L,65L,2L,71L,0L,73L,2L,79L,0L,81L,2L,87L,0L,89L,2L,95L,0L,97L,2L,103L,0L,105L,2L,111L,0L,113L,2L,119L,0L,121L,2L,127L,0L,129L,2L,135L,0L,137L,2L,143L,0L,145L,2L,151L,0L,153L,2L,159L,0L,161L,2L,167L,0L,169L,2L,175L,0L,177L,2L,183L,0L,185L,2L,191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199398Inst : IEnumerable<long>
{
public static readonly long[] Value=A199398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199398.Bytes);
public long this[int i]=>Value[i];

public static A199398Inst Instance=new A199398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199399
{
public static readonly long[] Value={ 1L,4L,29L,96L,529L,3620L,13101L,66048L,325601L,1653380L,9189501L,40187552L,216562929L,1143607140L,5098589837L,26660767488L,161932208321L,635945960964L,4313170161629L,20567937335008L,74804061006033L,551572049610276L,2689136522898669L,10088864973699328L,67578042506892449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199399Inst : IEnumerable<long>
{
public static readonly long[] Value=A199399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199399.Bytes);
public long this[int i]=>Value[i];

public static A199399Inst Instance=new A199399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199400
{
public static readonly long[] Value={ 1L,2L,2L,4L,10L,6L,8L,38L,54L,24L,16L,130L,330L,336L,120L,32L,422L,1710L,3000L,2400L,720L,64L,1330L,8106L,21840L,29400L,19440L,5040L,128L,4118L,36414L,141624L,285600L,312480L,176400L,40320L,256L,12610L,158010L,853776L,2421720L,3900960L,3598560L,1774080L,362880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199400Inst : IEnumerable<long>
{
public static readonly long[] Value=A199400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199400.Bytes);
public long this[int i]=>Value[i];

public static A199400Inst Instance=new A199400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199401
{
public static readonly long[] Value={ 1L,3L,7L,2L,8L,1L,3L,4L,6L,2L,8L,1L,8L,2L,4L,6L,0L,0L,9L,1L,1L,2L,1L,9L,2L,6L,9L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199401Inst : IEnumerable<long>
{
public static readonly long[] Value=A199401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199401.Bytes);
public long this[int i]=>Value[i];

public static A199401Inst Instance=new A199401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199402
{
public static readonly long[] Value={ 3L,0L,9L,6L,39L,24L,153L,102L,615L,408L,2457L,1638L,9831L,6552L,39321L,26214L,157287L,104856L,629145L,419430L,2516583L,1677720L,10066329L,6710886L,40265319L,26843544L,161061273L,107374182L,644245095L,429496728L,2576980377L,1717986918L,10307921511L,6871947672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199402Inst : IEnumerable<long>
{
public static readonly long[] Value=A199402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199402.Bytes);
public long this[int i]=>Value[i];

public static A199402Inst Instance=new A199402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199403
{
public static readonly long[] Value={ 1L,0L,3L,6L,13L,24L,51L,102L,205L,408L,819L,1638L,3277L,6552L,13107L,26214L,52429L,104856L,209715L,419430L,838861L,1677720L,3355443L,6710886L,13421773L,26843544L,53687091L,107374182L,214748365L,429496728L,858993459L,1717986918L,3435973837L,6871947672L,13743895347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199403Inst : IEnumerable<long>
{
public static readonly long[] Value=A199403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199403.Bytes);
public long this[int i]=>Value[i];

public static A199403Inst Instance=new A199403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199404
{
public static readonly long[] Value={ 1L,4L,7L,43L,76L,469L,829L,5116L,9043L,55807L,98644L,608761L,1076041L,6640564L,11737807L,72437443L,128039836L,790171309L,1396700389L,8619446956L,15235664443L,94023745207L,166195608484L,1025641750321L,1812916028881L,11188035508324L,19775880709207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199404Inst : IEnumerable<long>
{
public static readonly long[] Value=A199404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199404.Bytes);
public long this[int i]=>Value[i];

public static A199404Inst Instance=new A199404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}