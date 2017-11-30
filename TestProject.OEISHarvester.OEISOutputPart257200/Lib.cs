using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A141134
{
public static readonly long[] Value={ 1L,-8L,8L,1L,1L,-16L,16L,1L,1L,-24L,24L,1L,1L,-32L,32L,1L,1L,-40L,40L,1L,1L,-48L,48L,1L,1L,-56L,56L,1L,1L,-64L,64L,1L,1L,-72L,72L,1L,1L,-80L,80L,1L,1L,-88L,88L,1L,1L,-96L,96L,1L,1L,-104L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141134Inst : IEnumerable<long>
{
public static readonly long[] Value=A141134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141134.Bytes);
public long this[int i]=>Value[i];

public static A141134Inst Instance=new A141134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141135
{
public static readonly long[] Value={ 5L,9L,13L,17L,21L,24L,28L,32L,36L,39L,43L,47L,50L,54L,58L,61L,65L,69L,72L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141135Inst : IEnumerable<long>
{
public static readonly long[] Value=A141135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141135.Bytes);
public long this[int i]=>Value[i];

public static A141135Inst Instance=new A141135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141136
{
public static readonly long[] Value={ 1L,2L,6L,28L,52L,112L,172L,270L,316L,420L,592L,700L,910L,1060L,1150L,1290L,1510L,1782L,1830L,2212L,2376L,2472L,2740L,2998L,3256L,3630L,3930L,4078L,4270L,4390L,4546L,5350L,5590L,5866L,6100L,6658L,6802L,7186L,7602L,7828L,8218L,8520L,8712L,9310L,9438L,9732L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141136Inst : IEnumerable<long>
{
public static readonly long[] Value=A141136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141136.Bytes);
public long this[int i]=>Value[i];

public static A141136Inst Instance=new A141136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141137
{
public static readonly long[] Value={ 8539786L,12813274L,17340938L,33940178L,64132426L,89733106L,95173786L,187473826L,203211098L,234735586L,353686906L,799171066L,919831058L,1188287794L,1955272906L,2166139898L,2309861746L,2864860298L,3871638242L,5313594466L,5867301826L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141137Inst : IEnumerable<long>
{
public static readonly long[] Value=A141137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141137.Bytes);
public long this[int i]=>Value[i];

public static A141137Inst Instance=new A141137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141138
{
public static readonly long[] Value={ 1L,2L,4L,10L,16L,30L,40L,58L,66L,82L,108L,126L,156L,178L,190L,210L,240L,276L,282L,330L,352L,366L,400L,430L,460L,508L,546L,562L,586L,598L,616L,708L,738L,772L,796L,858L,876L,918L,966L,990L,1030L,1062L,1086L,1152L,1170L,1200L,1216L,1296L,1408L,1432L,1446L,1470L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141138Inst : IEnumerable<long>
{
public static readonly long[] Value=A141138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141138.Bytes);
public long this[int i]=>Value[i];

public static A141138Inst Instance=new A141138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141139
{
public static readonly long[] Value={ 1L,2L,150L,862L,4210L,6688L,12496L,15496L,24420L,40086L,43206L,67138L,83046L,88426L,102646L,133998L,161092L,169986L,202966L,235288L,243262L,279816L,305068L,346168L,394812L,438568L,454500L,481020L,498936L,521860L,633160L,670728L,715698L,741400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141139Inst : IEnumerable<long>
{
public static readonly long[] Value=A141139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141139.Bytes);
public long this[int i]=>Value[i];

public static A141139Inst Instance=new A141139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141140
{
public static readonly BigInteger[] Value={ 1L,1L,-2L,10L,-62L,466L,-4004L,37774L,-383042L,4120768L,-46601144L,550296628L,-6751738736L,85742962300L,-1123702072256L,15161509999324L,-210202294372118L,2989858353554554L,-43572404751879032L,649889656256427742L,BigInteger.Parse("-9911173481433673436") };
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
public class A141140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141140Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A141140.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A141140.Bytes);
public BigInteger this[int i]=>Value[i];

public static A141140Inst Instance=new A141140Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141141
{
public static readonly BigInteger[] Value={ 1L,2L,12L,114L,1435L,22219L,406441L,8559852L,203792337L,5409449156L,158350300141L,5066765087000L,175908765569628L,6585443884172129L,264428161094825151L,11335716352419699208UL,BigInteger.Parse("516717363793695685925"),BigInteger.Parse("24955728581736822645816") };
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
public class A141141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141141Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A141141.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A141141.Bytes);
public BigInteger this[int i]=>Value[i];

public static A141141Inst Instance=new A141141Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141142
{
public static readonly BigInteger[] Value={ -1L,2L,-4L,44L,-104L,40L,-7648L,2848L,-31712L,23429344L,-89072576L,1441952704L,-893393408L,9352282112L,-11547336704L,314833934543872L,-886909037097472L,8407858707080704L,-3185585650598165504L,476968653230369792L,-4605749416183789568L,BigInteger.Parse("11898401315301146359808"),BigInteger.Parse("-282034907680992595910656"),BigInteger.Parse("1032668724971184398336"),BigInteger.Parse("-2345904699036953797820416") };
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
public class A141142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141142Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A141142.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A141142.Bytes);
public BigInteger this[int i]=>Value[i];

public static A141142Inst Instance=new A141142Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141143
{
public static readonly BigInteger[] Value={ 1L,3L,9L,135L,405L,189L,42525L,18225L,229635L,189448875L,795685275L,14105329875L,9499507875L,107417512125L,142492618125L,4154372281434375L,12463116844303125L,125364292963284375L,BigInteger.Parse("50235263108858953125"),7931883648767203125L,BigInteger.Parse("80559094658206539375"),BigInteger.Parse("218372688734209869234375"),BigInteger.Parse("5419613093130844936453125"),BigInteger.Parse("20735910965022363235125") };
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
public class A141143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141143Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A141143.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A141143.Bytes);
public BigInteger this[int i]=>Value[i];

public static A141143Inst Instance=new A141143Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141240
{
public static readonly long[] Value={ 1L,11L,4L,15L,95L,26L,87L,634L,939L,10386L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141240Inst : IEnumerable<long>
{
public static readonly long[] Value=A141240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141240.Bytes);
public long this[int i]=>Value[i];

public static A141240Inst Instance=new A141240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141241
{
public static readonly long[] Value={ 1L,4L,4L,4L,6L,4L,4L,6L,6L,4L,4L,8L,4L,4L,6L,8L,6L,4L,4L,4L,9L,4L,4L,8L,8L,6L,6L,4L,10L,6L,4L,6L,8L,4L,8L,4L,4L,12L,4L,6L,4L,8L,6L,4L,8L,12L,4L,6L,6L,4L,8L,10L,4L,12L,4L,4L,4L,8L,12L,4L,6L,4L,4L,4L,12L,6L,6L,9L,8L,8L,8L,4L,12L,8L,4L,10L,8L,4L,6L,6L,4L,4L,16L,4L,4L,6L,4L,12L,8L,4L,8L,12L,4L,4L,8L,8L,8L,12L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141241Inst : IEnumerable<long>
{
public static readonly long[] Value=A141241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141241.Bytes);
public long this[int i]=>Value[i];

public static A141241Inst Instance=new A141241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141242
{
public static readonly long[] Value={ 2L,2L,3L,2L,2L,3L,2L,2L,5L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,7L,2L,2L,2L,2L,5L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141242Inst : IEnumerable<long>
{
public static readonly long[] Value=A141242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141242.Bytes);
public long this[int i]=>Value[i];

public static A141242Inst Instance=new A141242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141243
{
public static readonly BigInteger[] Value={ 1L,2L,16L,94L,1365L,55213L,3368146L,394631712L,101693175442L,50929053498909L,48988729226134301L,BigInteger.Parse("96325314726538906164"),BigInteger.Parse("375615195988659173454092"),BigInteger.Parse("2933480442104347575000834468"),BigInteger.Parse("45480806737377995771543610802659"),BigInteger.Parse("1422902021111889804120495149240353936") };
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
public class A141243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141243Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A141243.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A141243.Bytes);
public BigInteger this[int i]=>Value[i];

public static A141243Inst Instance=new A141243Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141244
{
public static readonly long[] Value={ 0L,0L,1L,1L,5L,5L,11L,11L,93L,93L,193L,193L,793L,793L,1619L,1619L,26333L,26333L,53381L,53381L,215955L,215955L,436109L,436109L,3518265L,3518265L,7088533L,7088533L,28539857L,28539857L,57414019L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141244Inst : IEnumerable<long>
{
public static readonly long[] Value=A141244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141244.Bytes);
public long this[int i]=>Value[i];

public static A141244Inst Instance=new A141244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141245
{
public static readonly long[] Value={ 1L,3L,3L,13L,13L,27L,27L,221L,221L,449L,449L,1817L,1817L,3667L,3667L,59101L,59101L,118917L,118917L,478099L,478099L,960397L,960397L,7712569L,7712569L,15477141L,15477141L,62094289L,62094289L,124522883L,124522883L,3994427101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141245Inst : IEnumerable<long>
{
public static readonly long[] Value=A141245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141245.Bytes);
public long this[int i]=>Value[i];

public static A141245Inst Instance=new A141245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141246
{
public static readonly long[] Value={ 5L,11L,13L,17L,19L,23L,29L,47L,73L,83L,89L,103L,109L,113L,139L,173L,181L,199L,271L,283L,293L,313L,383L,389L,467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141246Inst : IEnumerable<long>
{
public static readonly long[] Value=A141246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141246.Bytes);
public long this[int i]=>Value[i];

public static A141246Inst Instance=new A141246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141247
{
public static readonly long[] Value={ 1L,4L,6L,10L,14L,22L,26L,38L,46L,58L,66L,86L,94L,118L,130L,146L,162L,194L,206L,241L,257L,282L,302L,346L,362L,401L,426L,462L,486L,542L,558L,609L,641L,690L,722L,770L,794L,861L,899L,950L,982L,1062L,1086L,1157L,1201L,1258L,1302L,1393L,1425L,1501L,1546L,1613L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141247Inst : IEnumerable<long>
{
public static readonly long[] Value=A141247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141247.Bytes);
public long this[int i]=>Value[i];

public static A141247Inst Instance=new A141247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141248
{
public static readonly long[] Value={ 1L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,36L,1L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,9L,4L,4L,52L,4L,4L,8L,4L,4L,44L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,12L,4L,4L,4L,4L,1L,4L,4L,4L,4L,4L,4L,4L,1L,4L,4L,4L,20L,4L,4L,4L,4L,8L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141248Inst : IEnumerable<long>
{
public static readonly long[] Value=A141248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141248.Bytes);
public long this[int i]=>Value[i];

public static A141248Inst Instance=new A141248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141249
{
public static readonly long[] Value={ 1L,21L,33L,45L,73L,81L,193L,201L,241L,273L,313L,381L,421L,445L,453L,661L,693L,861L,885L,913L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141249Inst : IEnumerable<long>
{
public static readonly long[] Value=A141249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141249.Bytes);
public long this[int i]=>Value[i];

public static A141249Inst Instance=new A141249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141250
{
public static readonly long[] Value={ 11L,17L,23L,37L,41L,97L,101L,121L,137L,157L,191L,211L,223L,227L,331L,347L,431L,443L,457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141250Inst : IEnumerable<long>
{
public static readonly long[] Value=A141250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141250.Bytes);
public long this[int i]=>Value[i];

public static A141250Inst Instance=new A141250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141251
{
public static readonly long[] Value={ 3L,5L,9L,1L,1L,2L,1L,4L,7L,6L,6L,6L,8L,6L,2L,2L,1L,3L,6L,6L,4L,9L,2L,2L,2L,9L,2L,5L,7L,4L,1L,6L,3L,4L,8L,4L,2L,1L,0L,3L,0L,7L,5L,4L,0L,1L,5L,9L,2L,7L,8L,6L,9L,1L,9L,0L,4L,5L,2L,9L,8L,7L,3L,1L,9L,9L,2L,2L,6L,5L,4L,9L,8L,4L,4L,0L,3L,1L,6L,3L,7L,6L,6L,0L,2L,3L,6L,4L,1L,7L,7L,4L,6L,5L,2L,4L,5L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141251Inst : IEnumerable<long>
{
public static readonly long[] Value=A141251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141251.Bytes);
public long this[int i]=>Value[i];

public static A141251Inst Instance=new A141251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141252
{
public static readonly long[] Value={ 3L,1L,8L,0L,9L,6L,6L,0L,8L,6L,6L,3L,8L,9L,4L,3L,2L,1L,0L,6L,8L,3L,5L,8L,6L,4L,0L,3L,5L,4L,7L,5L,7L,5L,0L,0L,5L,1L,6L,0L,8L,7L,8L,7L,4L,9L,3L,9L,6L,5L,7L,5L,4L,3L,2L,0L,5L,3L,9L,6L,4L,8L,2L,6L,9L,7L,0L,2L,5L,4L,7L,1L,0L,0L,1L,2L,2L,5L,9L,1L,9L,4L,0L,2L,8L,3L,6L,6L,6L,3L,4L,8L,8L,1L,2L,5L,3L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141252Inst : IEnumerable<long>
{
public static readonly long[] Value=A141252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141252.Bytes);
public long this[int i]=>Value[i];

public static A141252Inst Instance=new A141252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141253
{
public static readonly long[] Value={ 1L,2L,6L,24L,100L,408L,1631L,6440L,25263L,98790L,385803L,1506156L,5881057L,22974406L,89804910L,351279584L,1375035208L,5386203792L,21113167346L,82816267480L,325055630634L,1276635121388L,5016837177052L,19725798613152L,77601159558800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141253Inst : IEnumerable<long>
{
public static readonly long[] Value=A141253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141253.Bytes);
public long this[int i]=>Value[i];

public static A141253Inst Instance=new A141253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141254
{
public static readonly long[] Value={ 1L,2L,6L,24L,110L,510L,2268L,9632L,39492L,158190L,624745L,2447808L,9552244L,37214086L,144932760L,564676096L,2201735552L,8592780798L,33568042425L,131261440720L,513747571680L,2012524130518L,7890178181831L,30957296889264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141254Inst : IEnumerable<long>
{
public static readonly long[] Value=A141254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141254.Bytes);
public long this[int i]=>Value[i];

public static A141254Inst Instance=new A141254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141255
{
public static readonly long[] Value={ 0L,6L,28L,86L,200L,418L,748L,1282L,2040L,3106L,4492L,6394L,8744L,11822L,15556L,20074L,25456L,32086L,39724L,48934L,59456L,71554L,85252L,101250L,119040L,139350L,161932L,187254L,215136L,246690L,280916L,319346L,361328L,407302L,457180L,511714L,570232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141255Inst : IEnumerable<long>
{
public static readonly long[] Value=A141255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141255.Bytes);
public long this[int i]=>Value[i];

public static A141255Inst Instance=new A141255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141288
{
public static readonly long[] Value={ 1L,1L,2L,6L,12L,84L,252L,252L,504L,2520L,17640L,52920L,52920L,52920L,52920L,476280L,952560L,952560L,4762800L,61916400L,185749200L,928746000L,928746000L,928746000L,928746000L,4643730000L,13931190000L,13931190000L,13931190000L,13931190000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141288Inst : IEnumerable<long>
{
public static readonly long[] Value=A141288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141288.Bytes);
public long this[int i]=>Value[i];

public static A141288Inst Instance=new A141288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141289
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,2L,3L,1L,2L,1L,1L,2L,3L,4L,1L,1L,2L,3L,1L,2L,1L,1L,2L,3L,4L,5L,1L,2L,1L,1L,2L,3L,4L,1L,1L,2L,3L,1L,2L,1L,1L,2L,3L,4L,5L,6L,1L,1L,2L,3L,1L,2L,1L,1L,2L,3L,4L,5L,1L,2L,1L,1L,2L,3L,4L,1L,1L,2L,3L,1L,2L,1L,1L,2L,3L,4L,5L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141289Inst : IEnumerable<long>
{
public static readonly long[] Value=A141289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141289.Bytes);
public long this[int i]=>Value[i];

public static A141289Inst Instance=new A141289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141290
{
public static readonly long[] Value={ 1L,3L,4L,5L,12L,16L,7L,20L,48L,64L,9L,28L,80L,112L,256L,11L,36L,112L,320L,768L,1024L,13L,44L,144L,448L,1280L,3072L,4096L,15L,52L,176L,576L,1792L,5120L,12288L,6384L,17L,60L,208L,704L,2304L,7168L,20480L,49152L,65536L,19L,68L,240L,832L,2816L,9216L,28672L,81920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141290Inst : IEnumerable<long>
{
public static readonly long[] Value=A141290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141290.Bytes);
public long this[int i]=>Value[i];

public static A141290Inst Instance=new A141290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141291
{
public static readonly long[] Value={ 0L,1L,7L,33L,139L,565L,2271L,9097L,36403L,145629L,582535L,2330161L,9320667L,37282693L,149130799L,596523225L,2386092931L,9544371757L,38177487063L,152709948289L,610839793195L,2443359172821L,9773436691327L,39093746765353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141291Inst : IEnumerable<long>
{
public static readonly long[] Value=A141291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141291.Bytes);
public long this[int i]=>Value[i];

public static A141291Inst Instance=new A141291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141292
{
public static readonly long[] Value={ 1L,5L,9L,12L,15L,19L,22L,25L,28L,31L,35L,38L,42L,47L,50L,53L,56L,60L,63L,67L,72L,76L,79L,82L,85L,89L,93L,100L,103L,106L,109L,113L,117L,121L,126L,130L,133L,136L,139L,143L,147L,156L,160L,163L,166L,169L,174L,177L,182L,186L,189L,192L,196L,202L,205L,214L,217L,220L,223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141292Inst : IEnumerable<long>
{
public static readonly long[] Value=A141292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141292.Bytes);
public long this[int i]=>Value[i];

public static A141292Inst Instance=new A141292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141293
{
public static readonly long[] Value={ 13L,29L,41L,53L,61L,73L,89L,97L,109L,113L,137L,149L,157L,173L,181L,193L,229L,233L,241L,269L,277L,281L,293L,313L,317L,337L,349L,353L,373L,389L,397L,409L,421L,433L,449L,457L,461L,509L,521L,541L,557L,569L,593L,601L,613L,617L,641L,653L,661L,673L,701L,709L,733L,757L,761L,769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141293Inst : IEnumerable<long>
{
public static readonly long[] Value=A141293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141293.Bytes);
public long this[int i]=>Value[i];

public static A141293Inst Instance=new A141293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141294
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,1L,4L,2L,1L,1L,5L,1L,1L,1L,1L,6L,4L,2L,1L,1L,1L,7L,1L,1L,1L,1L,1L,1L,8L,4L,2L,2L,1L,1L,1L,1L,9L,3L,3L,1L,1L,1L,1L,1L,1L,10L,6L,2L,2L,2L,1L,1L,1L,1L,1L,11L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,12L,8L,6L,4L,2L,2L,1L,1L,1L,1L,1L,1L,13L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,14L,8L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141294Inst : IEnumerable<long>
{
public static readonly long[] Value=A141294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141294.Bytes);
public long this[int i]=>Value[i];

public static A141294Inst Instance=new A141294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141295
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,3L,7L,5L,5L,3L,11L,7L,13L,3L,5L,5L,17L,3L,19L,5L,5L,3L,23L,8L,9L,3L,5L,5L,29L,3L,31L,5L,5L,3L,9L,7L,37L,3L,5L,5L,41L,3L,43L,5L,5L,3L,47L,8L,13L,3L,5L,5L,53L,3L,9L,5L,5L,3L,59L,7L,61L,3L,5L,5L,9L,3L,67L,5L,5L,3L,71L,9L,73L,3L,5L,5L,13L,3L,79L,5L,5L,3L,83L,7L,9L,3L,5L,5L,89L,3L,13L,5L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141295Inst : IEnumerable<long>
{
public static readonly long[] Value=A141295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141295.Bytes);
public long this[int i]=>Value[i];

public static A141295Inst Instance=new A141295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141296
{
public static readonly long[] Value={ 846493L,1407187L,1427963L,3675277L,3750833L,4266673L,4331647L,4346767L,4348307L,4841693L,5952077L,6827237L,7421137L,7470143L,7684483L,7974143L,8569153L,8651543L,8976713L,9073783L,9552083L,11245763L,11459317L,12348997L,12524503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141296Inst : IEnumerable<long>
{
public static readonly long[] Value=A141296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141296.Bytes);
public long this[int i]=>Value[i];

public static A141296Inst Instance=new A141296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141297
{
public static readonly long[] Value={ 1L,3L,2L,5L,5L,5L,3L,7L,8L,7L,8L,8L,8L,7L,4L,9L,11L,11L,12L,11L,9L,11L,11L,11L,12L,11L,11L,11L,11L,9L,5L,11L,14L,15L,16L,14L,15L,16L,16L,15L,15L,11L,14L,16L,14L,15L,14L,14L,16L,16L,16L,16L,14L,14L,15L,15L,16L,15L,15L,14L,14L,11L,6L,13L,17L,19L,20L,19L,20L,21L,21L,19L,17L,19L,21L,20L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141297Inst : IEnumerable<long>
{
public static readonly long[] Value=A141297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141297.Bytes);
public long this[int i]=>Value[i];

public static A141297Inst Instance=new A141297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141298
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,2L,2L,2L,3L,1L,2L,1L,2L,3L,3L,3L,3L,2L,3L,5L,3L,2L,3L,2L,3L,2L,3L,2L,3L,4L,4L,4L,4L,3L,5L,4L,3L,3L,4L,4L,7L,5L,3L,5L,4L,3L,4L,3L,3L,3L,3L,5L,5L,2L,4L,3L,4L,2L,4L,3L,4L,5L,5L,5L,5L,4L,5L,5L,4L,4L,5L,8L,5L,4L,5L,4L,4L,4L,5L,5L,5L,4L,7L,9L,5L,6L,4L,4L,5L,8L,4L,6L,5L,4L,5L,4L,4L,4L,5L,4L,5L,3L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141298Inst : IEnumerable<long>
{
public static readonly long[] Value=A141298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141298.Bytes);
public long this[int i]=>Value[i];

public static A141298Inst Instance=new A141298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141299
{
public static readonly long[] Value={ 0L,0L,2L,2L,2L,2L,5L,5L,4L,6L,3L,4L,3L,5L,9L,9L,7L,7L,5L,7L,11L,7L,6L,7L,5L,7L,6L,7L,6L,9L,14L,14L,11L,10L,8L,12L,10L,8L,8L,10L,10L,17L,12L,8L,12L,10L,10L,11L,8L,8L,8L,8L,12L,12L,8L,10L,8L,10L,8L,11L,10L,14L,20L,20L,16L,14L,12L,14L,13L,11L,11L,14L,19L,14L,11L,13L,11L,11L,12L,14L,13L,14L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141299Inst : IEnumerable<long>
{
public static readonly long[] Value=A141299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141299.Bytes);
public long this[int i]=>Value[i];

public static A141299Inst Instance=new A141299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141300
{
public static readonly long[] Value={ 1L,3L,1L,4L,4L,4L,1L,5L,6L,4L,7L,6L,7L,5L,1L,6L,8L,8L,10L,8L,4L,8L,9L,8L,10L,8L,9L,8L,9L,6L,1L,7L,10L,11L,13L,9L,11L,13L,13L,11L,11L,4L,9L,13L,9L,11L,11L,10L,13L,13L,13L,13L,9L,9L,13L,11L,13L,11L,13L,10L,11L,7L,1L,8L,12L,14L,16L,14L,15L,17L,17L,14L,9L,14L,17L,15L,17L,17L,16L,14L,15L,14L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141300Inst : IEnumerable<long>
{
public static readonly long[] Value=A141300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141300.Bytes);
public long this[int i]=>Value[i];

public static A141300Inst Instance=new A141300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141301
{
public static readonly long[] Value={ 61L,109L,181L,229L,241L,349L,409L,421L,541L,601L,661L,709L,769L,829L,1009L,1021L,1069L,1129L,1201L,1249L,1321L,1381L,1429L,1489L,1549L,1609L,1621L,1669L,1741L,1789L,1801L,1861L,2029L,2089L,2161L,2221L,2269L,2281L,2341L,2389L,2521L,2689L,2749L,3001L,3049L,3061L,3109L,3121L,3169L,3181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141301Inst : IEnumerable<long>
{
public static readonly long[] Value=A141301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141301.Bytes);
public long this[int i]=>Value[i];

public static A141301Inst Instance=new A141301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141302
{
public static readonly long[] Value={ 11L,59L,71L,131L,179L,191L,239L,251L,311L,359L,419L,431L,479L,491L,599L,659L,719L,839L,911L,971L,1019L,1031L,1091L,1151L,1259L,1319L,1439L,1451L,1499L,1511L,1559L,1571L,1619L,1811L,1871L,1931L,1979L,2039L,2099L,2111L,2339L,2351L,2399L,2411L,2459L,2531L,2579L,2591L,2699L,2711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141302Inst : IEnumerable<long>
{
public static readonly long[] Value=A141302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141302.Bytes);
public long this[int i]=>Value[i];

public static A141302Inst Instance=new A141302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141303
{
public static readonly long[] Value={ 2L,5L,17L,53L,113L,137L,173L,197L,233L,257L,293L,317L,353L,557L,593L,617L,653L,677L,773L,797L,857L,953L,977L,1013L,1097L,1193L,1217L,1277L,1373L,1433L,1493L,1553L,1613L,1637L,1697L,1733L,1877L,1913L,1973L,1997L,2153L,2213L,2237L,2273L,2297L,2333L,2357L,2393L,2417L,2477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141303Inst : IEnumerable<long>
{
public static readonly long[] Value=A141303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141303.Bytes);
public long this[int i]=>Value[i];

public static A141303Inst Instance=new A141303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141624
{
public static readonly long[] Value={ 2L,6L,6L,6L,6L,6L,-2L,6L,2L,-2L,2L,6L,6L,-6L,-6L,-18L,-18L,-14L,-14L,-18L,-18L,-22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141624Inst : IEnumerable<long>
{
public static readonly long[] Value=A141624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141624.Bytes);
public long this[int i]=>Value[i];

public static A141624Inst Instance=new A141624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141625
{
public static readonly BigInteger[] Value={ 1L,1L,3L,16L,121L,1196L,14593L,211884L,3564177L,68088880L,1454676641L,34335669820L,886637924569L,24846347615792L,750534094219393L,24299661162891796L,839155129170873505L,BigInteger.Parse("30780528267862736320"),BigInteger.Parse("1194857640269127135937") };
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
public class A141625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141625Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A141625.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A141625.Bytes);
public BigInteger this[int i]=>Value[i];

public static A141625Inst Instance=new A141625Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141626
{
public static readonly long[] Value={ 1L,1L,1L,7L,25L,121L,841L,9031L,74257L,779185L,9465841L,98157511L,1372854121L,19401758377L,301086307705L,5668190911111L,101297827616161L,1892733268852321L,38807453736318817L,751339911589120135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141626Inst : IEnumerable<long>
{
public static readonly long[] Value=A141626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141626.Bytes);
public long this[int i]=>Value[i];

public static A141626Inst Instance=new A141626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141627
{
public static readonly BigInteger[] Value={ 1L,1L,1L,7L,25L,101L,721L,8653L,66753L,574489L,7509601L,76972281L,938682625L,14560953109L,226747016497L,4226839991221L,73582415930881L,1133352458491185L,23260378180229569L,478118972286336241L,9648062520586144001UL,BigInteger.Parse("239696533730926824301"),BigInteger.Parse("6090975028325867045521") };
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
public class A141627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141627Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A141627.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A141627.Bytes);
public BigInteger this[int i]=>Value[i];

public static A141627Inst Instance=new A141627Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141628
{
public static readonly BigInteger[] Value={ 1L,1L,3L,16L,133L,1496L,21343L,371064L,7633641L,181891072L,4937228411L,150669126400L,5114378969965L,191400122127488L,7838565428874391L,349073700821172736L,16811407320683479633UL,BigInteger.Parse("871413633401197096960") };
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
public class A141628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141628Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A141628.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A141628.Bytes);
public BigInteger this[int i]=>Value[i];

public static A141628Inst Instance=new A141628Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141629
{
public static readonly long[] Value={ 3277L,4033L,838861L,85489L,80581L,130561L,104653L,20647621L,280601L,818201L,68719214593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141629Inst : IEnumerable<long>
{
public static readonly long[] Value=A141629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141629.Bytes);
public long this[int i]=>Value[i];

public static A141629Inst Instance=new A141629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141630
{
public static readonly long[] Value={ 1L,1L,3L,5L,13L,26L,66L,152L,366L,907L,2225L,6864L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141630Inst : IEnumerable<long>
{
public static readonly long[] Value=A141630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141630.Bytes);
public long this[int i]=>Value[i];

public static A141630Inst Instance=new A141630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141631
{
public static readonly long[] Value={ 2L,7L,18L,35L,58L,87L,122L,163L,210L,263L,322L,387L,458L,535L,618L,707L,802L,903L,1010L,1123L,1242L,1367L,1498L,1635L,1778L,1927L,2082L,2243L,2410L,2583L,2762L,2947L,3138L,3335L,3538L,3747L,3962L,4183L,4410L,4643L,4882L,5127L,5378L,5635L,5898L,6167L,6442L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141631Inst : IEnumerable<long>
{
public static readonly long[] Value=A141631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141631.Bytes);
public long this[int i]=>Value[i];

public static A141631Inst Instance=new A141631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141632
{
public static readonly long[] Value={ 1L,24L,27L,33L,35L,46L,48L,51L,57L,62L,65L,69L,74L,77L,82L,87L,88L,91L,95L,102L,105L,111L,112L,115L,116L,119L,121L,123L,125L,126L,132L,140L,141L,143L,144L,150L,153L,156L,158L,161L,162L,166L,169L,171L,175L,180L,183L,184L,185L,192L,195L,200L,202L,205L,206L,213L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141632Inst : IEnumerable<long>
{
public static readonly long[] Value=A141632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141632.Bytes);
public long this[int i]=>Value[i];

public static A141632Inst Instance=new A141632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141633
{
public static readonly long[] Value={ 2L,3L,7L,13L,17L,19L,23L,29L,31L,41L,43L,59L,61L,67L,73L,83L,101L,103L,107L,109L,113L,127L,163L,167L,179L,193L,199L,223L,233L,239L,241L,257L,281L,307L,311L,353L,373L,401L,409L,419L,443L,449L,461L,463L,487L,491L,499L,523L,541L,547L,569L,599L,607L,613L,659L,661L,677L,701L,709L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141633Inst : IEnumerable<long>
{
public static readonly long[] Value=A141633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141633.Bytes);
public long this[int i]=>Value[i];

public static A141633Inst Instance=new A141633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141634
{
public static readonly long[] Value={ 1L,24L,27L,33L,46L,48L,51L,62L,65L,69L,77L,82L,87L,91L,102L,105L,111L,115L,116L,119L,123L,126L,132L,141L,143L,144L,150L,153L,156L,158L,161L,162L,169L,175L,180L,183L,184L,192L,200L,202L,205L,206L,214L,216L,221L,228L,232L,234L,242L,243L,244L,246L,249L,252L,255L,258L,259L,265L,270L,272L,279L,286L,287L,288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141634Inst : IEnumerable<long>
{
public static readonly long[] Value=A141634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141634.Bytes);
public long this[int i]=>Value[i];

public static A141634Inst Instance=new A141634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141635
{
public static readonly long[] Value={ 1L,1L,1L,9L,9L,49L,91L,95L,35L,115L,117L,69L,143L,147L,159L,87L,25L,95L,195L,69L,215L,75L,57L,243L,249L,129L,265L,267L,135L,279L,35L,153L,39L,105L,161L,323L,329L,69L,117L,363L,387L,105L,423L,429L,217L,435L,437L,147L,225L,153L,93L,243L,245L,249L,125L,515L,87L,525L,527L,177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141635Inst : IEnumerable<long>
{
public static readonly long[] Value=A141635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141635.Bytes);
public long this[int i]=>Value[i];

public static A141635Inst Instance=new A141635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141636
{
public static readonly long[] Value={ 7L,11L,13L,17L,19L,31L,37L,43L,59L,61L,79L,83L,97L,109L,137L,149L,151L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L,251L,269L,293L,307L,313L,317L,337L,347L,349L,353L,373L,379L,383L,397L,419L,421L,431L,433L,443L,457L,461L,463L,467L,487L,491L,503L,509L,541L,547L,557L,563L,569L,571L,577L,587L,593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141636Inst : IEnumerable<long>
{
public static readonly long[] Value=A141636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141636.Bytes);
public long this[int i]=>Value[i];

public static A141636Inst Instance=new A141636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141637
{
public static readonly long[] Value={ 2L,5L,3L,3L,3L,13L,11L,17L,71L,29L,89L,103L,61L,31L,131L,151L,31L,173L,59L,199L,71L,31L,73L,229L,61L,271L,293L,151L,101L,103L,89L,181L,127L,197L,397L,137L,103L,431L,439L,149L,467L,131L,263L,181L,283L,293L,599L,619L,317L,367L,769L,257L,197L,263L,809L,271L,821L,167L,61L,433L,179L,449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141637Inst : IEnumerable<long>
{
public static readonly long[] Value=A141637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141637.Bytes);
public long this[int i]=>Value[i];

public static A141637Inst Instance=new A141637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141638
{
public static readonly long[] Value={ 35L,43L,47L,55L,63L,67L,71L,75L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141638Inst : IEnumerable<long>
{
public static readonly long[] Value=A141638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141638.Bytes);
public long this[int i]=>Value[i];

public static A141638Inst Instance=new A141638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141639
{
public static readonly long[] Value={ 5L,7L,11L,13L,17L,19L,31L,37L,41L,43L,53L,59L,61L,71L,73L,79L,83L,89L,97L,103L,109L,113L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L,251L,257L,263L,269L,271L,281L,293L,307L,313L,317L,337L,347L,349L,353L,359L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141639Inst : IEnumerable<long>
{
public static readonly long[] Value=A141639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141639.Bytes);
public long this[int i]=>Value[i];

public static A141639Inst Instance=new A141639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141656
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,17L,11L,13L,13L,17L,19L,67L,19L,23L,29L,31L,53L,79L,31L,37L,41L,53L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141656Inst : IEnumerable<long>
{
public static readonly long[] Value=A141656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141656.Bytes);
public long this[int i]=>Value[i];

public static A141656Inst Instance=new A141656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141657
{
public static readonly long[] Value={ 2L,3L,7L,11L,13L,17L,19L,23L,71L,71L,83L,83L,89L,101L,103L,127L,163L,167L,191L,193L,199L,239L,239L,251L,263L,277L,307L,307L,307L,317L,331L,337L,389L,443L,463L,487L,509L,509L,557L,659L,691L,787L,797L,863L,881L,883L,887L,887L,953L,971L,977L,991L,1019L,1063L,1069L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141657Inst : IEnumerable<long>
{
public static readonly long[] Value=A141657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141657.Bytes);
public long this[int i]=>Value[i];

public static A141657Inst Instance=new A141657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141658
{
public static readonly long[] Value={ 2L,3L,2L,5L,4L,3L,7L,6L,5L,3L,11L,10L,9L,6L,10L,13L,12L,11L,9L,12L,12L,17L,16L,15L,13L,16L,16L,14L,19L,18L,17L,15L,18L,18L,16L,14L,23L,22L,21L,19L,22L,22L,20L,18L,22L,29L,28L,27L,25L,28L,28L,26L,24L,28L,27L,31L,30L,29L,27L,30L,30L,28L,26L,30L,29L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141658Inst : IEnumerable<long>
{
public static readonly long[] Value=A141658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141658.Bytes);
public long this[int i]=>Value[i];

public static A141658Inst Instance=new A141658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141659
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,0L,3L,0L,0L,0L,7L,0L,0L,0L,8L,11L,3L,12L,9L,0L,6L,5L,5L,1L,13L,8L,8L,5L,11L,5L,17L,15L,9L,6L,3L,8L,10L,2L,2L,1L,14L,12L,6L,12L,9L,19L,7L,15L,26L,8L,14L,3L,12L,10L,1L,21L,10L,20L,12L,10L,9L,15L,28L,26L,21L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141659Inst : IEnumerable<long>
{
public static readonly long[] Value=A141659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141659.Bytes);
public long this[int i]=>Value[i];

public static A141659Inst Instance=new A141659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141660
{
public static readonly long[] Value={ 1L,0L,2L,0L,2L,4L,0L,2L,16L,8L,0L,2L,44L,88L,16L,0L,2L,104L,528L,416L,32L,0L,2L,228L,2416L,4832L,1824L,64L,0L,2L,480L,9528L,38656L,38112L,7680L,128L,0L,2L,988L,34344L,249904L,499808L,274752L,31616L,256L,0L,2L,2008L,116864L,1411744L,4998080L,5646976L,1869824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141660Inst : IEnumerable<long>
{
public static readonly long[] Value=A141660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141660.Bytes);
public long this[int i]=>Value[i];

public static A141660Inst Instance=new A141660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141661
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,0L,2L,2L,0L,2L,3L,0L,0L,0L,1L,5L,0L,0L,7L,7L,1L,7L,0L,0L,0L,8L,9L,1L,11L,3L,12L,9L,0L,6L,11L,11L,0L,10L,0L,1L,0L,8L,5L,10L,11L,5L,5L,1L,13L,8L,8L,5L,0L,5L,3L,11L,5L,17L,15L,9L,6L,3L,8L,13L,17L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141661Inst : IEnumerable<long>
{
public static readonly long[] Value=A141661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141661.Bytes);
public long this[int i]=>Value[i];

public static A141661Inst Instance=new A141661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141662
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,2L,3L,2L,1L,6L,4L,3L,0L,5L,12L,5L,4L,1L,4L,11L,20L,6L,5L,2L,3L,10L,19L,30L,7L,6L,3L,2L,9L,18L,29L,42L,8L,7L,4L,1L,8L,17L,28L,41L,56L,9L,8L,5L,0L,7L,16L,27L,40L,55L,72L,10L,9L,6L,1L,6L,15L,26L,39L,54L,71L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141662Inst : IEnumerable<long>
{
public static readonly long[] Value=A141662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141662.Bytes);
public long this[int i]=>Value[i];

public static A141662Inst Instance=new A141662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141663
{
public static readonly long[] Value={ 2L,3L,2L,5L,4L,1L,7L,6L,3L,2L,11L,10L,7L,2L,5L,13L,12L,9L,4L,3L,12L,17L,16L,13L,8L,1L,8L,19L,19L,18L,15L,10L,3L,6L,17L,30L,23L,22L,19L,14L,7L,2L,13L,26L,41L,29L,28L,25L,20L,13L,4L,7L,20L,35L,52L,31L,30L,27L,22L,15L,6L,5L,18L,33L,50L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141663Inst : IEnumerable<long>
{
public static readonly long[] Value=A141663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141663.Bytes);
public long this[int i]=>Value[i];

public static A141663Inst Instance=new A141663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141664
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,0L,-1L,1L,0L,0L,-1L,-1L,-1L,0L,1L,0L,0L,-1L,-1L,-2L,-1L,-1L,0L,0L,1L,1L,0L,0L,-1L,-1L,-2L,-2L,-2L,-1L,-1L,1L,1L,1L,1L,1L,0L,1L,0L,0L,-1L,-1L,-2L,-2L,-3L,-2L,-2L,0L,0L,2L,2L,3L,2L,2L,1L,1L,0L,0L,-1L,1L,0L,0L,-1L,-1L,-2L,-2L,-3L,-3L,-3L,-1L,-1L,1L,2L,4L,4L,5L,4L,4L,3L,2L,0L,0L,-1L,-1L,-1L,-1L,-1L,0L,1L,0L,0L,-1L,-1L,-2L,-2L,-3L,-3L,-4L,-2L,-2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141664Inst : IEnumerable<long>
{
public static readonly long[] Value=A141664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141664.Bytes);
public long this[int i]=>Value[i];

public static A141664Inst Instance=new A141664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141665
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,-1L,1L,0L,-3L,0L,1L,0L,-6L,0L,1L,1L,0L,-10L,0L,5L,0L,1L,0L,-15L,0L,15L,0L,-1L,1L,0L,-21L,0L,35L,0L,-7L,0L,1L,0L,-28L,0L,70L,0L,-28L,0L,1L,1L,0L,-36L,0L,126L,0L,-84L,0L,9L,0L,1L,0L,-45L,0L,210L,0L,-210L,0L,45L,0L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141665Inst : IEnumerable<long>
{
public static readonly long[] Value=A141665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141665.Bytes);
public long this[int i]=>Value[i];

public static A141665Inst Instance=new A141665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141666
{
public static readonly long[] Value={ 1L,4L,4L,4L,16L,4L,0L,16L,16L,0L,4L,0L,16L,0L,4L,8L,16L,0L,0L,16L,8L,0L,32L,16L,0L,16L,32L,0L,0L,0L,32L,0L,0L,32L,0L,0L,4L,0L,0L,0L,16L,0L,0L,0L,4L,4L,16L,0L,0L,32L,32L,0L,0L,16L,4L,8L,16L,16L,0L,0L,64L,0L,0L,16L,16L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141666Inst : IEnumerable<long>
{
public static readonly long[] Value=A141666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141666.Bytes);
public long this[int i]=>Value[i];

public static A141666Inst Instance=new A141666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141667
{
public static readonly long[] Value={ 1L,4L,6L,15L,14L,44L,30L,88L,90L,168L,112L,462L,202L,540L,704L,1155L,594L,2310L,980L,3762L,3168L,4008L,2510L,12600L,5874L,9744L,12040L,22308L,9130L,44832L,13684L,50094L,40572L,49240L,59532L,161793L,43274L,104060L,124740L,298704L,89166L,425392L,126522L,451050L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141667Inst : IEnumerable<long>
{
public static readonly long[] Value=A141667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141667.Bytes);
public long this[int i]=>Value[i];

public static A141667Inst Instance=new A141667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141668
{
public static readonly long[] Value={ 0L,0L,2L,4L,12L,12L,40L,28L,84L,87L,164L,110L,456L,200L,536L,700L,1150L,592L,2304L,978L,3756L,3164L,4004L,2508L,12592L,5871L,9740L,12036L,22302L,9128L,44824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141668Inst : IEnumerable<long>
{
public static readonly long[] Value=A141668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141668.Bytes);
public long this[int i]=>Value[i];

public static A141668Inst Instance=new A141668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141669
{
public static readonly long[] Value={ 0L,0L,0L,1L,4L,7L,8L,44L,43L,140L,245L,616L,615L,2268L,3069L,3712L,10800L,22271L,31609L,26378L,59973L,164939L,560722L,250906L,1339811L,888569L,2348567L,3092808L,11669193L,7541818L,8565719L,24997918L,16028067L,20502521L,26162831L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141669Inst : IEnumerable<long>
{
public static readonly long[] Value=A141669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141669.Bytes);
public long this[int i]=>Value[i];

public static A141669Inst Instance=new A141669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141670
{
public static readonly long[] Value={ 0L,2L,3L,10L,7L,33L,15L,66L,60L,126L,56L,385L,101L,405L,528L,924L,297L,1925L,490L,3135L,2376L,3006L,1255L,11025L,3916L,7308L,9030L,18590L,4565L,39228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141670Inst : IEnumerable<long>
{
public static readonly long[] Value=A141670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141670.Bytes);
public long this[int i]=>Value[i];

public static A141670Inst Instance=new A141670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141671
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,1L,4L,3L,0L,1L,5L,4L,2L,0L,1L,6L,5L,0L,0L,0L,1L,7L,6L,3L,2L,0L,0L,1L,8L,7L,0L,0L,0L,0L,0L,1L,9L,8L,4L,0L,2L,0L,0L,0L,1L,10L,9L,0L,3L,0L,0L,0L,0L,0L,1L,11L,10L,5L,0L,0L,2L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141671Inst : IEnumerable<long>
{
public static readonly long[] Value=A141671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141671.Bytes);
public long this[int i]=>Value[i];

public static A141671Inst Instance=new A141671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141704
{
public static readonly long[] Value={ 1L,2L,3L,4L,11L,14L,47L,193L,331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141704Inst : IEnumerable<long>
{
public static readonly long[] Value=A141704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141704.Bytes);
public long this[int i]=>Value[i];

public static A141704Inst Instance=new A141704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141705
{
public static readonly long[] Value={ 0L,561L,1105L,1729L,0L,29341L,162401L,334153L,1615681L,3581761L,399001L,294409L,252601L,1152271L,104569501L,2508013L,178837201L,6189121L,10267951L,10024561L,14469841L,4461725581L,985052881L,19384289L,23382529L,3828001L,90698401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141705Inst : IEnumerable<long>
{
public static readonly long[] Value=A141705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141705.Bytes);
public long this[int i]=>Value[i];

public static A141705Inst Instance=new A141705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141706
{
public static readonly long[] Value={ 0L,561L,10585L,52633L,0L,530881L,7207201L,1024651L,1615681L,5444489L,471905281L,36765901L,2489462641L,564651361L,958762729L,17316001L,178837201L,1574601601L,7991602081L,597717121L,962442001L,4461725581L,167385219121L,43286923681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141706Inst : IEnumerable<long>
{
public static readonly long[] Value=A141706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141706.Bytes);
public long this[int i]=>Value[i];

public static A141706Inst Instance=new A141706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141707
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,5L,1L,1L,27L,1L,89L,13L,1L,49L,1L,1L,13L,69L,5L,25L,3L,1L,103L,29L,1L,63L,3L,9L,103L,7L,1L,1L,19L,37L,147L,1L,13L,3L,19L,11L,45L,1L,37L,23L,3L,1L,27L,61L,1L,233L,47L,13L,1L,21L,23L,59L,525L,5L,1L,93L,23L,41L,1L,1L,49L,27L,13L,187L,87L,269L,15L,111L,13L,29L,7L,1L,13L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141707Inst : IEnumerable<long>
{
public static readonly long[] Value=A141707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141707.Bytes);
public long this[int i]=>Value[i];

public static A141707Inst Instance=new A141707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141708
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,33L,65L,15L,17L,513L,21L,2047L,325L,27L,1421L,31L,33L,455L,2553L,195L,1025L,129L,45L,4841L,1421L,51L,3339L,165L,513L,6077L,427L,63L,65L,1273L,2553L,10437L,73L,975L,231L,1501L,891L,3735L,85L,3219L,2047L,273L,93L,2565L,5917L,99L,23533L,4841L,1365L,107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141708Inst : IEnumerable<long>
{
public static readonly long[] Value=A141708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141708.Bytes);
public long this[int i]=>Value[i];

public static A141708Inst Instance=new A141708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141709
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,33L,12L,65L,14L,15L,16L,17L,18L,513L,20L,21L,66L,2047L,24L,325L,130L,27L,28L,1421L,30L,31L,32L,33L,34L,455L,36L,2553L,1026L,195L,40L,1025L,42L,129L,132L,45L,4094L,4841L,48L,1421L,650L,51L,260L,3339L,54L,165L,56L,513L,2842L,6077L,60L,427L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141709Inst : IEnumerable<long>
{
public static readonly long[] Value=A141709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141709.Bytes);
public long this[int i]=>Value[i];

public static A141709Inst Instance=new A141709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141710
{
public static readonly long[] Value={ 3L,5L,7L,5L,7L,7L,7L,5L,7L,13L,7L,13L,7L,3L,7L,11L,7L,13L,7L,17L,7L,7L,41L,5L,37L,13L,19L,13L,31L,41L,5L,37L,31L,13L,13L,3L,11L,7L,7L,5L,7L,11L,7L,19L,7L,5L,7L,43L,31L,37L,17L,23L,7L,31L,41L,11L,19L,17L,13L,53L,5L,7L,11L,43L,13L,5L,29L,5L,101L,53L,7L,13L,11L,7L,19L,31L,41L,13L,29L,31L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141710Inst : IEnumerable<long>
{
public static readonly long[] Value=A141710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141710.Bytes);
public long this[int i]=>Value[i];

public static A141710Inst Instance=new A141710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141711
{
public static readonly long[] Value={ 41041L,62745L,63973L,75361L,101101L,126217L,172081L,188461L,278545L,340561L,449065L,552721L,656601L,658801L,670033L,748657L,825265L,838201L,852841L,997633L,1033669L,1050985L,1082809L,1569457L,1773289L,2100901L,2113921L,2433601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141711Inst : IEnumerable<long>
{
public static readonly long[] Value=A141711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141711.Bytes);
public long this[int i]=>Value[i];

public static A141711Inst Instance=new A141711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141712
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,6L,6L,4L,1L,26L,26L,18L,8L,1L,162L,162L,114L,54L,16L,1L,1454L,1454L,1030L,506L,162L,32L,1L,18854L,18854L,13394L,6666L,2274L,486L,64L,1L,354258L,354258L,251962L,126134L,43798L,10346L,1458L,128L,1L,9671546L,9671546L,6882102L,3453110L,1210226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141712Inst : IEnumerable<long>
{
public static readonly long[] Value=A141712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141712.Bytes);
public long this[int i]=>Value[i];

public static A141712Inst Instance=new A141712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141713
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,26L,162L,1454L,18854L,354258L,9671546L,384587782L,22323926270L,1895288347354L,235764308325666L,43040024112901598L,11547470030266126198UL,BigInteger.Parse("4559235319260902237410"),BigInteger.Parse("2652214835190976783549066") };
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
public class A141713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141713Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A141713.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A141713.Bytes);
public BigInteger this[int i]=>Value[i];

public static A141713Inst Instance=new A141713Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141714
{
public static readonly BigInteger[] Value={ 1L,4L,18L,114L,1030L,13394L,251962L,6882102L,273720022L,15889775794L,1349080450162L,167821375177022L,30636881867681934L,8219778568738952282L,BigInteger.Parse("3245381833135712948474"),BigInteger.Parse("1887916233782601955737494") };
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
public class A141714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141714Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A141714.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A141714.Bytes);
public BigInteger this[int i]=>Value[i];

public static A141714Inst Instance=new A141714Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141715
{
public static readonly long[] Value={ 1L,2L,1L,6L,4L,1L,26L,20L,8L,1L,162L,136L,68L,16L,1L,1454L,1292L,732L,236L,32L,1L,18854L,17400L,10648L,4036L,836L,64L,1L,354258L,335404L,215708L,90152L,22692L,3020L,128L,1L,9671546L,9317288L,6192440L,2752332L,780400L,129556L,11108L,256L,1L,384587782L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141715Inst : IEnumerable<long>
{
public static readonly long[] Value=A141715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141715.Bytes);
public long this[int i]=>Value[i];

public static A141715Inst Instance=new A141715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141716
{
public static readonly BigInteger[] Value={ 1L,4L,20L,136L,1292L,17400L,335404L,9317288L,374916236L,21939338488L,1872964421084L,233869019978312L,42804259804575932L,11504430006153224600UL,BigInteger.Parse("4547687849230636111212"),BigInteger.Parse("2647655599871715881311656") };
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
public class A141716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141716Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A141716.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A141716.Bytes);
public BigInteger this[int i]=>Value[i];

public static A141716Inst Instance=new A141716Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141717
{
public static readonly long[] Value={ 24L,40L,96L,234L,360L,384L,540L,600L,640L,936L,1536L,1920L,2016L,2160L,2176L,3000L,3240L,3402L,3744L,4320L,4680L,5760L,6048L,6144L,6318L,6528L,6552L,8640L,9600L,9720L,10240L,10880L,11172L,11466L,13608L,14976L,15000L,17280L,18144L,19584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141717Inst : IEnumerable<long>
{
public static readonly long[] Value=A141717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141717.Bytes);
public long this[int i]=>Value[i];

public static A141717Inst Instance=new A141717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141718
{
public static readonly long[] Value={ 1L,4L,8L,16L,18L,32L,36L,50L,54L,64L,72L,100L,108L,128L,144L,162L,200L,216L,250L,256L,288L,294L,324L,400L,432L,450L,486L,500L,512L,576L,578L,588L,648L,800L,864L,882L,900L,972L,1000L,1014L,1024L,1152L,1156L,1176L,1210L,1250L,1296L,1350L,1458L,1600L,1728L,1764L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141718Inst : IEnumerable<long>
{
public static readonly long[] Value=A141718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141718.Bytes);
public long this[int i]=>Value[i];

public static A141718Inst Instance=new A141718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141719
{
public static readonly long[] Value={ 4L,8L,8L,12L,15L,12L,16L,24L,21L,16L,20L,35L,32L,27L,20L,24L,48L,45L,40L,33L,24L,28L,63L,60L,55L,48L,39L,28L,32L,80L,77L,72L,65L,56L,45L,32L,36L,99L,96L,91L,84L,75L,64L,51L,36L,40L,120L,117L,112L,105L,96L,85L,72L,57L,40L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141719Inst : IEnumerable<long>
{
public static readonly long[] Value=A141719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141719.Bytes);
public long this[int i]=>Value[i];

public static A141719Inst Instance=new A141719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141800
{
public static readonly long[] Value={ 0L,4L,8L,8L,17L,12L,28L,16L,23L,20L,50L,24L,67L,28L,38L,32L,95L,36L,118L,40L,53L,44L,152L,48L,81L,52L,68L,56L,201L,60L,236L,64L,83L,68L,112L,72L,293L,76L,98L,80L,345L,84L,392L,88L,113L,92L,450L,96L,185L,100L,128L,104L,525L,108L,176L,112L,143L,116L,604L,120L,669L,124L,158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141800Inst : IEnumerable<long>
{
public static readonly long[] Value=A141800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141800.Bytes);
public long this[int i]=>Value[i];

public static A141800Inst Instance=new A141800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141801
{
public static readonly long[] Value={ 0L,4L,9L,9L,25L,20L,49L,26L,33L,52L,121L,52L,169L,108L,93L,75L,289L,100L,361L,144L,179L,258L,529L,168L,195L,358L,189L,254L,841L,254L,961L,258L,431L,612L,363L,302L,1369L,766L,595L,404L,1681L,494L,1849L,656L,511L,1124L,2209L,556L,639L,598L,1009L,870L,2809L,654L,875L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141801Inst : IEnumerable<long>
{
public static readonly long[] Value=A141801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141801.Bytes);
public long this[int i]=>Value[i];

public static A141801Inst Instance=new A141801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141802
{
public static readonly long[] Value={ 0L,1L,3L,5L,7L,23L,177L,327L,875L,6645L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141802Inst : IEnumerable<long>
{
public static readonly long[] Value=A141802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141802.Bytes);
public long this[int i]=>Value[i];

public static A141802Inst Instance=new A141802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141803
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,0L,1L,2L,1L,1L,1L,2L,3L,2L,0L,1L,2L,3L,1L,0L,0L,1L,2L,3L,4L,2L,2L,1L,1L,2L,3L,4L,1L,3L,0L,1L,1L,2L,3L,4L,5L,2L,0L,1L,0L,1L,2L,3L,4L,5L,1L,3L,2L,1L,0L,1L,2L,3L,4L,5L,6L,2L,4L,3L,2L,1L,1L,2L,3L,4L,5L,6L,1L,3L,0L,0L,0L,0L,1L,2L,3L,4L,5L,6L,7L,2L,4L,2L,1L,2L,1L,1L,2L,3L,4L,5L,6L,7L,1L,3L,5L,3L,3L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141803Inst : IEnumerable<long>
{
public static readonly long[] Value=A141803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141803.Bytes);
public long this[int i]=>Value[i];

public static A141803Inst Instance=new A141803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141804
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,7L,15L,15L,18L,22L,33L,25L,40L,44L,47L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141804Inst : IEnumerable<long>
{
public static readonly long[] Value=A141804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141804.Bytes);
public long this[int i]=>Value[i];

public static A141804Inst Instance=new A141804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141805
{
public static readonly long[] Value={ 9L,28L,35L,65L,72L,91L,126L,133L,152L,189L,217L,224L,243L,280L,341L,344L,351L,370L,407L,468L,513L,520L,539L,559L,576L,637L,728L,855L,1001L,1008L,1027L,1064L,1125L,1216L,1332L,1339L,1343L,1358L,1395L,1456L,1512L,1547L,1674L,1729L,1736L,1755L,1792L,1843L,1853L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141805Inst : IEnumerable<long>
{
public static readonly long[] Value=A141805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141805.Bytes);
public long this[int i]=>Value[i];

public static A141805Inst Instance=new A141805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141806
{
public static readonly long[] Value={ 730L,737L,756L,793L,854L,945L,1072L,1241L,2060L,2457L,2926L,3473L,4825L,5642L,6561L,7588L,8729L,9990L,11377L,12896L,14553L,16354L,18305L,20412L,21953L,21960L,21979L,22016L,22077L,22168L,22295L,22464L,22681L,22952L,23283L,23680L,24149L,24696L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141806Inst : IEnumerable<long>
{
public static readonly long[] Value=A141806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141806.Bytes);
public long this[int i]=>Value[i];

public static A141806Inst Instance=new A141806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141807
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,12L,13L,16L,17L,19L,20L,23L,25L,27L,29L,31L,32L,37L,41L,43L,47L,49L,53L,56L,59L,60L,61L,64L,67L,71L,72L,73L,79L,81L,83L,89L,97L,101L,103L,107L,109L,113L,121L,125L,127L,128L,131L,137L,139L,149L,151L,157L,163L,167L,169L,173L,179L,181L,191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141807Inst : IEnumerable<long>
{
public static readonly long[] Value=A141807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141807.Bytes);
public long this[int i]=>Value[i];

public static A141807Inst Instance=new A141807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141808
{
public static readonly BigInteger[] Value={ 6L,12L,20L,56L,60L,72L,272L,504L,992L,16256L,65792L,67100672L,4295032832L,17179738112L,274877382656L,4611686016279904256L,BigInteger.Parse("5316911983139663489309385231907684352"),BigInteger.Parse("383123885216472214589586756168607276261994643096338432") };
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
public class A141808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141808Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A141808.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A141808.Bytes);
public BigInteger this[int i]=>Value[i];

public static A141808Inst Instance=new A141808Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141809
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,2L,3L,7L,8L,9L,2L,5L,11L,4L,3L,13L,2L,7L,3L,5L,16L,17L,2L,9L,19L,4L,5L,3L,7L,2L,11L,23L,8L,3L,25L,2L,13L,27L,4L,7L,29L,2L,3L,5L,31L,32L,3L,11L,2L,17L,5L,7L,4L,9L,37L,2L,19L,3L,13L,8L,5L,41L,2L,3L,7L,43L,4L,11L,9L,5L,2L,23L,47L,16L,3L,49L,2L,25L,3L,17L,4L,13L,53L,2L,27L,5L,11L,8L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141809Inst : IEnumerable<long>
{
public static readonly long[] Value=A141809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141809.Bytes);
public long this[int i]=>Value[i];

public static A141809Inst Instance=new A141809Inst();

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