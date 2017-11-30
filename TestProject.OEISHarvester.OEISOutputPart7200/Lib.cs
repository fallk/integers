using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A184235
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,15L,31L,119L,555L,2138L,9548L,33391L,136682L,468971L,1753525L,5789709L,19745186L,63565260L,203046061L,638284176L,1947963410L,5979604119L,17725544038L,53252284414L,155128241215L,456635560332L,1314718658955L,3796821176997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184235Inst : IEnumerable<long>
{
public static readonly long[] Value=A184235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184235.Bytes);
public long this[int i]=>Value[i];

public static A184235Inst Instance=new A184235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184234
{
public static readonly long[] Value={ 1L,1L,2L,1L,5L,5L,41L,36L,199L,420L,1377L,4140L,10728L,36839L,87400L,283225L,660812L,1940633L,4609045L,12276261L,29878104L,73822900L,181872899L,428160287L,1053371836L,2416581766L,5864707345L,13309989382L,31614183273L,71451195226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184234Inst : IEnumerable<long>
{
public static readonly long[] Value=A184234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184234.Bytes);
public long this[int i]=>Value[i];

public static A184234Inst Instance=new A184234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184233
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,4L,4L,7L,19L,47L,71L,207L,474L,1077L,2262L,4729L,9770L,18932L,39277L,75259L,142407L,269217L,504234L,930683L,1699058L,3071779L,5553557L,9841969L,17407209L,30656831L,53305283L,92690067L,159391413L,274236367L,467061289L,794526219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184233Inst : IEnumerable<long>
{
public static readonly long[] Value=A184233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184233.Bytes);
public long this[int i]=>Value[i];

public static A184233Inst Instance=new A184233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184232
{
public static readonly long[] Value={ 1L,1L,2L,1L,15L,43L,706L,3719L,85718L,1186420L,21953477L,511276432L,9623532968L,260312395764L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184232Inst : IEnumerable<long>
{
public static readonly long[] Value=A184232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184232.Bytes);
public long this[int i]=>Value[i];

public static A184232Inst Instance=new A184232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184231
{
public static readonly long[] Value={ 15L,57L,57L,180L,411L,180L,621L,2318L,2318L,621L,2061L,14641L,20958L,14641L,2061L,6966L,88103L,224156L,224156L,88103L,6966L,23355L,541936L,2227254L,4207437L,2227254L,541936L,23355L,78597L,3302001L,22904858L,72246797L,72246797L,22904858L,3302001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184231Inst : IEnumerable<long>
{
public static readonly long[] Value=A184231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184231.Bytes);
public long this[int i]=>Value[i];

public static A184231Inst Instance=new A184231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184230
{
public static readonly BigInteger[] Value={ 78597L,20204829L,2366228756L,402560143085L,58125919236791L,9060575120369248L,1365148390837029545L,BigInteger.Parse("208931377551712553029"),BigInteger.Parse("31752580288265710345482"),BigInteger.Parse("4841142511484050619724845"),BigInteger.Parse("737035578935913022062779089") };
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
public class A184230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184230Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184230.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184230.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184230Inst Instance=new A184230Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184229
{
public static readonly BigInteger[] Value={ 23355L,3302001L,231988508L,22718557269L,1922921988456L,174220807520698L,15315046904131217L,1365148390837029545L,BigInteger.Parse("120929646236147243376"),BigInteger.Parse("10742955468995988996920"),BigInteger.Parse("953140018069343327537272") };
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
public class A184229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184229Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184229.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184229.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184229Inst Instance=new A184229Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184228
{
public static readonly BigInteger[] Value={ 6966L,541936L,22904858L,1292899174L,64280495958L,3390680573862L,174220807520698L,9060575120369248L,468666562795511632L,BigInteger.Parse("24302116797857458570"),BigInteger.Parse("1258755953102506894388"),BigInteger.Parse("65231670365062829035438") };
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
public class A184228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184228Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184228.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184228.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184228Inst Instance=new A184228Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184227
{
public static readonly BigInteger[] Value={ 2061L,88103L,2227254L,72246797L,2100723171L,64280495958L,1922921988456L,58125919236791L,1748844715494641L,52730125376777241L,1588361030351074750L,BigInteger.Parse("47866257432157659796"),BigInteger.Parse("1442194920771971583468"),BigInteger.Parse("43456765293746977145236") };
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
public class A184227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184227Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184227.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184227.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184227Inst Instance=new A184227Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184226
{
public static readonly BigInteger[] Value={ 621L,14641L,224156L,4207437L,72246797L,1292899174L,22718557269L,402560143085L,7106563915316L,125668351802785L,2220554387222673L,39250640995900250L,693688800303272397L,12260638522902016569UL,BigInteger.Parse("216694437717450254826") };
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
public class A184226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184226Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184226.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184226.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184226Inst Instance=new A184226Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184225
{
public static readonly long[] Value={ 180L,2318L,20958L,224156L,2227254L,22904858L,231988508L,2366228756L,24059229300L,244980260166L,2492868966664L,25374399195344L,258246420327078L,2628446232292538L,26751738752624652L,272276599065597038L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184225Inst : IEnumerable<long>
{
public static readonly long[] Value=A184225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184225.Bytes);
public long this[int i]=>Value[i];

public static A184225Inst Instance=new A184225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184224
{
public static readonly long[] Value={ 57L,411L,2318L,14641L,88103L,541936L,3302001L,20204829L,123402988L,754319381L,4609217629L,28168842830L,172139309061L,1051973256999L,6428702835542L,39286618550317L,240084864227147L,1467186858794824L,8966146857909117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184224Inst : IEnumerable<long>
{
public static readonly long[] Value=A184224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184224.Bytes);
public long this[int i]=>Value[i];

public static A184224Inst Instance=new A184224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184223
{
public static readonly long[] Value={ 15L,57L,180L,621L,2061L,6966L,23355L,78597L,264060L,887841L,2984121L,10031526L,33719895L,113349537L,381019140L,1280786661L,4305320181L,14472205686L,48647857635L,163528268877L,549695145420L,1847783097081L,6211265114241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184223Inst : IEnumerable<long>
{
public static readonly long[] Value=A184223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184223.Bytes);
public long this[int i]=>Value[i];

public static A184223Inst Instance=new A184223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184222
{
public static readonly BigInteger[] Value={ 15L,411L,20958L,4207437L,2100723171L,3390680573862L,15315046904131217L,BigInteger.Parse("208931377551712553029"),BigInteger.Parse("8272310043853147026573208"),BigInteger.Parse("970110871920573518964680291007"),BigInteger.Parse("333510642857168957639513329116920351") };
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
public class A184222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184222Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184222.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184222.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184222Inst Instance=new A184222Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184221
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,7L,7L,1L,2L,1L,2L,1L,7L,7L,2L,1L,2L,1L,2L,7L,14L,1L,2L,1L,2L,1L,14L,7L,17L,1L,2L,1L,2L,17L,14L,1L,2L,1L,2L,23L,14L,7L,2L,1L,2L,17L,2L,7L,14L,1L,17L,1L,23L,1L,14L,7L,2L,1L,31L,1L,2L,7L,34L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184221Inst : IEnumerable<long>
{
public static readonly long[] Value=A184221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184221.Bytes);
public long this[int i]=>Value[i];

public static A184221Inst Instance=new A184221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184220
{
public static readonly long[] Value={ 0L,0L,0L,0L,14L,23L,34L,47L,62L,79L,98L,119L,142L,167L,194L,223L,254L,287L,322L,359L,398L,439L,482L,527L,574L,623L,674L,727L,782L,839L,898L,959L,1022L,1087L,1154L,1223L,1294L,1367L,1442L,1519L,1598L,1679L,1762L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184220Inst : IEnumerable<long>
{
public static readonly long[] Value=A184220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184220.Bytes);
public long this[int i]=>Value[i];

public static A184220Inst Instance=new A184220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184171
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,2L,1L,2L,1L,2L,2L,2L,2L,3L,3L,3L,2L,3L,3L,3L,4L,4L,5L,5L,4L,6L,5L,5L,6L,7L,7L,8L,7L,9L,8L,9L,8L,11L,11L,12L,10L,13L,12L,14L,14L,15L,16L,17L,16L,20L,19L,20L,20L,24L,22L,26L,23L,27L,27L,30L,28L,34L,33L,36L,34L,40L,37L,43L,41L,46L,46L,50L,47L,56L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184171Inst : IEnumerable<long>
{
public static readonly long[] Value=A184171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184171.Bytes);
public long this[int i]=>Value[i];

public static A184171Inst Instance=new A184171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184170
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,2L,1L,1L,3L,1L,1L,1L,1L,1L,2L,1L,3L,1L,2L,2L,1L,1L,1L,1L,1L,2L,3L,1L,2L,1L,1L,1L,3L,1L,1L,2L,1L,1L,2L,1L,2L,2L,3L,1L,4L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,3L,1L,3L,3L,2L,1L,4L,1L,1L,1L,1L,1L,3L,1L,3L,2L,1L,1L,1L,1L,1L,1L,2L,2L,2L,1L,3L,1L,2L,1L,1L,1L,3L,2L,2L,1L,4L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184170Inst : IEnumerable<long>
{
public static readonly long[] Value=A184170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184170.Bytes);
public long this[int i]=>Value[i];

public static A184170Inst Instance=new A184170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184169
{
public static readonly long[] Value={ 0L,1L,2L,1L,3L,1L,2L,1L,2L,2L,4L,1L,2L,1L,2L,1L,3L,1L,2L,2L,2L,3L,3L,1L,3L,1L,2L,1L,2L,2L,5L,1L,3L,2L,2L,1L,2L,1L,2L,2L,3L,1L,2L,3L,2L,2L,3L,1L,2L,2L,2L,1L,2L,1L,3L,1L,2L,2L,4L,2L,2L,4L,2L,1L,2L,3L,3L,2L,2L,2L,2L,1L,3L,1L,2L,1L,3L,1L,3L,2L,2L,2L,4L,1L,3L,1L,2L,3L,2L,2L,2L,2L,4L,2L,2L,1L,4L,1L,3L,2L,2L,2L,3L,1L,2L,1L,2L,1L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184169Inst : IEnumerable<long>
{
public static readonly long[] Value=A184169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184169.Bytes);
public long this[int i]=>Value[i];

public static A184169Inst Instance=new A184169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184168
{
public static readonly long[] Value={ 0L,1L,3L,1L,6L,2L,3L,1L,4L,4L,10L,2L,4L,2L,6L,1L,6L,3L,3L,4L,4L,7L,7L,2L,9L,3L,5L,2L,6L,5L,15L,1L,9L,4L,6L,3L,4L,2L,5L,4L,7L,3L,4L,7L,7L,5L,9L,2L,4L,7L,6L,3L,3L,4L,12L,2L,4L,5L,10L,5L,5L,11L,5L,1L,7L,8L,6L,4L,7L,5L,6L,3L,7L,3L,9L,2L,9L,4L,9L,4L,6L,5L,11L,3L,9L,3L,7L,7L,4L,6L,5L,5L,13L,7L,6L,2L,13L,3L,10L,7L,5L,5L,8L,3L,7L,2L,4L,4L,9L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184168Inst : IEnumerable<long>
{
public static readonly long[] Value=A184168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184168.Bytes);
public long this[int i]=>Value[i];

public static A184168Inst Instance=new A184168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184167
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,2L,2L,1L,1L,3L,1L,2L,2L,1L,2L,2L,1L,1L,1L,1L,1L,1L,3L,2L,2L,2L,1L,3L,2L,2L,2L,2L,4L,1L,2L,1L,1L,1L,3L,3L,3L,1L,1L,3L,2L,1L,3L,2L,1L,2L,2L,1L,1L,2L,2L,1L,1L,4L,2L,2L,2L,2L,1L,3L,3L,3L,3L,1L,4L,2L,2L,2L,2L,3L,3L,1L,1L,1L,1L,1L,1L,1L,5L,1L,2L,2L,2L,1L,3L,2L,1L,3L,2L,2L,4L,3L,3L,2L,1L,4L,2L,3L,3L,1L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184167Inst : IEnumerable<long>
{
public static readonly long[] Value=A184167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184167.Bytes);
public long this[int i]=>Value[i];

public static A184167Inst Instance=new A184167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184166
{
public static readonly long[] Value={ 0L,1L,2L,1L,3L,1L,2L,1L,2L,1L,4L,1L,2L,1L,2L,1L,3L,1L,2L,1L,2L,1L,3L,1L,3L,1L,2L,1L,2L,1L,5L,1L,2L,1L,2L,1L,2L,1L,2L,1L,3L,1L,2L,1L,2L,1L,3L,1L,2L,1L,2L,1L,2L,1L,3L,1L,2L,1L,4L,1L,2L,1L,2L,1L,2L,1L,3L,1L,2L,1L,2L,1L,3L,1L,2L,1L,2L,1L,2L,1L,2L,1L,4L,1L,3L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,4L,1L,2L,1L,2L,1L,3L,1L,2L,1L,2L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184166Inst : IEnumerable<long>
{
public static readonly long[] Value=A184166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184166.Bytes);
public long this[int i]=>Value[i];

public static A184166Inst Instance=new A184166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184165
{
public static readonly long[] Value={ 2L,3L,5L,5L,8L,8L,9L,9L,13L,13L,13L,14L,14L,14L,21L,17L,14L,22L,17L,23L,23L,21L,22L,26L,34L,22L,35L,24L,23L,36L,21L,33L,34L,23L,37L,40L,26L,26L,36L,43L,22L,38L,24L,37L,57L,35L,36L,50L,41L,59L,37L,38L,33L,62L,55L,44L,43L,36L,23L,66L,40L,34L,61L,65L,58L,58L,26L,41L,57L,62L,43L,76L,38L,40L,93L,44L,60L,60L,37L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184165Inst : IEnumerable<long>
{
public static readonly long[] Value=A184165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184165.Bytes);
public long this[int i]=>Value[i];

public static A184165Inst Instance=new A184165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184164
{
public static readonly long[] Value={ 2L,4L,5L,7L,8L,9L,12L,13L,14L,16L,18L,19L,22L,23L,26L,27L,29L,31L,33L,35L,38L,39L,42L,43L,46L,50L,52L,54L,60L,65L,68L,72L,77L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184164Inst : IEnumerable<long>
{
public static readonly long[] Value=A184164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184164.Bytes);
public long this[int i]=>Value[i];

public static A184164Inst Instance=new A184164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184163
{
public static readonly BigInteger[] Value={ 1L,1L,2L,3L,10L,1001L,BigInteger.Parse("1010045120210252210120045010002") };
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
public class A184163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184163Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184163.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184163.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184163Inst Instance=new A184163Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184162
{
public static readonly long[] Value={ 1L,3L,7L,5L,15L,9L,11L,7L,13L,17L,31L,11L,19L,13L,21L,9L,23L,15L,15L,19L,17L,33L,27L,13L,29L,21L,19L,15L,35L,23L,63L,11L,37L,25L,25L,17L,23L,17L,25L,21L,39L,19L,27L,35L,27L,29L,43L,15L,21L,31L,29L,23L,19L,21L,45L,17L,21L,37L,47L,25L,31L,65L,23L,13L,33L,39L,31L,27L,33L,27L,39L,19L,35L,25L,35L,19L,41L,27L,67L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184162Inst : IEnumerable<long>
{
public static readonly long[] Value=A184162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184162.Bytes);
public long this[int i]=>Value[i];

public static A184162Inst Instance=new A184162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184161
{
public static readonly long[] Value={ 1L,3L,6L,6L,10L,10L,11L,11L,15L,15L,15L,17L,17L,17L,21L,20L,17L,25L,20L,24L,24L,21L,25L,30L,28L,25L,36L,28L,24L,34L,21L,37L,28L,24L,32L,44L,30L,30L,34L,41L,25L,40L,28L,32L,48L,36L,34L,55L,37L,45L,32L,40L,37L,64L,36L,49L,41L,34L,24L,59L,44L,28L,57L,70L,44L,44L,30L,37L,48L,53L,41L,81L,40L,44L,63L,49L,41L,56L,32L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184161Inst : IEnumerable<long>
{
public static readonly long[] Value=A184161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184161.Bytes);
public long this[int i]=>Value[i];

public static A184161Inst Instance=new A184161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184160
{
public static readonly long[] Value={ 1L,2L,3L,4L,4L,6L,5L,8L,9L,8L,5L,12L,7L,10L,12L,16L,6L,18L,9L,16L,15L,10L,10L,24L,16L,14L,27L,20L,9L,24L,6L,32L,15L,12L,20L,36L,13L,18L,21L,32L,8L,30L,11L,20L,36L,20L,13L,48L,25L,32L,18L,28L,17L,54L,20L,40L,27L,18L,7L,48L,19L,12L,45L,64L,28L,30L,10L,24L,30L,40L,17L,72L,16L,26L,48L,36L,25L,42L,11L,64L,81L,16L,11L,60L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184160Inst : IEnumerable<long>
{
public static readonly long[] Value=A184160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184160.Bytes);
public long this[int i]=>Value[i];

public static A184160Inst Instance=new A184160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184159
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,0L,2L,0L,1L,1L,1L,1L,0L,0L,1L,0L,2L,0L,3L,0L,1L,0L,2L,0L,1L,2L,2L,0L,0L,2L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,3L,1L,2L,1L,1L,0L,2L,1L,2L,0L,1L,1L,1L,0L,3L,0L,2L,1L,4L,0L,0L,1L,3L,0L,2L,1L,2L,2L,1L,0L,2L,1L,1L,2L,2L,3L,2L,0L,3L,0L,1L,0L,2L,2L,3L,1L,2L,1L,2L,3L,3L,1L,1L,0L,1L,2L,2L,2L,2L,0L,2L,1L,1L,1L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184159Inst : IEnumerable<long>
{
public static readonly long[] Value=A184159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184159.Bytes);
public long this[int i]=>Value[i];

public static A184159Inst Instance=new A184159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184158
{
public static readonly long[] Value={ 0L,1L,2L,2L,6L,6L,3L,3L,10L,10L,10L,10L,10L,10L,19L,4L,10L,17L,4L,14L,14L,19L,17L,14L,28L,17L,24L,17L,14L,26L,19L,5L,28L,14L,28L,24L,14L,14L,26L,18L,17L,24L,17L,28L,38L,24L,26L,18L,18L,35L,28L,24L,5L,34L,44L,24L,18L,26L,14L,33L,24L,28L,31L,6L,40L,40L,14L,18L,38L,38L,18L,31L,24L,24L,52L,24L,37L,36L,28L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184158Inst : IEnumerable<long>
{
public static readonly long[] Value=A184158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184158.Bytes);
public long this[int i]=>Value[i];

public static A184158Inst Instance=new A184158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184157
{
public static readonly long[] Value={ 0L,0L,2L,2L,4L,4L,6L,6L,10L,10L,10L,8L,8L,8L,16L,12L,8L,14L,12L,18L,18L,16L,14L,14L,28L,14L,24L,12L,18L,24L,16L,20L,28L,18L,24L,20L,14L,14L,24L,28L,14L,22L,12L,24L,34L,24L,24L,22L,30L,40L,24L,22L,20L,30L,40L,18L,28L,24L,18L,34L,20L,28L,36L,30L,36L,36L,14L,30L,34L,32L,28L,28L,22L,20L,50L,18L,42L,32L,24L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184157Inst : IEnumerable<long>
{
public static readonly long[] Value=A184157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184157.Bytes);
public long this[int i]=>Value[i];

public static A184157Inst Instance=new A184157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184156
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,0L,0L,2L,2L,2L,2L,2L,2L,3L,0L,2L,4L,0L,3L,3L,3L,4L,3L,4L,4L,6L,4L,3L,5L,3L,0L,4L,3L,4L,6L,3L,3L,5L,4L,4L,6L,4L,4L,7L,6L,5L,4L,4L,6L,4L,6L,0L,9L,5L,6L,4L,5L,3L,7L,6L,4L,8L,0L,6L,6L,3L,4L,7L,7L,4L,8L,6L,6L,8L,6L,5L,8L,4L,5L,12L,5L,6L,9L,5L,6L,6L,5L,4L,10L,6L,8L,5L,7L,5L,5L,6L,8L,8L,8L,6L,6L,9L,8L,9L,4L,6L,12L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184156Inst : IEnumerable<long>
{
public static readonly long[] Value=A184156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184156.Bytes);
public long this[int i]=>Value[i];

public static A184156Inst Instance=new A184156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184123
{
public static readonly long[] Value={ 20L,561L,14178L,276427L,4249486L,53817407L,581588614L,5503143135L,46473256070L,355407459056L,2489794107266L,16126296889260L,97309331427298L,550557601317077L,2936599872342895L,14836021866212493L,71284139688101545L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184123Inst : IEnumerable<long>
{
public static readonly long[] Value=A184123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184123.Bytes);
public long this[int i]=>Value[i];

public static A184123Inst Instance=new A184123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184122
{
public static readonly long[] Value={ 10L,86L,561L,2861L,12068L,43947L,142376L,419213L,1139569L,2894178L,6931366L,15770131L,34291532L,71619470L,144269412L,281284873L,532422712L,980922994L,1763049635L,3097467201L,5328692624L,8990408705L,14896447100L,24269860485L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184122Inst : IEnumerable<long>
{
public static readonly long[] Value=A184122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184122.Bytes);
public long this[int i]=>Value[i];

public static A184122Inst Instance=new A184122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184121
{
public static readonly BigInteger[] Value={ 1L,-1L,-7L,-31L,-23L,2239L,39889L,603521L,-27466831L,-2445382081L,-204734091383L,7545563759329L,7265319037194073L,2502938339020429439L,BigInteger.Parse("404477135616551491361"),BigInteger.Parse("-932929530161758614571519") };
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
public class A184121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184121Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184121.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184121.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184121Inst Instance=new A184121Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184120
{
public static readonly long[] Value={ 1L,-3L,8L,-23L,70L,-218L,688L,-2195L,7062L,-22866L,74416L,-243206L,797660L,-2624004L,8654304L,-28607171L,94748774L,-314361682L,1044625200L,-3476135186L,11581870900L,-38632753228L,128998096032L,-431144781486L,1442252806012L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184120Inst : IEnumerable<long>
{
public static readonly long[] Value=A184120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184120.Bytes);
public long this[int i]=>Value[i];

public static A184120Inst Instance=new A184120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184119
{
public static readonly long[] Value={ 2L,6L,9L,12L,16L,19L,23L,26L,30L,33L,36L,40L,43L,47L,50L,53L,57L,60L,64L,67L,70L,74L,77L,81L,84L,88L,91L,94L,98L,101L,105L,108L,111L,115L,118L,122L,125L,129L,132L,135L,139L,142L,146L,149L,152L,156L,159L,163L,166L,170L,173L,176L,180L,183L,187L,190L,193L,197L,200L,204L,207L,210L,214L,217L,221L,224L,228L,231L,234L,238L,241L,245L,248L,251L,255L,258L,262L,265L,269L,272L,275L,279L,282L,286L,289L,292L,296L,299L,303L,306L,309L,313L,316L,320L,323L,327L,330L,333L,337L,340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184119Inst : IEnumerable<long>
{
public static readonly long[] Value=A184119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184119.Bytes);
public long this[int i]=>Value[i];

public static A184119Inst Instance=new A184119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184118
{
public static readonly long[] Value={ 4L,7L,10L,14L,17L,21L,24L,28L,31L,34L,38L,41L,45L,48L,51L,55L,58L,62L,65L,68L,72L,75L,79L,82L,86L,89L,92L,96L,99L,103L,106L,109L,113L,116L,120L,123L,127L,130L,133L,137L,140L,144L,147L,150L,154L,157L,161L,164L,168L,171L,174L,178L,181L,185L,188L,191L,195L,198L,202L,205L,208L,212L,215L,219L,222L,226L,229L,232L,236L,239L,243L,246L,249L,253L,256L,260L,263L,267L,270L,273L,277L,280L,284L,287L,290L,294L,297L,301L,304L,307L,311L,314L,318L,321L,325L,328L,331L,335L,338L,342L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184118Inst : IEnumerable<long>
{
public static readonly long[] Value=A184118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184118.Bytes);
public long this[int i]=>Value[i];

public static A184118Inst Instance=new A184118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184117
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,8L,9L,11L,12L,13L,15L,16L,18L,19L,20L,22L,23L,25L,26L,27L,29L,30L,32L,33L,35L,36L,37L,39L,40L,42L,43L,44L,46L,47L,49L,50L,52L,53L,54L,56L,57L,59L,60L,61L,63L,64L,66L,67L,69L,70L,71L,73L,74L,76L,77L,78L,80L,81L,83L,84L,85L,87L,88L,90L,91L,93L,94L,95L,97L,98L,100L,101L,102L,104L,105L,107L,108L,110L,111L,112L,114L,115L,117L,118L,119L,121L,122L,124L,125L,126L,128L,129L,131L,132L,134L,135L,136L,138L,139L,141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184117Inst : IEnumerable<long>
{
public static readonly long[] Value=A184117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184117.Bytes);
public long this[int i]=>Value[i];

public static A184117Inst Instance=new A184117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184116
{
public static readonly long[] Value={ 8L,10L,13L,15L,17L,19L,21L,23L,24L,26L,28L,30L,31L,33L,35L,36L,38L,39L,41L,42L,44L,45L,47L,49L,50L,51L,53L,54L,56L,57L,59L,60L,62L,63L,65L,66L,67L,69L,70L,72L,73L,74L,76L,77L,78L,80L,81L,83L,84L,85L,87L,88L,89L,91L,92L,93L,95L,96L,97L,99L,100L,101L,103L,104L,105L,106L,108L,109L,110L,112L,113L,114L,116L,117L,118L,119L,121L,122L,123L,125L,126L,127L,128L,130L,131L,132L,133L,135L,136L,137L,138L,140L,141L,142L,143L,145L,146L,147L,149L,150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184116Inst : IEnumerable<long>
{
public static readonly long[] Value=A184116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184116.Bytes);
public long this[int i]=>Value[i];

public static A184116Inst Instance=new A184116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184115
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,8L,9L,11L,13L,14L,16L,18L,20L,22L,24L,27L,29L,31L,34L,36L,39L,42L,45L,48L,50L,54L,57L,60L,63L,66L,70L,73L,77L,81L,84L,88L,92L,96L,100L,104L,109L,113L,117L,122L,126L,131L,136L,141L,146L,150L,156L,161L,166L,171L,176L,182L,187L,193L,199L,204L,210L,216L,222L,228L,234L,241L,247L,253L,260L,266L,273L,280L,287L,294L,300L,308L,315L,322L,329L,336L,344L,351L,359L,367L,374L,382L,390L,398L,406L,414L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184115Inst : IEnumerable<long>
{
public static readonly long[] Value=A184115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184115.Bytes);
public long this[int i]=>Value[i];

public static A184115Inst Instance=new A184115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184114
{
public static readonly long[] Value={ 1L,7L,10L,12L,15L,17L,19L,21L,23L,25L,26L,28L,30L,32L,33L,35L,37L,38L,40L,41L,43L,44L,46L,47L,49L,51L,52L,53L,55L,56L,58L,59L,61L,62L,64L,65L,67L,68L,69L,71L,72L,74L,75L,76L,78L,79L,80L,82L,83L,85L,86L,87L,89L,90L,91L,93L,94L,95L,97L,98L,99L,101L,102L,103L,105L,106L,107L,108L,110L,111L,112L,114L,115L,116L,118L,119L,120L,121L,123L,124L,125L,127L,128L,129L,130L,132L,133L,134L,135L,137L,138L,139L,140L,142L,143L,144L,145L,147L,148L,149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184114Inst : IEnumerable<long>
{
public static readonly long[] Value=A184114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184114.Bytes);
public long this[int i]=>Value[i];

public static A184114Inst Instance=new A184114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184113
{
public static readonly long[] Value={ 6L,8L,11L,12L,14L,16L,18L,20L,21L,23L,24L,26L,27L,29L,31L,32L,33L,35L,36L,38L,39L,41L,42L,44L,45L,46L,48L,49L,50L,52L,53L,54L,56L,57L,59L,60L,61L,62L,64L,65L,66L,68L,69L,70L,72L,73L,74L,76L,77L,78L,79L,81L,82L,83L,84L,86L,87L,88L,89L,91L,92L,93L,95L,96L,97L,98L,99L,101L,102L,103L,104L,106L,107L,108L,109L,111L,112L,113L,114L,116L,117L,118L,119L,120L,122L,123L,124L,125L,126L,128L,129L,130L,131L,132L,134L,135L,136L,137L,139L,140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184113Inst : IEnumerable<long>
{
public static readonly long[] Value=A184113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184113.Bytes);
public long this[int i]=>Value[i];

public static A184113Inst Instance=new A184113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184112
{
public static readonly long[] Value={ 2L,3L,4L,5L,7L,9L,11L,12L,15L,17L,19L,21L,24L,27L,30L,32L,36L,39L,42L,45L,49L,53L,57L,60L,65L,69L,73L,77L,82L,87L,92L,96L,102L,107L,112L,117L,123L,129L,135L,140L,147L,153L,159L,165L,172L,179L,186L,192L,200L,207L,214L,221L,229L,237L,245L,252L,261L,269L,277L,285L,294L,303L,312L,320L,330L,339L,348L,357L,367L,377L,387L,396L,407L,417L,427L,437L,448L,459L,470L,480L,492L,503L,514L,525L,537L,549L,561L,572L,585L,597L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184112Inst : IEnumerable<long>
{
public static readonly long[] Value=A184112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184112.Bytes);
public long this[int i]=>Value[i];

public static A184112Inst Instance=new A184112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184111
{
public static readonly long[] Value={ 1L,6L,8L,10L,13L,14L,16L,18L,20L,22L,23L,25L,26L,28L,29L,31L,33L,34L,35L,37L,38L,40L,41L,43L,44L,46L,47L,48L,50L,51L,52L,54L,55L,56L,58L,59L,61L,62L,63L,64L,66L,67L,68L,70L,71L,72L,74L,75L,76L,78L,79L,80L,81L,83L,84L,85L,86L,88L,89L,90L,91L,93L,94L,95L,97L,98L,99L,100L,101L,103L,104L,105L,106L,108L,109L,110L,111L,113L,114L,115L,116L,118L,119L,120L,121L,122L,124L,125L,126L,127L,128L,130L,131L,132L,133L,134L,136L,137L,138L,139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184111Inst : IEnumerable<long>
{
public static readonly long[] Value=A184111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184111.Bytes);
public long this[int i]=>Value[i];

public static A184111Inst Instance=new A184111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184110
{
public static readonly long[] Value={ 5L,7L,9L,10L,12L,13L,15L,17L,18L,19L,21L,22L,24L,25L,27L,28L,29L,31L,32L,33L,35L,36L,37L,39L,40L,41L,42L,44L,45L,46L,47L,49L,50L,51L,53L,54L,55L,56L,57L,59L,60L,61L,62L,64L,65L,66L,67L,69L,70L,71L,72L,73L,75L,76L,77L,78L,79L,81L,82L,83L,84L,85L,87L,88L,89L,90L,91L,92L,94L,95L,96L,97L,98L,99L,101L,102L,103L,104L,105L,107L,108L,109L,110L,111L,112L,113L,115L,116L,117L,118L,119L,120L,122L,123L,124L,125L,126L,127L,129L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184110Inst : IEnumerable<long>
{
public static readonly long[] Value=A184110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184110.Bytes);
public long this[int i]=>Value[i];

public static A184110Inst Instance=new A184110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184109
{
public static readonly long[] Value={ 2L,3L,4L,6L,8L,10L,13L,16L,18L,22L,25L,28L,32L,36L,40L,45L,50L,54L,60L,65L,70L,76L,82L,88L,95L,102L,108L,116L,123L,130L,138L,146L,154L,163L,172L,180L,190L,199L,208L,218L,228L,238L,249L,260L,270L,282L,293L,304L,316L,328L,340L,353L,366L,378L,392L,405L,418L,432L,446L,460L,475L,490L,504L,520L,535L,550L,566L,582L,598L,615L,632L,648L,666L,683L,700L,718L,736L,754L,773L,792L,810L,830L,849L,868L,888L,908L,928L,949L,970L,990L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184109Inst : IEnumerable<long>
{
public static readonly long[] Value=A184109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184109.Bytes);
public long this[int i]=>Value[i];

public static A184109Inst Instance=new A184109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184108
{
public static readonly long[] Value={ 1L,5L,7L,9L,11L,12L,14L,15L,17L,19L,20L,21L,23L,24L,26L,27L,29L,30L,31L,33L,34L,35L,37L,38L,39L,41L,42L,43L,44L,46L,47L,48L,49L,51L,52L,53L,55L,56L,57L,58L,59L,61L,62L,63L,64L,66L,67L,68L,69L,71L,72L,73L,74L,75L,77L,78L,79L,80L,81L,83L,84L,85L,86L,87L,89L,90L,91L,92L,93L,94L,96L,97L,98L,99L,100L,101L,103L,104L,105L,106L,107L,109L,110L,111L,112L,113L,114L,115L,117L,118L,119L,120L,121L,122L,124L,125L,126L,127L,128L,129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184108Inst : IEnumerable<long>
{
public static readonly long[] Value=A184108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184108.Bytes);
public long this[int i]=>Value[i];

public static A184108Inst Instance=new A184108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184075
{
public static readonly long[] Value={ 150L,239L,1436L,5760L,25954L,104404L,422992L,1588555L,5471235L,17366119L,50883759L,138309491L,350886736L,834954298L,1873682709L,3985258309L,8070671272L,15625241986L,29027866689L,51922380121L,89705278727L,150134603779L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184075Inst : IEnumerable<long>
{
public static readonly long[] Value=A184075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184075.Bytes);
public long this[int i]=>Value[i];

public static A184075Inst Instance=new A184075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184074
{
public static readonly long[] Value={ 58L,74L,239L,578L,1599L,4233L,11128L,28248L,67622L,152873L,327044L,665356L,1293389L,2411872L,4330976L,7515107L,12640705L,20668977L,32935784L,51260994L,78079741L,116598158L,170976280L,246540941L,350031617L,489882295L,676542576L,922841348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184074Inst : IEnumerable<long>
{
public static readonly long[] Value=A184074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184074.Bytes);
public long this[int i]=>Value[i];

public static A184074Inst Instance=new A184074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184073
{
public static readonly long[] Value={ 29L,58L,150L,335L,728L,1499L,2968L,5645L,10331L,18242L,31173L,51709L,83492L,131554L,202727L,306142L,453830L,661439L,949082L,1342332L,1873381L,2582381L,3518986L,4744115L,6331957L,8372240L,10972787L,14262383L,18393978L,23548252L,29937569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184073Inst : IEnumerable<long>
{
public static readonly long[] Value=A184073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184073.Bytes);
public long this[int i]=>Value[i];

public static A184073Inst Instance=new A184073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184072
{
public static readonly long[] Value={ 29L,74L,1436L,44050L,5727704L,2187790488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184072Inst : IEnumerable<long>
{
public static readonly long[] Value=A184072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184072.Bytes);
public long this[int i]=>Value[i];

public static A184072Inst Instance=new A184072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184071
{
public static readonly long[] Value={ 7L,11L,11L,20L,16L,20L,34L,36L,36L,34L,54L,73L,130L,73L,54L,81L,134L,382L,382L,134L,81L,116L,225L,924L,1918L,924L,225L,116L,160L,354L,1884L,7671L,7671L,1884L,354L,160L,214L,529L,3463L,22452L,56723L,22452L,3463L,529L,214L,279L,758L,5800L,57488L,288744L,288744L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184071Inst : IEnumerable<long>
{
public static readonly long[] Value=A184071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184071.Bytes);
public long this[int i]=>Value[i];

public static A184071Inst Instance=new A184071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184070
{
public static readonly long[] Value={ 160L,529L,5800L,126978L,4136338L,116690636L,2770530466L,52431215293L,815858815795L,10481797492543L,110945811109376L,969268941798697L,7097493179383915L,43883325663965862L,231088111095174435L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184070Inst : IEnumerable<long>
{
public static readonly long[] Value=A184070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184070.Bytes);
public long this[int i]=>Value[i];

public static A184070Inst Instance=new A184070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184069
{
public static readonly long[] Value={ 116L,354L,3463L,57488L,1201502L,19694227L,262752720L,2770530466L,24162848938L,172608985173L,1016605859378L,4984089231912L,20706626054603L,73706312982861L,227684956511158L,617008282013299L,1483858846733909L,3203034048943439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184069Inst : IEnumerable<long>
{
public static readonly long[] Value=A184069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184069.Bytes);
public long this[int i]=>Value[i];

public static A184069Inst Instance=new A184069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184068
{
public static readonly long[] Value={ 81L,225L,1884L,22452L,288744L,2663589L,19694227L,116690636L,572683182L,2305864084L,7782298646L,22382616957L,56141874238L,124734871342L,249667791032L,456693083041L,773758373131L,1229106077318L,1850219475619L,2663743231907L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184068Inst : IEnumerable<long>
{
public static readonly long[] Value=A184068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184068.Bytes);
public long this[int i]=>Value[i];

public static A184068Inst Instance=new A184068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184067
{
public static readonly long[] Value={ 54L,134L,924L,7671L,56723L,288744L,1201502L,4136338L,11927710L,29250767L,62876028L,120904433L,212281665L,345771803L,530007739L,773304379L,1083892502L,1469984808L,1939804454L,2501586120L,3163566510L,3933982328L,4821070278L,5833067064L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184067Inst : IEnumerable<long>
{
public static readonly long[] Value=A184067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184067.Bytes);
public long this[int i]=>Value[i];

public static A184067Inst Instance=new A184067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184066
{
public static readonly long[] Value={ 34L,73L,382L,1918L,7671L,22452L,57488L,126978L,248290L,439534L,717161L,1096422L,1592731L,2221230L,2997249L,3936118L,5053167L,6363726L,7883125L,9626694L,11609763L,13847662L,16355721L,19149270L,22243639L,25654158L,29396157L,33484966L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184066Inst : IEnumerable<long>
{
public static readonly long[] Value=A184066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184066.Bytes);
public long this[int i]=>Value[i];

public static A184066Inst Instance=new A184066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184065
{
public static readonly long[] Value={ 20L,36L,130L,382L,924L,1884L,3463L,5800L,9065L,13397L,18940L,25837L,34232L,44269L,56092L,69845L,85672L,103717L,124124L,147037L,172600L,200957L,232252L,266629L,304232L,345205L,389692L,437837L,489784L,545677L,605660L,669877L,738472L,811589L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184065Inst : IEnumerable<long>
{
public static readonly long[] Value=A184065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184065.Bytes);
public long this[int i]=>Value[i];

public static A184065Inst Instance=new A184065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184064
{
public static readonly long[] Value={ 11L,16L,36L,73L,134L,225L,354L,529L,758L,1049L,1410L,1849L,2374L,2993L,3714L,4545L,5494L,6569L,7778L,9129L,10630L,12289L,14114L,16113L,18294L,20665L,23234L,26009L,28998L,32209L,35650L,39329L,43254L,47433L,51874L,56585L,61574L,66849L,72418L,78289L,84470L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184064Inst : IEnumerable<long>
{
public static readonly long[] Value=A184064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184064.Bytes);
public long this[int i]=>Value[i];

public static A184064Inst Instance=new A184064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184063
{
public static readonly long[] Value={ 7L,11L,20L,34L,54L,81L,116L,160L,214L,279L,356L,446L,550L,669L,804L,956L,1126L,1315L,1524L,1754L,2006L,2281L,2580L,2904L,3254L,3631L,4036L,4470L,4934L,5429L,5956L,6516L,7110L,7739L,8404L,9106L,9846L,10625L,11444L,12304L,13206L,14151L,15140L,16174L,17254L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184063Inst : IEnumerable<long>
{
public static readonly long[] Value=A184063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184063.Bytes);
public long this[int i]=>Value[i];

public static A184063Inst Instance=new A184063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184062
{
public static readonly long[] Value={ 7L,16L,130L,1918L,56723L,2663589L,262752720L,52431215293L,22708430287929L,21448555991084059L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184062Inst : IEnumerable<long>
{
public static readonly long[] Value=A184062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184062.Bytes);
public long this[int i]=>Value[i];

public static A184062Inst Instance=new A184062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184061
{
public static readonly long[] Value={ 1L,1L,3L,1L,9L,11L,1L,11L,31L,21L,1L,19L,65L,107L,61L,1L,25L,109L,243L,501L,179L,1L,31L,143L,541L,1731L,2339L,447L,1L,33L,207L,839L,4769L,11251L,10303L,1243L,1L,41L,245L,1531L,10135L,40483L,67083L,44523L,3359L,1L,43L,337L,2145L,21411L,106047L,327223L,426379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184061Inst : IEnumerable<long>
{
public static readonly long[] Value=A184061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184061.Bytes);
public long this[int i]=>Value[i];

public static A184061Inst Instance=new A184061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184060
{
public static readonly long[] Value={ 1L,41L,337L,3345L,59353L,945243L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184060Inst : IEnumerable<long>
{
public static readonly long[] Value=A184060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184060.Bytes);
public long this[int i]=>Value[i];

public static A184060Inst Instance=new A184060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184011
{
public static readonly BigInteger[] Value={ 0L,1L,2L,2L,0L,8L,-56L,32L,10176L,-215808L,-78784L,150990912L,-3405688576L,-139041794560L,10385778676736L,130003936220160L,-43016304236761088L,526545841919713280L,BigInteger.Parse("266085261164348628992"),BigInteger.Parse("-12347306589339686547456") };
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
public class A184011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184011Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184011.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184011.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184011Inst Instance=new A184011Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184010
{
public static readonly long[] Value={ 1L,3L,4L,6L,7L,8L,9L,11L,12L,13L,14L,15L,17L,18L,19L,20L,21L,22L,23L,25L,26L,27L,28L,29L,30L,31L,32L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L,84L,86L,87L,88L,89L,90L,91L,92L,93L,94L,95L,96L,97L,98L,99L,100L,101L,103L,104L,105L,106L,107L,108L,109L,110L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184010Inst : IEnumerable<long>
{
public static readonly long[] Value=A184010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184010.Bytes);
public long this[int i]=>Value[i];

public static A184010Inst Instance=new A184010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184009
{
public static readonly long[] Value={ 1L,3L,6L,10L,15L,21L,27L,35L,43L,52L,62L,73L,85L,97L,111L,125L,140L,156L,173L,191L,209L,229L,249L,270L,292L,315L,339L,363L,389L,415L,442L,470L,499L,529L,559L,591L,623L,656L,690L,725L,761L,797L,835L,873L,912L,952L,993L,1035L,1077L,1121L,1165L,1210L,1256L,1303L,1351L,1399L,1449L,1499L,1550L,1602L,1655L,1709L,1763L,1819L,1875L,1932L,1990L,2049L,2109L,2169L,2231L,2293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184009Inst : IEnumerable<long>
{
public static readonly long[] Value=A184009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184009.Bytes);
public long this[int i]=>Value[i];

public static A184009Inst Instance=new A184009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184008
{
public static readonly long[] Value={ 2L,4L,5L,7L,8L,9L,11L,12L,13L,14L,16L,17L,18L,19L,20L,22L,23L,24L,25L,26L,28L,29L,30L,31L,32L,33L,34L,36L,37L,38L,39L,40L,41L,42L,44L,45L,46L,47L,48L,49L,50L,51L,53L,54L,55L,56L,57L,58L,59L,60L,61L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L,84L,86L,87L,88L,89L,90L,91L,92L,93L,94L,95L,96L,98L,99L,100L,101L,102L,103L,104L,105L,106L,107L,108L,109L,110L,112L,113L,114L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184008Inst : IEnumerable<long>
{
public static readonly long[] Value=A184008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184008.Bytes);
public long this[int i]=>Value[i];

public static A184008Inst Instance=new A184008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184007
{
public static readonly long[] Value={ 2L,5L,7L,9L,12L,14L,17L,19L,21L,24L,26L,28L,31L,33L,35L,38L,40L,43L,45L,47L,50L,52L,54L,57L,59L,61L,64L,66L,69L,71L,73L,76L,78L,80L,83L,85L,87L,90L,92L,95L,97L,99L,102L,104L,106L,109L,111L,114L,116L,118L,121L,123L,125L,128L,130L,132L,135L,137L,140L,142L,144L,147L,149L,151L,154L,156L,158L,161L,163L,166L,168L,170L,173L,175L,177L,180L,182L,185L,187L,189L,192L,194L,196L,199L,201L,203L,206L,208L,211L,213L,215L,218L,220L,222L,225L,227L,229L,232L,234L,237L,239L,241L,244L,246L,248L,251L,253L,255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184007Inst : IEnumerable<long>
{
public static readonly long[] Value=A184007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184007.Bytes);
public long this[int i]=>Value[i];

public static A184007Inst Instance=new A184007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184006
{
public static readonly long[] Value={ 1L,3L,4L,6L,8L,10L,11L,13L,15L,16L,18L,20L,22L,23L,25L,27L,29L,30L,32L,34L,36L,37L,39L,41L,42L,44L,46L,48L,49L,51L,53L,55L,56L,58L,60L,62L,63L,65L,67L,68L,70L,72L,74L,75L,77L,79L,81L,82L,84L,86L,88L,89L,91L,93L,94L,96L,98L,100L,101L,103L,105L,107L,108L,110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184006Inst : IEnumerable<long>
{
public static readonly long[] Value=A184006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184006.Bytes);
public long this[int i]=>Value[i];

public static A184006Inst Instance=new A184006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184005
{
public static readonly long[] Value={ 1L,4L,9L,15L,23L,32L,43L,55L,69L,84L,101L,119L,139L,160L,183L,207L,233L,260L,289L,319L,351L,384L,419L,455L,493L,532L,573L,615L,659L,704L,751L,799L,849L,900L,953L,1007L,1063L,1120L,1179L,1239L,1301L,1364L,1429L,1495L,1563L,1632L,1703L,1775L,1849L,1924L,2001L,2079L,2159L,2240L,2323L,2407L,2493L,2580L,2669L,2759L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184005Inst : IEnumerable<long>
{
public static readonly long[] Value=A184005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184005.Bytes);
public long this[int i]=>Value[i];

public static A184005Inst Instance=new A184005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184004
{
public static readonly long[] Value={ 2L,3L,5L,6L,7L,8L,10L,11L,12L,13L,14L,16L,17L,18L,19L,20L,21L,22L,24L,25L,26L,27L,28L,29L,30L,31L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L,85L,86L,87L,88L,89L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184004Inst : IEnumerable<long>
{
public static readonly long[] Value=A184004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184004.Bytes);
public long this[int i]=>Value[i];

public static A184004Inst Instance=new A184004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184003
{
public static readonly long[] Value={ 81L,171L,171L,361L,309L,361L,855L,579L,579L,855L,2025L,1233L,977L,1233L,2025L,5175L,2691L,1887L,1887L,2691L,5175L,13225L,6417L,3793L,3309L,3793L,6417L,13225L,35535L,15555L,8415L,6111L,6111L,8415L,15555L,35535L,95481L,40041L,19217L,12525L,10449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184003Inst : IEnumerable<long>
{
public static readonly long[] Value=A184003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184003.Bytes);
public long this[int i]=>Value[i];

public static A184003Inst Instance=new A184003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184002
{
public static readonly long[] Value={ 35535L,40041L,47031L,61125L,85431L,134853L,227319L,418461L,799815L,1612581L,3338151L,7206765L,16031991L,37247253L,89664279L,225444381L,586169895L,1579364421L,4360148871L,12326941005L,35353745751L,102812027253L,301213506039L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184002Inst : IEnumerable<long>
{
public static readonly long[] Value=A184002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184002.Bytes);
public long this[int i]=>Value[i];

public static A184002Inst Instance=new A184002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184001
{
public static readonly long[] Value={ 13225L,15555L,19217L,26655L,39697L,66591L,118097L,227319L,453025L,954495L,2073857L,4730055L,11163217L,27594351L,70508657L,187283319L,510129025L,1427563935L,4057091297L,11721369255L,34143669937L,100392943311L,296377454417L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184001Inst : IEnumerable<long>
{
public static readonly long[] Value=A184001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184001.Bytes);
public long this[int i]=>Value[i];

public static A184001Inst Instance=new A184001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184000
{
public static readonly long[] Value={ 5175L,6417L,8415L,12525L,19935L,35565L,66591L,134853L,282735L,628557L,1444815L,3494805L,8731935L,22771005L,60933951L,168205893L,472111695L,1351666797L,3905565615L,11418586485L,33538635135L,99183404445L,293959431711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184000Inst : IEnumerable<long>
{
public static readonly long[] Value=A184000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184000.Bytes);
public long this[int i]=>Value[i];

public static A184000Inst Instance=new A184000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A183999
{
public static readonly long[] Value={ 2025L,2691L,3793L,6111L,10449L,19935L,39697L,85431L,190305L,450111L,1098433L,2812551L,7386129L,20098095L,55623217L,157619511L,451006785L,1309524831L,3821415073L,11250418791L,33202564209L,98511527055L,292616203537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A183999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A183999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A183999Inst : IEnumerable<long>
{
public static readonly long[] Value=A183999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A183999.Bytes);
public long this[int i]=>Value[i];

public static A183999Inst Instance=new A183999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A183998
{
public static readonly long[] Value={ 855L,1233L,1887L,3309L,6111L,12525L,26655L,61125L,144495L,361293L,925647L,2471829L,6713631L,18762045L,52968255L,152326725L,440454735L,1288454253L,3779340207L,11166335349L,33034529151L,98175588765L,291944589855L,870672034725L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A183998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A183998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A183998Inst : IEnumerable<long>
{
public static readonly long[] Value=A183998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A183998.Bytes);
public long this[int i]=>Value[i];

public static A183998Inst Instance=new A183998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A183997
{
public static readonly long[] Value={ 361L,579L,977L,1887L,3793L,8415L,19217L,47031L,117601L,308799L,822977L,2268807L,6311953L,17963055L,51378737L,149156151L,434130241L,1275821919L,3754108577L,11115905127L,32933734513L,97974065295L,291541674257L,869866334871L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A183997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A183997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A183997Inst : IEnumerable<long>
{
public static readonly long[] Value=A183997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A183997.Bytes);
public long this[int i]=>Value[i];

public static A183997Inst Instance=new A183997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A183996
{
public static readonly long[] Value={ 171L,309L,579L,1233L,2691L,6417L,15555L,40041L,104211L,282609L,771699L,2167353L,6111171L,17563617L,50584035L,147570921L,430968051L,1269505809L,3741492819L,11090690073L,32883337251L,97873303617L,291340216515L,869463485001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A183996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A183996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A183996Inst : IEnumerable<long>
{
public static readonly long[] Value=A183996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A183996.Bytes);
public long this[int i]=>Value[i];

public static A183996Inst Instance=new A183996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A183963
{
public static readonly long[] Value={ 81L,459L,2601L,15759L,95481L,586791L,3606201L,22235391L,137100681L,845893287L,5219051049L,32205712671L,198734965209L,1226388884391L,7568017506009L,46702383172479L,288201314579049L,1778498201192679L,10975161082334409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A183963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A183963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A183963Inst : IEnumerable<long>
{
public static readonly long[] Value=A183963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A183963.Bytes);
public long this[int i]=>Value[i];

public static A183963Inst Instance=new A183963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A183962
{
public static readonly long[] Value={ 81L,4401L,746017L,492135291L,1088246684231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A183962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A183962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A183962Inst : IEnumerable<long>
{
public static readonly long[] Value=A183962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A183962.Bytes);
public long this[int i]=>Value[i];

public static A183962Inst Instance=new A183962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A183961
{
public static readonly long[] Value={ 3L,77L,771L,4987L,23044L,85595L,268008L,737538L,1830390L,4178324L,8894137L,17852441L,34075582L,62278704L,109576019L,186449688L,307961403L,495340098L,777909895L,1195576284L,1801779972L,2667185951L,3883983063L,5571216259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A183961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A183961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A183961Inst : IEnumerable<long>
{
public static readonly long[] Value=A183961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A183961.Bytes);
public long this[int i]=>Value[i];

public static A183961Inst Instance=new A183961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A183960
{
public static readonly long[] Value={ 3L,37L,339L,1805L,7250L,23611L,65909L,163588L,369777L,775045L,1525468L,2847243L,5078854L,8712108L,14442500L,23231857L,36384941L,55641864L,83284699L,122267246L,176362928L,250341134L,350161711L,483206291L,658533921L,887179738L,1182476762L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A183960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A183960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A183960Inst : IEnumerable<long>
{
public static readonly long[] Value=A183960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A183960.Bytes);
public long this[int i]=>Value[i];

public static A183960Inst Instance=new A183960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A183959
{
public static readonly long[] Value={ 1L,20L,147L,649L,2195L,6301L,15601L,34847L,71509L,137520L,249799L,433038L,720820L,1159650L,1809461L,2749459L,4079634L,5928317L,8451964L,11845820L,16345291L,22238744L,29865253L,39632411L,52016744L,67583239L,86980484L,110967120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A183959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A183959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A183959Inst : IEnumerable<long>
{
public static readonly long[] Value=A183959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A183959.Bytes);
public long this[int i]=>Value[i];

public static A183959Inst Instance=new A183959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A183958
{
public static readonly long[] Value={ 2L,10L,61L,219L,656L,1613L,3539L,7099L,13225L,23247L,38938L,62599L,97177L,146396L,214841L,308110L,432893L,597226L,810560L,1083958L,1430179L,1864028L,2402453L,3064671L,3872421L,4850307L,6025900L,7429899L,9096446L,11063531L,13373040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A183958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A183958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A183958Inst : IEnumerable<long>
{
public static readonly long[] Value=A183958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A183958.Bytes);
public long this[int i]=>Value[i];

public static A183958Inst Instance=new A183958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A183957
{
public static readonly long[] Value={ 1L,7L,26L,78L,180L,398L,770L,1387L,2330L,3738L,5772L,8599L,12396L,17488L,24122L,32632L,43334L,56754L,73278L,93477L,117791L,147036L,181786L,222869L,270904L,327053L,392108L,467146L,553100L,651442L,763249L,889952L,1032752L,1193547L,1373708L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A183957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A183957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A183957Inst : IEnumerable<long>
{
public static readonly long[] Value=A183957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A183957.Bytes);
public long this[int i]=>Value[i];

public static A183957Inst Instance=new A183957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A183956
{
public static readonly long[] Value={ 2L,5L,10L,27L,53L,94L,161L,259L,399L,578L,811L,1120L,1505L,1985L,2562L,3267L,4104L,5092L,6249L,7595L,9146L,10923L,12948L,15245L,17831L,20735L,23980L,27592L,31597L,36020L,40894L,46252L,52114L,58520L,65494L,73076L,81300L,90195L,99807L,110163L,121306L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A183956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A183956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A183956Inst : IEnumerable<long>
{
public static readonly long[] Value=A183956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A183956.Bytes);
public long this[int i]=>Value[i];

public static A183956Inst Instance=new A183956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A183955
{
public static readonly long[] Value={ 1L,1L,4L,8L,14L,21L,32L,48L,61L,82L,108L,139L,172L,210L,256L,311L,365L,427L,500L,582L,666L,759L,864L,982L,1097L,1228L,1372L,1529L,1688L,1860L,2048L,2253L,2457L,2677L,2916L,3172L,3430L,3705L,4000L,4316L,4629L,4966L,5324L,5703L,6084L,6486L,6912L,7363L,7813L,8287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A183955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A183955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A183955Inst : IEnumerable<long>
{
public static readonly long[] Value=A183955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A183955.Bytes);
public long this[int i]=>Value[i];

public static A183955Inst Instance=new A183955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A183954
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,6L,7L,9L,12L,14L,17L,19L,22L,25L,29L,32L,36L,41L,45L,50L,54L,59L,64L,70L,75L,81L,88L,94L,101L,107L,114L,121L,129L,136L,144L,153L,161L,170L,178L,187L,196L,206L,215L,225L,236L,246L,257L,267L,278L,289L,301L,312L,324L,337L,349L,362L,374L,387L,400L,414L,427L,441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A183954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A183954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A183954Inst : IEnumerable<long>
{
public static readonly long[] Value=A183954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A183954.Bytes);
public long this[int i]=>Value[i];

public static A183954Inst Instance=new A183954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A183953
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,2L,1L,2L,3L,4L,5L,1L,1L,2L,4L,8L,10L,7L,2L,1L,2L,6L,14L,27L,26L,10L,1L,1L,3L,7L,21L,53L,78L,61L,20L,3L,1L,3L,9L,32L,94L,180L,219L,147L,37L,3L,1L,3L,12L,48L,161L,398L,656L,649L,339L,77L,4L,1L,3L,14L,61L,259L,770L,1613L,2195L,1805L,771L,118L,2L,1L,4L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A183953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A183953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A183953Inst : IEnumerable<long>
{
public static readonly long[] Value=A183953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A183953.Bytes);
public long this[int i]=>Value[i];

public static A183953Inst Instance=new A183953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A183952
{
public static readonly long[] Value={ 1L,3L,9L,48L,259L,1387L,7099L,34847L,163588L,737538L,3200055L,13400036L,54289217L,213301597L,814463579L,3028171125L,10981909481L,38908787433L,134868584027L,457962911722L,1525173224446L,4987066348804L,16026405323579L,50662230359800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A183952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A183952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A183952Inst : IEnumerable<long>
{
public static readonly long[] Value=A183952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A183952.Bytes);
public long this[int i]=>Value[i];

public static A183952Inst Instance=new A183952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A183951
{
public static readonly long[] Value={ 1L,2L,7L,32L,161L,770L,3539L,15601L,65909L,268008L,1051270L,3988203L,14668943L,52424801L,182419618L,619151665L,2053195642L,6662236128L,21181322973L,66063536142L,202362531609L,609394911084L,1805804155160L,5270044397919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A183951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A183951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A183951Inst : IEnumerable<long>
{
public static readonly long[] Value=A183951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A183951.Bytes);
public long this[int i]=>Value[i];

public static A183951Inst Instance=new A183951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A183950
{
public static readonly long[] Value={ 1L,2L,6L,21L,94L,398L,1613L,6301L,23611L,85595L,299789L,1018889L,3364983L,10823939L,33973701L,104224215L,313017236L,921527638L,2662917595L,7561290034L,21119173722L,58077373552L,157382658382L,420599245799L,1109306162737L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A183950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A183950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A183950Inst : IEnumerable<long>
{
public static readonly long[] Value=A183950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A183950.Bytes);
public long this[int i]=>Value[i];

public static A183950Inst Instance=new A183950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A183949
{
public static readonly long[] Value={ 1L,2L,4L,14L,53L,180L,656L,2195L,7250L,23044L,71123L,213368L,624425L,1784399L,4986210L,13657266L,36691985L,96863639L,251472815L,642811767L,1619203005L,4022796235L,9864987052L,23894800443L,57205375668L,135438579331L,317296680619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A183949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A183949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A183949Inst : IEnumerable<long>
{
public static readonly long[] Value=A183949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A183949.Bytes);
public long this[int i]=>Value[i];

public static A183949Inst Instance=new A183949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A183948
{
public static readonly long[] Value={ 1L,2L,3L,8L,27L,78L,219L,649L,1805L,4987L,13179L,34331L,87203L,217281L,532073L,1278041L,3025466L,7046194L,16192534L,36706373L,82197783L,181900279L,398099637L,862217855L,1848842707L,3927404946L,8267742253L,17257223344L,35726693834L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A183948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A183948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A183948Inst : IEnumerable<long>
{
public static readonly long[] Value=A183948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A183948.Bytes);
public long this[int i]=>Value[i];

public static A183948Inst Instance=new A183948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A183899
{
public static readonly long[] Value={ 1L,5L,66L,174L,329L,539L,815L,1169L,1614L,2164L,2834L,3640L,4599L,5729L,7049L,8579L,10340L,12354L,14644L,17234L,20149L,23415L,27059L,31109L,35594L,40544L,45990L,51964L,58499L,65629L,73389L,81815L,90944L,100814L,111464L,122934L,135265L,148499L,162679L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A183899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A183899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A183899Inst : IEnumerable<long>
{
public static readonly long[] Value=A183899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A183899.Bytes);
public long this[int i]=>Value[i];

public static A183899Inst Instance=new A183899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A183898
{
public static readonly long[] Value={ 5L,14L,38L,70L,111L,162L,224L,298L,385L,486L,602L,734L,883L,1050L,1236L,1442L,1669L,1918L,2190L,2486L,2807L,3154L,3528L,3930L,4361L,4822L,5314L,5838L,6395L,6986L,7612L,8274L,8973L,9710L,10486L,11302L,12159L,13058L,14000L,14986L,16017L,17094L,18218L,19390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A183898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A183898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A183898Inst : IEnumerable<long>
{
public static readonly long[] Value=A183898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A183898.Bytes);
public long this[int i]=>Value[i];

public static A183898Inst Instance=new A183898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A183897
{
public static readonly long[] Value={ 1L,7L,17L,25L,34L,44L,55L,67L,80L,94L,109L,125L,142L,160L,179L,199L,220L,242L,265L,289L,314L,340L,367L,395L,424L,454L,485L,517L,550L,584L,619L,655L,692L,730L,769L,809L,850L,892L,935L,979L,1024L,1070L,1117L,1165L,1214L,1264L,1315L,1367L,1420L,1474L,1529L,1585L,1642L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A183897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A183897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A183897Inst : IEnumerable<long>
{
public static readonly long[] Value=A183897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A183897.Bytes);
public long this[int i]=>Value[i];

public static A183897Inst Instance=new A183897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A183896
{
public static readonly BigInteger[] Value={ 0L,-1L,-2L,0L,0L,-128L,-1024L,0L,0L,-4194304L,-134217728L,0L,0L,-35184372088832L,-4503599627370496L,0L,0L,BigInteger.Parse("-75557863725914323419136"),BigInteger.Parse("-38685626227668133590597632"),0L,0L,BigInteger.Parse("-41538374868278621028243970633760768"),BigInteger.Parse("-85070591730234615865843651857942052864"),0L };
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
public class A183896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A183896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A183896Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A183896.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A183896.Bytes);
public BigInteger this[int i]=>Value[i];

public static A183896Inst Instance=new A183896Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}