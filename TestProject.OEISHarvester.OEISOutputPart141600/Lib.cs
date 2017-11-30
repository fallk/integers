using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A170905
{
public static readonly long[] Value={ 0L,1L,2L,2L,4L,2L,4L,6L,8L,2L,4L,6L,10L,10L,8L,14L,16L,2L,4L,6L,10L,10L,10L,18L,26L,18L,8L,14L,24L,28L,20L,32L,32L,2L,4L,6L,10L,10L,10L,18L,26L,18L,10L,18L,30L,38L,34L,42L,58L,34L,8L,14L,24L,28L,28L,44L,68L,60L,28L,32L,56L,70L,50L,70L,64L,2L,4L,6L,10L,10L,10L,18L,26L,18L,10L,18L,30L,38L,34L,42L };
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
public class A170905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170905Inst : IEnumerable<long>
{
public static readonly long[] Value=A170905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170905.Bytes);
public long this[int i]=>Value[i];

public static A170905Inst Instance=new A170905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170906
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,2L,2L,2L,1L,1L,2L,2L,4L,1L,2L,1L,1L,2L,2L,4L,2L,2L,3L,3L,1L,1L,2L,2L,4L,2L,4L,5L,4L,1L,2L,1L,1L,2L,2L,4L,2L,4L,6L,6L,1L,2L,3L,3L,1L,1L,2L,2L,4L,2L,4L,6L,8L,1L,2L,3L,5L,3L,3L,1L,1L,2L,2L,4L,2L,4L,6L,8L,2L,2L,3L,5L,5L,3L,5L,4L,1L,1L,2L,2L,4L,2L,4L,6L,8L,2L,4L,5L,6L,7L,6L,6L,4L,1L,2L,1L };
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
public class A170906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170906Inst : IEnumerable<long>
{
public static readonly long[] Value=A170906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170906.Bytes);
public long this[int i]=>Value[i];

public static A170906Inst Instance=new A170906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170907
{
public static readonly long[] Value={ 1L,4L,8L,13L,20L,28L,37L,47L,59L,73L,87L,101L,118L,137L,156L,176L,198L,223L,248L,271L,299L,328L,357L,386L,418L,454L,489L,522L,558L,598L,638L,678L,720L,766L,812L,858L,907L,956L,1004L,1048L,1104L,1161L,1217L,1268L,1325L,1386L,1446L,1505L,1567L,1635L,1703L,1765L };
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
public class A170907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170907Inst : IEnumerable<long>
{
public static readonly long[] Value=A170907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170907.Bytes);
public long this[int i]=>Value[i];

public static A170907Inst Instance=new A170907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170908
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,2L,41L,169L,541L,71L,8983L,44419L,20183L,802751L,445223L,52275409L,166257661L,26261353L,2160586067L,4871649347L,3667033133L,2762567051857L,10112898715063L,12453960597367L,24546527305109L,48002125894859L,5216471357244949L,159144839200310539L };
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
public class A170908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170908Inst : IEnumerable<long>
{
public static readonly long[] Value=A170908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170908.Bytes);
public long this[int i]=>Value[i];

