using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A234507
{
public static readonly BigInteger[] Value={ 1L,4L,42L,580L,9139L,155664L,2791404L,51919296L,992414925L,19375620264L,384734333698L,7745767624560L,157746595917027L,3243956787596560L,67267249849483200L,1404952651131292800L,BigInteger.Parse("29529506061314207361"),BigInteger.Parse("624113938377564174540"),BigInteger.Parse("13256095235994257535900"),BigInteger.Parse("282803564653982441429256"),BigInteger.Parse("6057302574889055180495805") };
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
public class A234507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A234507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A234507Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A234507.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A234507.Bytes);
public BigInteger this[int i]=>Value[i];

public static A234507Inst Instance=new A234507Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A234506
{
public static readonly BigInteger[] Value={ 1L,3L,30L,406L,6327L,107019L,1909908L,35399520L,674842149L,13147742322L,260626484118L,5239783981320L,106585537781775L,2189670831627678L,45366284782209600L,946815917066740800L,BigInteger.Parse("19887218367823853937"),BigInteger.Parse("420076689292591271325"),BigInteger.Parse("8917736795123409615060"),BigInteger.Parse("190161017612160607167948"),BigInteger.Parse("4071301730663135449185705") };
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
public class A234506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A234506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A234506Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A234506.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A234506.Bytes);
public BigInteger this[int i]=>Value[i];

public static A234506Inst Instance=new A234506Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A234505
{
public static readonly BigInteger[] Value={ 1L,2L,19L,252L,3885L,65274L,1159587L,21421248L,407337153L,7920326700L,156753610013L,3147328992080L,63951322669065L,1312575792628356L,27172514322677625L,566707337222428800L,11896007334177739113UL,BigInteger.Parse("251142622845893276190"),BigInteger.Parse("5328891499524964282170") };
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
public class A234505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A234505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A234505Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A234505.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A234505.Bytes);
public BigInteger this[int i]=>Value[i];

public static A234505Inst Instance=new A234505Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A234504
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,2L,1L,1L,3L,2L,3L,2L,3L,2L,3L,4L,5L,5L,4L,5L,6L,7L,4L,5L,6L,7L,6L,5L,7L,8L,5L,7L,9L,8L,8L,6L,8L,7L,10L,7L,10L,10L,9L,9L,8L,9L,10L,5L,10L,10L,9L,10L,10L,9L,10L,9L,7L,12L,14L,10L,9L,5L,11L,7L,13L,8L,13L,6L,9L,11L,11L,14L,15L,9L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A234504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A234504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A234504Inst : IEnumerable<long>
{
public static readonly long[] Value=A234504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A234504.Bytes);
public long this[int i]=>Value[i];

public static A234504Inst Instance=new A234504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A234503
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,1L,2L,1L,1L,2L,3L,2L,1L,1L,1L,2L,1L,2L,2L,3L,2L,4L,4L,4L,2L,3L,2L,1L,3L,4L,8L,3L,4L,4L,4L,6L,3L,4L,6L,3L,5L,5L,3L,2L,2L,6L,5L,3L,2L,3L,7L,4L,3L,4L,4L,3L,4L,4L,4L,5L,2L,5L,2L,6L,5L,7L,3L,5L,7L,6L,13L,5L,7L,7L,10L,6L,8L,8L,9L,6L,7L,8L,6L,6L,5L,7L,9L,6L,7L,8L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A234503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A234503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A234503Inst : IEnumerable<long>
{
public static readonly long[] Value=A234503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A234503.Bytes);
public long this[int i]=>Value[i];

