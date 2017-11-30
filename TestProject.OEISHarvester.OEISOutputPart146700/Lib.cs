using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A176005
{
public static readonly long[] Value={ 1L,1L,0L,-1L,-3L,0L,3L,11L,24L,45L,75L,125L,175L,245L,91L,24L,0L,-24L,-5L,-1L,0L,1L,-3L,-7L,-11L,-15L,-19L,-23L,-16L,-9L,-5L,0L,0L,0L,-5L,-11L,-24L,-37L,-35L,-33L,-27L,-21L,-11L,-1L,13L,0L,-13L,-27L,-41L,-55L,-69L,0L,69L,221L,485L,344L,240L,136L,69L,27L,-15L,-32L,-36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176005Inst : IEnumerable<long>
{
public static readonly long[] Value=A176005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176005.Bytes);
public long this[int i]=>Value[i];

public static A176005Inst Instance=new A176005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176006
{
public static readonly long[] Value={ 1L,2L,4L,10L,32L,122L,516L,2322L,10880L,52466L,258564L,1296282L,6589728L,33887466L,175966212L,921353250L,4858956288L,25786112994L,137604139012L,737922992938L,3974647310112L,21493266631002L,116642921832964L,635074797251890L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176006Inst : IEnumerable<long>
{
public static readonly long[] Value=A176006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176006.Bytes);
public long this[int i]=>Value[i];

public static A176006Inst Instance=new A176006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176007
{
public static readonly long[] Value={ 2L,5L,6L,97L,120L,330L,355L,552L,1015L,4525L,5227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176007Inst : IEnumerable<long>
{
public static readonly long[] Value=A176007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176007.Bytes);
public long this[int i]=>Value[i];

public static A176007Inst Instance=new A176007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176008
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,9L,10L,40L,82L,159L,177L,525L,880L,2577L,3771L,11872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176008Inst : IEnumerable<long>
{
public static readonly long[] Value=A176008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176008.Bytes);
public long this[int i]=>Value[i];

public static A176008Inst Instance=new A176008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176009
{
public static readonly long[] Value={ 11L,211L,1123L,1423L,112543L,1124653L,1234657L,112345687L,1123468597L,10123457689L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176009Inst : IEnumerable<long>
{
public static readonly long[] Value=A176009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176009.Bytes);
public long this[int i]=>Value[i];

public static A176009Inst Instance=new A176009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176010
{
public static readonly long[] Value={ 14L,83L,111L,180L,208L,277L,305L,374L,402L,471L,499L,568L,596L,665L,693L,762L,790L,859L,887L,956L,984L,1053L,1081L,1150L,1178L,1247L,1275L,1344L,1372L,1441L,1469L,1538L,1566L,1635L,1663L,1732L,1760L,1829L,1857L,1926L,1954L,2023L,2051L,2120L,2148L,2217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176010Inst : IEnumerable<long>
{
public static readonly long[] Value=A176010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176010.Bytes);
public long this[int i]=>Value[i];

public static A176010Inst Instance=new A176010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176011
{
public static readonly BigInteger[] Value={ 97L,197L,397L,797L,1597L,6397L,51197L,102397L,204797L,409597L,13107197L,209715197L,1677721597L,107374182397L,1717986918397L,54975581388797L,14073748835532797L,3602879701896396797L,BigInteger.Parse("461168601842738790397"),BigInteger.Parse("1888946593147858085478397"),BigInteger.Parse("3868562622766813359059763197") };
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
public class A176011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176011Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176011.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176011.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176011Inst Instance=new A176011Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176012
{
public static readonly long[] Value={ 227L,827L,1201L,1621L,2179L,2333L,2441L,2711L,3041L,3251L,3329L,3541L,5147L,5167L,5701L,5711L,6131L,6661L,6833L,7321L,7331L,8501L,9209L,9239L,10271L,13807L,14251L,14449L,14629L,15731L,15761L,16007L,16139L,16619L,16741L,17291L,19421L,20231L,20441L,20507L,22441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176012Inst : IEnumerable<long>
{
public static readonly long[] Value=A176012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176012.Bytes);
public long this[int i]=>Value[i];

public static A176012Inst Instance=new A176012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176013
{
public static readonly long[] Value={ -1L,2L,1L,-6L,-9L,-1L,24L,72L,24L,1L,-120L,-600L,-400L,-50L,-1L,720L,5400L,6000L,1500L,90L,1L,-5040L,-52920L,-88200L,-36750L,-4410L,-147L,-1L,40320L,564480L,1317120L,823200L,164640L,10976L,224L,1L,-362880L,-6531840L,-20321280L,-17781120L,-5334336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176013Inst : IEnumerable<long>
{
public static readonly long[] Value=A176013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176013.Bytes);
public long this[int i]=>Value[i];

public static A176013Inst Instance=new A176013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176014
{
public static readonly long[] Value={ 1L,2L,6L,3L,7L,6L,2L,6L,1L,5L,8L,2L,5L,9L,7L,3L,3L,3L,4L,4L,3L,1L,3L,4L,1L,1L,9L,8L,9L,5L,4L,6L,6L,8L,0L,8L,1L,4L,9L,7L,4L,0L,9L,4L,2L,9L,4L,6L,1L,3L,2L,8L,6L,5L,0L,4L,3L,4L,5L,4L,0L,3L,5L,3L,9L,8L,4L,4L,7L,8L,0L,7L,0L,9L,2L,4L,6L,2L,8L,4L,8L,1L,1L,0L,0L,7L,2L,6L,9L,2L,6L,5L,8L,2L,2L,4L,0L,8L,3L,8L,7L,7L,9L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176014Inst : IEnumerable<long>
{
public static readonly long[] Value=A176014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176014.Bytes);
public long this[int i]=>Value[i];

public static A176014Inst Instance=new A176014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176015
{
public static readonly long[] Value={ 1L,1L,7L,0L,8L,2L,0L,3L,9L,3L,2L,4L,9L,9L,3L,6L,9L,0L,8L,9L,2L,2L,7L,5L,2L,1L,0L,0L,6L,1L,9L,3L,8L,2L,8L,7L,0L,6L,3L,2L,1L,8L,5L,5L,0L,7L,8L,8L,3L,4L,5L,7L,7L,1L,7L,2L,8L,1L,2L,6L,9L,1L,7L,3L,6L,2L,3L,1L,5L,6L,2L,7L,7L,6L,9L,1L,3L,4L,1L,4L,6L,9L,8L,2L,4L,3L,2L,4L,3L,2L,2L,5L,1L,3L,6L,3L,4L,6L,8L,2L,4L,9L,0L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176015Inst : IEnumerable<long>
{
public static readonly long[] Value=A176015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176015.Bytes);
public long this[int i]=>Value[i];

public static A176015Inst Instance=new A176015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176016
{
public static readonly long[] Value={ 1L,1L,4L,5L,4L,9L,7L,2L,2L,4L,3L,6L,7L,9L,0L,2L,8L,1L,4L,1L,9L,6L,5L,4L,4L,2L,3L,3L,2L,9L,7L,0L,6L,6L,6L,0L,1L,8L,0L,5L,4L,8L,6L,9L,5L,0L,8L,8L,1L,9L,3L,1L,8L,0L,4L,4L,3L,1L,2L,6L,2L,2L,9L,4L,3L,5L,2L,2L,4L,7L,1L,8L,1L,9L,8L,9L,4L,9L,6L,5L,0L,5L,5L,8L,6L,5L,4L,7L,8L,9L,6L,1L,4L,3L,1L,1L,2L,2L,5L,2L,9L,8L,6L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176016Inst : IEnumerable<long>
{
public static readonly long[] Value=A176016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176016.Bytes);
public long this[int i]=>Value[i];

public static A176016Inst Instance=new A176016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176017
{
public static readonly long[] Value={ 1L,1L,2L,6L,7L,8L,3L,1L,7L,0L,5L,2L,8L,0L,0L,8L,7L,1L,8L,6L,0L,0L,4L,5L,6L,3L,0L,7L,6L,7L,2L,5L,9L,3L,5L,4L,0L,0L,6L,2L,5L,6L,2L,6L,3L,0L,5L,3L,9L,6L,0L,7L,3L,9L,9L,3L,5L,1L,9L,7L,8L,2L,5L,9L,2L,7L,0L,1L,9L,7L,4L,7L,4L,7L,2L,9L,9L,5L,0L,4L,4L,8L,6L,9L,1L,1L,2L,0L,9L,3L,9L,7L,9L,0L,6L,2L,1L,8L,3L,9L,7L,0L,9L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176017Inst : IEnumerable<long>
{
public static readonly long[] Value=A176017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176017.Bytes);
public long this[int i]=>Value[i];

public static A176017Inst Instance=new A176017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176018
{
public static readonly BigInteger[] Value={ 165L,45760L,4545100L,280859635L,13177343466L,519435748656L,18247149400480L,592679189880470L,18233421432967455L,539997542625453900L,15568435368162197664UL,BigInteger.Parse("440371777466788015089"),BigInteger.Parse("12288775148056292092340"),BigInteger.Parse("339634237637121659008140") };
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
public class A176018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176018Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176018.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176018.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176018Inst Instance=new A176018Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176019
{
public static readonly long[] Value={ 1L,1L,0L,0L,9L,2L,5L,2L,1L,2L,5L,7L,7L,3L,3L,1L,5L,4L,8L,8L,5L,3L,2L,0L,3L,5L,4L,4L,5L,7L,8L,4L,1L,5L,9L,9L,1L,0L,4L,1L,8L,8L,2L,7L,6L,2L,3L,0L,7L,5L,4L,1L,0L,3L,5L,4L,5L,1L,7L,4L,2L,1L,7L,6L,0L,3L,7L,8L,6L,1L,1L,5L,8L,0L,4L,8L,8L,3L,5L,0L,7L,4L,2L,0L,0L,7L,6L,9L,8L,4L,7L,0L,0L,3L,0L,8L,1L,7L,8L,6L,2L,7L,8L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176019Inst : IEnumerable<long>
{
public static readonly long[] Value=A176019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176019.Bytes);
public long this[int i]=>Value[i];

public static A176019Inst Instance=new A176019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176020
{
public static readonly long[] Value={ 2L,2L,9L,0L,9L,9L,4L,4L,4L,8L,7L,3L,5L,8L,0L,5L,6L,2L,8L,3L,9L,3L,0L,8L,8L,4L,6L,6L,5L,9L,4L,1L,3L,3L,2L,0L,3L,6L,1L,0L,9L,7L,3L,9L,0L,1L,7L,6L,3L,8L,6L,3L,6L,0L,8L,8L,6L,2L,5L,2L,4L,5L,8L,8L,7L,0L,4L,4L,9L,4L,3L,6L,3L,9L,7L,8L,9L,9L,3L,0L,1L,1L,1L,7L,3L,0L,9L,5L,7L,9L,2L,2L,8L,6L,2L,2L,4L,5L,0L,5L,9L,7L,2L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176020Inst : IEnumerable<long>
{
public static readonly long[] Value=A176020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176020.Bytes);
public long this[int i]=>Value[i];

public static A176020Inst Instance=new A176020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176021
{
public static readonly long[] Value={ 1L,1L,1L,1L,-10L,1L,1L,72L,72L,1L,1L,-528L,-678L,-528L,1L,1L,4770L,6780L,6780L,4770L,1L,1L,-48025L,-87568L,-68458L,-87568L,-48025L,1L,1L,524384L,1287776L,947520L,947520L,1287776L,524384L,1L,1L,-6169282L,-19982590L,-18010942L,-10305790L,-18010942L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176021Inst : IEnumerable<long>
{
public static readonly long[] Value=A176021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176021.Bytes);
public long this[int i]=>Value[i];

public static A176021Inst Instance=new A176021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176022
{
public static readonly long[] Value={ -2L,3L,3L,-7L,-18L,-7L,25L,96L,96L,25L,-121L,-650L,-800L,-650L,-121L,721L,5490L,7500L,7500L,5490L,721L,-5041L,-53067L,-92610L,-73500L,-92610L,-53067L,-5041L,40321L,564704L,1328096L,987840L,987840L,1328096L,564704L,40321L,-362881L,-6532164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176022Inst : IEnumerable<long>
{
public static readonly long[] Value=A176022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176022.Bytes);
public long this[int i]=>Value[i];

public static A176022Inst Instance=new A176022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176023
{
public static readonly BigInteger[] Value={ 13L,169L,33124L,1109289636L,1230597389647535364L,BigInteger.Parse("1514369938137587812499677175361189636"),BigInteger.Parse("2293316309534841541915473293317407055631848366256764867236421660610435364") };
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
public class A176023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176023Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176023.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176023.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176023Inst Instance=new A176023Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176024
{
public static readonly long[] Value={ 82L,37765L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176024Inst : IEnumerable<long>
{
public static readonly long[] Value=A176024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176024.Bytes);
public long this[int i]=>Value[i];

public static A176024Inst Instance=new A176024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176025
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,49L,169L,603L,2205L,8217L,31095L,119185L,461790L,1805810L,7117865L,28250549L,112806534L,452862663L,1826705940L,7399893522L,30092189864L,122799412699L,502709227763L,2063939448400L,8496355807149L,35061664792175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176025Inst : IEnumerable<long>
{
public static readonly long[] Value=A176025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176025.Bytes);
public long this[int i]=>Value[i];

public static A176025Inst Instance=new A176025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176026
{
public static readonly long[] Value={ 18L,54L,51L,131L,87L,206L,95L,322L,150L,350L,139L,511L,190L,457L,255L,708L,219L,668L,237L,912L,339L,691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176026Inst : IEnumerable<long>
{
public static readonly long[] Value=A176026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176026.Bytes);
public long this[int i]=>Value[i];

public static A176026Inst Instance=new A176026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176027
{
public static readonly long[] Value={ 0L,3L,14L,48L,144L,400L,1056L,2688L,6656L,16128L,38400L,90112L,208896L,479232L,1089536L,2457600L,5505024L,12255232L,27131904L,59768832L,131072000L,286261248L,622854144L,1350565888L,2919235584L,6291456000L,13522436096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176027Inst : IEnumerable<long>
{
public static readonly long[] Value=A176027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176027.Bytes);
public long this[int i]=>Value[i];

public static A176027Inst Instance=new A176027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176028
{
public static readonly long[] Value={ 3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,5L,5L,5L,5L,5L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176028Inst : IEnumerable<long>
{
public static readonly long[] Value=A176028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176028.Bytes);
public long this[int i]=>Value[i];

public static A176028Inst Instance=new A176028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176029
{
public static readonly long[] Value={ 1L,2L,3L,16L,5L,36L,7L,512L,81L,100L,11L,1728L,13L,196L,225L,65536L,17L,5832L,19L,8000L,441L,484L,23L,331776L,625L,676L,19683L,21952L,29L,27000L,31L,33554432L,1089L,1156L,1225L,1679616L,37L,1444L,1521L,2560000L,41L,74088L,43L,85184L,91125L,2116L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176029Inst : IEnumerable<long>
{
public static readonly long[] Value=A176029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176029.Bytes);
public long this[int i]=>Value[i];

public static A176029Inst Instance=new A176029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176030
{
public static readonly BigInteger[] Value={ 1L,32L,59049L,4398046511104L,1490116119384765625L,BigInteger.Parse("808281277464764060643139600456536293376"),BigInteger.Parse("1798465042647412146620280340569649349251249") };
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
public class A176030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176030Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176030.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176030.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176030Inst Instance=new A176030Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176031
{
public static readonly BigInteger[] Value={ 1L,4L,27L,16L,3125L,46656L,823543L,64L,729L,10000000000L,285311670611L,2985984L,302875106592253L,11112006825558016L,437893890380859375L,256L,BigInteger.Parse("827240261886336764177"),34012224L,BigInteger.Parse("1978419655660313589123979") };
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
public class A176031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176031Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176031.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176031.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176031Inst Instance=new A176031Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176032
{
public static readonly long[] Value={ 1L,1L,3L,1L,3L,1L,7L,3L,5L,3L,1L,11L,3L,1L,9L,7L,5L,9L,11L,3L,1L,13L,15L,3L,13L,19L,15L,7L,3L,5L,11L,3L,9L,13L,15L,11L,1L,13L,21L,19L,7L,3L,17L,21L,27L,23L,1L,25L,27L,23L,15L,3L,1L,21L,31L,19L,7L,3L,9L,17L,21L,27L,1L,9L,13L,21L,23L,11L,9L,13L,21L,33L,27L,15L,3L,5L,17L,33L,39L,23L,3L,1L,21L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176032Inst : IEnumerable<long>
{
public static readonly long[] Value=A176032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176032.Bytes);
public long this[int i]=>Value[i];

public static A176032Inst Instance=new A176032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176033
{
public static readonly long[] Value={ 15L,85L,91L,435L,451L,703L,1247L,1271L,1581L,1695L,1891L,2071L,3133L,3367L,3683L,4795L,4859L,5551L,6643L,8695L,9061L,9131L,9211L,9605L,9919L,12403L,13019L,14351L,14701L,15051L,15211L,16021L,16471L,19669L,20191L,20485L,24727L,25351L,26335L,26599L,27511L,28645L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176033Inst : IEnumerable<long>
{
public static readonly long[] Value=A176033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176033.Bytes);
public long this[int i]=>Value[i];

public static A176033Inst Instance=new A176033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176034
{
public static readonly long[] Value={ 3L,6L,2L,1L,4L,3L,10L,3L,2L,1L,11L,10L,3L,13L,9L,7L,6L,2L,16L,12L,7L,4L,18L,15L,14L,13L,9L,7L,6L,5L,15L,10L,6L,3L,2L,22L,21L,15L,11L,10L,3L,2L,1L,24L,23L,14L,11L,10L,8L,3L,19L,18L,13L,11L,9L,2L,24L,23L,22L,20L,19L,16L,12L,11L,10L,8L,7L,6L,4L,30L,21L,19L,9L,7L,3L,2L,30L,27L,24L,22L,15L,11L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176034Inst : IEnumerable<long>
{
public static readonly long[] Value=A176034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176034.Bytes);
public long this[int i]=>Value[i];

public static A176034Inst Instance=new A176034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176035
{
public static readonly long[] Value={ 2L,1L,5L,6L,5L,6L,1L,8L,9L,10L,2L,3L,10L,2L,6L,8L,9L,13L,1L,5L,10L,13L,1L,4L,5L,6L,10L,12L,13L,14L,6L,11L,15L,18L,19L,1L,2L,8L,12L,13L,20L,21L,22L,1L,2L,11L,14L,15L,17L,22L,8L,9L,14L,16L,18L,25L,5L,6L,7L,9L,10L,13L,17L,18L,19L,21L,22L,23L,25L,1L,10L,12L,22L,24L,28L,29L,3L,6L,9L,11L,18L,22L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176035Inst : IEnumerable<long>
{
public static readonly long[] Value=A176035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176035.Bytes);
public long this[int i]=>Value[i];

public static A176035Inst Instance=new A176035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176036
{
public static readonly long[] Value={ 1L,5L,3L,5L,1L,3L,9L,5L,7L,9L,9L,7L,7L,11L,3L,1L,3L,11L,15L,7L,3L,9L,17L,11L,9L,7L,1L,5L,7L,9L,9L,1L,9L,15L,17L,21L,19L,7L,1L,3L,17L,19L,21L,23L,21L,3L,3L,5L,9L,19L,11L,9L,1L,5L,9L,23L,19L,17L,15L,11L,9L,3L,5L,7L,9L,13L,15L,17L,21L,29L,11L,7L,13L,17L,25L,27L,27L,21L,15L,11L,3L,11L,29L,31L,23L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176036Inst : IEnumerable<long>
{
public static readonly long[] Value=A176036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176036.Bytes);
public long this[int i]=>Value[i];

public static A176036Inst Instance=new A176036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176037
{
public static readonly BigInteger[] Value={ 2L,12L,288L,17280L,2073600L,435456000L,146313216000L,73741860864000L,53094139822080000L,BigInteger.Parse("52563198423859200000"),BigInteger.Parse("69383421919494144000000"),BigInteger.Parse("119061952013851951104000000"),BigInteger.Parse("260031303198252661211136000000") };
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
public class A176037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176037Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176037.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176037.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176037Inst Instance=new A176037Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176038
{
public static readonly BigInteger[] Value={ 2L,3L,11L,13L,2879L,86399L,BigInteger.Parse("114000816848279961600001"),BigInteger.Parse("2284848632399058501374484565150666260597460935294482959564800000000000001") };
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
public class A176038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176038Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176038.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176038.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176038Inst Instance=new A176038Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176039
{
public static readonly long[] Value={ 1L,2L,6L,9L,15L,20L,25L,28L,35L,42L,45L,49L,63L,66L,77L,88L,91L,99L,104L,110L,117L,121L,130L,143L,153L,156L,165L,169L,170L,187L,190L,195L,204L,209L,221L,228L,231L,238L,247L,255L,266L,272L,273L,276L,285L,289L,299L,304L,322L,323L,325L,342L,345L,350L,357L,361L,368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176039Inst : IEnumerable<long>
{
public static readonly long[] Value=A176039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176039.Bytes);
public long this[int i]=>Value[i];

public static A176039Inst Instance=new A176039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176040
{
public static readonly long[] Value={ 3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176040Inst : IEnumerable<long>
{
public static readonly long[] Value=A176040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176040.Bytes);
public long this[int i]=>Value[i];

public static A176040Inst Instance=new A176040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176041
{
public static readonly long[] Value={ 1L,1L,4L,1L,2L,3L,1L,1L,12L,7L,1L,4L,9L,9L,24L,1L,2L,10L,17L,9L,25L,1L,1L,1L,11L,7L,26L,11L,1L,4L,4L,6L,28L,30L,1L,7L,1L,2L,3L,5L,25L,9L,4L,28L,22L,1L,1L,12L,1L,13L,36L,16L,6L,27L,12L,1L,4L,9L,4L,23L,33L,21L,24L,47L,48L,9L,1L,2L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176041Inst : IEnumerable<long>
{
public static readonly long[] Value=A176041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176041.Bytes);
public long this[int i]=>Value[i];

public static A176041Inst Instance=new A176041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176042
{
public static readonly long[] Value={ 1L,1L,2L,5L,20L,42L,238L,511L,3311L,7423L,52273L,119739L,894950L,2087761L,16317275L,38616848L,312598141L,748492526L,6233339701L,15070028915L,128475055100L,313137867019L,2722580871465L,6681890398543L,59076953846060L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176042Inst : IEnumerable<long>
{
public static readonly long[] Value=A176042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176042.Bytes);
public long this[int i]=>Value[i];

public static A176042Inst Instance=new A176042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176043
{
public static readonly BigInteger[] Value={ 1L,1L,3L,20L,189L,2304L,34375L,606528L,12353145L,285212672L,7360989291L,210000000000L,6562168424053L,222902511206400L,8177627877990831L,322248197941182464L,13574710601806640625UL,BigInteger.Parse("608742554432415203328") };
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
public class A176043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176043Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176043.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176043.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176043Inst Instance=new A176043Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176044
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,1L,1L,2L,2L,3L,3L,4L,4L,4L,5L,5L,6L,6L,7L,7L,7L,8L,8L,9L,10L,10L,10L,10L,11L,12L,13L,13L,13L,14L,15L,15L,16L,16L,17L,17L,18L,19L,19L,19L,19L,21L,22L,22L,22L,23L,23L,24L,25L,25L,26L,26L,27L,27L,28L,28L,29L,30L,31L,31L,31L,33L,33L,34L,34L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176044Inst : IEnumerable<long>
{
public static readonly long[] Value=A176044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176044.Bytes);
public long this[int i]=>Value[i];

public static A176044Inst Instance=new A176044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176045
{
public static readonly long[] Value={ 3L,4L,6L,12L,24L,30L,42L,54L,84L,90L,114L,132L,174L,180L,192L,234L,240L,252L,282L,294L,360L,420L,432L,444L,492L,510L,594L,642L,654L,660L,684L,720L,744L,762L,810L,912L,954L,1014L,1020L,1032L,1050L,1104L,1224L,1230L,1290L,1410L,1440L,1452L,1482L,1500L,1512L,1560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176045Inst : IEnumerable<long>
{
public static readonly long[] Value=A176045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176045.Bytes);
public long this[int i]=>Value[i];

public static A176045Inst Instance=new A176045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176046
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,-1L,-1L,0L,1L,1L,-1L,-3L,-3L,-3L,-1L,1L,1L,-3L,-6L,-7L,-7L,-6L,-3L,1L,1L,-6L,-11L,-13L,-14L,-13L,-11L,-6L,1L,1L,-11L,-19L,-23L,-25L,-25L,-23L,-19L,-11L,1L,1L,-19L,-32L,-39L,-43L,-44L,-43L,-39L,-32L,-19L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176046Inst : IEnumerable<long>
{
public static readonly long[] Value=A176046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176046.Bytes);
public long this[int i]=>Value[i];

public static A176046Inst Instance=new A176046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176047
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,-1L,0L,1L,0L,-1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,1L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176047Inst : IEnumerable<long>
{
public static readonly long[] Value=A176047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176047.Bytes);
public long this[int i]=>Value[i];

public static A176047Inst Instance=new A176047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176048
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,1L,1L,1L,-1L,0L,1L,0L,1L,1L,0L,1L,0L,-1L,1L,1L,1L,0L,1L,1L,1L,2L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176048Inst : IEnumerable<long>
{
public static readonly long[] Value=A176048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176048.Bytes);
public long this[int i]=>Value[i];

public static A176048Inst Instance=new A176048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176049
{
public static readonly BigInteger[] Value={ 3L,11L,13L,2073601L,146313215999L,BigInteger.Parse("52563198423859200001"),BigInteger.Parse("709885457731229765106401279999999"),BigInteger.Parse("15120395453651827088974983182763034097693491200000000001") };
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
public class A176049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176049Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176049.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176049.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176049Inst Instance=new A176049Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176050
{
public static readonly BigInteger[] Value={ 0L,4L,0L,256L,0L,46656L,0L,16777216L,0L,10000000000L,0L,8916100448256L,0L,11112006825558016L,0L,BigInteger.Parse("18446744073709551616"),0L,BigInteger.Parse("39346408075296537575424"),0L,BigInteger.Parse("104857600000000000000000000"),0L,BigInteger.Parse("341427877364219557396646723584"),0L };
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
public class A176050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176050Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176050.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176050.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176050Inst Instance=new A176050Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176051
{
public static readonly long[] Value={ 2L,2L,2L,4L,7L,4L,4L,8L,7L,1L,3L,9L,1L,5L,8L,9L,0L,4L,9L,0L,9L,8L,6L,4L,2L,0L,3L,7L,3L,5L,2L,9L,4L,5L,6L,9L,5L,9L,8L,2L,9L,7L,3L,7L,4L,0L,3L,2L,8L,3L,3L,5L,0L,6L,4L,2L,1L,6L,3L,4L,6L,2L,8L,3L,6L,2L,5L,4L,8L,0L,1L,8L,8L,7L,2L,8L,6L,5L,7L,5L,1L,3L,2L,6L,9L,9L,2L,9L,7L,1L,6L,5L,5L,2L,3L,2L,0L,1L,1L,7L,4L,0L,9L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176051Inst : IEnumerable<long>
{
public static readonly long[] Value=A176051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176051.Bytes);
public long this[int i]=>Value[i];

public static A176051Inst Instance=new A176051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176052
{
public static readonly long[] Value={ 2L,1L,8L,3L,2L,1L,5L,9L,5L,6L,6L,1L,9L,9L,2L,3L,2L,0L,8L,5L,1L,3L,4L,6L,5L,6L,5L,8L,3L,1L,2L,3L,2L,3L,4L,0L,9L,6L,8L,3L,1L,0L,0L,2L,4L,6L,1L,5L,8L,8L,6L,8L,0L,6L,4L,5L,7L,5L,9L,4L,3L,9L,3L,3L,8L,2L,8L,5L,6L,4L,4L,9L,1L,8L,2L,1L,1L,3L,0L,6L,0L,7L,3L,5L,3L,1L,5L,0L,5L,0L,5L,4L,3L,6L,6L,2L,1L,8L,3L,5L,6L,1L,7L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176052Inst : IEnumerable<long>
{
public static readonly long[] Value=A176052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176052.Bytes);
public long this[int i]=>Value[i];

public static A176052Inst Instance=new A176052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176053
{
public static readonly long[] Value={ 2L,1L,5L,4L,7L,0L,0L,5L,3L,8L,3L,7L,9L,2L,5L,1L,5L,2L,9L,0L,1L,8L,2L,9L,7L,5L,6L,1L,0L,0L,3L,9L,1L,4L,9L,1L,1L,2L,9L,5L,2L,0L,3L,5L,0L,2L,5L,4L,0L,2L,5L,3L,7L,5L,2L,0L,3L,7L,2L,0L,4L,6L,5L,2L,9L,6L,7L,9L,5L,5L,3L,4L,4L,6L,0L,5L,8L,6L,6L,6L,9L,1L,3L,8L,7L,4L,3L,0L,7L,9L,1L,1L,7L,1L,4L,9L,9L,0L,5L,0L,4L,5L,0L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176053Inst : IEnumerable<long>
{
public static readonly long[] Value=A176053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176053.Bytes);
public long this[int i]=>Value[i];

public static A176053Inst Instance=new A176053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176054
{
public static readonly long[] Value={ 2L,1L,3L,3L,8L,9L,3L,4L,1L,9L,0L,2L,7L,6L,8L,1L,6L,8L,1L,6L,4L,3L,5L,4L,9L,6L,0L,8L,7L,0L,2L,5L,4L,0L,1L,8L,2L,4L,4L,7L,2L,5L,3L,9L,3L,5L,6L,0L,6L,7L,6L,4L,3L,6L,3L,0L,1L,5L,0L,0L,0L,4L,8L,2L,5L,1L,4L,7L,4L,3L,7L,8L,1L,3L,8L,4L,4L,0L,7L,2L,6L,9L,0L,4L,0L,1L,6L,8L,3L,7L,9L,9L,1L,7L,6L,6L,1L,5L,4L,7L,4L,0L,6L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176054Inst : IEnumerable<long>
{
public static readonly long[] Value=A176054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176054.Bytes);
public long this[int i]=>Value[i];

public static A176054Inst Instance=new A176054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176055
{
public static readonly long[] Value={ 2L,1L,1L,8L,0L,3L,3L,9L,8L,8L,7L,4L,9L,8L,9L,4L,8L,4L,8L,2L,0L,4L,5L,8L,6L,8L,3L,4L,3L,6L,5L,6L,3L,8L,1L,1L,7L,7L,2L,0L,3L,0L,9L,1L,7L,9L,8L,0L,5L,7L,6L,2L,8L,6L,2L,1L,3L,5L,4L,4L,8L,6L,2L,2L,7L,0L,5L,2L,6L,0L,4L,6L,2L,8L,1L,8L,9L,0L,2L,4L,4L,9L,7L,0L,7L,2L,0L,7L,2L,0L,4L,1L,8L,9L,3L,9L,1L,1L,3L,7L,4L,8L,4L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176055Inst : IEnumerable<long>
{
public static readonly long[] Value=A176055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176055.Bytes);
public long this[int i]=>Value[i];

public static A176055Inst Instance=new A176055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176056
{
public static readonly long[] Value={ 2L,1L,0L,5L,5L,4L,1L,5L,9L,6L,7L,8L,5L,1L,3L,3L,2L,8L,3L,0L,3L,8L,3L,1L,0L,9L,1L,2L,2L,2L,3L,5L,6L,2L,2L,2L,7L,9L,7L,5L,6L,9L,6L,1L,8L,1L,8L,6L,3L,1L,1L,7L,8L,6L,5L,6L,8L,6L,2L,2L,7L,3L,8L,2L,0L,3L,8L,8L,2L,8L,2L,1L,4L,2L,0L,3L,0L,1L,4L,6L,1L,5L,5L,6L,9L,6L,1L,4L,4L,6L,6L,3L,7L,6L,0L,9L,6L,8L,8L,3L,6L,3L,5L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176056Inst : IEnumerable<long>
{
public static readonly long[] Value=A176056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176056.Bytes);
public long this[int i]=>Value[i];

public static A176056Inst Instance=new A176056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176057
{
public static readonly long[] Value={ 2L,0L,9L,5L,4L,4L,5L,1L,1L,5L,0L,1L,0L,3L,3L,2L,2L,2L,6L,9L,1L,3L,9L,3L,9L,5L,6L,5L,6L,0L,1L,6L,0L,4L,2L,6L,7L,9L,0L,5L,4L,8L,9L,3L,8L,9L,9L,9L,5L,9L,6L,6L,5L,0L,8L,4L,5L,3L,7L,8L,8L,8L,9L,9L,4L,6L,4L,9L,8L,6L,5L,5L,4L,2L,4L,5L,4L,4L,5L,4L,6L,7L,6L,0L,1L,7L,1L,6L,8L,7L,2L,3L,2L,7L,7L,4L,1L,2L,5L,1L,5L,2L,9L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176057Inst : IEnumerable<long>
{
public static readonly long[] Value=A176057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176057.Bytes);
public long this[int i]=>Value[i];

public static A176057Inst Instance=new A176057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176058
{
public static readonly long[] Value={ 3L,4L,3L,6L,4L,9L,1L,6L,7L,3L,1L,0L,3L,7L,0L,8L,4L,4L,2L,5L,8L,9L,6L,3L,2L,6L,9L,9L,8L,9L,1L,1L,9L,9L,8L,0L,5L,4L,1L,6L,4L,6L,0L,8L,5L,2L,6L,4L,5L,7L,9L,5L,4L,1L,3L,2L,9L,3L,7L,8L,6L,8L,8L,3L,0L,5L,6L,7L,4L,1L,5L,4L,5L,9L,6L,8L,4L,8L,9L,5L,1L,6L,7L,5L,9L,6L,4L,3L,6L,8L,8L,4L,2L,9L,3L,3L,6L,7L,5L,8L,9L,5L,8L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176058Inst : IEnumerable<long>
{
public static readonly long[] Value=A176058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176058.Bytes);
public long this[int i]=>Value[i];

public static A176058Inst Instance=new A176058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176059
{
public static readonly long[] Value={ 3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176059Inst : IEnumerable<long>
{
public static readonly long[] Value=A176059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176059.Bytes);
public long this[int i]=>Value[i];

public static A176059Inst Instance=new A176059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176060
{
public static readonly long[] Value={ 0L,2L,13L,46L,120L,260L,497L,868L,1416L,2190L,3245L,4642L,6448L,8736L,11585L,15080L,19312L,24378L,30381L,37430L,45640L,55132L,66033L,78476L,92600L,108550L,126477L,146538L,168896L,193720L,221185L,251472L,284768L,321266L,361165L,404670L,451992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176060Inst : IEnumerable<long>
{
public static readonly long[] Value=A176060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176060.Bytes);
public long this[int i]=>Value[i];

public static A176060Inst Instance=new A176060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176061
{
public static readonly long[] Value={ 0L,2L,5L,8L,9L,12L,14L,16L,32L,36L,42L,43L,62L,69L,72L,76L,95L,98L,102L,166L,179L,290L,324L,332L,393L,457L,569L,661L,788L,816L,904L,952L,986L,1004L,1036L,1064L,1091L,1279L,1307L,1491L,1496L,1521L,1597L,1740L,1760L,1856L,2104L,2196L,2402L,2699L,2943L,2999L,3095L,3509L,3584L,3890L,3927L,4074L,4454L,5162L,5635L,5860L,6288L,6478L,6675L,6911L,7455L,7806L,10409L,10735L,11719L,12312L,14789L,15171L,18031L,18764L,23033L,23461L,26192L,31490L,32259L,37641L,41899L,53582L,57425L,59724L,63535L,87393L,95326L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176061Inst : IEnumerable<long>
{
public static readonly long[] Value=A176061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176061.Bytes);
public long this[int i]=>Value[i];

public static A176061Inst Instance=new A176061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176062
{
public static readonly long[] Value={ 9L,12L,16L,32L,290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176062Inst : IEnumerable<long>
{
public static readonly long[] Value=A176062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176062.Bytes);
public long this[int i]=>Value[i];

public static A176062Inst Instance=new A176062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176063
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,1L,21L,21L,1L,1L,88L,120L,88L,1L,1L,505L,680L,680L,505L,1L,1L,3636L,5130L,4080L,5130L,3636L,1L,1L,30289L,48762L,31710L,31710L,48762L,30289L,1L,1L,282304L,525728L,354816L,194880L,354816L,525728L,282304L,1L,1L,2903121L,6171552L,4759776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176063Inst : IEnumerable<long>
{
public static readonly long[] Value=A176063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176063.Bytes);
public long this[int i]=>Value[i];

public static A176063Inst Instance=new A176063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176064
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,-18L,-18L,1L,1L,-26L,-122L,-26L,1L,1L,90L,-190L,-190L,90L,1L,1L,58L,298L,58L,298L,58L,1L,1L,-1806L,-1470L,3234L,3234L,-1470L,-1806L,1L,1L,-1934L,-18958L,-1934L,24946L,-1934L,-18958L,-1934L,1L,1L,29730L,-9726L,-81150L,47874L,47874L,-81150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176064Inst : IEnumerable<long>
{
public static readonly long[] Value=A176064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176064.Bytes);
public long this[int i]=>Value[i];

public static A176064Inst Instance=new A176064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176065
{
public static readonly long[] Value={ 1L,3L,6L,7L,9L,11L,15L,17L,19L,24L,28L,31L,36L,37L,43L,44L,46L,53L,56L,59L,63L,69L,77L,81L,83L,85L,92L,99L,101L,109L,112L,114L,119L,122L,127L,129L,136L,139L,144L,148L,151L,152L,154L,156L,157L,170L,175L,177L,179L,180L,184L,193L,196L,197L,203L,205L,213L,219L,224L,227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176065Inst : IEnumerable<long>
{
public static readonly long[] Value=A176065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176065.Bytes);
public long this[int i]=>Value[i];

public static A176065Inst Instance=new A176065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176066
{
public static readonly long[] Value={ 1L,4L,2L,0L,3L,0L,4L,0L,4L,3L,0L,1L,5L,4L,0L,1L,0L,1L,10L,6L,5L,2L,1L,2L,0L,7L,6L,0L,0L,4L,5L,3L,10L,9L,3L,2L,1L,5L,6L,4L,11L,10L,4L,3L,0L,3L,5L,3L,0L,3L,1L,11L,10L,7L,6L,4L,6L,4L,1L,4L,2L,12L,11L,8L,7L,0L,0L,0L,5L,2L,5L,3L,13L,12L,9L,8L,1L,0L,3L,3L,8L,5L,8L,6L,16L,15L,12L,11L,4L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176066Inst : IEnumerable<long>
{
public static readonly long[] Value=A176066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176066.Bytes);
public long this[int i]=>Value[i];

public static A176066Inst Instance=new A176066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176067
{
public static readonly BigInteger[] Value={ 1L,0L,10L,1010L,101010L,10101010L,1010101010L,101010101010L,10101010101010L,1010101010101010L,101010101010101010L,10101010101010101010UL,BigInteger.Parse("1010101010101010101010"),BigInteger.Parse("101010101010101010101010") };
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
public class A176067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176067Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176067.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176067.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176067Inst Instance=new A176067Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176068
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,27L,152L,2163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176068Inst : IEnumerable<long>
{
public static readonly long[] Value=A176068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176068.Bytes);
public long this[int i]=>Value[i];

public static A176068Inst Instance=new A176068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176069
{
public static readonly long[] Value={ 21L,57L,91L,111L,133L,183L,381L,553L,703L,813L,871L,993L,1057L,1191L,1261L,1333L,1561L,1641L,1807L,1893L,1981L,2071L,2257L,2353L,2653L,2757L,2863L,3193L,3661L,4033L,4291L,4971L,5257L,5403L,5853L,6807L,6973L,7141L,7311L,7483L,8373L,8557L,8743L,9121L,9313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176069Inst : IEnumerable<long>
{
public static readonly long[] Value=A176069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176069.Bytes);
public long this[int i]=>Value[i];

public static A176069Inst Instance=new A176069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176070
{
public static readonly long[] Value={ 15L,85L,259L,1111L,4369L,47989L,65641L,291919L,2016379L,2214031L,3397651L,3820909L,5864581L,9305311L,13881841L,15687751L,16843009L,19756171L,22030681L,28746559L,62256349L,64160401L,74264821L,79692331L,101412319L,117889591L,172189309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176070Inst : IEnumerable<long>
{
public static readonly long[] Value=A176070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176070.Bytes);
public long this[int i]=>Value[i];

public static A176070Inst Instance=new A176070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176071
{
public static readonly BigInteger[] Value={ 21L,38L,265L,4109L,65553L,262163L,1048597L,67108891L,274877906983L,4503599627370549L,BigInteger.Parse("73786976294838206531"),BigInteger.Parse("75557863725914323419213"),BigInteger.Parse("302231454903657293676623"),BigInteger.Parse("5192296858534827628530496329220209") };
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
public class A176071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176071Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176071.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176071.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176071Inst Instance=new A176071Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176072
{
public static readonly long[] Value={ 7L,281L,1602529L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176072Inst : IEnumerable<long>
{
public static readonly long[] Value=A176072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176072.Bytes);
public long this[int i]=>Value[i];

public static A176072Inst Instance=new A176072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176073
{
public static readonly BigInteger[] Value={ 39L,2323L,6826L,179207L,14381691L,129271253L,617675543767627L,5559069156490149L,450284043329950873L,BigInteger.Parse("174449211045148976090134531"),BigInteger.Parse("5474401089420370497804607762216590113") };
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
public class A176073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176073Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176073.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176073.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176073Inst Instance=new A176073Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176074
{
public static readonly long[] Value={ 1L,1L,2L,3L,7L,17L,51L,163L,561L,2004L,7391L,27873L,107050L,417152L,1645339L,6555752L,26348334L,106691779L,434851380L,1782551286L,7344326285L,30397197514L,126324028956L,526911437207L,2205163133586L,9256931835831L,38967696710845L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176074Inst : IEnumerable<long>
{
public static readonly long[] Value=A176074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176074.Bytes);
public long this[int i]=>Value[i];

public static A176074Inst Instance=new A176074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176075
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,4L,3L,4L,4L,4L,4L,5L,5L,5L,6L,5L,6L,7L,6L,7L,8L,7L,8L,9L,7L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,10L,10L,10L,10L,11L,10L,11L,10L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,12L,12L,12L,12L,12L,13L,12L,13L,12L,13L,14L,13L,14L,13L,14L,15L,13L,14L,15L,13L,14L,15L,14L,15L,14L,15L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176075Inst : IEnumerable<long>
{
public static readonly long[] Value=A176075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176075.Bytes);
public long this[int i]=>Value[i];

public static A176075Inst Instance=new A176075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176076
{
public static readonly long[] Value={ 0L,1L,2L,0L,1L,1L,3L,1L,5L,7L,0L,1L,2L,13L,1L,1L,3L,17L,2L,2L,5L,21L,4L,23L,3L,2L,5L,0L,1L,1L,3L,1L,5L,31L,0L,1L,2L,37L,1L,1L,3L,41L,2L,2L,5L,45L,4L,47L,3L,2L,5L,0L,1L,1L,3L,1L,5L,55L,0L,1L,2L,61L,1L,1L,3L,65L,2L,2L,5L,69L,4L,2L,7L,72L,0L,1L,2L,1L,4L,1L,6L,78L,80L,6L,2L,79L,84L,11L,3L,82L,70L,0L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176076Inst : IEnumerable<long>
{
public static readonly long[] Value=A176076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176076.Bytes);
public long this[int i]=>Value[i];

public static A176076Inst Instance=new A176076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176077
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,8L,6L,15L,14L,14L,10L,61L,12L,25L,33L,142L,16L,203L,18L,266L,94L,127L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176077Inst : IEnumerable<long>
{
public static readonly long[] Value=A176077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176077.Bytes);
public long this[int i]=>Value[i];

public static A176077Inst Instance=new A176077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176078
{
public static readonly long[] Value={ 1L,1L,1L,1L,19L,1L,1L,161L,161L,1L,1L,1051L,2451L,1051L,1L,1L,6049L,24949L,24949L,6049L,1L,1L,32341L,206977L,368677L,206977L,32341L,1L,1L,164737L,1510081L,4200769L,4200769L,1510081L,164737L,1L,1L,810811L,10077211L,40347451L,63050131L,40347451L,10077211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176078Inst : IEnumerable<long>
{
public static readonly long[] Value=A176078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176078.Bytes);
public long this[int i]=>Value[i];

public static A176078Inst Instance=new A176078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176079
{
public static readonly long[] Value={ 0L,0L,1L,0L,-1L,2L,0L,1L,-1L,3L,0L,-1L,-1L,-1L,4L,0L,1L,2L,-1L,-1L,5L,0L,-1L,-1L,-1L,-1L,-1L,6L,0L,1L,-1L,3L,-1L,-1L,-1L,7L,0L,-1L,2L,-1L,-1L,-1L,-1L,-1L,8L,0L,1L,-1L,-1L,4L,-1L,-1L,-1L,-1L,9L,0L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,10L,0L,1L,2L,3L,-1L,5L,-1L,-1L,-1L,-1L,-1L,11L,0L,-1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176079Inst : IEnumerable<long>
{
public static readonly long[] Value=A176079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176079.Bytes);
public long this[int i]=>Value[i];

public static A176079Inst Instance=new A176079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176080
{
public static readonly long[] Value={ 1L,1L,4L,1L,9L,42L,1L,16L,130L,680L,1L,25L,315L,2555L,14630L,1L,36L,651L,7616L,63126L,389592L,1L,49L,1204L,19236L,219450L,1871562L,12314148L,1L,64L,2052L,42960L,647130L,7346592L,64578228L,449324304L,1L,81L,3285L,87285L,1679535L,24557247L,280146867L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176080Inst : IEnumerable<long>
{
public static readonly long[] Value=A176080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176080.Bytes);
public long this[int i]=>Value[i];

public static A176080Inst Instance=new A176080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176081
{
public static readonly long[] Value={ 2L,5L,5L,43L,18L,43L,681L,146L,146L,681L,14631L,2580L,630L,2580L,14631L,389593L,63162L,8267L,8267L,63162L,389593L,12314149L,1871611L,220654L,38472L,220654L,1871611L,12314149L,449324305L,64578292L,7348644L,690090L,690090L,7348644L,64578292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176081Inst : IEnumerable<long>
{
public static readonly long[] Value=A176081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176081.Bytes);
public long this[int i]=>Value[i];

public static A176081Inst Instance=new A176081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176082
{
public static readonly long[] Value={ 1L,1L,1L,1L,-24L,1L,1L,-534L,-534L,1L,1L,-12050L,-14000L,-12050L,1L,1L,-326430L,-381325L,-381325L,-326430L,1L,1L,-10442537L,-12093494L,-12275676L,-12093494L,-10442537L,1L,1L,-384746012L,-441975660L,-448634214L,-448634214L,-441975660L,-384746012L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176082Inst : IEnumerable<long>
{
public static readonly long[] Value=A176082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176082.Bytes);
public long this[int i]=>Value[i];

public static A176082Inst Instance=new A176082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176083
{
public static readonly long[] Value={ 1L,4L,3L,7L,24L,25L,11L,7L,22L,12L,9L,1L,5L,69L,1L,62L,41L,16L,133L,89L,39L,3L,162L,66L,121L,12L,4L,109L,163L,85L,135L,52L,251L,8L,14L,6L,154L,126L,167L,284L,149L,158L,254L,110L,318L,23L,75L,23L,59L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176083Inst : IEnumerable<long>
{
public static readonly long[] Value=A176083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176083.Bytes);
public long this[int i]=>Value[i];

public static A176083Inst Instance=new A176083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176084
{
public static readonly long[] Value={ 1L,2L,4L,9L,22L,58L,160L,454L,1311L,3828L,11260L,33290L,98778L,293866L,875960L,2614891L,7814544L,23373354L,69955372L,209478678L,627521578L,1880400340L,5636065932L,16895989570L,50658893073L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176084Inst : IEnumerable<long>
{
public static readonly long[] Value=A176084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176084.Bytes);
public long this[int i]=>Value[i];

public static A176084Inst Instance=new A176084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176085
{
public static readonly long[] Value={ 0L,1L,3L,11L,41L,155L,591L,2267L,8735L,33775L,130965L,509015L,1982269L,7732659L,30208749L,118167055L,462760369L,1814091011L,7118044023L,27952660883L,109853552255L,432021606103L,1700093447847L,6694137523051L,26372544576331L,103950885100775L,409928481296331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176085Inst : IEnumerable<long>
{
public static readonly long[] Value=A176085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176085.Bytes);
public long this[int i]=>Value[i];

public static A176085Inst Instance=new A176085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176086
{
public static readonly long[] Value={ 1L,5L,17L,53L,161L,485L,1433L,4229L,12425L,36485L,106673L,311957L,909953L,2654501L,7728401L,22503053L,65425505L,190239989L,552507641L,1604779373L,4656679889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176086Inst : IEnumerable<long>
{
public static readonly long[] Value=A176086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176086.Bytes);
public long this[int i]=>Value[i];

public static A176086Inst Instance=new A176086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176087
{
public static readonly long[] Value={ 1L,253L,35473L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176087Inst : IEnumerable<long>
{
public static readonly long[] Value=A176087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176087.Bytes);
public long this[int i]=>Value[i];

public static A176087Inst Instance=new A176087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176088
{
public static readonly long[] Value={ 1L,2L,1L,12L,1L,1L,112L,2L,1L,1L,1112L,11L,1L,1L,1L,11112L,102L,2L,1L,1L,1L,111112L,1011L,11L,1L,1L,1L,1L,1111112L,10102L,101L,2L,1L,1L,1L,1L,11111112L,101011L,1002L,11L,1L,1L,1L,1L,1L,111111112L,1010102L,10011L,101L,2L,1L,1L,1L,1L,1L,1111111112L,10101011L,100101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176088Inst : IEnumerable<long>
{
public static readonly long[] Value=A176088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176088.Bytes);
public long this[int i]=>Value[i];

public static A176088Inst Instance=new A176088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176089
{
public static readonly long[] Value={ 1L,547L,1187L,11183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176089Inst : IEnumerable<long>
{
public static readonly long[] Value=A176089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176089.Bytes);
public long this[int i]=>Value[i];

public static A176089Inst Instance=new A176089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176090
{
public static readonly long[] Value={ 1L,7L,41L,2429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176090Inst : IEnumerable<long>
{
public static readonly long[] Value=A176090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176090.Bytes);
public long this[int i]=>Value[i];

public static A176090Inst Instance=new A176090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176091
{
public static readonly long[] Value={ 307L,1759L,2963L,3881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176091Inst : IEnumerable<long>
{
public static readonly long[] Value=A176091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176091.Bytes);
public long this[int i]=>Value[i];

public static A176091Inst Instance=new A176091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176092
{
public static readonly long[] Value={ 1L,1L,0L,1L,-3L,-6L,1L,-8L,10L,80L,1L,-15L,75L,35L,-1050L,1L,-24L,231L,-784L,-2394L,14112L,1L,-35L,532L,-3948L,7770L,69762L,-170940L,1L,-48L,1044L,-12480L,74250L,-26928L,-1872156L,700128L,1L,-63L,1845L,-31515L,317295L,-1491633L,-2663661L,50456835L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176092Inst : IEnumerable<long>
{
public static readonly long[] Value=A176092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176092.Bytes);
public long this[int i]=>Value[i];

public static A176092Inst Instance=new A176092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176093
{
public static readonly long[] Value={ 2L,1L,1L,-5L,-6L,-5L,81L,2L,2L,81L,-1049L,20L,150L,20L,-1049L,14113L,-2418L,-553L,-553L,-2418L,14113L,-170939L,69727L,8302L,-7896L,8302L,69727L,-170939L,700129L,-1872204L,-25884L,61770L,61770L,-25884L,-1872204L,700129L,79909831L,50456772L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176093Inst : IEnumerable<long>
{
public static readonly long[] Value=A176093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176093.Bytes);
public long this[int i]=>Value[i];

public static A176093Inst Instance=new A176093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176094
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,-78L,-78L,1L,1L,1070L,1200L,1070L,1L,1L,-16530L,-14665L,-14665L,-16530L,1L,1L,240667L,179242L,163044L,179242L,240667L,1L,1L,-2572332L,-726012L,-638358L,-638358L,-726012L,-2572332L,1L,1L,-29453058L,-82571646L,-81432978L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176094Inst : IEnumerable<long>
{
public static readonly long[] Value=A176094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176094.Bytes);
public long this[int i]=>Value[i];

public static A176094Inst Instance=new A176094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176095
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,2L,1L,0L,3L,2L,1L,4L,1L,2L,7L,0L,1L,6L,1L,4L,9L,2L,1L,8L,5L,2L,9L,4L,1L,14L,1L,0L,13L,2L,11L,12L,1L,2L,15L,8L,1L,18L,1L,4L,21L,2L,1L,16L,7L,10L,19L,4L,1L,18L,15L,8L,21L,2L,1L,28L,1L,2L,27L,0L,17L,26L,1L,4L,25L,22L,1L,24L,1L,2L,35L,4L,17L,30L,1L,16L,27L,2L,1L,36L,21L,2L,31L,8L,1L,42L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176095Inst : IEnumerable<long>
{
public static readonly long[] Value=A176095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176095.Bytes);
public long this[int i]=>Value[i];

public static A176095Inst Instance=new A176095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176096
{
public static readonly BigInteger[] Value={ 13L,13313L,1313813L,131313113L,13131313133L,1131313131313L,131313131313139L,13131313131313913L,1313131311313131313L,BigInteger.Parse("113131313131313131313"),BigInteger.Parse("13131313131313133131313"),BigInteger.Parse("1313131131313131313131313") };
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
public class A176096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176096Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176096.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A176096.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176096Inst Instance=new A176096Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176097
{
public static readonly long[] Value={ 1L,4L,36L,272L,2150L,16992L,134848L,1072192L,8536914L,68036600L,542607560L,4329671040L,34561892560L,275979195520L,2204266118400L,17609217372416L,140698273234634L,1124340854572296L,8985828520591912L,71822662173752800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176097Inst : IEnumerable<long>
{
public static readonly long[] Value=A176097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176097.Bytes);
public long this[int i]=>Value[i];

public static A176097Inst Instance=new A176097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176098
{
public static readonly long[] Value={ 0L,3L,10L,21L,55L,91L,187L,247L,391L,551L,713L,1073L,1271L,1591L,1927L,2279L,2773L,3233L,3953L,4331L,4891L,5609L,6059L,7031L,8051L,8989L,9991L,10807L,11227L,12091L,13843L,14803L,17399L,18209L,20413L,20989L,23393L,24613L,26219L,28199L,29893L,31313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176098Inst : IEnumerable<long>
{
public static readonly long[] Value=A176098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176098.Bytes);
public long this[int i]=>Value[i];

public static A176098Inst Instance=new A176098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176099
{
public static readonly long[] Value={ 2L,4L,7L,10L,16L,20L,28L,32L,40L,48L,54L,66L,72L,80L,88L,96L,106L,114L,126L,132L,140L,150L,156L,168L,180L,190L,200L,208L,212L,220L,236L,244L,264L,270L,286L,290L,306L,314L,324L,336L,346L,354L,370L,374L,388L,392L,408L,422L,438L,452L,460L,468L,474L,490L,498L,514L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176099Inst : IEnumerable<long>
{
public static readonly long[] Value=A176099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176099.Bytes);
public long this[int i]=>Value[i];

public static A176099Inst Instance=new A176099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176100
{
public static readonly long[] Value={ 0L,2L,8L,12L,16L,18L,20L,24L,28L,30L,32L,36L,40L,42L,44L,48L,50L,52L,54L,56L,60L,64L,66L,68L,70L,72L,76L,78L,80L,84L,88L,90L,92L,96L,98L,100L,102L,104L,108L,110L,112L,114L,116L,120L,124L,126L,128L,130L,132L,136L,138L,140L,144L,148L,150L,152L,154L,156L,160L,162L,164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176100Inst : IEnumerable<long>
{
public static readonly long[] Value=A176100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176100.Bytes);
public long this[int i]=>Value[i];

public static A176100Inst Instance=new A176100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176101
{
public static readonly long[] Value={ 1L,4L,4L,4L,0L,16L,16L,16L,16L,16L,21L,10L,1L,16L,4L,0L,31L,18L,16L,4L,16L,1L,24L,16L,36L,34L,18L,16L,46L,4L,16L,16L,28L,26L,16L,7L,54L,4L,16L,16L,0L,16L,64L,64L,58L,4L,16L,70L,49L,64L,9L,22L,64L,55L,64L,16L,1L,44L,25L,56L,64L,74L,48L,70L,74L,49L,64L,44L,1L,4L,52L,48L,79L,36L,88L,56L,58L,64L,112L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176101Inst : IEnumerable<long>
{
public static readonly long[] Value=A176101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176101.Bytes);
public long this[int i]=>Value[i];

public static A176101Inst Instance=new A176101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176102
{
public static readonly long[] Value={ 3L,2L,3L,2L,0L,5L,0L,8L,0L,7L,5L,6L,8L,8L,7L,7L,2L,9L,3L,5L,2L,7L,4L,4L,6L,3L,4L,1L,5L,0L,5L,8L,7L,2L,3L,6L,6L,9L,4L,2L,8L,0L,5L,2L,5L,3L,8L,1L,0L,3L,8L,0L,6L,2L,8L,0L,5L,5L,8L,0L,6L,9L,7L,9L,4L,5L,1L,9L,3L,3L,0L,1L,6L,9L,0L,8L,8L,0L,0L,0L,3L,7L,0L,8L,1L,1L,4L,6L,1L,8L,6L,7L,5L,7L,2L,4L,8L,5L,7L,5L,6L,7L,5L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176102Inst : IEnumerable<long>
{
public static readonly long[] Value=A176102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176102.Bytes);
public long this[int i]=>Value[i];

public static A176102Inst Instance=new A176102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176103
{
public static readonly long[] Value={ 3L,1L,8L,8L,1L,9L,4L,3L,0L,1L,6L,1L,3L,4L,1L,3L,2L,1L,8L,3L,1L,1L,6L,8L,8L,9L,4L,0L,9L,5L,2L,2L,1L,0L,9L,9L,8L,8L,8L,4L,8L,4L,7L,7L,1L,5L,7L,6L,2L,4L,8L,5L,3L,9L,5L,2L,6L,4L,9L,8L,0L,3L,7L,2L,7L,9L,3L,2L,5L,9L,6L,1L,5L,0L,2L,9L,7L,8L,0L,8L,2L,2L,6L,5L,6L,4L,2L,5L,6L,9L,7L,4L,3L,9L,0L,3L,5L,8L,8L,4L,0L,7L,3L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176103Inst : IEnumerable<long>
{
public static readonly long[] Value=A176103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176103.Bytes);
public long this[int i]=>Value[i];

public static A176103Inst Instance=new A176103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176104
{
public static readonly long[] Value={ 1L,6L,8L,8L,1L,9L,4L,3L,0L,1L,6L,1L,3L,4L,1L,3L,2L,1L,8L,3L,1L,1L,6L,8L,8L,9L,4L,0L,9L,5L,2L,2L,1L,0L,9L,9L,8L,8L,8L,4L,8L,4L,7L,7L,1L,5L,7L,6L,2L,4L,8L,5L,3L,9L,5L,2L,6L,4L,9L,8L,0L,3L,7L,2L,7L,9L,3L,2L,5L,9L,6L,1L,5L,0L,2L,9L,7L,8L,0L,8L,2L,2L,6L,5L,6L,4L,2L,5L,6L,9L,7L,4L,3L,9L,0L,3L,5L,8L,8L,4L,0L,7L,3L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176104Inst : IEnumerable<long>
{
public static readonly long[] Value=A176104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176104.Bytes);
public long this[int i]=>Value[i];

public static A176104Inst Instance=new A176104Inst();

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