public static A170908Inst Instance=new A170908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170909
{
public static readonly BigInteger[] Value={ 1L,1L,2L,3L,24L,15L,360L,5040L,40320L,11340L,1814400L,39916800L,47900160L,6227020800L,7925299200L,1307674368000L,20922789888000L,11115232128000L,3201186852864000L,24329020081766400L,48658040163532800L,BigInteger.Parse("51090942171709440000"),BigInteger.Parse("1124000727777607680000") };
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
public class A170909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170909Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170909.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A170909.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170909Inst Instance=new A170909Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170910
{
public static readonly long[] Value={ -1L,1L,1L,3L,1L,13L,1L,27L,8L,91L,1L,1213L,1L,505L,1919L,2955L,1L,24557L,1L,1136313L,34943L,12277L,1L,65978519L,624L,57331L,58528L,195948483L,1L,1052424027703L,1L,77010795L,7085759L,1179631L,37497599L,7047825380633L,1L,5242861L,89281919L,355723139681937L };
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
public class A170910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170910Inst : IEnumerable<long>
{
public static readonly long[] Value=A170910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170910.Bytes);
public long this[int i]=>Value[i];

public static A170910Inst Instance=new A170910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170911
{
public static readonly long[] Value={ 1L,2L,3L,8L,5L,72L,7L,128L,81L,800L,11L,13824L,13L,6272L,30375L,32768L,17L,419904L,19L,20480000L,750141L,247808L,23L,1528823808L,15625L,1384448L,1594323L,5035261952L,29L,30233088000000L,31L,2147483648L,235782657L,37879808L,1313046875L,240734712102912L,37L,189267968L };
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
public class A170911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170911Inst : IEnumerable<long>
{
public static readonly long[] Value=A170911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170911.Bytes);
public long this[int i]=>Value[i];

public static A170911Inst Instance=new A170911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170912
{
public static readonly BigInteger[] Value={ -1L,1L,7L,131L,1843L,97261L,4683059L,1331727679L,568285777L,9521655609199L,175554688130609L,11334988388673161L,3457026400678609391L,BigInteger.Parse("6594042537777612027841"),BigInteger.Parse("249248595232521829462213"),BigInteger.Parse("268938575250382935485761673113"),BigInteger.Parse("3929672369519648081411955883"),BigInteger.Parse("4719016202742955262333630268611") };
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
public class A170912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170912Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170912.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A170912.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170912Inst Instance=new A170912Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170913
{
public static readonly BigInteger[] Value={ 2L,24L,360L,13440L,453600L,47900160L,5448643200L,2988969984000L,3126159036000L,101370917007360000L,4390627842881280000L,BigInteger.Parse("552984315270266880000"),BigInteger.Parse("393839317506450816000000"),BigInteger.Parse("1465809349094778175488000000"),BigInteger.Parse("129517997955171415349760000000"),BigInteger.Parse("263130836933693530167218012160000000") };
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
public class A170913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170913Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170913.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A170913.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170913Inst Instance=new A170913Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170914
{
public static readonly BigInteger[] Value={ 1L,0L,-1L,1L,-19L,19L,-659L,37L,-7675L,40043L,-3578279L,1123009L,-95259767L,7091713L,-85215100151L,832857559L,-4180679675171L,63804880881241L,-6399968826052559L,5697831990097981L,-478887035449041839L,252737248941887573L,BigInteger.Parse("-1123931378903214542099"),35703551772944759L };
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
public class A170914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170914Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170914.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A170914.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170914Inst Instance=new A170914Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170915
{
public static readonly BigInteger[] Value={ 1L,1L,6L,6L,120L,120L,5040L,280L,72576L,362880L,39916800L,11975040L,1245404160L,88957440L,1307674368000L,11675664000L,71137485619200L,1067062284288000L,121645100408832000L,101370917007360000L,10218188434341888000UL,5109094217170944000L,BigInteger.Parse("25852016738884976640000") };
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
public class A170915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170915Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170915.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A170915.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170915Inst Instance=new A170915Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170916
{
public static readonly BigInteger[] Value={ -1L,1L,1L,73L,353L,36499L,24257L,302426881L,87721L,348958703L,226786069421L,62199570679633L,62531659610839L,8559230855533306387L,235495453816743509L,BigInteger.Parse("2644298730170939345197"),BigInteger.Parse("281737789368631676609"),BigInteger.Parse("39043444996461526437828311"),BigInteger.Parse("6203284926188598376335167") };
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
public class A170916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170916Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170916.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A170916.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170916Inst Instance=new A170916Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170917
{
public static readonly BigInteger[] Value={ 6L,120L,840L,362880L,14968800L,9340531200L,49037788800L,3201186852864000L,8485288812000L,182467650613248000L,BigInteger.Parse("908859963476424960000"),BigInteger.Parse("1424498881530396672000000"),BigInteger.Parse("10633661572674172032000000"),BigInteger.Parse("8289151869130970582384640000000"),BigInteger.Parse("1720739115690134518218240000000"),BigInteger.Parse("97858575719142221963014963200000000") };
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
public class A170917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170917Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170917.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A170917.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170917Inst Instance=new A170917Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170918
{
public static readonly BigInteger[] Value={ 1L,-1L,7L,-14L,54L,-1112L,6574L,-48488L,1143731L,-14813072L,16252211L,-3500388967L,125127865048L,-158589803803L,33133618166566L,-30512906279732L,4378989933312913L,-330336346477870319L,1981395373839282068L,BigInteger.Parse("-251479418962683770473"),BigInteger.Parse("79893293800974935213"),BigInteger.Parse("-31493610597939643431532") };
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
public class A170918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170918Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170918.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A170918.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170918Inst Instance=new A170918Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170919
{
public static readonly long[] Value={ 1L,1L,3L,3L,5L,45L,105L,315L,2835L,14175L,5775L,467775L,6081075L,2837835L,212837625L,70945875L,3618239625L,97692469875L,206239658625L,9280784638125L,1031198293125L,142924083427125L,322279795963125L,101111706320625L,136968913284328125L,161872352063296875L };
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
public class A170919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170919Inst : IEnumerable<long>
{
public static readonly long[] Value=A170919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170919.Bytes);
public long this[int i]=>Value[i];

public static A170919Inst Instance=new A170919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170920
{
public static readonly BigInteger[] Value={ -1L,-2L,-211L,-2743L,-1418638L,-2268068L,-550669394L,-23861846102L,-48726978122069L,-461240499534601L,-336080282371649483L,-2842820955735934463L,BigInteger.Parse("-1628158082048867402632"),BigInteger.Parse("-331277549738199913530049"),BigInteger.Parse("-14001180998026101838535141"),BigInteger.Parse("-1500970948062470951644822898"),BigInteger.Parse("-889277588648296174667504384505014") };
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
public class A170920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170920Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170920.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A170920.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170920Inst Instance=new A170920Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170921
{
public static readonly BigInteger[] Value={ 3L,27L,3645L,98415L,93002175L,279006525L,112997642625L,9152809052625L,31714483367345625L,513774630550999125L,BigInteger.Parse("644053197583573903125"),BigInteger.Parse("9363542641791959053125"),BigInteger.Parse("8848547796493401305203125"),BigInteger.Parse("3105840276569183858126296875"),BigInteger.Parse("215997073779584150133328828125"),BigInteger.Parse("38490678547521895553759197171875") };
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
public class A170921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170921Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170921.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A170921.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170921Inst Instance=new A170921Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170922
{
public static readonly long[] Value={ 1L,-1L,1L,-13L,3L,-37L,9L,-1861L,7L,-1491L,93L,-81001L,315L,-69705L,1083L,-63586357L,3855L,-438821L,13797L,-822684711L,49689L,-186369117L,182361L,-704368012465L,10485L,-10165801275L,619549L,-9738266477517L,9256395L,-566066862375L,34636833L,-140047960975823893L };
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
public class A170922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170922Inst : IEnumerable<long>
{
public static readonly long[] Value=A170922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170922.Bytes);
public long this[int i]=>Value[i];

public static A170922Inst Instance=new A170922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170923
{
public static readonly long[] Value={ 2L,8L,8L,128L,32L,512L,128L,32768L,128L,32768L,2048L,2097152L,8192L,2097152L,32768L,2147483648L,131072L,16777216L,524288L,34359738368L,2097152L,8589934592L,8388608L,35184372088832L,524288L,549755813888L,33554432L,562949953421312L,536870912L,35184372088832L };
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
public class A170923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170923Inst : IEnumerable<long>
{
public static readonly long[] Value=A170923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170923.Bytes);
public long this[int i]=>Value[i];

public static A170923Inst Instance=new A170923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170924
{
public static readonly long[] Value={ 1L,3L,1L,27L,3L,39L,9L,2955L,7L,1737L,93L,88047L,315L,79779L,1083L,77010795L,3855L,488391L,13797L,905252529L,49689L,204066351L,182361L,756251509503L,10485L,10978530465L,619549L,10462007147787L,9256395L,603860858253L,34636833L,150202954242966315L };
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
public class A170924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170924Inst : IEnumerable<long>
{
public static readonly long[] Value=A170924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170924.Bytes);
public long this[int i]=>Value[i];

public static A170924Inst Instance=new A170924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170925
{
public static readonly long[] Value={ 1L,-1L,-2L,1L,-1L,3L,3L,-1L,-2L,-2L,4L,-4L,-1L,-3L,-3L,2L,1L,9L,-1L,6L,7L,-8L,-10L,1L,-1L,0L,-2L,0L,2L,-1L,4L,-4L,-1L,-5L,14L,-15L,-7L,9L,11L,7L,0L,3L,-14L,17L,-7L,18L,4L,-6L,-7L,-25L,-12L,-5L,-13L,-3L,9L,-14L,25L,10L,-2L,8L,17L,1L,2L,13L,4L,0L,-4L,7L,13L,-27L,-42L,11L,5L,5L,10L,-24L,3L,-21L,-4L,0L,-32L,27L,29L,-1L,-4L,43L,26L,-7L,-41L,-9L,27L,-11L };
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
public class A170925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170925Inst : IEnumerable<long>
{
public static readonly long[] Value=A170925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170925.Bytes);
public long this[int i]=>Value[i];

public static A170925Inst Instance=new A170925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170926
{
public static readonly long[] Value={ 0L,0L,1L,3L,4L,5L,10L,17L,20L,21L,25L,30L,33L,40L,58L,77L,84L,85L,89L,94L,97L,104L,121L,138L,145L,151L,164L,177L,190L,222L,278L,325L,340L,341L,345L,350L,353L,360L,377L,394L,401L,407L,420L,433L,446L,478L,533L,578L,593L,599L,612L,625L,638L,669L,720L,761L,781L,806L,845L,884L,942L };
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
public class A170926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170926Inst : IEnumerable<long>
{
public static readonly long[] Value=A170926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170926.Bytes);
public long this[int i]=>Value[i];

public static A170926Inst Instance=new A170926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170927
{
public static readonly long[] Value={ 1L,2L,5L,12L,21L,44L,89L,180L,362L,728L,1459L,2921L,5843L,11690L,23384L,46770L,93544L,187094L,374193L,748391L,1496786L,2993576L,5987158L,11974321L,23948647L,47897300L,95794608L,191589222L,383178450L,766356910L,1532713828L,3065427664L,6130855333L,12261710675L };
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
public class A170927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170927Inst : IEnumerable<long>
{
public static readonly long[] Value=A170927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170927.Bytes);
public long this[int i]=>Value[i];

public static A170927Inst Instance=new A170927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170928
{
public static readonly long[] Value={ 822L,1195L,1636L,2472L,3720L,5856L,8737L,12202L,16335L,21333L,27612L,35185L,43968L,54013L,65464L,78281L,92422L,107932L,126404L,147816L,171556L,197041L,224506L,253587L,285314L,320620L,359151L,400064L,442886L,487920L,536844L,589129L,644797L };
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
public class A170928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170928Inst : IEnumerable<long>
{
public static readonly long[] Value=A170928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170928.Bytes);
public long this[int i]=>Value[i];

public static A170928Inst Instance=new A170928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170929
{
public static readonly long[] Value={ 1L,4L,5L,3L,7L,17L,17L,7L,6L,13L,13L,13L,32L,55L,45L,15L,6L,13L,13L,13L,31L,51L,41L,20L,25L,39L,39L,58L,120L,159L,109L,31L,6L,13L,13L,13L,31L,51L,41L,20L,25L,39L,39L,58L,119L,155L,105L,36L,25L,39L,39L,57L,113L,143L,102L,65L,89L,117L,136L,236L,400L,431L,253L,63L,6L,13L,13L,13L,31L };
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
public class A170929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170929Inst : IEnumerable<long>
{
public static readonly long[] Value=A170929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170929.Bytes);
public long this[int i]=>Value[i];

public static A170929Inst Instance=new A170929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170930
{
public static readonly long[] Value={ 0L,21L,63L,252L,945L,3591L,13608L,51597L,195615L,741636L,2811753L,10660167L,40415760L,153227781L,580930623L,2202475212L,8350217505L,31658078151L,120024886968L,455048895357L,1725221346975L,6540810726996L,24798096221913L };
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
public class A170930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170930Inst : IEnumerable<long>
{
public static readonly long[] Value=A170930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170930.Bytes);
public long this[int i]=>Value[i];

public static A170930Inst Instance=new A170930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170931
{
public static readonly long[] Value={ 2L,4L,24L,112L,544L,2624L,12672L,61184L,295424L,1426432L,6887424L,33255424L,160571392L,775307264L,3743514624L,18075287552L,87275208704L,421401985024L,2034708774912L,9824443039744L,47436607258624L,229044201193472L };
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
public class A170931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170931Inst : IEnumerable<long>
{
public static readonly long[] Value=A170931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170931.Bytes);
public long this[int i]=>Value[i];

public static A170931Inst Instance=new A170931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170932
{
public static readonly long[] Value={ 1L,63L,2205L,56595L,1188495L,21630609L,353299947L,5299499205L,74192988870L,980996186170L,12360551945742L,149450309889426L,1743586948709970L,19715944727720430L,216875392004924730L,2327795874186192102L };
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
public class A170932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170932Inst : IEnumerable<long>
{
public static readonly long[] Value=A170932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170932.Bytes);
public long this[int i]=>Value[i];

public static A170932Inst Instance=new A170932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170933
{
public static readonly long[] Value={ 7L,8L,9L,12L,16L,21L,29L,41L,58L,83L,120L,174L,253L,369L,539L,788L,1153L,1688L,2472L,3621L,5305L,7773L,11390L,16691L,24460L,35846L,52533L,76989L,112831L,165360L,242345L,355172L,520528L,762869L,1118037L };
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
public class A170933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170933Inst : IEnumerable<long>
{
public static readonly long[] Value=A170933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170933.Bytes);
public long this[int i]=>Value[i];

public static A170933Inst Instance=new A170933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170934
{
public static readonly long[] Value={ 4L,4L,5L,7L,9L,12L,17L,24L,34L,49L,71L,103L,150L,219L,320L,468L,685L,1003L,1469L,2152L,3153L,4620L,6770L,9921L,14539L,21307L,31226L,45763L,67068L,98292L,144053L,211119L,309409L,453460L,664577L,973984L,1427442L,2092017L,3065999L,4493439L,6585454L,9651451L };
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
public class A170934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170934Inst : IEnumerable<long>
{
public static readonly long[] Value=A170934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170934.Bytes);
public long this[int i]=>Value[i];

public static A170934Inst Instance=new A170934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170935
{
public static readonly long[] Value={ 1L,1L,2L,6L,12L,24L,54L,117L,247L,532L,1148L,2460L,5280L,11352L,24381L,52353L,112462L,241570L,518840L,1114416L,2393694L,5141385L,11043135L,23719608L,50947336L,109429624L,235043840L,504850560L,1084367865L,2329112625L,5002699050L,10745292366L,23079802756L,49573086472L };
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
public class A170935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170935Inst : IEnumerable<long>
{
public static readonly long[] Value=A170935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170935.Bytes);
public long this[int i]=>Value[i];

public static A170935Inst Instance=new A170935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170936
{
public static readonly long[] Value={ 2L,7L,1L,7L,5L,2L,5L,8L,5L,3L,1L,9L,5L,1L,1L,7L,1L,6L,5L,2L,8L,8L,4L,3L,7L,2L,2L,4L,9L,8L,5L,8L,8L,9L,2L,0L,7L,0L,9L,4L,6L,4L,1L,1L,1L,4L,6L,1L,7L,7L,9L,4L,5L,3L,0L,9L,8L,0L,8L,4L,6L,2L,7L,0L,7L,5L,4L,6L,7L,0L,5L,8L,3L,0L,4L,7L,0L,0L,1L,1L,7L,7L,6L,8L,1L,0L,8L,5L,1L,5L,1L,6L,4L,1L,8L,7L,2L,9L,5L };
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
public class A170936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170936Inst : IEnumerable<long>
{
public static readonly long[] Value=A170936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170936.Bytes);
public long this[int i]=>Value[i];

public static A170936Inst Instance=new A170936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170937
{
public static readonly long[] Value={ 1L,0L,8L,3L,9L,2L,3L,3L,2L,7L,3L,3L,8L,6L,9L,4L,5L,4L,3L,4L,7L,5L,7L,5L,2L,0L,6L,1L,2L,1L,1L,9L,7L,1L,7L,2L,1L,3L,4L,4L,9L,6L,7L,5L,2L,7L,4L,7L,5L,3L,8L,9L,8L,5L,6L,3L,1L,9L,7L,2L,2L,0L,4L,2L,5L,3L,8L,9L,5L,6L,0L,9L,8L,1L,2L,0L,7L,8L,6L,0L,0L,6L,2L,4L,3L,9L,2L,9L,1L,3L,2L,9L,7L,7L,6L,3L,3L,0L,0L };
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
public class A170937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170937Inst : IEnumerable<long>
{
public static readonly long[] Value=A170937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170937.Bytes);
public long this[int i]=>Value[i];

public static A170937Inst Instance=new A170937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170938
{
public static readonly long[] Value={ 4L,8L,22L,74L,274L,1058L,4162L,16514L,65794L,262658L,1049602L,4196354L,16781314L,67117058L,268451842L,1073774594L,4295032834L,17180000258L,68719738882L,274878431234L,1099512676354L,4398048608258L,17592190238722L,70368752566274L,281474993487874L,1125899940397058L };
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
public class A170938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170938Inst : IEnumerable<long>
{
public static readonly long[] Value=A170938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170938.Bytes);
public long this[int i]=>Value[i];

public static A170938Inst Instance=new A170938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170939
{
public static readonly long[] Value={ 2L,4L,14L,58L,242L,994L,4034L,16258L,65282L,261634L,1047554L,4192258L,16773122L,67100674L,268419074L,1073709058L,4294901762L,17179738114L,68719214594L,274877382658L,1099510579202L,4398044413954L,17592181850114L,70368735789058L,281474959933442L,1125899873288194L };
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
public class A170939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170939Inst : IEnumerable<long>
{
public static readonly long[] Value=A170939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170939.Bytes);
public long this[int i]=>Value[i];

public static A170939Inst Instance=new A170939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170940
{
public static readonly long[] Value={ 0L,10L,54L,238L,990L,4030L,16254L,65278L,261630L,1047550L,4192254L,16773118L,67100670L,268419070L,1073709054L,4294901758L,17179738110L,68719214590L,274877382654L,1099510579198L,4398044413950L,17592181850110L,70368735789054L,281474959933438L,1125899873288190L };
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
public class A170940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170940Inst : IEnumerable<long>
{
public static readonly long[] Value=A170940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170940.Bytes);
public long this[int i]=>Value[i];

public static A170940Inst Instance=new A170940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170941
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,13L,37L,112L,363L,1235L,4427L,16526L,64351L,259471L,1083935L,4668704L,20732609L,94607409L,443476993L,2130346450L,10482534517L,52740593933L,271186949333L,1423127827792L,7618169603035L,41554791114643L,230857090312059L,1305086617517534L };
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
public class A170941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170941Inst : IEnumerable<long>
{
public static readonly long[] Value=A170941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170941.Bytes);
public long this[int i]=>Value[i];

public static A170941Inst Instance=new A170941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170942
{
public static readonly long[] Value={ 1L,2L,0L,3L,1L,1L,0L,0L,1L,4L,2L,2L,1L,1L,2L,2L,0L,1L,0L,0L,1L,1L,0L,2L,1L,0L,0L,0L,1L,1L,2L,0L,0L,5L,3L,3L,2L,2L,3L,3L,1L,2L,1L,1L,2L,2L,1L,3L,2L,1L,1L,1L,2L,2L,3L,1L,1L,3L,1L,1L,0L,0L,1L,2L,0L,1L,0L,0L,1L,1L,0L,2L,1L,0L,0L,0L,1L,1L,2L,0L,0L,2L,0L,1L,0L,0L,1L,3L,1L,2L,1L,1L,2L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,0L };
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
public class A170942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170942Inst : IEnumerable<long>
{
public static readonly long[] Value=A170942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170942.Bytes);
public long this[int i]=>Value[i];

public static A170942Inst Instance=new A170942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170943
{
public static readonly long[] Value={ 1L,4L,10L,12L,13L,28L,30L,36L,39L,40L,82L,84L,90L,91L,108L,117L,120L,121L,244L,246L,252L,270L,273L,324L,328L,351L,360L,363L,364L,730L,732L,738L,756L,757L,810L,819L,820L,949L,972L,984L,1036L,1053L,1080L,1089L,1092L,1093L,2188L,2190L,2196L,2214L,2268L,2271L,2362L,2430L };
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
public class A170943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170943Inst : IEnumerable<long>
{
public static readonly long[] Value=A170943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170943.Bytes);
public long this[int i]=>Value[i];

public static A170943Inst Instance=new A170943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170944
{
public static readonly long[] Value={ 2L,5L,6L,7L,8L,11L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,29L,31L,32L,33L,34L,35L,37L,38L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,83L,85L,86L,87L,88L,89L };
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
public class A170944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170944Inst : IEnumerable<long>
{
public static readonly long[] Value=A170944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170944.Bytes);
public long this[int i]=>Value[i];

public static A170944Inst Instance=new A170944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170945
{
public static readonly BigInteger[] Value={ 3L,11L,27L,41L,73L,53L,43L,103L,1321L,497867L,323L,467L,11311L,20141L,12169L,BigInteger.Parse("232159532264041847249") };
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
public class A170945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170945Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170945.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A170945.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170945Inst Instance=new A170945Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170946
{
public static readonly BigInteger[] Value={ 2L,5L,20L,107L,870L,9436L,122840L,1863359L,32019826L,613981447L,12989756316L,300559406027L,7550660328494L,204687564072918L,5955893472990664L,185158932576089787L,6125200100394894738L,BigInteger.Parse("214837724735760642773") };
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
public class A170946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170946Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170946.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A170946.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170946Inst Instance=new A170946Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170947
{
public static readonly long[] Value={ 2L,5L,20L,85L,418L,2242L,12828L,77777L,493286L,3260485L,22314484L,157735801L,1147285362L,8570960234L,65611620808L,513963377327L,4113363020482L,33598074760393L,279764563749076L,2372822051513583L,20481425601917742L };
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
public class A170947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170947Inst : IEnumerable<long>
{
public static readonly long[] Value=A170947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170947.Bytes);
public long this[int i]=>Value[i];

public static A170947Inst Instance=new A170947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170948
{
public static readonly BigInteger[] Value={ 0L,0L,0L,11L,226L,3597L,55006L,892791L,15763270L,305360481L,6483720916L,150200835113L,3774756521566L,102339496556342L,2977913930684928L,92579209306356230L,3062597993515937128L,BigInteger.Parse("107418845568842941190") };
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
public class A170948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170948Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170948.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A170948.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170948Inst Instance=new A170948Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170949
{
public static readonly long[] Value={ 1L,3L,2L,4L,8L,6L,5L,7L,9L,15L,13L,11L,10L,12L,14L,16L,24L,22L,20L,18L,17L,19L,21L,23L,25L,35L,33L,31L,29L,27L,26L,28L,30L,32L,34L,36L,48L,46L,44L,42L,40L,38L,37L,39L,41L,43L,45L,47L,49L,63L,61L,59L,57L,55L,53L,51L,50L,52L,54L,56L,58L,60L,62L,64L,80L,78L,76L,74L,72L };
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
public class A170949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170949Inst : IEnumerable<long>
{
public static readonly long[] Value=A170949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170949.Bytes);
public long this[int i]=>Value[i];

public static A170949Inst Instance=new A170949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170950
{
public static readonly long[] Value={ 1L,3L,2L,4L,7L,6L,8L,5L,9L,13L,12L,14L,11L,15L,10L,16L,21L,20L,22L,19L,23L,18L,24L,17L,25L,31L,30L,32L,29L,33L,28L,34L,27L,35L,26L,36L,43L,42L,44L,41L,45L,40L,46L,39L,47L,38L,48L,37L,49L,57L,56L,58L,55L,59L,54L,60L,53L,61L,52L,62L,51L,63L,50L,64L,73L,72L,74L,71L,75L,70L,76L,69L,77L,68L,78L };
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
public class A170950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170950Inst : IEnumerable<long>
{
public static readonly long[] Value=A170950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170950.Bytes);
public long this[int i]=>Value[i];

public static A170950Inst Instance=new A170950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170951
{
public static readonly long[] Value={ 9L,12L,13L,27L,28L,30L,36L,39L,40L,81L,82L,84L,90L,91L,108L,117L,120L,121L,243L,244L,246L,252L,270L,273L,324L,328L,351L,360L,363L,364L,729L,730L,732L,738L,756L,757L,810L,819L,820L,949L,972L,984L,1036L,1053L,1080L,1089L,1092L,1093L,2187L };
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
public class A170951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170951Inst : IEnumerable<long>
{
public static readonly long[] Value=A170951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170951.Bytes);
public long this[int i]=>Value[i];

public static A170951Inst Instance=new A170951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170952
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,3L,4L,0L,1L,3L,9L,12L,13L,0L,1L,3L,9L,10L,27L,36L,39L,40L,0L,1L,3L,9L,27L,30L,81L,85L,108L,117L,120L,121L,0L,1L,3L,9L,27L,28L,81L,90L,91L,220L,243L,255L,307L,324L,351L,360L,363L,364L,0L,1L,3L,9L,27L,81L,84L,175L,243L,270L,273L,625L,660L,729L,733L,765L,921L,972L,1053L };
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
public class A170952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170952Inst : IEnumerable<long>
{
public static readonly long[] Value=A170952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170952.Bytes);
public long this[int i]=>Value[i];

public static A170952Inst Instance=new A170952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170953
{
public static readonly long[] Value={ 0L,0L,1L,3L,9L,28L,88L,278L,873L,2743L,8616L,27067L,85033L,267138L,839238L,2636541L,8282935L,26021607L,81749288L,256822959L,806833118L,2534740993L,7963123681L,25016890852L,78592880514L,246906816045L,775680639403L,2436872598277L,7655661052477L,24050968520831L };
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
public class A170953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170953Inst : IEnumerable<long>
{
public static readonly long[] Value=A170953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170953.Bytes);
public long this[int i]=>Value[i];

public static A170953Inst Instance=new A170953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170954
{
public static readonly long[] Value={ 3L,4L,8L,9L,11L,16L,21L,25L,81L,6241L,25747L };
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
public class A170954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170954Inst : IEnumerable<long>
{
public static readonly long[] Value=A170954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170954.Bytes);
public long this[int i]=>Value[i];

public static A170954Inst Instance=new A170954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170955
{
public static readonly long[] Value={ 1L,91L,991L,9991L,99991L,999991L,9999991L,99999991L,999999991L,9999999991L,99999999991L,999999999991L,9999999999991L,99999999999991L,999999999999991L,9999999999999991L,99999999999999991L,999999999999999991L };
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
public class A170955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170955Inst : IEnumerable<long>
{
public static readonly long[] Value=A170955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170955.Bytes);
public long this[int i]=>Value[i];

public static A170955Inst Instance=new A170955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170956
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L };
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
public class A170956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170956Inst : IEnumerable<long>
{
public static readonly long[] Value=A170956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170956.Bytes);
public long this[int i]=>Value[i];

public static A170956Inst Instance=new A170956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170957
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,2L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L };
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
public class A170957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170957Inst : IEnumerable<long>
{
public static readonly long[] Value=A170957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170957.Bytes);
public long this[int i]=>Value[i];

public static A170957Inst Instance=new A170957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170958
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,2L,1L,0L,1L,2L,0L,0L,1L,2L,0L,0L,2L,1L,0L,0L,2L,1L,0L,1L,2L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L };
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
public class A170958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170958Inst : IEnumerable<long>
{
public static readonly long[] Value=A170958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170958.Bytes);
public long this[int i]=>Value[i];

public static A170958Inst Instance=new A170958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170959
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,2L,1L,0L,1L,2L,1L,0L,1L,3L,0L,0L,2L,2L,0L,0L,3L,2L,0L,1L,3L,1L,0L,1L,3L,1L,0L,2L,3L,0L,0L,2L,2L,0L,0L,3L,1L,0L,1L,2L,1L,0L,1L,2L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L };
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
public class A170959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170959Inst : IEnumerable<long>
{
public static readonly long[] Value=A170959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170959.Bytes);
public long this[int i]=>Value[i];

public static A170959Inst Instance=new A170959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170960
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,2L,1L,0L,1L,2L,1L,0L,1L,3L,1L,0L,2L,3L,0L,0L,3L,3L,0L,1L,4L,2L,0L,1L,4L,2L,0L,2L,5L,1L,0L,3L,4L,1L,0L,4L,4L,0L,1L,4L,3L,0L,1L,5L,2L,0L,2L,4L,1L,0L,2L,4L,1L,0L,3L,3L,0L,0L,3L,2L,0L,1L,3L,1L,0L,1L,2L,1L,0L,1L,2L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L };
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
public class A170960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170960Inst : IEnumerable<long>
{
public static readonly long[] Value=A170960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170960.Bytes);
public long this[int i]=>Value[i];

public static A170960Inst Instance=new A170960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170961
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,2L,1L,0L,1L,2L,1L,0L,1L,3L,1L,0L,2L,3L,1L,0L,3L,4L,0L,1L,4L,3L,0L,1L,5L,3L,0L,2L,6L,2L,0L,3L,6L,2L,0L,5L,6L,1L,1L,5L,6L,1L,1L,7L,5L,0L,2L,7L,4L,0L,3L,8L,3L,0L,4L,7L,2L,0L,5L,7L,1L,1L,6L,5L,1L,1L,6L,5L,0L,2L,6L,3L,0L,2L,6L,2L,0L,3L,5L,1L,0L,3L,4L,1L,0L,4L,3L,0L };
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
public class A170961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170961Inst : IEnumerable<long>
{
public static readonly long[] Value=A170961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170961.Bytes);
public long this[int i]=>Value[i];

public static A170961Inst Instance=new A170961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170962
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,2L,1L,0L,1L,2L,1L,0L,1L,3L,1L,0L,2L,3L,1L,0L,3L,4L,1L,1L,4L,4L,0L,1L,5L,4L,0L,2L,7L,3L,0L,3L,7L,3L,0L,5L,8L,2L,1L,6L,8L,2L,1L,8L,8L,1L,2L,9L,7L,1L,3L,11L,7L,0L,5L,11L,5L,0L,6L,12L,4L,1L,8L,11L,3L,1L,9L,11L,2L,2L,11L,9L,1L,3L,11L,8L,1L,4L,12L,6L,0L,5L,11L,5L };
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
public class A170962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170962Inst : IEnumerable<long>
{
public static readonly long[] Value=A170962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170962.Bytes);
public long this[int i]=>Value[i];

public static A170962Inst Instance=new A170962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170963
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,2L,1L,0L,1L,2L,1L,0L,1L,3L,1L,0L,2L,3L,1L,0L,3L,4L,1L,1L,4L,4L,1L,1L,5L,5L,0L,2L,7L,4L,0L,3L,8L,4L,0L,5L,9L,3L,1L,6L,10L,3L,1L,9L,10L,2L,2L,10L,10L,2L,3L,13L,10L,1L,5L,14L,9L,1L,7L,16L,8L,1L,9L,16L,7L,1L,11L,18L,5L,2L,14L,16L,4L,3L,16L,16L,3L,5L,18L,14L };
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
public class A170963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170963Inst : IEnumerable<long>
{
public static readonly long[] Value=A170963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170963.Bytes);
public long this[int i]=>Value[i];

public static A170963Inst Instance=new A170963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170964
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,2L,1L,0L,1L,2L,1L,0L,1L,3L,1L,0L,2L,3L,1L,0L,3L,4L,1L,1L,4L,4L,1L,1L,5L,5L,1L,2L,7L,5L,0L,3L,8L,5L,0L,5L,10L,4L,1L,6L,11L,4L,1L,9L,12L,3L,2L,11L,12L,3L,3L,14L,13L,2L,5L,16L,12L,2L,7L,19L,12L,2L,10L,20L,11L,2L,12L,23L,10L,2L,16L,23L,8L,3L,19L,24L,7L,5L };
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
public class A170964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170964Inst : IEnumerable<long>
{
public static readonly long[] Value=A170964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170964.Bytes);
public long this[int i]=>Value[i];

public static A170964Inst Instance=new A170964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170965
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,2L,1L,0L,1L,2L,1L,0L,1L,3L,1L,0L,2L,3L,1L,0L,3L,4L,1L,1L,4L,4L,1L,1L,5L,5L,1L,2L,7L,5L,1L,3L,8L,6L,0L,5L,10L,5L,1L,6L,12L,5L,1L,9L,13L,4L,2L,11L,14L,4L,3L,15L,15L,3L,5L,17L,15L,3L,7L,21L,15L,3L,10L,23L,15L,3L,13L,27L,14L,3L,17L,28L,13L,4L,21L,31L,12L };
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
public class A170965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170965Inst : IEnumerable<long>
{
public static readonly long[] Value=A170965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170965.Bytes);
public long this[int i]=>Value[i];

public static A170965Inst Instance=new A170965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170966
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L };
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
public class A170966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170966Inst : IEnumerable<long>
{
public static readonly long[] Value=A170966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170966.Bytes);
public long this[int i]=>Value[i];

public static A170966Inst Instance=new A170966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170967
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,2L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L };
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
public class A170967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170967Inst : IEnumerable<long>
{
public static readonly long[] Value=A170967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170967.Bytes);
public long this[int i]=>Value[i];

public static A170967Inst Instance=new A170967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170968
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,2L,1L,0L,1L,2L,1L,0L,0L,2L,2L,0L,0L,1L,2L,1L,0L,1L,2L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L };
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
public class A170968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170968Inst : IEnumerable<long>
{
public static readonly long[] Value=A170968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170968.Bytes);
public long this[int i]=>Value[i];

public static A170968Inst Instance=new A170968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170969
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,2L,1L,0L,1L,2L,1L,0L,1L,3L,2L,0L,0L,2L,3L,1L,0L,2L,3L,1L,0L,1L,3L,2L,0L,1L,3L,2L,0L,0L,2L,3L,1L,0L,1L,2L,1L,0L,1L,2L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L };
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
public class A170969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170969Inst : IEnumerable<long>
{
public static readonly long[] Value=A170969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170969.Bytes);
public long this[int i]=>Value[i];

public static A170969Inst Instance=new A170969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170970
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,2L,1L,0L,1L,2L,1L,0L,1L,3L,2L,0L,1L,3L,3L,1L,0L,3L,4L,1L,0L,2L,4L,2L,0L,2L,5L,3L,0L,1L,4L,4L,1L,1L,4L,4L,1L,0L,3L,5L,2L,0L,2L,4L,2L,0L,1L,4L,3L,0L,1L,3L,3L,1L,0L,2L,3L,1L,0L,1L,2L,1L,0L,1L,2L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L };
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
public class A170970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170970Inst : IEnumerable<long>
{
public static readonly long[] Value=A170970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170970.Bytes);
public long this[int i]=>Value[i];

public static A170970Inst Instance=new A170970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170971
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,2L,1L,0L,1L,2L,1L,0L,1L,3L,2L,0L,1L,3L,3L,1L,1L,4L,4L,1L,0L,3L,5L,2L,0L,3L,6L,3L,0L,2L,6L,5L,1L,2L,6L,5L,1L,1L,6L,7L,2L,1L,5L,7L,3L,0L,4L,8L,4L,0L,3L,7L,5L,1L,2L,7L,6L,1L,1L,5L,6L,2L,1L,5L,6L,2L,0L,3L,6L,3L,0L,2L,5L,3L,0L,1L,4L,4L,1L,1L,3L,3L,1L,0L,2L,3L,1L,0L,1L,2L,1L,0L };
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
public class A170971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170971Inst : IEnumerable<long>
{
public static readonly long[] Value=A170971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170971.Bytes);
public long this[int i]=>Value[i];

public static A170971Inst Instance=new A170971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170972
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,2L,1L,0L,1L,2L,1L,0L,1L,3L,2L,0L,1L,3L,3L,1L,1L,4L,4L,1L,1L,4L,5L,2L,0L,4L,7L,3L,0L,3L,7L,5L,1L,3L,8L,6L,1L,2L,8L,8L,2L,2L,8L,9L,3L,1L,7L,11L,5L,1L,7L,11L,6L,1L,5L,12L,8L,1L,4L,11L,9L,2L,3L,11L,11L,3L,2L,9L,11L,4L,1L,8L,12L,5L,1L,6L,11L,7L,1L,5L,11L,7L,1L,3L,9L,8L,2L,2L };
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
public class A170972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170972Inst : IEnumerable<long>
{
public static readonly long[] Value=A170972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170972.Bytes);
public long this[int i]=>Value[i];

public static A170972Inst Instance=new A170972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170973
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,2L,1L,0L,1L,2L,1L,0L,1L,3L,2L,0L,1L,3L,3L,1L,1L,4L,4L,1L,1L,4L,5L,2L,1L,5L,7L,3L,0L,4L,8L,5L,1L,4L,9L,6L,1L,3L,10L,9L,2L,3L,10L,10L,3L,2L,10L,13L,5L,2L,10L,14L,7L,2L,9L,16L,9L,2L,8L,16L,11L,2L,7L,18L,14L,3L,5L,16L,16L,5L,4L,16L,18L,6L,3L,14L,19L,9L,3L,13L,20L,10L };
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
public class A170973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170973Inst : IEnumerable<long>
{
public static readonly long[] Value=A170973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170973.Bytes);
public long this[int i]=>Value[i];

public static A170973Inst Instance=new A170973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170974
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,2L,1L,0L,1L,2L,1L,0L,1L,3L,2L,0L,1L,3L,3L,1L,1L,4L,4L,1L,1L,4L,5L,2L,1L,5L,7L,3L,1L,5L,8L,5L,1L,5L,10L,6L,1L,4L,11L,9L,2L,4L,12L,11L,3L,3L,12L,14L,5L,3L,13L,16L,7L,3L,12L,19L,10L,3L,12L,20L,12L,3L,11L,23L,16L,4L,10L,23L,19L,5L,8L,24L,23L,7L,7L,23L,25L,10L,6L,23L };
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
public class A170974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170974Inst : IEnumerable<long>
{
public static readonly long[] Value=A170974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170974.Bytes);
public long this[int i]=>Value[i];

public static A170974Inst Instance=new A170974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170975
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,2L,1L,0L,1L,2L,1L,0L,1L,3L,2L,0L,1L,3L,3L,1L,1L,4L,4L,1L,1L,4L,5L,2L,1L,5L,7L,3L,1L,5L,8L,5L,2L,6L,10L,6L,1L,5L,12L,9L,2L,5L,13L,11L,3L,4L,14L,15L,5L,4L,15L,17L,7L,4L,15L,21L,10L,4L,15L,23L,13L,4L,15L,27L,17L,5L,14L,28L,21L,6L,13L,31L,26L,8L,12L,31L,30L,11L,11L };
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
public class A170975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170975Inst : IEnumerable<long>
{
public static readonly long[] Value=A170975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170975.Bytes);
public long this[int i]=>Value[i];

public static A170975Inst Instance=new A170975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170976
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,0L,2L,0L,0L,2L,1L,0L,0L,2L,0L,0L,1L,2L,0L,0L,2L,0L,0L,0L,1L,0L,0L,1L };
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
public class A170976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170976Inst : IEnumerable<long>
{
public static readonly long[] Value=A170976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170976.Bytes);
public long this[int i]=>Value[i];

public static A170976Inst Instance=new A170976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170977
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L };
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
public class A170977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170977Inst : IEnumerable<long>
{
public static readonly long[] Value=A170977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170977.Bytes);
public long this[int i]=>Value[i];

public static A170977Inst Instance=new A170977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170978
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,2L,0L,0L,2L,1L,0L,0L,3L,1L,0L,2L,3L,0L,0L,2L,3L,0L,0L,4L,2L,0L,1L,4L,1L,0L,2L,4L,0L,0L,3L,2L,0L,0L,3L,2L,0L,1L,3L,0L,0L,1L,2L,0L,0L,2L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L };
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
public class A170978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170978Inst : IEnumerable<long>
{
public static readonly long[] Value=A170978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170978.Bytes);
public long this[int i]=>Value[i];

public static A170978Inst Instance=new A170978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170979
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,0L,2L,1L,1L,1L,2L,2L,1L,1L,3L,1L,1L,2L,2L,2L,1L,3L,3L,2L,2L,3L,2L,3L,1L,3L,3L,2L,2L,3L,3L,2L,2L,3L,3L,1L,3L,2L,3L,2L,2L,3L,3L,1L,2L,2L,2L,1L,1L,3L,1L,1L,2L,2L,1L,1L,1L,2L,0L,1L,1L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L };
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
public class A170979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170979Inst : IEnumerable<long>
{
public static readonly long[] Value=A170979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170979.Bytes);
public long this[int i]=>Value[i];

public static A170979Inst Instance=new A170979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170980
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,2L,0L,0L,3L,1L,0L,1L,3L,1L,0L,2L,4L,1L,0L,3L,4L,0L,0L,5L,4L,0L,2L,6L,3L,0L,2L,7L,3L,0L,4L,8L,1L,0L,6L,7L,1L,1L,8L,6L,0L,2L,8L,5L,0L,3L,10L,3L,0L,5L,8L,2L,0L,6L,8L,1L,1L,7L,6L,0L,1L,8L,4L,0L,3L,7L,2L,0L,3L,6L,2L,0L,4L,5L,0L,0L,4L,3L,0L,1L,4L,2L,0L,1L,3L,1L,0L,1L,3L,0L,0L };
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
public class A170980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170980Inst : IEnumerable<long>
{
public static readonly long[] Value=A170980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170980.Bytes);
public long this[int i]=>Value[i];

public static A170980Inst Instance=new A170980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170981
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,2L,1L,1L,1L,2L,1L,1L,1L,3L,2L,1L,2L,3L,2L,1L,3L,4L,2L,2L,4L,4L,2L,2L,5L,4L,3L,3L,6L,4L,3L,4L,6L,5L,4L,5L,7L,5L,4L,5L,7L,6L,4L,7L,7L,6L,4L,7L,7L,6L,5L,8L,8L,6L,5L,8L,7L,6L,6L,8L,8L,6L,6L,7L,8L,5L,6L,8L,8L,5L,6L,7L,7L,4L,6L,7L,7L,4L,6L,7L,5L,4L,5L,7L,5L,4L,5L,6L };
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
public class A170981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170981Inst : IEnumerable<long>
{
public static readonly long[] Value=A170981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170981.Bytes);
public long this[int i]=>Value[i];

public static A170981Inst Instance=new A170981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170982
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,2L,2L,0L,1L,3L,1L,0L,1L,4L,1L,0L,3L,4L,1L,0L,4L,5L,1L,1L,6L,5L,0L,2L,7L,5L,0L,3L,10L,4L,0L,5L,10L,4L,0L,8L,12L,3L,2L,10L,12L,2L,2L,13L,12L,1L,4L,16L,10L,1L,6L,18L,10L,0L,10L,19L,7L,1L,12L,20L,6L,2L,16L,19L,4L,3L,18L,18L,3L,5L,22L,16L,1L,8L,22L,13L,1L };
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
public class A170982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170982Inst : IEnumerable<long>
{
public static readonly long[] Value=A170982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170982.Bytes);
public long this[int i]=>Value[i];

public static A170982Inst Instance=new A170982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170983
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,2L,1L,0L,2L,2L,1L,1L,1L,3L,1L,1L,2L,3L,2L,1L,3L,4L,2L,2L,4L,4L,3L,2L,5L,6L,2L,3L,7L,5L,3L,4L,8L,6L,3L,6L,9L,6L,5L,7L,11L,7L,5L,10L,11L,7L,7L,10L,12L,9L,7L,13L,13L,9L,9L,14L,14L,10L,10L,17L,14L,11L,12L,17L,16L,11L,13L,20L,15L,12L,16L,19L,17L,13L,17L };
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
public class A170983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170983Inst : IEnumerable<long>
{
public static readonly long[] Value=A170983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170983.Bytes);
public long this[int i]=>Value[i];

public static A170983Inst Instance=new A170983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170984
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,2L,1L,0L,1L,2L,2L,0L,1L,4L,1L,0L,2L,4L,1L,0L,4L,5L,1L,1L,5L,5L,1L,1L,7L,6L,1L,3L,9L,6L,0L,4L,11L,6L,0L,7L,13L,5L,1L,9L,15L,5L,2L,13L,16L,4L,3L,16L,17L,4L,5L,21L,18L,2L,8L,24L,17L,2L,12L,29L,16L,3L,16L,31L,15L,3L,21L,35L,13L,4L,27L,35L,11L,6L,33L,37L };
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
public class A170984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170984Inst : IEnumerable<long>
{
public static readonly long[] Value=A170984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170984.Bytes);
public long this[int i]=>Value[i];

public static A170984Inst Instance=new A170984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170985
{
public static readonly long[] Value={ 0L,1L,0L,1L,16L,25L,16L,25L,0L,1L,0L,1L,16L,25L,16L,25L,256L,289L,256L,289L,400L,441L,400L,441L,256L,289L,256L,289L,400L,441L,400L,441L,0L,1L,0L,1L,16L,25L,16L,25L,0L,1L,0L,1L,16L,25L,16L,25L,256L,289L,256L,289L,400L,441L,400L,441L,256L,289L,256L,289L,400L,441L,400L,441L,4096L,4225L };
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
public class A170985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170985Inst : IEnumerable<long>
{
public static readonly long[] Value=A170985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170985.Bytes);
public long this[int i]=>Value[i];

public static A170985Inst Instance=new A170985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170986
{
public static readonly long[] Value={ 0L,1L,4L,4L,1L,25L,36L,49L,34L,41L,100L,121L,119L,114L,106L,100L,106L,114L,119L,121L,25L,41L,34L,49L,36L,625L,676L,729L,654L,701L,900L,961L,899L,934L,991L,1225L,1171L,1219L,1139L,1181L,850L,781L,839L,769L,821L,1025L,1091L,1009L,1074L,1111L,2500L,2601L,2579L,2554L,2526L };
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
public class A170986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170986Inst : IEnumerable<long>
{
public static readonly long[] Value=A170986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170986.Bytes);
public long this[int i]=>Value[i];

public static A170986Inst Instance=new A170986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170987
{
public static readonly long[] Value={ 0L,1L,4L,3L,4L,1L,36L,49L,64L,39L,52L,61L,144L,169L,160L,147L,172L,157L,108L,109L,112L,111L,112L,109L,144L,157L,172L,147L,160L,169L,36L,61L,52L,39L,64L,49L,1296L,1369L,1444L,1299L,1372L,1441L,1764L,1849L,1936L,1767L,1852L,1933L,2304L,2185L,2248L,2307L,2188L,2245L };
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
public class A170987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170987Inst : IEnumerable<long>
{
public static readonly long[] Value=A170987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170987.Bytes);
public long this[int i]=>Value[i];

public static A170987Inst Instance=new A170987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170988
{
public static readonly long[] Value={ 0L,1L,4L,2L,2L,4L,1L,49L,64L,81L,93L,58L,74L,85L,196L,225L,207L,233L,212L,242L,218L,98L,141L,137L,128L,121L,116L,106L,98L,106L,116L,121L,128L,137L,141L,196L,218L,242L,212L,233L,207L,225L,49L,85L,74L,58L,93L,81L,64L,2401L,2500L,2601L,2697L,2452L,2552L,2647L,3136L,3249L };
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
public class A170988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170988Inst : IEnumerable<long>
{
public static readonly long[] Value=A170988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170988.Bytes);
public long this[int i]=>Value[i];

public static A170988Inst Instance=new A170988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170989
{
public static readonly long[] Value={ 0L,1L,4L,1L,0L,1L,4L,1L,64L,81L,100L,113L,64L,81L,100L,113L,256L,289L,260L,289L,256L,289L,260L,289L,64L,113L,100L,81L,64L,113L,100L,81L,0L,1L,4L,1L,0L,1L,4L,1L,64L,81L,100L,113L,64L,81L,100L,113L,256L,289L,260L,289L,256L,289L,260L,289L,64L,113L,100L,81L,64L,113L,100L,81L,4096L,4225L };
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
public class A170989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170989Inst : IEnumerable<long>
{
public static readonly long[] Value=A170989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170989.Bytes);
public long this[int i]=>Value[i];

public static A170989Inst Instance=new A170989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170990
{
public static readonly long[] Value={ 0L,1L,4L,0L,7L,7L,0L,4L,1L,81L,100L,121L,135L,160L,97L,108L,130L,145L,324L,361L,400L,351L,394L,349L,378L,337L,370L,0L,55L,31L,0L,61L,34L,0L,58L,28L,567L,640L,634L,621L,619L,610L,594L,589L,577L,567L,577L,589L,594L,610L,619L,621L,634L,640L,0L,28L,58L,0L,34L,61L,0L,31L,55L,324L,370L };
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
public class A170990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170990Inst : IEnumerable<long>
{
public static readonly long[] Value=A170990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170990.Bytes);
public long this[int i]=>Value[i];

public static A170990Inst Instance=new A170990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170991
{
public static readonly long[] Value={ 2L,16L,60L,160L,360L,672L,1240L,1920L,3180L,4400L,6832L,8736L,12880L,15840L,22320L,26112L,36666L };
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
public class A170991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170991Inst : IEnumerable<long>
{
public static readonly long[] Value=A170991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170991.Bytes);
public long this[int i]=>Value[i];

public static A170991Inst Instance=new A170991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170992
{
public static readonly long[] Value={ 2L,160L,2448L,18304L,90552L,341568L,1068928L,2877696L,7014204L,15423200L,32107456L,61663104L,115156144L,200764608L,346235904L,561158400L,911313450L };
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
public class A170992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170992Inst : IEnumerable<long>
{
public static readonly long[] Value=A170992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170992.Bytes);
public long this[int i]=>Value[i];

public static A170992Inst Instance=new A170992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170993
{
public static readonly long[] Value={ 2L,1456L,91920L,1931200L,21639720L,160786272L,893985280L,4001984640L,15166797900L,50211875600L,149342289472L,404551482816L,1017967450960L,2389725895200L,5320611901440L,11218821981312L,22749778149786L };
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
public class A170993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170993Inst : IEnumerable<long>
{
public static readonly long[] Value=A170993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170993.Bytes);
public long this[int i]=>Value[i];

public static A170993Inst Instance=new A170993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170994
{
public static readonly long[] Value={ 2L,13120L,3346368L,197304064L,5001497112L,73102904448L,724280109568L,5371101006336L,31830391591644L,157705369657280L,675306861112576L,2559854615265024L,8759525149882864L,27434575456211328L };
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
public class A170994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170994Inst : IEnumerable<long>
{
public static readonly long[] Value=A170994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170994.Bytes);
public long this[int i]=>Value[i];

public static A170994Inst Instance=new A170994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170995
{
public static readonly ulong[] Value={ 2L,118096L,120815280L,19896619840L,1139754451080L,32740753325472L,577763760958720L,7092667383039360L,65742150901548780L,487018342594703600L,3004685799388645312L,15919220244209484096UL };
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
public class A170995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170995Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A170995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170995.Bytes);
public ulong this[int i]=>Value[i];

public static A170995Inst Instance=new A170995Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170996
{
public static readonly BigInteger[] Value={ 2L,1062880L,4352505888L,1996102225024L,258031607185272L,14560223135464128L,457472951327051008L,9293626316677061376UL,BigInteger.Parse("134707212077147740284"),BigInteger.Parse("1491667016717716134560") };
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
public class A170996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170996Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170996.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A170996.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170996Inst Instance=new A170996Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170997
{
public static readonly BigInteger[] Value={ 2L,9565936L,156718778640L,199854951398080L,58230316414059240L,6451030954702152672L,BigInteger.Parse("360793945093731688960"),BigInteger.Parse("12127449147074861834880"),BigInteger.Parse("274847057797905019237260"),BigInteger.Parse("4548825193274613857646800") };
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
public class A170997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170997Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170997.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A170997.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170997Inst Instance=new A170997Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170998
{
public static readonly BigInteger[] Value={ 2L,86093440L,5642133787008L,19994654452125184L,13120458818999011032UL,BigInteger.Parse("2852277353239208548608"),BigInteger.Parse("283889181859169785013248"),BigInteger.Parse("15786934495235533394850816"),BigInteger.Parse("559374323532926110389380124") };
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
public class A170998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170998Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170998.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A170998.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170998Inst Instance=new A170998Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170999
{
public static readonly BigInteger[] Value={ 2L,774840976L,203119138758000L,1999804372817081920L,BigInteger.Parse("2954080786719122704200"),BigInteger.Parse("1259649848110685616355872"),BigInteger.Parse("223062465532295875789024000"),BigInteger.Parse("20519169517386068841434851200") };
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
public class A170999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170999Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170999.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A170999.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170999Inst Instance=new A170999Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A171000
{
public static readonly long[] Value={ 1L,10L,11L,101L,1001L,1011L,1101L,10001L,10011L,10111L,11001L,11101L,100001L,100011L,100101L,100111L,101001L,101011L,110001L,110101L,111001L,1000001L,1000011L,1000101L,1000111L,1001011L,1001101L,1001111L,1010001L,1010011L,1010111L,1011001L,1011101L };
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
public class A171000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A171000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A171000Inst : IEnumerable<long>
{
public static readonly long[] Value=A171000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A171000.Bytes);
public long this[int i]=>Value[i];

public static A171000Inst Instance=new A171000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A171001
{
public static readonly long[] Value={ 1L,0L,1L,4L,9L,9L,36L,100L,225L,400L,1225L,3136L,7056L,15876L,44100L,108900L,245025L,627264L,1656369L,4008004L,9018009L,25050025L,64128064L,153165376L,344622096L,1012766976L,2538950544L,6009350400L,13521038400L,41408180100L,102252852900L,240407818596L };
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
public class A171001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A171001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A171001Inst : IEnumerable<long>
{
public static readonly long[] Value=A171001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A171001.Bytes);
public long this[int i]=>Value[i];

public static A171001Inst Instance=new A171001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A171002
{
public static readonly long[] Value={ 0L,0L,0L,3L,0L,6L,40L,150L,100L,525L,1960L,5880L,7056L,26460L,83160L,228690L,365904L,1189188L,3435432L,9018009L,17177160L,51531480L,141581440L,361032672L,773641440L,2204878104L,5859116640L,14647791600L,34178180400L,93989996100L,243891989880L,601019546490L };
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
public class A171002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A171002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A171002Inst : IEnumerable<long>
{
public static readonly long[] Value=A171002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A171002.Bytes);
public long this[int i]=>Value[i];

public static A171002Inst Instance=new A171002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A171003
{
public static readonly long[] Value={ 1L,2L,4L,9L,18L,40L,100L,225L,525L,1225L,3136L,7056L,17640L,44100L,108900L,261360L,637065L,1656369L,4008004L,10020010L,25050025L,64128064L,155739584L,393853824L,1012766976L,2538950544L,6347376360L,15774544800L,41408180100L };
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
public class A171003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A171003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A171003Inst : IEnumerable<long>
{
public static readonly long[] Value=A171003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A171003.Bytes);
public long this[int i]=>Value[i];

public static A171003Inst Instance=new A171003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A171004
{
public static readonly long[] Value={ 1119L,1129L,1139L,1149L,1159L,1169L,1179L,1189L,1191L,1192L,1193L,1194L,1195L,1196L,1197L,1198L,1199L,1219L,1319L,1419L,1519L,1619L,1719L,1819L,1911L,1912L,1913L,1914L,1915L,1916L,1917L,1918L,1919L,2191L,2229L,2239L,2249L,2259L,2269L,2279L,2289L,2292L,2293L,2294L,2295L,2296L,2297L,2298L,2299L,2329L,2429L,2529L,2629L,2729L,2829L,2911L,2922L,2923L,2924L,2925L,2926L,2927L,2928L };
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
public class A171004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A171004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A171004Inst : IEnumerable<long>
{
public static readonly long[] Value=A171004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A171004.Bytes);
public long this[int i]=>Value[i];

public static A171004Inst Instance=new A171004Inst();

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