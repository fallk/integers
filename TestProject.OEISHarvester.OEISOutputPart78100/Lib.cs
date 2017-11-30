using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A097741
{
public static readonly BigInteger[] Value={ 1L,403L,162005L,65125607L,26180332009L,10524428342011L,4230794013156413L,1700768668860536015L,BigInteger.Parse("683704774087922321617"),BigInteger.Parse("274847618414675912754019"),BigInteger.Parse("110488058897925629004794021"),BigInteger.Parse("44415924829347688184014442423") };
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
public class A097741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097741Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097741.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097741Inst Instance=new A097741Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097742
{
public static readonly BigInteger[] Value={ 1L,401L,161201L,64802401L,26050404001L,10472197606001L,4209797387208401L,1692328077460171201L,BigInteger.Parse("680311677341601614401"),BigInteger.Parse("273483601963246388818001"),BigInteger.Parse("109939727677547706703222001"),BigInteger.Parse("44195497042772214848306426401") };
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
public class A097742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097742Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097742.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097742Inst Instance=new A097742Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097743
{
public static readonly long[] Value={ 5L,11L,47L,191L,3071L,12287L,196607L,786431L,12582911L,805306367L,3221225471L,206158430207L,3298534883327L,13194139533311L,211106232532991L,13510798882111487L,864691128455135231L,3458764513820540927L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097743Inst : IEnumerable<long>
{
public static readonly long[] Value=A097743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097743.Bytes);
public long this[int i]=>Value[i];

public static A097743Inst Instance=new A097743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097744
{
public static readonly long[] Value={ 2L,3L,1L,4L,1L,2L,1L,3L,1L,2L,1L,2L,1L,2L,2L,0L,1L,0L,2L,2L,2L,0L,1L,1L,1L,1L,2L,1L,1L,0L,1L,0L,0L,2L,2L,0L,1L,0L,1L,1L,3L,0L,0L,0L,2L,0L,1L,0L,1L,0L,1L,0L,1L,1L,3L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,2L,0L,0L,0L,1L,1L,1L,0L,1L,2L,1L,0L,0L,2L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,2L,0L,1L,2L,1L,0L,0L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097744Inst : IEnumerable<long>
{
public static readonly long[] Value=A097744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097744.Bytes);
public long this[int i]=>Value[i];

public static A097744Inst Instance=new A097744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097745
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,17L,19L,20L,21L,23L,24L,25L,26L,27L,28L,29L,31L,34L,35L,37L,39L,40L,41L,45L,47L,49L,51L,53L,54L,55L,58L,59L,62L,66L,70L,71L,72L,74L,75L,76L,79L,86L,88L,90L,93L,94L,96L,98L,99L,100L,105L,113L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097745Inst : IEnumerable<long>
{
public static readonly long[] Value=A097745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097745.Bytes);
public long this[int i]=>Value[i];

public static A097745Inst Instance=new A097745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097746
{
public static readonly long[] Value={ 16L,18L,22L,30L,32L,33L,36L,38L,42L,43L,44L,46L,48L,50L,52L,56L,57L,60L,61L,63L,64L,65L,67L,68L,69L,73L,77L,78L,80L,81L,82L,83L,84L,85L,87L,89L,91L,92L,95L,97L,101L,102L,103L,104L,106L,107L,108L,109L,110L,111L,112L,114L,115L,116L,117L,118L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097746Inst : IEnumerable<long>
{
public static readonly long[] Value=A097746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097746.Bytes);
public long this[int i]=>Value[i];

public static A097746Inst Instance=new A097746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097747
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,3L,3L,4L,3L,4L,4L,5L,4L,5L,5L,4L,5L,5L,6L,5L,5L,6L,6L,6L,5L,6L,6L,7L,5L,8L,6L,7L,7L,7L,7L,6L,7L,7L,8L,8L,6L,9L,7L,8L,8L,8L,8L,9L,8L,8L,8L,9L,9L,8L,9L,8L,8L,9L,9L,9L,9L,10L,8L,11L,9L,9L,10L,10L,9L,10L,8L,12L,7L,13L,9L,11L,10L,11L,9L,12L,9L,10L,10L,11L,11L,10L,11L,11L,9L,12L,10L,11L,11L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097747Inst : IEnumerable<long>
{
public static readonly long[] Value=A097747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097747.Bytes);
public long this[int i]=>Value[i];

public static A097747Inst Instance=new A097747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097748
{
public static readonly long[] Value={ 0L,1L,3L,7L,11L,18L,27L,29L,41L,61L,63L,71L,73L,97L,99L,141L,166L,209L,205L,236L,253L,303L,338L,375L,394L,415L,457L,417L,507L,595L,617L,698L,723L,721L,835L,833L,920L,841L,843L,991L,1180L,1123L,1054L,1217L,1473L,1261L,1559L,1629L,1641L,1836L,1805L,1834L,1981L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097748Inst : IEnumerable<long>
{
public static readonly long[] Value=A097748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097748.Bytes);
public long this[int i]=>Value[i];

public static A097748Inst Instance=new A097748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097749
{
public static readonly long[] Value={ 2L,1L,2L,-1L,10L,6L,5L,-35L,105L,30L,-63L,420L,-882L,1260L,210L,1576L,-10395L,20790L,-20790L,17325L,1890L,-68409L,450450L,-891891L,849420L,-495495L,270270L,20790L,4729726L,-31126095L,61486425L,-57972915L,32207175L,-12297285L,4729725L,270270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097749Inst : IEnumerable<long>
{
public static readonly long[] Value=A097749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097749.Bytes);
public long this[int i]=>Value[i];

public static A097749Inst Instance=new A097749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097750
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,4L,1L,6L,11L,8L,1L,8L,22L,26L,16L,1L,10L,37L,64L,57L,32L,1L,12L,56L,130L,163L,120L,64L,1L,14L,79L,232L,386L,382L,247L,128L,1L,16L,106L,378L,794L,1024L,848L,502L,256L,1L,18L,137L,576L,1471L,2380L,2510L,1816L,1013L,512L,1L,20L,172L,834L,2517L,4944L,6476L,5812L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097750Inst : IEnumerable<long>
{
public static readonly long[] Value=A097750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097750.Bytes);
public long this[int i]=>Value[i];

public static A097750Inst Instance=new A097750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097751
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,3L,8L,9L,10L,3L,12L,5L,6L,15L,16L,5L,18L,3L,20L,21L,6L,3L,24L,25L,10L,27L,12L,5L,30L,3L,32L,21L,10L,15L,36L,5L,6L,15L,40L,5L,42L,3L,12L,45L,6L,3L,48L,9L,50L,15L,20L,5L,54L,15L,24L,21L,10L,3L,60L,5L,6L,63L,64L,65L,42L,3L,20L,21L,30L,3L,72L,5L,10L,75L,12L,21L,30L,3L,80L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097751Inst : IEnumerable<long>
{
public static readonly long[] Value=A097751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097751.Bytes);
public long this[int i]=>Value[i];

public static A097751Inst Instance=new A097751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097752
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,9L,10L,12L,15L,16L,18L,20L,21L,24L,25L,27L,30L,32L,36L,40L,42L,45L,48L,50L,54L,60L,63L,64L,65L,72L,75L,80L,81L,84L,90L,96L,100L,105L,108L,120L,125L,126L,128L,130L,135L,144L,150L,160L,162L,168L,180L,189L,192L,195L,200L,210L,216L,225L,231L,240L,243L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097752Inst : IEnumerable<long>
{
public static readonly long[] Value=A097752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097752.Bytes);
public long this[int i]=>Value[i];

public static A097752Inst Instance=new A097752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097753
{
public static readonly long[] Value={ 1L,2L,5L,3L,10L,25L,4L,15L,50L,125L,6L,20L,75L,250L,65L,8L,30L,100L,375L,130L,3125L,9L,40L,150L,500L,195L,6250L,15625L,12L,45L,200L,750L,260L,9375L,31250L,325L,16L,60L,225L,1000L,390L,12500L,46875L,650L,390625L,18L,80L,300L,1125L,520L,18750L,62500L,975L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097753Inst : IEnumerable<long>
{
public static readonly long[] Value=A097753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097753.Bytes);
public long this[int i]=>Value[i];

public static A097753Inst Instance=new A097753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097754
{
public static readonly long[] Value={ 1L,2L,5L,3L,25L,65L,4L,125L,325L,1105L,6L,625L,1625L,5525L,32045L,8L,3125L,4225L,27625L,160225L,1185665L,9L,15625L,8125L,71825L,801125L,5928325L,48612265L,10L,78125L,21125L,138125L,2082925L,29641625L,243061325L,2576450045L,12L,390625L,40625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097754Inst : IEnumerable<long>
{
public static readonly long[] Value=A097754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097754.Bytes);
public long this[int i]=>Value[i];

public static A097754Inst Instance=new A097754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097755
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,9L,12L,16L,18L,21L,24L,27L,32L,36L,42L,48L,54L,63L,64L,72L,81L,84L,96L,108L,126L,128L,144L,162L,168L,189L,192L,216L,231L,243L,252L,256L,288L,324L,336L,378L,384L,432L,441L,462L,486L,504L,512L,567L,576L,648L,672L,693L,729L,756L,768L,864L,882L,924L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097755Inst : IEnumerable<long>
{
public static readonly long[] Value=A097755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097755.Bytes);
public long this[int i]=>Value[i];

public static A097755Inst Instance=new A097755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097756
{
public static readonly long[] Value={ 1L,5L,25L,125L,65L,625L,3125L,15625L,325L,78125L,390625L,1953125L,1625L,9765625L,48828125L,4225L,244140625L,1105L,8125L,1220703125L,6103515625L,30517578125L,40625L,152587890625L,21125L,762939453125L,3814697265625L,203125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097756Inst : IEnumerable<long>
{
public static readonly long[] Value=A097756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097756.Bytes);
public long this[int i]=>Value[i];

public static A097756Inst Instance=new A097756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097757
{
public static readonly long[] Value={ 2L,3L,6L,7L,8L,11L,12L,15L,18L,19L,22L,23L,24L,27L,28L,31L,32L,33L,43L,44L,47L,48L,60L,67L,72L,76L,92L,96L,108L,112L,128L,0L,1L,4L,5L,9L,10L,13L,14L,16L,17L,20L,21L,34L,35L,36L,37L,38L,39L,40L,42L,51L,52L,55L,56L,57L,58L,59L,63L,64L,68L,71L,73L,80L,83L,88L,97L,124L,132L,25L,26L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097757Inst : IEnumerable<long>
{
public static readonly long[] Value=A097757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097757.Bytes);
public long this[int i]=>Value[i];

public static A097757Inst Instance=new A097757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097758
{
public static readonly long[] Value={ 128L,132L,188L,192L,193L,213L,228L,224L,253L,288L,257L,293L,297L,292L,317L,301L,333L,284L,337L,357L,353L,329L,332L,349L,336L,373L,397L,362L,393L,372L,377L,413L,368L,365L,388L,389L,417L,437L,433L,319L,343L,421L,405L,457L,453L,364L,408L,351L,432L,402L,473L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097758Inst : IEnumerable<long>
{
public static readonly long[] Value=A097758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097758.Bytes);
public long this[int i]=>Value[i];

public static A097758Inst Instance=new A097758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097759
{
public static readonly long[] Value={ 31L,38L,25L,30L,19L,14L,13L,10L,17L,15L,6L,11L,7L,6L,10L,5L,8L,6L,8L,5L,7L,6L,1L,4L,4L,10L,3L,7L,7L,3L,4L,5L,3L,6L,5L,2L,5L,3L,2L,1L,2L,8L,1L,3L,5L,1L,4L,1L,4L,2L,4L,7L,2L,2L,2L,4L,1L,1L,5L,1L,2L,2L,5L,2L,3L,2L,2L,2L,0L,1L,5L,2L,3L,1L,1L,1L,2L,2L,6L,1L,4L,0L,2L,1L,3L,1L,3L,4L,0L,2L,4L,5L,1L,1L,1L,0L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097759Inst : IEnumerable<long>
{
public static readonly long[] Value=A097759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097759.Bytes);
public long this[int i]=>Value[i];

public static A097759Inst Instance=new A097759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097760
{
public static readonly long[] Value={ 68L,81L,88L,95L,99L,104L,107L,115L,116L,118L,126L,134L,139L,149L,150L,152L,153L,157L,163L,164L,169L,177L,178L,180L,181L,184L,193L,197L,204L,207L,208L,209L,211L,212L,215L,217L,220L,225L,226L,227L,228L,229L,230L,231L,232L,236L,237L,238L,239L,244L,246L,247L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097760Inst : IEnumerable<long>
{
public static readonly long[] Value=A097760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097760.Bytes);
public long this[int i]=>Value[i];

public static A097760Inst Instance=new A097760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097761
{
public static readonly long[] Value={ 1L,-2L,1L,4L,-4L,1L,-10L,13L,-6L,1L,28L,-42L,26L,-8L,1L,-84L,138L,-102L,43L,-10L,1L,264L,-462L,385L,-198L,64L,-12L,1L,-858L,1573L,-1430L,845L,-338L,89L,-14L,1L,2860L,-5434L,5278L,-3458L,1610L,-530L,118L,-16L,1L,-9724L,19006L,-19448L,13804L,-7208L,2788L,-782L,151L,-18L,1L,33592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097761Inst : IEnumerable<long>
{
public static readonly long[] Value=A097761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097761.Bytes);
public long this[int i]=>Value[i];

public static A097761Inst Instance=new A097761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097762
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,16L,106L,491L,1919L,7771L,40261L,264892L,1871728L,12988977L,88413417L,612354549L,4492798353L,35529920764L,299329573882L,2625719242667L,23612697535919L,216981233646783L,2047084700918445L,19952633715109592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097762Inst : IEnumerable<long>
{
public static readonly long[] Value=A097762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097762.Bytes);
public long this[int i]=>Value[i];

public static A097762Inst Instance=new A097762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097763
{
public static readonly long[] Value={ 0L,0L,0L,3L,10L,25L,56L,224L,1506L,9951L,57992L,315425L,1761552L,11022180L,78474748L,603715831L,4771273414L,38070877273L,309146434240L,2598546954268L,22887194502518L,211388690471531L,2031261113410564L,20121026325645745L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097763Inst : IEnumerable<long>
{
public static readonly long[] Value=A097763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097763.Bytes);
public long this[int i]=>Value[i];

public static A097763Inst Instance=new A097763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097764
{
public static readonly long[] Value={ 4L,16L,27L,36L,64L,100L,144L,196L,216L,256L,324L,400L,484L,576L,676L,729L,784L,900L,1024L,1156L,1296L,1444L,1600L,1728L,1764L,1936L,2116L,2304L,2500L,2704L,2916L,3125L,3136L,3364L,3375L,3600L,3844L,4096L,4356L,4624L,4900L,5184L,5476L,5776L,5832L,6084L,6400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097764Inst : IEnumerable<long>
{
public static readonly long[] Value=A097764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097764.Bytes);
public long this[int i]=>Value[i];

public static A097764Inst Instance=new A097764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097765
{
public static readonly BigInteger[] Value={ 1L,486L,236195L,114790284L,55787841829L,27112776338610L,13176753512722631L,6403875094406860056L,BigInteger.Parse("3112270119128221264585"),BigInteger.Parse("1512556874021221127728254"),BigInteger.Parse("735099528504194339854666859"),BigInteger.Parse("357256858296164427948240365220") };
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
public class A097765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097765Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097765.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097765Inst Instance=new A097765Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097766
{
public static readonly BigInteger[] Value={ 1L,487L,236681L,115026479L,55902632113L,27168564180439L,13203866289061241L,6417051847919582687L,BigInteger.Parse("3118673994222628124641"),BigInteger.Parse("1515669144140349348992839"),BigInteger.Parse("736612085378215560982395113"),BigInteger.Parse("357991957824668622288095032079") };
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
public class A097766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097766Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097766.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097766Inst Instance=new A097766Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097767
{
public static readonly BigInteger[] Value={ 1L,485L,235709L,114554089L,55673051545L,27056988496781L,13149640736384021L,6390698340894137425L,BigInteger.Parse("3105866244033814404529"),BigInteger.Parse("1509444603902092906463669"),BigInteger.Parse("733586971630173118726938605"),BigInteger.Parse("356521758767660233608385698361") };
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
public class A097767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097767Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097767.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097767Inst Instance=new A097767Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097768
{
public static readonly BigInteger[] Value={ 1L,578L,334083L,193099396L,111611116805L,64511032413894L,37287265124113927L,BigInteger.Parse("21551974730705435912"),BigInteger.Parse("12457004107082617843209"),BigInteger.Parse("7200126821919022407938890"),BigInteger.Parse("4161660846065087869170835211"),BigInteger.Parse("2405432768898798869358334813068") };
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
public class A097768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097768Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097768.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097768Inst Instance=new A097768Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097769
{
public static readonly BigInteger[] Value={ 1L,579L,334661L,193433479L,111804216201L,64622643530699L,37351776156527821L,BigInteger.Parse("21589261995829549839"),BigInteger.Parse("12478556081813323279121"),BigInteger.Parse("7212583826026105025782099"),BigInteger.Parse("4168860972887006891578774101"),BigInteger.Parse("2409594429744863957227505648279") };
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
public class A097769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097769Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097769.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097769Inst Instance=new A097769Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097770
{
public static readonly BigInteger[] Value={ 1L,577L,333505L,192765313L,111418017409L,64399421297089L,37222754091700033L,BigInteger.Parse("21514687465581321985"),BigInteger.Parse("12435452132351912407297"),BigInteger.Parse("7187669817811939790095681"),BigInteger.Parse("4154460719243168846762896321"),BigInteger.Parse("2401271108052733781489163977857") };
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
public class A097770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097770Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097770.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097770Inst Instance=new A097770Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097771
{
public static readonly BigInteger[] Value={ 1L,678L,459683L,311664396L,211308000805L,143266512881394L,97134484425584327L,BigInteger.Parse("65857037174033292312"),BigInteger.Parse("44650974069510146603209"),BigInteger.Parse("30273294562090705363683390"),BigInteger.Parse("20525249062123428726430735211") };
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
public class A097771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097771Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097771.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097771Inst Instance=new A097771Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097772
{
public static readonly BigInteger[] Value={ 1L,679L,460361L,312124079L,211619665201L,143477820882199L,97277750938465721L,BigInteger.Parse("65954171658458876639"),BigInteger.Parse("44716831106684179895521"),BigInteger.Parse("30317945536160215510286599"),BigInteger.Parse("20555522356685519431794418601") };
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
public class A097772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097772Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097772.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097772Inst Instance=new A097772Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097773
{
public static readonly BigInteger[] Value={ 1L,677L,459005L,311204713L,210996336409L,143055204880589L,96991217912702933L,BigInteger.Parse("65759902689607707985"),BigInteger.Parse("44585117032336113310897"),BigInteger.Parse("30228643588021195217080181"),BigInteger.Parse("20494975767561338021067051821") };
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
public class A097773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097773Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097773.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097773Inst Instance=new A097773Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097774
{
public static readonly BigInteger[] Value={ 1L,786L,617795L,485586084L,381670044229L,299992169177910L,235793463303793031L,BigInteger.Parse("185333362164612144456"),BigInteger.Parse("145671786867921841749385"),BigInteger.Parse("114497839144824403002872154"),BigInteger.Parse("89995155896045112838415763659") };
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
public class A097774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097774Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097774.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097774Inst Instance=new A097774Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097775
{
public static readonly BigInteger[] Value={ 1L,787L,618581L,486203879L,382155630313L,300373839222139L,236093455472970941L,BigInteger.Parse("185569155627915937487"),BigInteger.Parse("145857120230086453893841"),BigInteger.Parse("114643510931692324844621539"),BigInteger.Parse("90109653735189937241418635813"),BigInteger.Parse("70826073192348358979430203127479"),BigInteger.Parse("55669203419532074967894898239562681") };
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
public class A097775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097775Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097775.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097775Inst Instance=new A097775Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097776
{
public static readonly BigInteger[] Value={ 1L,785L,617009L,484968289L,381184458145L,299610499133681L,235493471134615121L,BigInteger.Parse("185097568701308351425"),BigInteger.Parse("145486453505757229604929"),BigInteger.Parse("114352167357956481161122769"),BigInteger.Parse("89880658056900288435412891505") };
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
public class A097776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097776Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097776.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097776Inst Instance=new A097776Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097777
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,8L,16L,1L,32L,5L,65L,17L,134L,50L,1L,280L,136L,7L,592L,355L,31L,1264L,904L,114L,1L,2722L,2264L,378L,9L,5906L,5604L,1176L,49L,12900L,13752L,3504L,215L,1L,28344L,33530L,10112L,835L,11L,62608L,81358L,28468L,2997L,71L,138949L,196688L,78576L,10173L,361L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097777Inst : IEnumerable<long>
{
public static readonly long[] Value=A097777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097777.Bytes);
public long this[int i]=>Value[i];

public static A097777Inst Instance=new A097777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097778
{
public static readonly BigInteger[] Value={ 1L,23L,528L,12121L,278255L,6387744L,146639857L,3366328967L,77278926384L,1774048977865L,40725847564511L,934920445005888L,21462444387570913L,492701300469125111L,11310667466402306640UL,BigInteger.Parse("259652650426783927609") };
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
public class A097778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097778Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097778.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097778Inst Instance=new A097778Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097779
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,2L,5L,11L,25L,58L,135L,317L,750L,1785L,4272L,10275L,24823L,60210L,146576L,358010L,877087L,2154751L,5307166L,13102511L,32418806L,80375267L,199650310L,496803811L,1238276667L,3091173482L,7727893389L,19346109435L,48493869237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097779Inst : IEnumerable<long>
{
public static readonly long[] Value=A097779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097779.Bytes);
public long this[int i]=>Value[i];

public static A097779Inst Instance=new A097779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097780
{
public static readonly BigInteger[] Value={ 1L,25L,624L,15575L,388751L,9703200L,242191249L,6045078025L,150884759376L,3766073906375L,94000962899999L,2346257998593600L,58562449001940001L,1461714967049906425L,BigInteger.Parse("36484311727245720624"),BigInteger.Parse("910646078214093109175") };
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
public class A097780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097780Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097780.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097780Inst Instance=new A097780Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097781
{
public static readonly BigInteger[] Value={ 1L,27L,728L,19629L,529255L,14270256L,384767657L,10374456483L,279725557384L,7542215592885L,203360095450511L,5483180361570912L,147842509666964113L,3986264580646460139L,BigInteger.Parse("107481301167787459640"),BigInteger.Parse("2898008866949614950141") };
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
public class A097781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097781Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097781.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097781Inst Instance=new A097781Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097782
{
public static readonly BigInteger[] Value={ 1L,29L,840L,24331L,704759L,20413680L,591291961L,17127053189L,496093250520L,14369577211891L,416221645894319L,12056058153723360L,349209464812083121L,10115018421396687149UL,BigInteger.Parse("292986324755691844200"),BigInteger.Parse("8486488399493666794651") };
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
public class A097782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097782Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097782.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097782Inst Instance=new A097782Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097783
{
public static readonly BigInteger[] Value={ 1L,12L,131L,1429L,15588L,170039L,1854841L,20233212L,220710491L,2407582189L,26262693588L,286482047279L,3125039826481L,34088956044012L,371853476657651L,4056299287190149L,44247438682433988L,482665526219583719L,5265073349732986921L,BigInteger.Parse("57433141320843272412") };
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
public class A097783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097783Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097783.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097783Inst Instance=new A097783Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097784
{
public static readonly ulong[] Value={ 1L,11L,110L,1090L,10791L,106821L,1057420L,10467380L,103616381L,1025696431L,10153347930L,100507782870L,994924480771L,9848737024841L,97492445767640L,965075720651560L,9553264760747961L,94567571886828051L,936122454107532550L,9266656969188497450UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097784Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A097784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097784.Bytes);
public ulong this[int i]=>Value[i];

public static A097784Inst Instance=new A097784Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097785
{
public static readonly long[] Value={ 497L,1771L,2279L,3161L,3487L,5149L,5357L,5993L,6439L,8129L,9451L,9731L,11477L,15049L,16469L,18337L,19901L,25879L,26333L,28681L,29159L,34717L,40187L,43069L,48517L,50401L,54947L,60379L,61073L,62479L,67529L,69749L,72011L,73537L,79001L,88829L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097785Inst : IEnumerable<long>
{
public static readonly long[] Value=A097785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097785.Bytes);
public long this[int i]=>Value[i];

public static A097785Inst Instance=new A097785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097786
{
public static readonly long[] Value={ 1L,7L,31L,113L,374L,1178L,3618L,10974L,33087L,99481L,298729L,896551L,2690108L,8070884L,24213332L,72640812L,217923405L,653771355L,1961315395L,5883947725L,17651844946L,52955536862L,158866612886L,476599841258L,1429799526699L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097786Inst : IEnumerable<long>
{
public static readonly long[] Value=A097786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097786.Bytes);
public long this[int i]=>Value[i];

public static A097786Inst Instance=new A097786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097787
{
public static readonly long[] Value={ 1L,8L,39L,152L,526L,1704L,5322L,16296L,49383L,148864L,447593L,1344144L,4034252L,12105136L,36318468L,108959280L,326882685L,980654040L,2941969435L,8825917160L,26477762106L,79433298968L,238299911854L,714899753112L,2144699279811L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097787Inst : IEnumerable<long>
{
public static readonly long[] Value=A097787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097787.Bytes);
public long this[int i]=>Value[i];

public static A097787Inst Instance=new A097787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097788
{
public static readonly long[] Value={ 1L,8L,42L,188L,787L,3204L,12900L,51720L,207045L,828400L,3313886L,13255908L,53024087L,212096908L,848388312L,3393554064L,13574217225L,54296870040L,217187481490L,868749927500L,3474999711771L,13899998849108L,55599995398732L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097788Inst : IEnumerable<long>
{
public static readonly long[] Value=A097788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097788.Bytes);
public long this[int i]=>Value[i];

public static A097788Inst Instance=new A097788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097789
{
public static readonly long[] Value={ 1L,9L,51L,239L,1026L,4230L,17130L,68850L,275895L,1104295L,4418181L,17674089L,70698176L,282795084L,1131183396L,4524737460L,18098954685L,72395824725L,289583306215L,1158333233715L,4633332945486L,18533331794594L,74133327193326L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097789Inst : IEnumerable<long>
{
public static readonly long[] Value=A097789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097789.Bytes);
public long this[int i]=>Value[i];

public static A097789Inst Instance=new A097789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097790
{
public static readonly long[] Value={ 1L,9L,55L,295L,1510L,7606L,38114L,190690L,953615L,4768295L,23841761L,119209169L,596046300L,2980232060L,14901160980L,74505805716L,372529029549L,1862645148885L,9313225745755L,46566128730315L,232830643653346L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097790Inst : IEnumerable<long>
{
public static readonly long[] Value=A097790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097790.Bytes);
public long this[int i]=>Value[i];

public static A097790Inst Instance=new A097790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097791
{
public static readonly long[] Value={ 1L,10L,65L,360L,1870L,9476L,47590L,238280L,1191895L,5960190L,29801951L,149011120L,745057420L,3725289480L,18626450460L,93132256176L,465661285725L,2328306434610L,11641532180365L,58207660910680L,291038304564026L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097791Inst : IEnumerable<long>
{
public static readonly long[] Value=A097791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097791.Bytes);
public long this[int i]=>Value[i];

public static A097791Inst Instance=new A097791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097792
{
public static readonly long[] Value={ 4L,27L,64L,216L,324L,729L,1024L,1728L,2500L,3125L,3375L,5184L,5832L,9261L,9604L,13824L,16384L,19683L,26244L,27000L,35937L,40000L,46656L,58564L,59319L,74088L,82944L,91125L,100000L,110592L,114244L,132651L,153664L,157464L,185193L,202500L,216000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097792Inst : IEnumerable<long>
{
public static readonly long[] Value=A097792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097792.Bytes);
public long this[int i]=>Value[i];

public static A097792Inst Instance=new A097792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097793
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,4L,4L,5L,7L,8L,10L,12L,14L,17L,21L,24L,28L,34L,39L,46L,53L,61L,71L,82L,94L,108L,124L,142L,162L,185L,210L,238L,271L,306L,345L,390L,439L,494L,556L,623L,698L,783L,875L,977L,1092L,1216L,1354L,1508L,1674L,1859L,2064L,2286L,2532L,2803L,3098L,3424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097793Inst : IEnumerable<long>
{
public static readonly long[] Value=A097793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097793.Bytes);
public long this[int i]=>Value[i];

public static A097793Inst Instance=new A097793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097794
{
public static readonly long[] Value={ 3L,2L,1L,1L,4L,1L,60L,1L,2L,21L,28L,1L,2L,1L,28L,0L,234L,1L,2L,1L,2L,159L,10L,1L,68L,145L,0L,69L,186L,1L,32L,1L,26L,261L,4L,0L,8L,1L,62L,3L,22L,1L,6L,1L,8L,945L,76L,1L,116L,129L,382L,93L,330L,1L,2L,555L,224L,1359L,78L,1L,62L,1L,110L,0L,1032L,37L,462L,1L,100L,9L,88L,1L,1416L,1L,218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097794Inst : IEnumerable<long>
{
public static readonly long[] Value=A097794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097794.Bytes);
public long this[int i]=>Value[i];

public static A097794Inst Instance=new A097794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097795
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,2L,1L,2L,2L,1L,2L,2L,1L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097795Inst : IEnumerable<long>
{
public static readonly long[] Value=A097795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097795.Bytes);
public long this[int i]=>Value[i];

public static A097795Inst Instance=new A097795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097796
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,2L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097796Inst : IEnumerable<long>
{
public static readonly long[] Value=A097796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097796.Bytes);
public long this[int i]=>Value[i];

public static A097796Inst Instance=new A097796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097797
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,10L,14L,20L,27L,37L,49L,65L,85L,111L,143L,184L,234L,297L,374L,469L,585L,727L,899L,1108L,1360L,1664L,2028L,2464L,2985L,3606L,4343L,5218L,6252L,7474L,8913L,10605L,12591L,14918L,17639L,20816L,24519L,28829L,33836L,39646L,46377L,54165L,63162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097797Inst : IEnumerable<long>
{
public static readonly long[] Value=A097797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097797.Bytes);
public long this[int i]=>Value[i];

public static A097797Inst Instance=new A097797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097798
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,2L,0L,0L,0L,0L,0L,2L,0L,1L,0L,0L,0L,4L,0L,1L,0L,2L,0L,4L,0L,2L,0L,0L,0L,7L,0L,2L,0L,2L,0L,8L,0L,5L,0L,2L,0L,14L,0L,4L,0L,4L,0L,14L,0L,8L,0L,5L,0L,23L,0L,9L,0L,9L,0L,26L,0L,18L,0L,9L,0L,38L,0L,16L,0L,17L,0L,46L,0L,29L,0L,19L,0L,65L,0L,32L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097798Inst : IEnumerable<long>
{
public static readonly long[] Value=A097798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097798.Bytes);
public long this[int i]=>Value[i];

public static A097798Inst Instance=new A097798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097799
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,14L,20L,27L,37L,49L,85L,111L,143L,184L,234L,374L,585L,727L,899L,1360L,1664L,2028L,2985L,4343L,5218L,6252L,7474L,8913L,12591L,14918L,17639L,24519L,33836L,39646L,46377L,54165L,63162L,85507L,99276L,115103L,133276L,154116L,205308L,272190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097799Inst : IEnumerable<long>
{
public static readonly long[] Value=A097799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097799.Bytes);
public long this[int i]=>Value[i];

public static A097799Inst Instance=new A097799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097800
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,4L,2L,4L,7L,8L,5L,14L,14L,5L,23L,26L,18L,38L,17L,46L,65L,34L,75L,50L,106L,59L,125L,175L,203L,275L,326L,243L,434L,519L,675L,477L,806L,1044L,1244L,985L,1604L,1902L,2420L,1892L,2887L,2391L,3632L,2932L,4342L,5424L,4509L,6460L,5513L,8021L,9557L,11817L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097800Inst : IEnumerable<long>
{
public static readonly long[] Value=A097800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097800.Bytes);
public long this[int i]=>Value[i];

public static A097800Inst Instance=new A097800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097801
{
public static readonly BigInteger[] Value={ 2L,2L,6L,30L,210L,1890L,20790L,270270L,4054050L,68918850L,1309458150L,27498621150L,632468286450L,15811707161250L,426916093353750L,12380566707258750L,383797567925021250L,12665319741525701250UL,BigInteger.Parse("443286190953399543750"),BigInteger.Parse("16401589065275783118750"),BigInteger.Parse("639661973545755541631250") };
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
public class A097801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097801Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097801.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097801Inst Instance=new A097801Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097802
{
public static readonly long[] Value={ 3L,78L,153L,228L,303L,378L,453L,528L,603L,678L,753L,828L,903L,978L,1053L,1128L,1203L,1278L,1353L,1428L,1503L,1578L,1653L,1728L,1803L,1878L,1953L,2028L,2103L,2178L,2253L,2328L,2403L,2478L,2553L,2628L,2703L,2778L,2853L,2928L,3003L,3078L,3153L,3228L,3303L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097802Inst : IEnumerable<long>
{
public static readonly long[] Value=A097802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097802.Bytes);
public long this[int i]=>Value[i];

public static A097802Inst Instance=new A097802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097803
{
public static readonly long[] Value={ 3L,9L,27L,57L,99L,153L,219L,297L,387L,489L,603L,729L,867L,1017L,1179L,1353L,1539L,1737L,1947L,2169L,2403L,2649L,2907L,3177L,3459L,3753L,4059L,4377L,4707L,5049L,5403L,5769L,6147L,6537L,6939L,7353L,7779L,8217L,8667L,9129L,9603L,10089L,10587L,11097L,11619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097803Inst : IEnumerable<long>
{
public static readonly long[] Value=A097803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097803.Bytes);
public long this[int i]=>Value[i];

public static A097803Inst Instance=new A097803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097804
{
public static readonly long[] Value={ 9L,33L,153L,753L,3753L,18753L,93753L,468753L,2343753L,11718753L,58593753L,292968753L,1464843753L,7324218753L,36621093753L,183105468753L,915527343753L,4577636718753L,22888183593753L,114440917968753L,572204589843753L,2861022949218753L,14305114746093753L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097804Inst : IEnumerable<long>
{
public static readonly long[] Value=A097804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097804.Bytes);
public long this[int i]=>Value[i];

public static A097804Inst Instance=new A097804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097805
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,1L,2L,1L,0L,1L,3L,3L,1L,0L,1L,4L,6L,4L,1L,0L,1L,5L,10L,10L,5L,1L,0L,1L,6L,15L,20L,15L,6L,1L,0L,1L,7L,21L,35L,35L,21L,7L,1L,0L,1L,8L,28L,56L,70L,56L,28L,8L,1L,0L,1L,9L,36L,84L,126L,126L,84L,36L,9L,1L,0L,1L,10L,45L,120L,210L,252L,210L,120L,45L,10L,1L,0L,1L,11L,55L,165L,330L,462L,462L,330L,165L,55L,11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097805Inst : IEnumerable<long>
{
public static readonly long[] Value=A097805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097805.Bytes);
public long this[int i]=>Value[i];

public static A097805Inst Instance=new A097805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097806
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097806Inst : IEnumerable<long>
{
public static readonly long[] Value=A097806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097806.Bytes);
public long this[int i]=>Value[i];

public static A097806Inst Instance=new A097806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097807
{
public static readonly long[] Value={ 1L,-1L,1L,1L,-1L,1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,1L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097807Inst : IEnumerable<long>
{
public static readonly long[] Value=A097807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097807.Bytes);
public long this[int i]=>Value[i];

public static A097807Inst Instance=new A097807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097808
{
public static readonly long[] Value={ 1L,0L,1L,-1L,-1L,1L,2L,0L,-2L,1L,-3L,2L,2L,-3L,1L,4L,-5L,0L,5L,-4L,1L,-5L,9L,-5L,-5L,9L,-5L,1L,6L,-14L,14L,0L,-14L,14L,-6L,1L,-7L,20L,-28L,14L,14L,-28L,20L,-7L,1L,8L,-27L,48L,-42L,0L,42L,-48L,27L,-8L,1L,-9L,35L,-75L,90L,-42L,-42L,90L,-75L,35L,-9L,1L,10L,-44L,110L,-165L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097808Inst : IEnumerable<long>
{
public static readonly long[] Value=A097808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097808.Bytes);
public long this[int i]=>Value[i];

public static A097808Inst Instance=new A097808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097809
{
public static readonly long[] Value={ 1L,4L,12L,30L,68L,146L,304L,622L,1260L,2538L,5096L,10214L,20452L,40930L,81888L,163806L,327644L,655322L,1310680L,2621398L,5242836L,10485714L,20971472L,41942990L,83886028L,167772106L,335544264L,671088582L,1342177220L,2684354498L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097809Inst : IEnumerable<long>
{
public static readonly long[] Value=A097809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097809.Bytes);
public long this[int i]=>Value[i];

public static A097809Inst Instance=new A097809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097810
{
public static readonly long[] Value={ 1L,5L,16L,41L,94L,203L,424L,869L,1762L,3551L,7132L,14297L,28630L,57299L,114640L,229325L,458698L,917447L,1834948L,3669953L,7339966L,14679995L,29360056L,58720181L,117440434L,234880943L,469761964L,939524009L,1879048102L,3758096291L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097810Inst : IEnumerable<long>
{
public static readonly long[] Value=A097810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097810.Bytes);
public long this[int i]=>Value[i];

public static A097810Inst Instance=new A097810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097811
{
public static readonly long[] Value={ 6L,20L,40L,60L,70L,180L,330L,540L,1155L,1581L,2805L,2856L,3876L,5544L,16830L,27060L,62244L,82680L,90090L,175440L,237456L,249424L,273819L,413820L,431548L,534660L,860706L,1074744L,1205750L,1306620L,1630200L,1764070L,1962820L,1983150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097811Inst : IEnumerable<long>
{
public static readonly long[] Value=A097811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097811.Bytes);
public long this[int i]=>Value[i];

public static A097811Inst Instance=new A097811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097812
{
public static readonly long[] Value={ 5L,29L,70L,77L,92L,106L,138L,143L,158L,169L,182L,195L,245L,253L,274L,357L,385L,413L,430L,440L,495L,531L,650L,652L,655L,679L,724L,788L,795L,985L,1012L,1022L,1055L,1133L,1281L,1365L,1397L,1518L,1525L,1529L,1546L,1599L,1612L,1786L,1828L,2205L,2222L,2257L,2372L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097812Inst : IEnumerable<long>
{
public static readonly long[] Value=A097812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097812.Bytes);
public long this[int i]=>Value[i];

public static A097812Inst Instance=new A097812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097813
{
public static readonly long[] Value={ 1L,2L,6L,16L,38L,84L,178L,368L,750L,1516L,3050L,6120L,12262L,24548L,49122L,98272L,196574L,393180L,786394L,1572824L,3145686L,6291412L,12582866L,25165776L,50331598L,100663244L,201326538L,402653128L,805306310L,1610612676L,3221225410L,6442450880L,12884901822L,25769803708L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097813Inst : IEnumerable<long>
{
public static readonly long[] Value=A097813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097813.Bytes);
public long this[int i]=>Value[i];

public static A097813Inst Instance=new A097813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097814
{
public static readonly BigInteger[] Value={ 1L,6L,45L,432L,5265L,79218L,1426653L,29961900L,719092161L,19415508030L,582465299949L,19221355075464L,691968783248145L,26986782548271978L,1133444867032206045L,BigInteger.Parse("51005019016463620932"),BigInteger.Parse("2448240912790296851457") };
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
public class A097814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097814Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097814.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097814Inst Instance=new A097814Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097815
{
public static readonly BigInteger[] Value={ 1L,8L,80L,1024L,16640L,333824L,8015872L,224460800L,7182811136L,258581463040L,10343259570176L,455103425282048L,21844964430315520L,1135938150443515904L,BigInteger.Parse("63612536425105326080"),BigInteger.Parse("3816752185507393306624"),BigInteger.Parse("244272139872477466591232") };
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
public class A097815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097815Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097815.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097815Inst Instance=new A097815Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097816
{
public static readonly BigInteger[] Value={ 1L,10L,125L,2000L,40625L,1018750L,30578125L,1070312500L,42812890625L,1926582031250L,96329111328125L,5298101171875000L,317886070556640625L,BigInteger.Parse("20662594587402343750"),BigInteger.Parse("1446381621124267578125"),BigInteger.Parse("108478621584350585937500") };
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
public class A097816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097816Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097816.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097816Inst Instance=new A097816Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097817
{
public static readonly BigInteger[] Value={ 1L,5L,34L,314L,3784L,56792L,1022320L,21468848L,515252608L,13911820928L,417354628864L,13772702754560L,495817299168256L,19336874667570176L,812148736037963776L,BigInteger.Parse("36546693121708402688"),BigInteger.Parse("1754241269842003394560") };
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
public class A097817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097817Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097817.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097817Inst Instance=new A097817Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097818
{
public static readonly BigInteger[] Value={ 8L,818L,81818L,8181818L,818181818L,81818181818L,8181818181818L,818181818181818L,81818181818181818L,8181818181818181818L,BigInteger.Parse("818181818181818181818"),BigInteger.Parse("81818181818181818181818") };
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
public class A097818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097818Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097818.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097818Inst Instance=new A097818Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097819
{
public static readonly BigInteger[] Value={ 1L,7L,65L,807L,12993L,260103L,6243201L,174811815L,5593984641L,201383466759L,8055338729409L,354434904271143L,17012875405546305L,884669521090002183L,BigInteger.Parse("49541493181044905217"),BigInteger.Parse("2972489590862708661927"),BigInteger.Parse("190239333815213397410049"),BigInteger.Parse("12936274699434511153023495") };
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
public class A097819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097819Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097819.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097819Inst Instance=new A097819Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097820
{
public static readonly BigInteger[] Value={ 1L,6L,52L,632L,10128L,202592L,4862272L,136143744L,4356600064L,156837602816L,6273504113664L,276034181003264L,13249640688160768L,688981315784368128L,BigInteger.Parse("38582953683924631552"),BigInteger.Parse("2314977221035477925888"),BigInteger.Parse("148158542146270587322368") };
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
public class A097820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097820Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097820.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097820Inst Instance=new A097820Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097821
{
public static readonly BigInteger[] Value={ 1L,7L,74L,1118L,22376L,559432L,16783024L,587405968L,23496238976L,1057330754432L,52866537722624L,2907659574746368L,174459574484786176L,11339872341511109632UL,BigInteger.Parse("793791063905777690624"),BigInteger.Parse("59534329792933326829568") };
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
public class A097821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097821Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097821.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097821Inst Instance=new A097821Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097822
{
public static readonly long[] Value={ 420L,431L,491L,492L,514L,533L,573L,574L,603L,614L,655L,686L,738L,775L,798L,858L,861L,890L,995L,901L,904L,917L,919L,942L,984L,989L,1025L,1059L,1116L,1130L,1162L,1169L,1188L,1215L,1222L,1224L,1245L,1251L,1253L,1268L,1271L,1318L,1321L,1334L,1365L,1374L,1407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097822Inst : IEnumerable<long>
{
public static readonly long[] Value=A097822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097822.Bytes);
public long this[int i]=>Value[i];

public static A097822Inst Instance=new A097822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097823
{
public static readonly long[] Value={ 40L,603L,798L,890L,917L,1245L,1253L,1318L,1640L,1651L,1721L,2010L,2069L,2251L,2452L,2606L,2649L,3094L,3099L,3321L,3402L,3527L,3607L,4123L,4239L,4301L,4819L,4943L,5002L,5083L,5308L,5372L,5425L,5736L,5790L,5930L,5958L,5998L,6150L,6416L,6511L,6683L,6764L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097823Inst : IEnumerable<long>
{
public static readonly long[] Value=A097823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097823.Bytes);
public long this[int i]=>Value[i];

public static A097823Inst Instance=new A097823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097824
{
public static readonly long[] Value={ 12L,12L,4L,52L,52L,72L,96L,198L,198L,114L,594L,48L,354L,1860L,3942L,2574L,2574L,2574L,20910L,20910L,9600L,9600L,152250L,152250L,152250L,152250L,1887270L,4667040L,4094790L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097824Inst : IEnumerable<long>
{
public static readonly long[] Value=A097824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097824.Bytes);
public long this[int i]=>Value[i];

public static A097824Inst Instance=new A097824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097825
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,1L,3L,1L,2L,4L,2L,1L,5L,4L,3L,1L,3L,2L,5L,6L,4L,6L,1L,2L,3L,5L,4L,7L,1L,7L,4L,5L,6L,8L,3L,2L,9L,7L,6L,1L,4L,5L,3L,2L,8L,7L,10L,8L,3L,6L,9L,5L,4L,1L,2L,5L,11L,10L,7L,6L,3L,8L,9L,1L,2L,4L,11L,10L,12L,1L,4L,5L,9L,6L,3L,2L,7L,8L,3L,6L,7L,11L,10L,5L,4L,9L,12L,13L,1L,8L,2L,14L,6L,7L,1L,2L,3L,13L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097825Inst : IEnumerable<long>
{
public static readonly long[] Value=A097825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097825.Bytes);
public long this[int i]=>Value[i];

public static A097825Inst Instance=new A097825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097826
{
public static readonly BigInteger[] Value={ 1L,12L,132L,1441L,15720L,171480L,1870561L,20404692L,222581052L,2427986881L,26485274640L,288910034160L,3151525101121L,34377866078172L,375005001758772L,4090677153268321L,44622443684192760L,486756203372852040L,5309695793417179681L,BigInteger.Parse("57919897524216124452") };
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
public class A097826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097826Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097826.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097826Inst Instance=new A097826Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097827
{
public static readonly long[] Value={ 1L,13L,156L,1860L,22165L,264121L,3147288L,37503336L,446892745L,5325209605L,63455622516L,756142260588L,9010251504541L,107366875793905L,1279392258022320L,15245340220473936L,181664690387664913L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097827Inst : IEnumerable<long>
{
public static readonly long[] Value=A097827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097827.Bytes);
public long this[int i]=>Value[i];

public static A097827Inst Instance=new A097827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097828
{
public static readonly long[] Value={ 1L,14L,182L,2353L,30408L,392952L,5077969L,65620646L,847990430L,10958254945L,141609323856L,1829962955184L,23647909093537L,305592855260798L,3949059209296838L,51032176865598097L,659469240043478424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097828Inst : IEnumerable<long>
{
public static readonly long[] Value=A097828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097828.Bytes);
public long this[int i]=>Value[i];

public static A097828Inst Instance=new A097828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097829
{
public static readonly long[] Value={ 1L,16L,240L,3585L,53536L,799456L,11938305L,178275120L,2662188496L,39754552321L,593656096320L,8865086892480L,132382647290881L,1976874622470736L,29520736689770160L,440834175724081665L,6582991899171454816L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097829Inst : IEnumerable<long>
{
public static readonly long[] Value=A097829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097829.Bytes);
public long this[int i]=>Value[i];

public static A097829Inst Instance=new A097829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097830
{
public static readonly BigInteger[] Value={ 1L,17L,272L,4336L,69105L,1101345L,17552416L,279737312L,4458244577L,71052175921L,1132376570160L,18046972946640L,287619190576081L,4583860076270657L,73054142029754432L,1164282412399800256L,BigInteger.Parse("18555464456367049665"),BigInteger.Parse("295723148889472994385"),BigInteger.Parse("4713014917775200860496") };
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
public class A097830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097830Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097830.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097830Inst Instance=new A097830Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097831
{
public static readonly BigInteger[] Value={ 1L,18L,306L,5185L,87840L,1488096L,25209793L,427078386L,7235122770L,122570008705L,2076455025216L,35177165419968L,595935357114241L,10095723905522130L,171031371036761970L,2897437583719431361L,BigInteger.Parse("49085407552193571168") };
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
public class A097831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097831Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097831.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097831Inst Instance=new A097831Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097832
{
public static readonly ulong[] Value={ 1L,20L,380L,7201L,136440L,2585160L,48981601L,928065260L,17584258340L,333172843201L,6312699762480L,119608122643920L,2266241630472001L,42938982856324100L,813574432639685900L,15414975237297708001UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097832Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A097832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097832.Bytes);
public ulong this[int i]=>Value[i];

public static A097832Inst Instance=new A097832Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097833
{
public static readonly BigInteger[] Value={ 1L,21L,420L,8380L,167181L,3335241L,66537640L,1327417560L,26481813561L,528308853661L,10539695259660L,210265596339540L,4194772231531141L,83685179034283281L,1669508808454134480L,BigInteger.Parse("33306490990048406320") };
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
public class A097833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097833Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097833.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097833Inst Instance=new A097833Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097834
{
public static readonly BigInteger[] Value={ 1L,28L,755L,20357L,548884L,14799511L,399037913L,10759224140L,290100013867L,7821941150269L,210902311043396L,5686540457021423L,153325690028535025L,4134107090313424252L,BigInteger.Parse("111467565748433919779"),BigInteger.Parse("3005490168117402409781") };
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
public class A097834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097834Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097834.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097834Inst Instance=new A097834Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097835
{
public static readonly BigInteger[] Value={ 1L,26L,701L,18901L,509626L,13741001L,370497401L,9989688826L,269351100901L,7262490035501L,195817879857626L,5279820266120401L,142359329305393201L,3838422070979496026L,BigInteger.Parse("103495036587140999501"),BigInteger.Parse("2790527565781827490501") };
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
public class A097835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097835Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097835.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097835Inst Instance=new A097835Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097836
{
public static readonly BigInteger[] Value={ 1L,51L,2600L,132549L,6757399L,344494800L,17562477401L,895341852651L,45644872007800L,2326993130545149L,118631004785794799L,6047854250944989600L,BigInteger.Parse("308321935793408674801"),BigInteger.Parse("15718370871212897425251"),BigInteger.Parse("801328592496064360013000") };
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
public class A097836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097836Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097836.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097836Inst Instance=new A097836Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097837
{
public static readonly BigInteger[] Value={ 1L,52L,2651L,135149L,6889948L,351252199L,17906972201L,912904330052L,46540213860451L,2372638002552949L,120957997916339948L,6166485255730784399L,BigInteger.Parse("314369790044353664401"),BigInteger.Parse("16026692807006306100052"),BigInteger.Parse("817046963367277257438251") };
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
public class A097837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097837Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097837.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097837Inst Instance=new A097837Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097838
{
public static readonly BigInteger[] Value={ 1L,50L,2549L,129949L,6624850L,337737401L,17217982601L,877779375250L,44749530155149L,2281348258537349L,116304011655249650L,5929223246159194801L,BigInteger.Parse("302274081542463685201"),BigInteger.Parse("15410048935419488750450"),BigInteger.Parse("785610221624851462587749") };
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
public class A097838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097838Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097838.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097838Inst Instance=new A097838Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097839
{
public static readonly BigInteger[] Value={ 1L,83L,6888L,571621L,47437655L,3936753744L,326703123097L,27112422463307L,2250004361331384L,186723249568041565L,15495779709786118511UL,BigInteger.Parse("1285962992662679794848"),BigInteger.Parse("106719432611292636853873"),BigInteger.Parse("8856426943744626179076611"),BigInteger.Parse("734976716898192680226504840") };
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
public class A097839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097839Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097839.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097839Inst Instance=new A097839Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097840
{
public static readonly BigInteger[] Value={ 1L,84L,6971L,578509L,48009276L,3984191399L,330639876841L,27439125586404L,2277116783794691L,188973253929372949L,15682502959354160076UL,BigInteger.Parse("1301458772372465913359"),BigInteger.Parse("108005395603955316648721") };
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
public class A097840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097840Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097840.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097840Inst Instance=new A097840Inst();

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