using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A201505
{
public static readonly long[] Value={ 8L,7L,7L,5L,8L,2L,5L,6L,1L,8L,9L,0L,3L,7L,2L,7L,1L,6L,1L,1L,6L,2L,8L,1L,5L,8L,2L,6L,0L,3L,8L,2L,9L,6L,5L,1L,9L,9L,1L,6L,4L,5L,1L,9L,7L,1L,0L,9L,7L,4L,4L,0L,5L,2L,9L,9L,7L,6L,1L,0L,8L,6L,8L,3L,1L,5L,9L,5L,0L,7L,6L,3L,2L,7L,4L,2L,1L,3L,9L,4L,7L,4L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201505Inst : IEnumerable<long>
{
public static readonly long[] Value=A201505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201505.Bytes);
public long this[int i]=>Value[i];

public static A201505Inst Instance=new A201505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201506
{
public static readonly long[] Value={ 1L,0L,5L,7L,4L,7L,3L,5L,5L,3L,7L,0L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201506Inst : IEnumerable<long>
{
public static readonly long[] Value=A201506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201506.Bytes);
public long this[int i]=>Value[i];

public static A201506Inst Instance=new A201506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201507
{
public static readonly long[] Value={ 0L,0L,0L,20L,12798L,763144L,15516804L,170842828L,1264750240L,7084450248L,32251861624L,125030824732L,426265242412L,1308045124808L,3675893768908L,9586626461484L,23445303141400L,54219244028296L,119372323892736L,251614892723068L,510130577706724L,998740710435208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201507Inst : IEnumerable<long>
{
public static readonly long[] Value=A201507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201507.Bytes);
public long this[int i]=>Value[i];

public static A201507Inst Instance=new A201507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201508
{
public static readonly long[] Value={ 0L,0L,0L,2L,7157L,1143638L,44031035L,771464278L,8219304992L,62114308624L,364798895986L,1765597908290L,7329246973785L,26849172347850L,88645482921449L,268042562131202L,751635857876290L,1974215715426992L,4896315981217168L,11542835604897814L,26008912447737323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201508Inst : IEnumerable<long>
{
public static readonly long[] Value=A201508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201508.Bytes);
public long this[int i]=>Value[i];

public static A201508Inst Instance=new A201508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201509
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,5L,1L,8L,12L,4L,16L,28L,13L,1L,32L,64L,38L,6L,64L,144L,104L,25L,1L,128L,320L,272L,88L,8L,256L,704L,688L,280L,41L,1L,512L,1536L,1696L,832L,170L,10L,1024L,3328L,4096L,2352L,620L,61L,1L,2048L,7168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201509Inst : IEnumerable<long>
{
public static readonly long[] Value=A201509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201509.Bytes);
public long this[int i]=>Value[i];

public static A201509Inst Instance=new A201509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201510
{
public static readonly long[] Value={ 0L,0L,0L,0L,2578L,1247116L,97284860L,2817340064L,44218721793L,457851259868L,3506596268191L,21355746900992L,108582220087480L,477032549147428L,1857084405493128L,6529640029479296L,21044674478336823L,62903854631232636L,176034055470126073L,464793685059669728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201510Inst : IEnumerable<long>
{
public static readonly long[] Value=A201510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201510.Bytes);
public long this[int i]=>Value[i];

public static A201510Inst Instance=new A201510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201511
{
public static readonly BigInteger[] Value={ 1L,2L,22L,405L,10741L,368868L,15516804L,771464278L,44218721793L,2868879752822L,207739939478618L,16602826428818482L,1451305771147909684L,BigInteger.Parse("137715836041691050398"),BigInteger.Parse("14096224186664736126206"),BigInteger.Parse("1547966111897855935957132"),BigInteger.Parse("181519663430661533452513680"),BigInteger.Parse("22636566614411901986006002896") };
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
public class A201511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201511Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201511.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201511Inst Instance=new A201511Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201512
{
public static readonly long[] Value={ 5L,6L,8L,9L,10L,11L,13L,14L,16L,17L,19L,20L,21L,22L,23L,24L,27L,28L,29L,30L,32L,33L,34L,35L,37L,38L,39L,40L,42L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201512Inst : IEnumerable<long>
{
public static readonly long[] Value=A201512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201512.Bytes);
public long this[int i]=>Value[i];

public static A201512Inst Instance=new A201512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201513
{
public static readonly BigInteger[] Value={ 1L,1L,0L,8L,79L,1974L,62266L,2484382L,119138166L,6655170642L,423677826986L,30242576462856L,2390359529372724L,207127434998494421L,BigInteger.Parse("19516867860507198208"),BigInteger.Parse("1986288643031862123264"),BigInteger.Parse("217094567491104327256049"),BigInteger.Parse("25357029929230564723578520"),BigInteger.Parse("3151672341378566296926684684") };
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
public class A201513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201513Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201513.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201513Inst Instance=new A201513Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201514
{
public static readonly long[] Value={ 6L,10L,14L,15L,21L,22L,26L,33L,34L,35L,38L,39L,46L,51L,55L,57L,58L,62L,65L,69L,77L,82L,87L,91L,93L,95L,106L,119L,122L,123L,133L,155L,159L,161L,183L,187L,202L,203L,213L,265L,287L,299L,319L,355L,453L,497L,505L,583L,671L,1057L,1313L,1963L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201514Inst : IEnumerable<long>
{
public static readonly long[] Value=A201514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201514.Bytes);
public long this[int i]=>Value[i];

public static A201514Inst Instance=new A201514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201515
{
public static readonly long[] Value={ 9L,5L,3L,5L,3L,9L,0L,9L,7L,5L,4L,9L,9L,1L,4L,6L,8L,9L,6L,6L,7L,2L,7L,0L,6L,9L,5L,3L,7L,2L,3L,7L,8L,2L,2L,7L,4L,3L,3L,6L,0L,9L,6L,5L,6L,0L,5L,1L,5L,1L,6L,0L,6L,8L,0L,6L,9L,6L,9L,6L,0L,1L,9L,7L,9L,7L,3L,5L,6L,7L,6L,1L,0L,2L,2L,9L,8L,0L,9L,1L,3L,6L,4L,7L,8L,7L,6L,9L,4L,7L,8L,2L,7L,9L,5L,7L,4L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201515Inst : IEnumerable<long>
{
public static readonly long[] Value=A201515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201515.Bytes);
public long this[int i]=>Value[i];

public static A201515Inst Instance=new A201515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201516
{
public static readonly long[] Value={ 1L,3L,4L,1L,4L,3L,0L,1L,6L,6L,2L,9L,1L,2L,5L,9L,7L,6L,4L,5L,7L,6L,0L,8L,0L,5L,0L,6L,7L,6L,3L,6L,1L,4L,1L,7L,1L,7L,7L,1L,4L,0L,8L,2L,9L,1L,7L,9L,4L,8L,3L,0L,1L,1L,3L,0L,7L,5L,1L,6L,4L,3L,7L,7L,1L,8L,0L,4L,9L,8L,8L,2L,4L,9L,6L,7L,8L,0L,0L,0L,6L,9L,8L,5L,4L,2L,0L,4L,6L,3L,0L,5L,8L,6L,0L,2L,4L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201516Inst : IEnumerable<long>
{
public static readonly long[] Value=A201516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201516.Bytes);
public long this[int i]=>Value[i];

public static A201516Inst Instance=new A201516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201517
{
public static readonly long[] Value={ 7L,7L,4L,4L,2L,7L,2L,5L,7L,0L,7L,9L,8L,9L,3L,6L,2L,3L,2L,5L,7L,0L,2L,9L,0L,0L,9L,0L,0L,0L,6L,2L,4L,5L,6L,3L,9L,8L,5L,9L,1L,3L,6L,7L,7L,8L,3L,5L,0L,7L,9L,2L,6L,8L,7L,8L,4L,2L,5L,9L,1L,6L,0L,5L,0L,5L,9L,2L,7L,3L,0L,3L,6L,8L,2L,5L,8L,1L,2L,4L,6L,4L,8L,7L,2L,7L,2L,4L,4L,6L,5L,7L,4L,2L,9L,1L,6L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201517Inst : IEnumerable<long>
{
public static readonly long[] Value=A201517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201517.Bytes);
public long this[int i]=>Value[i];

public static A201517Inst Instance=new A201517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201518
{
public static readonly long[] Value={ 1L,4L,3L,1L,3L,6L,3L,5L,5L,0L,0L,6L,9L,0L,3L,9L,1L,3L,5L,7L,6L,4L,0L,4L,4L,9L,9L,3L,7L,8L,2L,7L,5L,4L,2L,1L,3L,0L,4L,1L,2L,3L,9L,5L,6L,8L,1L,7L,9L,9L,6L,4L,5L,3L,6L,5L,1L,5L,2L,4L,6L,6L,6L,2L,8L,0L,3L,0L,0L,3L,3L,6L,4L,7L,5L,9L,5L,6L,4L,3L,9L,0L,3L,8L,9L,5L,2L,1L,6L,2L,8L,8L,2L,5L,4L,7L,9L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201518Inst : IEnumerable<long>
{
public static readonly long[] Value=A201518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201518.Bytes);
public long this[int i]=>Value[i];

public static A201518Inst Instance=new A201518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201519
{
public static readonly long[] Value={ 6L,7L,5L,4L,8L,2L,9L,0L,8L,1L,1L,3L,7L,2L,4L,2L,2L,8L,0L,1L,5L,1L,7L,8L,8L,5L,8L,1L,9L,0L,8L,2L,7L,3L,1L,5L,9L,4L,1L,0L,7L,4L,0L,1L,2L,5L,4L,4L,0L,8L,8L,0L,7L,9L,6L,4L,4L,8L,5L,0L,8L,0L,4L,5L,2L,7L,2L,3L,7L,1L,5L,8L,0L,3L,2L,5L,1L,7L,3L,9L,1L,3L,5L,7L,5L,5L,1L,1L,7L,5L,3L,3L,0L,3L,5L,5L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201519Inst : IEnumerable<long>
{
public static readonly long[] Value=A201519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201519.Bytes);
public long this[int i]=>Value[i];

public static A201519Inst Instance=new A201519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201520
{
public static readonly long[] Value={ 1L,4L,6L,8L,3L,7L,4L,2L,9L,2L,0L,3L,3L,2L,8L,2L,9L,3L,7L,6L,5L,5L,4L,6L,8L,7L,8L,1L,5L,8L,0L,5L,4L,6L,6L,9L,4L,6L,9L,2L,0L,5L,9L,7L,4L,2L,8L,6L,1L,4L,1L,7L,5L,6L,0L,3L,2L,9L,3L,8L,4L,9L,7L,7L,5L,5L,7L,5L,6L,9L,6L,9L,3L,6L,9L,2L,3L,4L,0L,7L,1L,4L,5L,9L,7L,9L,0L,3L,1L,1L,3L,5L,3L,2L,8L,4L,7L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201520Inst : IEnumerable<long>
{
public static readonly long[] Value=A201520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201520.Bytes);
public long this[int i]=>Value[i];

public static A201520Inst Instance=new A201520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201521
{
public static readonly long[] Value={ 6L,0L,8L,0L,5L,4L,4L,7L,7L,9L,9L,7L,9L,1L,3L,0L,5L,3L,3L,2L,7L,9L,9L,5L,7L,2L,2L,5L,1L,0L,8L,9L,7L,6L,1L,7L,8L,8L,5L,3L,2L,9L,6L,8L,8L,0L,9L,3L,5L,3L,6L,0L,8L,7L,7L,7L,4L,5L,4L,0L,5L,6L,5L,6L,6L,4L,3L,4L,7L,5L,2L,1L,6L,4L,7L,2L,0L,8L,0L,8L,5L,1L,2L,1L,0L,0L,0L,3L,6L,7L,9L,4L,8L,7L,2L,9L,3L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201521Inst : IEnumerable<long>
{
public static readonly long[] Value=A201521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201521.Bytes);
public long this[int i]=>Value[i];

public static A201521Inst Instance=new A201521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201522
{
public static readonly long[] Value={ 1L,4L,8L,9L,4L,8L,0L,6L,5L,6L,7L,3L,1L,8L,3L,3L,3L,2L,0L,3L,9L,9L,1L,2L,6L,0L,1L,7L,6L,7L,7L,3L,1L,7L,5L,4L,4L,9L,4L,3L,3L,6L,9L,1L,4L,8L,0L,6L,1L,5L,0L,7L,0L,4L,7L,3L,0L,5L,6L,8L,8L,5L,1L,9L,2L,7L,5L,0L,4L,5L,7L,7L,5L,1L,2L,6L,7L,8L,1L,6L,2L,9L,7L,4L,3L,0L,6L,2L,3L,7L,3L,9L,0L,3L,5L,3L,3L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201522Inst : IEnumerable<long>
{
public static readonly long[] Value=A201522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201522.Bytes);
public long this[int i]=>Value[i];

public static A201522Inst Instance=new A201522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201523
{
public static readonly long[] Value={ 5L,5L,7L,8L,9L,5L,1L,7L,5L,7L,7L,9L,0L,3L,5L,2L,9L,9L,8L,3L,2L,8L,6L,9L,7L,3L,6L,3L,1L,3L,8L,7L,3L,7L,9L,8L,3L,9L,2L,7L,5L,7L,3L,9L,8L,4L,7L,4L,4L,1L,5L,3L,6L,3L,8L,0L,6L,8L,1L,1L,8L,6L,2L,6L,2L,0L,8L,9L,0L,3L,8L,8L,6L,4L,1L,1L,8L,6L,4L,3L,1L,4L,9L,8L,1L,9L,8L,7L,9L,0L,5L,1L,2L,7L,0L,9L,2L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201523Inst : IEnumerable<long>
{
public static readonly long[] Value=A201523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201523.Bytes);
public long this[int i]=>Value[i];

public static A201523Inst Instance=new A201523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201524
{
public static readonly long[] Value={ 1L,5L,0L,3L,2L,6L,2L,1L,5L,2L,1L,3L,1L,4L,9L,3L,0L,9L,9L,9L,1L,9L,0L,7L,9L,9L,0L,7L,5L,2L,0L,0L,8L,3L,0L,8L,2L,9L,0L,8L,3L,4L,3L,1L,7L,1L,5L,6L,2L,7L,8L,2L,9L,3L,8L,3L,2L,1L,0L,3L,3L,2L,1L,4L,8L,8L,7L,2L,7L,4L,9L,7L,2L,3L,3L,7L,5L,1L,4L,2L,4L,9L,8L,0L,0L,9L,9L,4L,8L,7L,2L,9L,9L,6L,6L,2L,0L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201524Inst : IEnumerable<long>
{
public static readonly long[] Value=A201524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201524.Bytes);
public long this[int i]=>Value[i];

public static A201524Inst Instance=new A201524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201525
{
public static readonly long[] Value={ 5L,1L,8L,5L,7L,7L,0L,0L,2L,2L,0L,1L,7L,1L,1L,4L,5L,8L,2L,5L,3L,1L,0L,9L,8L,2L,0L,4L,1L,7L,2L,4L,4L,9L,9L,4L,8L,3L,1L,0L,4L,3L,3L,3L,7L,0L,3L,4L,8L,6L,2L,9L,7L,2L,7L,1L,9L,3L,3L,8L,9L,8L,0L,8L,1L,5L,4L,5L,0L,6L,9L,7L,3L,1L,1L,0L,2L,9L,7L,7L,7L,1L,8L,4L,3L,4L,8L,1L,3L,2L,6L,4L,1L,2L,8L,0L,7L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201525Inst : IEnumerable<long>
{
public static readonly long[] Value=A201525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201525.Bytes);
public long this[int i]=>Value[i];

public static A201525Inst Instance=new A201525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201526
{
public static readonly long[] Value={ 1L,5L,1L,3L,0L,0L,5L,7L,3L,7L,4L,4L,7L,7L,4L,9L,0L,9L,7L,7L,7L,4L,6L,9L,3L,0L,5L,4L,0L,1L,2L,0L,7L,0L,4L,4L,6L,0L,1L,9L,5L,5L,8L,8L,8L,6L,9L,4L,3L,2L,2L,3L,4L,2L,0L,4L,7L,3L,9L,1L,8L,7L,6L,1L,2L,1L,5L,8L,8L,2L,8L,9L,4L,5L,6L,1L,0L,7L,7L,4L,1L,4L,7L,8L,7L,3L,8L,0L,0L,8L,6L,2L,7L,8L,8L,7L,6L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201526Inst : IEnumerable<long>
{
public static readonly long[] Value=A201526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201526.Bytes);
public long this[int i]=>Value[i];

public static A201526Inst Instance=new A201526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201527
{
public static readonly long[] Value={ 4L,8L,6L,6L,3L,6L,5L,1L,3L,4L,4L,2L,8L,2L,8L,7L,9L,6L,4L,1L,5L,0L,1L,0L,6L,8L,8L,8L,7L,7L,4L,0L,5L,3L,0L,6L,1L,5L,3L,8L,3L,1L,1L,0L,2L,8L,3L,9L,7L,3L,3L,6L,9L,2L,6L,7L,4L,2L,5L,4L,7L,1L,3L,2L,8L,8L,0L,9L,9L,8L,8L,9L,2L,5L,7L,8L,6L,4L,7L,1L,9L,3L,7L,2L,7L,8L,9L,1L,4L,0L,6L,4L,1L,4L,5L,6L,3L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201527Inst : IEnumerable<long>
{
public static readonly long[] Value=A201527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201527.Bytes);
public long this[int i]=>Value[i];

public static A201527Inst Instance=new A201527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201528
{
public static readonly long[] Value={ 1L,5L,2L,0L,2L,7L,2L,4L,7L,6L,5L,0L,6L,1L,5L,0L,3L,4L,5L,9L,5L,9L,8L,4L,3L,5L,7L,6L,7L,9L,4L,3L,8L,3L,0L,6L,3L,0L,4L,2L,1L,6L,3L,8L,0L,6L,1L,0L,2L,5L,7L,5L,3L,9L,3L,3L,2L,7L,0L,7L,3L,2L,6L,4L,6L,0L,7L,6L,8L,0L,7L,7L,6L,2L,1L,2L,1L,3L,7L,2L,4L,4L,6L,1L,0L,5L,4L,5L,3L,5L,0L,0L,9L,2L,6L,7L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201528Inst : IEnumerable<long>
{
public static readonly long[] Value=A201528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201528.Bytes);
public long this[int i]=>Value[i];

public static A201528Inst Instance=new A201528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201529
{
public static readonly long[] Value={ 4L,6L,0L,0L,0L,0L,6L,9L,8L,5L,7L,9L,4L,9L,0L,4L,2L,1L,6L,9L,6L,9L,3L,4L,9L,8L,3L,3L,8L,4L,4L,4L,6L,0L,9L,3L,8L,6L,3L,4L,3L,9L,0L,7L,3L,2L,8L,5L,4L,0L,9L,6L,9L,3L,7L,4L,6L,5L,6L,6L,4L,6L,5L,1L,7L,3L,7L,8L,8L,3L,8L,8L,1L,3L,6L,5L,3L,4L,4L,0L,4L,1L,1L,9L,1L,8L,0L,5L,1L,8L,6L,4L,6L,1L,1L,5L,4L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201529Inst : IEnumerable<long>
{
public static readonly long[] Value=A201529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201529.Bytes);
public long this[int i]=>Value[i];

public static A201529Inst Instance=new A201529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201530
{
public static readonly long[] Value={ 1L,5L,2L,5L,9L,0L,5L,7L,7L,1L,4L,1L,0L,5L,6L,6L,1L,4L,5L,4L,2L,9L,2L,6L,6L,2L,0L,6L,9L,5L,0L,6L,6L,9L,7L,5L,3L,1L,8L,6L,9L,3L,5L,1L,7L,0L,0L,5L,3L,9L,8L,0L,6L,7L,9L,9L,2L,9L,5L,0L,3L,0L,4L,6L,8L,3L,6L,6L,5L,7L,8L,0L,1L,2L,2L,6L,5L,6L,9L,5L,6L,2L,7L,3L,8L,9L,6L,2L,2L,4L,2L,2L,9L,3L,4L,5L,3L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201530Inst : IEnumerable<long>
{
public static readonly long[] Value=A201530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201530.Bytes);
public long this[int i]=>Value[i];

public static A201530Inst Instance=new A201530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201531
{
public static readonly long[] Value={ 1L,4L,2L,9L,1L,8L,2L,7L,3L,2L,5L,9L,7L,0L,1L,8L,3L,6L,7L,8L,2L,0L,2L,8L,8L,4L,2L,1L,5L,7L,3L,7L,9L,3L,6L,7L,4L,4L,7L,8L,9L,8L,1L,0L,4L,4L,9L,0L,6L,9L,1L,5L,7L,0L,5L,8L,8L,2L,4L,0L,5L,5L,3L,2L,6L,6L,7L,4L,1L,7L,8L,6L,3L,0L,7L,4L,4L,3L,1L,6L,8L,3L,5L,3L,2L,4L,0L,7L,4L,8L,1L,0L,3L,5L,6L,5L,8L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201531Inst : IEnumerable<long>
{
public static readonly long[] Value=A201531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201531.Bytes);
public long this[int i]=>Value[i];

public static A201531Inst Instance=new A201531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201532
{
public static readonly long[] Value={ 0L,9L,111L,7799L,2446147L,3762507339L,28456420346436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201532Inst : IEnumerable<long>
{
public static readonly long[] Value=A201532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201532.Bytes);
public long this[int i]=>Value[i];

public static A201532Inst Instance=new A201532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201533
{
public static readonly long[] Value={ 3L,9L,25L,69L,175L,410L,899L,1859L,3649L,6840L,12311L,21378L,35964L,58819L,93800L,146222L,223292L,334639L,492954L,714755L,1021293L,1439616L,2003809L,2756429L,3750155L,5049674L,6733825L,8898024L,11656994L,15147825L,19533390L,25006144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201533Inst : IEnumerable<long>
{
public static readonly long[] Value=A201533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201533.Bytes);
public long this[int i]=>Value[i];

public static A201533Inst Instance=new A201533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201534
{
public static readonly long[] Value={ 3L,25L,111L,633L,3354L,16393L,72811L,293831L,1087857L,3735546L,12012530L,36466979L,105202136L,289996482L,767360174L,1956720113L,4824093641L,11531663892L,26793101230L,60636948110L,133921364986L,289121431541L,611037886807L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201534Inst : IEnumerable<long>
{
public static readonly long[] Value=A201534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201534.Bytes);
public long this[int i]=>Value[i];

public static A201534Inst Instance=new A201534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201535
{
public static readonly long[] Value={ 6L,69L,633L,7799L,91425L,983981L,9526987L,82847704L,652848538L,4712696751L,31480011434L,196280028176L,1150650039753L,6380377582098L,33631853768986L,169225758487160L,815686475352515L,3777731764480697L,16854911299206527L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201535Inst : IEnumerable<long>
{
public static readonly long[] Value=A201535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201535.Bytes);
public long this[int i]=>Value[i];

public static A201535Inst Instance=new A201535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201536
{
public static readonly BigInteger[] Value={ 9L,175L,3354L,91425L,2446147L,61807736L,1408677515L,28646055184L,523398227137L,8686880778087L,132361720458239L,1868645862989467L,24631940812325029L,305098771555173655L,3569810381726216867L,BigInteger.Parse("39630824798203404663") };
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
public class A201536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201536Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201536.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201536Inst Instance=new A201536Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201537
{
public static readonly BigInteger[] Value={ 13L,410L,16393L,983981L,61807736L,3762507339L,208164634003L,10298954399450L,457194210355549L,18377434753379050L,675525914078702215L,BigInteger.Parse("22913890806174601101"),BigInteger.Parse("722808878339707158532"),BigInteger.Parse("21342091118575178714919") };
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
public class A201537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201537Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201537.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201537Inst Instance=new A201537Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201538
{
public static readonly BigInteger[] Value={ 18L,899L,72811L,9526987L,1408677515L,208164634003L,28456420346436L,3505159734744220L,387870239576486118L,BigInteger.Parse("38812326822498760643"),BigInteger.Parse("3543738686502556683539"),BigInteger.Parse("297838575975499416278867") };
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
public class A201538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201538Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201538.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201538Inst Instance=new A201538Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201539
{
public static readonly long[] Value={ 0L,3L,3L,3L,9L,3L,6L,25L,25L,6L,9L,69L,111L,69L,9L,13L,175L,633L,633L,175L,13L,18L,410L,3354L,7799L,3354L,410L,18L,24L,899L,16393L,91425L,91425L,16393L,899L,24L,31L,1859L,72811L,983981L,2446147L,983981L,72811L,1859L,31L,39L,3649L,293831L,9526987L,61807736L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201539Inst : IEnumerable<long>
{
public static readonly long[] Value=A201539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201539.Bytes);
public long this[int i]=>Value[i];

public static A201539Inst Instance=new A201539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201540
{
public static readonly BigInteger[] Value={ 1L,6L,36L,412L,9386L,257318L,8891854L,379978716L,19206532478L,1120204619108L,74113608972922L,5483225594409823L,448414229054798028L,BigInteger.Parse("40154319792412218900") };
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
public class A201540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201540Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201540.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201540Inst Instance=new A201540Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201541
{
public static readonly long[] Value={ 0L,1L,2L,3L,8L,11L,12L,16L,22L,23L,38L,43L,47L,51L,53L,67L,68L,71L,73L,87L,88L,102L,106L,107L,108L,123L,141L,143L,156L,162L,166L,173L,177L,178L,186L,192L,198L,212L,221L,227L,232L,233L,247L,271L,277L,282L,288L,296L,298L,318L,326L,327L,333L,337L,346L,351L,352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201541Inst : IEnumerable<long>
{
public static readonly long[] Value=A201541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201541.Bytes);
public long this[int i]=>Value[i];

public static A201541Inst Instance=new A201541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201542
{
public static readonly long[] Value={ 2L,2L,4L,6L,11L,18L,31L,54L,96L,171L,309L,562L,1029L,1896L,3514L,6545L,12247L,23005L,43371L,82029L,155598L,295927L,564164L,1077892L,2063545L,3957761L,7603593L,14630713L,28192867L,54399529L,105097590L,203280493L,393614506L,762937782L,1480207843L,2874399615L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201542Inst : IEnumerable<long>
{
public static readonly long[] Value=A201542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201542.Bytes);
public long this[int i]=>Value[i];

public static A201542Inst Instance=new A201542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201543
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,6L,5L,8L,9L,12L,11L,14L,16L,21L,10L,22L,13L,24L,15L,26L,19L,31L,18L,32L,20L,23L,25L,29L,30L,28L,33L,34L,38L,40L,17L,36L,42L,27L,35L,44L,37L,48L,39L,50L,46L,41L,43L,47L,49L,51L,52L,56L,58L,60L,45L,53L,62L,55L,66L,57L,68L,61L,65L,67L,71L,54L,70L,64L,75L,74L,76L,80L,59L,72L,84L,63L,77L,86L,69L,81L,73L,90L,78L,94L,82L,79L,96L,88L,83L,85L,89L,93L,92L,98L,102L,91L,104L,101L,106L,111L,112L,114L,116L,121L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201543Inst : IEnumerable<long>
{
public static readonly long[] Value=A201543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201543.Bytes);
public long this[int i]=>Value[i];

public static A201543Inst Instance=new A201543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201544
{
public static readonly long[] Value={ 3L,9L,11L,17L,19L,27L,33L,41L,43L,51L,57L,59L,67L,73L,75L,81L,83L,89L,97L,99L,107L,113L,121L,123L,129L,131L,137L,139L,147L,153L,163L,171L,177L,179L,187L,193L,201L,209L,211L,219L,225L,227L,233L,241L,243L,249L,251L,257L,267L,275L,281L,283L,289L,291L,297L,307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201544Inst : IEnumerable<long>
{
public static readonly long[] Value=A201544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201544.Bytes);
public long this[int i]=>Value[i];

public static A201544Inst Instance=new A201544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201545
{
public static readonly long[] Value={ 47L,281L,381L,399L,515L,648L,918L,928L,1303L,1538L,3746L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201545Inst : IEnumerable<long>
{
public static readonly long[] Value=A201545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201545.Bytes);
public long this[int i]=>Value[i];

public static A201545Inst Instance=new A201545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201546
{
public static readonly BigInteger[] Value={ 1L,14L,444L,25584L,2342880L,312888960L,57424792320L,13869128448000L,4264876094976000L,1627055289796608000L,BigInteger.Parse("754132445894209536000"),BigInteger.Parse("417405110861381271552000"),BigInteger.Parse("271933770461631065948160000"),BigInteger.Parse("205985221930119691492392960000"),BigInteger.Parse("179512031423815845458883379200000") };
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
public class A201546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201546Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201546.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201546Inst Instance=new A201546Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201547
{
public static readonly long[] Value={ 0L,0L,0L,0L,250L,480916L,54916456L,1962132800L,34690541994L,385983794500L,3095143575007L,19437996015280L,100963195651565L,450398154002132L,1773257833600750L,6288010190509312L,20398342362118678L,61282868654684052L,172190699515632837L,456120623076014000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201547Inst : IEnumerable<long>
{
public static readonly long[] Value=A201547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201547.Bytes);
public long this[int i]=>Value[i];

public static A201547Inst Instance=new A201547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201548
{
public static readonly ulong[] Value={ 0L,0L,0L,0L,10L,308574L,81442802L,5296005568L,146127335256L,2309813476870L,24738873315596L,198759048859008L,1279605298916568L,6906427308782106L,32277449304595350L,133788325435448576L,500896430870051174L,1718268150463137018L,5462521782760829320L,16243031089247644800UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201548Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A201548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201548.Bytes);
public ulong this[int i]=>Value[i];

public static A201548Inst Instance=new A201548Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201549
{
public static readonly long[] Value={ 1L,11L,91L,891L,8801L,88913L,908755L,9377467L,97464799L,1018872811L,10701243741L,112835748609L,1193692544825L,12663809507129L,134678108144591L,1435345208419771L,15326122342137035L,163920458145421109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201549Inst : IEnumerable<long>
{
public static readonly long[] Value=A201549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201549.Bytes);
public long this[int i]=>Value[i];

public static A201549Inst Instance=new A201549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201550
{
public static readonly long[] Value={ 1L,13L,127L,1469L,17151L,204763L,2473325L,30162301L,370487485L,4577127763L,56813989827L,707972099627L,8851373201919L,110976634957761L,1394804756117877L,17567994350713469L,221690794842728445L,2802194053806820153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201550Inst : IEnumerable<long>
{
public static readonly long[] Value=A201550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201550.Bytes);
public long this[int i]=>Value[i];

public static A201550Inst Instance=new A201550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201551
{
public static readonly long[] Value={ 1L,15L,169L,2255L,30381L,418503L,5832765L,82073295L,1163205475L,16581420835L,237481736823L,3414582082055L,49258226347903L,712601187601395L,10334165623697259L,150186639579545295L,2186774434431445455L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201551Inst : IEnumerable<long>
{
public static readonly long[] Value=A201551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201551.Bytes);
public long this[int i]=>Value[i];

public static A201551Inst Instance=new A201551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201552
{
public static readonly long[] Value={ 1L,1L,3L,1L,5L,7L,1L,7L,19L,19L,1L,9L,37L,85L,51L,1L,11L,61L,231L,381L,141L,1L,13L,91L,489L,1451L,1751L,393L,1L,15L,127L,891L,3951L,9331L,8135L,1107L,1L,17L,169L,1469L,8801L,32661L,60691L,38165L,3139L,1L,19L,217L,2255L,17151L,88913L,273127L,398567L,180325L,8953L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201552Inst : IEnumerable<long>
{
public static readonly long[] Value=A201552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201552.Bytes);
public long this[int i]=>Value[i];

public static A201552Inst Instance=new A201552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201553
{
public static readonly long[] Value={ 141L,1751L,9331L,32661L,88913L,204763L,418503L,782153L,1363573L,2248575L,3543035L,5375005L,7896825L,11287235L,15753487L,21533457L,28897757L,38151847L,49638147L,63738149L,80874529L,101513259L,126165719L,155390809L,189797061L,230044751L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201553Inst : IEnumerable<long>
{
public static readonly long[] Value=A201553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201553.Bytes);
public long this[int i]=>Value[i];

public static A201553Inst Instance=new A201553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201554
{
public static readonly long[] Value={ 393L,8135L,60691L,273127L,908755L,2473325L,5832765L,12354469L,24072133L,43874139L,75715487L,124853275L,198105727L,304134769L,453752153L,660249129L,939749665L,1311587215L,1798705035L,2428080047L,3231170251L,4244385685L,5509582933L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201554Inst : IEnumerable<long>
{
public static readonly long[] Value=A201554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201554.Bytes);
public long this[int i]=>Value[i];

public static A201554Inst Instance=new A201554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201555
{
public static readonly BigInteger[] Value={ 1L,2L,70L,48620L,601080390L,126410606437752L,BigInteger.Parse("442512540276836779204"),BigInteger.Parse("25477612258980856902730428600"),BigInteger.Parse("23951146041928082866135587776380551750"),BigInteger.Parse("365907784099042279561985786395502921046971688680"),BigInteger.Parse("90548514656103281165404177077484163874504589675413336841320") };
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
public class A201555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201555Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201555.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201555Inst Instance=new A201555Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201556
{
public static readonly BigInteger[] Value={ 1L,2L,37L,16278L,150303194L,25282422428664L,BigInteger.Parse("73752140616074524401"),BigInteger.Parse("3639659041645240391812731402"),BigInteger.Parse("2993893262520330875797362908273443346"),BigInteger.Parse("40656420461436928818704580402413441308206341488"),BigInteger.Parse("9054851465691640957562090101797213977192016103053025996396") };
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
public class A201556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201556Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201556.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201556Inst Instance=new A201556Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201557
{
public static readonly long[] Value={ 183783600L,367567200L,1396755360L,1745944200L,2327925600L,3491888400L,6983776800L,80313433200L,160626866400L,252706217563800L,288807105787200L,336941623418400L,404329948102080L,505412435127600L,673883246836800L,1010824870255200L,2021649740510400L,112201560598327200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201557Inst : IEnumerable<long>
{
public static readonly long[] Value=A201557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201557.Bytes);
public long this[int i]=>Value[i];

public static A201557Inst Instance=new A201557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201558
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,4L,2L,1L,1L,2L,4L,1L,2L,3L,7L,7L,7L,1L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201558Inst : IEnumerable<long>
{
public static readonly long[] Value=A201558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201558.Bytes);
public long this[int i]=>Value[i];

public static A201558Inst Instance=new A201558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201559
{
public static readonly long[] Value={ 1L,1L,9L,2L,3L,4L,7L,3L,3L,7L,1L,8L,6L,1L,9L,3L,2L,0L,2L,8L,9L,7L,5L,0L,4L,4L,2L,7L,4L,2L,5L,5L,9L,7L,8L,8L,3L,4L,0L,1L,1L,1L,9L,2L,3L,0L,8L,3L,7L,9L,9L,9L,4L,3L,0L,1L,3L,7L,1L,9L,4L,9L,2L,9L,9L,0L,5L,2L,4L,5L,8L,6L,4L,8L,4L,8L,3L,0L,1L,3L,9L,2L,4L,0L,8L,4L,9L,9L,8L,6L,3L,8L,3L,7L,8L,8L,3L,6L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201559Inst : IEnumerable<long>
{
public static readonly long[] Value=A201559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201559.Bytes);
public long this[int i]=>Value[i];

public static A201559Inst Instance=new A201559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201560
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,4L,0L,1L,7L,6L,0L,1L,0L,8L,11L,1L,0L,10L,0L,1L,15L,12L,0L,1L,21L,14L,19L,1L,0L,16L,0L,1L,23L,18L,1L,1L,0L,20L,27L,1L,0L,22L,0L,1L,22L,24L,0L,1L,43L,26L,35L,1L,0L,28L,1L,1L,39L,30L,0L,1L,0L,32L,43L,1L,53L,34L,0L,1L,47L,36L,0L,1L,0L,38L,51L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201560Inst : IEnumerable<long>
{
public static readonly long[] Value=A201560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201560.Bytes);
public long this[int i]=>Value[i];

public static A201560Inst Instance=new A201560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201561
{
public static readonly BigInteger[] Value={ 1L,2L,12L,136L,2160L,43952L,1092672L,32102656L,1088252160L,41809041152L,1795201638912L,85196352787456L,4428299422310400L,250187205957220352L,15265712890413023232UL,BigInteger.Parse("1000468694343925006336"),BigInteger.Parse("70089639485229413498880"),BigInteger.Parse("5227049493330884279140352"),BigInteger.Parse("413441163603081566484037632") };
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
public class A201561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201561Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201561.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201561Inst Instance=new A201561Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201562
{
public static readonly long[] Value={ 2L,4L,2L,5L,6L,2L,2L,4L,5L,6L,9L,6L,5L,4L,4L,2L,2L,3L,4L,3L,8L,7L,5L,1L,8L,8L,0L,9L,4L,8L,5L,0L,9L,2L,0L,3L,3L,8L,1L,8L,2L,8L,2L,1L,1L,5L,7L,2L,4L,2L,5L,9L,5L,1L,0L,5L,9L,0L,8L,6L,2L,4L,3L,0L,7L,7L,7L,7L,8L,7L,6L,1L,9L,2L,3L,5L,3L,7L,3L,1L,0L,7L,4L,2L,3L,2L,2L,8L,6L,5L,0L,0L,0L,2L,0L,3L,9L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201562Inst : IEnumerable<long>
{
public static readonly long[] Value=A201562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201562.Bytes);
public long this[int i]=>Value[i];

public static A201562Inst Instance=new A201562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201563
{
public static readonly long[] Value={ 3L,0L,4L,4L,0L,3L,0L,1L,6L,6L,1L,1L,9L,2L,3L,5L,2L,8L,1L,6L,2L,2L,9L,8L,3L,5L,4L,9L,8L,0L,1L,1L,0L,0L,7L,9L,0L,3L,6L,8L,8L,2L,8L,0L,4L,8L,6L,0L,0L,7L,4L,4L,4L,9L,6L,3L,6L,8L,1L,1L,0L,7L,1L,7L,1L,3L,0L,0L,5L,4L,3L,7L,6L,0L,8L,6L,7L,4L,0L,3L,4L,7L,2L,7L,6L,9L,7L,1L,2L,4L,3L,8L,5L,2L,4L,3L,1L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201563Inst : IEnumerable<long>
{
public static readonly long[] Value=A201563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201563.Bytes);
public long this[int i]=>Value[i];

public static A201563Inst Instance=new A201563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201564
{
public static readonly long[] Value={ 4L,6L,7L,5L,8L,0L,9L,4L,4L,0L,6L,3L,4L,7L,1L,3L,6L,7L,3L,6L,1L,4L,1L,9L,2L,7L,0L,7L,6L,6L,8L,6L,5L,3L,8L,8L,5L,9L,4L,0L,2L,5L,3L,7L,2L,6L,6L,9L,2L,4L,9L,0L,6L,6L,7L,9L,2L,9L,5L,5L,6L,8L,3L,7L,6L,1L,2L,1L,9L,5L,2L,4L,9L,1L,3L,8L,9L,8L,3L,8L,0L,4L,3L,4L,5L,9L,4L,1L,1L,8L,5L,8L,8L,3L,2L,8L,8L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201564Inst : IEnumerable<long>
{
public static readonly long[] Value=A201564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201564.Bytes);
public long this[int i]=>Value[i];

public static A201564Inst Instance=new A201564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201565
{
public static readonly long[] Value={ 3L,0L,5L,3L,1L,5L,1L,7L,2L,2L,5L,2L,4L,8L,7L,0L,2L,1L,1L,8L,0L,4L,1L,5L,5L,0L,5L,3L,1L,7L,8L,1L,1L,3L,7L,4L,5L,9L,6L,2L,2L,4L,7L,6L,7L,8L,3L,9L,2L,0L,5L,5L,3L,4L,7L,5L,4L,1L,5L,4L,4L,1L,3L,9L,0L,6L,3L,7L,7L,3L,7L,1L,6L,9L,0L,6L,9L,5L,2L,2L,2L,7L,9L,1L,6L,9L,7L,4L,3L,4L,0L,3L,5L,9L,3L,5L,7L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201565Inst : IEnumerable<long>
{
public static readonly long[] Value=A201565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201565.Bytes);
public long this[int i]=>Value[i];

public static A201565Inst Instance=new A201565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201566
{
public static readonly long[] Value={ 3L,2L,7L,6L,4L,8L,2L,4L,7L,1L,1L,3L,6L,6L,8L,6L,7L,8L,0L,9L,8L,2L,4L,7L,7L,0L,6L,2L,0L,9L,8L,1L,9L,5L,2L,9L,8L,4L,4L,3L,7L,8L,4L,5L,2L,8L,2L,0L,0L,2L,4L,4L,8L,6L,4L,8L,9L,9L,2L,1L,7L,0L,7L,4L,8L,2L,1L,6L,1L,7L,1L,2L,6L,7L,5L,1L,4L,2L,8L,3L,5L,6L,9L,6L,9L,5L,8L,9L,9L,8L,1L,6L,1L,6L,1L,7L,2L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201566Inst : IEnumerable<long>
{
public static readonly long[] Value=A201566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201566.Bytes);
public long this[int i]=>Value[i];

public static A201566Inst Instance=new A201566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201567
{
public static readonly long[] Value={ 3L,0L,6L,0L,6L,4L,7L,6L,2L,1L,6L,7L,4L,3L,9L,0L,6L,4L,9L,4L,6L,7L,0L,2L,1L,0L,6L,1L,4L,4L,1L,5L,7L,5L,3L,7L,2L,7L,8L,8L,8L,9L,0L,1L,2L,3L,3L,7L,6L,9L,2L,2L,2L,7L,4L,3L,9L,7L,9L,9L,5L,2L,3L,0L,0L,1L,8L,8L,1L,8L,3L,7L,3L,7L,3L,6L,9L,0L,6L,0L,9L,4L,1L,8L,6L,6L,2L,9L,2L,4L,4L,0L,1L,7L,3L,8L,0L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201567Inst : IEnumerable<long>
{
public static readonly long[] Value=A201567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201567.Bytes);
public long this[int i]=>Value[i];

public static A201567Inst Instance=new A201567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201568
{
public static readonly long[] Value={ 2L,4L,8L,7L,4L,9L,0L,0L,0L,7L,1L,6L,2L,9L,5L,9L,8L,5L,3L,6L,5L,2L,9L,2L,4L,0L,8L,3L,7L,1L,6L,9L,4L,1L,0L,3L,9L,7L,1L,7L,2L,2L,7L,0L,7L,8L,6L,8L,7L,3L,3L,4L,9L,6L,1L,4L,2L,4L,4L,2L,2L,3L,6L,6L,8L,1L,9L,7L,3L,6L,4L,6L,7L,3L,2L,3L,9L,3L,5L,8L,5L,8L,5L,1L,0L,8L,2L,9L,3L,6L,4L,2L,8L,2L,2L,8L,8L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201568Inst : IEnumerable<long>
{
public static readonly long[] Value=A201568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201568.Bytes);
public long this[int i]=>Value[i];

public static A201568Inst Instance=new A201568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201569
{
public static readonly long[] Value={ 3L,0L,6L,6L,9L,3L,0L,1L,7L,7L,6L,5L,5L,7L,9L,6L,7L,1L,5L,9L,2L,1L,0L,6L,2L,7L,1L,3L,7L,3L,8L,1L,9L,8L,0L,7L,6L,4L,5L,0L,3L,0L,6L,2L,1L,6L,7L,1L,9L,0L,4L,5L,6L,7L,5L,9L,0L,8L,5L,3L,0L,1L,7L,8L,9L,3L,4L,9L,7L,7L,9L,4L,1L,5L,5L,5L,0L,6L,8L,7L,0L,1L,3L,2L,5L,0L,4L,0L,0L,1L,4L,8L,0L,6L,4L,8L,0L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201569Inst : IEnumerable<long>
{
public static readonly long[] Value=A201569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201569.Bytes);
public long this[int i]=>Value[i];

public static A201569Inst Instance=new A201569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201570
{
public static readonly long[] Value={ 1L,9L,9L,7L,4L,2L,2L,9L,2L,8L,1L,9L,4L,7L,2L,1L,3L,7L,0L,8L,6L,7L,4L,0L,5L,1L,5L,9L,5L,5L,3L,4L,8L,1L,1L,4L,5L,3L,2L,5L,4L,5L,4L,4L,3L,9L,0L,3L,2L,5L,3L,2L,4L,3L,3L,4L,5L,3L,8L,3L,3L,5L,7L,7L,9L,2L,2L,9L,6L,3L,1L,0L,3L,9L,3L,7L,2L,6L,7L,6L,1L,4L,9L,0L,4L,3L,4L,8L,2L,7L,7L,7L,7L,7L,5L,6L,0L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201570Inst : IEnumerable<long>
{
public static readonly long[] Value=A201570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201570.Bytes);
public long this[int i]=>Value[i];

public static A201570Inst Instance=new A201570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201571
{
public static readonly long[] Value={ 3L,0L,7L,2L,2L,7L,9L,8L,3L,0L,0L,5L,1L,2L,5L,0L,3L,3L,5L,8L,5L,9L,8L,6L,6L,4L,6L,0L,4L,6L,4L,6L,9L,9L,0L,6L,0L,3L,6L,3L,7L,2L,9L,1L,3L,7L,8L,0L,4L,8L,4L,8L,3L,4L,3L,3L,0L,6L,3L,1L,4L,0L,6L,9L,7L,8L,4L,5L,2L,0L,7L,7L,8L,5L,0L,3L,1L,7L,1L,7L,0L,5L,5L,2L,3L,2L,0L,3L,8L,1L,8L,3L,5L,8L,4L,0L,9L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201571Inst : IEnumerable<long>
{
public static readonly long[] Value=A201571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201571.Bytes);
public long this[int i]=>Value[i];

public static A201571Inst Instance=new A201571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201572
{
public static readonly long[] Value={ 1L,6L,6L,6L,6L,9L,1L,6L,3L,1L,7L,5L,4L,0L,0L,9L,4L,9L,5L,6L,5L,2L,0L,0L,3L,2L,0L,6L,2L,7L,7L,6L,1L,2L,9L,9L,1L,5L,8L,1L,6L,7L,6L,7L,4L,4L,7L,5L,4L,0L,3L,4L,4L,9L,3L,4L,8L,0L,4L,8L,4L,6L,7L,5L,6L,4L,4L,2L,3L,4L,9L,3L,7L,1L,3L,9L,6L,9L,9L,0L,8L,9L,8L,1L,0L,3L,5L,3L,6L,6L,4L,1L,8L,6L,7L,0L,3L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201572Inst : IEnumerable<long>
{
public static readonly long[] Value=A201572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201572.Bytes);
public long this[int i]=>Value[i];

public static A201572Inst Instance=new A201572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201573
{
public static readonly long[] Value={ 3L,0L,7L,6L,8L,9L,4L,9L,2L,9L,2L,4L,6L,1L,9L,2L,0L,2L,3L,1L,6L,6L,6L,9L,3L,6L,4L,7L,3L,2L,7L,7L,2L,5L,7L,7L,3L,2L,4L,8L,4L,1L,9L,8L,0L,6L,5L,8L,2L,3L,7L,4L,3L,2L,0L,1L,5L,8L,3L,9L,9L,5L,2L,4L,3L,9L,9L,1L,1L,1L,5L,7L,6L,0L,6L,3L,1L,5L,1L,1L,6L,6L,3L,2L,3L,5L,2L,6L,3L,1L,1L,7L,4L,6L,7L,7L,2L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201573Inst : IEnumerable<long>
{
public static readonly long[] Value=A201573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201573.Bytes);
public long this[int i]=>Value[i];

public static A201573Inst Instance=new A201573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201574
{
public static readonly long[] Value={ 1L,4L,2L,9L,2L,7L,5L,8L,2L,9L,9L,3L,9L,2L,0L,8L,6L,7L,0L,0L,4L,3L,1L,0L,4L,4L,3L,0L,7L,5L,5L,4L,7L,4L,8L,2L,4L,0L,8L,8L,4L,3L,5L,1L,3L,9L,9L,1L,0L,5L,0L,9L,4L,5L,4L,0L,2L,7L,8L,5L,0L,1L,0L,4L,5L,9L,2L,8L,5L,0L,3L,0L,7L,9L,5L,5L,0L,5L,9L,4L,2L,2L,7L,2L,6L,3L,9L,7L,7L,6L,0L,5L,3L,6L,5L,1L,6L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201574Inst : IEnumerable<long>
{
public static readonly long[] Value=A201574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201574.Bytes);
public long this[int i]=>Value[i];

public static A201574Inst Instance=new A201574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201575
{
public static readonly long[] Value={ 3L,0L,8L,0L,9L,2L,0L,2L,3L,2L,2L,9L,5L,2L,0L,6L,8L,0L,4L,5L,5L,9L,3L,5L,8L,4L,9L,8L,2L,1L,2L,7L,5L,3L,7L,0L,1L,0L,8L,7L,2L,6L,9L,9L,6L,9L,0L,8L,2L,4L,2L,1L,1L,8L,5L,7L,5L,7L,2L,2L,8L,1L,7L,4L,8L,5L,3L,8L,9L,4L,3L,8L,2L,4L,7L,7L,5L,0L,5L,0L,9L,0L,3L,9L,8L,7L,9L,1L,5L,9L,7L,4L,0L,2L,6L,4L,8L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201575Inst : IEnumerable<long>
{
public static readonly long[] Value=A201575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201575.Bytes);
public long this[int i]=>Value[i];

public static A201575Inst Instance=new A201575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201576
{
public static readonly long[] Value={ 1L,2L,5L,0L,8L,1L,9L,2L,2L,6L,3L,5L,9L,9L,7L,4L,4L,1L,2L,8L,9L,1L,7L,7L,7L,0L,1L,6L,5L,3L,7L,8L,5L,7L,0L,7L,1L,8L,7L,6L,5L,5L,4L,8L,7L,1L,3L,4L,6L,8L,7L,6L,2L,6L,4L,8L,0L,7L,0L,8L,7L,1L,4L,2L,1L,6L,3L,6L,8L,2L,8L,2L,2L,8L,9L,2L,4L,8L,7L,3L,4L,6L,3L,7L,1L,4L,1L,7L,7L,6L,1L,6L,6L,7L,2L,8L,5L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201576Inst : IEnumerable<long>
{
public static readonly long[] Value=A201576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201576.Bytes);
public long this[int i]=>Value[i];

public static A201576Inst Instance=new A201576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201577
{
public static readonly long[] Value={ 3L,0L,8L,4L,4L,6L,4L,1L,4L,0L,5L,6L,4L,3L,8L,0L,8L,4L,9L,4L,5L,9L,1L,9L,0L,5L,9L,5L,3L,6L,4L,6L,4L,6L,0L,2L,1L,8L,3L,3L,5L,2L,0L,6L,1L,4L,9L,0L,4L,5L,8L,6L,4L,7L,6L,8L,3L,8L,8L,2L,8L,5L,6L,2L,6L,8L,3L,0L,8L,4L,7L,2L,4L,3L,6L,7L,1L,4L,1L,4L,6L,2L,8L,5L,9L,3L,5L,3L,3L,4L,0L,8L,3L,2L,7L,8L,3L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201577Inst : IEnumerable<long>
{
public static readonly long[] Value=A201577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201577.Bytes);
public long this[int i]=>Value[i];

public static A201577Inst Instance=new A201577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201578
{
public static readonly long[] Value={ 1L,0L,0L,0L,6L,6L,8L,8L,4L,0L,7L,2L,9L,1L,9L,3L,0L,9L,2L,7L,9L,8L,0L,5L,3L,8L,4L,4L,5L,9L,3L,8L,1L,1L,1L,5L,0L,6L,0L,7L,1L,7L,8L,5L,4L,6L,9L,8L,0L,2L,2L,5L,0L,0L,6L,0L,9L,9L,9L,8L,6L,7L,6L,2L,9L,6L,3L,7L,6L,9L,7L,5L,0L,6L,9L,5L,8L,2L,6L,1L,7L,7L,6L,0L,5L,8L,1L,0L,9L,3L,5L,5L,1L,2L,5L,2L,5L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201578Inst : IEnumerable<long>
{
public static readonly long[] Value=A201578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201578.Bytes);
public long this[int i]=>Value[i];

public static A201578Inst Instance=new A201578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201579
{
public static readonly long[] Value={ 1L,1L,1L,1L,8L,7L,6L,4L,9L,5L,3L,0L,3L,3L,6L,5L,5L,2L,4L,1L,1L,3L,2L,1L,6L,9L,1L,8L,0L,0L,6L,5L,7L,5L,3L,3L,6L,1L,1L,7L,8L,7L,3L,4L,2L,3L,4L,6L,0L,7L,0L,0L,3L,7L,0L,8L,5L,6L,9L,6L,1L,2L,1L,2L,7L,2L,8L,3L,8L,6L,1L,8L,4L,4L,7L,2L,8L,6L,5L,9L,0L,9L,2L,5L,8L,1L,7L,6L,4L,2L,8L,9L,2L,7L,5L,3L,2L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201579Inst : IEnumerable<long>
{
public static readonly long[] Value=A201579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201579.Bytes);
public long this[int i]=>Value[i];

public static A201579Inst Instance=new A201579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201580
{
public static readonly long[] Value={ 3L,0L,8L,7L,6L,0L,9L,6L,0L,2L,7L,8L,3L,6L,0L,6L,1L,3L,3L,0L,0L,1L,1L,9L,0L,4L,9L,8L,8L,4L,6L,7L,0L,1L,5L,0L,7L,7L,1L,5L,8L,0L,1L,9L,5L,4L,6L,6L,8L,5L,6L,6L,5L,3L,7L,9L,3L,4L,2L,4L,0L,9L,4L,1L,4L,2L,9L,0L,1L,8L,0L,5L,2L,0L,5L,2L,6L,7L,1L,8L,3L,9L,8L,1L,8L,5L,7L,2L,8L,3L,5L,2L,7L,8L,2L,3L,7L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201580Inst : IEnumerable<long>
{
public static readonly long[] Value=A201580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201580.Bytes);
public long this[int i]=>Value[i];

public static A201580Inst Instance=new A201580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201581
{
public static readonly long[] Value={ 3L,0L,9L,0L,4L,2L,1L,2L,7L,0L,1L,5L,2L,1L,5L,1L,4L,5L,3L,6L,5L,1L,4L,9L,7L,4L,4L,3L,8L,9L,9L,9L,2L,0L,5L,3L,4L,3L,8L,7L,8L,8L,2L,1L,3L,8L,3L,1L,5L,6L,3L,5L,0L,1L,4L,0L,8L,5L,5L,5L,5L,1L,8L,9L,9L,6L,6L,3L,6L,3L,1L,5L,9L,8L,0L,6L,4L,7L,6L,1L,2L,8L,4L,0L,6L,0L,6L,1L,1L,0L,6L,8L,9L,9L,4L,4L,5L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201581Inst : IEnumerable<long>
{
public static readonly long[] Value=A201581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201581.Bytes);
public long this[int i]=>Value[i];

public static A201581Inst Instance=new A201581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201582
{
public static readonly long[] Value={ 3L,0L,3L,2L,6L,4L,5L,4L,1L,8L,3L,8L,8L,7L,5L,6L,1L,8L,8L,6L,7L,5L,3L,2L,5L,6L,3L,6L,8L,0L,2L,6L,0L,8L,9L,3L,2L,8L,4L,6L,7L,2L,3L,6L,2L,6L,7L,4L,9L,9L,7L,1L,8L,5L,9L,8L,5L,1L,9L,8L,4L,5L,6L,7L,7L,8L,0L,6L,7L,1L,1L,3L,4L,1L,9L,9L,2L,4L,2L,2L,5L,0L,4L,2L,5L,5L,8L,4L,3L,8L,8L,9L,8L,8L,9L,7L,1L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201582Inst : IEnumerable<long>
{
public static readonly long[] Value=A201582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201582.Bytes);
public long this[int i]=>Value[i];

public static A201582Inst Instance=new A201582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201583
{
public static readonly long[] Value={ 8L,2L,5L,0L,2L,8L,9L,2L,4L,0L,1L,5L,0L,0L,6L,3L,3L,9L,3L,3L,3L,9L,4L,6L,3L,1L,8L,1L,8L,3L,3L,5L,7L,9L,7L,8L,6L,9L,2L,2L,8L,7L,1L,0L,1L,4L,8L,2L,8L,7L,1L,0L,8L,8L,5L,2L,7L,4L,2L,5L,2L,0L,4L,2L,7L,7L,8L,5L,7L,4L,3L,9L,1L,0L,4L,3L,1L,4L,1L,6L,8L,3L,6L,0L,1L,4L,4L,0L,9L,8L,7L,0L,3L,4L,7L,3L,9L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201583Inst : IEnumerable<long>
{
public static readonly long[] Value=A201583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201583.Bytes);
public long this[int i]=>Value[i];

public static A201583Inst Instance=new A201583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201584
{
public static readonly long[] Value={ 3L,0L,8L,9L,1L,7L,4L,2L,1L,1L,9L,2L,9L,9L,3L,0L,2L,0L,6L,5L,6L,0L,5L,7L,7L,4L,8L,7L,8L,6L,9L,9L,7L,3L,8L,0L,4L,9L,3L,7L,1L,6L,3L,0L,9L,6L,5L,6L,6L,7L,2L,1L,0L,0L,2L,6L,5L,8L,0L,5L,8L,8L,2L,2L,6L,9L,1L,1L,0L,0L,8L,9L,9L,1L,3L,2L,5L,0L,5L,1L,6L,3L,6L,1L,8L,4L,8L,9L,4L,4L,8L,0L,0L,1L,6L,6L,3L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201584Inst : IEnumerable<long>
{
public static readonly long[] Value=A201584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201584.Bytes);
public long this[int i]=>Value[i];

public static A201584Inst Instance=new A201584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201585
{
public static readonly long[] Value={ 7L,1L,3L,6L,1L,1L,5L,4L,1L,0L,6L,5L,4L,5L,3L,5L,1L,6L,9L,6L,7L,1L,2L,3L,4L,8L,7L,4L,8L,4L,8L,2L,8L,2L,3L,1L,1L,4L,4L,0L,0L,5L,5L,5L,1L,9L,8L,5L,0L,0L,2L,7L,5L,7L,8L,8L,6L,3L,6L,5L,8L,4L,1L,9L,1L,4L,4L,4L,9L,9L,0L,3L,5L,1L,3L,2L,8L,5L,5L,6L,4L,8L,4L,8L,0L,8L,7L,8L,7L,0L,0L,2L,5L,8L,9L,6L,5L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201585Inst : IEnumerable<long>
{
public static readonly long[] Value=A201585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201585.Bytes);
public long this[int i]=>Value[i];

public static A201585Inst Instance=new A201585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201586
{
public static readonly long[] Value={ 3L,1L,0L,7L,0L,5L,7L,0L,8L,4L,6L,6L,9L,2L,7L,9L,1L,3L,9L,4L,2L,1L,3L,3L,6L,3L,9L,7L,5L,8L,9L,0L,2L,3L,2L,6L,5L,5L,1L,8L,6L,0L,5L,8L,8L,9L,3L,2L,2L,5L,2L,6L,6L,1L,3L,6L,2L,2L,4L,2L,2L,4L,1L,7L,2L,2L,9L,4L,1L,3L,6L,5L,7L,1L,6L,6L,3L,2L,5L,1L,8L,1L,3L,0L,2L,2L,1L,8L,8L,2L,7L,7L,7L,5L,6L,4L,8L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201586Inst : IEnumerable<long>
{
public static readonly long[] Value=A201586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201586.Bytes);
public long this[int i]=>Value[i];

public static A201586Inst Instance=new A201586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201587
{
public static readonly long[] Value={ 6L,4L,4L,8L,9L,7L,4L,7L,5L,5L,4L,3L,6L,7L,3L,8L,3L,4L,4L,4L,3L,3L,5L,7L,3L,9L,0L,0L,4L,4L,4L,7L,4L,5L,2L,0L,1L,7L,0L,1L,3L,6L,8L,0L,5L,7L,9L,8L,7L,6L,3L,3L,7L,5L,0L,8L,8L,3L,4L,1L,4L,4L,8L,8L,6L,5L,5L,0L,7L,5L,9L,7L,3L,0L,8L,2L,2L,8L,5L,9L,1L,9L,6L,9L,6L,3L,7L,0L,0L,3L,0L,4L,9L,4L,5L,1L,7L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201587Inst : IEnumerable<long>
{
public static readonly long[] Value=A201587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201587.Bytes);
public long this[int i]=>Value[i];

public static A201587Inst Instance=new A201587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201588
{
public static readonly long[] Value={ 3L,1L,1L,5L,8L,3L,9L,0L,5L,1L,2L,7L,6L,2L,5L,3L,5L,2L,1L,1L,3L,1L,0L,8L,5L,0L,1L,5L,1L,9L,5L,2L,0L,8L,2L,5L,8L,7L,8L,1L,1L,1L,2L,0L,9L,6L,5L,8L,8L,8L,1L,7L,4L,0L,1L,0L,7L,7L,2L,8L,9L,3L,9L,0L,0L,7L,8L,2L,4L,7L,0L,2L,2L,4L,1L,3L,9L,2L,7L,8L,4L,1L,4L,1L,9L,7L,4L,9L,9L,3L,0L,3L,8L,8L,6L,8L,6L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201588Inst : IEnumerable<long>
{
public static readonly long[] Value=A201588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201588.Bytes);
public long this[int i]=>Value[i];

public static A201588Inst Instance=new A201588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201589
{
public static readonly long[] Value={ 5L,9L,6L,6L,2L,6L,8L,1L,9L,8L,6L,0L,7L,0L,4L,5L,4L,6L,7L,6L,1L,8L,3L,2L,8L,5L,9L,0L,8L,2L,1L,4L,1L,0L,4L,8L,3L,0L,3L,6L,5L,3L,1L,0L,0L,8L,7L,0L,2L,9L,3L,0L,5L,7L,4L,4L,7L,1L,8L,2L,0L,4L,7L,7L,5L,8L,3L,7L,4L,7L,8L,6L,0L,6L,4L,1L,9L,9L,1L,6L,3L,4L,1L,9L,4L,0L,7L,6L,9L,5L,5L,7L,2L,8L,9L,7L,2L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201589Inst : IEnumerable<long>
{
public static readonly long[] Value=A201589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201589.Bytes);
public long this[int i]=>Value[i];

public static A201589Inst Instance=new A201589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201590
{
public static readonly long[] Value={ 3L,1L,2L,1L,0L,5L,9L,4L,6L,3L,5L,2L,3L,8L,2L,7L,4L,1L,5L,3L,6L,0L,1L,7L,5L,7L,0L,0L,0L,3L,4L,0L,9L,2L,0L,4L,8L,9L,1L,0L,7L,4L,9L,9L,6L,8L,4L,4L,7L,8L,4L,7L,8L,2L,7L,1L,2L,2L,2L,5L,2L,7L,1L,0L,2L,4L,0L,7L,1L,2L,3L,5L,0L,6L,2L,6L,9L,9L,8L,4L,0L,2L,3L,6L,0L,2L,1L,5L,9L,2L,8L,2L,7L,3L,1L,7L,9L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201590Inst : IEnumerable<long>
{
public static readonly long[] Value=A201590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201590.Bytes);
public long this[int i]=>Value[i];

public static A201590Inst Instance=new A201590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201591
{
public static readonly long[] Value={ 5L,6L,0L,1L,0L,0L,6L,9L,4L,9L,1L,2L,1L,6L,0L,7L,6L,2L,8L,2L,3L,8L,4L,1L,3L,3L,3L,7L,9L,7L,8L,1L,2L,0L,7L,7L,5L,2L,9L,3L,7L,4L,5L,0L,3L,0L,3L,0L,8L,9L,6L,4L,1L,1L,5L,5L,8L,6L,1L,2L,2L,0L,4L,3L,0L,9L,0L,6L,7L,5L,9L,1L,6L,2L,1L,5L,6L,4L,8L,3L,3L,1L,4L,0L,8L,0L,7L,1L,6L,1L,8L,4L,7L,1L,4L,3L,7L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201591Inst : IEnumerable<long>
{
public static readonly long[] Value=A201591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201591.Bytes);
public long this[int i]=>Value[i];

public static A201591Inst Instance=new A201591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201592
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,3L,4L,1L,2L,4L,3L,1L,4L,2L,6L,3L,5L,6L,4L,1L,2L,5L,3L,4L,7L,6L,8L,1L,5L,2L,3L,8L,9L,6L,4L,9L,8L,5L,1L,2L,3L,6L,9L,4L,10L,7L,5L,1L,9L,2L,6L,8L,3L,11L,4L,12L,7L,10L,12L,5L,8L,1L,6L,2L,3L,10L,12L,7L,4L,9L,5L,8L,11L,12L,6L,1L,2L,3L,7L,14L,4L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201592Inst : IEnumerable<long>
{
public static readonly long[] Value=A201592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201592.Bytes);
public long this[int i]=>Value[i];

public static A201592Inst Instance=new A201592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201593
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,1L,3L,3L,2L,3L,4L,3L,4L,1L,4L,3L,2L,4L,5L,5L,4L,5L,5L,3L,4L,2L,6L,5L,6L,6L,3L,1L,5L,6L,2L,4L,6L,7L,7L,7L,6L,4L,7L,3L,6L,7L,8L,5L,8L,7L,6L,8L,3L,8L,1L,7L,5L,2L,8L,7L,9L,8L,9L,9L,6L,4L,8L,9L,7L,9L,8L,6L,5L,9L,10L,10L,10L,9L,3L,10L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201593Inst : IEnumerable<long>
{
public static readonly long[] Value=A201593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201593.Bytes);
public long this[int i]=>Value[i];

public static A201593Inst Instance=new A201593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201594
{
public static readonly BigInteger[] Value={ 1L,1L,4L,32L,384L,6176L,124928L,3049472L,87265280L,2865848320L,106258440192L,4391008927744L,200131590356992L,9973976451383296L,539604322034384896L,BigInteger.Parse("31496226303081709568"),BigInteger.Parse("1972926888464596598784"),BigInteger.Parse("132015791534989604028416"),BigInteger.Parse("9398128264859870497341440"),BigInteger.Parse("709248762402156849800413184") };
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
public class A201594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201594Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201594.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201594Inst Instance=new A201594Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201595
{
public static readonly BigInteger[] Value={ 1L,1L,4L,28L,288L,3936L,67328L,1385728L,33372160L,921118720L,28677169152L,994360565760L,38007586684928L,1587878686621696L,71990467473965056L,3520403893852831744L,BigInteger.Parse("184707311409882464256"),BigInteger.Parse("10350444842488122310656"),BigInteger.Parse("616975843658373414256640"),BigInteger.Parse("38981881007475178476666880") };
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
public class A201595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201595Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201595.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201595Inst Instance=new A201595Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201596
{
public static readonly long[] Value={ 6L,24L,30L,90L,150L,156L,210L,240L,306L,366L,384L,444L,810L,834L,1086L,1200L,1326L,2316L,3876L,4230L,4350L,8244L,8880L,9450L,10686L,10950L,11784L,12816L,13554L,15504L,15576L,16254L,16506L,16596L,19446L,19944L,21516L,38340L,39990L,41556L,45786L,47190L,48246L,59856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201596Inst : IEnumerable<long>
{
public static readonly long[] Value=A201596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201596.Bytes);
public long this[int i]=>Value[i];

public static A201596Inst Instance=new A201596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201597
{
public static readonly long[] Value={ 7L,13L,37L,103L,307L,457L,613L,2137L,2377L,2797L,3463L,4783L,5737L,9433L,14557L,24103L,45817L,52177L,126487L,317587L,580687L,715873L,2719663L,6227563L,8114857L,10085623L,10137493L,18773137L,21297553L,25291363L,43472497L,52645423L,69718147L,80002627L,89776327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201597Inst : IEnumerable<long>
{
public static readonly long[] Value=A201597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201597.Bytes);
public long this[int i]=>Value[i];

public static A201597Inst Instance=new A201597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201598
{
public static readonly long[] Value={ 6L,24L,60L,84L,114L,180L,210L,264L,390L,564L,630L,1050L,1200L,1530L,2016L,2844L,3426L,3756L,3864L,3936L,4074L,4110L,6090L,8250L,9240L,9270L,10344L,10506L,10734L,10920L,12930L,15204L,20190L,20286L,21216L,25746L,34920L,38820L,39390L,41754L,43020L,44310L,52500L,71346L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201598Inst : IEnumerable<long>
{
public static readonly long[] Value=A201598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201598.Bytes);
public long this[int i]=>Value[i];

public static A201598Inst Instance=new A201598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201599
{
public static readonly long[] Value={ 5L,17L,41L,107L,347L,461L,881L,1607L,2267L,2687L,6197L,6827L,39227L,46181L,56891L,83267L,167621L,375251L,381527L,549161L,741677L,805031L,931571L,2095361L,2428451L,4769111L,4938287L,12300641L,12652457L,13430171L,14094797L,18074027L,29480651L,107379731L,138778301L,156377861L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201599Inst : IEnumerable<long>
{
public static readonly long[] Value=A201599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201599.Bytes);
public long this[int i]=>Value[i];

public static A201599Inst Instance=new A201599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201600
{
public static readonly long[] Value={ 5L,11L,29L,59L,101L,389L,491L,1019L,1181L,1949L,2909L,3461L,5051L,8219L,8669L,10091L,10589L,11621L,13259L,13829L,14411L,16229L,23819L,26141L,27749L,28571L,39371L,44381L,50789L,51899L,61211L,63659L,64901L,67421L,68699L,75269L,82139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201600Inst : IEnumerable<long>
{
public static readonly long[] Value=A201600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201600.Bytes);
public long this[int i]=>Value[i];

public static A201600Inst Instance=new A201600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201601
{
public static readonly long[] Value={ 7L,13L,31L,61L,103L,157L,223L,607L,733L,1021L,1543L,1741L,1951L,3181L,3463L,5407L,6151L,8221L,9133L,10093L,12157L,12703L,13831L,16231L,19501L,23071L,25357L,27751L,28573L,30253L,31981L,33757L,39373L,40351L,41341L,44383L,46471L,47533L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201601Inst : IEnumerable<long>
{
public static readonly long[] Value=A201601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201601.Bytes);
public long this[int i]=>Value[i];

public static A201601Inst Instance=new A201601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201602
{
public static readonly long[] Value={ 29L,113L,449L,701L,1009L,1373L,2269L,2801L,3389L,4733L,6301L,8093L,13553L,14813L,23549L,30493L,32369L,34301L,38333L,40433L,42589L,49393L,56701L,64513L,70001L,78653L,81649L,84701L,100801L,114689L,125693L,137201L,149213L,161729L,166013L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201602Inst : IEnumerable<long>
{
public static readonly long[] Value=A201602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201602.Bytes);
public long this[int i]=>Value[i];

public static A201602Inst Instance=new A201602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201603
{
public static readonly long[] Value={ 2L,569L,3089L,14177L,33329L,86249L,139169L,190577L,250049L,266177L,282809L,335729L,354377L,434009L,455177L,476849L,544889L,568577L,804449L,833177L,862409L,1148177L,1182449L,1324577L,1474769L,1673849L,1715177L,1885529L,2203049L,2647577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201603Inst : IEnumerable<long>
{
public static readonly long[] Value=A201603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201603.Bytes);
public long this[int i]=>Value[i];

public static A201603Inst Instance=new A201603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201604
{
public static readonly long[] Value={ 3L,31L,2803L,3391L,10111L,32371L,34303L,67231L,70003L,87811L,114691L,161731L,179203L,231871L,285631L,302851L,338803L,409951L,473203L,502771L,588703L,596851L,621631L,638431L,672703L,753091L,809203L,1075651L,1246591L,1294303L,1367551L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201604Inst : IEnumerable<long>
{
public static readonly long[] Value=A201604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201604.Bytes);
public long this[int i]=>Value[i];

public static A201604Inst Instance=new A201604Inst();

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