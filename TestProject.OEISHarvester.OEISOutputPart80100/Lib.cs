using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A099741
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,3L,3L,3L,4L,4L,4L,5L,5L,5L,5L,5L,5L,7L,7L,7L,7L,7L,7L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,13L,13L,13L,13L,13L,13L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,20L,20L,20L,20L,20L,20L,20L,20L,20L,21L };
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
public class A099741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099741Inst : IEnumerable<long>
{
public static readonly long[] Value=A099741.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099741.Bytes);
public long this[int i]=>Value[i];

public static A099741Inst Instance=new A099741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099742
{
public static readonly long[] Value={ 1L,1L,1L,7L,412L,7L,7L,133L,7L,7L,316L,7L,25L,10L,10L,10L,7L,7L,16L,10L,7L,25L,1L,7L,7L,100L,55L,7L,28L,940L,37L,148L,22L,16L,28L,67L };
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
public class A099742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099742Inst : IEnumerable<long>
{
public static readonly long[] Value=A099742.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099742.Bytes);
public long this[int i]=>Value[i];

public static A099742Inst Instance=new A099742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099743
{
public static readonly long[] Value={ 0L,0L,2L,15L,75L,313L,1179L,4161L,14051L,45993L,147195L,463345L,1440723L,4438905L,13582955L,41350977L,125404611L,379228489L,1144370139L,3447856017L,10375942835L,31198607385L,93749962827L,281584384225L,845476670115L,2537990291433L,7617326317499L };
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
public class A099743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099743Inst : IEnumerable<long>
{
public static readonly long[] Value=A099743.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099743.Bytes);
public long this[int i]=>Value[i];

public static A099743Inst Instance=new A099743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099744
{
public static readonly long[] Value={ 3L,5L,6L,222L,282L,353L,434L,555L,626L,656L,747L,828L,858L,929L,939L,10301L,10601L,11411L,11711L,12821L,12921L,13431L,13731L,14141L,14241L,14741L,15951L,16161L,17171L,17771L,18381L,18981L,19191L,19491L,19991L,20402L,20702L,22022L,22322L };
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
public class A099744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099744Inst : IEnumerable<long>
{
public static readonly long[] Value=A099744.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099744.Bytes);
public long this[int i]=>Value[i];

public static A099744Inst Instance=new A099744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099745
{
public static readonly long[] Value={ 0L,0L,0L,0L,12L,168L,1409L,9187L,51362L,258674L,1207855L,5326205L,22459080L,91368900L,360977373L,1391835607L,5257593566L,19515948358L,71358739003L,257521313441L,918732810340L,3244576312440L,11355547678665L,39423281302875L,135876498446042L,465248862099418L };
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
public class A099745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099745Inst : IEnumerable<long>
{
public static readonly long[] Value=A099745.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099745.Bytes);
public long this[int i]=>Value[i];

public static A099745Inst Instance=new A099745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099746
{
public static readonly long[] Value={ 10301L,10501L,10601L,1022201L,1028201L,1035301L,1043401L,1055501L,1062601L,1065601L,1074701L,1082801L,1085801L,1092901L,1093901L,101030101L,101060101L,101141101L,101171101L,101282101L,101292101L,101343101L,101373101L,101414101L };
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
public class A099746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099746Inst : IEnumerable<long>
{
public static readonly long[] Value=A099746.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099746.Bytes);
public long this[int i]=>Value[i];

public static A099746Inst Instance=new A099746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099747
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,6L,8L,10L,40L,46L,60L,61L,64L,80L,84L,5000L };
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
public class A099747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099747Inst : IEnumerable<long>
{
public static readonly long[] Value=A099747.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099747.Bytes);
public long this[int i]=>Value[i];

public static A099747Inst Instance=new A099747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099748
{
public static readonly long[] Value={ 1L,2L,21L,225L,3328L,33518L,257909L,1544907L,7657779L,32454761L,121100938L,405911691L,1242567609L,3517715389L,9305703095L,23194232130L,54848107788L,123760738779L,267768667311L,557808040826L,1122804257019L,2190539008704L,4153269969884L,7670791137960L };
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
public class A099748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099748Inst : IEnumerable<long>
{
public static readonly long[] Value=A099748.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099748.Bytes);
public long this[int i]=>Value[i];

public static A099748Inst Instance=new A099748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099749
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,7L,1L,9L,2L,3L,3L,7L,4L,3L,4L,7L,4L,9L,5L,9L,7L,7L,7L,9L,8L,3L,10L,3L,16L,9L,18L,1L,22L,1L,22L,7L,23L,3L,28L,7L,39L,7L,49L,9L,83L,3L,130L,7L,135L,7L,214L,7L,220L,3L,316L,1L,610L,7L,683L,9L,719L,9L,766L,7L,1030L,1L,1313L,3L,1451L,9L,1678L,9L,2152L,7L,2575L,7L };
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
public class A099749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099749Inst : IEnumerable<long>
{
public static readonly long[] Value=A099749.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099749.Bytes);
public long this[int i]=>Value[i];

public static A099749Inst Instance=new A099749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099750
{
public static readonly long[] Value={ 1L,3L,22L,346L,5100L,53504L,411041L,2471091L,12244665L,51924492L,193733585L,649448814L,1988025385L,5628317525L,14888914321L,37110706136L,87756490312L,198017040530L,428428858514L,892492579595L,1796484842799L,3504861873102L,6645228329464L,12273264853180L };
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
public class A099750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099750Inst : IEnumerable<long>
{
public static readonly long[] Value=A099750.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099750.Bytes);
public long this[int i]=>Value[i];

public static A099750Inst Instance=new A099750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099751
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,0L,2L,2L,1L,0L,2L,1L,2L,0L,2L,3L,2L,0L,2L,2L,2L,0L,2L,2L,3L,0L,1L,2L,2L,0L,2L,4L,2L,0L,4L,1L,2L,0L,2L,4L,2L,0L,2L,2L,2L,0L,2L,3L,3L,0L,2L,2L,2L,0L,4L,4L,2L,0L,2L,2L,2L,0L,2L,5L,4L,0L,2L,2L,2L,0L,2L,2L,2L,0L,3L,2L,4L,0L,2L,6L,1L,0L,2L,2L,4L,0L,2L,4L,2L,0L,4L,2L,2L,0L,4L,4L,2L,0L,2L,3L,2L,0L,2L,4L,4L };
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
public class A099751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099751Inst : IEnumerable<long>
{
public static readonly long[] Value=A099751.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099751.Bytes);
public long this[int i]=>Value[i];

public static A099751Inst Instance=new A099751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099752
{
public static readonly long[] Value={ 1L,2L,8L,32L,119L,438L,1483L,4463L,12121L,30047L,68783L,147178L,297234L,570865L,1049605L,1857388L,3177426L,5274519L,8523168L,13442921L,20742950L,31376270L,46605818L,68084760L,97952005L,138945430L,194536354L,269086136L,368028405L,498081190L,667490215L,886307575L };
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
public class A099752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099752Inst : IEnumerable<long>
{
public static readonly long[] Value=A099752.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099752.Bytes);
public long this[int i]=>Value[i];

public static A099752Inst Instance=new A099752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099753
{
public static readonly BigInteger[] Value={ 1L,27L,625L,16807L,531441L,19487171L,815730721L,38443359375L,2015993900449L,116490258898219L,7355827511386641L,504036361936467383L,BigInteger.Parse("37252902984619140625") };
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
public class A099753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099753Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A099753.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099753.Bytes);
public BigInteger this[int i]=>Value[i];

public static A099753Inst Instance=new A099753Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099754
{
public static readonly long[] Value={ 2L,4L,9L,22L,57L,154L,429L,1222L,3537L,10354L,30549L,90622L,269817L,805354L,2407869L,7207222L,21588897L,64701154L,193972389L,581655022L,1744440777L,5232273754L,15694724109L,47079978022L,141231545457L,423677859154L,1271000023029L };
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
public class A099754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099754Inst : IEnumerable<long>
{
public static readonly long[] Value=A099754.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099754.Bytes);
public long this[int i]=>Value[i];

public static A099754Inst Instance=new A099754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099755
{
public static readonly long[] Value={ 1L,1L,2L,1L,10L,4L,1L,44L,44L,16L,1L,182L,440L,216L,106L,1L,736L,3732L,3488L,1492L,946L,1L,2954L,28280L,50296L,28872L,14336L,10396L,1L,11828L,199220L,628608L,590496L,287520L,174216L,135136L,1L,47326L,1337256L,7021064L,10933824L,6993216L,3589104L,2510608L };
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
public class A099755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099755Inst : IEnumerable<long>
{
public static readonly long[] Value=A099755.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099755.Bytes);
public long this[int i]=>Value[i];

public static A099755Inst Instance=new A099755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099756
{
public static readonly long[] Value={ 11L,2L,3L,5L,7L,101L,211L,13L,41L,151L,61L,17L,181L,19L,23L,227L,29L,43L,53L,37L,83L,47L,499L,557L,59L,67L,787L,79L,89L,1021L,103L,401L,1051L,601L,107L,1801L,109L,2003L,2027L,2029L,4003L,503L,307L,3083L,4007L,409L,5077L,509L,607L,8087L,709L,809L,1123L,241L,251L,1621L };
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
public class A099756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099756Inst : IEnumerable<long>
{
public static readonly long[] Value=A099756.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099756.Bytes);
public long this[int i]=>Value[i];

public static A099756Inst Instance=new A099756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099757
{
public static readonly long[] Value={ 1L,1L,5L,5L,37L,55L,309L,551L,2203L,4244L,13162L,25440L,66070L,124994L,285536L,523098L,1085624L,1921844L,3702554L,6338324L,11505922L,19087926L,33001680L,53187842L,88283749L,138577771L,222176121L,340466203L,529761539L,794259297L,1203988645L,1769515717L };
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
public class A099757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099757Inst : IEnumerable<long>
{
public static readonly long[] Value=A099757.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099757.Bytes);
public long this[int i]=>Value[i];

public static A099757Inst Instance=new A099757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099758
{
public static readonly long[] Value={ 1L,2L,6L,26L,158L,1266L,12662L,151946L,2127246L,34035938L,612646886L,12252937722L };
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
public class A099758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099758Inst : IEnumerable<long>
{
public static readonly long[] Value=A099758.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099758.Bytes);
public long this[int i]=>Value[i];

public static A099758Inst Instance=new A099758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099759
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,12L,12L,1L,1L,30L,96L,30L,1L,1L,68L,564L,564L,68L,1L,1L,146L,2800L,6768L,2800L,146L,1L,1L,304L,12660L,63008L,63008L,12660L,304L,1L,1L,622L,54288L,504648L,1008128L,504648L,54288L,622L,1L,1L,1260L,225860L,3679344L,13111504L,13111504L };
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
public class A099759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099759Inst : IEnumerable<long>
{
public static readonly long[] Value=A099759.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099759.Bytes);
public long this[int i]=>Value[i];

public static A099759Inst Instance=new A099759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099760
{
public static readonly BigInteger[] Value={ 1L,2L,6L,26L,158L,1266L,12662L,151946L,2127246L,34035938L,612646886L,12252937722L,269564629886L,6469551117266L,168208329048918L,4709833213369706L,141294996401091182L,4521439884834917826L,BigInteger.Parse("153728956084387206086") };
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
public class A099760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099760Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A099760.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099760.Bytes);
public BigInteger this[int i]=>Value[i];

public static A099760Inst Instance=new A099760Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099761
{
public static readonly long[] Value={ 0L,9L,64L,225L,576L,1225L,2304L,3969L,6400L,9801L,14400L,20449L,28224L,38025L,50176L,65025L,82944L,104329L,129600L,159201L,193600L,233289L,278784L,330625L,389376L,455625L,529984L,613089L,705600L,808201L,921600L,1046529L,1183744L,1334025L };
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
public class A099761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099761Inst : IEnumerable<long>
{
public static readonly long[] Value=A099761.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099761.Bytes);
public long this[int i]=>Value[i];

public static A099761Inst Instance=new A099761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099762
{
public static readonly long[] Value={ 0L,8L,108L,576L,2000L,5400L,12348L,25088L,46656L,81000L,133100L,209088L,316368L,463736L,661500L,921600L,1257728L,1685448L,2222316L,2888000L,3704400L,4695768L,5888828L,7312896L,9000000L,10985000L,13305708L,16003008L,19120976L,22707000L };
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
public class A099762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099762Inst : IEnumerable<long>
{
public static readonly long[] Value=A099762.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099762.Bytes);
public long this[int i]=>Value[i];

public static A099762Inst Instance=new A099762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099763
{
public static readonly long[] Value={ 1L,3L,10L,40L,41L,30L,11L,31L,32L,2L,20L,42L,21L,33L,12L,22L,23L,13L,100L,43L,101L,300L,400L,401L,301L,302L,200L,402L,201L,303L,103L,202L,203L,103L,110L,403L,111L,310L,410L,411L,311L,312L,210L,412L,211L,313L,112L,212L,213L,113L,120L,413L,121L,320L,420L,421L,321L };
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
public class A099763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099763Inst : IEnumerable<long>
{
public static readonly long[] Value=A099763.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099763.Bytes);
public long this[int i]=>Value[i];

public static A099763Inst Instance=new A099763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099764
{
public static readonly long[] Value={ 0L,36L,576L,3600L,14400L,44100L,112896L,254016L,518400L,980100L,1742400L,2944656L,4769856L,7452900L,11289600L,16646400L,23970816L,33802596L,46785600L,63680400L,85377600L,112911876L,147476736L,190440000L,243360000L,308002500L,386358336L };
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
public class A099764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099764Inst : IEnumerable<long>
{
public static readonly long[] Value=A099764.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099764.Bytes);
public long this[int i]=>Value[i];

public static A099764Inst Instance=new A099764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099765
{
public static readonly BigInteger[] Value={ 1L,1L,2L,8L,46L,352L,3364L,38656L,519446L,7996928L,138826588L,2683604992L,57176039628L,1331300646912L,33636118326984L,916559498182656L,26795449170328038L,836606220759859200L,BigInteger.Parse("27784046218331805100") };
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
public class A099765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099765Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A099765.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099765.Bytes);
public BigInteger this[int i]=>Value[i];

public static A099765Inst Instance=new A099765Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099766
{
public static readonly long[] Value={ 1L,1L,1L,0L,2L,0L,0L,2L,2L,0L,0L,2L,2L,2L,0L,0L,2L,4L,4L,2L,0L,0L,2L,4L,8L,4L,2L,0L,0L,2L,6L,12L,12L,6L,2L,0L,0L,2L,6L,18L,22L,18L,6L,2L,0L,0L,2L,8L,24L,40L,40L,24L,8L,2L,0L,0L,2L,8L,32L,60L,80L,60L,32L,8L,2L,0L,0L,2L,10L,40L,92L,140L,140L,92L,40L,10L,2L,0L,0L,2L,10L,50L,128L,232L };
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
public class A099766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099766Inst : IEnumerable<long>
{
public static readonly long[] Value=A099766.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099766.Bytes);
public long this[int i]=>Value[i];

public static A099766Inst Instance=new A099766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099767
{
public static readonly long[] Value={ 1L,6L,12L,100L,180L,2058L,3584L,52488L,90000L,1610510L,2737152L,57921708L,97883968L,2392031250L,4026531840L,111612119056L,187339329792L,5808378560022L,9728000000000L };
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
public class A099767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099767Inst : IEnumerable<long>
{
public static readonly long[] Value=A099767.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099767.Bytes);
public long this[int i]=>Value[i];

public static A099767Inst Instance=new A099767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099768
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,4L,8L,12L,22L,40L,80L,140L,272L,504L,1008L,1860L,3698L,6948L,13896L,26196L,52312L,99416L,198832L,379316L,758360L,1453312L,2906624L,5587704L,11174400L,21546672L,43093344L,83295796L,166587894L,322712680L,645425360L,1252691124L,2505368352L,4870919800L };
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
public class A099768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099768Inst : IEnumerable<long>
{
public static readonly long[] Value=A099768.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099768.Bytes);
public long this[int i]=>Value[i];

public static A099768Inst Instance=new A099768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099769
{
public static readonly long[] Value={ 9L,2L,4L,2L,9L,9L,8L,9L,7L,2L,2L,2L,9L,3L,8L,8L,5L,5L,9L,5L,9L,5L,7L,0L,1L,8L,1L,3L,5L,9L,5L,9L,0L,0L,5L,3L,7L,7L,3L,3L,1L,9L,3L,9L,7L,8L,8L,6L,9L,1L,9L,0L,7L,4L,7L,7L,9L,6L,3L,0L,4L,3L,7L,2L,5L,0L,7L,0L,0L,5L,4L,1L,7L,1L,1L,4L,3L,4L,6L,8L,9L,7L,9L,8L,9L,9L,1L,3L,4L,7L,6L,6L,4L,9L,4L,6L,9L,1L,9L,5L,3L,5L,7L,4L,1L,4L,5L,2L,8L };
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
public class A099769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099769Inst : IEnumerable<long>
{
public static readonly long[] Value=A099769.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099769.Bytes);
public long this[int i]=>Value[i];

public static A099769Inst Instance=new A099769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099770
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,4L,7L,7L,11L,11L,16L,16L,23L,23L,31L,31L,41L,41L,53L,53L,67L,67L,83L,83L,102L,102L,123L,123L,147L,147L,174L,174L,204L,204L,237L,237L,274L,274L,314L,314L,358L,358L,406L,406L,458L,458L,514L,514L,575L,575L,640L,640L,710L,710L,785L,785L,865L,865L,950L,950L,1041L,1041L };
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
public class A099770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099770Inst : IEnumerable<long>
{
public static readonly long[] Value=A099770.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099770.Bytes);
public long this[int i]=>Value[i];

public static A099770Inst Instance=new A099770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099771
{
public static readonly long[] Value={ 25L,95L,417L,675L,2541L,3888L,3528L,16256L,13984L,11312L,10648L,10688L,6672L,15364L,20476L,12288L,12636L,32216L,33304L,33896L,34504L,38660L,31824L,15792L,62296L,67304L,49120L,58104L,102740L,82120L,84704L,53680L };
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
public class A099771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099771Inst : IEnumerable<long>
{
public static readonly long[] Value=A099771.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099771.Bytes);
public long this[int i]=>Value[i];

public static A099771Inst Instance=new A099771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099772
{
public static readonly BigInteger[] Value={ 16L,512L,33554432L,562949953421312L,BigInteger.Parse("2658455991569831745807614120560689152"),BigInteger.Parse("748288838313422294120286634350736906063837462003712"),BigInteger.Parse("994646472819573284310764496293641680200912301594695434880927953786318994025066751066112") };
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
public class A099772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099772Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A099772.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099772.Bytes);
public BigInteger this[int i]=>Value[i];

public static A099772Inst Instance=new A099772Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099773
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,1L,1L,1L,1L,2L,2L,2L,3L,3L,3L,4L,5L,5L,6L,7L,7L,9L,10L,11L,12L,14L,15L,17L,20L,21L,24L,26L,29L,33L,35L,40L,44L,47L,53L,58L,64L,70L,77L,84L,91L,101L,110L,120L,130L,142L,155L,168L,184L,199L,215L,234L,254L,275L,298L,323L,348L,376L,407L,439L,474L,511L,551L,592L };
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
public class A099773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099773Inst : IEnumerable<long>
{
public static readonly long[] Value=A099773.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099773.Bytes);
public long this[int i]=>Value[i];

public static A099773Inst Instance=new A099773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099774
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,2L,2L,4L,2L,2L,4L,2L,3L,4L,2L,2L,4L,4L,2L,4L,2L,2L,6L,2L,3L,4L,2L,4L,4L,2L,2L,6L,4L,2L,4L,2L,2L,6L,4L,2L,5L,2L,4L,4L,2L,4L,4L,4L,2L,6L,2L,2L,8L,2L,2L,4L,2L,4L,6L,4L,3L,4L,4L,2L,4L,2L,4L,8L,2L,2L,4L,4L,4L,6L,2L,2L,6L,4L,2L,4L,4L,2L,8L,2L,3L,6L,2L,6L,4L,2L,2L,4L,4L,4L,8L,2L,2L,8L,2L,2L,4L,4L,4L,6L,4L };
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
public class A099774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099774Inst : IEnumerable<long>
{
public static readonly long[] Value=A099774.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099774.Bytes);
public long this[int i]=>Value[i];

public static A099774Inst Instance=new A099774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099775
{
public static readonly long[] Value={ 29L,71L,137L,317L,431L,661L,1511L,3121L,3593L,4751L,6551L,8627L,9791L,11657L,16631L,19037L,36857L,41983L,51977L,55681L,57593L,72893L,82913L,95471L,116933L,123191L,159191L,194471L,198901L,205187L,210671L,233267L,256021L,272477L,324893L,364801L };
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
public class A099775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099775Inst : IEnumerable<long>
{
public static readonly long[] Value=A099775.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099775.Bytes);
public long this[int i]=>Value[i];

public static A099775Inst Instance=new A099775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099776
{
public static readonly long[] Value={ 5L,13L,25L,41L,61L,85L,113L,145L,181L,221L,265L,313L,365L,421L,481L,545L,613L,685L,761L,841L,925L,1013L,1105L,1201L,1301L,1405L,1513L,1625L,1741L,1861L,1985L,2113L,2245L,2381L,2521L,2665L,2813L,2965L,3121L,3281L,3445L,3613L,3785L,3961L,4141L,4325L,4513L };
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
public class A099776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099776Inst : IEnumerable<long>
{
public static readonly long[] Value=A099776.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099776.Bytes);
public long this[int i]=>Value[i];

public static A099776Inst Instance=new A099776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099777
{
public static readonly long[] Value={ 2L,3L,4L,4L,4L,6L,4L,5L,6L,6L,4L,8L,4L,6L,8L,6L,4L,9L,4L,8L,8L,6L,4L,10L,6L,6L,8L,8L,4L,12L,4L,7L,8L,6L,8L,12L,4L,6L,8L,10L,4L,12L,4L,8L,12L,6L,4L,12L,6L,9L,8L,8L,4L,12L,8L,10L,8L,6L,4L,16L,4L,6L,12L,8L,8L,12L,4L,8L,8L,12L,4L,15L,4L,6L,12L,8L,8L,12L,4L,12L,10L,6L,4L,16L,8L,6L,8L,10L,4L,18L,8L,8L,8L,6L,8L };
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
public class A099777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099777Inst : IEnumerable<long>
{
public static readonly long[] Value=A099777.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099777.Bytes);
public long this[int i]=>Value[i];

public static A099777Inst Instance=new A099777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099778
{
public static readonly long[] Value={ 6728L,75272L,1113032L,14601608L,206700000L,2832600000L,39626000000L,549520000000L,7662700000000L,106600000000000L,1485300000000000L,20681000000000000L,288070000000000000L,4011900000000000000L };
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
public class A099778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099778Inst : IEnumerable<long>
{
public static readonly long[] Value=A099778.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099778.Bytes);
public long this[int i]=>Value[i];

public static A099778Inst Instance=new A099778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099779
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,13L,23L,44L,83L,159L,306L,590L,1144L,2220L,4317L,8408L,16399L,32023L,62601L,122498L,239924L,470304L,922612L,1811217L,3558035L,6993883L,13755529L,27068914L,53294747L,104979547L,206880514L,407866454L,804432711L,1587177283L };
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
public class A099779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099779Inst : IEnumerable<long>
{
public static readonly long[] Value=A099779.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099779.Bytes);
public long this[int i]=>Value[i];

public static A099779Inst Instance=new A099779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099780
{
public static readonly long[] Value={ 1L,3L,9L,29L,99L,351L,1273L,4677L,17307L,64295L,239361L,892125L,3327091L,12412143L,46313289L,172824629L,644952459L,2406919671L,8982595153L,33523198797L,125109675747L,466914455615L,1742546049561L,6503265548325L,24270507755131L,90578748694983L,338044453470369L };
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
public class A099780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099780Inst : IEnumerable<long>
{
public static readonly long[] Value=A099780.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099780.Bytes);
public long this[int i]=>Value[i];

public static A099780Inst Instance=new A099780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099781
{
public static readonly long[] Value={ 1L,4L,16L,65L,268L,1120L,4737L,20244L,87280L,379073L,1656348L,7272896L,32060673L,141775396L,628505296L,2791696705L,12419264300L,55315472416L,246607247233L,1100229683508L,4911436984752L,21934428189121L,97992663440444L };
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
public class A099781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099781Inst : IEnumerable<long>
{
public static readonly long[] Value=A099781.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099781.Bytes);
public long this[int i]=>Value[i];

public static A099781Inst Instance=new A099781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099782
{
public static readonly long[] Value={ 1L,4L,16L,66L,280L,1216L,5380L,24144L,109504L,500488L,2300128L,10612224L,49096720L,227578432L,1056304384L,4907373600L,22813275520L,106100835328L,493609021504L,2296885357824L,10689540189184L,49753373831296L,231588118339072L };
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
public class A099782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099782Inst : IEnumerable<long>
{
public static readonly long[] Value=A099782.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099782.Bytes);
public long this[int i]=>Value[i];

public static A099782Inst Instance=new A099782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099783
{
public static readonly long[] Value={ 1L,3L,9L,30L,108L,405L,1548L,5967L,23085L,89451L,346842L,1345248L,5218263L,20242872L,78528609L,304640595L,1181814705L,4584708702L,17785841652L,68998115709L,267670245492L,1038395956527L,4028337876861L,15627474388899L,60624993311226L };
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
public class A099783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099783Inst : IEnumerable<long>
{
public static readonly long[] Value=A099783.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099783.Bytes);
public long this[int i]=>Value[i];

public static A099783Inst Instance=new A099783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099784
{
public static readonly long[] Value={ 1L,-2L,4L,-6L,4L,16L,-92L,312L,-848L,1960L,-3824L,5760L,-3824L,-15392L,88384L,-299616L,814144L,-1881344L,3669568L,-5524608L,3657472L,14807680L,-84909824L,287723520L,-781639424L,1805843968L,-3521371136L,5298829824L };
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
public class A099784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099784Inst : IEnumerable<long>
{
public static readonly long[] Value=A099784.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099784.Bytes);
public long this[int i]=>Value[i];

public static A099784Inst Instance=new A099784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099785
{
public static readonly long[] Value={ 1L,2L,4L,8L,18L,48L,144L,448L,1380L,4152L,12224L,35456L,102024L,292768L,840416L,2416384L,6959504L,20069280L,57913536L,167158656L,482462752L,1392319488L,4017460224L,11590946816L,33439639616L,96470796672L,278311599616L };
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
public class A099785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099785Inst : IEnumerable<long>
{
public static readonly long[] Value=A099785.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099785.Bytes);
public long this[int i]=>Value[i];

public static A099785Inst Instance=new A099785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099786
{
public static readonly long[] Value={ 1L,3L,9L,27L,82L,255L,819L,2727L,9397L,33312L,120537L,441855L,1631017L,6036879L,22345074L,82589247L,304612975L,1120960983L,4116353265L,15088372416L,55224373105L,201895801851L,737506551321L,2692518758163L,9826402960882L };
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
public class A099786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099786Inst : IEnumerable<long>
{
public static readonly long[] Value=A099786.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099786.Bytes);
public long this[int i]=>Value[i];

public static A099786Inst Instance=new A099786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099787
{
public static readonly long[] Value={ 1L,3L,9L,27L,83L,267L,909L,3267L,12235L,46983L,182529L,711099L,2764619L,10704147L,41257341L,158371011L,605932099L,2312728095L,8812918161L,33549513579L,127652354627L,485608571547L,1847326271949L,7028217617859L,26742885359131L };
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
public class A099787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099787Inst : IEnumerable<long>
{
public static readonly long[] Value=A099787.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099787.Bytes);
public long this[int i]=>Value[i];

public static A099787Inst Instance=new A099787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099788
{
public static readonly BigInteger[] Value={ 1L,6L,210L,30030L,9699690L,6469693230L,7420738134810L,13082761331670030L,BigInteger.Parse("32589158477190044730"),BigInteger.Parse("117288381359406970983270"),BigInteger.Parse("557940830126698960967415390"),BigInteger.Parse("3217644767340672907899084554130") };
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
public class A099788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099788Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A099788.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099788.Bytes);
public BigInteger this[int i]=>Value[i];

public static A099788Inst Instance=new A099788Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099789
{
public static readonly long[] Value={ 0L,1L,10L,88L,322L,330L,1102L,6328L,8708L,9075L,50036L,69203L,119499L,1127146L,4977922L,83001715L,110648989L,1075575929L,2716859574L,4005383367L,13981702062L };
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
public class A099789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099789Inst : IEnumerable<long>
{
public static readonly long[] Value=A099789.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099789.Bytes);
public long this[int i]=>Value[i];

public static A099789Inst Instance=new A099789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099790
{
public static readonly long[] Value={ 0L,1L,2L,6L,105L,284L,747L,984L,2230L,5377L,11513L,15453L,56611L,140810L,1282328L,2175211L,3328834L,96073801L,285626436L,801855023L,927833490L };
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
public class A099790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099790Inst : IEnumerable<long>
{
public static readonly long[] Value=A099790.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099790.Bytes);
public long this[int i]=>Value[i];

public static A099790Inst Instance=new A099790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099791
{
public static readonly long[] Value={ 1L,3L,5L,12L,271L,12574L,13740L,78907L,133430L,574536L };
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
public class A099791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099791Inst : IEnumerable<long>
{
public static readonly long[] Value=A099791.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099791.Bytes);
public long this[int i]=>Value[i];

public static A099791Inst Instance=new A099791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099792
{
public static readonly long[] Value={ 1L,2L,5L,10L,13L,267L,3171L,3213L,12962L,82528L };
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
public class A099792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099792Inst : IEnumerable<long>
{
public static readonly long[] Value=A099792.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099792.Bytes);
public long this[int i]=>Value[i];

public static A099792Inst Instance=new A099792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099793
{
public static readonly long[] Value={ 1L,1L,4L,1L,0L,1L,9L,4L,5L,1L,0L,1L,21L,19L,12L,9L,7L,1L,0L,1L,52L,57L,53L,47L,16L,16L,9L,1L,0L,1L,127L,178L,202L,154L,120L,85L,20L,25L,11L,1L,0L,1L,313L,543L,664L,636L,525L,310L,233L,133L,24L,36L,13L,1L,0L,1L,778L,1591L,2204L,2355L,2007L,1621L,1076L,549L,404L,191L,28L,49L,15L };
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
public class A099793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099793Inst : IEnumerable<long>
{
public static readonly long[] Value=A099793.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099793.Bytes);
public long this[int i]=>Value[i];

public static A099793Inst Instance=new A099793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099794
{
public static readonly BigInteger[] Value={ 1L,1L,5L,43L,2291L,6397L,423953L,2579419L,30364247L,77544004469L,1277242663471L,70250377083373L,3909462041753561L,101888460343995907L,8217087542785091183L,BigInteger.Parse("2455846588270412484317"),BigInteger.Parse("38974424104246263663539") };
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
public class A099794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099794Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A099794.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099794.Bytes);
public BigInteger this[int i]=>Value[i];

public static A099794Inst Instance=new A099794Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099795
{
public static readonly BigInteger[] Value={ 1L,2L,12L,60L,2520L,27720L,720720L,12252240L,232792560L,80313433200L,2329089562800L,144403552893600L,5342931457063200L,219060189739591200L,9419588158802421600UL,BigInteger.Parse("3099044504245996706400"),BigInteger.Parse("164249358725037825439200"),BigInteger.Parse("9690712164777231700912800") };
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
public class A099795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099795Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A099795.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099795.Bytes);
public BigInteger this[int i]=>Value[i];

public static A099795Inst Instance=new A099795Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099796
{
public static readonly long[] Value={ 1L,1L,2L,5L,10L,3L,10L,4L,3L,28L,17L,18L,30L,20L,41L,42L,14L,19L,30L,37L,63L,50L,7L,12L,83L,30L,91L,19L,69L,91L,97L,56L,22L,80L,39L,137L,44L,9L,154L,19L,37L,141L,141L,168L,126L,183L,200L,205L,136L,55L,95L,204L,126L,213L,230L,68L,63L,158L,202L,162L,102L,182L,104L,38L,165L,119L };
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
public class A099796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099796Inst : IEnumerable<long>
{
public static readonly long[] Value=A099796.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099796.Bytes);
public long this[int i]=>Value[i];

public static A099796Inst Instance=new A099796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099797
{
public static readonly long[] Value={ 2L,4L,5L,6L,8L,9L,11L,12L,14L,17L,18L,20L,23L,24L,29L,31L,32L,33L,37L,38L,41L,43L,44L,45L,47L,53L,59L,61L,62L,67L,68L,69L,70L,71L,73L,79L,80L,81L,83L,89L,90L,97L,98L,99L,100L,101L,102L,103L,107L,109L,113L,127L,128L,131L,137L,139L,149L,151L,152L,157L,158L,159L,163L,167L };
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
public class A099797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099797Inst : IEnumerable<long>
{
public static readonly long[] Value=A099797.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099797.Bytes);
public long this[int i]=>Value[i];

public static A099797Inst Instance=new A099797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099798
{
public static readonly long[] Value={ 1L,2L,3L,6L,8L,11L,12L,13L,14L,15L,17L,19L,23L,29L,31L,32L,37L,38L,41L,42L,44L,45L,47L,48L,49L,50L,51L,52L,53L,54L,59L,61L,62L,63L,64L,65L,67L,71L,72L,74L,79L,83L,84L,89L,97L,98L,101L,103L,107L,109L,113L,127L,131L,137L,138L,140L,141L,142L,149L,150L,151L,157L,163L,167L };
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
public class A099798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099798Inst : IEnumerable<long>
{
public static readonly long[] Value=A099798.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099798.Bytes);
public long this[int i]=>Value[i];

public static A099798Inst Instance=new A099798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099799
{
public static readonly long[] Value={ 5L,25L,39L,50L,218L,775L,949L,673L,403L,1597L,2190L,2820L,6050L,8577L,12423L,27325L,34075L,52754L,37088L,74649L,68150L,43795L,106368L,102227L,225809L,149297L,87594L,694398L,820953L,575377L,741617L,776230L,169160L,2218014L };
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
public class A099799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099799Inst : IEnumerable<long>
{
public static readonly long[] Value=A099799.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099799.Bytes);
public long this[int i]=>Value[i];

public static A099799Inst Instance=new A099799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099800
{
public static readonly BigInteger[] Value={ 2L,30L,2310L,510510L,223092870L,200560490130L,304250263527210L,614889782588491410L,BigInteger.Parse("1922760350154212639070"),BigInteger.Parse("7858321551080267055879090"),BigInteger.Parse("40729680599249024150621323470"),BigInteger.Parse("267064515689275851355624017992790") };
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
public class A099800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099800Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A099800.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099800.Bytes);
public BigInteger this[int i]=>Value[i];

public static A099800Inst Instance=new A099800Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099801
{
public static readonly long[] Value={ 0L,2L,3L,4L,4L,5L,6L,6L,7L,8L,8L,9L,9L,9L,10L,11L,11L,11L,12L,12L,13L,14L,14L,15L,15L,15L,16L,16L,16L,17L,18L,18L,18L,19L,19L,20L,21L,21L,21L,22L,22L,23L,23L,23L,24L,24L,24L,24L,25L,25L,26L,27L,27L,28L,29L,29L,30L,30L,30L,30L,30L,30L,30L,31L,31L,32L,32L,32L,33L,34L,34L,34L,34L,34L };
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
public class A099801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099801Inst : IEnumerable<long>
{
public static readonly long[] Value=A099801.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099801.Bytes);
public long this[int i]=>Value[i];

public static A099801Inst Instance=new A099801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099802
{
public static readonly long[] Value={ 1L,2L,3L,4L,4L,5L,6L,6L,7L,8L,8L,9L,9L,9L,10L,11L,11L,11L,12L,12L,13L,14L,14L,15L,15L,15L,16L,16L,16L,17L,18L,18L,18L,19L,19L,20L,21L,21L,21L,22L,22L,23L,23L,23L,24L,24L,24L,24L,25L,25L,26L,27L,27L,28L,29L,29L,30L,30L,30L,30L,30L,30L,30L,31L,31L,32L,32L,32L,33L,34L,34L,34L,34L,34L };
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
public class A099802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099802Inst : IEnumerable<long>
{
public static readonly long[] Value=A099802.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099802.Bytes);
public long this[int i]=>Value[i];

public static A099802Inst Instance=new A099802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099803
{
public static readonly long[] Value={ 1L,2L,4L,1L,1L,1L,3L,1L,1L,1L,2L,47L,2L,4L,1L,12L,1L,1L,2L,2L,1L,7L,2L,1L,1L,1L,2L,30L,6L,3L,6L,1L,6L,1L,3L,1L,1L,1L,1L,10L,1L,1L,2L,2L,1L,4L,2L,5L,26L,5L,1L,19L,2L,6L,1L,10L,28L,1L,2L,1L,10L,2L,1L,1L,11L,1L,4L,19L,16L,99L,1L,1L,1L,35L,1L,1L,3L,2L,3L,1L,3L,2L,1L,1L,1L,1L,1L,1L,11L,3L,2L,1L,6L,5L,1L };
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
public class A099803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099803Inst : IEnumerable<long>
{
public static readonly long[] Value=A099803.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099803.Bytes);
public long this[int i]=>Value[i];

public static A099803Inst Instance=new A099803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099804
{
public static readonly long[] Value={ 1L,2L,4L,47L,99L,294L,527L,616L,1152L,1456L,2638L,2705L,4105L,31772L,88683L,90658L,95845L,237245L,1387437L,5499408L,12672729L,110482114L };
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
public class A099804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099804Inst : IEnumerable<long>
{
public static readonly long[] Value=A099804.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099804.Bytes);
public long this[int i]=>Value[i];

public static A099804Inst Instance=new A099804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099805
{
public static readonly long[] Value={ 1L,2L,3L,12L,70L,126L,202L,585L,1592L,2436L,2544L,4814L,9603L,12148L,122447L };
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
public class A099805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099805Inst : IEnumerable<long>
{
public static readonly long[] Value=A099805.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099805.Bytes);
public long this[int i]=>Value[i];

public static A099805Inst Instance=new A099805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099806
{
public static readonly long[] Value={ 11L,8663L,28703L,56999L,44111L,86291L,87959L,16931L,246011L,54083L,367823L,552011L,457511L,571019L,765983L,1586531L,1915163L,2437751L,16139L,2305883L,4074743L,3963299L,1296563L,5440991L,4683779L,2238023L,9682703L,8681639L,8142803L };
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
public class A099806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099806Inst : IEnumerable<long>
{
public static readonly long[] Value=A099806.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099806.Bytes);
public long this[int i]=>Value[i];

public static A099806Inst Instance=new A099806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099807
{
public static readonly long[] Value={ 37L,2137L,8929L,1801L,48817L,6637L,57241L,133597L,151477L,334717L,3889L,127717L,786697L,735781L,1154017L,38557L,1662229L,2446777L,3882661L,3811669L,2747449L,3716701L,5634637L,3600097L,9836221L,10591849L,7139569L,9473161L,11395309L };
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
public class A099807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099807Inst : IEnumerable<long>
{
public static readonly long[] Value=A099807.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099807.Bytes);
public long this[int i]=>Value[i];

public static A099807Inst Instance=new A099807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099808
{
public static readonly long[] Value={ 1L,15L,28L,35L,44L,44L,55L,56L,91L,90L,88L,119L,161L,165L,200L,184L,273L,319L,285L,357L,377L,400L,380L,434L,550L,517L,592L,615L,638L,667L,682L,666L,740L,697L,784L,688L,825L,682L,846L,770L,893L,814L,868L,925L,775L,899L,885L,1007L,1045L,1040L,1078L,1184L,1015L };
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
public class A099808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099808Inst : IEnumerable<long>
{
public static readonly long[] Value=A099808.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099808.Bytes);
public long this[int i]=>Value[i];

public static A099808Inst Instance=new A099808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099809
{
public static readonly long[] Value={ 19L,4513L,14689L,32401L,26929L,48019L,44641L,72739L,124099L,179683L,211249L,288979L,395089L,386131L,587233L,905059L,1040419L,1410049L,2237011L,1919779L,2078209L,2220451L,2950963L,2767489L,4919971L,5582449L,5019889L,5255761L };
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
public class A099809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099809Inst : IEnumerable<long>
{
public static readonly long[] Value=A099809.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099809.Bytes);
public long this[int i]=>Value[i];

public static A099809Inst Instance=new A099809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099810
{
public static readonly long[] Value={ 1L,3L,7L,13L,25L,63L,103L,193L,489L,835L,1647L,4061L,6545L,12543L,31343L,53505L,105073L,258307L,424567L,790797L,2005641L,3420447L,6748855L,16634209L,26811769L,51377059L,128377535L,219165917L,430383937L,1058044767L,1739056639L };
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
public class A099810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099810Inst : IEnumerable<long>
{
public static readonly long[] Value=A099810.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099810.Bytes);
public long this[int i]=>Value[i];

public static A099810Inst Instance=new A099810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099811
{
public static readonly long[] Value={ 1L,3L,7L,12L,27L,41L,114L,191L,307L,908L,1479L,2517L,7218L,11819L,20079L,57564L,94035L,233905L,327970L,954519L,1356507L,3827708L,5462751L,15712989L,21207042L,61631203L,87045927L,251438028L,339057531L,986402633L,1392602162L,4023051167L };
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
public class A099811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099811Inst : IEnumerable<long>
{
public static readonly long[] Value=A099811.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099811.Bytes);
public long this[int i]=>Value[i];

public static A099811Inst Instance=new A099811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099812
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,3L,1L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,1L,3L,2L,3L,2L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,2L,2L,2L,3L,2L,2L,2L,3L,2L,3L,2L,2L,3L,2L,2L,3L,1L,3L,3L,2L,2L,3L,3L,2L,2L,2L,2L,3L,2L,3L,3L,2L,2L,2L,2L,2L,3L,3L,2L,3L,2L,2L,3L,3L,2L,3L,2L,3L,2L,2L,2L,3L,2L,2L,3L,2L,2L,4L };
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
public class A099812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099812Inst : IEnumerable<long>
{
public static readonly long[] Value=A099812.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099812.Bytes);
public long this[int i]=>Value[i];

public static A099812Inst Instance=new A099812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099813
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,4L,4L,1L,10L,5L,1L,15L,15L,1L,7L,35L,21L,1L,8L,56L,56L,8L,1L,36L,126L,84L,9L,1L,45L,210L,210L,45L,1L,11L,165L,462L,330L,55L,1L,12L,220L,792L,792L,220L,12L,1L,78L,715L,1716L,1287L,286L,13L,1L,91L,1001L,3003L,3003L,1001L,91L,1L,15L,455L,3003L,6435L,5005L,1365L };
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
public class A099813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099813Inst : IEnumerable<long>
{
public static readonly long[] Value=A099813.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099813.Bytes);
public long this[int i]=>Value[i];

public static A099813Inst Instance=new A099813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099814
{
public static readonly BigInteger[] Value={ 0L,11L,1111L,111111L,11111111L,1111111111L,111111111111L,11111111111111L,1111111111111111L,111111111111111111L,11111111111111111111UL,BigInteger.Parse("1111111111111111111111"),BigInteger.Parse("111111111111111111111111"),BigInteger.Parse("11111111111111111111111111"),BigInteger.Parse("1111111111111111111111111111"),BigInteger.Parse("111111111111111111111111111111"),BigInteger.Parse("11111111111111111111111111111111") };
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
public class A099814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099814Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A099814.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099814.Bytes);
public BigInteger this[int i]=>Value[i];

public static A099814Inst Instance=new A099814Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099815
{
public static readonly long[] Value={ 2L,7L,28L,62L,123L,202L,331L,456L,724L,937L,1391L,1526L,2084L,2424L,3107L,3771L,4694L,5704L,7119L,8062L,9632L,10987L,12332L,14506L,16626L,19296L,22492L,21669L,25179L,27430L,32044L,32555L,39916L,41032L };
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
public class A099815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099815Inst : IEnumerable<long>
{
public static readonly long[] Value=A099815.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099815.Bytes);
public long this[int i]=>Value[i];

public static A099815Inst Instance=new A099815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099816
{
public static readonly long[] Value={ 3L,4L,5L,2L,5L,5L,9L,9L,2L,8L,6L,6L,3L,8L,2L,9L,0L,8L,4L,9L,1L,9L,9L,3L,5L,0L,8L,0L,7L,9L,4L,9L,3L,7L,1L,4L,6L,8L,2L,8L,9L,6L,8L,3L,8L,5L,4L,1L,7L,6L,9L,2L,4L,0L,6L,1L,2L,2L,0L,6L,7L,9L,8L,4L,0L,5L,0L,8L,2L,1L,2L,3L,9L,0L,1L,8L,8L,1L,7L,5L,2L,4L,0L,7L,1L,3L,5L,1L,0L,5L,9L,4L,6L,2L,4L,9L,4L,3L,3L,1L,6L,4L,8L,1L,9L };
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
public class A099816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099816Inst : IEnumerable<long>
{
public static readonly long[] Value=A099816.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099816.Bytes);
public long this[int i]=>Value[i];

public static A099816Inst Instance=new A099816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099817
{
public static readonly long[] Value={ 1L,1L,9L,6L,3L,8L,7L,3L,3L,4L,2L,4L,3L,3L,7L,5L,2L,8L,1L,7L,6L,3L,9L,7L,1L,5L,2L,9L,4L,4L,5L,2L,0L,8L,6L,0L,2L,6L,0L,9L,8L,2L,0L,4L,2L,3L,2L,1L,0L,7L,8L,1L,8L,8L,5L,3L,8L,3L,6L,4L,0L,3L,4L,6L,9L,5L,5L,2L,3L,7L,5L,5L,4L,8L,2L,4L,1L,1L,4L,0L,8L,1L,2L,0L,9L,8L,2L,1L,5L,5L,6L,4L,2L,9L,8L,5L,9L,0L,8L,9L,4L,2L,8L,0L,7L };
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
public class A099817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099817Inst : IEnumerable<long>
{
public static readonly long[] Value=A099817.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099817.Bytes);
public long this[int i]=>Value[i];

public static A099817Inst Instance=new A099817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099818
{
public static readonly BigInteger[] Value={ 1L,196884L,864299970L,333202640600L,44656994071935L,3176440229784420L,146211911499519294L,4872010111798142520L,BigInteger.Parse("126142916465781843075"),BigInteger.Parse("2662842413150775245160"),BigInteger.Parse("47438786801234168813250"),BigInteger.Parse("731811377318137519245696") };
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
public class A099818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099818Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A099818.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099818.Bytes);
public BigInteger this[int i]=>Value[i];

public static A099818Inst Instance=new A099818Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099819
{
public static readonly BigInteger[] Value={ 744L,21493760L,20245856256L,4252023300096L,401490886656000L,22567393309593600L,874313719685775360L,BigInteger.Parse("25497827389410525184"),BigInteger.Parse("593121772421445058560"),BigInteger.Parse("11459912788444786513920"),BigInteger.Parse("189449976248893390028800") };
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
public class A099819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099819Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A099819.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099819.Bytes);
public BigInteger this[int i]=>Value[i];

public static A099819Inst Instance=new A099819Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099820
{
public static readonly long[] Value={ 0L,10L,100L,110L,1000L,1010L,1100L,1110L,10000L,10010L,10100L,10110L,11000L,11010L,11100L,11110L,100000L,100010L,100100L,100110L,101000L,101010L,101100L,101110L,110000L,110010L,110100L,110110L,111000L,111010L,111100L,111110L,1000000L };
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
public class A099820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099820Inst : IEnumerable<long>
{
public static readonly long[] Value=A099820.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099820.Bytes);
public long this[int i]=>Value[i];

public static A099820Inst Instance=new A099820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099821
{
public static readonly long[] Value={ 1L,11L,101L,111L,1001L,1011L,1101L,1111L,10001L,10011L,10101L,10111L,11001L,11011L,11101L,11111L,100001L,100011L,100101L,100111L,101001L,101011L,101101L,101111L,110001L,110011L,110101L,110111L,111001L,111011L,111101L,111111L,1000001L };
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
public class A099821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099821Inst : IEnumerable<long>
{
public static readonly long[] Value=A099821.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099821.Bytes);
public long this[int i]=>Value[i];

public static A099821Inst Instance=new A099821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099822
{
public static readonly long[] Value={ 1L,3L,6L,10L,13L,15L,19L,22L,26L,30L,33L,35L,38L,41L,43L,47L,53L,57L,59L,62L,66L,69L,71L,74L,78L,82L,85L,87L,91L,94L,97L,102L,105L,107L,110L,113L,115L,119L,123L,129L,131L,134L,138L,141L,143L,146L,151L,155L,158L,161L,165L,167L,173L,177L,179L,182L,185L,187L,191L,194L };
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
public class A099822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099822Inst : IEnumerable<long>
{
public static readonly long[] Value=A099822.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099822.Bytes);
public long this[int i]=>Value[i];

public static A099822Inst Instance=new A099822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099823
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,8L,12L,19L,29L,44L,67L,101L,153L,230L,346L,520L,780L,1171L,1755L,2631L,3942L,5905L,8846L,13247L,19839L,29707L,44482L,66604L,99722L,149309L,223546L,334692L,501096L,750226L,1123216L,1681635L,2517676L,3769356L,5643307L,8448900L,12649289L };
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
public class A099823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099823Inst : IEnumerable<long>
{
public static readonly long[] Value=A099823.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099823.Bytes);
public long this[int i]=>Value[i];

public static A099823Inst Instance=new A099823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099824
{
public static readonly BigInteger[] Value={ 2L,129L,24133L,3682913L,496165411L,62260698721L,7472966967499L,870530414842019L,99262851056183695L,11138479445180240497UL,BigInteger.Parse("1234379338586942892505"),BigInteger.Parse("135436174616790289414111"),BigInteger.Parse("14738971133550183905879827"),BigInteger.Parse("1593061976858155930556059673") };
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
public class A099824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099824Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A099824.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099824.Bytes);
public BigInteger this[int i]=>Value[i];

public static A099824Inst Instance=new A099824Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099825
{
public static readonly long[] Value={ 2L,5L,17L,77L,381L,1851L,8893L,41741L,191755L,868151L,3875933L,17120309L,74950547L,325590115L,1405167561L,6029676711L,25750781177L,109495928099L,463852117169L,1958476902435L,8244703036797L,34615624751259L,144991244981985L };
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
public class A099825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099825Inst : IEnumerable<long>
{
public static readonly long[] Value=A099825.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099825.Bytes);
public long this[int i]=>Value[i];

public static A099825Inst Instance=new A099825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099826
{
public static readonly long[] Value={ 2L,10L,100L,1264L,15116L,171148L,1864190L,19697700L,203534530L,2067129306L,20706364528L,205144046742L,2014349179358L,19632546354498L,190150622868298L,1831906588192414L,17567504017456404L,167794196312059488L,1597037992049539274L };
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
public class A099826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099826Inst : IEnumerable<long>
{
public static readonly long[] Value=A099826.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099826.Bytes);
public long this[int i]=>Value[i];

public static A099826Inst Instance=new A099826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099827
{
public static readonly BigInteger[] Value={ 0L,1L,33L,8051L,8252000L,25795462624L,200610400564224L,3371852494046112768L,BigInteger.Parse("110492114540967125581824"),BigInteger.Parse("6524555433591956305924325376"),BigInteger.Parse("652461835742417609568446054400000"),BigInteger.Parse("105080260346474296336209157187174400000") };
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
public class A099827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099827Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A099827.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099827.Bytes);
public BigInteger this[int i]=>Value[i];

public static A099827Inst Instance=new A099827Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099828
{
public static readonly BigInteger[] Value={ 1L,33L,8051L,257875L,806108207L,268736069L,4516906311683L,144545256245731L,105375212839937899L,105376229094957931L,BigInteger.Parse("16971048697474072945481"),BigInteger.Parse("16971114472329088045481"),BigInteger.Parse("6301272372663207205033976933") };
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
public class A099828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099828Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A099828.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099828.Bytes);
public BigInteger this[int i]=>Value[i];

public static A099828Inst Instance=new A099828Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099829
{
public static readonly long[] Value={ 12L,60L,120L,240L,420L,720L,840L,840L,1680L,1680L,2520L,2520L,4620L,5040L,5040L,5040L,9240L,9240L,9240L,9240L,18480L,18480L,18480L,18480L,18480L,27720L,27720L,27720L,27720L,27720L,27720L,55440L,55440L,55440L,55440L,55440L,55440L,55440L,55440L };
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
public class A099829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099829Inst : IEnumerable<long>
{
public static readonly long[] Value=A099829.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099829.Bytes);
public long this[int i]=>Value[i];

public static A099829Inst Instance=new A099829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099830
{
public static readonly long[] Value={ 12L,60L,120L,240L,420L,720L,1320L,840L,2640L,1680L,3360L,2520L,4620L,7920L,7560L,5040L,10080L,17160L,10920L,9240L,40320L,25200L,28560L,21840L,18480L,60480L,41580L,46200L,36960L,32760L,27720L,78540L,60060L,129360L,134640L,115920L,85680L,65520L,83160L };
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
public class A099830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099830Inst : IEnumerable<long>
{
public static readonly long[] Value=A099830.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099830.Bytes);
public long this[int i]=>Value[i];

public static A099830Inst Instance=new A099830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099831
{
public static readonly long[] Value={ 60L,84L,90L,132L,144L,210L,264L,270L,288L,300L,312L,330L,390L,408L,432L,440L,450L,456L,462L,468L,510L,520L,546L,552L,570L,576L,588L,612L,616L,680L,684L,690L,700L,728L,760L,770L,800L,810L,816L,828L,870L,910L,912L,918L,920L,952L,1044L,1064L,1100L,1104L,1116L };
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
public class A099831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099831Inst : IEnumerable<long>
{
public static readonly long[] Value=A099831.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099831.Bytes);
public long this[int i]=>Value[i];

public static A099831Inst Instance=new A099831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099832
{
public static readonly long[] Value={ 120L,168L,180L,252L,280L,336L,396L,528L,540L,560L,600L,624L,792L,864L,880L,936L,1040L,1050L,1056L,1120L,1176L,1224L,1232L,1248L,1350L,1368L,1380L,1404L,1456L,1620L,1632L,1650L,1656L,1710L,1728L,1740L,1760L,1764L,1824L,1836L,1860L,1960L,2002L,2052L,2080L };
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
public class A099832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099832Inst : IEnumerable<long>
{
public static readonly long[] Value=A099832.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099832.Bytes);
public long this[int i]=>Value[i];

public static A099832Inst Instance=new A099832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099833
{
public static readonly long[] Value={ 240L,360L,480L,504L,630L,672L,756L,780L,900L,960L,990L,1020L,1092L,1140L,1170L,1188L,1344L,1386L,1400L,1428L,1530L,1540L,1596L,1638L,1820L,1920L,1932L,1950L,2070L,2112L,2240L,2244L,2268L,2376L,2380L,2448L,2496L,2508L,2610L,2652L,2660L,2688L,2736L,2800L };
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
public class A099833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099833Inst : IEnumerable<long>
{
public static readonly long[] Value=A099833.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099833.Bytes);
public long this[int i]=>Value[i];

public static A099833Inst Instance=new A099833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099834
{
public static readonly long[] Value={ 5L,15L,53L,109L,209L,351L,573L,811L,1193L,1509L,1971L,2501L,3183L,3769L,4511L,5025L,5641L,6165L,6600L,6964L,7354L,7696L,7960L,8110L,8404L,8606L,8704L,8846L,8962L,9125L,9210L,9284L,9362L,9420L };
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
public class A099834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099834Inst : IEnumerable<long>
{
public static readonly long[] Value=A099834.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099834.Bytes);
public long this[int i]=>Value[i];

public static A099834Inst Instance=new A099834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099835
{
public static readonly long[] Value={ 2L,5L,7L,11L,14L,17L,21L,23L,29L,31L,34L,37L,39L,42L,46L,51L,55L,58L,61L,65L,67L,70L,73L,77L,79L,83L,86L,89L,93L,95L,101L,103L,106L,109L,111L,114L,118L,122L,127L,130L,133L,137L,139L,142L,145L,149L,154L,157L,159L,163L,166L,170L,174L,178L,181L,183L,186L,190L,193L,195L };
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
public class A099835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099835Inst : IEnumerable<long>
{
public static readonly long[] Value=A099835.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099835.Bytes);
public long this[int i]=>Value[i];

public static A099835Inst Instance=new A099835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099836
{
public static readonly long[] Value={ 1L,3L,5L,8L,11L,16L,19L,25L,29L,32L,41L,47L,53L,61L,67L,73L,81L,89L,101L,107L,113L,125L,128L,137L,149L,157L,167L,173L,181L,193L,199L,223L,229L,239L,243L,256L,263L,271L,281L,289L,307L,313L,331L,343L,349L,359L,367L,379L,389L,401L,419L,431L,439L,449L,461L,467L,487L };
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
public class A099836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099836Inst : IEnumerable<long>
{
public static readonly long[] Value=A099836.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099836.Bytes);
public long this[int i]=>Value[i];

public static A099836Inst Instance=new A099836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099837
{
public static readonly long[] Value={ 1L,-1L,-1L,2L,-1L,-1L,2L,-1L,-1L,2L,-1L,-1L,2L,-1L,-1L,2L,-1L,-1L,2L,-1L,-1L,2L,-1L,-1L,2L,-1L,-1L,2L,-1L,-1L,2L,-1L,-1L,2L,-1L,-1L,2L,-1L,-1L,2L,-1L,-1L,2L,-1L,-1L,2L,-1L,-1L,2L,-1L,-1L,2L,-1L,-1L,2L,-1L,-1L,2L,-1L,-1L,2L,-1L,-1L,2L,-1L,-1L,2L,-1L,-1L,2L,-1L,-1L };
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
public class A099837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099837Inst : IEnumerable<long>
{
public static readonly long[] Value=A099837.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099837.Bytes);
public long this[int i]=>Value[i];

public static A099837Inst Instance=new A099837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099838
{
public static readonly long[] Value={ 1L,-2L,0L,3L,-3L,0L,3L,-3L,0L,3L,-3L,0L,3L,-3L,0L,3L,-3L,0L,3L,-3L,0L,3L,-3L,0L,3L,-3L,0L,3L,-3L,0L,3L,-3L,0L,3L,-3L,0L,3L,-3L,0L,3L,-3L,0L,3L,-3L,0L,3L,-3L,0L,3L,-3L,0L,3L,-3L,0L,3L,-3L,0L,3L,-3L,0L,3L,-3L,0L,3L,-3L,0L,3L,-3L,0L,3L,-3L,0L,3L,-3L,0L,3L,-3L,0L,3L,-3L,0L,3L,-3L,0L,3L,-3L,0L,3L,-3L,0L,3L,-3L,0L,3L,-3L,0L,3L,-3L,0L,3L,-3L,0L };
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
public class A099838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099838Inst : IEnumerable<long>
{
public static readonly long[] Value=A099838.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099838.Bytes);
public long this[int i]=>Value[i];

public static A099838Inst Instance=new A099838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099839
{
public static readonly long[] Value={ 1L,-11L,105L,-995L,9425L,-89275L,845625L,-8009875L,75870625L,-718656875L,6807215625L,-64478871875L,610752640625L,-5785132046875L,54797557265625L,-519049912421875L,4916511337890625L,-46569863816796875L,441116081478515625L,-4178311495701171875L };
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
public class A099839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099839Inst : IEnumerable<long>
{
public static readonly long[] Value=A099839.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099839.Bytes);
public long this[int i]=>Value[i];

public static A099839Inst Instance=new A099839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099840
{
public static readonly long[] Value={ 1L,-6L,20L,-120L,400L,-2400L,8000L,-48000L,160000L,-960000L,3200000L,-19200000L,64000000L,-384000000L,1280000000L,-7680000000L,25600000000L,-153600000000L,512000000000L,-3072000000000L,10240000000000L,-61440000000000L,204800000000000L,-1228800000000000L };
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
public class A099840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099840Inst : IEnumerable<long>
{
public static readonly long[] Value=A099840.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099840.Bytes);
public long this[int i]=>Value[i];

public static A099840Inst Instance=new A099840Inst();

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