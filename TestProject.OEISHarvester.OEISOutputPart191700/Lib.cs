using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A222157
{
public static readonly long[] Value={ 120L,6322L,207262L,4907711L,91075868L,1393742886L,18203084280L,207961261268L,2116883443548L,19475385665260L,163788555854232L,1270883781907016L,9168186853827174L,61890082396969113L,393107547309424404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222157Inst : IEnumerable<long>
{
public static readonly long[] Value=A222157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222157.Bytes);
public long this[int i]=>Value[i];

public static A222157Inst Instance=new A222157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222158
{
public static readonly BigInteger[] Value={ 720L,215659L,38778082L,4900249687L,474541614240L,37174156067106L,2443652727700740L,138390122328018723L,6886742682955869488L,BigInteger.Parse("305784165735033471729"),BigInteger.Parse("12263159054342175847892"),BigInteger.Parse("448624205061282686849788") };
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
public class A222158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222158Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222158.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222158.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222158Inst Instance=new A222158Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222159
{
public static readonly long[] Value={ 1L,2L,1L,6L,3L,1L,24L,21L,4L,1L,120L,277L,56L,5L,1L,720L,6322L,2132L,126L,6L,1L,5040L,215659L,207262L,12521L,252L,7L,1L,40320L,10218797L,38778082L,4907711L,60344L,462L,8L,1L,362880L,636984802L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222159Inst : IEnumerable<long>
{
public static readonly long[] Value=A222159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222159.Bytes);
public long this[int i]=>Value[i];

public static A222159Inst Instance=new A222159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222160
{
public static readonly long[] Value={ 1L,5L,17L,53L,159L,467L,1356L,3913L,11253L,32299L,92606L,265353L,760080L,2176758L,6233232L,17847997L,51103477L,146319703L,418938535L,1199485661L,3434300229L,9832876386L,28152852451L,80605364957L,230783807849L,660764392260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222160Inst : IEnumerable<long>
{
public static readonly long[] Value=A222160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222160.Bytes);
public long this[int i]=>Value[i];

public static A222160Inst Instance=new A222160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222161
{
public static readonly long[] Value={ 13L,57L,205L,733L,2627L,9305L,32576L,113448L,394406L,1369551L,4750768L,16468347L,57064823L,197691644L,684764755L,2371639753L,8213463074L,28443621204L,98498816070L,341089856906L,1181139073972L,4090059069992L,14163013655470L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222161Inst : IEnumerable<long>
{
public static readonly long[] Value=A222161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222161.Bytes);
public long this[int i]=>Value[i];

public static A222161Inst Instance=new A222161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222162
{
public static readonly long[] Value={ 81L,329L,1216L,4499L,16750L,62531L,231973L,855590L,3147832L,11573804L,42548081L,156375085L,574525894L,2110266004L,7749866077L,28458386767L,104495519709L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222162Inst : IEnumerable<long>
{
public static readonly long[] Value=A222162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222162.Bytes);
public long this[int i]=>Value[i];

public static A222162Inst Instance=new A222162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222163
{
public static readonly long[] Value={ 381L,1488L,5576L,20946L,79109L,299690L,1135379L,4291104L,16190182L,61049080L,230189508L,868002078L,3273177822L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222163Inst : IEnumerable<long>
{
public static readonly long[] Value=A222163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222163.Bytes);
public long this[int i]=>Value[i];

public static A222163Inst Instance=new A222163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222164
{
public static readonly long[] Value={ 1583L,6075L,22955L,87009L,331273L,1265044L,4836758L,18497653L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222164Inst : IEnumerable<long>
{
public static readonly long[] Value=A222164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222164.Bytes);
public long this[int i]=>Value[i];

public static A222164Inst Instance=new A222164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222165
{
public static readonly long[] Value={ 0L,1L,0L,13L,5L,0L,81L,57L,17L,0L,381L,329L,205L,53L,0L,1583L,1488L,1216L,733L,159L,0L,6231L,6075L,5576L,4499L,2627L,467L,0L,24013L,23775L,22955L,20946L,16750L,9305L,1356L,0L,91963L,91619L,90369L,87009L,79109L,62531L,32576L,3913L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222165Inst : IEnumerable<long>
{
public static readonly long[] Value=A222165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222165.Bytes);
public long this[int i]=>Value[i];

public static A222165Inst Instance=new A222165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222166
{
public static readonly BigInteger[] Value={ 81L,4913L,317259L,20780181L,1366395515L,89948464453L,5923189816253L,390086038882651L,25690815631493191L,1691995329032459285L,BigInteger.Parse("111434983000652039093"),BigInteger.Parse("7339124863989795685471"),BigInteger.Parse("483355986017042494039859") };
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
public class A222166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222166Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222166.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222166.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222166Inst Instance=new A222166Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222167
{
public static readonly BigInteger[] Value={ 243L,31307L,4380445L,625649047L,89948464453L,12961320464027L,1869223526083263L,269651329420019349L,BigInteger.Parse("38903706021233668197"),BigInteger.Parse("5613019387964005463679"),BigInteger.Parse("809857047207692689731131"),BigInteger.Parse("116848319343974137914103093") };
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
public class A222167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222167Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222167.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222167.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222167Inst Instance=new A222167Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222168
{
public static readonly BigInteger[] Value={ 729L,199497L,60481881L,18838482047L,5923189816253L,1869223526083263L,590771311004409091L,BigInteger.Parse("186831129401198761761"),BigInteger.Parse("59100748356892786911715"),BigInteger.Parse("18697545591371281608525201"),BigInteger.Parse("5915566903646796343481287921") };
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
public class A222168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222168Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222168.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222168.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222168Inst Instance=new A222168Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222169
{
public static readonly long[] Value={ 1L,3L,3L,9L,19L,9L,27L,121L,121L,27L,81L,771L,1665L,771L,81L,243L,4913L,22979L,22979L,4913L,243L,729L,31307L,317259L,690437L,317259L,31307L,729L,2187L,199497L,4380445L,20780181L,20780181L,4380445L,199497L,2187L,6561L,1271251L,60481881L,625649047L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222169Inst : IEnumerable<long>
{
public static readonly long[] Value=A222169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222169.Bytes);
public long this[int i]=>Value[i];

public static A222169Inst Instance=new A222169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222170
{
public static readonly long[] Value={ 0L,1L,6L,15L,26L,41L,60L,81L,106L,135L,166L,201L,240L,281L,326L,375L,426L,481L,540L,601L,666L,735L,806L,881L,960L,1041L,1126L,1215L,1306L,1401L,1500L,1601L,1706L,1815L,1926L,2041L,2160L,2281L,2406L,2535L,2666L,2801L,2940L,3081L,3226L,3375L,3526L,3681L,3840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222170Inst : IEnumerable<long>
{
public static readonly long[] Value=A222170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222170.Bytes);
public long this[int i]=>Value[i];

public static A222170Inst Instance=new A222170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222171
{
public static readonly long[] Value={ 4L,1L,1L,2L,3L,3L,5L,1L,6L,7L,1L,2L,0L,5L,6L,6L,0L,9L,1L,1L,8L,1L,0L,3L,7L,9L,1L,6L,6L,1L,5L,0L,6L,2L,9L,7L,3L,0L,4L,7L,3L,7L,4L,7L,5L,3L,0L,1L,6L,9L,9L,6L,0L,9L,4L,3L,3L,8L,8L,9L,5L,5L,7L,3L,4L,2L,5L,0L,1L,8L,6L,7L,6L,0L,0L,8L,0L,0L,2L,1L,8L,4L,5L,8L,4L,0L,7L,2L,2L,5L,1L,5L,4L,9L,3L,9L,6L,7L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222171Inst : IEnumerable<long>
{
public static readonly long[] Value=A222171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222171.Bytes);
public long this[int i]=>Value[i];

public static A222171Inst Instance=new A222171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222172
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,8L,10L,11L,13L,17L,21L,24L,29L,36L,40L,41L,43L,47L,53L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222172Inst : IEnumerable<long>
{
public static readonly long[] Value=A222172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222172.Bytes);
public long this[int i]=>Value[i];

public static A222172Inst Instance=new A222172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222173
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,3L,2L,1L,2L,4L,4L,3L,5L,7L,4L,1L,2L,4L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222173Inst : IEnumerable<long>
{
public static readonly long[] Value=A222173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222173.Bytes);
public long this[int i]=>Value[i];

public static A222173Inst Instance=new A222173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222174
{
public static readonly long[] Value={ 6L,34L,50L,236L,262L,386L,898L,8362L,26938L,46594L,80876L,5244548L,5462384L,17062316L,323987588L,1162300834L,1381439876L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222174Inst : IEnumerable<long>
{
public static readonly long[] Value=A222174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222174.Bytes);
public long this[int i]=>Value[i];

public static A222174Inst Instance=new A222174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222175
{
public static readonly long[] Value={ 1L,6L,8L,11L,33L,55L,70L,225L,348L,430L,1449L,3091L,4455L,5334L,6369L,17822L,21039L,40227L,47133L,55165L,64468L,160215L,441105L,1159752L,1327013L,2929465L,3334067L,7142275L,16873472L,19032990L,38749850L,86737678L,97129029L,189672868L,405991500L,451875336L,852077072L,1756048833L,2152268305L,3558408287L,4341238854L,7098041203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222175Inst : IEnumerable<long>
{
public static readonly long[] Value=A222175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222175.Bytes);
public long this[int i]=>Value[i];

public static A222175Inst Instance=new A222175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222176
{
public static readonly long[] Value={ 0L,1L,3L,5L,7L,11L,17L,21L,23L,27L,35L,43L,49L,59L,73L,81L,83L,87L,95L,107L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222176Inst : IEnumerable<long>
{
public static readonly long[] Value=A222176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222176.Bytes);
public long this[int i]=>Value[i];

public static A222176Inst Instance=new A222176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222177
{
public static readonly long[] Value={ 0L,1L,2L,2L,2L,4L,6L,4L,2L,4L,8L,8L,6L,10L,14L,8L,2L,4L,8L,12L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222177Inst : IEnumerable<long>
{
public static readonly long[] Value=A222177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222177.Bytes);
public long this[int i]=>Value[i];

public static A222177Inst Instance=new A222177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222178
{
public static readonly long[] Value={ 7L,22L,99L,290440L,510996L,1014783L,11583715L,14764288L,18774767L,48034542L,67743280L,148613531L,230543695L,286415114L,395390919L,543884825L,671414425L,745567438L,918328689L,1251947710L,1387205627L,2083836151L,2305036665L,4628419400L,7544584160L,37673100256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222178Inst : IEnumerable<long>
{
public static readonly long[] Value=A222178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222178.Bytes);
public long this[int i]=>Value[i];

public static A222178Inst Instance=new A222178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222179
{
public static readonly long[] Value={ 15L,33L,88L,175L,1127L,3465L,7029L,36659L,1755164L,4900901L,537252430L,816292168L,1365815759L,2048921480L,11937573274L,14434878293L,17435497255L,27826547235L,169697066625L,371707331522L,405119159125L,800760189610L,23737435535625L,86561181062463L,100528900924040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222179Inst : IEnumerable<long>
{
public static readonly long[] Value=A222179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222179.Bytes);
public long this[int i]=>Value[i];

public static A222179Inst Instance=new A222179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222180
{
public static readonly long[] Value={ 0L,1L,6L,16L,26L,36L,56L,86L,106L,116L,136L,176L,216L,246L,296L,366L,406L,416L,436L,476L,536L,616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222180Inst : IEnumerable<long>
{
public static readonly long[] Value=A222180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222180.Bytes);
public long this[int i]=>Value[i];

public static A222180Inst Instance=new A222180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222181
{
public static readonly long[] Value={ 0L,1L,5L,10L,10L,10L,20L,30L,20L,10L,20L,40L,40L,30L,50L,70L,40L,10L,20L,40L,60L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222181Inst : IEnumerable<long>
{
public static readonly long[] Value=A222181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222181.Bytes);
public long this[int i]=>Value[i];

public static A222181Inst Instance=new A222181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222182
{
public static readonly long[] Value={ -5L,-1L,7L,19L,35L,55L,79L,107L,139L,175L,215L,259L,307L,359L,415L,475L,539L,607L,679L,755L,835L,919L,1007L,1099L,1195L,1295L,1399L,1507L,1619L,1735L,1855L,1979L,2107L,2239L,2375L,2515L,2659L,2807L,2959L,3115L,3275L,3439L,3607L,3779L,3955L,4135L,4319L,4507L,4699L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222182Inst : IEnumerable<long>
{
public static readonly long[] Value=A222182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222182.Bytes);
public long this[int i]=>Value[i];

public static A222182Inst Instance=new A222182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222183
{
public static readonly long[] Value={ 1L,0L,7L,4L,8L,3L,3L,0L,7L,2L,1L,5L,6L,6L,9L,4L,4L,2L,1L,2L,0L,4L,4L,5L,7L,4L,4L,4L,9L,5L,8L,4L,5L,1L,5L,0L,1L,3L,4L,4L,1L,8L,0L,9L,0L,0L,0L,9L,3L,3L,8L,5L,4L,8L,1L,2L,8L,4L,0L,8L,3L,3L,9L,5L,8L,2L,4L,6L,3L,4L,3L,1L,1L,2L,8L,9L,3L,2L,7L,7L,1L,2L,4L,2L,7L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222183Inst : IEnumerable<long>
{
public static readonly long[] Value=A222183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222183.Bytes);
public long this[int i]=>Value[i];

public static A222183Inst Instance=new A222183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222184
{
public static readonly long[] Value={ 11L,43L,59L,71L,79L,97L,103L,137L,263L,331L,349L,359L,421L,433L,487L,523L,653L,659L,743L,859L,863L,907L,919L,983L,1069L,1087L,1091L,1093L,1163L,1223L,1229L,1279L,1381L,1483L,1499L,1549L,1657L,1663L,1667L,1697L,1747L,1777L,1787L,1789L,1877L,1993L,2011L,2213L,2221L,2251L,2281L,2309L,2371L,2393L,2473L,2671L,2719L,2777L,2791L,2803L,2833L,2861L,3037L,3079L,3163L,3251L,3257L,3463L,3511L,3557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222184Inst : IEnumerable<long>
{
public static readonly long[] Value=A222184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222184.Bytes);
public long this[int i]=>Value[i];

public static A222184Inst Instance=new A222184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222185
{
public static readonly long[] Value={ 3L,19L,53L,11L,31L,53L,43L,19L,79L,71L,223L,257L,251L,349L,307L,241L,197L,503L,467L,643L,13L,127L,457L,419L,487L,617L,691L,2L,241L,997L,821L,683L,653L,421L,941L,1069L,1481L,709L,463L,461L,1153L,1381L,631L,449L,1091L,277L,1993L,367L,659L,151L,1657L,823L,1493L,431L,1787L,2063L,1487L,59L,2389L,2131L,479L,1907L,79L,173L,1151L,1831L,419L,1193L,2L,3319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222185Inst : IEnumerable<long>
{
public static readonly long[] Value=A222185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222185.Bytes);
public long this[int i]=>Value[i];

public static A222185Inst Instance=new A222185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222186
{
public static readonly long[] Value={ 1L,3L,123L,14632581L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222186Inst : IEnumerable<long>
{
public static readonly long[] Value=A222186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222186.Bytes);
public long this[int i]=>Value[i];

public static A222186Inst Instance=new A222186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222187
{
public static readonly long[] Value={ 3L,7L,13L,34L,78L,237L,687L,2299L,7685L,27190L,96909L,353384L,1296858L,4808707L,17920860L,67169299L,252745368L,954677597L,3617214681L,13744852240L,52359294790L,199915018057L,764884036743L,2932046213314L,11259024569838L,43303903226962L,166800088109829L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222187Inst : IEnumerable<long>
{
public static readonly long[] Value=A222187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222187.Bytes);
public long this[int i]=>Value[i];

public static A222187Inst Instance=new A222187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222188
{
public static readonly long[] Value={ 2L,3L,3L,4L,7L,4L,6L,13L,13L,6L,8L,34L,36L,34L,8L,13L,78L,158L,158L,78L,13L,18L,237L,708L,1459L,708L,237L,18L,30L,687L,4236L,14676L,14676L,4236L,687L,30L,46L,2299L,26412L,184854L,340880L,184854L,26412L,2299L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222188Inst : IEnumerable<long>
{
public static readonly long[] Value=A222188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222188.Bytes);
public long this[int i]=>Value[i];

public static A222188Inst Instance=new A222188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222189
{
public static readonly long[] Value={ 4L,13L,36L,158L,708L,4236L,26412L,180070L,1256914L,8999762L,65225244L,477772294L,3525803320L,26185264801L,195490126328L,1466095545930L,11038514989344L,83401050695432L,632087998742988L,4803854169636124L,36600736833265244L,279496328812771427L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222189Inst : IEnumerable<long>
{
public static readonly long[] Value=A222189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222189.Bytes);
public long this[int i]=>Value[i];

public static A222189Inst Instance=new A222189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222190
{
public static readonly BigInteger[] Value={ 6L,34L,158L,1459L,14676L,184854L,2445918L,33888844L,479268556L,6886509940L,100056170778L,1466749421254L,21657254505396L,321725243553514L,4804133557262316L,72059797641376804L,1085119161923382576L,16397231016301629254UL,BigInteger.Parse("248546552679488856498") };
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
public class A222190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222190Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222190.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222190.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222190Inst Instance=new A222190Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222191
{
public static readonly BigInteger[] Value={ 8L,78L,708L,14676L,340880L,8999762L,245619576L,6873769668L,195476237384L,5629567649856L,163767575198904L,4803842349528720L,141898045773925232L,4216398765923837382L,BigInteger.Parse("125929773586625359472"),BigInteger.Parse("3777893192033792518716"),BigInteger.Parse("113781253647861573211712") };
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
public class A222191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222191Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222191.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222191.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222191Inst Instance=new A222191Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222192
{
public static readonly long[] Value={ 1L,3L,78L,7338218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222192Inst : IEnumerable<long>
{
public static readonly long[] Value=A222192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222192.Bytes);
public long this[int i]=>Value[i];

public static A222192Inst Instance=new A222192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222193
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,32L,48L,96L,144L,288L,576L,1152L,1216L,2432L,4736L,9472L,18688L,37376L,54272L,108544L,115712L,231424L,360448L,720896L,1384448L,2768896L,5537792L,6889472L,13778944L,27557888L,33177600L,66355200L,79495168L,158990336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222193Inst : IEnumerable<long>
{
public static readonly long[] Value=A222193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222193.Bytes);
public long this[int i]=>Value[i];

public static A222193Inst Instance=new A222193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222194
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,13L,14L,19L,20L,21L,22L,74L,75L,131L,132L,182L,183L,234L,235L,317L,318L,500L,501L,996L,997L,998L,1549L,1550L,1551L,2347L,2348L,4453L,4454L,4504L,4505L,4506L,4507L,6111L,15261L,15262L,15263L,15264L,56757L,76252L,80742L,80743L,80744L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222194Inst : IEnumerable<long>
{
public static readonly long[] Value=A222194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222194.Bytes);
public long this[int i]=>Value[i];

public static A222194Inst Instance=new A222194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222195
{
public static readonly long[] Value={ 1L,4L,3L,14L,18L,66L,104L,346L,671L,2086L,4479L,13523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222195Inst : IEnumerable<long>
{
public static readonly long[] Value=A222195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222195.Bytes);
public long this[int i]=>Value[i];

public static A222195Inst Instance=new A222195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222196
{
public static readonly long[] Value={ 1L,2L,3L,7L,12L,20L,51L,74L,246L,303L,1320L,1514L,7936L,8363L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222196Inst : IEnumerable<long>
{
public static readonly long[] Value=A222196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222196.Bytes);
public long this[int i]=>Value[i];

public static A222196Inst Instance=new A222196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222197
{
public static readonly BigInteger[] Value={ 6L,82L,850L,63674L,2861964L,1087362018L,218915964618L,404126474166012L,374905251599545986L,BigInteger.Parse("3300767481388100805696"),BigInteger.Parse("14292173292228195059141732"),BigInteger.Parse("595370485568270695379595524706"),BigInteger.Parse("12097705655943392593368119042729446"),BigInteger.Parse("2376002864597357261596276659315012706002"),BigInteger.Parse("227092183804629590129597176335482393366366980") };
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
public class A222197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222197Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222197.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222197.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222197Inst Instance=new A222197Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222198
{
public static readonly long[] Value={ 6L,28L,84L,257L,856L,2785L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222198Inst : IEnumerable<long>
{
public static readonly long[] Value=A222198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222198.Bytes);
public long this[int i]=>Value[i];

public static A222198Inst Instance=new A222198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222199
{
public static readonly long[] Value={ 48L,1344L,23580L,3273360L,257165468L,171785923808L,61997157648756L,196554899918485160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222199Inst : IEnumerable<long>
{
public static readonly long[] Value=A222199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222199.Bytes);
public long this[int i]=>Value[i];

public static A222199Inst Instance=new A222199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222200
{
public static readonly BigInteger[] Value={ 1L,2L,14L,154L,5320L,301384L,49483138L,13916993782L,10754797724124L,14746957510647992L,BigInteger.Parse("53540340738182687296"),BigInteger.Parse("354282765498796010420944"),BigInteger.Parse("6040964455632840415885507728"),BigInteger.Parse("191678405883294971709423926242394") };
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
public class A222200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222200Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222200.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222200.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222200Inst Instance=new A222200Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222201
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,14L,154L,1072L,5320L,301384L,4638576L,49483138L,13916993782L,467260456608L,10754797724124L,14746957510647992L,1076226888605605706L,BigInteger.Parse("53540340738182687296"),BigInteger.Parse("354282765498796010420944"),BigInteger.Parse("56126499620491437281263608"),BigInteger.Parse("6040964455632840415885507728"),BigInteger.Parse("191678405883294971709423926242394"),BigInteger.Parse("65882516522625836326159786165530572") };
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
public class A222201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222201Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222201.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222201.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222201Inst Instance=new A222201Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222202
{
public static readonly BigInteger[] Value={ 1L,18L,13903L,360783593L,303872744726644L,BigInteger.Parse("8217125138015950451626"),BigInteger.Parse("7095967027221343377167292602835"),BigInteger.Parse("195081705501438193439250404333039349462635"),BigInteger.Parse("170400931523966165754313513175663906434875251822099185"),BigInteger.Parse("4722705723996809689481769489662532396060449405036901391459114641198") };
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
public class A222202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222202Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222202.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222202.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222202Inst Instance=new A222202Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222203
{
public static readonly BigInteger[] Value={ 1L,3L,54L,1140L,99051L,13049563L,6044482889L,4738211572702L,11986520595161863L,BigInteger.Parse("54755153078468134960"),BigInteger.Parse("764291947227525464744293"),BigInteger.Parse("20119942924108379011391597989"),BigInteger.Parse("1558052539448513320447263528275071"),BigInteger.Parse("234788223520702255614480389250160811898"),BigInteger.Parse("101199388044301804167035198499446336399419451"),BigInteger.Parse("86918369741985767628242106496018767545685968221295") };
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
public class A222203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222203Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222203.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222203.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222203Inst Instance=new A222203Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222204
{
public static readonly BigInteger[] Value={ 1L,1L,3L,18L,54L,1140L,13903L,99051L,13049563L,360783593L,6044482889L,4738211572702L,303872744726644L,11986520595161863L,BigInteger.Parse("54755153078468134960"),BigInteger.Parse("8217125138015950451626"),BigInteger.Parse("764291947227525464744293"),BigInteger.Parse("20119942924108379011391597989"),BigInteger.Parse("7095967027221343377167292602835"),BigInteger.Parse("1558052539448513320447263528275071") };
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
public class A222204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222204Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222204.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222204.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222204Inst Instance=new A222204Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222205
{
public static readonly long[] Value={ 1L,4L,20L,110L,636L,3790L,23036L,141946L,883360L,5538098L,34917224L,221125102L,1405276324L,8956020294L,57209977908L,366147270370L,2347081505816L,15065301857194L,96808851937152L,622682497349910L,4008412023724124L,25821543284366686L,166438749582676204L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222205Inst : IEnumerable<long>
{
public static readonly long[] Value=A222205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222205.Bytes);
public long this[int i]=>Value[i];

public static A222205Inst Instance=new A222205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222206
{
public static readonly long[] Value={ 2L,11L,349L,13691L,24329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222206Inst : IEnumerable<long>
{
public static readonly long[] Value=A222206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222206.Bytes);
public long this[int i]=>Value[i];

public static A222206Inst Instance=new A222206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222207
{
public static readonly BigInteger[] Value={ 2L,12L,788L,7636L,874202L,10018884L,1445893544L,2954512034024L,38700329118256L,93229749133527532L,17540746936557672236UL,BigInteger.Parse("243284404062970619608"),BigInteger.Parse("47694250379410432495952"),BigInteger.Parse("136236017676683906365850456"),BigInteger.Parse("404504597532158799519693872144"),BigInteger.Parse("5856120097210409121404621878992"),BigInteger.Parse("18102352585707069737371994385420772"),BigInteger.Parse("3894254646848417473467131712404310728") };
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
public class A222207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222207Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222207.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222207.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222207Inst Instance=new A222207Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222208
{
public static readonly long[] Value={ 1L,3L,2L,6L,4L,12L,5L,18L,8L,24L,7L,36L,9L,15L,16L,54L,10L,48L,11L,72L,20L,21L,13L,108L,28L,27L,32L,30L,14L,96L,17L,162L,42L,60L,40L,144L,19L,33L,90L,216L,22L,120L,23L,84L,64L,39L,25L,324L,35L,168L,50L,270L,26L,192L,56L,180L,44L,126L,29L,288L,31L,51L,80L,486L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222208Inst : IEnumerable<long>
{
public static readonly long[] Value=A222208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222208.Bytes);
public long this[int i]=>Value[i];

public static A222208Inst Instance=new A222208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222209
{
public static readonly long[] Value={ 1L,3L,2L,5L,7L,4L,11L,9L,13L,17L,19L,6L,23L,29L,14L,15L,31L,8L,37L,21L,22L,41L,43L,10L,47L,53L,26L,25L,59L,28L,61L,27L,38L,67L,49L,12L,71L,73L,46L,35L,79L,33L,83L,57L,89L,97L,101L,18L,103L,51L,62L,69L,107L,16L,109L,55L,74L,113L,127L,34L,131L,137L,121L,45L,139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222209Inst : IEnumerable<long>
{
public static readonly long[] Value=A222209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222209.Bytes);
public long this[int i]=>Value[i];

public static A222209Inst Instance=new A222209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222210
{
public static readonly long[] Value={ 1L,0L,2L,3L,4L,5L,6L,7L,8L,9L,1L,0L,2L,3L,4L,5L,6L,7L,8L,9L,21L,20L,22L,23L,24L,25L,26L,27L,28L,29L,31L,30L,32L,33L,34L,35L,36L,37L,38L,39L,41L,40L,42L,43L,44L,45L,46L,47L,48L,49L,51L,50L,52L,53L,54L,55L,56L,57L,58L,59L,61L,60L,62L,63L,64L,65L,66L,67L,68L,69L,71L,70L,72L,73L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222210Inst : IEnumerable<long>
{
public static readonly long[] Value=A222210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222210.Bytes);
public long this[int i]=>Value[i];

public static A222210Inst Instance=new A222210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222211
{
public static readonly long[] Value={ 2L,1L,0L,3L,4L,5L,6L,7L,8L,9L,12L,11L,10L,13L,14L,15L,16L,17L,18L,19L,2L,1L,0L,3L,4L,5L,6L,7L,8L,9L,32L,31L,30L,33L,34L,35L,36L,37L,38L,39L,42L,41L,40L,43L,44L,45L,46L,47L,48L,49L,52L,51L,50L,53L,54L,55L,56L,57L,58L,59L,62L,61L,60L,63L,64L,65L,66L,67L,68L,69L,72L,71L,70L,73L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222211Inst : IEnumerable<long>
{
public static readonly long[] Value=A222211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222211.Bytes);
public long this[int i]=>Value[i];

public static A222211Inst Instance=new A222211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222212
{
public static readonly long[] Value={ 3L,1L,2L,0L,4L,5L,6L,7L,8L,9L,13L,11L,12L,10L,14L,15L,16L,17L,18L,19L,23L,21L,22L,20L,24L,25L,26L,27L,28L,29L,3L,1L,2L,0L,4L,5L,6L,7L,8L,9L,43L,41L,42L,40L,44L,45L,46L,47L,48L,49L,53L,51L,52L,50L,54L,55L,56L,57L,58L,59L,63L,61L,62L,60L,64L,65L,66L,67L,68L,69L,73L,71L,72L,70L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222212Inst : IEnumerable<long>
{
public static readonly long[] Value=A222212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222212.Bytes);
public long this[int i]=>Value[i];

public static A222212Inst Instance=new A222212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222213
{
public static readonly long[] Value={ 4L,1L,2L,3L,0L,5L,6L,7L,8L,9L,14L,11L,12L,13L,10L,15L,16L,17L,18L,19L,24L,21L,22L,23L,20L,25L,26L,27L,28L,29L,34L,31L,32L,33L,30L,35L,36L,37L,38L,39L,4L,1L,2L,3L,0L,5L,6L,7L,8L,9L,54L,51L,52L,53L,50L,55L,56L,57L,58L,59L,64L,61L,62L,63L,60L,65L,66L,67L,68L,69L,74L,71L,72L,73L,70L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222213Inst : IEnumerable<long>
{
public static readonly long[] Value=A222213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222213.Bytes);
public long this[int i]=>Value[i];

public static A222213Inst Instance=new A222213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222214
{
public static readonly long[] Value={ 5L,1L,2L,3L,4L,0L,6L,7L,8L,9L,15L,11L,12L,13L,14L,10L,16L,17L,18L,19L,25L,21L,22L,23L,24L,20L,26L,27L,28L,29L,35L,31L,32L,33L,34L,30L,36L,37L,38L,39L,45L,41L,42L,43L,44L,40L,46L,47L,48L,49L,5L,1L,2L,3L,4L,0L,6L,7L,8L,9L,65L,61L,62L,63L,64L,60L,66L,67L,68L,69L,75L,71L,72L,73L,74L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222214Inst : IEnumerable<long>
{
public static readonly long[] Value=A222214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222214.Bytes);
public long this[int i]=>Value[i];

public static A222214Inst Instance=new A222214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222215
{
public static readonly long[] Value={ 6L,1L,2L,3L,4L,5L,0L,7L,8L,9L,16L,11L,12L,13L,14L,15L,10L,17L,18L,19L,26L,21L,22L,23L,24L,25L,20L,27L,28L,29L,36L,31L,32L,33L,34L,35L,30L,37L,38L,39L,46L,41L,42L,43L,44L,45L,40L,47L,48L,49L,56L,51L,52L,53L,54L,55L,50L,57L,58L,59L,6L,1L,2L,3L,4L,5L,0L,7L,8L,9L,76L,71L,72L,73L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222215Inst : IEnumerable<long>
{
public static readonly long[] Value=A222215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222215.Bytes);
public long this[int i]=>Value[i];

public static A222215Inst Instance=new A222215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222216
{
public static readonly long[] Value={ 7L,1L,2L,3L,4L,5L,6L,0L,8L,9L,17L,11L,12L,13L,14L,15L,16L,10L,18L,19L,27L,21L,22L,23L,24L,25L,26L,20L,28L,29L,37L,31L,32L,33L,34L,35L,36L,30L,38L,39L,47L,41L,42L,43L,44L,45L,46L,40L,48L,49L,57L,51L,52L,53L,54L,55L,56L,50L,58L,59L,67L,61L,62L,63L,64L,65L,66L,60L,68L,69L,7L,1L,2L,3L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222216Inst : IEnumerable<long>
{
public static readonly long[] Value=A222216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222216.Bytes);
public long this[int i]=>Value[i];

public static A222216Inst Instance=new A222216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222217
{
public static readonly long[] Value={ 8L,1L,2L,3L,4L,5L,6L,7L,0L,9L,18L,11L,12L,13L,14L,15L,16L,17L,10L,19L,28L,21L,22L,23L,24L,25L,26L,27L,20L,29L,38L,31L,32L,33L,34L,35L,36L,37L,30L,39L,48L,41L,42L,43L,44L,45L,46L,47L,40L,49L,58L,51L,52L,53L,54L,55L,56L,57L,50L,59L,68L,61L,62L,63L,64L,65L,66L,67L,60L,69L,78L,71L,72L,73L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222217Inst : IEnumerable<long>
{
public static readonly long[] Value=A222217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222217.Bytes);
public long this[int i]=>Value[i];

public static A222217Inst Instance=new A222217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222218
{
public static readonly long[] Value={ 9L,1L,2L,3L,4L,5L,6L,7L,8L,0L,19L,11L,12L,13L,14L,15L,16L,17L,18L,10L,29L,21L,22L,23L,24L,25L,26L,27L,28L,20L,39L,31L,32L,33L,34L,35L,36L,37L,38L,30L,49L,41L,42L,43L,44L,45L,46L,47L,48L,40L,59L,51L,52L,53L,54L,55L,56L,57L,58L,50L,69L,61L,62L,63L,64L,65L,66L,67L,68L,60L,79L,71L,72L,73L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222218Inst : IEnumerable<long>
{
public static readonly long[] Value=A222218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222218.Bytes);
public long this[int i]=>Value[i];

public static A222218Inst Instance=new A222218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222219
{
public static readonly BigInteger[] Value={ 5L,11L,13L,19L,23L,29L,53L,61L,113L,239L,251L,503L,1013L,1021L,4093L,8191L,65519L,65521L,262133L,1048571L,4194301L,BigInteger.Parse("302231454903657293676533") };
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
public class A222219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222219Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222219.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222219.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222219Inst Instance=new A222219Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222220
{
public static readonly long[] Value={ 0L,3L,2L,1L,4L,5L,6L,7L,8L,9L,30L,33L,32L,31L,34L,35L,36L,37L,38L,39L,20L,23L,22L,21L,24L,25L,26L,27L,28L,29L,10L,13L,12L,11L,14L,15L,16L,17L,18L,19L,40L,43L,42L,41L,44L,45L,46L,47L,48L,49L,50L,53L,52L,51L,54L,55L,56L,57L,58L,59L,60L,63L,62L,61L,64L,65L,66L,67L,68L,69L,70L,73L,72L,71L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222220Inst : IEnumerable<long>
{
public static readonly long[] Value=A222220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222220.Bytes);
public long this[int i]=>Value[i];

public static A222220Inst Instance=new A222220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222221
{
public static readonly long[] Value={ 0L,4L,2L,3L,1L,5L,6L,7L,8L,9L,40L,44L,42L,43L,41L,45L,46L,47L,48L,49L,20L,24L,22L,23L,21L,25L,26L,27L,28L,29L,30L,34L,32L,33L,31L,35L,36L,37L,38L,39L,10L,14L,12L,13L,11L,15L,16L,17L,18L,19L,50L,54L,52L,53L,51L,55L,56L,57L,58L,59L,60L,64L,62L,63L,61L,65L,66L,67L,68L,69L,70L,74L,72L,73L,71L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222221Inst : IEnumerable<long>
{
public static readonly long[] Value=A222221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222221.Bytes);
public long this[int i]=>Value[i];

public static A222221Inst Instance=new A222221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222222
{
public static readonly long[] Value={ 0L,5L,2L,3L,4L,1L,6L,7L,8L,9L,50L,55L,52L,53L,54L,51L,56L,57L,58L,59L,20L,25L,22L,23L,24L,21L,26L,27L,28L,29L,30L,35L,32L,33L,34L,31L,36L,37L,38L,39L,40L,45L,42L,43L,44L,41L,46L,47L,48L,49L,10L,15L,12L,13L,14L,11L,16L,17L,18L,19L,60L,65L,62L,63L,64L,61L,66L,67L,68L,69L,70L,75L,72L,73L,74L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222222Inst : IEnumerable<long>
{
public static readonly long[] Value=A222222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222222.Bytes);
public long this[int i]=>Value[i];

public static A222222Inst Instance=new A222222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222223
{
public static readonly long[] Value={ 0L,6L,2L,3L,4L,5L,1L,7L,8L,9L,60L,66L,62L,63L,64L,65L,61L,67L,68L,69L,20L,26L,22L,23L,24L,25L,21L,27L,28L,29L,30L,36L,32L,33L,34L,35L,31L,37L,38L,39L,40L,46L,42L,43L,44L,45L,41L,47L,48L,49L,50L,56L,52L,53L,54L,55L,51L,57L,58L,59L,10L,16L,12L,13L,14L,15L,11L,17L,18L,19L,70L,76L,72L,73L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222223Inst : IEnumerable<long>
{
public static readonly long[] Value=A222223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222223.Bytes);
public long this[int i]=>Value[i];

public static A222223Inst Instance=new A222223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222224
{
public static readonly long[] Value={ 0L,7L,2L,3L,4L,5L,6L,1L,8L,9L,70L,77L,72L,73L,74L,75L,76L,71L,78L,79L,20L,27L,22L,23L,24L,25L,26L,21L,28L,29L,30L,37L,32L,33L,34L,35L,36L,31L,38L,39L,40L,47L,42L,43L,44L,45L,46L,41L,48L,49L,50L,57L,52L,53L,54L,55L,56L,51L,58L,59L,60L,67L,62L,63L,64L,65L,66L,61L,68L,69L,10L,17L,12L,13L,14L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222224Inst : IEnumerable<long>
{
public static readonly long[] Value=A222224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222224.Bytes);
public long this[int i]=>Value[i];

public static A222224Inst Instance=new A222224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222225
{
public static readonly long[] Value={ 0L,8L,2L,3L,4L,5L,6L,7L,1L,9L,80L,88L,82L,83L,84L,85L,86L,87L,81L,89L,20L,28L,22L,23L,24L,25L,26L,27L,21L,29L,30L,38L,32L,33L,34L,35L,36L,37L,31L,39L,40L,48L,42L,43L,44L,45L,46L,47L,41L,49L,50L,58L,52L,53L,54L,55L,56L,57L,51L,59L,60L,68L,62L,63L,64L,65L,66L,67L,61L,69L,70L,78L,72L,73L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222225Inst : IEnumerable<long>
{
public static readonly long[] Value=A222225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222225.Bytes);
public long this[int i]=>Value[i];

public static A222225Inst Instance=new A222225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222226
{
public static readonly long[] Value={ 0L,9L,2L,3L,4L,5L,6L,7L,8L,1L,90L,99L,92L,93L,94L,95L,96L,97L,98L,91L,20L,29L,22L,23L,24L,25L,26L,27L,28L,21L,30L,39L,32L,33L,34L,35L,36L,37L,38L,31L,40L,49L,42L,43L,44L,45L,46L,47L,48L,41L,50L,59L,52L,53L,54L,55L,56L,57L,58L,51L,60L,69L,62L,63L,64L,65L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222226Inst : IEnumerable<long>
{
public static readonly long[] Value=A222226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222226.Bytes);
public long this[int i]=>Value[i];

public static A222226Inst Instance=new A222226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222227
{
public static readonly long[] Value={ 3L,7L,13L,31L,241L,65521L,1048573L,2305843009213693951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222227Inst : IEnumerable<long>
{
public static readonly long[] Value=A222227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222227.Bytes);
public long this[int i]=>Value[i];

public static A222227Inst Instance=new A222227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222228
{
public static readonly long[] Value={ 0L,1L,4L,3L,2L,5L,6L,7L,8L,9L,10L,11L,14L,13L,12L,15L,16L,17L,18L,19L,40L,41L,44L,43L,42L,45L,46L,47L,48L,49L,30L,31L,34L,33L,32L,35L,36L,37L,38L,39L,20L,21L,24L,23L,22L,25L,26L,27L,28L,29L,50L,51L,54L,53L,52L,55L,56L,57L,58L,59L,60L,61L,64L,63L,62L,65L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222228Inst : IEnumerable<long>
{
public static readonly long[] Value=A222228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222228.Bytes);
public long this[int i]=>Value[i];

public static A222228Inst Instance=new A222228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222229
{
public static readonly long[] Value={ 0L,1L,5L,3L,4L,2L,6L,7L,8L,9L,10L,11L,15L,13L,14L,12L,16L,17L,18L,19L,50L,51L,55L,53L,54L,52L,56L,57L,58L,59L,30L,31L,35L,33L,34L,32L,36L,37L,38L,39L,40L,41L,45L,43L,44L,42L,46L,47L,48L,49L,20L,21L,25L,23L,24L,22L,26L,27L,28L,29L,60L,61L,65L,63L,64L,62L,66L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222229Inst : IEnumerable<long>
{
public static readonly long[] Value=A222229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222229.Bytes);
public long this[int i]=>Value[i];

public static A222229Inst Instance=new A222229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222230
{
public static readonly long[] Value={ 0L,1L,6L,3L,4L,5L,2L,7L,8L,9L,10L,11L,16L,13L,14L,15L,12L,17L,18L,19L,60L,61L,66L,63L,64L,65L,62L,67L,68L,69L,30L,31L,36L,33L,34L,35L,32L,37L,38L,39L,40L,41L,46L,43L,44L,45L,42L,47L,48L,49L,50L,51L,56L,53L,54L,55L,52L,57L,58L,59L,20L,21L,26L,23L,24L,25L,22L,27L,28L,29L,70L,71L,76L,73L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222230Inst : IEnumerable<long>
{
public static readonly long[] Value=A222230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222230.Bytes);
public long this[int i]=>Value[i];

public static A222230Inst Instance=new A222230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222231
{
public static readonly long[] Value={ 0L,1L,7L,3L,4L,5L,6L,2L,8L,9L,10L,11L,17L,13L,14L,15L,16L,12L,18L,19L,70L,71L,77L,73L,74L,75L,76L,72L,78L,79L,30L,31L,37L,33L,34L,35L,36L,32L,38L,39L,40L,41L,47L,43L,44L,45L,46L,42L,48L,49L,50L,51L,57L,53L,54L,55L,56L,52L,58L,59L,60L,61L,67L,63L,64L,65L,66L,62L,68L,69L,20L,21L,27L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222231Inst : IEnumerable<long>
{
public static readonly long[] Value=A222231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222231.Bytes);
public long this[int i]=>Value[i];

public static A222231Inst Instance=new A222231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222232
{
public static readonly long[] Value={ 0L,1L,8L,3L,4L,5L,6L,7L,2L,9L,10L,11L,18L,13L,14L,15L,16L,17L,12L,19L,80L,81L,88L,83L,84L,85L,86L,87L,82L,89L,30L,31L,38L,33L,34L,35L,36L,37L,32L,39L,40L,41L,48L,43L,44L,45L,46L,47L,42L,49L,50L,51L,58L,53L,54L,55L,56L,57L,52L,59L,60L,61L,68L,63L,64L,65L,66L,67L,62L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222232Inst : IEnumerable<long>
{
public static readonly long[] Value=A222232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222232.Bytes);
public long this[int i]=>Value[i];

public static A222232Inst Instance=new A222232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222233
{
public static readonly long[] Value={ 0L,1L,9L,3L,4L,5L,6L,7L,8L,2L,10L,11L,19L,13L,14L,15L,16L,17L,18L,12L,90L,91L,99L,93L,94L,95L,96L,97L,98L,92L,30L,31L,39L,33L,34L,35L,36L,37L,38L,32L,40L,41L,49L,43L,44L,45L,46L,47L,48L,42L,50L,51L,59L,53L,54L,55L,56L,57L,58L,52L,60L,61L,69L,63L,64L,65L,66L,67L,68L,62L,70L,71L,79L,73L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222233Inst : IEnumerable<long>
{
public static readonly long[] Value=A222233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222233.Bytes);
public long this[int i]=>Value[i];

public static A222233Inst Instance=new A222233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222234
{
public static readonly long[] Value={ 0L,1L,2L,4L,3L,5L,6L,7L,8L,9L,10L,11L,12L,14L,13L,15L,16L,17L,18L,19L,20L,21L,22L,24L,23L,25L,26L,27L,28L,29L,40L,41L,42L,44L,43L,45L,46L,47L,48L,49L,30L,31L,32L,34L,33L,35L,36L,37L,38L,39L,50L,51L,52L,54L,53L,55L,56L,57L,58L,59L,60L,61L,62L,64L,63L,65L,66L,67L,68L,69L,70L,71L,72L,74L,73L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222234Inst : IEnumerable<long>
{
public static readonly long[] Value=A222234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222234.Bytes);
public long this[int i]=>Value[i];

public static A222234Inst Instance=new A222234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222235
{
public static readonly long[] Value={ 0L,1L,2L,5L,4L,3L,6L,7L,8L,9L,10L,11L,12L,15L,14L,13L,16L,17L,18L,19L,20L,21L,22L,25L,24L,23L,26L,27L,28L,29L,50L,51L,52L,55L,54L,53L,56L,57L,58L,59L,40L,41L,42L,45L,44L,43L,46L,47L,48L,49L,30L,31L,32L,35L,34L,33L,36L,37L,38L,39L,60L,61L,62L,65L,64L,63L,66L,67L,68L,69L,70L,71L,72L,75L,74L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222235Inst : IEnumerable<long>
{
public static readonly long[] Value=A222235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222235.Bytes);
public long this[int i]=>Value[i];

public static A222235Inst Instance=new A222235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222236
{
public static readonly long[] Value={ 0L,1L,2L,6L,4L,5L,3L,7L,8L,9L,10L,11L,12L,16L,14L,15L,13L,17L,18L,19L,20L,21L,22L,26L,24L,25L,23L,27L,28L,29L,60L,61L,62L,66L,64L,65L,63L,67L,68L,69L,40L,41L,42L,46L,44L,45L,43L,47L,48L,49L,50L,51L,52L,56L,54L,55L,53L,57L,58L,59L,30L,31L,32L,36L,34L,35L,33L,37L,38L,39L,70L,71L,72L,76L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222236Inst : IEnumerable<long>
{
public static readonly long[] Value=A222236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222236.Bytes);
public long this[int i]=>Value[i];

public static A222236Inst Instance=new A222236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222237
{
public static readonly long[] Value={ 0L,1L,2L,7L,4L,5L,6L,3L,8L,9L,10L,11L,12L,17L,14L,15L,16L,13L,18L,19L,20L,21L,22L,27L,24L,25L,26L,23L,28L,29L,70L,71L,72L,77L,74L,75L,76L,73L,78L,79L,40L,41L,42L,47L,44L,45L,46L,43L,48L,49L,50L,51L,52L,57L,54L,55L,56L,53L,58L,59L,60L,61L,62L,67L,64L,65L,66L,63L,68L,69L,30L,31L,32L,37L,34L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222237Inst : IEnumerable<long>
{
public static readonly long[] Value=A222237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222237.Bytes);
public long this[int i]=>Value[i];

public static A222237Inst Instance=new A222237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222238
{
public static readonly long[] Value={ 0L,1L,2L,8L,4L,5L,6L,7L,3L,9L,10L,11L,12L,18L,14L,15L,16L,17L,13L,19L,20L,21L,22L,28L,24L,25L,26L,27L,23L,29L,80L,81L,82L,88L,84L,85L,86L,87L,83L,89L,40L,41L,42L,48L,44L,45L,46L,47L,43L,49L,50L,51L,52L,58L,54L,55L,56L,57L,53L,59L,60L,61L,62L,68L,64L,65L,66L,67L,63L,69L,70L,71L,72L,78L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222238Inst : IEnumerable<long>
{
public static readonly long[] Value=A222238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222238.Bytes);
public long this[int i]=>Value[i];

public static A222238Inst Instance=new A222238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222239
{
public static readonly long[] Value={ 0L,1L,2L,9L,4L,5L,6L,7L,8L,3L,10L,11L,12L,19L,14L,15L,16L,17L,18L,13L,20L,21L,22L,29L,24L,25L,26L,27L,28L,23L,90L,91L,92L,99L,94L,95L,96L,97L,98L,93L,40L,41L,42L,49L,44L,45L,46L,47L,48L,43L,50L,51L,52L,59L,54L,55L,56L,57L,58L,53L,60L,61L,62L,69L,64L,65L,66L,67L,68L,63L,70L,71L,72L,79L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222239Inst : IEnumerable<long>
{
public static readonly long[] Value=A222239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222239.Bytes);
public long this[int i]=>Value[i];

public static A222239Inst Instance=new A222239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222240
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,4L,6L,7L,8L,9L,10L,11L,12L,13L,15L,14L,16L,17L,18L,19L,20L,21L,22L,23L,25L,24L,26L,27L,28L,29L,30L,31L,32L,33L,35L,34L,36L,37L,38L,39L,50L,51L,52L,53L,55L,54L,56L,57L,58L,59L,40L,41L,42L,43L,45L,44L,46L,47L,48L,49L,60L,61L,62L,63L,65L,64L,66L,67L,68L,69L,70L,71L,72L,73L,75L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222240Inst : IEnumerable<long>
{
public static readonly long[] Value=A222240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222240.Bytes);
public long this[int i]=>Value[i];

public static A222240Inst Instance=new A222240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222241
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,5L,4L,7L,8L,9L,10L,11L,12L,13L,16L,15L,14L,17L,18L,19L,20L,21L,22L,23L,26L,25L,24L,27L,28L,29L,30L,31L,32L,33L,36L,35L,34L,37L,38L,39L,60L,61L,62L,63L,66L,65L,64L,67L,68L,69L,50L,51L,52L,53L,56L,55L,54L,57L,58L,59L,40L,41L,42L,43L,46L,45L,44L,47L,48L,49L,70L,71L,72L,73L,76L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222241Inst : IEnumerable<long>
{
public static readonly long[] Value=A222241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222241.Bytes);
public long this[int i]=>Value[i];

public static A222241Inst Instance=new A222241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222242
{
public static readonly long[] Value={ 0L,1L,2L,3L,7L,5L,6L,4L,8L,9L,10L,11L,12L,13L,17L,15L,16L,14L,18L,19L,20L,21L,22L,23L,27L,25L,26L,24L,28L,29L,30L,31L,32L,33L,37L,35L,36L,34L,38L,39L,70L,71L,72L,73L,77L,75L,76L,74L,78L,79L,50L,51L,52L,53L,57L,55L,56L,54L,58L,59L,60L,61L,62L,63L,67L,65L,66L,64L,68L,69L,40L,41L,42L,43L,47L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222242Inst : IEnumerable<long>
{
public static readonly long[] Value=A222242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222242.Bytes);
public long this[int i]=>Value[i];

public static A222242Inst Instance=new A222242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222243
{
public static readonly long[] Value={ 0L,1L,2L,3L,8L,5L,6L,7L,4L,9L,10L,11L,12L,13L,18L,15L,16L,17L,14L,19L,20L,21L,22L,23L,28L,25L,26L,27L,24L,29L,30L,31L,32L,33L,38L,35L,36L,37L,34L,39L,80L,81L,82L,83L,88L,85L,86L,87L,84L,89L,50L,51L,52L,53L,58L,55L,56L,57L,54L,59L,60L,61L,62L,63L,68L,65L,66L,67L,64L,69L,70L,71L,72L,73L,78L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222243Inst : IEnumerable<long>
{
public static readonly long[] Value=A222243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222243.Bytes);
public long this[int i]=>Value[i];

public static A222243Inst Instance=new A222243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222244
{
public static readonly long[] Value={ 0L,1L,2L,3L,9L,5L,6L,7L,8L,4L,10L,11L,12L,13L,19L,15L,16L,17L,18L,14L,20L,21L,22L,23L,29L,25L,26L,27L,28L,24L,30L,31L,32L,33L,39L,35L,36L,37L,38L,34L,90L,91L,92L,93L,99L,95L,96L,97L,98L,94L,50L,51L,52L,53L,59L,55L,56L,57L,58L,54L,60L,61L,62L,63L,69L,65L,66L,67L,68L,64L,70L,71L,72L,73L,79L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222244Inst : IEnumerable<long>
{
public static readonly long[] Value=A222244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222244.Bytes);
public long this[int i]=>Value[i];

public static A222244Inst Instance=new A222244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222245
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,5L,7L,8L,9L,10L,11L,12L,13L,14L,16L,15L,17L,18L,19L,20L,21L,22L,23L,24L,26L,25L,27L,28L,29L,30L,31L,32L,33L,34L,36L,35L,37L,38L,39L,40L,41L,42L,43L,44L,46L,45L,47L,48L,49L,60L,61L,62L,63L,64L,66L,65L,67L,68L,69L,50L,51L,52L,53L,54L,56L,55L,57L,58L,59L,70L,71L,72L,73L,74L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222245Inst : IEnumerable<long>
{
public static readonly long[] Value=A222245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222245.Bytes);
public long this[int i]=>Value[i];

public static A222245Inst Instance=new A222245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222246
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,7L,6L,5L,8L,9L,10L,11L,12L,13L,14L,17L,16L,15L,18L,19L,20L,21L,22L,23L,24L,27L,26L,25L,28L,29L,30L,31L,32L,33L,34L,37L,36L,35L,38L,39L,40L,41L,42L,43L,44L,47L,46L,45L,48L,49L,70L,71L,72L,73L,74L,77L,76L,75L,78L,79L,60L,61L,62L,63L,64L,67L,66L,65L,68L,69L,50L,51L,52L,53L,54L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222246Inst : IEnumerable<long>
{
public static readonly long[] Value=A222246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222246.Bytes);
public long this[int i]=>Value[i];

public static A222246Inst Instance=new A222246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222247
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,8L,6L,7L,5L,9L,10L,11L,12L,13L,14L,18L,16L,17L,15L,19L,20L,21L,22L,23L,24L,28L,26L,27L,25L,29L,30L,31L,32L,33L,34L,38L,36L,37L,35L,39L,40L,41L,42L,43L,44L,48L,46L,47L,45L,49L,80L,81L,82L,83L,84L,88L,86L,87L,85L,89L,60L,61L,62L,63L,64L,68L,66L,67L,65L,69L,70L,71L,72L,73L,74L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222247Inst : IEnumerable<long>
{
public static readonly long[] Value=A222247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222247.Bytes);
public long this[int i]=>Value[i];

public static A222247Inst Instance=new A222247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222248
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,9L,6L,7L,8L,5L,10L,11L,12L,13L,14L,19L,16L,17L,18L,15L,20L,21L,22L,23L,24L,29L,26L,27L,28L,25L,30L,31L,32L,33L,34L,39L,36L,37L,38L,35L,40L,41L,42L,43L,44L,49L,46L,47L,48L,45L,90L,91L,92L,93L,94L,99L,96L,97L,98L,95L,60L,61L,62L,63L,64L,69L,66L,67L,68L,65L,70L,71L,72L,73L,74L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222248Inst : IEnumerable<long>
{
public static readonly long[] Value=A222248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222248.Bytes);
public long this[int i]=>Value[i];

public static A222248Inst Instance=new A222248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222249
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,6L,8L,9L,10L,11L,12L,13L,14L,15L,17L,16L,18L,19L,20L,21L,22L,23L,24L,25L,27L,26L,28L,29L,30L,31L,32L,33L,34L,35L,37L,36L,38L,39L,40L,41L,42L,43L,44L,45L,47L,46L,48L,49L,50L,51L,52L,53L,54L,55L,57L,56L,58L,59L,70L,71L,72L,73L,74L,75L,77L,76L,78L,79L,60L,61L,62L,63L,64L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222249Inst : IEnumerable<long>
{
public static readonly long[] Value=A222249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222249.Bytes);
public long this[int i]=>Value[i];

public static A222249Inst Instance=new A222249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222250
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,8L,7L,6L,9L,10L,11L,12L,13L,14L,15L,18L,17L,16L,19L,20L,21L,22L,23L,24L,25L,28L,27L,26L,29L,30L,31L,32L,33L,34L,35L,38L,37L,36L,39L,40L,41L,42L,43L,44L,45L,48L,47L,46L,49L,50L,51L,52L,53L,54L,55L,58L,57L,56L,59L,80L,81L,82L,83L,84L,85L,88L,87L,86L,89L,70L,71L,72L,73L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222250Inst : IEnumerable<long>
{
public static readonly long[] Value=A222250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222250.Bytes);
public long this[int i]=>Value[i];

public static A222250Inst Instance=new A222250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222251
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,9L,7L,8L,6L,10L,11L,12L,13L,14L,15L,19L,17L,18L,16L,20L,21L,22L,23L,24L,25L,29L,27L,28L,26L,30L,31L,32L,33L,34L,35L,39L,37L,38L,36L,40L,41L,42L,43L,44L,45L,49L,47L,48L,46L,50L,51L,52L,53L,54L,55L,59L,57L,58L,56L,90L,91L,92L,93L,94L,95L,99L,97L,98L,96L,70L,71L,72L,73L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222251Inst : IEnumerable<long>
{
public static readonly long[] Value=A222251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222251.Bytes);
public long this[int i]=>Value[i];

public static A222251Inst Instance=new A222251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222252
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,8L,7L,9L,10L,11L,12L,13L,14L,15L,16L,18L,17L,19L,20L,21L,22L,23L,24L,25L,26L,28L,27L,29L,30L,31L,32L,33L,34L,35L,36L,38L,37L,39L,40L,41L,42L,43L,44L,45L,46L,48L,47L,49L,50L,51L,52L,53L,54L,55L,56L,58L,57L,59L,60L,61L,62L,63L,64L,65L,66L,68L,67L,69L,80L,81L,82L,83L,84L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222252Inst : IEnumerable<long>
{
public static readonly long[] Value=A222252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222252.Bytes);
public long this[int i]=>Value[i];

public static A222252Inst Instance=new A222252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222253
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,9L,8L,7L,10L,11L,12L,13L,14L,15L,16L,19L,18L,17L,20L,21L,22L,23L,24L,25L,26L,29L,28L,27L,30L,31L,32L,33L,34L,35L,36L,39L,38L,37L,40L,41L,42L,43L,44L,45L,46L,49L,48L,47L,50L,51L,52L,53L,54L,55L,56L,59L,58L,57L,60L,61L,62L,63L,64L,65L,66L,69L,68L,67L,90L,91L,92L,93L,94L,95L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222253Inst : IEnumerable<long>
{
public static readonly long[] Value=A222253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222253.Bytes);
public long this[int i]=>Value[i];

public static A222253Inst Instance=new A222253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222254
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,9L,8L,10L,11L,12L,13L,14L,15L,16L,17L,19L,18L,20L,21L,22L,23L,24L,25L,26L,27L,29L,28L,30L,31L,32L,33L,34L,35L,36L,37L,39L,38L,40L,41L,42L,43L,44L,45L,46L,47L,49L,48L,50L,51L,52L,53L,54L,55L,56L,57L,59L,58L,60L,61L,62L,63L,64L,65L,66L,67L,69L,68L,70L,71L,72L,73L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222254Inst : IEnumerable<long>
{
public static readonly long[] Value=A222254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222254.Bytes);
public long this[int i]=>Value[i];

public static A222254Inst Instance=new A222254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222255
{
public static readonly BigInteger[] Value={ 2L,2L,2L,2L,5L,5L,193L,2903041L,250822656001L,1807729046323200001L,BigInteger.Parse("1472038679443987759104000001"),BigInteger.Parse("21817028147643299474152432146548259236610048000000000001") };
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
public class A222255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222255Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222255.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A222255.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222255Inst Instance=new A222255Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222256
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,8L,6L,7L,14L,9L,10L,20L,12L,13L,26L,15L,16L,32L,18L,19L,38L,21L,22L,44L,24L,25L,50L,27L,28L,56L,30L,31L,62L,33L,34L,68L,36L,37L,74L,39L,40L,80L,42L,43L,86L,45L,46L,92L,48L,49L,98L,51L,52L,104L,54L,55L,110L,57L,58L,116L,60L,61L,122L,63L,64L,128L,66L,67L,134L,69L,70L,140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222256Inst : IEnumerable<long>
{
public static readonly long[] Value=A222256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222256.Bytes);
public long this[int i]=>Value[i];

public static A222256Inst Instance=new A222256Inst();

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