public static A234503Inst Instance=new A234503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A234502
{
public static readonly long[] Value={ 683L,1523L,2153L,2243L,2393L,2423L,2503L,2657L,3023L,3203L,3581L,3833L,4133L,4373L,4583L,4673L,4967L,5003L,5051L,5233L,5273L,5303L,5483L,5653L,5843L,6221L,6299L,6793L,7193L,7211L,7487L,7523L,7703L,7823L,7937L,8093L,8243L,8543L,8693L,9323L,9377L,9461L,9533L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A234502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A234502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A234502Inst : IEnumerable<long>
{
public static readonly long[] Value=A234502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A234502.Bytes);
public long this[int i]=>Value[i];

public static A234502Inst Instance=new A234502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A234501
{
public static readonly long[] Value={ 1365L,3045L,4305L,4485L,4785L,4845L,5005L,5313L,6045L,6405L,7161L,7665L,8265L,8745L,9165L,9345L,9933L,10005L,10101L,10465L,10545L,10605L,10965L,11305L,11685L,12441L,12597L,13585L,14385L,14421L,14973L,15045L,15405L,15645L,15873L,16185L,16485L,17085L,17385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A234501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A234501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A234501Inst : IEnumerable<long>
{
public static readonly long[] Value=A234501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A234501.Bytes);
public long this[int i]=>Value[i];

public static A234501Inst Instance=new A234501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A234500
{
public static readonly long[] Value={ 578L,683L,893L,998L,1073L,1208L,1403L,1502L,1523L,1568L,1628L,1658L,1853L,1898L,1943L,1964L,2153L,2195L,2243L,2258L,2321L,2393L,2423L,2468L,2503L,2558L,2594L,2657L,2783L,2828L,2933L,3023L,3053L,3098L,3140L,3203L,3273L,3278L,3350L,3383L,3392L,3518L,3548L,3581L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A234500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A234500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A234500Inst : IEnumerable<long>
{
public static readonly long[] Value=A234500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A234500.Bytes);
public long this[int i]=>Value[i];

public static A234500Inst Instance=new A234500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A234499
{
public static readonly long[] Value={ 577L,997L,1567L,1627L,1657L,2467L,2557L,2593L,3391L,3517L,3547L,3607L,3697L,3727L,3877L,4231L,4273L,4357L,4933L,5167L,5227L,5347L,5407L,5527L,5857L,5869L,6121L,6451L,7297L,7417L,7927L,8053L,8179L,8389L,8431L,8521L,8627L,8677L,9091L,9397L,9439L,9547L,9613L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A234499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A234499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A234499Inst : IEnumerable<long>
{
public static readonly long[] Value=A234499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A234499.Bytes);
public long this[int i]=>Value[i];

public static A234499Inst Instance=new A234499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A234498
{
public static readonly long[] Value={ 1155L,1995L,3135L,3255L,3315L,4935L,5115L,5187L,6783L,7035L,7095L,7215L,7395L,7455L,7755L,8463L,8547L,8715L,9867L,10335L,10455L,10695L,10815L,11055L,11715L,11739L,12243L,12903L,14595L,14835L,15855L,16107L,16359L,16779L,16863L,17043L,17255L,17355L,18183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A234498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A234498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A234498Inst : IEnumerable<long>
{
public static readonly long[] Value=A234498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A234498.Bytes);
public long this[int i]=>Value[i];

public static A234498Inst Instance=new A234498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A234497
{
public static readonly long[] Value={ 250L,1834L,1834L,13464L,17022L,13464L,99142L,158288L,158288L,99142L,728536L,1483566L,1856768L,1483566L,728536L,5368636L,13868952L,22124316L,22124316L,13868952L,5368636L,39476802L,130537496L,260915944L,337787398L,260915944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A234497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A234497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A234497Inst : IEnumerable<long>
{
public static readonly long[] Value=A234497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A234497.Bytes);
public long this[int i]=>Value[i];

public static A234497Inst Instance=new A234497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A234496
{
public static readonly long[] Value={ 5368636L,130537496L,3122368992L,78343976876L,1903351845712L,48536967979768L,1192684325401686L,30927279276836584L,768812747956709154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A234496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A234496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A234496Inst : IEnumerable<long>
{
public static readonly long[] Value=A234496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A234496.Bytes);
public long this[int i]=>Value[i];

public static A234496Inst Instance=new A234496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A234127
{
public static readonly BigInteger[] Value={ 12457L,484731L,19007583L,753253097L,29939517797L,1191882104721L,47493714739641L,1893857438251263L,75563062469539403L,3016375900398947031L,BigInteger.Parse("120461028024895476887"),BigInteger.Parse("4812488258562982818841"),BigInteger.Parse("192324808079833297779041") };
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
public class A234127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A234127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A234127Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A234127.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A234127.Bytes);
public BigInteger this[int i]=>Value[i];

public static A234127Inst Instance=new A234127Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A234126
{
public static readonly BigInteger[] Value={ 2413L,47933L,951709L,19007583L,380250439L,7615879723L,152668773739L,3062622875925L,61475337004953L,1234620917271949L,24806175566692573L,498600733683615435L,10025142990290536251UL,BigInteger.Parse("201629391376355775879") };
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
public class A234126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A234126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A234126Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A234126.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A234126.Bytes);
public BigInteger this[int i]=>Value[i];

public static A234126Inst Instance=new A234126Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A234125
{
public static readonly long[] Value={ 469L,4757L,47933L,484731L,4909103L,49779251L,505273311L,5132833317L,52176901353L,530689037697L,5400110298073L,54970941475239L,559763882549955L,5701582841549151L,58087981854053195L,591918422269666865L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A234125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A234125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A234125Inst : IEnumerable<long>
{
public static readonly long[] Value=A234125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A234125.Bytes);
public long this[int i]=>Value[i];

public static A234125Inst Instance=new A234125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A234124
{
public static readonly long[] Value={ 91L,469L,2413L,12457L,64441L,333883L,1731979L,8992639L,46723771L,242899381L,1263281581L,6572316673L,34201861129L,178020202699L,926739961723L,4825035300439L,25123800838123L,130828761714565L,681313452720301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A234124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A234124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A234124Inst : IEnumerable<long>
{
public static readonly long[] Value=A234124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A234124.Bytes);
public long this[int i]=>Value[i];

public static A234124Inst Instance=new A234124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A234123
{
public static readonly BigInteger[] Value={ 91L,4757L,951709L,753253097L,2369586581169L,29777695096321851L,BigInteger.Parse("1499309201721436345531"),BigInteger.Parse("303126582922004534372454101"),BigInteger.Parse("246491114964153072540340892486965") };
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
public class A234123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A234123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A234123Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A234123.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A234123.Bytes);
public BigInteger this[int i]=>Value[i];

public static A234123Inst Instance=new A234123Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A234122
{
public static readonly long[] Value={ 31L,145L,145L,673L,1361L,673L,3127L,12593L,12593L,3127L,14527L,116801L,231713L,116801L,14527L,67489L,1082977L,4279065L,4279065L,1082977L,67489L,313537L,10041953L,79003521L,157630963L,79003521L,10041953L,313537L,1456615L,93113761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A234122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A234122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A234122Inst : IEnumerable<long>
{
public static readonly long[] Value=A234122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A234122.Bytes);
public long this[int i]=>Value[i];

public static A234122Inst Instance=new A234122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A234121
{
public static readonly BigInteger[] Value={ 313537L,93113761L,26937444801L,7888454356625L,2315408571668225L,680845368964238145L,BigInteger.Parse("200376051988817866625"),BigInteger.Parse("58999673293833047076529"),BigInteger.Parse("17376516489941449765539393"),BigInteger.Parse("5118401705337856988983612385") };
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
public class A234121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A234121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A234121Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A234121.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A234121.Bytes);
public BigInteger this[int i]=>Value[i];

public static A234121Inst Instance=new A234121Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A234120
{
public static readonly BigInteger[] Value={ 67489L,10041953L,1458813409L,214027901025L,31446640848897L,4625943683805313L,680845368964238145L,BigInteger.Parse("100232847106041668353"),BigInteger.Parse("14757962542814417545441"),BigInteger.Parse("2173049645779146516000801"),BigInteger.Parse("319982366490305655551327777") };
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
public class A234120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A234120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A234120Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A234120.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A234120.Bytes);
public BigInteger this[int i]=>Value[i];

public static A234120Inst Instance=new A234120Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A234119
{
public static readonly BigInteger[] Value={ 14527L,1082977L,79003521L,5807422543L,427196005695L,31446640848897L,2315408571668225L,170502665692732079L,12556134956123911615UL,BigInteger.Parse("924677153131389366689"),BigInteger.Parse("68097056429203867060865"),BigInteger.Parse("5014969801413653091728655") };
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
public class A234119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A234119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A234119Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A234119.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A234119.Bytes);
public BigInteger this[int i]=>Value[i];

public static A234119Inst Instance=new A234119Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A234118
{
public static readonly BigInteger[] Value={ 3127L,116801L,4279065L,157630963L,5807422543L,214027901025L,7888454356625L,290756314787875L,10716964158533127L,395017615132720993L,14560017639995412841UL,BigInteger.Parse("536670372954048895219"),BigInteger.Parse("19781236893820566186079") };
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
public class A234118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A234118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A234118Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A234118.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A234118.Bytes);
public BigInteger this[int i]=>Value[i];

public static A234118Inst Instance=new A234118Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A234117
{
public static readonly BigInteger[] Value={ 673L,12593L,231713L,4279065L,79003521L,1458813409L,26937444801L,497411686793L,9184935953377L,169604155276817L,3131820756402657L,57830550281200505L,1067868451774107585L,BigInteger.Parse("19718695887361293761"),BigInteger.Parse("364115043587212161409") };
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
public class A234117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A234117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A234117Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A234117.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A234117.Bytes);
public BigInteger this[int i]=>Value[i];

public static A234117Inst Instance=new A234117Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A234116
{
public static readonly long[] Value={ 145L,1361L,12593L,116801L,1082977L,10041953L,93113761L,863396401L,8005833073L,74233997105L,688333901137L,6382568345057L,59182293086657L,548767146042305L,5088437180610625L,47182476443409233L,437498981379983185L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A234116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A234116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A234116Inst : IEnumerable<long>
{
public static readonly long[] Value=A234116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A234116.Bytes);
public long this[int i]=>Value[i];

public static A234116Inst Instance=new A234116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A234115
{
public static readonly BigInteger[] Value={ 31L,1361L,231713L,157630963L,427196005695L,4625943683805313L,BigInteger.Parse("200376051988817866625"),BigInteger.Parse("34754816964141969688314115"),BigInteger.Parse("24157262935852623408023272643359"),BigInteger.Parse("67332158893994957162261589597358347857") };
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
public class A234115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A234115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A234115Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A234115.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A234115.Bytes);
public BigInteger this[int i]=>Value[i];

public static A234115Inst Instance=new A234115Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A234114
{
public static readonly long[] Value={ 56L,186L,186L,604L,608L,604L,2064L,2086L,2086L,2064L,6964L,7742L,7732L,7742L,6964L,24156L,29278L,31740L,31740L,29278L,24156L,83012L,113666L,133592L,151304L,133592L,113666L,83012L,290164L,446590L,581756L,738628L,738628L,581756L,446590L,290164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A234114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A234114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A234114Inst : IEnumerable<long>
{
public static readonly long[] Value=A234114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A234114.Bytes);
public long this[int i]=>Value[i];

public static A234114Inst Instance=new A234114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A234113
{
public static readonly long[] Value={ 83012L,446590L,2579864L,20547980L,150134376L,1293718300L,10603143992L,97572997380L,892457433308L,8881590361884L,90024944561008L,965652228376156L,10592740576262476L,120178412755723492L,1386668576796168084L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A234113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A234113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A234113Inst : IEnumerable<long>
{
public static readonly long[] Value=A234113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A234113.Bytes);
public long this[int i]=>Value[i];

public static A234113Inst Instance=new A234113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A234112
{
public static readonly long[] Value={ 24156L,113666L,581756L,3840512L,24612244L,178269116L,1293718300L,10243412736L,83539101944L,726030071196L,6523835568272L,61001852606952L,583875017617376L,5708286244788676L,56533338152109484L,565648200914302292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A234112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A234112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A234112Inst : IEnumerable<long>
{
public static readonly long[] Value=A234112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A234112.Bytes);
public long this[int i]=>Value[i];

public static A234112Inst Instance=new A234112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233919
{
public static readonly long[] Value={ 1L,2L,4L,6L,18L,42L,111L,279L,752L,1990L,5376L,14707L,40465L,111970L,311997L,873239L,2455818L,6933060L,19640273L,55813426L,159047591L,454373344L,1301016216L,3733009232L,10731465131L,30904208376L,89140202911L,257498974953L,744861243809L,2157405104355L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233919Inst : IEnumerable<long>
{
public static readonly long[] Value=A233919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233919.Bytes);
public long this[int i]=>Value[i];

public static A233919Inst Instance=new A233919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233918
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,2L,2L,1L,2L,3L,1L,3L,2L,4L,3L,2L,7L,1L,3L,3L,4L,7L,2L,4L,5L,5L,5L,5L,6L,6L,4L,7L,5L,6L,4L,4L,11L,5L,5L,5L,11L,4L,3L,5L,7L,12L,4L,6L,11L,3L,6L,7L,8L,6L,7L,8L,11L,10L,5L,9L,7L,9L,5L,4L,14L,8L,9L,6L,10L,7L,6L,10L,9L,10L,7L,10L,11L,7L,7L,13L,11L,13L,5L,8L,11L,9L,9L,3L,12L,4L,11L,13L,11L,19L,8L,12L,11L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233918Inst : IEnumerable<long>
{
public static readonly long[] Value=A233918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233918.Bytes);
public long this[int i]=>Value[i];

public static A233918Inst Instance=new A233918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233917
{
public static readonly long[] Value={ 160L,640L,640L,2440L,3944L,2440L,9612L,22632L,22632L,9612L,36976L,138132L,194208L,138132L,36976L,145004L,807964L,1813476L,1813476L,807964L,145004L,559736L,4908404L,15981048L,26954304L,15981048L,4908404L,559736L,2189924L,28936484L,148503096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233917Inst : IEnumerable<long>
{
public static readonly long[] Value=A233917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233917.Bytes);
public long this[int i]=>Value[i];

public static A233917Inst Instance=new A233917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233916
{
public static readonly BigInteger[] Value={ 559736L,28936484L,1317291048L,76393662524L,3816435022128L,224247343748408L,11458028594887856L,672061212550600320L,BigInteger.Parse("34642386448309478976"),BigInteger.Parse("2024556302397626065444"),BigInteger.Parse("104880714157688434998824") };
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
public class A233916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233916Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233916.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233916.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233916Inst Instance=new A233916Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233915
{
public static readonly BigInteger[] Value={ 145004L,4908404L,148503096L,5494251884L,179779430264L,6709328689904L,224247343748408L,8354188752786996L,282149056961983552L,10483870479310426784UL,BigInteger.Parse("356671417796342099644"),BigInteger.Parse("13222669495882027796652") };
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
public class A233915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233915Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233915.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233915.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233915Inst Instance=new A233915Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233914
{
public static readonly BigInteger[] Value={ 36976L,807964L,15981048L,369978404L,7752002928L,179779430264L,3816435022128L,88174304365260L,1882101558915232L,43329895764737680L,928159189164216848L,BigInteger.Parse("21305336764584666304"),BigInteger.Parse("457639958123218639480"),BigInteger.Parse("10478566423139329437168") };
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
public class A233914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233914Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233914.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233914.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233914Inst Instance=new A233914Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233913
{
public static readonly ulong[] Value={ 9612L,138132L,1813476L,26954304L,369978404L,5494251884L,76393662524L,1131348498772L,15846113265432L,234199189701020L,3298277776530524L,48674865163210448L,688571019650205760L,10149555642796141884UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233913Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A233913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233913.Bytes);
public ulong this[int i]=>Value[i];

public static A233913Inst Instance=new A233913Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233912
{
public static readonly long[] Value={ 2440L,22632L,194208L,1813476L,15981048L,148503096L,1317291048L,12194674440L,108542688160L,1002043707452L,8941088637664L,82361200249948L,736372072644264L,6770660028757160L,60638120886991720L,556662134862492320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233912Inst : IEnumerable<long>
{
public static readonly long[] Value=A233912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233912.Bytes);
public long this[int i]=>Value[i];

public static A233912Inst Instance=new A233912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233911
{
public static readonly long[] Value={ 640L,3944L,22632L,138132L,807964L,4908404L,28936484L,175407492L,1039210048L,6291984872L,37411050288L,226333090864L,1349436837188L,8159273967724L,48752105141528L,294639966341512L,1763518515517052L,10653925639599432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233911Inst : IEnumerable<long>
{
public static readonly long[] Value=A233911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233911.Bytes);
public long this[int i]=>Value[i];

public static A233911Inst Instance=new A233911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233910
{
public static readonly long[] Value={ 160L,640L,2440L,9612L,36976L,145004L,559736L,2189924L,8470344L,33088100L,128155456L,500055876L,1938715672L,7558416852L,29325538832L,114258452900L,443550616168L,1727342374724L,6708320872096L,26115152683348L,101452849075768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233910Inst : IEnumerable<long>
{
public static readonly long[] Value=A233910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233910.Bytes);
public long this[int i]=>Value[i];

public static A233910Inst Instance=new A233910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233909
{
public static readonly BigInteger[] Value={ 160L,3944L,194208L,26954304L,7752002928L,6709328689904L,11458028594887856L,BigInteger.Parse("63725861037698186808") };
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
public class A233909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233909Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233909.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233909.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233909Inst Instance=new A233909Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233908
{
public static readonly BigInteger[] Value={ 1L,10L,115L,1450L,19425L,271502L,3915100L,57821940L,870238200L,13298907050L,205811513765L,3218995093860L,50802419972395L,808016193159000L,12938696992921000L,208419656266988904L,3374960506795660365L,BigInteger.Parse("54907659530154222000"),BigInteger.Parse("897060906625956765000") };
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
public class A233908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233908Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233908.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233908.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233908Inst Instance=new A233908Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233907
{
public static readonly BigInteger[] Value={ 1L,9L,99L,1218L,16065L,222138L,3178140L,46656324L,698868216L,10639125640L,164128169205L,2560224004884L,40314178429707L,639948824981928L,10230035192533800L,164541833894991240L,2660919275605834701L,BigInteger.Parse("43239781879996449825"),BigInteger.Parse("705687913212419321800"),BigInteger.Parse("11561996402992103418000"),BigInteger.Parse("190100812111989146008641") };
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
public class A233907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233907Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233907.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233907.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233907Inst Instance=new A233907Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233906
{
public static readonly long[] Value={ 2L,1499L,1783L,9719L,9311L,67883L,134947L,203317L,189433L,560171L,438533L,943849L,640973L,578827L,2172383L,28687L,1505657L,7595033L,2822971L,1242379L,22899523L,9232219L,5730031L,12336083L,3487607L,35451433L,12174803L,10234079L,84459019L,68736683L,44671169L,85507057L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233906Inst : IEnumerable<long>
{
public static readonly long[] Value=A233906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233906.Bytes);
public long this[int i]=>Value[i];

public static A233906Inst Instance=new A233906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233905
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,2L,1L,4L,0L,4L,2L,7L,1L,7L,4L,11L,0L,8L,4L,13L,2L,12L,7L,18L,1L,13L,7L,20L,4L,18L,11L,26L,0L,16L,8L,25L,4L,22L,13L,32L,2L,22L,12L,33L,7L,29L,18L,41L,1L,25L,13L,38L,7L,33L,20L,47L,4L,32L,18L,47L,11L,41L,26L,57L,0L,32L,16L,49L,8L,42L,25L,60L,4L,40L,22L,59L,13L,51L,32L,71L,2L,42L,22L,63L,12L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233905Inst : IEnumerable<long>
{
public static readonly long[] Value=A233905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233905.Bytes);
public long this[int i]=>Value[i];

public static A233905Inst Instance=new A233905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233904
{
public static readonly long[] Value={ 0L,0L,-1L,1L,-3L,1L,-2L,4L,-7L,1L,-4L,6L,-8L,4L,-3L,11L,-15L,1L,-8L,10L,-14L,6L,-5L,17L,-20L,4L,-9L,17L,-17L,11L,-4L,26L,-31L,1L,-16L,18L,-26L,10L,-9L,29L,-34L,6L,-15L,27L,-27L,17L,-6L,40L,-44L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233904Inst : IEnumerable<long>
{
public static readonly long[] Value=A233904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233904.Bytes);
public long this[int i]=>Value[i];

public static A233904Inst Instance=new A233904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233583
{
public static readonly long[] Value={ 2L,2L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233583Inst : IEnumerable<long>
{
public static readonly long[] Value=A233583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233583.Bytes);
public long this[int i]=>Value[i];

public static A233583Inst Instance=new A233583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233582
{
public static readonly long[] Value={ 3L,21L,111L,113L,158L,160L,211L,216L,525L,1634L,1721L,7063L,8771L,15077L,26168L,58447L,223767L,254729L,587278L,1046086L,1491449L,1635223L,1689171L,2039096L,2290214L,13444599L,22666443L,1276179737L,4470200748L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233582Inst : IEnumerable<long>
{
public static readonly long[] Value=A233582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233582.Bytes);
public long this[int i]=>Value[i];

public static A233582Inst Instance=new A233582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233581
{
public static readonly long[] Value={ 1L,0L,-1L,-1L,1L,4L,4L,-3L,-14L,-15L,9L,49L,56L,-26L,-171L,-208L,71L,595L,769L,-176L,-2064L,-2831L,354L,7137L,10381L,-295L,-24596L,-37926L,-2359L,84464L,138079L,20407L,-288959L,-501060L,-114836L,984549L,1812546L,556609L,-3339871L,-6537023L,-2497824L,11275550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233581Inst : IEnumerable<long>
{
public static readonly long[] Value=A233581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233581.Bytes);
public long this[int i]=>Value[i];

public static A233581Inst Instance=new A233581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233580
{
public static readonly long[] Value={ 2L,7L,16L,20L,32L,43L,61L,103L,124L,146L,182L,196L,292L,302L,338L,367L,421L,547L,601L,859L,913L,1039L,1096L,1172L,1280L,1312L,1600L,1640L,1748L,1816L,2560L,2624L,2732L,2776L,3064L,3092L,3200L,3283L,3445L,3823L,3985L,4759L,4921L,5299L,5461L,7663L,7825L,8203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233580Inst : IEnumerable<long>
{
public static readonly long[] Value=A233580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233580.Bytes);
public long this[int i]=>Value[i];

public static A233580Inst Instance=new A233580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233579
{
public static readonly long[] Value={ 10L,16L,20L,22L,28L,30L,32L,44L,46L,48L,50L,52L,56L,58L,60L,64L,66L,80L,82L,84L,90L,92L,96L,104L,106L,112L,116L,128L,132L,136L,138L,140L,144L,148L,150L,154L,156L,160L,164L,166L,168L,170L,172L,174L,176L,178L,180L,184L,192L,198L,200L,212L,224L,226L,238L,240L,242L,246L,252L,260L,262L,268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233579Inst : IEnumerable<long>
{
public static readonly long[] Value=A233579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233579.Bytes);
public long this[int i]=>Value[i];

public static A233579Inst Instance=new A233579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233578
{
public static readonly long[] Value={ 2L,4L,6L,8L,12L,14L,18L,24L,26L,34L,36L,38L,40L,42L,54L,62L,68L,70L,72L,74L,76L,78L,86L,88L,94L,98L,100L,102L,108L,110L,114L,118L,120L,122L,124L,126L,130L,134L,142L,146L,152L,158L,162L,182L,186L,188L,190L,194L,196L,202L,204L,206L,208L,210L,214L,216L,218L,220L,222L,228L,230L,232L,234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233578Inst : IEnumerable<long>
{
public static readonly long[] Value=A233578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233578.Bytes);
public long this[int i]=>Value[i];

public static A233578Inst Instance=new A233578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233577
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,17L,19L,23L,37L,43L,61L,67L,73L,89L,103L,107L,151L,163L,179L,181L,197L,223L,251L,263L,269L,307L,347L,359L,373L,383L,433L,491L,587L,593L,613L,619L,701L,751L,761L,881L,997L,1019L,1129L,1321L,1439L,1601L,1699L,1951L,2069L,2243L,2267L,2297L,2423L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233577Inst : IEnumerable<long>
{
public static readonly long[] Value=A233577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233577.Bytes);
public long this[int i]=>Value[i];

public static A233577Inst Instance=new A233577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233576
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,9L,12L,14L,18L,19L,21L,24L,27L,28L,36L,38L,41L,42L,45L,48L,54L,56L,57L,63L,69L,72L,74L,76L,84L,94L,107L,108L,112L,114L,126L,133L,135L,152L,168L,171L,189L,216L,228L,252L,266L,297L,312L,334L,336L,342L,360L,378L,380L,399L,423L,432L,441L,444L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233576Inst : IEnumerable<long>
{
public static readonly long[] Value=A233576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233576.Bytes);
public long this[int i]=>Value[i];

public static A233576Inst Instance=new A233576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233575
{
public static readonly long[] Value={ 2L,157L,1697L,190573L,167719729L,22092660553L,57613776809L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233575Inst : IEnumerable<long>
{
public static readonly long[] Value=A233575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233575.Bytes);
public long this[int i]=>Value[i];

public static A233575Inst Instance=new A233575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233574
{
public static readonly long[] Value={ 0L,1L,2L,2L,4L,3L,4L,6L,8L,6L,6L,8L,8L,7L,12L,8L,10L,9L,10L,13L,12L,13L,16L,20L,16L,18L,26L,18L,18L,20L,18L,18L,20L,20L,18L,26L,20L,24L,26L,21L,24L,21L,26L,43L,32L,24L,28L,26L,28L,43L,30L,27L,28L,27L,28L,54L,30L,39L,40L,32L,32L,43L,32L,39L,40L,39L,40L,43L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233574Inst : IEnumerable<long>
{
public static readonly long[] Value=A233574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233574.Bytes);
public long this[int i]=>Value[i];

public static A233574Inst Instance=new A233574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233573
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,2L,1L,4L,2L,2L,3L,2L,1L,3L,2L,1L,4L,2L,2L,4L,2L,2L,3L,2L,1L,6L,3L,4L,5L,2L,3L,5L,3L,3L,7L,1L,3L,4L,2L,3L,4L,1L,2L,5L,2L,3L,5L,1L,2L,2L,2L,2L,6L,1L,4L,3L,3L,3L,6L,4L,2L,7L,3L,3L,4L,4L,3L,5L,3L,2L,6L,3L,1L,4L,3L,1L,2L,4L,2L,9L,4L,4L,7L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233573Inst : IEnumerable<long>
{
public static readonly long[] Value=A233573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233573.Bytes);
public long this[int i]=>Value[i];

public static A233573Inst Instance=new A233573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233572
{
public static readonly long[] Value={ 0L,2L,6L,8L,18L,20L,24L,26L,32L,54L,56L,60L,72L,78L,80L,96L,104L,146L,162L,164L,168L,180L,182L,216L,224L,234L,240L,242L,260L,288L,302L,312L,320L,338L,416L,438L,486L,488L,492L,504L,540L,546L,560L,648L,656L,672L,702L,720L,726L,728L,780L,800L,864L,896L,906L,936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233572Inst : IEnumerable<long>
{
public static readonly long[] Value=A233572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233572.Bytes);
public long this[int i]=>Value[i];

public static A233572Inst Instance=new A233572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233571
{
public static readonly long[] Value={ 0L,2L,8L,20L,26L,32L,56L,80L,104L,146L,164L,182L,224L,242L,260L,302L,320L,338L,416L,488L,560L,656L,728L,800L,896L,968L,1040L,1172L,1226L,1280L,1406L,1460L,1514L,1640L,1694L,1748L,1898L,1952L,2006L,2132L,2186L,2240L,2366L,2420L,2474L,2624L,2678L,2732L,2858L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233571Inst : IEnumerable<long>
{
public static readonly long[] Value=A233571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233571.Bytes);
public long this[int i]=>Value[i];

public static A233571Inst Instance=new A233571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233570
{
public static readonly long[] Value={ 1L,3L,5L,6L,7L,9L,11L,12L,15L,15L,13L,18L,17L,21L,25L,24L,19L,27L,23L,30L,35L,33L,29L,36L,35L,39L,45L,42L,31L,45L,37L,48L,55L,51L,49L,54L,41L,57L,65L,60L,43L,63L,47L,66L,75L,69L,53L,72L,77L,75L,85L,78L,59L,81L,77L,84L,95L,87L,61L,90L,67L,93L,105L,96L,91L,99L,71L,102L,115L,105L,73L,108L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233570Inst : IEnumerable<long>
{
public static readonly long[] Value=A233570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233570.Bytes);
public long this[int i]=>Value[i];

public static A233570Inst Instance=new A233570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233569
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,6L,7L,8L,12L,10L,14L,12L,14L,14L,15L,16L,24L,20L,28L,20L,26L,26L,30L,24L,28L,26L,30L,28L,30L,30L,31L,32L,48L,40L,56L,36L,52L,52L,60L,40L,52L,42L,58L,52L,58L,58L,62L,48L,56L,52L,60L,52L,58L,58L,62L,56L,60L,58L,62L,60L,62L,62L,63L,64L,96L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233569Inst : IEnumerable<long>
{
public static readonly long[] Value=A233569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233569.Bytes);
public long this[int i]=>Value[i];

public static A233569Inst Instance=new A233569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233568
{
public static readonly BigInteger[] Value={ 1L,5L,23L,151L,1199L,9567L,76543L,1125119L,17978879L,287659519L,4602550271L,73629609983L,1178073743359L,18849179828223L,301586877251583L,9308786131992575L,297840749160955903L,9530903606625042431UL,BigInteger.Parse("304988913945966280703"),BigInteger.Parse("9759645240406772285439") };
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
public class A233568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233568Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233568.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233568.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233568Inst Instance=new A233568Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233487
{
public static readonly BigInteger[] Value={ 846914338316L,5070020645309648L,BigInteger.Parse("28457838067515915868"),BigInteger.Parse("158651203925316697808911"),BigInteger.Parse("878277219085987050067730382"),BigInteger.Parse("4856912550311218393312690904367"),BigInteger.Parse("26837940556052708958006836213552610") };
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
public class A233487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233487Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233487.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233487.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233487Inst Instance=new A233487Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233486
{
public static readonly BigInteger[] Value={ 18116531520L,32519299606118L,55442546308058920L,BigInteger.Parse("94038386779753884364"),BigInteger.Parse("158651203925316697808911"),BigInteger.Parse("267457939129841084397425458"),BigInteger.Parse("450635011196058144943097350481"),BigInteger.Parse("759193722701220137409721033632067") };
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
public class A233486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233486Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233486.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233486.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233486Inst Instance=new A233486Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233485
{
public static readonly BigInteger[] Value={ 386906152L,208066125583L,107592918949238L,55442546308058920L,BigInteger.Parse("28457838067515915868"),BigInteger.Parse("14599877618428749394824"),BigInteger.Parse("7487230243357112789375674"),BigInteger.Parse("3839427812196854822442932801"),BigInteger.Parse("1968762192441113320779511808280") };
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
public class A233485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233485Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233485.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233485.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233485Inst Instance=new A233485Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233484
{
public static readonly BigInteger[] Value={ 8254896L,1328621536L,208066125583L,32519299606118L,5070020645309648L,790268803855249807L,BigInteger.Parse("123152447408851785342"),BigInteger.Parse("19191100654338179315407"),BigInteger.Parse("2990528559024374872097052"),BigInteger.Parse("466009565463506152675878521") };
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
public class A233484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233484Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233484.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233484.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233484Inst Instance=new A233484Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233483
{
public static readonly BigInteger[] Value={ 172952L,8254896L,386906152L,18116531520L,846914338316L,39587056212137L,1850126770689608L,86465768048368472L,4040923982272526872L,BigInteger.Parse("188849818269171055054"),BigInteger.Parse("8825754751934559124956"),BigInteger.Parse("412464977706204443514728") };
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
public class A233483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233483Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233483.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233483.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233483Inst Instance=new A233483Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233482
{
public static readonly long[] Value={ 575L,2057L,2645L,3179L,4416L,8512L,12275L,33534L,94272L,138431L,203075L,218176L,392747L,715878L,918592L,982157L,991841L,1082176L,1205405L,1244387L,1559616L,1690432L,1966912L,2344079L,2464576L,2982976L,3386176L,3452992L,3625792L,3821632L,3867712L,3900497L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233482Inst : IEnumerable<long>
{
public static readonly long[] Value=A233482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233482.Bytes);
public long this[int i]=>Value[i];

public static A233482Inst Instance=new A233482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233481
{
public static readonly BigInteger[] Value={ 0L,1L,4L,21L,144L,1245L,13140L,164745L,2399040L,39834585L,742940100L,15374360925L,349484058000L,8654336615925L,231842662751700L,6679510641428625L,205916703920928000L,6762863294018456625L,BigInteger.Parse("235719416966063530500"),BigInteger.Parse("8689887736412502745125") };
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
public class A233481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233481Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233481.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233481.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233481Inst Instance=new A233481Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233480
{
public static readonly long[] Value={ 178464L,8840905L,8840905L,432047816L,1542165988L,432047816L,21111771232L,264110152411L,264110152411L,21111771232L,1030570080608L,45223720670867L,157745111994988L,45223720670867L,1030570080608L,50306732887149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233480Inst : IEnumerable<long>
{
public static readonly long[] Value=A233480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233480.Bytes);
public long this[int i]=>Value[i];

public static A233480Inst Instance=new A233480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233479
{
public static readonly BigInteger[] Value={ 1030570080608L,7732943732414030L,BigInteger.Parse("56144572756093218532"),BigInteger.Parse("407469009947158776878785"),BigInteger.Parse("2949642405355277235588516280"),BigInteger.Parse("21351274587488969266031394375096"),BigInteger.Parse("154522350497970592467901520516939384") };
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
public class A233479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233479Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233479.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233479.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233479Inst Instance=new A233479Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233478
{
public static readonly BigInteger[] Value={ 21111771232L,45223720670867L,94192817031882237L,BigInteger.Parse("196122261590679299496"),BigInteger.Parse("407469009947158776878785"),BigInteger.Parse("846537132143871418217915702"),BigInteger.Parse("1758426966252867944813771559333"),BigInteger.Parse("3652590644663404309130794104320920") };
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
public class A233478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233478Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233478.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233478.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233478Inst Instance=new A233478Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233477
{
public static readonly BigInteger[] Value={ 432047816L,264110152411L,157745111994988L,94192817031882237L,BigInteger.Parse("56144572756093218532"),BigInteger.Parse("33464589643594017658068"),BigInteger.Parse("19943610614570401668122830"),BigInteger.Parse("11885592674748739620208778761"),BigInteger.Parse("7083262038757043890993319580932") };
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
public class A233477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233477Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233477.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233477.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233477Inst Instance=new A233477Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233476
{
public static readonly BigInteger[] Value={ 8840905L,1542165988L,264110152411L,45223720670867L,7732943732414030L,1322255733920272536L,BigInteger.Parse("226068657791038230800"),BigInteger.Parse("38651333034861710486643"),BigInteger.Parse("6608229637236101895009182"),BigInteger.Parse("1129810754947963897221965651") };
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
public class A233476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233476Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233476.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233476.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233476Inst Instance=new A233476Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233475
{
public static readonly BigInteger[] Value={ 178464L,8840905L,432047816L,21111771232L,1030570080608L,50306732887149L,2455509770023748L,119855189715624816L,5850184020893059584L,BigInteger.Parse("285550010593205974009"),BigInteger.Parse("13937813362561049133972"),BigInteger.Parse("680310394336994074070032") };
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
public class A233475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233475Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233475.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233475.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233475Inst Instance=new A233475Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233474
{
public static readonly long[] Value={ 1L,4L,52L,169L,1993L,6436L,75700L,244417L,2874625L,9281428L,109160068L,352449865L,4145207977L,13383813460L,157408743076L,508232461633L,5977387028929L,19299449728612L,226983298356244L,732870857225641L,8619387950508361L,27829793124845764L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233474Inst : IEnumerable<long>
{
public static readonly long[] Value=A233474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233474.Bytes);
public long this[int i]=>Value[i];

public static A233474Inst Instance=new A233474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233473
{
public static readonly long[] Value={ 0L,4L,7L,9L,11L,14L,16L,19L,21L,23L,26L,28L,31L,33L,36L,38L,40L,43L,45L,48L,50L,52L,55L,57L,60L,62L,64L,67L,69L,72L,74L,77L,79L,81L,84L,86L,89L,91L,93L,96L,98L,101L,103L,106L,108L,110L,113L,115L,118L,120L,122L,125L,127L,130L,132L,134L,137L,139L,142L,144L,147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233473Inst : IEnumerable<long>
{
public static readonly long[] Value=A233473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233473.Bytes);
public long this[int i]=>Value[i];

public static A233473Inst Instance=new A233473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233472
{
public static readonly BigInteger[] Value={ 1L,2L,1L,72L,12L,12L,43200L,3600L,1440L,2160L,423360000L,21168000L,4704000L,3024000L,6048000L,67212633600000L,2240421120000L,320060160000L,120022560000L,106686720000L,266716800000L,BigInteger.Parse("172153600393420800000"),4098895247462400000L };
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
public class A233472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233472Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233472.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233472.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233472Inst Instance=new A233472Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233295
{
public static readonly long[] Value={ 1L,4L,2L,9L,10L,4L,16L,28L,24L,8L,25L,60L,80L,56L,16L,36L,110L,200L,216L,128L,32L,49L,182L,420L,616L,560L,288L,64L,64L,280L,784L,1456L,1792L,1408L,640L,128L,81L,408L,1344L,3024L,4704L,4992L,3456L,1408L,256L,100L,570L,2160L,5712L,10752L,14400L,13440L,8320L,3072L,512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233295Inst : IEnumerable<long>
{
public static readonly long[] Value=A233295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233295.Bytes);
public long this[int i]=>Value[i];

public static A233295Inst Instance=new A233295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233294
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,93L,668L,3440L,13728L,46252L,172577L,739002L,3417464L,15550336L,65956764L,271247405L,1119519052L,4726308568L,20348072952L,87598217268L,373660404281L,1581318625634L,6680851858676L,28326586367464L,120536842633616L,513461699313993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233294Inst : IEnumerable<long>
{
public static readonly long[] Value=A233294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233294.Bytes);
public long this[int i]=>Value[i];

public static A233294Inst Instance=new A233294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233293
{
public static readonly long[] Value={ 3L,1L,0L,40L,0L,0L,16L,0L,88L,592L,0L,628L,52L,160L,304L,1672L,808L,2248L,3616L,11176L,10096L,8728L,4192L,23056L,13912L,65428L,40804L,5812L,9448L,12148L,8584L,82132L,27700L,10528L,91672L,53188L,58804L,20896L,96064L,2752L,32776L,25972L,14560L,183688L,8080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233293Inst : IEnumerable<long>
{
public static readonly long[] Value=A233293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233293.Bytes);
public long this[int i]=>Value[i];

public static A233293Inst Instance=new A233293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233292
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,2L,0L,1L,2L,3L,0L,1L,3L,4L,5L,0L,0L,2L,4L,5L,6L,0L,0L,2L,5L,7L,8L,9L,0L,0L,1L,4L,7L,9L,10L,11L,0L,0L,1L,4L,8L,11L,13L,14L,15L,0L,0L,0L,3L,7L,11L,14L,16L,17L,18L,0L,0L,0L,2L,7L,12L,16L,19L,21L,22L,23L,0L,0L,0L,1L,5L,11L,16L,20L,23L,25L,26L,27L,0L,0L,0L,1L,5L,11L,18L,23L,27L,30L,32L,33L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233292Inst : IEnumerable<long>
{
public static readonly long[] Value=A233292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233292.Bytes);
public long this[int i]=>Value[i];

public static A233292Inst Instance=new A233292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233291
{
public static readonly long[] Value={ 1L,2L,4L,8L,45L,248L,1032L,3524L,13173L,54274L,228712L,917992L,3608665L,14286188L,57438652L,231343468L,926921081L,3700936774L,14793198332L,59241396140L,237333611629L,950127617692L,3801974385964L,15215432779936L,60907523900693L,243826775063490L,976008753961184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233291Inst : IEnumerable<long>
{
public static readonly long[] Value=A233291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233291.Bytes);
public long this[int i]=>Value[i];

public static A233291Inst Instance=new A233291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233290
{
public static readonly long[] Value={ 1L,1L,11L,170L,939L,8342L,80092L,614581L,5271923L,45832761L,379419508L,3223419241L,27438555522L,231096250072L,1958024834151L,16593169804557L,140295718998907L,1187830239559588L,10056816580083721L,85104482994177208L,720410915948382970L,6098207777286812381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233290Inst : IEnumerable<long>
{
public static readonly long[] Value=A233290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233290.Bytes);
public long this[int i]=>Value[i];

public static A233290Inst Instance=new A233290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233289
{
public static readonly long[] Value={ 1L,2L,4L,21L,92L,320L,1213L,4822L,18556L,70929L,273808L,1057020L,4069737L,15676666L,60424640L,232846801L,897164316L,3457096532L,13321674833L,51332757274L,197801848744L,762200458321L,2937024077340L,11317358546188L,43609682555721L,168043191679374L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233289Inst : IEnumerable<long>
{
public static readonly long[] Value=A233289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233289.Bytes);
public long this[int i]=>Value[i];

public static A233289Inst Instance=new A233289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233288
{
public static readonly long[] Value={ 1L,1L,2L,16L,230L,6856L,318162L,19819281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233288Inst : IEnumerable<long>
{
public static readonly long[] Value=A233288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233288.Bytes);
public long this[int i]=>Value[i];

public static A233288Inst Instance=new A233288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233287
{
public static readonly long[] Value={ 1L,3L,12L,12L,60L,60L,120L,120L,120L,120L,120L,120L,840L,840L,840L,840L,2520L,2520L,2520L,2520L,2520L,2520L,2520L,2520L,12600L,12600L,12600L,12600L,12600L,12600L,12600L,12600L,12600L,12600L,12600L,12600L,239400L,239400L,239400L,239400L,239400L,239400L,2633400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233287Inst : IEnumerable<long>
{
public static readonly long[] Value=A233287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233287.Bytes);
public long this[int i]=>Value[i];

public static A233287Inst Instance=new A233287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233286
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,3L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,3L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,3L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,3L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,5L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,3L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,3L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233286Inst : IEnumerable<long>
{
public static readonly long[] Value=A233286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233286.Bytes);
public long this[int i]=>Value[i];

public static A233286Inst Instance=new A233286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233285
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,4L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,4L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,4L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,4L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,6L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,4L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,4L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,4L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,4L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233285Inst : IEnumerable<long>
{
public static readonly long[] Value=A233285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233285.Bytes);
public long this[int i]=>Value[i];

public static A233285Inst Instance=new A233285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233284
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,4L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,4L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,4L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,4L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,6L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,4L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,4L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,4L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,4L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233284Inst : IEnumerable<long>
{
public static readonly long[] Value=A233284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233284.Bytes);
public long this[int i]=>Value[i];

public static A233284Inst Instance=new A233284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233283
{
public static readonly BigInteger[] Value={ 1L,3L,12L,60L,120L,840L,2520L,12600L,239400L,2633400L,5266800L,15800400L,458211600L,7789597200L,288215096400L,3746796253200L,26227573772400L,131137868862000L,1049102950896000L,24129367870608000L,1906220061778032000L,BigInteger.Parse("78155022532899312000"),BigInteger.Parse("6955797005428038768000") };
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
public class A233283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233283Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233283.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233283.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233283Inst Instance=new A233283Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233282
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,13L,17L,25L,37L,43L,47L,53L,59L,67L,73L,79L,97L,125L,127L,137L,157L,163L,179L,193L,243L,257L,269L,277L,283L,311L,313L,317L,337L,353L,359L,397L,439L,457L,479L,487L,499L,509L,523L,547L,563L,577L,613L,617L,625L,653L,673L,677L,719L,729L,733L,757L,787L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233282Inst : IEnumerable<long>
{
public static readonly long[] Value=A233282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233282.Bytes);
public long this[int i]=>Value[i];

public static A233282Inst Instance=new A233282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233281
{
public static readonly long[] Value={ 2L,5L,13L,37L,73L,89L,113L,149L,157L,193L,233L,269L,277L,313L,353L,389L,397L,457L,557L,613L,673L,677L,733L,757L,877L,953L,977L,997L,1069L,1093L,1153L,1213L,1237L,1453L,1597L,1657L,1753L,1873L,1877L,1933L,1949L,1993L,2017L,2137L,2221L,2237L,2309L,2333L,2417L,2473L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233281Inst : IEnumerable<long>
{
public static readonly long[] Value=A233281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233281.Bytes);
public long this[int i]=>Value[i];

public static A233281Inst Instance=new A233281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233280
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,6L,8L,9L,11L,10L,14L,15L,13L,12L,16L,17L,19L,18L,22L,23L,21L,20L,28L,29L,31L,30L,26L,27L,25L,24L,32L,33L,35L,34L,38L,39L,37L,36L,44L,45L,47L,46L,42L,43L,41L,40L,56L,57L,59L,58L,62L,63L,61L,60L,52L,53L,55L,54L,50L,51L,49L,48L,64L,65L,67L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233280Inst : IEnumerable<long>
{
public static readonly long[] Value=A233280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233280.Bytes);
public long this[int i]=>Value[i];

public static A233280Inst Instance=new A233280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233279
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,6L,8L,9L,11L,10L,15L,14L,12L,13L,16L,17L,19L,18L,23L,22L,20L,21L,31L,30L,28L,29L,24L,25L,27L,26L,32L,33L,35L,34L,39L,38L,36L,37L,47L,46L,44L,45L,40L,41L,43L,42L,63L,62L,60L,61L,56L,57L,59L,58L,48L,49L,51L,50L,55L,54L,52L,53L,64L,65L,67L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233279Inst : IEnumerable<long>
{
public static readonly long[] Value=A233279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233279.Bytes);
public long this[int i]=>Value[i];

public static A233279Inst Instance=new A233279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233278
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,4L,6L,7L,12L,10L,9L,8L,13L,11L,14L,15L,27L,23L,21L,19L,20L,18L,17L,16L,28L,25L,24L,22L,29L,26L,30L,31L,58L,53L,48L,46L,44L,41L,40L,38L,43L,39L,37L,35L,36L,34L,33L,32L,59L,54L,52L,49L,51L,47L,45L,42L,60L,56L,55L,50L,61L,57L,62L,63L,121L,113L,108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233278Inst : IEnumerable<long>
{
public static readonly long[] Value=A233278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233278.Bytes);
public long this[int i]=>Value[i];

public static A233278Inst Instance=new A233278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233277
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,4L,6L,7L,11L,10L,9L,13L,8L,12L,14L,15L,23L,22L,21L,19L,20L,18L,27L,17L,26L,25L,29L,16L,24L,28L,30L,31L,47L,46L,45L,43L,44L,42L,39L,41L,38L,37L,55L,40L,36L,54L,35L,53L,34L,51L,59L,52L,50L,33L,49L,58L,57L,61L,32L,48L,56L,60L,62L,63L,95L,94L,93L,91L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233277Inst : IEnumerable<long>
{
public static readonly long[] Value=A233277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233277.Bytes);
public long this[int i]=>Value[i];

public static A233277Inst Instance=new A233277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233276
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,6L,4L,5L,15L,14L,11L,13L,8L,9L,10L,12L,31L,30L,26L,29L,22L,24L,25L,28L,16L,17L,18L,20L,19L,21L,23L,27L,63L,62L,57L,61L,50L,55L,56L,60L,42L,45L,47L,51L,49L,52L,54L,59L,32L,33L,34L,36L,35L,37L,39L,43L,38L,40L,41L,44L,46L,48L,53L,58L,127L,126L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233276Inst : IEnumerable<long>
{
public static readonly long[] Value=A233276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233276.Bytes);
public long this[int i]=>Value[i];

public static A233276Inst Instance=new A233276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233275
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,7L,5L,4L,12L,13L,14L,10L,15L,11L,9L,8L,24L,25L,26L,28L,27L,29L,20L,30L,21L,22L,18L,31L,23L,19L,17L,16L,48L,49L,50L,52L,51L,53L,56L,54L,57L,58L,40L,55L,59L,41L,60L,42L,61L,44L,36L,43L,45L,62L,46L,37L,38L,34L,63L,47L,39L,35L,33L,32L,96L,97L,98L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233275Inst : IEnumerable<long>
{
public static readonly long[] Value=A233275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233275.Bytes);
public long this[int i]=>Value[i];

public static A233275Inst Instance=new A233275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233274
{
public static readonly long[] Value={ 0L,0L,-1L,0L,0L,0L,0L,1L,2L,4L,8L,13L,22L,38L,68L,125L,232L,429L,786L,1428L,2578L,4645L,8364L,15064L,27145L,48990L,88736L,161813L,298001L,555451L,1048207L,1999608L,3844722L,7425094L,14356699L,27722560L,53374986L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233274Inst : IEnumerable<long>
{
public static readonly long[] Value=A233274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233274.Bytes);
public long this[int i]=>Value[i];

public static A233274Inst Instance=new A233274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233273
{
public static readonly long[] Value={ 2L,4L,7L,8L,12L,13L,15L,16L,21L,22L,24L,25L,28L,29L,31L,32L,38L,39L,41L,42L,45L,46L,48L,49L,53L,54L,56L,57L,60L,61L,63L,64L,71L,72L,74L,75L,78L,79L,81L,82L,86L,87L,89L,90L,93L,94L,96L,97L,102L,103L,105L,106L,109L,110L,112L,113L,117L,118L,120L,121L,124L,125L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233273Inst : IEnumerable<long>
{
public static readonly long[] Value=A233273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233273.Bytes);
public long this[int i]=>Value[i];

public static A233273Inst Instance=new A233273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233272
{
public static readonly long[] Value={ 1L,2L,4L,4L,7L,7L,8L,8L,12L,12L,13L,13L,15L,15L,16L,16L,21L,21L,22L,22L,24L,24L,25L,25L,28L,28L,29L,29L,31L,31L,32L,32L,38L,38L,39L,39L,41L,41L,42L,42L,45L,45L,46L,46L,48L,48L,49L,49L,53L,53L,54L,54L,56L,56L,57L,57L,60L,60L,61L,61L,63L,63L,64L,64L,71L,71L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233272Inst : IEnumerable<long>
{
public static readonly long[] Value=A233272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233272.Bytes);
public long this[int i]=>Value[i];

public static A233272Inst Instance=new A233272Inst();

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