using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A145052
{
public static readonly long[] Value={ 3L,7L,11L,15L,27L,39L,51L,87L,123L,159L,267L,375L,483L,807L,1131L,1455L,2427L,3399L,4371L,7287L,10203L,13119L,21867L,30615L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A145052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A145052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A145052Inst : IEnumerable<long>
{
public static readonly long[] Value=A145052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A145052.Bytes);
public long this[int i]=>Value[i];

public static A145052Inst Instance=new A145052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A145051
{
public static readonly long[] Value={ 1L,3L,2L,5L,3L,7L,4L,9L,5L,11L,6L,13L,7L,15L,8L,17L,9L,19L,10L,21L,11L,23L,12L,25L,13L,27L,14L,29L,15L,31L,16L,33L,17L,35L,18L,37L,19L,39L,20L,41L,21L,43L,22L,45L,23L,47L,24L,49L,25L,51L,26L,53L,27L,55L,28L,57L,29L,59L,30L,61L,31L,63L,32L,65L,33L,67L,34L,69L,35L,71L,36L,73L,37L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A145051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A145051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A145051Inst : IEnumerable<long>
{
public static readonly long[] Value=A145051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A145051.Bytes);
public long this[int i]=>Value[i];

public static A145051Inst Instance=new A145051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A145050
{
public static readonly long[] Value={ 6569L,8117L,8689L,9221L,9281L,9829L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A145050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A145050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A145050Inst : IEnumerable<long>
{
public static readonly long[] Value=A145050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A145050.Bytes);
public long this[int i]=>Value[i];

public static A145050Inst Instance=new A145050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A145049
{
public static readonly long[] Value={ 3037L,3169L,3257L,3769L,4013L,4421L,4793L,4957L,5237L,5297L,5701L,5821L,5881L,6373L,6689L,6761L,6949L,7013L,7213L,7417L,7481L,7549L,7621L,7757L,8389L,8461L,8537L,8681L,8753L,9049L,9133L,9277L,9349L,9733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A145049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A145049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A145049Inst : IEnumerable<long>
{
public static readonly long[] Value=A145049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A145049.Bytes);
public long this[int i]=>Value[i];

public static A145049Inst Instance=new A145049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A145048
{
public static readonly long[] Value={ 2749L,2897L,3049L,3529L,3557L,3929L,4073L,4253L,4657L,4817L,5081L,5281L,5417L,5449L,5657L,5693L,5869L,6053L,6121L,6529L,6793L,6833L,7109L,7393L,7541L,7829L,7877L,7993L,8209L,8329L,8377L,8429L,8501L,8741L,8761L,8893L,9001L,9109L,9157L,9209L,9257L,9293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A145048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A145048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A145048Inst : IEnumerable<long>
{
public static readonly long[] Value=A145048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A145048.Bytes);
public long this[int i]=>Value[i];

public static A145048Inst Instance=new A145048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A145031
{
public static readonly long[] Value={ 5L,9L,45L,81L,675L,1215L,14175L,28431L,72171L,597051L,2679075L,885735L,10333575L,89813529L,286446699L,390609135L,789189885L,7274895849L,55142849601L,204945438681L,154580775111L,1049522104701L,596240132571L,1307544150375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A145031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A145031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A145031Inst : IEnumerable<long>
{
public static readonly long[] Value=A145031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A145031.Bytes);
public long this[int i]=>Value[i];

public static A145031Inst Instance=new A145031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A145030
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,15L,30L,59L,116L,229L,454L,903L,1791L,3552L,7045L,13974L,27719L,54984L,109065L,216339L,429126L,851207L,1688440L,3349161L,6643338L,13177611L,26138883L,51848640L,102846073L,204003706L,404658251L,802673164L,1592168717L,3158198551L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A145030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A145030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A145030Inst : IEnumerable<long>
{
public static readonly long[] Value=A145030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A145030.Bytes);
public long this[int i]=>Value[i];

public static A145030Inst Instance=new A145030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A145029
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,15L,29L,56L,109L,214L,423L,831L,1633L,3210L,6311L,12408L,24393L,47955L,94277L,185344L,364377L,716346L,1408299L,2768643L,5443009L,10700674L,21036971L,41357596L,81306893L,159845143L,314247277L,617793880L,1214550789L,2387743982L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A145029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A145029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A145029Inst : IEnumerable<long>
{
public static readonly long[] Value=A145029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A145029.Bytes);
public long this[int i]=>Value[i];

public static A145029Inst Instance=new A145029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A145028
{
public static readonly long[] Value={ 1L,2L,3L,4L,10L,19L,36L,69L,134L,258L,497L,958L,1847L,3560L,6862L,13227L,25496L,49145L,94730L,182598L,351969L,678442L,1307739L,2520748L,4858898L,9365827L,18053212L,34798685L,67076622L,129294346L,249222865L,480392518L,925986351L,1784896080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A145028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A145028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A145028Inst : IEnumerable<long>
{
public static readonly long[] Value=A145028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A145028.Bytes);
public long this[int i]=>Value[i];

public static A145028Inst Instance=new A145028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A145027
{
public static readonly long[] Value={ 2L,3L,4L,9L,16L,29L,54L,99L,182L,335L,616L,1133L,2084L,3833L,7050L,12967L,23850L,43867L,80684L,148401L,272952L,502037L,923390L,1698379L,3123806L,5745575L,10567760L,19437141L,35750476L,65755377L,120942994L,222448847L,409147218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A145027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A145027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A145027Inst : IEnumerable<long>
{
public static readonly long[] Value=A145027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A145027.Bytes);
public long this[int i]=>Value[i];

public static A145027Inst Instance=new A145027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A145026
{
public static readonly BigInteger[] Value={ 5L,21L,34L,144L,610L,987L,24157817L,7540113804746346429L,BigInteger.Parse("18547707689471986212190138521399707760"),BigInteger.Parse("382699285659014174244530850035136059033084785") };
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
public class A145026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A145026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A145026Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A145026.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A145026.Bytes);
public BigInteger this[int i]=>Value[i];

public static A145026Inst Instance=new A145026Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A145025
{
public static readonly long[] Value={ 4L,5L,6L,9L,12L,15L,18L,21L,26L,30L,34L,39L,42L,45L,50L,53L,56L,60L,64L,69L,72L,76L,81L,86L,93L,99L,102L,105L,108L,111L,120L,129L,134L,138L,144L,150L,154L,157L,160L,165L,170L,173L,176L,180L,186L,192L,195L,198L,205L,211L,217L,225L,228L,231L,236L,240L,246L,254L,257L,260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A145025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A145025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A145025Inst : IEnumerable<long>
{
public static readonly long[] Value=A145025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A145025.Bytes);
public long this[int i]=>Value[i];

public static A145025Inst Instance=new A145025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A145024
{
public static readonly long[] Value={ 3L,13L,21L,3L,7L,8L,1L,18L,29L,5L,3L,8L,11L,31L,4L,20L,3L,7L,5L,19L,21L,32L,1L,19L,48L,19L,29L,32L,7L,38L,1L,43L,12L,33L,46L,6L,16L,8L,4L,34L,15L,1L,19L,7L,1L,23L,28L,30L,22L,8L,1L,7L,1L,52L,14L,56L,10L,26L,2L,30L,65L,5L,71L,12L,44L,39L,37L,6L,19L,47L,11L,10L,21L,7L,11L,4L,62L,7L,4L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A145024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A145024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A145024Inst : IEnumerable<long>
{
public static readonly long[] Value=A145024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A145024.Bytes);
public long this[int i]=>Value[i];

public static A145024Inst Instance=new A145024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A145023
{
public static readonly long[] Value={ 353L,373L,449L,461L,521L,541L,593L,653L,673L,757L,769L,797L,821L,829L,941L,953L,1009L,1021L,1061L,1069L,1097L,1193L,1217L,1249L,1277L,1361L,1381L,1481L,1489L,1549L,1597L,1613L,1657L,1669L,1693L,1709L,1733L,1777L,1801L,1877L,1889L,1973L,2053L,2069L,2081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A145023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A145023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A145023Inst : IEnumerable<long>
{
public static readonly long[] Value=A145023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A145023.Bytes);
public long this[int i]=>Value[i];

public static A145023Inst Instance=new A145023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A145022
{
public static readonly long[] Value={ 41L,61L,89L,113L,149L,157L,181L,193L,233L,269L,277L,313L,317L,337L,389L,421L,433L,557L,569L,613L,617L,709L,761L,773L,853L,881L,929L,937L,1013L,1109L,1117L,1129L,1201L,1213L,1301L,1409L,1429L,1553L,1637L,1741L,1753L,1861L,1873L,1901L,1997L,2113L,2137L,2153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A145022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A145022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A145022Inst : IEnumerable<long>
{
public static readonly long[] Value=A145022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A145022.Bytes);
public long this[int i]=>Value[i];

public static A145022Inst Instance=new A145022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A145021
{
public static readonly long[] Value={ 4L,10L,20L,25L,27L,29L,30L,31L,30L,31L,30L,31L,30L,31L,30L,31L,30L,31L,30L,31L,30L,31L,30L,31L,30L,31L,30L,31L,30L,31L,30L,31L,30L,31L,30L,31L,30L,31L,30L,31L,30L,31L,30L,31L,30L,31L,30L,31L,30L,31L,30L,31L,30L,31L,30L,31L,30L,31L,30L,31L,30L,31L,30L,31L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A145021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A145021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A145021Inst : IEnumerable<long>
{
public static readonly long[] Value=A145021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A145021.Bytes);
public long this[int i]=>Value[i];

public static A145021Inst Instance=new A145021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A145020
{
public static readonly BigInteger[] Value={ 1L,196L,23716L,2458624L,239754256L,22776846400L,2139058352704L,199857257119744L,18630079167234304L,1734834007938712576L,BigInteger.Parse("161472109634377851904"),BigInteger.Parse("15026063825688651366400") };
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
public class A145020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A145020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A145020Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A145020.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A145020.Bytes);
public BigInteger this[int i]=>Value[i];

public static A145020Inst Instance=new A145020Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A145019
{
public static readonly long[] Value={ 1L,2L,6L,4L,10L,6L,20L,14L,30L,24L,40L,36L,10L,30L,56L,44L,70L,66L,26L,90L,84L,14L,30L,104L,60L,16L,130L,126L,80L,34L,156L,154L,144L,90L,136L,126L,170L,114L,20L,60L,210L,204L,140L,84L,190L,110L,220L,210L,266L,260L,24L,184L,120L,306L,304L,100L,286L,150L,276L,26L,130L,330L,54L,234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A145019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A145019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A145019Inst : IEnumerable<long>
{
public static readonly long[] Value=A145019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A145019.Bytes);
public long this[int i]=>Value[i];

public static A145019Inst Instance=new A145019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A145018
{
public static readonly long[] Value={ 4L,5L,7L,10L,14L,19L,25L,32L,40L,49L,59L,70L,82L,95L,109L,124L,140L,157L,175L,194L,214L,235L,257L,280L,304L,329L,355L,382L,410L,439L,469L,500L,532L,565L,599L,634L,670L,707L,745L,784L,824L,865L,907L,950L,994L,1039L,1085L,1132L,1180L,1229L,1279L,1330L,1382L,1435L,1489L,1544L,1600L,1657L,1715L,1774L,1834L,1895L,1957L,2020L,2084L,2149L,2215L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A145018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A145018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A145018Inst : IEnumerable<long>
{
public static readonly long[] Value=A145018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A145018.Bytes);
public long this[int i]=>Value[i];

public static A145018Inst Instance=new A145018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A145017
{
public static readonly long[] Value={ 1L,2L,5L,10L,13L,17L,26L,29L,34L,37L,53L,58L,65L,73L,82L,85L,97L,101L,109L,122L,130L,137L,145L,170L,173L,178L,185L,194L,197L,205L,221L,226L,229L,241L,257L,265L,281L,290L,293L,305L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A145017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A145017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A145017Inst : IEnumerable<long>
{
public static readonly long[] Value=A145017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A145017.Bytes);
public long this[int i]=>Value[i];

public static A145017Inst Instance=new A145017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A145016
{
public static readonly long[] Value={ 5L,13L,17L,29L,37L,53L,73L,97L,101L,109L,137L,173L,197L,229L,241L,257L,281L,293L,349L,397L,401L,409L,457L,509L,577L,601L,641L,661L,677L,701L,733L,809L,857L,877L,977L,997L,1033L,1049L,1093L,1153L,1181L,1229L,1289L,1297L,1321L,1373L,1433L,1453L,1493L,1601L,1609L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A145016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A145016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A145016Inst : IEnumerable<long>
{
public static readonly long[] Value=A145016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A145016.Bytes);
public long this[int i]=>Value[i];

public static A145016Inst Instance=new A145016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144951
{
public static readonly long[] Value={ 3L,45L,1512L,51408L,66528L,116375L,185976L,6323184L,8182944L,11442816L,50492975L,368852400L,1407466368L,5881607424L,22350712320L,723437713152L,183348802920960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144951Inst : IEnumerable<long>
{
public static readonly long[] Value=A144951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144951.Bytes);
public long this[int i]=>Value[i];

public static A144951Inst Instance=new A144951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144950
{
public static readonly long[] Value={ 3L,45L,1512L,51408L,66528L,85500L,185976L,6323184L,8182944L,11442816L,43023600L,368852400L,1407466368L,5881607424L,22350712320L,723437713152L,183348802920960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144950Inst : IEnumerable<long>
{
public static readonly long[] Value=A144950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144950.Bytes);
public long this[int i]=>Value[i];

public static A144950Inst Instance=new A144950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144949
{
public static readonly long[] Value={ 3L,45L,1512L,51408L,66528L,85500L,185976L,6323184L,8182944L,11442816L,43023600L,318041100L,1407466368L,5881607424L,22350712320L,723437713152L,183348802920960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144949Inst : IEnumerable<long>
{
public static readonly long[] Value=A144949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144949.Bytes);
public long this[int i]=>Value[i];

public static A144949Inst Instance=new A144949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144948
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,3L,2L,2L,0L,2L,2L,0L,1L,2L,0L,0L,3L,0L,1L,3L,3L,2L,2L,0L,0L,6L,4L,0L,6L,4L,4L,6L,2L,4L,6L,6L,2L,2L,4L,4L,6L,0L,0L,6L,6L,4L,2L,2L,6L,6L,6L,2L,0L,13L,13L,5L,8L,9L,4L,12L,12L,13L,0L,12L,12L,4L,8L,8L,13L,5L,12L,8L,0L,12L,12L,12L,1L,8L,12L,4L,13L,8L,9L,5L,5L,13L,0L,8L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144948Inst : IEnumerable<long>
{
public static readonly long[] Value=A144948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144948.Bytes);
public long this[int i]=>Value[i];

public static A144948Inst Instance=new A144948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144947
{
public static readonly long[] Value={ 1L,1L,4L,13L,16L,1L,43L,37L,126L,12L,226L,149L,97L,115L,33L,51L,9L,428L,68L,29L,34L,47L,583L,15L,502L,410L,336L,283L,756L,1303L,33L,793L,343L,703L,1024L,1888L,728L,782L,226L,493L,1977L,3265L,567L,151L,1096L,203L,77L,3255L,381L,4963L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144947Inst : IEnumerable<long>
{
public static readonly long[] Value=A144947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144947.Bytes);
public long this[int i]=>Value[i];

public static A144947Inst Instance=new A144947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144946
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,8L,21L,5L,4L,4L,4L,32L,4L,16L,7L,9L,1L,14L,5L,32L,22L,35L,6L,21L,11L,22L,3L,72L,48L,20L,1L,8L,1L,36L,30L,32L,6L,26L,14L,2L,22L,32L,6L,48L,37L,2L,58L,1L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144946Inst : IEnumerable<long>
{
public static readonly long[] Value=A144946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144946.Bytes);
public long this[int i]=>Value[i];

public static A144946Inst Instance=new A144946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144945
{
public static readonly long[] Value={ 0L,6L,28L,76L,160L,290L,476L,728L,1056L,1470L,1980L,2596L,3328L,4186L,5180L,6320L,7616L,9078L,10716L,12540L,14560L,16786L,19228L,21896L,24800L,27950L,31356L,35028L,38976L,43210L,47740L,52576L,57728L,63206L,69020L,75180L,81696L,88578L,95836L,103480L,111520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144945Inst : IEnumerable<long>
{
public static readonly long[] Value=A144945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144945.Bytes);
public long this[int i]=>Value[i];

public static A144945Inst Instance=new A144945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144944
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,3L,1L,5L,11L,11L,1L,7L,23L,45L,45L,1L,9L,39L,107L,197L,197L,1L,11L,59L,205L,509L,903L,903L,1L,13L,83L,347L,1061L,2473L,4279L,4279L,1L,15L,111L,541L,1949L,5483L,12235L,20793L,20793L,1L,17L,143L,795L,3285L,10717L,28435L,61463L,103049L,103049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144944Inst : IEnumerable<long>
{
public static readonly long[] Value=A144944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144944.Bytes);
public long this[int i]=>Value[i];

public static A144944Inst Instance=new A144944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144943
{
public static readonly long[] Value={ 0L,2L,2L,5L,2L,14L,2L,8L,5L,14L,2L,26L,2L,14L,14L,11L,2L,26L,2L,26L,14L,14L,2L,38L,5L,14L,8L,26L,2L,62L,2L,14L,14L,14L,14L,47L,2L,14L,14L,38L,2L,62L,2L,26L,26L,14L,2L,50L,5L,26L,14L,26L,2L,38L,14L,38L,14L,14L,2L,110L,2L,14L,26L,17L,14L,62L,2L,26L,14L,62L,2L,68L,2L,14L,26L,26L,14L,62L,2L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144943Inst : IEnumerable<long>
{
public static readonly long[] Value=A144943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144943.Bytes);
public long this[int i]=>Value[i];

public static A144943Inst Instance=new A144943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144942
{
public static readonly BigInteger[] Value={ 0L,25L,532L,29237L,614312L,33739857L,708915900L,38935766125L,818088334672L,44931840368777L,944073229295972L,51851304849802917L,1089459688519217400L,BigInteger.Parse("59836360864832197825"),BigInteger.Parse("1257235536477947584012"),BigInteger.Parse("69051108586711506487517"),BigInteger.Parse("1450848719635862992732832") };
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
public class A144942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144942Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144942.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144942.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144942Inst Instance=new A144942Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144941
{
public static readonly BigInteger[] Value={ 1L,36L,753L,41348L,868769L,47715364L,1002558481L,55063488516L,1156951618113L,63543218031908L,1335121164743729L,73328818545333124L,1540728667162644961L,BigInteger.Parse("84621393058096392996"),BigInteger.Parse("1777999546784527541073"),BigInteger.Parse("97653014260224692184068") };
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
public class A144941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144941Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144941.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144941.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144941Inst Instance=new A144941Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144940
{
public static readonly long[] Value={ 67L,17317L,80317L,97117L,398467L,1333417L,1423717L,1876267L,2317267L,3332167L,4890367L,5456317L,5911417L,6151867L,6622867L,9151717L,9522367L,11013967L,13372717L,15381967L,17080267L,21663067L,22439017L,22552417L,24262267L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144940Inst : IEnumerable<long>
{
public static readonly long[] Value=A144940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144940.Bytes);
public long this[int i]=>Value[i];

public static A144940Inst Instance=new A144940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144939
{
public static readonly long[] Value={ 53L,83L,7433L,978683L,1238033L,2325833L,3168983L,3305483L,4148633L,4289783L,5112533L,5456333L,5867933L,6231833L,6842333L,12093383L,12499733L,13820633L,14201333L,15516383L,18107333L,19189283L,19470233L,21121883L,24887183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144939Inst : IEnumerable<long>
{
public static readonly long[] Value=A144939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144939.Bytes);
public long this[int i]=>Value[i];

public static A144939Inst Instance=new A144939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144938
{
public static readonly long[] Value={ 9L,81L,225L,441L,1089L,13689L,56169L,74529L,91809L,95481L,149769L,184041L,194481L,199809L,263169L,314721L,328329L,370881L,651249L,804609L,1071225L,1147041L,1238769L,1306449L,1520289L,1535121L,1718721L,2442969L,2595321L,2614689L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144938Inst : IEnumerable<long>
{
public static readonly long[] Value=A144938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144938.Bytes);
public long this[int i]=>Value[i];

public static A144938Inst Instance=new A144938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144937
{
public static readonly BigInteger[] Value={ 2L,4L,32L,368L,6752L,171648L,5638656L,227787008L,10932927488L,608031869952L,38451260291072L,2724757330591744L,213848122843791360L,18412354032091807744UL,BigInteger.Parse("1725472542353497456640"),BigInteger.Parse("174827224579118545174528") };
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
public class A144937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144937Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144937.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144937.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144937Inst Instance=new A144937Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144936
{
public static readonly long[] Value={ 3251L,5380811L,21435859L,3559590211L,43950269291L,1197301738651L,4978825201387L,7555858447451L,44733963701131L,108285670562779L,302711489293211L,912484779174091L,2585353346765411L,4300509998893139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144936Inst : IEnumerable<long>
{
public static readonly long[] Value=A144936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144936.Bytes);
public long this[int i]=>Value[i];

public static A144936Inst Instance=new A144936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144887
{
public static readonly BigInteger[] Value={ 1L,5L,25L,161L,1081L,8745L,75305L,741961L,7904201L,93174025L,1185282185L,16364262281L,242055376521L,3834244039305L,64590031280265L,1154392672267401L,21796700933039241L,433694961594395785L,9066521908425387145L,BigInteger.Parse("198692729793556061321") };
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
public class A144887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144887Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144887.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144887.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144887Inst Instance=new A144887Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144886
{
public static readonly long[] Value={ 1L,4L,1L,20L,4L,1L,120L,36L,4L,1L,840L,200L,36L,4L,1L,6720L,1720L,264L,36L,4L,1L,60480L,12480L,2040L,264L,36L,4L,1L,604800L,118560L,16000L,2296L,264L,36L,4L,1L,6652800L,1081920L,149600L,17280L,2296L,264L,36L,4L,1L,79833600L,11793600L,1362240L,163680L,18304L,2296L,264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144886Inst : IEnumerable<long>
{
public static readonly long[] Value=A144886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144886.Bytes);
public long this[int i]=>Value[i];

public static A144886Inst Instance=new A144886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144885
{
public static readonly long[] Value={ 1L,4L,1L,20L,4L,1L,120L,20L,16L,4L,1L,840L,120L,80L,20L,16L,4L,1L,6720L,840L,480L,400L,120L,80L,64L,20L,16L,4L,1L,60480L,6720L,3360L,2400L,840L,480L,400L,320L,120L,80L,64L,20L,16L,4L,1L,604800L,60480L,26880L,16800L,14400L,6720L,3360L,2400L,1920L,1600L,840L,480L,400L,320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144885Inst : IEnumerable<long>
{
public static readonly long[] Value=A144885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144885.Bytes);
public long this[int i]=>Value[i];

public static A144885Inst Instance=new A144885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144884
{
public static readonly BigInteger[] Value={ 1L,3L,21L,123L,792L,5292L,42768L,348840L,3313440L,33734880L,382423680L,4683303360L,62795865600L,903908678400L,14018003596800L,231803919244800L,4081121327001600L,76062618390528000L,1497060883196928000L,BigInteger.Parse("31001124301830144000"),BigInteger.Parse("673857550403702784000") };
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
public class A144884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144884Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144884.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144884.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144884Inst Instance=new A144884Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144883
{
public static readonly BigInteger[] Value={ 1L,3L,21L,96L,684L,4320L,35640L,293760L,2881440L,29695680L,345643200L,4296499200L,58518028800L,851751936000L,13338801100800L,222145265664000L,3934764739584000L,73675580977152000L,1455693852146688000L,BigInteger.Parse("30238671742304256000"),BigInteger.Parse("659012259039805440000") };
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
public class A144883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144883Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144883.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144883.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144883Inst Instance=new A144883Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144882
{
public static readonly BigInteger[] Value={ 1L,4L,16L,85L,481L,3352L,25420L,223393L,2157565L,23241244L,272933680L,3496821133L,48307202761L,717473918560L,11381186498836L,192155770419673L,3438337498017781L,65004294514876996L,1294456866053992600L,BigInteger.Parse("27081588485949257605") };
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
public class A144882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144882Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144882.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144882.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144882Inst Instance=new A144882Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144881
{
public static readonly long[] Value={ 1L,3L,1L,12L,3L,1L,60L,21L,3L,1L,360L,96L,21L,3L,1L,2520L,684L,123L,21L,3L,1L,20160L,4320L,792L,123L,21L,3L,1L,181440L,35640L,5292L,873L,123L,21L,3L,1L,1814400L,293760L,42768L,5616L,873L,123L,21L,3L,1L,19958400L,2881440L,348840L,45684L,5859L,873L,123L,21L,3L,1L,239500800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144881Inst : IEnumerable<long>
{
public static readonly long[] Value=A144881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144881.Bytes);
public long this[int i]=>Value[i];

public static A144881Inst Instance=new A144881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144880
{
public static readonly long[] Value={ 1L,3L,1L,12L,3L,1L,60L,12L,9L,3L,1L,360L,60L,36L,12L,9L,3L,1L,2520L,360L,180L,144L,60L,36L,27L,12L,9L,3L,1L,20160L,2520L,1080L,720L,360L,180L,144L,108L,60L,36L,27L,12L,9L,3L,1L,181440L,20160L,7560L,4320L,3600L,2520L,1080L,720L,540L,432L,360L,180L,144L,108L,81L,60L,36L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144880Inst : IEnumerable<long>
{
public static readonly long[] Value=A144880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144880.Bytes);
public long this[int i]=>Value[i];

public static A144880Inst Instance=new A144880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144879
{
public static readonly long[] Value={ 1L,5L,1L,20L,15L,1L,60L,80L,75L,30L,1L,120L,300L,1000L,200L,375L,50L,1L,120L,720L,4500L,4000L,900L,6000L,1875L,400L,1125L,75L,1L,0L,840L,12600L,42000L,2520L,31500L,28000L,52500L,2100L,21000L,13125L,700L,2625L,105L,1L,0L,0L,16800L,134400L,126000L,3360L,100800L,336000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144879Inst : IEnumerable<long>
{
public static readonly long[] Value=A144879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144879.Bytes);
public long this[int i]=>Value[i];

public static A144879Inst Instance=new A144879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144878
{
public static readonly long[] Value={ 1L,4L,1L,12L,12L,1L,24L,48L,48L,24L,1L,24L,120L,480L,120L,240L,40L,1L,0L,144L,1440L,1440L,360L,2880L,960L,240L,720L,60L,1L,0L,0L,2016L,10080L,504L,10080L,10080L,20160L,840L,10080L,6720L,420L,1680L,84L,1L,0L,0L,0L,16128L,20160L,0L,16128L,80640L,80640L,161280L,1344L,40320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144878Inst : IEnumerable<long>
{
public static readonly long[] Value=A144878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144878.Bytes);
public long this[int i]=>Value[i];

public static A144878Inst Instance=new A144878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144877
{
public static readonly long[] Value={ 1L,3L,1L,6L,9L,1L,6L,24L,27L,18L,1L,0L,30L,180L,60L,135L,30L,1L,0L,0L,270L,360L,90L,1080L,405L,120L,405L,45L,1L,0L,0L,0L,1260L,0L,1890L,2520L,5670L,210L,3780L,2835L,210L,945L,63L,1L,0L,0L,0L,0L,1260L,0L,0L,10080L,11340L,30240L,0L,7560L,10080L,45360L,8505L,420L,10080L,11340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144877Inst : IEnumerable<long>
{
public static readonly long[] Value=A144877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144877.Bytes);
public long this[int i]=>Value[i];

public static A144877Inst Instance=new A144877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144876
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,10L,13L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144876Inst : IEnumerable<long>
{
public static readonly long[] Value=A144876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144876.Bytes);
public long this[int i]=>Value[i];

public static A144876Inst Instance=new A144876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144875
{
public static readonly long[] Value={ 1L,7L,2L,4L,9L,9L,1L,1L,2L,6L,0L,3L,4L,5L,0L,0L,0L,8L,6L,8L,7L,3L,4L,4L,1L,6L,4L,9L,4L,6L,9L,1L,4L,2L,7L,1L,9L,9L,3L,0L,7L,3L,2L,4L,6L,2L,8L,3L,7L,0L,3L,9L,3L,8L,6L,1L,2L,7L,9L,6L,2L,3L,0L,7L,0L,2L,0L,2L,5L,5L,9L,6L,3L,6L,9L,6L,2L,1L,5L,4L,6L,0L,7L,4L,4L,9L,1L,5L,9L,9L,7L,1L,5L,8L,1L,2L,8L,8L,0L,0L,7L,8L,5L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144875Inst : IEnumerable<long>
{
public static readonly long[] Value=A144875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144875.Bytes);
public long this[int i]=>Value[i];

public static A144875Inst Instance=new A144875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144874
{
public static readonly long[] Value={ 1L,2L,0L,0L,1L,-2L,1L,2L,-3L,0L,2L,0L,-1L,0L,-1L,0L,4L,-2L,-2L,0L,-1L,4L,1L,-4L,0L,2L,-2L,0L,2L,0L,-1L,2L,-1L,-4L,2L,0L,2L,2L,-2L,0L,-2L,-2L,3L,2L,-3L,0L,4L,-2L,-2L,2L,-2L,2L,0L,-4L,0L,4L,3L,-2L,-1L,-2L,0L,2L,-2L,-2L,2L,2L,2L,0L,-4L,0L,2L,-2L,1L,2L,-3L,-2L,4L,0L,-2L,2L,-2L,4L,0L,-4L,2L,-2L,-2L,2L,2L,-2L,-1L,4L,1L,-2L,2L,-2L,-4L,2L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144874Inst : IEnumerable<long>
{
public static readonly long[] Value=A144874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144874.Bytes);
public long this[int i]=>Value[i];

public static A144874Inst Instance=new A144874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144873
{
public static readonly long[] Value={ 0L,0L,2L,4L,7L,10L,14L,18L,24L,28L,35L,40L,47L,54L,62L,70L,80L,88L,98L,108L,120L,130L,142L,154L,168L,180L,194L,208L,223L,238L,255L,270L,288L,304L,322L,340L,359L,378L,398L,418L,440L,460L,482L,504L,527L,550L,574L,598L,624L,648L,675L,700L,727L,754L,782L,810L,840L,868L,898L,928L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144873Inst : IEnumerable<long>
{
public static readonly long[] Value=A144873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144873.Bytes);
public long this[int i]=>Value[i];

public static A144873Inst Instance=new A144873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144872
{
public static readonly long[] Value={ 1L,1L,3L,8L,5L,72L,7L,32L,27L,400L,11L,864L,13L,784L,675L,128L,17L,2592L,19L,1600L,1323L,3872L,23L,3456L,125L,5408L,243L,3136L,29L,324000L,31L,512L,9801L,18496L,6125L,31104L,37L,23104L,13689L,32000L,41L,254016L,43L,15488L,30375L,33856L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144872Inst : IEnumerable<long>
{
public static readonly long[] Value=A144872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144872.Bytes);
public long this[int i]=>Value[i];

public static A144872Inst Instance=new A144872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144855
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,254L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144855Inst : IEnumerable<long>
{
public static readonly long[] Value=A144855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144855.Bytes);
public long this[int i]=>Value[i];

public static A144855Inst Instance=new A144855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144854
{
public static readonly long[] Value={ 25L,99L,609L,650L,1189L,3479L,4901L,5429L,11659L,16275L,29469L,38479L,62525L,73814L,78089L,117739L,142449L,201116L,203319L,240199L,328769L,381275L,406900L,504889L,576909L,743775L,839629L,1005731L,1058819L,1183259L,1464709L,1622919L,1960244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144854Inst : IEnumerable<long>
{
public static readonly long[] Value=A144854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144854.Bytes);
public long this[int i]=>Value[i];

public static A144854Inst Instance=new A144854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144853
{
public static readonly BigInteger[] Value={ 1L,1L,21L,2541L,1023561L,1036809081L,2219782435101L,8923051855107621L,BigInteger.Parse("61797392100611962641"),BigInteger.Parse("690766390156657904866161"),BigInteger.Parse("11839493254591562294152214181"),BigInteger.Parse("298556076626963858753929987732701"),BigInteger.Parse("10706038142052878970311146962646277721"),BigInteger.Parse("530588758323899225681861502684757146635241") };
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
public class A144853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144853Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144853.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144853.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144853Inst Instance=new A144853Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144852
{
public static readonly long[] Value={ 9L,87L,836L,8000L,78124L,766585L,7556731L,74771106L,741554656L,7366252759L,73261462211L,729280694469L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144852Inst : IEnumerable<long>
{
public static readonly long[] Value=A144852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144852.Bytes);
public long this[int i]=>Value[i];

public static A144852Inst Instance=new A144852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144851
{
public static readonly long[] Value={ 8L,76L,760L,7445L,73477L,726948L,7218256L,71801859L,715087632L,7127665635L,71089166879L,709344259821L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144851Inst : IEnumerable<long>
{
public static readonly long[] Value=A144851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144851.Bytes);
public long this[int i]=>Value[i];

public static A144851Inst Instance=new A144851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144850
{
public static readonly long[] Value={ 8L,74L,734L,7233L,71653L,712026L,7090655L,70686855L,705173825L,7038475146L,70278276834L,701910715473L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144850Inst : IEnumerable<long>
{
public static readonly long[] Value=A144850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144850.Bytes);
public long this[int i]=>Value[i];

public static A144850Inst Instance=new A144850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144849
{
public static readonly BigInteger[] Value={ 1L,6L,336L,77616L,50916096L,76307083776L,226653840838656L,1207012936807028736L,BigInteger.Parse("10696277678308486742016"),BigInteger.Parse("148900090457044541209706496"),BigInteger.Parse("3110043187741674836967136690176"),BigInteger.Parse("93885206124269301790338015801901056"),BigInteger.Parse("3970859549814416912519992571903015387136") };
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
public class A144849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144849Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144849.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144849.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144849Inst Instance=new A144849Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144848
{
public static readonly long[] Value={ 7L,70L,720L,7102L,70780L,704537L,7026559L,70122424L,700184485L,6993568566L,69870544960L,698175242376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144848Inst : IEnumerable<long>
{
public static readonly long[] Value=A144848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144848.Bytes);
public long this[int i]=>Value[i];

public static A144848Inst Instance=new A144848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144847
{
public static readonly long[] Value={ 1L,2L,2L,8L,4L,8L,88L,22L,88L,44L,2048L,64L,1024L,256L,2048L,78656L,4916L,19664L,39328L,78656L,39328L,4439936L,34687L,277496L,1109984L,4439936L,1109984L,2219968L,344674688L,2692771L,21542168L,43084336L,344674688L,86168672L,172337344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144847Inst : IEnumerable<long>
{
public static readonly long[] Value=A144847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144847.Bytes);
public long this[int i]=>Value[i];

public static A144847Inst Instance=new A144847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144846
{
public static readonly long[] Value={ 0L,1L,-1L,7L,-5L,3L,87L,-35L,63L,-5L,2047L,-105L,819L,-45L,35L,78655L,-8085L,15939L,-7425L,1925L,-63L,4439935L,-57057L,225225L,-211497L,115115L,-2457L,231L,344674687L,-4429425L,17486469L,-8217495L,9003995L,-200655L,24255L,-429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144846Inst : IEnumerable<long>
{
public static readonly long[] Value=A144846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144846.Bytes);
public long this[int i]=>Value[i];

public static A144846Inst Instance=new A144846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144845
{
public static readonly long[] Value={ 1L,2L,6L,2L,30L,6L,42L,6L,30L,10L,66L,6L,2730L,210L,30L,6L,510L,30L,3990L,210L,2310L,330L,690L,30L,2730L,546L,42L,14L,870L,30L,14322L,462L,39270L,3570L,210L,6L,1919190L,51870L,2730L,210L,94710L,2310L,99330L,2310L,4830L,4830L,9870L,210L,46410L,6630L,14586L,858L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144845Inst : IEnumerable<long>
{
public static readonly long[] Value=A144845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144845.Bytes);
public long this[int i]=>Value[i];

public static A144845Inst Instance=new A144845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144844
{
public static readonly BigInteger[] Value={ 0L,1L,16L,196L,2304L,26896L,313600L,3655744L,42614784L,496754944L,5790601216L,67500196864L,786839961600L,9172078759936L,106917585289216L,1246322708463616L,14528202160472064L,169353135091941376L,1974124812461670400L,BigInteger.Parse("23012085209172803584") };
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
public class A144844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144844Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144844.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144844.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144844Inst Instance=new A144844Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144843
{
public static readonly BigInteger[] Value={ 1L,64L,2704L,102400L,3748096L,135675904L,4893282304L,176265625600L,6346852335616L,228502162898944L,8226263614357504L,296147719133593600L,10661344637077159936UL,BigInteger.Parse("383808727914259677184"),BigInteger.Parse("13817118056668205154304") };
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
public class A144843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144843Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144843.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144843.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144843Inst Instance=new A144843Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144842
{
public static readonly long[] Value={ 8L,14L,26L,56L,104L,134L,176L,194L,236L,266L,566L,596L,656L,824L,1016L,1226L,1286L,1484L,1604L,1616L,1874L,2084L,2336L,2546L,2966L,3254L,3326L,3464L,3536L,3764L,3914L,3926L,4016L,4214L,4256L,4646L,4796L,5006L,5276L,5474L,5654L,5846L,5864L,6266L,6356L,6566L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144842Inst : IEnumerable<long>
{
public static readonly long[] Value=A144842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144842.Bytes);
public long this[int i]=>Value[i];

public static A144842Inst Instance=new A144842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144841
{
public static readonly long[] Value={ 1L,1L,2L,11L,41L,121L,316L,757L,1961L,6281L,22166L,74031L,221937L,596961L,1460096L,3294761L,6945521L,13818417L,26161386L,47446611L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144841Inst : IEnumerable<long>
{
public static readonly long[] Value=A144841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144841.Bytes);
public long this[int i]=>Value[i];

public static A144841Inst Instance=new A144841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144840
{
public static readonly long[] Value={ 8L,14L,38L,68L,98L,104L,194L,224L,278L,308L,458L,614L,824L,854L,878L,1088L,1298L,1424L,1448L,1484L,1664L,1694L,1784L,1868L,1874L,1994L,2084L,2138L,2378L,2684L,2708L,2798L,3164L,3254L,3458L,3464L,3848L,4154L,4514L,4784L,5228L,5414L,5438L,5648L,5654L,5738L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144840Inst : IEnumerable<long>
{
public static readonly long[] Value=A144840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144840.Bytes);
public long this[int i]=>Value[i];

public static A144840Inst Instance=new A144840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144807
{
public static readonly long[] Value={ 3L,0L,8L,4L,3L,5L,1L,0L,4L,9L,0L,6L,9L,1L,8L,9L,9L,0L,2L,3L,3L,5L,6L,9L,3L,2L,0L,0L,2L,0L,2L,7L,2L,1L,4L,8L,8L,7L,5L,0L,1L,1L,0L,8L,9L,8L,3L,7L,3L,9L,8L,8L,4L,8L,4L,7L,6L,4L,4L,2L,2L,3L,7L,0L,9L,6L,5L,6L,9L,1L,8L,8L,1L,9L,5L,7L,3L,4L,7L,8L,3L,1L,3L,9L,3L,3L,7L,4L,9L,2L,9L,4L,2L,2L,7L,8L,5L,4L,9L,5L,1L,8L,5L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144807Inst : IEnumerable<long>
{
public static readonly long[] Value=A144807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144807.Bytes);
public long this[int i]=>Value[i];

public static A144807Inst Instance=new A144807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144806
{
public static readonly long[] Value={ 2L,9L,1L,8L,0L,1L,2L,0L,6L,9L,1L,4L,1L,0L,7L,7L,3L,0L,6L,2L,3L,2L,1L,4L,4L,4L,4L,8L,9L,4L,1L,3L,4L,9L,9L,6L,3L,5L,2L,9L,9L,5L,8L,3L,9L,3L,3L,5L,3L,8L,3L,3L,3L,0L,0L,8L,5L,3L,1L,2L,4L,0L,2L,0L,8L,3L,8L,7L,6L,8L,0L,2L,0L,1L,2L,8L,3L,2L,2L,6L,0L,4L,0L,5L,6L,1L,1L,6L,6L,8L,0L,4L,5L,6L,5L,1L,5L,6L,3L,1L,1L,7L,7L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144806Inst : IEnumerable<long>
{
public static readonly long[] Value=A144806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144806.Bytes);
public long this[int i]=>Value[i];

public static A144806Inst Instance=new A144806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144805
{
public static readonly long[] Value={ 2L,7L,4L,1L,6L,7L,7L,4L,7L,4L,4L,4L,2L,3L,3L,7L,7L,6L,7L,7L,6L,0L,3L,0L,4L,4L,5L,3L,3L,3L,6L,4L,7L,7L,4L,1L,8L,9L,7L,3L,3L,1L,2L,8L,1L,9L,7L,4L,4L,3L,9L,7L,5L,0L,9L,3L,1L,8L,1L,4L,0L,0L,0L,2L,4L,7L,6L,8L,4L,6L,8L,3L,2L,7L,8L,3L,9L,3L,5L,6L,7L,8L,3L,4L,4L,3L,9L,4L,6L,6L,1L,6L,8L,6L,3L,5L,3L,1L,0L,9L,7L,6L,0L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144805Inst : IEnumerable<long>
{
public static readonly long[] Value=A144805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144805.Bytes);
public long this[int i]=>Value[i];

public static A144805Inst Instance=new A144805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144804
{
public static readonly long[] Value={ 2L,3L,5L,0L,1L,1L,7L,3L,8L,4L,0L,2L,2L,7L,6L,0L,0L,7L,6L,1L,2L,9L,7L,2L,3L,4L,0L,7L,2L,4L,8L,9L,2L,5L,9L,8L,9L,2L,2L,6L,3L,0L,5L,9L,0L,5L,0L,2L,4L,0L,3L,5L,7L,9L,7L,4L,8L,5L,3L,3L,5L,2L,5L,5L,6L,6L,1L,1L,9L,2L,6L,5L,4L,7L,8L,8L,0L,2L,5L,5L,8L,4L,2L,5L,9L,8L,2L,9L,6L,4L,4L,8L,4L,3L,5L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144804Inst : IEnumerable<long>
{
public static readonly long[] Value=A144804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144804.Bytes);
public long this[int i]=>Value[i];

public static A144804Inst Instance=new A144804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144803
{
public static readonly long[] Value={ 2L,1L,2L,7L,9L,9L,5L,9L,0L,7L,4L,6L,4L,1L,0L,7L,0L,5L,4L,5L,7L,7L,3L,5L,1L,9L,4L,8L,1L,4L,0L,4L,9L,8L,7L,8L,3L,8L,0L,9L,4L,4L,0L,9L,2L,7L,5L,5L,4L,6L,2L,0L,2L,3L,3L,8L,7L,7L,6L,1L,4L,4L,0L,8L,2L,5L,3L,9L,7L,9L,1L,6L,7L,9L,6L,2L,7L,6L,3L,4L,9L,2L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144803Inst : IEnumerable<long>
{
public static readonly long[] Value=A144803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144803.Bytes);
public long this[int i]=>Value[i];

public static A144803Inst Instance=new A144803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144802
{
public static readonly long[] Value={ 1L,8L,8L,0L,6L,7L,8L,5L,4L,3L,6L,8L,3L,0L,7L,8L,0L,9L,4L,4L,9L,2L,1L,9L,1L,7L,6L,5L,0L,1L,2L,7L,5L,0L,3L,5L,6L,2L,6L,3L,0L,6L,1L,7L,5L,6L,3L,2L,3L,6L,3L,0L,1L,9L,6L,9L,0L,4L,7L,9L,9L,5L,9L,5L,3L,3L,9L,1L,4L,7L,9L,8L,7L,1L,7L,6L,9L,5L,3L,9L,5L,2L,0L,4L,0L,8L,7L,3L,5L,8L,0L,9L,0L,8L,7L,4L,1L,9L,4L,1L,2L,4L,5L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144802Inst : IEnumerable<long>
{
public static readonly long[] Value=A144802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144802.Bytes);
public long this[int i]=>Value[i];

public static A144802Inst Instance=new A144802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144801
{
public static readonly long[] Value={ 36990L,37230L,38670L,43350L,45390L,14492490L,14496810L,14512170L,14578050L,14579970L,14630970L,14655810L,14663730L,14685690L,14733810L,14741790L,14753010L,14758350L,14761350L,14779230L,14779710L,14780310L,14784090L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144801Inst : IEnumerable<long>
{
public static readonly long[] Value=A144801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144801.Bytes);
public long this[int i]=>Value[i];

public static A144801Inst Instance=new A144801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144800
{
public static readonly long[] Value={ 3468L,3696L,3864L,3984L,33918L,34158L,34674L,36294L,36990L,37230L,37302L,37326L,37722L,38046L,38106L,38322L,38478L,38670L,38682L,38730L,40038L,40086L,40326L,40722L,41334L,43350L,45270L,45390L,49278L,49518L,49638L,49878L,49950L,50478L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144800Inst : IEnumerable<long>
{
public static readonly long[] Value=A144800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144800.Bytes);
public long this[int i]=>Value[i];

public static A144800Inst Instance=new A144800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144799
{
public static readonly long[] Value={ 141L,147L,153L,177L,195L,201L,225L,2079L,2109L,2418L,2424L,2508L,2652L,2868L,2892L,2898L,3102L,3126L,3150L,3228L,3282L,3288L,3300L,3312L,3342L,3354L,3366L,3378L,3384L,3426L,3462L,3468L,3474L,3504L,3522L,3528L,3696L,3792L,3846L,3852L,3864L,3912L,3936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144799Inst : IEnumerable<long>
{
public static readonly long[] Value=A144799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144799.Bytes);
public long this[int i]=>Value[i];

public static A144799Inst Instance=new A144799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144798
{
public static readonly long[] Value={ 38L,42L,56L,139L,141L,147L,153L,169L,177L,195L,201L,225L,542L,558L,572L,598L,604L,654L,666L,678L,684L,779L,781L,803L,805L,835L,899L,905L,913L,929L,2079L,2107L,2109L,2266L,2390L,2396L,2410L,2418L,2424L,2474L,2482L,2506L,2508L,2536L,2606L,2614L,2638L,2650L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144798Inst : IEnumerable<long>
{
public static readonly long[] Value=A144798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144798.Bytes);
public long this[int i]=>Value[i];

public static A144798Inst Instance=new A144798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144797
{
public static readonly long[] Value={ 2L,4L,16L,26L,94L,152L,548L,886L,3194L,5164L,18616L,30098L,108502L,175424L,632396L,1022446L,3685874L,5959252L,21482848L,34733066L,125211214L,202439144L,729784436L,1179901798L,4253495402L,6876971644L,24791187976L,40081928066L,144493632454L,233614596752L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144797Inst : IEnumerable<long>
{
public static readonly long[] Value=A144797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144797.Bytes);
public long this[int i]=>Value[i];

public static A144797Inst Instance=new A144797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144796
{
public static readonly BigInteger[] Value={ 5L,215L,4517L,248087L,5212613L,286292183L,6015350885L,330380931095L,6941709708677L,381259308191447L,8010726988462373L,439972911271998743L,9244372002975869765UL,BigInteger.Parse("507728358348578357975"),BigInteger.Parse("10667997280707165246437") };
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
public class A144796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144796Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144796.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144796.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144796Inst Instance=new A144796Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144795
{
public static readonly long[] Value={ 3L,6L,7L,12L,14L,15L,24L,27L,28L,30L,31L,48L,51L,54L,55L,56L,59L,60L,62L,63L,96L,99L,102L,103L,108L,110L,111L,112L,115L,118L,119L,120L,123L,124L,126L,127L,192L,195L,198L,199L,204L,206L,207L,216L,219L,220L,222L,223L,224L,227L,230L,231L,236L,238L,239L,240L,243L,246L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144795Inst : IEnumerable<long>
{
public static readonly long[] Value=A144795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144795.Bytes);
public long this[int i]=>Value[i];

public static A144795Inst Instance=new A144795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144794
{
public static readonly long[] Value={ 4L,8L,9L,12L,16L,17L,19L,24L,25L,28L,32L,33L,35L,36L,39L,48L,49L,51L,56L,57L,60L,64L,65L,67L,68L,71L,72L,73L,76L,79L,96L,97L,99L,100L,103L,112L,113L,115L,120L,121L,124L,128L,129L,131L,132L,135L,136L,137L,140L,143L,144L,145L,147L,152L,153L,156L,159L,192L,193L,195L,196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144794Inst : IEnumerable<long>
{
public static readonly long[] Value=A144794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144794.Bytes);
public long this[int i]=>Value[i];

public static A144794Inst Instance=new A144794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144793
{
public static readonly long[] Value={ 2L,5L,10L,11L,12L,13L,18L,20L,21L,22L,23L,26L,29L,34L,37L,38L,40L,41L,42L,43L,44L,45L,46L,47L,50L,51L,52L,53L,56L,58L,61L,66L,69L,70L,74L,75L,77L,78L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,90L,91L,92L,93L,94L,95L,98L,101L,103L,104L,105L,106L,107L,109L,114L,115L,116L,117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144793Inst : IEnumerable<long>
{
public static readonly long[] Value=A144793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144793.Bytes);
public long this[int i]=>Value[i];

public static A144793Inst Instance=new A144793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144792
{
public static readonly BigInteger[] Value={ 1L,1L,5L,33L,282L,2938L,36029L,507440L,8058990L,142315830L,2763775025L,58498072273L,1339545500214L,32980132065364L,868417100538399L,24344702489881998L,723694354351500431L,BigInteger.Parse("22733368105181643193"),BigInteger.Parse("752291980101845144878"),BigInteger.Parse("26153153055424960528533") };
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
public class A144792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144792Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144792.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144792.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144792Inst Instance=new A144792Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144775
{
public static readonly long[] Value={ 0L,1L,2L,0L,4L,0L,6L,3L,2L,0L,10L,0L,12L,0L,0L,4L,16L,8L,18L,0L,0L,0L,22L,13L,7L,0L,2L,0L,28L,0L,30L,5L,0L,0L,0L,16L,36L,0L,0L,24L,40L,0L,42L,0L,21L,0L,46L,16L,13L,15L,0L,0L,52L,11L,0L,35L,0L,0L,58L,0L,60L,0L,31L,5L,0L,0L,66L,0L,0L,0L,70L,20L,72L,0L,27L,0L,0L,0L,78L,32L,2L,0L,82L,0L,0L,0L,0L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144775Inst : IEnumerable<long>
{
public static readonly long[] Value=A144775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144775.Bytes);
public long this[int i]=>Value[i];

public static A144775Inst Instance=new A144775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144774
{
public static readonly long[] Value={ 0L,1L,2L,1L,4L,5L,6L,1L,4L,9L,10L,7L,12L,13L,14L,1L,16L,8L,18L,12L,20L,21L,22L,8L,7L,25L,5L,19L,28L,29L,30L,1L,32L,33L,34L,11L,36L,37L,38L,17L,40L,41L,42L,28L,24L,45L,46L,11L,17L,19L,50L,35L,52L,11L,54L,26L,56L,57L,58L,40L,60L,61L,33L,1L,64L,65L,66L,46L,68L,69L,70L,12L,72L,73L,31L,52L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144774Inst : IEnumerable<long>
{
public static readonly long[] Value=A144774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144774.Bytes);
public long this[int i]=>Value[i];

public static A144774Inst Instance=new A144774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144773
{
public static readonly BigInteger[] Value={ 1L,1L,11L,231L,7161L,293601L,14973651L,913392711L,64850882481L,5252921480961L,478015854767451L,48279601331512551L,5359035747797893161L,BigInteger.Parse("648443325483545072481"),BigInteger.Parse("84946075638344404495011") };
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
public class A144773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144773Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144773.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144773.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144773Inst Instance=new A144773Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144772
{
public static readonly BigInteger[] Value={ 1L,1L,10L,190L,5320L,196840L,9054640L,498005200L,31872332800L,2326680294400L,190787784140800L,17361688356812800L,1736168835681280000L,BigInteger.Parse("189242403089259520000"),BigInteger.Parse("22330603564532623360000") };
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
public class A144772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144772Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144772.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144772.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144772Inst Instance=new A144772Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144771
{
public static readonly long[] Value={ 1L,2L,3L,6L,12L,36L,84L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144771Inst : IEnumerable<long>
{
public static readonly long[] Value=A144771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144771.Bytes);
public long this[int i]=>Value[i];

public static A144771Inst Instance=new A144771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144770
{
public static readonly long[] Value={ 840L,1128L,1218L,1240L,1242L,1254L,1288L,1330L,1434L,1485L,1528L,1738L,1786L,1798L,1869L,1917L,1947L,2001L,2065L,2157L,2185L,2233L,2261L,2395L,2513L,2629L,2759L,2773L,2879L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144770Inst : IEnumerable<long>
{
public static readonly long[] Value=A144770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144770.Bytes);
public long this[int i]=>Value[i];

public static A144770Inst Instance=new A144770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144769
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,4L,5L,6L,7L,9L,10L,12L,13L,14L,15L,17L,19L,20L,22L,23L,24L,26L,27L,29L,32L,33L,34L,35L,36L,37L,42L,43L,45L,46L,49L,50L,52L,54L,55L,57L,59L,60L,63L,64L,65L,66L,70L,74L,75L,76L,77L,79L,80L,83L,85L,87L,89L,90L,92L,93L,94L,97L,102L,103L,104L,105L,110L,112L,115L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144769Inst : IEnumerable<long>
{
public static readonly long[] Value=A144769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144769.Bytes);
public long this[int i]=>Value[i];

public static A144769Inst Instance=new A144769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144768
{
public static readonly BigInteger[] Value={ 1L,0L,-510L,-19677L,-262120L,-1953005L,-10076976L,-40348567L,-134177408L,-387057609L,-996371200L,-2318030891L,-4680778752L,-4377478573L,66517244416L,1269231008625L,20854070411264L,355568840219503L,6402175346437632L,121644777721134221L,2432901496176640000L,BigInteger.Parse("51090941377429393419") };
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
public class A144768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144768Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144768.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144768.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144768Inst Instance=new A144768Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144767
{
public static readonly BigInteger[] Value={ 719L,5033L,40256L,362151L,3618800L,39755749L,476015616L,6164272283L,85702502144L,1269231008625L,19823278260224L,321415531788367L,5245542324301824L,79592116946574941L,794502008176640000L,BigInteger.Parse("-17031376411242242301"),BigInteger.Parse("-1887360768561457463296") };
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
public class A144767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144767Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144767.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144767.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144767Inst Instance=new A144767Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144766
{
public static readonly long[] Value={ 121L,10001L,10201L,36763L,1226221L,7673767L,12467976421L,1030507050301L,1120237320211L,1225559555221L,1234469644321L,1334459544331L,100330272033001L,100827848728001L,101222252222101L,103023070320301L,121363494363121L,134312696213431L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144766Inst : IEnumerable<long>
{
public static readonly long[] Value=A144766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144766.Bytes);
public long this[int i]=>Value[i];

public static A144766Inst Instance=new A144766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144765
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,2L,0L,2L,1L,2L,0L,3L,0L,4L,2L,4L,0L,4L,1L,4L,3L,5L,0L,7L,0L,6L,4L,6L,3L,7L,0L,6L,4L,6L,0L,8L,0L,8L,7L,8L,0L,10L,2L,10L,6L,10L,0L,12L,5L,10L,6L,10L,0L,12L,0L,10L,8L,10L,5L,14L,0L,12L,8L,15L,0L,16L,0L,13L,12L,14L,6L,19L,0L,17L,10L,15L,0L,19L,7L,15L,10L,15L,0L,19L,6L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144765Inst : IEnumerable<long>
{
public static readonly long[] Value=A144765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144765.Bytes);
public long this[int i]=>Value[i];

public static A144765Inst Instance=new A144765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144764
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,2L,0L,1L,0L,2L,0L,3L,0L,2L,0L,4L,0L,3L,0L,2L,1L,6L,0L,7L,1L,3L,1L,4L,0L,7L,1L,3L,1L,7L,0L,8L,1L,3L,2L,10L,0L,8L,1L,5L,2L,12L,0L,7L,2L,6L,2L,12L,0L,12L,2L,5L,3L,8L,0L,14L,3L,7L,1L,16L,0L,16L,3L,5L,4L,12L,0L,19L,2L,9L,4L,19L,0L,12L,4L,9L,4L,19L,0L,13L,4L,10L,4L,13L,0L,20L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144764Inst : IEnumerable<long>
{
public static readonly long[] Value=A144764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144764.Bytes);
public long this[int i]=>Value[i];

public static A144764Inst Instance=new A144764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144763
{
public static readonly long[] Value={ 1L,6L,10L,3L,2L,6L,30L,1L,42L,6L,15L,78L,21L,10L,30L,6L,42L,5L,210L,15L,30L,3L,330L,390L,105L,510L,546L,570L,70L,195L,210L,110L,42L,130L,35L,330L,30L,66L,105L,210L,21L,2310L,2730L,14L,210L,3570L,3990L,4290L,1155L,4830L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144763Inst : IEnumerable<long>
{
public static readonly long[] Value=A144763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144763.Bytes);
public long this[int i]=>Value[i];

public static A144763Inst Instance=new A144763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144762
{
public static readonly long[] Value={ 2L,6L,10L,6L,6L,6L,30L,6L,42L,6L,30L,78L,42L,30L,30L,30L,42L,30L,210L,30L,30L,30L,330L,390L,210L,510L,546L,570L,210L,390L,210L,330L,210L,390L,210L,330L,210L,330L,210L,210L,210L,2310L,2730L,210L,210L,3570L,3990L,4290L,2310L,4830L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144762Inst : IEnumerable<long>
{
public static readonly long[] Value=A144762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144762.Bytes);
public long this[int i]=>Value[i];

public static A144762Inst Instance=new A144762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144761
{
public static readonly long[] Value={ 4L,6L,10L,12L,18L,24L,30L,36L,42L,54L,60L,78L,84L,90L,120L,150L,168L,180L,210L,240L,270L,300L,330L,390L,420L,510L,546L,570L,630L,780L,840L,990L,1050L,1170L,1260L,1320L,1470L,1650L,1680L,1890L,2100L,2310L,2730L,3150L,3360L,3570L,3990L,4290L,4620L,4830L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144761Inst : IEnumerable<long>
{
public static readonly long[] Value=A144761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144761.Bytes);
public long this[int i]=>Value[i];

public static A144761Inst Instance=new A144761Inst();

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