using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A194105
{
public static readonly long[] Value={ 1L,3L,2L,5L,6L,10L,4L,8L,9L,14L,15L,7L,12L,13L,19L,20L,21L,28L,11L,17L,18L,25L,26L,27L,35L,36L,16L,23L,24L,32L,33L,34L,43L,44L,45L,22L,30L,31L,40L,41L,42L,52L,53L,54L,55L,66L,29L,38L,39L,49L,50L,51L,62L,63L,64L,65L,77L,78L,37L,47L,48L,59L,60L,61L,73L,74L,75L,76L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194105Inst : IEnumerable<long>
{
public static readonly long[] Value=A194105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194105.Bytes);
public long this[int i]=>Value[i];

public static A194105Inst Instance=new A194105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194106
{
public static readonly long[] Value={ 1L,4L,9L,15L,23L,33L,45L,58L,73L,90L,109L,129L,151L,175L,200L,227L,256L,287L,319L,353L,389L,427L,466L,507L,550L,595L,641L,689L,739L,790L,843L,898L,955L,1013L,1073L,1135L,1199L,1264L,1331L,1400L,1471L,1543L,1617L,1693L,1770L,1849L,1930L,2013L,2097L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194106Inst : IEnumerable<long>
{
public static readonly long[] Value=A194106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194106.Bytes);
public long this[int i]=>Value[i];

public static A194106Inst Instance=new A194106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194107
{
public static readonly long[] Value={ 1L,2L,3L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,6L,1L,2L,3L,4L,5L,6L,7L,8L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194107Inst : IEnumerable<long>
{
public static readonly long[] Value=A194107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194107.Bytes);
public long this[int i]=>Value[i];

public static A194107Inst Instance=new A194107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194156
{
public static readonly long[] Value={ 13L,23L,47L,113L,199L,283L,467L,887L,1627L,2803L,4297L,6397L,10343L,18461L,29453L,43067L,67993L,102679L,155893L,267961L,395323L,617819L,926707L,1513751L,2160469L,3278837L,4991687L,7115989L,11113793L,16310629L,24417233L,33888653L,52100569L,76020569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194156Inst : IEnumerable<long>
{
public static readonly long[] Value=A194156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194156.Bytes);
public long this[int i]=>Value[i];

public static A194156Inst Instance=new A194156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194157
{
public static readonly BigInteger[] Value={ 1L,3L,24L,504L,27720L,3991680L,1504863360L,1485300136320L,3838015552250880L,BigInteger.Parse("25964175210977203200"),BigInteger.Parse("459851507161617245875200"),BigInteger.Parse("21322394684069868456741273600"),BigInteger.Parse("2588389457883293541569193426124800"),BigInteger.Parse("822618641999347403739646931950148812800") };
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
public class A194157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194157Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194157.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194157Inst Instance=new A194157Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194158
{
public static readonly BigInteger[] Value={ 1L,2L,10L,130L,4420L,393380L,91657540L,55911099400L,89290025741800L,373321597626465800L,BigInteger.Parse("4086378207619294646800"),BigInteger.Parse("117103340295746126693347600"),BigInteger.Parse("8785678105688353155168403690000"),BigInteger.Parse("1725665322163094950031867515982420000"),BigInteger.Parse("887387152950606153059937200876123854180000") };
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
public class A194158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194158Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194158.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194158Inst Instance=new A194158Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194159
{
public static readonly long[] Value={ 8L,3L,2L,8L,8L,3L,2L,4L,4L,0L,3L,3L,9L,1L,2L,9L,8L,2L,4L,5L,0L,2L,5L,6L,6L,4L,3L,1L,3L,6L,1L,4L,2L,2L,9L,4L,2L,2L,7L,3L,2L,1L,5L,1L,9L,9L,4L,0L,9L,0L,5L,0L,3L,2L,4L,5L,1L,5L,4L,2L,2L,4L,0L,8L,9L,2L,5L,7L,6L,0L,6L,4L,8L,3L,9L,8L,5L,4L,5L,9L,9L,3L,4L,0L,8L,9L,1L,1L,6L,9L,2L,5L,6L,6L,8L,0L,5L,5L,8L,1L,8L,2L,1L,4L,9L,5L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194159Inst : IEnumerable<long>
{
public static readonly long[] Value=A194159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194159.Bytes);
public long this[int i]=>Value[i];

public static A194159Inst Instance=new A194159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194160
{
public static readonly long[] Value={ 1L,4L,7L,2L,8L,8L,5L,9L,2L,9L,0L,9L,9L,5L,6L,9L,3L,1L,4L,6L,0L,7L,1L,3L,4L,2L,8L,1L,5L,0L,3L,8L,1L,5L,9L,3L,2L,2L,6L,9L,6L,2L,9L,5L,1L,5L,2L,6L,5L,6L,9L,9L,0L,5L,3L,7L,1L,1L,1L,5L,8L,6L,2L,3L,7L,6L,2L,7L,3L,6L,4L,9L,2L,8L,7L,7L,0L,5L,3L,7L,4L,4L,8L,2L,0L,5L,3L,1L,5L,9L,0L,6L,0L,9L,3L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194160Inst : IEnumerable<long>
{
public static readonly long[] Value=A194160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194160.Bytes);
public long this[int i]=>Value[i];

public static A194160Inst Instance=new A194160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194161
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,2L,3L,3L,4L,4L,5L,6L,6L,7L,7L,8L,8L,8L,9L,9L,10L,10L,11L,12L,12L,13L,13L,14L,14L,14L,15L,15L,16L,16L,16L,17L,18L,18L,19L,19L,20L,21L,21L,22L,22L,22L,23L,24L,24L,25L,25L,25L,26L,27L,27L,28L,28L,28L,29L,30L,30L,30L,31L,31L,32L,32L,33L,33L,34L,35L,35L,36L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194161Inst : IEnumerable<long>
{
public static readonly long[] Value=A194161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194161.Bytes);
public long this[int i]=>Value[i];

public static A194161Inst Instance=new A194161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194162
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,8L,11L,14L,18L,22L,27L,33L,39L,46L,53L,61L,69L,77L,86L,95L,105L,115L,126L,138L,150L,163L,176L,190L,204L,218L,233L,248L,264L,280L,296L,313L,331L,349L,368L,387L,407L,428L,449L,471L,493L,515L,538L,562L,586L,611L,636L,661L,687L,714L,741L,769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194162Inst : IEnumerable<long>
{
public static readonly long[] Value=A194162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194162.Bytes);
public long this[int i]=>Value[i];

public static A194162Inst Instance=new A194162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194163
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,6L,7L,8L,9L,9L,10L,10L,11L,11L,12L,12L,12L,12L,13L,14L,14L,15L,16L,16L,16L,17L,18L,18L,18L,19L,19L,20L,20L,21L,21L,21L,22L,23L,23L,23L,24L,25L,25L,25L,26L,27L,27L,28L,29L,29L,29L,30L,31L,31L,31L,32L,33L,33L,33L,34L,34L,35L,36L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194163Inst : IEnumerable<long>
{
public static readonly long[] Value=A194163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194163.Bytes);
public long this[int i]=>Value[i];

public static A194163Inst Instance=new A194163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194164
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,9L,12L,16L,20L,25L,30L,36L,42L,48L,55L,63L,72L,81L,91L,101L,112L,123L,135L,147L,159L,171L,184L,198L,212L,227L,243L,259L,275L,292L,310L,328L,346L,365L,384L,404L,424L,445L,466L,487L,509L,532L,555L,578L,602L,627L,652L,677L,703L,730L,757L,785L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194164Inst : IEnumerable<long>
{
public static readonly long[] Value=A194164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194164.Bytes);
public long this[int i]=>Value[i];

public static A194164Inst Instance=new A194164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194165
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,2L,3L,4L,4L,4L,5L,6L,6L,6L,7L,8L,8L,8L,9L,9L,10L,11L,11L,12L,12L,12L,13L,13L,14L,15L,15L,16L,16L,16L,17L,17L,18L,18L,19L,19L,20L,21L,21L,21L,22L,23L,23L,23L,24L,24L,25L,25L,26L,26L,27L,28L,28L,29L,29L,30L,30L,31L,31L,32L,32L,33L,33L,33L,34L,34L,35L,36L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194165Inst : IEnumerable<long>
{
public static readonly long[] Value=A194165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194165.Bytes);
public long this[int i]=>Value[i];

public static A194165Inst Instance=new A194165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194166
{
public static readonly long[] Value={ 0L,0L,1L,3L,5L,7L,10L,14L,18L,22L,27L,33L,39L,45L,52L,60L,68L,76L,85L,94L,104L,115L,126L,138L,150L,162L,175L,188L,202L,217L,232L,248L,264L,280L,297L,314L,332L,350L,369L,388L,408L,429L,450L,471L,493L,516L,539L,562L,586L,610L,635L,660L,686L,712L,739L,767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194166Inst : IEnumerable<long>
{
public static readonly long[] Value=A194166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194166.Bytes);
public long this[int i]=>Value[i];

public static A194166Inst Instance=new A194166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194167
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,2L,3L,4L,4L,4L,4L,5L,5L,6L,7L,8L,8L,8L,8L,8L,9L,9L,10L,11L,12L,12L,12L,12L,13L,13L,14L,15L,16L,16L,16L,16L,16L,17L,18L,18L,19L,20L,20L,20L,21L,21L,22L,22L,23L,24L,24L,24L,24L,25L,25L,26L,27L,27L,28L,29L,29L,29L,29L,30L,31L,31L,32L,32L,33L,33L,33L,34L,34L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194167Inst : IEnumerable<long>
{
public static readonly long[] Value=A194167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194167.Bytes);
public long this[int i]=>Value[i];

public static A194167Inst Instance=new A194167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194168
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,4L,7L,11L,15L,19L,23L,28L,33L,39L,46L,54L,62L,70L,78L,86L,95L,104L,114L,125L,137L,149L,161L,173L,186L,199L,213L,228L,244L,260L,276L,292L,308L,325L,343L,361L,380L,400L,420L,440L,461L,482L,504L,526L,549L,573L,597L,621L,645L,670L,695L,721L,748L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194168Inst : IEnumerable<long>
{
public static readonly long[] Value=A194168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194168.Bytes);
public long this[int i]=>Value[i];

public static A194168Inst Instance=new A194168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194169
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,2L,3L,4L,4L,4L,5L,6L,6L,6L,7L,8L,8L,8L,8L,9L,10L,10L,11L,11L,12L,12L,13L,13L,14L,14L,15L,15L,16L,16L,16L,17L,17L,18L,19L,19L,20L,21L,21L,21L,22L,23L,23L,23L,24L,24L,25L,25L,25L,26L,27L,27L,28L,28L,29L,30L,30L,31L,31L,32L,32L,32L,33L,33L,34L,34L,35L,36L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194169Inst : IEnumerable<long>
{
public static readonly long[] Value=A194169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194169.Bytes);
public long this[int i]=>Value[i];

public static A194169Inst Instance=new A194169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194170
{
public static readonly long[] Value={ 0L,0L,1L,3L,5L,7L,10L,14L,18L,22L,27L,33L,39L,45L,52L,60L,68L,76L,84L,93L,103L,113L,124L,135L,147L,159L,172L,185L,199L,213L,228L,243L,259L,275L,291L,308L,325L,343L,362L,381L,401L,422L,443L,464L,486L,509L,532L,555L,579L,603L,628L,653L,678L,704L,731L,758L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194170Inst : IEnumerable<long>
{
public static readonly long[] Value=A194170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194170.Bytes);
public long this[int i]=>Value[i];

public static A194170Inst Instance=new A194170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194171
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,3L,3L,4L,5L,5L,5L,6L,6L,7L,7L,8L,8L,8L,9L,10L,11L,11L,12L,12L,13L,13L,14L,14L,15L,15L,16L,16L,16L,16L,17L,18L,18L,19L,20L,20L,20L,21L,22L,22L,22L,23L,24L,24L,24L,25L,26L,26L,26L,27L,27L,27L,28L,29L,29L,30L,30L,31L,31L,32L,32L,33L,33L,33L,34L,35L,35L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194171Inst : IEnumerable<long>
{
public static readonly long[] Value=A194171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194171.Bytes);
public long this[int i]=>Value[i];

public static A194171Inst Instance=new A194171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194188
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,3L,0L,2L,1L,5L,0L,4L,6L,3L,5L,2L,4L,8L,3L,7L,9L,0L,6L,8L,1L,5L,7L,11L,0L,6L,10L,3L,9L,2L,4L,8L,14L,3L,13L,15L,0L,6L,12L,14L,1L,5L,11L,13L,0L,12L,18L,3L,9L,17L,2L,8L,10L,16L,20L,9L,15L,19L,21L,0L,6L,18L,20L,5L,7L,13L,17L,19L,23L,6L,12L,18L,22L,3L,15L,21L,4L,10L,14L,16L,20L,26L,9L,15L,25L,0L,12L,18L,24L,1L,7L,11L,13L,17L,23L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194188Inst : IEnumerable<long>
{
public static readonly long[] Value=A194188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194188.Bytes);
public long this[int i]=>Value[i];

public static A194188Inst Instance=new A194188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194189
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,3L,6L,7L,8L,9L,12L,13L,15L,17L,18L,22L,25L,27L,30L,32L,35L,38L,41L,43L,48L,52L,55L,58L,62L,64L,68L,73L,79L,83L,86L,89L,93L,97L,103L,110L,114L,120L,123L,129L,132L,139L,141L,149L,157L,162L,162L,173L,183L,186L,192L,195L,198L,207L,213L,222L,229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194189Inst : IEnumerable<long>
{
public static readonly long[] Value=A194189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194189.Bytes);
public long this[int i]=>Value[i];

public static A194189Inst Instance=new A194189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194190
{
public static readonly long[] Value={ 0L,0L,28L,1668L,25052L,215448L,1189868L,5199888L,18520572L,56978440L,155627304L,388897892L,894254904L,1932504496L,3945470564L,7669533756L,14291010972L,25694009628L,44662697948L,75451394832L,124066723008L,199190308172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194190Inst : IEnumerable<long>
{
public static readonly long[] Value=A194190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194190.Bytes);
public long this[int i]=>Value[i];

public static A194190Inst Instance=new A194190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194191
{
public static readonly long[] Value={ 0L,0L,2L,998L,36698L,620210L,5367308L,34678364L,169259212L,682686652L,2356999994L,7294368210L,20227526910L,52008171998L,124422857864L,279767468172L,596674510744L,1218556387684L,2385034544810L,4509309201242L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194191Inst : IEnumerable<long>
{
public static readonly long[] Value=A194191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194191.Bytes);
public long this[int i]=>Value[i];

public static A194191Inst Instance=new A194191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194192
{
public static readonly long[] Value={ 0L,0L,0L,204L,26700L,1073076L,15657764L,159413700L,1108580092L,6030207624L,26852315940L,104865006648L,354993232192L,1098793355508L,3109294280324L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194192Inst : IEnumerable<long>
{
public static readonly long[] Value=A194192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194192.Bytes);
public long this[int i]=>Value[i];

public static A194192Inst Instance=new A194192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194193
{
public static readonly long[] Value={ 1L,0L,4L,0L,6L,9L,0L,4L,36L,16L,0L,1L,76L,120L,25L,0L,0L,78L,516L,300L,36L,0L,0L,28L,1278L,2148L,630L,49L,0L,0L,2L,1668L,9498L,6768L,1176L,64L,0L,0L,0L,998L,25052L,47331L,17600L,2016L,81L,0L,0L,0L,204L,36698L,215448L,175952L,40120L,3240L,100L,0L,0L,0L,11L,26700L,620210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194193Inst : IEnumerable<long>
{
public static readonly long[] Value=A194193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194193.Bytes);
public long this[int i]=>Value[i];

public static A194193Inst Instance=new A194193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194194
{
public static readonly long[] Value={ 7L,55987L,8108731L,321272407L,3092313043L,4201025641L,9684836827L,31401724537L,47446779661L,83925549247L,100343116693L,141276239497L,265462278481L,438668366137L,654022685443L,742912017121L,2333350772341L,3324554405047L,4033516174507L,4432676798593L,9752186278927L,14505760086637L,15656690128843L,16882733081761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194194Inst : IEnumerable<long>
{
public static readonly long[] Value=A194194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194194.Bytes);
public long this[int i]=>Value[i];

public static A194194Inst Instance=new A194194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194195
{
public static readonly long[] Value={ 1L,2L,2L,1L,3L,3L,3L,2L,1L,4L,4L,4L,4L,3L,2L,1L,5L,5L,5L,5L,5L,4L,3L,2L,1L,6L,6L,6L,6L,6L,6L,5L,4L,3L,2L,1L,7L,7L,7L,7L,7L,7L,7L,6L,5L,4L,3L,2L,1L,8L,8L,8L,8L,8L,8L,8L,8L,7L,6L,5L,4L,3L,2L,1L,9L,9L,9L,9L,9L,9L,9L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194195Inst : IEnumerable<long>
{
public static readonly long[] Value=A194195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194195.Bytes);
public long this[int i]=>Value[i];

public static A194195Inst Instance=new A194195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194196
{
public static readonly long[] Value={ 1L,66L,94L,1092L,1146L,1416L,1491L,1782L,2130L,2159L,2805L,3012L,3531L,4836L,8736L,9065L,9911L,12532L,13156L,15960L,16194L,24096L,25866L,27652L,29316L,29484L,30942L,34162L,34782L,34860L,37736L,37884L,38232L,38688L,40257L,41331L,48204L,51460L,54162L,54411L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194196Inst : IEnumerable<long>
{
public static readonly long[] Value=A194196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194196.Bytes);
public long this[int i]=>Value[i];

public static A194196Inst Instance=new A194196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194197
{
public static readonly long[] Value={ 1L,19858L,436140L,2897747L,11402579L,33377536L,80758518L,171070425L,328507157L,585011614L,981355696L,1568220303L,2407275335L,3572259692L,5150061274L,7241796981L,9963892713L,13449163370L,17847892852L,23328914059L,30080688891L,38312388248L,48254972030L,60162269137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194197Inst : IEnumerable<long>
{
public static readonly long[] Value=A194197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194197.Bytes);
public long this[int i]=>Value[i];

public static A194197Inst Instance=new A194197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194198
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,3L,3L,3L,4L,4L,5L,6L,6L,7L,7L,8L,8L,9L,9L,10L,10L,11L,11L,12L,12L,12L,13L,13L,14L,15L,15L,15L,16L,16L,17L,18L,18L,18L,18L,19L,19L,20L,21L,21L,21L,22L,23L,23L,24L,24L,25L,25L,26L,26L,27L,27L,28L,28L,29L,29L,30L,30L,31L,31L,32L,32L,33L,33L,33L,34L,34L,35L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194198Inst : IEnumerable<long>
{
public static readonly long[] Value=A194198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194198.Bytes);
public long this[int i]=>Value[i];

public static A194198Inst Instance=new A194198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194199
{
public static readonly long[] Value={ 0L,0L,0L,1L,3L,6L,9L,12L,16L,20L,25L,31L,37L,44L,51L,59L,67L,76L,85L,95L,105L,116L,127L,139L,151L,163L,176L,189L,203L,218L,233L,248L,264L,280L,297L,315L,333L,351L,369L,388L,407L,427L,448L,469L,490L,512L,535L,558L,582L,606L,631L,656L,682L,708L,735L,762L,790L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194199Inst : IEnumerable<long>
{
public static readonly long[] Value=A194199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194199.Bytes);
public long this[int i]=>Value[i];

public static A194199Inst Instance=new A194199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194200
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,3L,3L,4L,4L,5L,6L,6L,6L,7L,7L,7L,8L,9L,9L,9L,10L,11L,11L,12L,13L,13L,13L,14L,15L,15L,16L,16L,17L,17L,18L,18L,19L,19L,19L,20L,20L,21L,22L,22L,22L,23L,23L,23L,24L,25L,25L,25L,26L,27L,27L,28L,28L,29L,29L,30L,30L,31L,32L,32L,33L,33L,34L,34L,34L,35L,36L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194200Inst : IEnumerable<long>
{
public static readonly long[] Value=A194200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194200.Bytes);
public long this[int i]=>Value[i];

public static A194200Inst Instance=new A194200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194201
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,9L,12L,15L,19L,23L,28L,34L,40L,46L,53L,60L,67L,75L,84L,93L,102L,112L,123L,134L,146L,159L,172L,185L,199L,214L,229L,245L,261L,278L,295L,313L,331L,350L,369L,388L,408L,428L,449L,471L,493L,515L,538L,561L,584L,608L,633L,658L,683L,709L,736L,763L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194201Inst : IEnumerable<long>
{
public static readonly long[] Value=A194201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194201.Bytes);
public long this[int i]=>Value[i];

public static A194201Inst Instance=new A194201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194202
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,3L,3L,4L,5L,5L,6L,6L,6L,7L,8L,8L,9L,9L,10L,10L,11L,11L,11L,12L,13L,14L,14L,14L,15L,15L,16L,16L,17L,18L,18L,18L,19L,19L,19L,20L,21L,21L,22L,22L,22L,23L,24L,24L,25L,25L,26L,26L,27L,27L,27L,28L,28L,29L,29L,30L,30L,31L,32L,32L,33L,33L,34L,34L,34L,35L,36L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194202Inst : IEnumerable<long>
{
public static readonly long[] Value=A194202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194202.Bytes);
public long this[int i]=>Value[i];

public static A194202Inst Instance=new A194202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194203
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,9L,12L,15L,19L,24L,29L,35L,41L,47L,54L,62L,70L,79L,88L,98L,108L,119L,130L,141L,153L,166L,180L,194L,208L,223L,238L,254L,270L,287L,305L,323L,341L,360L,379L,398L,418L,439L,460L,482L,504L,526L,549L,573L,597L,622L,647L,673L,699L,726L,753L,780L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194203Inst : IEnumerable<long>
{
public static readonly long[] Value=A194203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194203.Bytes);
public long this[int i]=>Value[i];

public static A194203Inst Instance=new A194203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194380
{
public static readonly long[] Value={ 31L,33L,45L,47L,79L,81L,93L,95L,127L,129L,141L,143L,175L,177L,189L,191L,223L,225L,237L,239L,525L,527L,539L,541L,573L,575L,587L,589L,621L,623L,635L,637L,669L,671L,683L,685L,717L,719L,731L,733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194380Inst : IEnumerable<long>
{
public static readonly long[] Value=A194380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194380.Bytes);
public long this[int i]=>Value[i];

public static A194380Inst Instance=new A194380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194381
{
public static readonly long[] Value={ 1L,2L,3L,7L,8L,9L,13L,14L,15L,19L,20L,21L,25L,26L,27L,31L,32L,33L,35L,36L,37L,38L,39L,41L,42L,43L,44L,45L,47L,48L,49L,50L,51L,53L,54L,55L,56L,57L,59L,60L,61L,62L,63L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194381Inst : IEnumerable<long>
{
public static readonly long[] Value=A194381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194381.Bytes);
public long this[int i]=>Value[i];

public static A194381Inst Instance=new A194381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194382
{
public static readonly long[] Value={ 4L,6L,10L,12L,16L,18L,22L,24L,28L,30L,34L,40L,46L,52L,58L,64L,104L,110L,116L,122L,128L,134L,138L,140L,144L,146L,150L,152L,156L,158L,162L,164L,168L,170L,172L,176L,178L,182L,184L,188L,190L,194L,196L,200L,202L,204L,208L,210L,214L,216L,220L,222L,226L,228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194382Inst : IEnumerable<long>
{
public static readonly long[] Value=A194382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194382.Bytes);
public long this[int i]=>Value[i];

public static A194382Inst Instance=new A194382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194383
{
public static readonly long[] Value={ 2L,3L,5L,6L,8L,9L,11L,12L,14L,15L,17L,20L,23L,26L,29L,32L,52L,55L,58L,61L,64L,67L,69L,70L,72L,73L,75L,76L,78L,79L,81L,82L,84L,85L,86L,88L,89L,91L,92L,94L,95L,97L,98L,100L,101L,102L,104L,105L,107L,108L,110L,111L,113L,114L,116L,117L,119L,122L,125L,128L,131L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194383Inst : IEnumerable<long>
{
public static readonly long[] Value=A194383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194383.Bytes);
public long this[int i]=>Value[i];

public static A194383Inst Instance=new A194383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194384
{
public static readonly long[] Value={ 5L,11L,17L,23L,29L,139L,145L,151L,157L,163L,169L,173L,174L,175L,179L,180L,181L,185L,186L,187L,191L,192L,193L,197L,198L,199L,203L,209L,215L,221L,227L,233L,343L,349L,355L,361L,367L,373L,377L,378L,379L,383L,384L,385L,389L,390L,391L,395L,396L,397L,401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194384Inst : IEnumerable<long>
{
public static readonly long[] Value=A194384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194384.Bytes);
public long this[int i]=>Value[i];

public static A194384Inst Instance=new A194384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227984
{
public static readonly long[] Value={ 1L,3L,1L,7L,1L,1L,15L,7L,3L,1L,31L,5L,1L,1L,1L,63L,31L,15L,7L,3L,1L,127L,21L,31L,1L,7L,1L,1L,255L,127L,9L,31L,15L,1L,3L,1L,511L,85L,127L,21L,1L,5L,7L,1L,1L,1023L,511L,255L,127L,63L,31L,15L,7L,3L,1L,2047L,341L,73L,17L,127L,1L,31L,1L,1L,1L,1L,4095L,2047L,1023L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227984Inst : IEnumerable<long>
{
public static readonly long[] Value=A227984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227984.Bytes);
public long this[int i]=>Value[i];

public static A227984Inst Instance=new A227984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227985
{
public static readonly long[] Value={ 1L,0L,-1L,0L,-1L,1L,0L,-1L,1L,-1L,0L,-1L,1L,-1L,0L,0L,-1L,1L,-5L,0L,1L,0L,-1L,1L,-1L,0L,1L,0L,0L,-1L,1L,-7L,0L,7L,0L,-1L,0L,-1L,1L,-2L,0L,7L,0L,-2L,0L,0L,-1L,1L,-3L,0L,7L,0L,-1L,0L,3L,0L,-1L,1L,-5L,0L,1L,0L,-1L,0L,1L,0L,0L,-1L,1L,-11L,0L,11L,0L,-11L,0L,11L,0L,-5L,0L,-1L,1L,-1L,0L,11L,0L,-22L,0L,33L,0L,-5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227985Inst : IEnumerable<long>
{
public static readonly long[] Value=A227985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227985.Bytes);
public long this[int i]=>Value[i];

public static A227985Inst Instance=new A227985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227986
{
public static readonly long[] Value={ 13L,35L,85L,91L,119L,185L,255L,245L,255L,313L,455L,481L,425L,455L,629L,559L,841L,845L,741L,765L,1183L,841L,793L,1355L,1015L,833L,935L,1295L,1547L,1105L,1443L,1505L,1445L,2197L,1785L,1799L,2735L,2041L,3315L,2405L,2135L,2523L,3523L,2873L,2755L,3605L,2191L,4165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227986Inst : IEnumerable<long>
{
public static readonly long[] Value=A227986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227986.Bytes);
public long this[int i]=>Value[i];

public static A227986Inst Instance=new A227986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227987
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,12L,7L,8L,19L,10L,11L,6L,51L,56L,15L,16L,71L,76L,9L,20L,21L,44L,23L,48L,13L,204L,25L,112L,455L,240L,31L,32L,271L,568L,143L,38L,307L,18L,79L,40L,83L,42L,43L,22L,179L,184L,47L,24L,783L,26L,27L,102L,819L,50L,207L,14L,1807L,3640L,911L,120L,3855L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227987Inst : IEnumerable<long>
{
public static readonly long[] Value=A227987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227987.Bytes);
public long this[int i]=>Value[i];

public static A227987Inst Instance=new A227987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227988
{
public static readonly long[] Value={ 3L,5L,2L,7L,0L,0L,0L,4L,7L,1L,8L,5L,2L,9L,5L,2L,8L,2L,9L,7L,6L,1L,5L,3L,6L,7L,9L,1L,7L,6L,9L,3L,2L,6L,2L,0L,3L,7L,6L,3L,5L,6L,4L,3L,4L,4L,9L,5L,2L,4L,0L,8L,2L,7L,7L,6L,0L,5L,7L,1L,7L,8L,2L,0L,6L,1L,9L,2L,1L,5L,4L,6L,3L,8L,0L,4L,1L,8L,8L,6L,1L,4L,8L,2L,3L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227988Inst : IEnumerable<long>
{
public static readonly long[] Value=A227988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227988.Bytes);
public long this[int i]=>Value[i];

public static A227988Inst Instance=new A227988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227989
{
public static readonly long[] Value={ 6L,3L,4L,0L,0L,9L,6L,6L,6L,8L,8L,9L,2L,1L,7L,1L,6L,3L,8L,8L,2L,9L,9L,6L,5L,9L,9L,4L,0L,0L,7L,5L,0L,4L,6L,0L,7L,8L,6L,3L,6L,4L,4L,3L,3L,5L,5L,9L,8L,9L,0L,1L,7L,8L,5L,4L,3L,9L,9L,6L,0L,6L,1L,1L,5L,9L,3L,7L,0L,8L,7L,7L,1L,3L,8L,6L,4L,2L,6L,5L,6L,1L,5L,8L,3L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227989Inst : IEnumerable<long>
{
public static readonly long[] Value=A227989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227989.Bytes);
public long this[int i]=>Value[i];

public static A227989Inst Instance=new A227989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227990
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,2L,0L,1L,1L,0L,0L,1L,0L,1L,3L,1L,0L,0L,2L,0L,0L,1L,2L,0L,1L,0L,3L,0L,1L,0L,1L,1L,0L,1L,0L,0L,0L,1L,1L,2L,0L,1L,0L,2L,0L,0L,0L,1L,0L,2L,1L,0L,2L,1L,1L,3L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,2L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,3L,0L,0L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227990Inst : IEnumerable<long>
{
public static readonly long[] Value=A227990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227990.Bytes);
public long this[int i]=>Value[i];

public static A227990Inst Instance=new A227990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227991
{
public static readonly long[] Value={ 3L,1L,3L,1L,3L,1L,9L,1L,3L,3L,1L,1L,3L,1L,3L,27L,3L,1L,1L,9L,1L,1L,3L,9L,1L,3L,1L,27L,1L,3L,1L,3L,3L,1L,3L,1L,1L,1L,3L,3L,9L,1L,3L,1L,9L,1L,1L,1L,3L,1L,9L,3L,1L,9L,3L,3L,27L,1L,1L,3L,1L,3L,1L,3L,1L,3L,1L,1L,3L,1L,3L,9L,1L,1L,1L,3L,3L,1L,3L,1L,3L,1L,27L,1L,1L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227991Inst : IEnumerable<long>
{
public static readonly long[] Value=A227991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227991.Bytes);
public long this[int i]=>Value[i];

public static A227991Inst Instance=new A227991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227992
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,8L,10L,16L,18L,24L,26L,32L,34L,40L,42L,64L,66L,72L,74L,96L,98L,104L,106L,128L,130L,136L,138L,160L,162L,168L,170L,256L,258L,264L,266L,288L,290L,296L,298L,384L,386L,392L,394L,416L,418L,424L,426L,512L,514L,520L,522L,544L,546L,552L,554L,640L,642L,648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227992Inst : IEnumerable<long>
{
public static readonly long[] Value=A227992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227992.Bytes);
public long this[int i]=>Value[i];

public static A227992Inst Instance=new A227992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227993
{
public static readonly long[] Value={ 4L,16L,27L,54L,64L,256L,729L,1024L,1296L,1536L,3125L,4096L,6250L,9375L,12500L,16384L,19683L,30720L,39366L,65536L,262144L,472392L,531441L,823543L,1048576L,1179648L,1647086L,2125764L,3294172L,4194304L,6291456L,6770688L,9765625L,11595672L,14348907L,16777216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227993Inst : IEnumerable<long>
{
public static readonly long[] Value=A227993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227993.Bytes);
public long this[int i]=>Value[i];

public static A227993Inst Instance=new A227993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227994
{
public static readonly long[] Value={ 461L,773L,1181L,1973L,2621L,6173L,7901L,9173L,11261L,21773L,29501L,37061L,44021L,50021L,51581L,54773L,58061L,66701L,68501L,72173L,75941L,81773L,85781L,96221L,109541L,118901L,126173L,143981L,204461L,210773L,220421L,233621L,236981L,254141L,279173L,286541L,328781L,336773L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227994Inst : IEnumerable<long>
{
public static readonly long[] Value=A227994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227994.Bytes);
public long this[int i]=>Value[i];

public static A227994Inst Instance=new A227994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227995
{
public static readonly BigInteger[] Value={ 1L,3L,25L,195L,1625L,13879L,120717L,1063323L,9454977L,84688303L,762972225L,6906366907L,62762167561L,572251392039L,5232480571761L,47961608620959L,440565328458621L,4054586252967027L,37377503512616413L,345083448151227987L,3190232694060946333L,BigInteger.Parse("29529002023029712547") };
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
public class A227995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227995Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227995.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227995Inst Instance=new A227995Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227996
{
public static readonly BigInteger[] Value={ 1L,4L,41L,414L,4431L,48699L,545076L,6179444L,70725241L,815437894L,9456840276L,110196725574L,1289162119401L,15131911395879L,178121845513281L,2101890841202799L,24856330289305726L,294500697587787599L,3495147445120811176L,BigInteger.Parse("41542892270532317969"),BigInteger.Parse("494440478133277365001") };
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
public class A227996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227996Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227996.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227996Inst Instance=new A227996Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227997
{
public static readonly long[] Value={ 4L,20L,16L,176L,160L,64L,1876L,1808L,960L,256L,22064L,22048L,13248L,5120L,1024L,275568L,282528L,182528L,83456L,25600L,4096L,3584064L,3747456L,2542464L,1284096L,481280L,122880L,16384L,47995476L,50981136L,35851968L,19365120L,8186880L,2617344L,573440L,65536L,657037232L,707110432L,511288256L,290053120L,133084160L,48799744L,13647872L,2621440L,262144L,9150655216L,9958458656L,7363711104L,4338317824L,2113592320L,851398656L,276856832L,68943872L,11796480L,1048576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227997Inst : IEnumerable<long>
{
public static readonly long[] Value=A227997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227997.Bytes);
public long this[int i]=>Value[i];

public static A227997Inst Instance=new A227997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227998
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A227998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227998Inst : IEnumerable<long>
{
public static readonly long[] Value=A227998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227998.Bytes);
public long this[int i]=>Value[i];

public static A227998Inst Instance=new A227998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227999
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,2L,2L,5L,11L,25L,97L,220L,1396L,6053L,30467L,249431L,1381913L,19850884L,160799404L,1942868797L,36133524445L,458473480079L,13521902050025L,220176552243482L,7006033824529130L,276364333237297549L,7470025110120086101L,BigInteger.Parse("460097285931623600317"),BigInteger.Parse("17010560092754291510533"),BigInteger.Parse("1372227474279446678113082") };
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
public class A227999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227999Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227999.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227999Inst Instance=new A227999Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228080
{
public static readonly BigInteger[] Value={ 1L,2520L,7484400L,22870848000L,70579794285000L,218799620836917120L,BigInteger.Parse("679953587124305894400"),BigInteger.Parse("2116187746296592370688000"),BigInteger.Parse("6592431144164903462359935000"),BigInteger.Parse("20550499897066845200729434200000"),BigInteger.Parse("64091912654977017603465324370118400"),BigInteger.Parse("199956261330234671205699024876891648000") };
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
public class A228080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228080Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A228080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228080.Bytes);
public BigInteger this[int i]=>Value[i];

public static A228080Inst Instance=new A228080Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228081
{
public static readonly BigInteger[] Value={ 2L,65L,4097L,262145L,16777217L,1073741825L,68719476737L,4398046511105L,281474976710657L,18014398509481985L,1152921504606846977L,BigInteger.Parse("73786976294838206465"),BigInteger.Parse("4722366482869645213697"),BigInteger.Parse("302231454903657293676545"),BigInteger.Parse("19342813113834066795298817"),BigInteger.Parse("1237940039285380274899124225") };
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
public class A228081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228081Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A228081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228081.Bytes);
public BigInteger this[int i]=>Value[i];

public static A228081Inst Instance=new A228081Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228082
{
public static readonly long[] Value={ 0L,2L,3L,5L,7L,8L,9L,10L,11L,12L,14L,16L,17L,19L,20L,22L,24L,25L,26L,27L,28L,29L,31L,33L,34L,35L,36L,38L,40L,41L,42L,43L,44L,45L,47L,49L,50L,52L,53L,55L,57L,58L,59L,60L,61L,62L,64L,65L,66L,67L,68L,69L,70L,72L,73L,74L,75L,76L,77L,79L,81L,82L,84L,85L,87L,89L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228082Inst : IEnumerable<long>
{
public static readonly long[] Value=A228082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228082.Bytes);
public long this[int i]=>Value[i];

public static A228082Inst Instance=new A228082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228083
{
public static readonly long[] Value={ 1L,2L,4L,3L,5L,6L,5L,7L,8L,13L,7L,10L,9L,16L,15L,10L,12L,11L,17L,19L,18L,12L,14L,14L,19L,22L,20L,21L,14L,17L,17L,22L,25L,22L,24L,23L,17L,19L,19L,25L,28L,25L,26L,27L,30L,19L,22L,22L,28L,31L,28L,29L,31L,34L,32L,22L,25L,25L,31L,36L,31L,33L,36L,36L,33L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228083Inst : IEnumerable<long>
{
public static readonly long[] Value=A228083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228083.Bytes);
public long this[int i]=>Value[i];

public static A228083Inst Instance=new A228083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228084
{
public static readonly long[] Value={ 1L,4L,2L,6L,5L,3L,13L,8L,7L,5L,15L,16L,9L,10L,7L,18L,19L,17L,11L,12L,10L,21L,20L,22L,19L,14L,14L,12L,23L,24L,22L,25L,22L,17L,17L,14L,30L,27L,26L,25L,28L,25L,19L,19L,17L,32L,34L,31L,29L,28L,31L,28L,22L,22L,19L,37L,33L,36L,36L,33L,31L,36L,31L,25L,25L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228084Inst : IEnumerable<long>
{
public static readonly long[] Value=A228084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228084.Bytes);
public long this[int i]=>Value[i];

public static A228084Inst Instance=new A228084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228085
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,2L,0L,1L,1L,1L,1L,1L,1L,0L,2L,0L,1L,2L,0L,2L,1L,0L,2L,0L,1L,1L,1L,1L,1L,1L,0L,2L,0L,2L,1L,1L,2L,0L,2L,0L,1L,1L,1L,1L,1L,1L,0L,2L,0L,1L,2L,0L,2L,1L,0L,2L,0L,1L,1L,1L,1L,1L,1L,0L,2L,1L,1L,2L,1L,1L,2L,0L,1L,1L,1L,1L,1L,1L,0L,2L,0L,1L,2L,0L,2L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228085Inst : IEnumerable<long>
{
public static readonly long[] Value=A228085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228085.Bytes);
public long this[int i]=>Value[i];

public static A228085Inst Instance=new A228085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228086
{
public static readonly long[] Value={ 0L,0L,1L,2L,0L,3L,0L,5L,6L,8L,7L,9L,10L,0L,11L,0L,13L,14L,0L,15L,18L,0L,19L,0L,21L,22L,24L,23L,25L,26L,0L,27L,0L,29L,30L,33L,31L,0L,35L,0L,37L,38L,40L,39L,41L,42L,0L,43L,0L,45L,46L,0L,47L,50L,0L,51L,0L,53L,54L,56L,55L,57L,58L,0L,59L,64L,61L,62L,66L,63L,67L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228086Inst : IEnumerable<long>
{
public static readonly long[] Value=A228086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228086.Bytes);
public long this[int i]=>Value[i];

public static A228086Inst Instance=new A228086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228087
{
public static readonly long[] Value={ 0L,0L,1L,2L,0L,4L,0L,5L,6L,8L,7L,9L,10L,0L,12L,0L,13L,16L,0L,17L,18L,0L,20L,0L,21L,22L,24L,23L,25L,26L,0L,28L,0L,32L,30L,33L,34L,0L,36L,0L,37L,38L,40L,39L,41L,42L,0L,44L,0L,45L,48L,0L,49L,50L,0L,52L,0L,53L,54L,56L,55L,57L,58L,0L,60L,64L,61L,65L,66L,63L,68L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228087Inst : IEnumerable<long>
{
public static readonly long[] Value=A228087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228087.Bytes);
public long this[int i]=>Value[i];

public static A228087Inst Instance=new A228087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228088
{
public static readonly long[] Value={ 0L,2L,3L,7L,8L,9L,10L,11L,12L,16L,20L,24L,25L,26L,27L,28L,29L,34L,35L,40L,41L,42L,43L,44L,45L,49L,53L,57L,58L,59L,60L,61L,62L,65L,66L,68L,69L,72L,73L,74L,75L,76L,77L,81L,85L,89L,90L,91L,92L,93L,94L,99L,100L,105L,106L,107L,108L,109L,110L,114L,118L,122L,123L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228088Inst : IEnumerable<long>
{
public static readonly long[] Value=A228088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228088.Bytes);
public long this[int i]=>Value[i];

public static A228088Inst Instance=new A228088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228089
{
public static readonly long[] Value={ 0L,1L,2L,5L,6L,8L,7L,9L,10L,13L,18L,21L,22L,24L,23L,25L,26L,30L,33L,37L,38L,40L,39L,41L,42L,45L,50L,53L,54L,56L,55L,57L,58L,64L,61L,66L,63L,69L,70L,72L,71L,73L,74L,77L,82L,85L,86L,88L,87L,89L,90L,94L,97L,101L,102L,104L,103L,105L,106L,109L,114L,117L,118L,120L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228089Inst : IEnumerable<long>
{
public static readonly long[] Value=A228089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228089.Bytes);
public long this[int i]=>Value[i];

public static A228089Inst Instance=new A228089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228090
{
public static readonly long[] Value={ 0L,1L,2L,5L,6L,7L,8L,9L,10L,13L,18L,21L,22L,23L,24L,25L,26L,30L,33L,37L,38L,39L,40L,41L,42L,45L,50L,53L,54L,55L,56L,57L,58L,61L,63L,64L,66L,69L,70L,71L,72L,73L,74L,77L,82L,85L,86L,87L,88L,89L,90L,94L,97L,101L,102L,103L,104L,105L,106L,109L,114L,117L,118L,119L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228090Inst : IEnumerable<long>
{
public static readonly long[] Value=A228090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228090.Bytes);
public long this[int i]=>Value[i];

public static A228090Inst Instance=new A228090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228091
{
public static readonly long[] Value={ 4L,12L,16L,17L,20L,28L,32L,34L,36L,44L,48L,49L,52L,60L,65L,68L,76L,80L,81L,84L,92L,96L,98L,100L,108L,112L,113L,116L,124L,128L,129L,130L,131L,132L,140L,144L,145L,148L,156L,160L,162L,164L,172L,176L,177L,180L,188L,193L,196L,204L,208L,209L,212L,220L,224L,226L,228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228091Inst : IEnumerable<long>
{
public static readonly long[] Value=A228091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228091.Bytes);
public long this[int i]=>Value[i];

public static A228091Inst Instance=new A228091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228092
{
public static readonly long[] Value={ 1L,21L,12L,32L,33L,91L,14L,72L,111L,15L,92L,321L,301L,102L,322L,721L,901L,702L,931L,312L,332L,942L,152L,153L,74L,75L,34L,93L,703L,711L,121L,731L,132L,762L,361L,932L,972L,171L,741L,951L,154L,704L,104L,912L,981L,161L,362L,781L,371L,372L,992L,3002L,3012L,1011L,782L,1022L,7021L,993L,112L,3031L,994L,323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228092Inst : IEnumerable<long>
{
public static readonly long[] Value=A228092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228092.Bytes);
public long this[int i]=>Value[i];

public static A228092Inst Instance=new A228092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228093
{
public static readonly long[] Value={ 5L,509L,1013L,3533L,6053L,8069L,8573L,10589L,11093L,11597L,12101L,13109L,13613L,14621L,15629L,18149L,19157L,19661L,23189L,24197L,26717L,28229L,29741L,31253L,32261L,33773L,34781L,36293L,39317L,40829L,41333L,43853L,44357L,45869L,46877L,47381L,50909L,51413L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228093Inst : IEnumerable<long>
{
public static readonly long[] Value=A228093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228093.Bytes);
public long this[int i]=>Value[i];

public static A228093Inst Instance=new A228093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228094
{
public static readonly long[] Value={ 2L,3L,1L,2L,3L,2L,1L,4L,0L,5L,0L,1L,2L,2L,4L,3L,0L,1L,6L,0L,0L,7L,0L,0L,1L,4L,2L,0L,5L,4L,0L,0L,1L,4L,2L,0L,5L,4L,0L,0L,1L,6L,0L,2L,0L,9L,0L,0L,0L,1L,6L,0L,2L,0L,9L,0L,0L,0L,1L,4L,4L,0L,0L,6L,5L,0L,0L,0L,1L,10L,0L,0L,0L,0L,11L,0L,0L,0L,0L,1L,4L,2L,2L,2L,0L,7L,6L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228094Inst : IEnumerable<long>
{
public static readonly long[] Value=A228094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228094.Bytes);
public long this[int i]=>Value[i];

public static A228094Inst Instance=new A228094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228095
{
public static readonly BigInteger[] Value={ 0L,0L,-72L,0L,9600L,0L,23970816L,0L,0L,-8814759178752000000L,BigInteger.Parse("-1217765613534782800527360"),0L,BigInteger.Parse("2555625991208076641833058304"),0L,0L,0L,BigInteger.Parse("164525463228624478317575381527120287356682240"),BigInteger.Parse("-33094833021317386202938131485140597289779200"),0L };
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
public class A228095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228095Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A228095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228095.Bytes);
public BigInteger this[int i]=>Value[i];

public static A228095Inst Instance=new A228095Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228464
{
public static readonly long[] Value={ 44L,383L,1821L,6254L,17487L,42386L,92430L,185727L,349558L,623513L,1063283L,1745172L,2771393L,4276212L,6433004L,9462285L,13640784L,19311619L,26895641L,36904010L,49952067L,66774566L,88242330L,115380395L,149387706L,191658429L,243804943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228464Inst : IEnumerable<long>
{
public static readonly long[] Value=A228464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228464.Bytes);
public long this[int i]=>Value[i];

public static A228464Inst Instance=new A228464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228465
{
public static readonly BigInteger[] Value={ 0L,1L,1L,9L,25L,313L,1913L,41977L,531705L,22023929L,566489849L,45671496441L,2366013917945L,376506912762617L,39141278944373497L,12376519796349807353UL,BigInteger.Parse("2577539376694811306745"),BigInteger.Parse("1624792742123856760679161"),BigInteger.Parse("677311275106408471956040441"),BigInteger.Parse("852536648457739021814912002809") };
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
public class A228465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228465Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A228465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228465.Bytes);
public BigInteger this[int i]=>Value[i];

public static A228465Inst Instance=new A228465Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228466
{
public static readonly long[] Value={ 5777L,1L,3L,13L,19L,55L,61L,169L,139L,271L,181L,391L,439L,559L,661L,619L,829L,859L,1069L,1081L,1459L,1489L,1609L,1741L,1951L,2029L,2509L,2341L,3631L,3769L,3331L,3961L,4525L,4189L,4261L,5281L,4801L,6229L,6361L,5911L,6439L,7111L,6319L,13081L,9931L,8869L,10321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228466Inst : IEnumerable<long>
{
public static readonly long[] Value=A228466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228466.Bytes);
public long this[int i]=>Value[i];

public static A228466Inst Instance=new A228466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228467
{
public static readonly BigInteger[] Value={ 0L,1L,4L,31L,492L,15713L,1005140L,128642207L,32931399852L,16860748082017L,17265373104585556L,BigInteger.Parse("35359467257443136671"),BigInteger.Parse("144832360621113983218860"),BigInteger.Parse("1186466662848698493085764449"),BigInteger.Parse("19439069659280715489603181513556"),BigInteger.Parse("636979433408843822314618558750438559") };
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
public class A228467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228467Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A228467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228467.Bytes);
public BigInteger this[int i]=>Value[i];

public static A228467Inst Instance=new A228467Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228468
{
public static readonly long[] Value={ 14353L,18572L,22876L,25212L,26799L,27803L,28752L,30510L,32011L,32423L,32515L,35137L,37055L,42840L,43058L,43167L,43211L,43288L,43315L,43830L,46713L,46766L,48281L,48319L,48471L,49118L,51415L,52047L,52086L,53022L,53092L,54940L,54979L,55065L,55269L,55769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228468Inst : IEnumerable<long>
{
public static readonly long[] Value=A228468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228468.Bytes);
public long this[int i]=>Value[i];

public static A228468Inst Instance=new A228468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228469
{
public static readonly long[] Value={ 2L,8L,13L,49L,80L,302L,493L,1861L,3038L,11468L,18721L,70669L,115364L,435482L,710905L,2683561L,4380794L,16536848L,26995669L,101904649L,166354808L,627964742L,1025124517L,3869693101L,6317101910L,23846123348L,38927735977L,146946433189L,239883517772L,905524722482L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228469Inst : IEnumerable<long>
{
public static readonly long[] Value=A228469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228469.Bytes);
public long this[int i]=>Value[i];

public static A228469Inst Instance=new A228469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228470
{
public static readonly long[] Value={ 3L,11L,18L,68L,111L,419L,684L,2582L,4215L,15911L,25974L,98048L,160059L,604199L,986328L,3723242L,6078027L,22943651L,37454490L,141385148L,230804967L,871254539L,1422284292L,5368912382L,8764510719L,33084728831L,54009348606L,203877285368L,332820602355L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228470Inst : IEnumerable<long>
{
public static readonly long[] Value=A228470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228470.Bytes);
public long this[int i]=>Value[i];

public static A228470Inst Instance=new A228470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228471
{
public static readonly long[] Value={ 3L,5L,19L,31L,117L,191L,721L,1177L,4443L,7253L,27379L,44695L,168717L,275423L,1039681L,1697233L,6406803L,10458821L,39480499L,64450159L,243289797L,397159775L,1499219281L,2447408809L,9238605483L,15081612629L,56930852179L,92937084583L,350823718557L,572704120127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228471Inst : IEnumerable<long>
{
public static readonly long[] Value=A228471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228471.Bytes);
public long this[int i]=>Value[i];

public static A228471Inst Instance=new A228471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228472
{
public static readonly long[] Value={ 5L,8L,30L,49L,185L,302L,1140L,1861L,7025L,11468L,43290L,70669L,266765L,435482L,1643880L,2683561L,10130045L,16536848L,62424150L,101904649L,384674945L,627964742L,2370473820L,3869693101L,14607517865L,23846123348L,90015581010L,146946433189L,554701003925L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228472Inst : IEnumerable<long>
{
public static readonly long[] Value=A228472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228472.Bytes);
public long this[int i]=>Value[i];

public static A228472Inst Instance=new A228472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228473
{
public static readonly long[] Value={ 155863L,207301L,260539L,289847L,309977L,322429L,334427L,356831L,376291L,381631L,382873L,416821L,441461L,517207L,519947L,521393L,521897L,522881L,523351L,530051L,568627L,569267L,588949L,589507L,591709L,600289L,631139L,639631L,640121L,652667L,653651L,678553L,678971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228473Inst : IEnumerable<long>
{
public static readonly long[] Value=A228473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228473.Bytes);
public long this[int i]=>Value[i];

public static A228473Inst Instance=new A228473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228474
{
public static readonly long[] Value={ 0L,1L,4L,2L,24L,26L,3L,1725L,12L,14L,4L,26L,123L,125L,15L,5L,119L,781802L,20L,22L,132896L,6L,51L,29L,31L,1220793L,23L,25L,7L,429L,8869123L,532009L,532007L,532009L,532011L,26L,8L,94L,213355L,213353L,248L,33L,31L,33L,1000L,9L,144L,110L,112L,82L,84L,210L,60L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228474Inst : IEnumerable<long>
{
public static readonly long[] Value=A228474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228474.Bytes);
public long this[int i]=>Value[i];

public static A228474Inst Instance=new A228474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228475
{
public static readonly long[] Value={ 5L,1L,6L,5L,8L,7L,7L,2L,2L,1L,5L,4L,0L,5L,2L,6L,4L,7L,1L,2L,5L,3L,2L,9L,8L,8L,0L,7L,7L,4L,8L,5L,0L,5L,2L,4L,7L,8L,6L,3L,8L,5L,8L,8L,8L,8L,3L,4L,7L,7L,7L,5L,6L,9L,9L,3L,4L,9L,2L,7L,5L,8L,3L,1L,4L,9L,6L,6L,2L,6L,7L,5L,5L,1L,9L,2L,9L,4L,5L,0L,4L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228475Inst : IEnumerable<long>
{
public static readonly long[] Value=A228475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228475.Bytes);
public long this[int i]=>Value[i];

public static A228475Inst Instance=new A228475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228476
{
public static readonly BigInteger[] Value={ 1L,2L,14L,172L,4354L,211588L,20185842L,3737615288L,1349721589622L,948593164919044L,1298594593323021084L,BigInteger.Parse("3461591189556243601228"),BigInteger.Parse("17969903126848842785918376"),BigInteger.Parse("181660279488635404176787338286") };
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
public class A228476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228476Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A228476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228476.Bytes);
public BigInteger this[int i]=>Value[i];

public static A228476Inst Instance=new A228476Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228477
{
public static readonly long[] Value={ 2L,4L,14L,41L,127L,386L,1181L,3605L,11013L,33635L,102734L,313780L,958385L,2927208L,8940618L,27307464L,83405606L,254747013L,778077691L,2376494562L,7258563605L,22169941573L,67713990833L,206819875427L,631693101322L,1929389878184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228477Inst : IEnumerable<long>
{
public static readonly long[] Value=A228477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228477.Bytes);
public long this[int i]=>Value[i];

public static A228477Inst Instance=new A228477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228478
{
public static readonly long[] Value={ 3L,9L,41L,172L,728L,3084L,13050L,55252L,233875L,990055L,4191028L,17741339L,75101906L,317918500L,1345800258L,5696989354L,24116274286L,102088075950L,432155280235L,1829382955772L,7744072911728L,32781908823977L,138771103836595L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228478Inst : IEnumerable<long>
{
public static readonly long[] Value=A228478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228478.Bytes);
public long this[int i]=>Value[i];

public static A228478Inst Instance=new A228478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228479
{
public static readonly long[] Value={ 5L,19L,127L,728L,4354L,25699L,152373L,902042L,5342712L,31639786L,187379548L,1109702480L,6571916787L,38920392611L,230495519461L,1365047364511L,8084124028133L,47876038862427L,283532896714060L,1679146925634733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228479Inst : IEnumerable<long>
{
public static readonly long[] Value=A228479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228479.Bytes);
public long this[int i]=>Value[i];

public static A228479Inst Instance=new A228479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228496
{
public static readonly long[] Value={ 8L,4L,1L,0L,6L,8L,6L,7L,0L,5L,6L,7L,9L,3L,0L,2L,5L,5L,7L,7L,6L,5L,2L,5L,0L,3L,1L,8L,2L,6L,4L,3L,0L,7L,4L,6L,7L,0L,2L,0L,7L,8L,7L,8L,5L,6L,3L,9L,8L,3L,9L,2L,1L,9L,7L,7L,8L,5L,2L,2L,8L,0L,4L,6L,9L,2L,0L,8L,9L,3L,0L,3L,4L,7L,6L,3L,3L,7L,3L,6L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228496Inst : IEnumerable<long>
{
public static readonly long[] Value=A228496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228496.Bytes);
public long this[int i]=>Value[i];

public static A228496Inst Instance=new A228496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228497
{
public static readonly long[] Value={ 8L,4L,0L,8L,9L,6L,4L,1L,5L,2L,5L,3L,7L,1L,4L,5L,4L,3L,0L,3L,1L,1L,2L,5L,4L,7L,6L,2L,3L,3L,2L,1L,4L,8L,9L,5L,0L,4L,0L,0L,3L,4L,2L,6L,2L,3L,5L,6L,7L,8L,4L,5L,1L,0L,8L,1L,3L,2L,2L,6L,0L,8L,5L,9L,7L,4L,9L,2L,4L,7L,5L,4L,9L,5L,3L,9L,0L,2L,2L,3L,9L,8L,1L,4L,3L,2L,4L,0L,0L,4L,1L,9L,9L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228497Inst : IEnumerable<long>
{
public static readonly long[] Value=A228497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228497.Bytes);
public long this[int i]=>Value[i];

public static A228497Inst Instance=new A228497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228498
{
public static readonly long[] Value={ 0L,1L,1L,7L,1L,31L,1L,31L,13L,57L,1L,163L,1L,91L,73L,127L,1L,307L,1L,321L,111L,183L,1L,691L,31L,241L,121L,535L,1L,1261L,1L,511L,211L,381L,157L,1591L,1L,463L,273L,1377L,1L,2163L,1L,1131L,781L,651L,1L,2803L,57L,1467L,421L,1513L,1L,2791L,273L,2311L,507L,993L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228498Inst : IEnumerable<long>
{
public static readonly long[] Value=A228498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228498.Bytes);
public long this[int i]=>Value[i];

public static A228498Inst Instance=new A228498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228499
{
public static readonly long[] Value={ 6L,7L,9L,12L,13L,15L,17L,19L,20L,22L,26L,28L,30L,31L,33L,34L,35L,37L,42L,43L,48L,49L,50L,51L,53L,56L,58L,61L,62L,63L,65L,67L,68L,69L,70L,71L,72L,75L,78L,79L,84L,85L,86L,87L,89L,90L,91L,92L,94L,96L,97L,98L,103L,104L,105L,106L,107L,110L,114L,115L,117L,120L,123L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228499Inst : IEnumerable<long>
{
public static readonly long[] Value=A228499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228499.Bytes);
public long this[int i]=>Value[i];

public static A228499Inst Instance=new A228499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228500
{
public static readonly BigInteger[] Value={ 1L,1L,12L,87L,2002L,59839L,3862849L,405580157L,81304395949L,28446567810005L,18268841726936268L,BigInteger.Parse("20937720031330292269"),BigInteger.Parse("43502129718103134992611"),BigInteger.Parse("162426195975365708781849519"),BigInteger.Parse("1095156092719874995442597502324") };
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
public class A228500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228500Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A228500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228500.Bytes);
public BigInteger this[int i]=>Value[i];

public static A228500Inst Instance=new A228500Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228501
{
public static readonly long[] Value={ 2L,3L,12L,29L,88L,239L,684L,1909L,5392L,15143L,42644L,119933L,337512L,949535L,2671740L,7517061L,21150272L,59508247L,167433188L,471090573L,1325464216L,3729333775L,10492879052L,29522830997L,83065631600L,233713998087L,657579228980L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228501Inst : IEnumerable<long>
{
public static readonly long[] Value=A228501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228501.Bytes);
public long this[int i]=>Value[i];

public static A228501Inst Instance=new A228501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228502
{
public static readonly long[] Value={ 3L,5L,29L,87L,358L,1252L,4749L,17285L,64235L,236211L,873250L,3219652L,11886927L,43856285L,161862005L,597285195L,2204231074L,8134165648L,30017792409L,110774426621L,408792375587L,1508567655759L,5567079710158L,20544224979592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228502Inst : IEnumerable<long>
{
public static readonly long[] Value=A228502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228502.Bytes);
public long this[int i]=>Value[i];

public static A228502Inst Instance=new A228502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228503
{
public static readonly long[] Value={ 5L,11L,88L,358L,2002L,9528L,49101L,243118L,1228036L,6141239L,30865981L,154742849L,776765183L,3896668986L,19553995645L,98108834263L,492283814664L,2470048647138L,12393793010466L,62186850336292L,312029099308093L,1565635002686314L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228503Inst : IEnumerable<long>
{
public static readonly long[] Value=A228503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228503.Bytes);
public long this[int i]=>Value[i];

public static A228503Inst Instance=new A228503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228504
{
public static readonly long[] Value={ 8L,21L,239L,1252L,9528L,59839L,413786L,2724191L,18387032L,122539084L,821945828L,5495164996L,36800032261L,246231184011L,1648269251345L,11031030456148L,73833534042745L,494158034052549L,3307432804186754L,22136531409536410L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228504Inst : IEnumerable<long>
{
public static readonly long[] Value=A228504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228504.Bytes);
public long this[int i]=>Value[i];

public static A228504Inst Instance=new A228504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228505
{
public static readonly long[] Value={ 13L,43L,684L,4749L,49101L,413786L,3862849L,34229311L,311423874L,2795565191L,25267110999L,227577191098L,2053397764249L,18510745379063L,166945846438154L,1505305762277273L,13574575402532525L,122405516285033798L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228505Inst : IEnumerable<long>
{
public static readonly long[] Value=A228505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228505.Bytes);
public long this[int i]=>Value[i];

public static A228505Inst Instance=new A228505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228506
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,3L,3L,3L,3L,5L,5L,12L,5L,5L,8L,11L,29L,29L,11L,8L,13L,21L,88L,87L,88L,21L,13L,21L,43L,239L,358L,358L,239L,43L,21L,34L,85L,684L,1252L,2002L,1252L,684L,85L,34L,55L,171L,1909L,4749L,9528L,9528L,4749L,1909L,171L,55L,89L,341L,5392L,17285L,49101L,59839L,49101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228506Inst : IEnumerable<long>
{
public static readonly long[] Value=A228506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228506.Bytes);
public long this[int i]=>Value[i];

public static A228506Inst Instance=new A228506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228507
{
public static readonly long[] Value={ 1L,2L,145L,180L,691L,4123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A228507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228507Inst : IEnumerable<long>
{
public static readonly long[] Value=A228507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A228507.Bytes);
public long this[int i]=>Value[i];

public static A228507Inst Instance=new A228507Inst();

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