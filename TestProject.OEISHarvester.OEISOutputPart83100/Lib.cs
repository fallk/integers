using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A102741
{
public static readonly long[] Value={ 81L,405L,1215L,2835L,5670L,10206L,17010L,26730L,40095L,57915L,81081L,110565L,147420L,192780L,247860L,313956L,392445L,484785L,592515L,717255L,860706L,1024650L,1210950L,1421550L,1658475L,1923831L,2219805L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102741Inst : IEnumerable<long>
{
public static readonly long[] Value=A102741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102741.Bytes);
public long this[int i]=>Value[i];

public static A102741Inst Instance=new A102741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102742
{
public static readonly long[] Value={ 3L,5L,7L,41L,15361L,23041L,26881L,61441L,87041L,163841L,544001L,604801L,6684673L,14172161L,159318017L,446960641L,1151139841L,3208642561L,38126223361L,108905103361L,171727482881L,318093312001L,443069456129L,912680550401L,1295536619521L,1825696645121L,2061584302081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102742Inst : IEnumerable<long>
{
public static readonly long[] Value=A102742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102742.Bytes);
public long this[int i]=>Value[i];

public static A102742Inst Instance=new A102742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102743
{
public static readonly BigInteger[] Value={ 1L,2L,7L,37L,273L,2661L,32773L,491555L,8715409L,178438681L,4142334501L,107483043735L,3081956918857L,96759352320437L,3300826000845493L,121569984050610331L,4807542796319581089L,BigInteger.Parse("203167758634027130289") };
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
public class A102743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102743Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A102743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102743.Bytes);
public BigInteger this[int i]=>Value[i];

public static A102743Inst Instance=new A102743Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102744
{
public static readonly long[] Value={ 3L,12L,37L,57L,60L,70L,75L,85L,89L,92L,131L,147L,161L,166L,177L,181L,182L,194L,200L,211L,224L,228L,233L,242L,244L,255L,259L,260L,265L,269L,271L,281L,285L,293L,294L,321L,325L,329L,336L,343L,364L,367L,394L,402L,415L,425L,435L,445L,464L,465L,484L,499L,522L,531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102744Inst : IEnumerable<long>
{
public static readonly long[] Value=A102744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102744.Bytes);
public long this[int i]=>Value[i];

public static A102744Inst Instance=new A102744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102745
{
public static readonly long[] Value={ 1L,3L,4L,3L,4L,3L,3L,2L,3L,2L,3L,3L,3L,4L,4L,3L,3L,4L,1L,2L,4L,3L,1L,3L,4L,3L,4L,4L,3L,2L,5L,2L,3L,1L,1L,2L,2L,2L,2L,2L,3L,5L,3L,2L,4L,4L,2L,3L,5L,4L,3L,4L,3L,5L,3L,3L,3L,2L,4L,2L,4L,3L,3L,3L,4L,4L,2L,3L,2L,3L,2L,3L,2L,4L,3L,1L,2L,4L,3L,3L,3L,4L,4L,2L,4L,3L,4L,5L,4L,4L,2L,4L,5L,4L,3L,1L,3L,3L,4L,3L,4L,1L,2L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102745Inst : IEnumerable<long>
{
public static readonly long[] Value=A102745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102745.Bytes);
public long this[int i]=>Value[i];

public static A102745Inst Instance=new A102745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102746
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,3L,2L,3L,3L,3L,5L,4L,3L,4L,3L,4L,4L,4L,2L,2L,3L,4L,3L,4L,4L,5L,2L,5L,3L,6L,5L,5L,7L,7L,7L,4L,4L,6L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102746Inst : IEnumerable<long>
{
public static readonly long[] Value=A102746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102746.Bytes);
public long this[int i]=>Value[i];

public static A102746Inst Instance=new A102746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102747
{
public static readonly long[] Value={ 2L,7L,103L,229561L,863833L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102747Inst : IEnumerable<long>
{
public static readonly long[] Value=A102747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102747.Bytes);
public long this[int i]=>Value[i];

public static A102747Inst Instance=new A102747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102748
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,4554L,1L,1L,0L,1L,2L,0L,0L,2L,0L,2L,2L,3L,6L,1L,12L,21L,14L,4L,5L,74L,0L,3L,2L,5L,12L,7L,2L,1L,5L,16L,3L,1870L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102748Inst : IEnumerable<long>
{
public static readonly long[] Value=A102748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102748.Bytes);
public long this[int i]=>Value[i];

public static A102748Inst Instance=new A102748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102749
{
public static readonly long[] Value={ 12L,24L,40L,45L,48L,56L,63L,80L,90L,96L,112L,120L,126L,135L,144L,160L,168L,175L,176L,180L,189L,192L,208L,224L,240L,252L,270L,275L,280L,288L,297L,315L,320L,325L,336L,350L,351L,352L,360L,378L,384L,405L,416L,425L,448L,459L,475L,480L,504L,513L,525L,528L,539L,540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102749Inst : IEnumerable<long>
{
public static readonly long[] Value=A102749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102749.Bytes);
public long this[int i]=>Value[i];

public static A102749Inst Instance=new A102749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102750
{
public static readonly long[] Value={ 2L,3L,5L,6L,7L,10L,11L,12L,13L,14L,15L,17L,19L,20L,21L,22L,23L,24L,26L,28L,29L,30L,31L,33L,34L,35L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,51L,52L,53L,55L,56L,57L,58L,59L,60L,61L,62L,63L,65L,66L,67L,68L,69L,70L,71L,73L,74L,76L,77L,78L,79L,80L,82L,83L,84L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102750Inst : IEnumerable<long>
{
public static readonly long[] Value=A102750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102750.Bytes);
public long this[int i]=>Value[i];

public static A102750Inst Instance=new A102750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102751
{
public static readonly long[] Value={ 3L,5L,11L,15L,25L,85L,95L,121L,131L,171L,181L,205L,231L,261L,271L,315L,441L,445L,471L,545L,571L,595L,715L,751L,781L,861L,921L,951L,1011L,1055L,1081L,1095L,1125L,1151L,1185L,1315L,1411L,1421L,1495L,1615L,1661L,1701L,2035L,2051L,2055L,2065L,2175L,2261L,2315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102751Inst : IEnumerable<long>
{
public static readonly long[] Value=A102751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102751.Bytes);
public long this[int i]=>Value[i];

public static A102751Inst Instance=new A102751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102752
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,0L,1L,3L,3L,0L,1L,5L,9L,5L,0L,1L,7L,21L,27L,11L,0L,1L,9L,39L,85L,81L,21L,0L,1L,11L,63L,203L,341L,243L,43L,0L,1L,13L,93L,405L,1031L,1365L,729L,85L,0L,1L,15L,129L,715L,2511L,5187L,5461L,2187L,171L,0L,1L,17L,171L,1157L,5261L,15309L,25999L,21845L,6561L,341L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102752Inst : IEnumerable<long>
{
public static readonly long[] Value=A102752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102752.Bytes);
public long this[int i]=>Value[i];

public static A102752Inst Instance=new A102752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102753
{
public static readonly long[] Value={ 4L,9L,3L,4L,8L,0L,2L,2L,0L,0L,5L,4L,4L,6L,7L,9L,3L,0L,9L,4L,1L,7L,2L,4L,5L,4L,9L,9L,9L,3L,8L,0L,7L,5L,5L,6L,7L,6L,5L,6L,8L,4L,9L,7L,0L,3L,6L,2L,0L,3L,9L,5L,3L,1L,3L,2L,0L,6L,6L,7L,4L,6L,8L,8L,1L,1L,0L,0L,2L,2L,4L,1L,1L,2L,0L,9L,6L,0L,2L,6L,2L,1L,5L,0L,0L,8L,8L,6L,7L,0L,1L,8L,5L,9L,2L,7L,6L,1L,1L,5L,9L,1L,2L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102753Inst : IEnumerable<long>
{
public static readonly long[] Value=A102753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102753.Bytes);
public long this[int i]=>Value[i];

public static A102753Inst Instance=new A102753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102754
{
public static readonly long[] Value={ 9L,3L,4L,8L,0L,2L,2L,0L,0L,5L,4L,4L,6L,7L,9L,3L,0L,9L,4L,1L,7L,2L,4L,5L,4L,9L,9L,9L,3L,8L,0L,7L,5L,5L,6L,7L,6L,5L,6L,8L,4L,9L,7L,0L,3L,6L,2L,0L,3L,9L,5L,3L,1L,3L,2L,0L,6L,6L,7L,4L,6L,8L,8L,1L,1L,0L,0L,2L,2L,4L,1L,1L,2L,0L,9L,6L,0L,2L,6L,2L,1L,5L,0L,0L,8L,8L,6L,7L,0L,1L,8L,5L,9L,2L,7L,6L,1L,1L,5L,9L,1L,2L,0L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102754Inst : IEnumerable<long>
{
public static readonly long[] Value=A102754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102754.Bytes);
public long this[int i]=>Value[i];

public static A102754Inst Instance=new A102754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102755
{
public static readonly long[] Value={ 1L,1L,1L,4L,10L,37L,135L,522L,2060L,8430L,35115L,149286L,644456L,2821835L,12503878L,56001856L,253174451L,1154179790L,5301178673L,24513058220L,114042743290L,533510321377L,2508491383101L,11849321038092L,56211286929146L,267707017974770L,1279602152054934L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102755Inst : IEnumerable<long>
{
public static readonly long[] Value=A102755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102755.Bytes);
public long this[int i]=>Value[i];

public static A102755Inst Instance=new A102755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102756
{
public static readonly long[] Value={ 1L,2L,1L,3L,4L,2L,4L,10L,10L,3L,5L,20L,31L,20L,5L,6L,35L,76L,78L,40L,8L,7L,56L,161L,232L,184L,76L,13L,8L,84L,308L,582L,636L,406L,142L,21L,9L,120L,546L,1296L,1831L,1604L,861L,260L,34L,10L,165L,912L,2640L,4630L,5215L,3820L,1766L,470L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102756Inst : IEnumerable<long>
{
public static readonly long[] Value=A102756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102756.Bytes);
public long this[int i]=>Value[i];

public static A102756Inst Instance=new A102756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102757
{
public static readonly BigInteger[] Value={ 1L,4L,31L,352L,5233L,95836L,2080999L,52189096L,1482977857L,47053929268L,1648037039791L,63125834205424L,2624096058047281L,117620219281363852L,5653607876781921463L,BigInteger.Parse("290035426344483253816"),BigInteger.Parse("15814774125898034896129") };
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
public class A102757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102757Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A102757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102757.Bytes);
public BigInteger this[int i]=>Value[i];

public static A102757Inst Instance=new A102757Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102758
{
public static readonly long[] Value={ 8L,10L,11L,22L,37L,59L,64L,71L,77L,82L,85L,89L,94L,98L,103L,109L,116L,119L,130L,134L,142L,145L,151L,154L,158L,166L,173L,178L,184L,215L,229L,236L,247L,250L,253L,259L,275L,298L,299L,301L,310L,316L,317L,323L,346L,347L,364L,380L,385L,389L,401L,406L,422L,425L,449L,460L,464L,467L,470L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102758Inst : IEnumerable<long>
{
public static readonly long[] Value=A102758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102758.Bytes);
public long this[int i]=>Value[i];

public static A102758Inst Instance=new A102758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102759
{
public static readonly long[] Value={ 1L,1L,1L,2L,8L,27L,82L,338L,1647L,7668L,37779L,210520L,1276662L,7985200L,51302500L,358798144L,2677814900L,20309850311L,160547934756L,1344197852830L,11666610870142L,104156661915427L,962681713955130L,9238216839975106L,91508384728188792L,930538977116673878L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102759Inst : IEnumerable<long>
{
public static readonly long[] Value=A102759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102759.Bytes);
public long this[int i]=>Value[i];

public static A102759Inst Instance=new A102759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102760
{
public static readonly BigInteger[] Value={ 1L,1L,1L,7L,37L,241L,1381L,13231L,140617L,1483777L,16211881L,217551511L,3384215341L,50221272817L,782154787597L,13913712591871L,272739557719441L,5282625708305281L,106588332600443857L,2354480141600267047L,BigInteger.Parse("56238135934525073461"),BigInteger.Parse("1338131691952924913521") };
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
public class A102760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102760Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A102760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102760.Bytes);
public BigInteger this[int i]=>Value[i];

public static A102760Inst Instance=new A102760Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102761
{
public static readonly long[] Value={ 1L,-1L,0L,1L,2L,13L,80L,579L,4738L,43387L,439792L,4890741L,59216642L,775596313L,10927434464L,164806435783L,2649391469058L,45226435601207L,817056406224416L,15574618910994665L,312400218671253762L,6577618644576902053L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102761Inst : IEnumerable<long>
{
public static readonly long[] Value=A102761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102761.Bytes);
public long this[int i]=>Value[i];

public static A102761Inst Instance=new A102761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102762
{
public static readonly long[] Value={ -1L,2L,2L,3L,6L,11L,18L,27L,38L,51L,66L,83L,102L,123L,146L,171L,198L,227L,258L,291L,326L,363L,402L,443L,486L,531L,578L,627L,678L,731L,786L,843L,902L,963L,1026L,1091L,1158L,1227L,1298L,1371L,1446L,1523L,1602L,1683L,1766L,1851L,1938L,2027L,2118L,2211L,2306L,2403L,2502L,2603L,2706L,2811L,2918L,3027L,3138L,3251L,3366L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102762Inst : IEnumerable<long>
{
public static readonly long[] Value=A102762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102762.Bytes);
public long this[int i]=>Value[i];

public static A102762Inst Instance=new A102762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102763
{
public static readonly long[] Value={ 2L,2L,4L,2L,4L,4L,4L,2L,6L,4L,4L,4L,4L,4L,6L,6L,6L,4L,6L,4L,4L,4L,4L,4L,8L,6L,6L,6L,6L,6L,6L,4L,6L,6L,6L,4L,6L,4L,8L,4L,8L,4L,8L,8L,8L,6L,6L,6L,8L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,4L,6L,6L,10L,8L,8L,4L,8L,8L,8L,4L,8L,8L,8L,8L,8L,6L,8L,6L,6L,6L,6L,8L,8L,6L,8L,6L,8L,6L,6L,6L,6L,6L,8L,6L,6L,6L,10L,6L,6L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102763Inst : IEnumerable<long>
{
public static readonly long[] Value=A102763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102763.Bytes);
public long this[int i]=>Value[i];

public static A102763Inst Instance=new A102763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102764
{
public static readonly long[] Value={ 13L,19L,30L,34L,43L,52L,54L,57L,58L,64L,69L,78L,82L,94L,96L,124L,145L,148L,157L,165L,177L,178L,187L,192L,195L,201L,202L,243L,246L,250L,256L,264L,277L,291L,303L,307L,313L,319L,324L,325L,340L,342L,352L,355L,382L,393L,397L,402L,409L,429L,430L,432L,444L,456L,468L,474L,486L,493L,499L,517L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102764Inst : IEnumerable<long>
{
public static readonly long[] Value=A102764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102764.Bytes);
public long this[int i]=>Value[i];

public static A102764Inst Instance=new A102764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102765
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,3L,0L,1L,5L,13L,0L,1L,7L,25L,51L,0L,1L,9L,43L,125L,205L,0L,1L,11L,67L,259L,625L,819L,0L,1L,13L,97L,477L,1555L,3125L,3277L,0L,1L,15L,133L,803L,3355L,9331L,15625L,13107L,0L,1L,17L,175L,1261L,6505L,23517L,55987L,78125L,52429L,0L,1L,19L,223L,1875L,11605L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102765Inst : IEnumerable<long>
{
public static readonly long[] Value=A102765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102765.Bytes);
public long this[int i]=>Value[i];

public static A102765Inst Instance=new A102765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102766
{
public static readonly long[] Value={ 1L,81L,100L,2025L,3025L,9801L,10000L,88209L,494209L,998001L,1000000L,4941729L,7441984L,23804641L,24502500L,25502500L,28005264L,52881984L,60481729L,99980001L,100000000L,300814336L,493817284L,1518037444L,6049417284L,6832014336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102766Inst : IEnumerable<long>
{
public static readonly long[] Value=A102766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102766.Bytes);
public long this[int i]=>Value[i];

public static A102766Inst Instance=new A102766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102767
{
public static readonly long[] Value={ 2L,4L,3L,5L,7L,4L,3L,5L,13L,3L,5L,6L,6L,7L,10L,6L,7L,12L,5L,3L,12L,8L,6L,14L,6L,7L,5L,3L,8L,19L,16L,5L,4L,14L,7L,9L,7L,8L,13L,7L,7L,18L,7L,5L,3L,19L,18L,9L,7L,5L,13L,3L,11L,12L,13L,8L,6L,12L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102767Inst : IEnumerable<long>
{
public static readonly long[] Value=A102767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102767.Bytes);
public long this[int i]=>Value[i];

public static A102767Inst Instance=new A102767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102768
{
public static readonly long[] Value={ 0L,4L,6L,10L,16L,24L,30L,36L,42L,46L,64L,70L,72L,76L,90L,100L,102L,114L,126L,130L,144L,150L,160L,172L,174L,184L,186L,196L,202L,204L,214L,226L,232L,234L,240L,244L,246L,252L,262L,270L,276L,280L,300L,312L,322L,342L,360L,366L,370L,402L,406L,414L,430L,436L,442L,444L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102768Inst : IEnumerable<long>
{
public static readonly long[] Value=A102768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102768.Bytes);
public long this[int i]=>Value[i];

public static A102768Inst Instance=new A102768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102769
{
public static readonly long[] Value={ 7L,6L,6L,3L,1L,1L,8L,9L,6L,0L,6L,2L,4L,6L,3L,1L,9L,6L,8L,7L,1L,6L,0L,5L,3L,9L,2L,0L,2L,7L,9L,7L,3L,3L,4L,1L,2L,0L,2L,1L,0L,8L,2L,1L,2L,9L,3L,2L,0L,1L,7L,0L,0L,1L,7L,4L,7L,4L,0L,7L,0L,1L,7L,9L,4L,6L,8L,4L,1L,1L,6L,1L,9L,8L,6L,6L,1L,5L,8L,5L,7L,3L,9L,7L,5L,2L,2L,5L,2L,1L,4L,6L,6L,2L,8L,6L,8L,9L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102769Inst : IEnumerable<long>
{
public static readonly long[] Value=A102769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102769.Bytes);
public long this[int i]=>Value[i];

public static A102769Inst Instance=new A102769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102770
{
public static readonly long[] Value={ 7L,17L,38L,71L,110L,161L,218L,333L,449L,573L,758L,881L,1010L,1245L,1563L,1799L,2043L,2378L,2591L,2883L,3278L,3693L,4316L,4898L,5201L,5510L,5831L,6158L,7175L,8318L,8973L,9521L,10355L,11249L,11853L,12795L,13610L,14445L,15483L,16199L,17285L,18431L,19010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102770Inst : IEnumerable<long>
{
public static readonly long[] Value=A102770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102770.Bytes);
public long this[int i]=>Value[i];

public static A102770Inst Instance=new A102770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102771
{
public static readonly long[] Value={ 1L,7L,2L,0L,4L,7L,7L,4L,0L,0L,5L,8L,8L,9L,6L,6L,9L,2L,2L,7L,5L,9L,0L,1L,1L,9L,7L,7L,3L,8L,8L,6L,0L,9L,5L,9L,9L,4L,0L,7L,3L,7L,4L,1L,7L,0L,0L,1L,0L,1L,9L,8L,3L,2L,9L,2L,0L,7L,0L,9L,4L,7L,0L,7L,0L,2L,3L,8L,6L,8L,9L,9L,2L,2L,0L,8L,9L,6L,6L,2L,3L,1L,3L,3L,2L,4L,4L,1L,2L,4L,1L,3L,8L,7L,5L,8L,7L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102771Inst : IEnumerable<long>
{
public static readonly long[] Value=A102771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102771.Bytes);
public long this[int i]=>Value[i];

public static A102771Inst Instance=new A102771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102772
{
public static readonly long[] Value={ 1L,3L,5L,10L,22L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102772Inst : IEnumerable<long>
{
public static readonly long[] Value=A102772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102772.Bytes);
public long this[int i]=>Value[i];

public static A102772Inst Instance=new A102772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102773
{
public static readonly BigInteger[] Value={ 1L,5L,49L,709L,13505L,318181L,8916145L,289283429L,10656031489L,439039941445L,19995858681521L,997184081617285L,54026137182982849L,3159127731435043109L,BigInteger.Parse("198258247783634075185"),BigInteger.Parse("13289190424904891606821"),BigInteger.Parse("947419111092028780186625") };
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
public class A102773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102773Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A102773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102773.Bytes);
public BigInteger this[int i]=>Value[i];

public static A102773Inst Instance=new A102773Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102774
{
public static readonly long[] Value={ 1L,3L,1L,2L,1L,5L,10L,3L,1L,3L,7L,90L,561L,24L,1155L,70633L,5L,15L,55L,1L,14L,2L,5075L,7L,1L,5L,4823L,110754153315L,4L,1L,5L,10153L,14L,119L,2L,5L,3L,1386L,231L,106865L,571064L,102L,6816L,1221L,8L,39L,385L,14156395253L,3L,3L,2392L,15351L,2241050L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102774Inst : IEnumerable<long>
{
public static readonly long[] Value=A102774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102774.Bytes);
public long this[int i]=>Value[i];

public static A102774Inst Instance=new A102774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102775
{
public static readonly long[] Value={ 2L,10L,2L,3L,6L,-26L,77L,-11L,6L,10L,-22L,391L,6450L,-65L,-2109L,-3329130L,-464L,-1190L,595L,14L,-174L,15L,128050L,10L,-40L,-68L,-7458L,-34644001047040L,-33L,-20L,22L,-58656L,-99L,475L,-78L,-138L,-336L,35226L,-725L,-144690L,-1799160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102775Inst : IEnumerable<long>
{
public static readonly long[] Value=A102775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102775.Bytes);
public long this[int i]=>Value[i];

public static A102775Inst Instance=new A102775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102776
{
public static readonly long[] Value={ 4L,9L,14L,0L,17L,23L,24L,31L,33L,40L,36L,47L,44L,45L,49L,41L,46L,58L,55L,60L,70L,69L,67L,74L,76L,78L,97L,87L,99L,92L,100L,0L,95L,104L,89L,113L,106L,102L,112L,111L,118L,108L,123L,0L,116L,120L,131L,125L,129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102776Inst : IEnumerable<long>
{
public static readonly long[] Value=A102776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102776.Bytes);
public long this[int i]=>Value[i];

public static A102776Inst Instance=new A102776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102777
{
public static readonly long[] Value={ 3L,15L,6L,15L,14L,195L,165L,132L,21L,65L,385L,2210L,13889L,1640L,110770L,6685382L,720L,1974L,2002L,35L,1015L,85L,160602L,238L,104L,420L,930930L,42290521588224L,348L,95L,270L,957719L,1309L,7106L,247L,570L,592L,81473L,31350L,37646466L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102777Inst : IEnumerable<long>
{
public static readonly long[] Value=A102777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102777.Bytes);
public long this[int i]=>Value[i];

public static A102777Inst Instance=new A102777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102778
{
public static readonly long[] Value={ 1L,1L,-1L,-5L,1L,7L,-1L,-68L,1L,1L,-12L,228L,-1L,-15L,-770L,-1L,1L,2460L,-5166L,-1L,-135762627L,63L,-266L,5L,1L,-175L,27728847L,-1L,-19535516L,-15L,-3L,-11L,52L,-1L,-9762340L,-77L,-4L,-1812880L,1L,5L,-3L,-46129720L,9L,-3003037440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102778Inst : IEnumerable<long>
{
public static readonly long[] Value=A102778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102778.Bytes);
public long this[int i]=>Value[i];

public static A102778Inst Instance=new A102778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102779
{
public static readonly long[] Value={ 2L,3L,6L,12L,4L,33L,10L,105L,15L,5L,77L,364L,15L,136L,8151L,12L,6L,11859L,23715L,21L,2269245880L,209L,825L,18L,7L,288L,2085664428L,28L,196404156L,348L,68L,36L,700L,36L,264208596L,2331L,133L,2700432L,9L,19L,102L,177989847L,11L,5581682432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102779Inst : IEnumerable<long>
{
public static readonly long[] Value=A102779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102779.Bytes);
public long this[int i]=>Value[i];

public static A102779Inst Instance=new A102779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102780
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,7L,3L,8L,12L,13L,5L,10L,6L,19L,15L,24L,32L,25L,29L,26L,26L,39L,47L,36L,36L,45L,37L,50L,62L,59L,67L,64L,64L,65L,73L,82L,86L,87L,99L,108L,108L,101L,109L,122L,118L,131L,135L,140L,136L,153L,153L,166L,170L,175L,171L,192L,188L,197L,205L,218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102780Inst : IEnumerable<long>
{
public static readonly long[] Value=A102780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102780.Bytes);
public long this[int i]=>Value[i];

public static A102780Inst Instance=new A102780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102781
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,8L,9L,11L,14L,15L,18L,20L,21L,23L,26L,29L,30L,33L,35L,36L,39L,41L,44L,48L,50L,51L,53L,54L,56L,63L,65L,68L,69L,74L,75L,78L,81L,83L,86L,89L,90L,95L,96L,98L,99L,105L,111L,113L,114L,116L,119L,120L,125L,128L,131L,134L,135L,138L,140L,141L,146L,153L,155L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102781Inst : IEnumerable<long>
{
public static readonly long[] Value=A102781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102781.Bytes);
public long this[int i]=>Value[i];

public static A102781Inst Instance=new A102781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102782
{
public static readonly BigInteger[] Value={ 111L,1111L,11111L,1111111L,11111111111L,11111111111111111L,BigInteger.Parse("11111111111111111111111111111111111111111111111"),BigInteger.Parse("11111111111111111111111111111111111111111111111111111111111") };
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
public class A102782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102782Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A102782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102782.Bytes);
public BigInteger this[int i]=>Value[i];

public static A102782Inst Instance=new A102782Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102783
{
public static readonly long[] Value={ 1L,6L,10L,22L,26L,28L,34L,38L,42L,54L,58L,60L,65L,66L,74L,75L,82L,84L,86L,106L,114L,118L,120L,122L,130L,134L,135L,140L,145L,147L,150L,156L,166L,168L,175L,185L,186L,190L,194L,198L,202L,204L,214L,216L,218L,222L,226L,228L,231L,250L,258L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102783Inst : IEnumerable<long>
{
public static readonly long[] Value=A102783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102783.Bytes);
public long this[int i]=>Value[i];

public static A102783Inst Instance=new A102783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102784
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,10L,41L,116L,335L,1111L,2619L,6067L,12788L,26692L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102784Inst : IEnumerable<long>
{
public static readonly long[] Value=A102784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102784.Bytes);
public long this[int i]=>Value[i];

public static A102784Inst Instance=new A102784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102785
{
public static readonly long[] Value={ 1L,1L,0L,1L,5L,8L,9L,17L,40L,73L,117L,208L,401L,737L,1296L,2321L,4261L,7768L,13977L,25201L,45752L,83033L,150165L,271520L,491809L,891073L,1613088L,2919457L,5285957L,9572264L,17330985L,31375313L,56805448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102785Inst : IEnumerable<long>
{
public static readonly long[] Value=A102785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102785.Bytes);
public long this[int i]=>Value[i];

public static A102785Inst Instance=new A102785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102786
{
public static readonly long[] Value={ 0L,2L,5L,1L,23L,2L,53L,3L,4L,149L,6L,6L,293L,7L,8L,9L,599L,11L,11L,863L,13L,13L,14L,16L,16L,1733L,17L,1943L,18L,21L,21L,22L,3173L,24L,3749L,26L,27L,27L,28L,29L,5399L,31L,6143L,32L,6533L,35L,37L,37L,8663L,38L,39L,9599L,41L,42L,43L,44L,12149L,46L,46L,13253L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102786Inst : IEnumerable<long>
{
public static readonly long[] Value=A102786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102786.Bytes);
public long this[int i]=>Value[i];

public static A102786Inst Instance=new A102786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102787
{
public static readonly long[] Value={ 0L,0L,0L,3L,2L,4L,7L,10L,14L,0L,29L,1L,50L,58L,67L,1L,1L,119L,2L,158L,172L,2L,218L,2L,3L,326L,346L,367L,388L,410L,4L,554L,4L,634L,4L,749L,5L,5L,907L,5L,5L,1079L,6L,1228L,1267L,1306L,7L,7L,1687L,1732L,1778L,7L,1919L,8L,8L,8L,8L,2429L,9L,2594L,2650L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102787Inst : IEnumerable<long>
{
public static readonly long[] Value=A102787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102787.Bytes);
public long this[int i]=>Value[i];

public static A102787Inst Instance=new A102787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102788
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,4L,11L,19L,35L,3L,4L,5L,7L,310L,394L,11L,14L,17L,19L,22L,1653L,27L,31L,35L,0L,46L,4805L,5300L,5720L,6275L,0L,79L,85L,90L,0L,107L,112L,121L,129L,137L,147L,154L,0L,175L,34581L,36029L,1L,1L,241L,55200L,57676L,265L,274L,1L,307L,321L,336L,347L,357L,370L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102788Inst : IEnumerable<long>
{
public static readonly long[] Value=A102788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102788.Bytes);
public long this[int i]=>Value[i];

public static A102788Inst Instance=new A102788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102789
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,6L,7L,19L,41L,5L,8L,14L,20L,28L,1327L,46L,1L,82L,104L,125L,150L,177L,207L,252L,3L,4L,436L,46741L,52523L,58764L,0L,7L,986L,1079L,8L,9L,1529L,11L,1850L,2038L,13L,2426L,14L,15L,3143L,625601L,0L,0L,21L,5018L,1169257L,5520L,5809L,26L,27L,29L,30L,8299L,8741L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102789Inst : IEnumerable<long>
{
public static readonly long[] Value=A102789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102789.Bytes);
public long this[int i]=>Value[i];

public static A102789Inst Instance=new A102789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102790
{
public static readonly long[] Value={ 3L,15L,35L,11L,143L,17L,323L,23L,29L,899L,37L,41L,1763L,47L,53L,59L,3599L,67L,71L,5183L,79L,83L,89L,97L,101L,10403L,107L,11663L,113L,127L,131L,137L,19043L,149L,22499L,157L,163L,167L,173L,179L,32399L,191L,36863L,197L,39203L,211L,223L,227L,51983L,233L,239L,57599L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102790Inst : IEnumerable<long>
{
public static readonly long[] Value=A102790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102790.Bytes);
public long this[int i]=>Value[i];

public static A102790Inst Instance=new A102790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102791
{
public static readonly long[] Value={ 15L,105L,77L,143L,221L,323L,437L,29L,899L,37L,1517L,1763L,2021L,53L,59L,3599L,67L,4757L,5183L,79L,6557L,89L,97L,9797L,10403L,11021L,11663L,12317L,127L,16637L,137L,19043L,149L,22499L,157L,163L,27221L,173L,179L,32399L,191L,36863L,38021L,39203L,211L,223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102791Inst : IEnumerable<long>
{
public static readonly long[] Value=A102791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102791.Bytes);
public long this[int i]=>Value[i];

public static A102791Inst Instance=new A102791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102792
{
public static readonly long[] Value={ 105L,385L,1001L,2431L,4199L,7429L,667L,899L,1147L,1517L,65231L,82861L,2491L,3127L,3599L,4087L,4757L,347261L,5767L,6557L,7387L,97L,9797L,1009091L,1113121L,1201289L,1317919L,127L,16637L,17947L,19043L,149L,22499L,23707L,25591L,27221L,28891L,30967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102792Inst : IEnumerable<long>
{
public static readonly long[] Value=A102792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102792.Bytes);
public long this[int i]=>Value[i];

public static A102792Inst Instance=new A102792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102793
{
public static readonly long[] Value={ 840L,1080L,2940L,3780L,4200L,4320L,5280L,5400L,5880L,6270L,6720L,7560L,8640L,8910L,9360L,10560L,12852L,13608L,14520L,15120L,16632L,17640L,18000L,18480L,20328L,21600L,22680L,23520L,24192L,25200L,26460L,28080L,29106L,29160L,30240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102793Inst : IEnumerable<long>
{
public static readonly long[] Value=A102793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102793.Bytes);
public long this[int i]=>Value[i];

public static A102793Inst Instance=new A102793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102794
{
public static readonly BigInteger[] Value={ 1L,36L,4356L,443556L,44435556L,4444355556L,444443555556L,44444435555556L,4444444355555556L,444444443555555556L,BigInteger.Parse("44444444435555555556"),BigInteger.Parse("4444444444355555555556"),BigInteger.Parse("444444444443555555555556"),BigInteger.Parse("44444444444435555555555556"),BigInteger.Parse("4444444444444355555555555556"),BigInteger.Parse("444444444444443555555555555556") };
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
public class A102794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102794Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A102794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102794.Bytes);
public BigInteger this[int i]=>Value[i];

public static A102794Inst Instance=new A102794Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102795
{
public static readonly long[] Value={ 2L,5L,8L,11L,14L,21L,24L,30L,36L,39L,40L,45L,55L,57L,60L,66L,70L,76L,85L,88L,91L,94L,104L,112L,119L,121L,124L,130L,140L,155L,166L,168L,169L,175L,176L,185L,200L,204L,221L,224L,230L,240L,249L,255L,276L,285L,287L,290L,296L,304L,306L,321L,330L,340L,342L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102795Inst : IEnumerable<long>
{
public static readonly long[] Value=A102795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102795.Bytes);
public long this[int i]=>Value[i];

public static A102795Inst Instance=new A102795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102796
{
public static readonly long[] Value={ 3L,6L,9L,12L,15L,18L,22L,25L,28L,31L,34L,37L,41L,43L,44L,46L,49L,50L,58L,59L,61L,64L,65L,67L,71L,74L,75L,77L,80L,86L,89L,90L,92L,95L,96L,98L,101L,105L,108L,111L,113L,114L,116L,122L,123L,125L,126L,128L,129L,131L,132L,134L,139L,141L,144L,147L,150L,154L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102796Inst : IEnumerable<long>
{
public static readonly long[] Value=A102796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102796.Bytes);
public long this[int i]=>Value[i];

public static A102796Inst Instance=new A102796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102797
{
public static readonly long[] Value={ 7L,13L,16L,19L,23L,26L,29L,32L,38L,42L,47L,48L,51L,53L,54L,62L,63L,68L,69L,72L,78L,79L,81L,87L,93L,97L,99L,100L,102L,106L,109L,110L,115L,117L,118L,127L,133L,135L,136L,138L,142L,143L,145L,146L,148L,149L,151L,152L,157L,158L,161L,163L,164L,171L,174L,181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102797Inst : IEnumerable<long>
{
public static readonly long[] Value=A102797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102797.Bytes);
public long this[int i]=>Value[i];

public static A102797Inst Instance=new A102797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102798
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,10L,11L,14L,20L,21L,24L,30L,35L,36L,39L,40L,45L,55L,56L,57L,60L,66L,70L,76L,84L,85L,88L,91L,94L,104L,112L,119L,120L,121L,124L,130L,140L,155L,165L,166L,168L,169L,175L,176L,185L,200L,204L,220L,221L,224L,230L,240L,249L,255L,276L,285L,286L,287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102798Inst : IEnumerable<long>
{
public static readonly long[] Value=A102798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102798.Bytes);
public long this[int i]=>Value[i];

public static A102798Inst Instance=new A102798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102799
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,9L,10L,11L,12L,14L,15L,18L,20L,21L,22L,24L,25L,28L,30L,31L,34L,35L,36L,37L,39L,40L,41L,43L,44L,45L,46L,49L,50L,55L,56L,57L,58L,59L,60L,61L,64L,65L,66L,67L,70L,71L,74L,75L,76L,77L,80L,84L,85L,86L,88L,89L,90L,91L,92L,94L,95L,96L,98L,101L,104L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102799Inst : IEnumerable<long>
{
public static readonly long[] Value=A102799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102799.Bytes);
public long this[int i]=>Value[i];

public static A102799Inst Instance=new A102799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102800
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,18L,19L,20L,21L,22L,23L,24L,25L,26L,28L,29L,30L,31L,32L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102800Inst : IEnumerable<long>
{
public static readonly long[] Value=A102800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102800.Bytes);
public long this[int i]=>Value[i];

public static A102800Inst Instance=new A102800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102801
{
public static readonly long[] Value={ 5L,11L,14L,21L,24L,30L,36L,39L,45L,55L,57L,60L,66L,76L,85L,88L,91L,94L,104L,119L,121L,124L,130L,140L,155L,166L,169L,175L,176L,185L,200L,204L,221L,224L,230L,240L,249L,255L,276L,285L,287L,290L,296L,304L,306L,321L,340L,342L,365L,368L,370L,374L,384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102801Inst : IEnumerable<long>
{
public static readonly long[] Value=A102801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102801.Bytes);
public long this[int i]=>Value[i];

public static A102801Inst Instance=new A102801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102802
{
public static readonly long[] Value={ 15L,25L,31L,34L,40L,46L,49L,59L,61L,65L,67L,70L,77L,80L,86L,89L,92L,95L,98L,101L,105L,108L,111L,114L,123L,125L,129L,131L,134L,139L,141L,144L,150L,156L,159L,160L,170L,177L,179L,180L,186L,189L,195L,196L,201L,205L,208L,210L,211L,214L,222L,225L,231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102802Inst : IEnumerable<long>
{
public static readonly long[] Value=A102802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102802.Bytes);
public long this[int i]=>Value[i];

public static A102802Inst Instance=new A102802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102803
{
public static readonly long[] Value={ 50L,69L,71L,81L,87L,90L,96L,99L,102L,109L,112L,115L,118L,133L,135L,143L,145L,149L,151L,154L,161L,164L,181L,187L,190L,197L,199L,206L,209L,212L,215L,218L,226L,228L,232L,235L,242L,243L,245L,251L,254L,257L,261L,263L,264L,266L,270L,273L,279L,281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102803Inst : IEnumerable<long>
{
public static readonly long[] Value=A102803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102803.Bytes);
public long this[int i]=>Value[i];

public static A102803Inst Instance=new A102803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102804
{
public static readonly long[] Value={ 106L,116L,122L,153L,171L,174L,191L,207L,216L,219L,229L,236L,238L,246L,252L,267L,271L,274L,283L,298L,319L,329L,336L,338L,355L,357L,367L,382L,383L,393L,401L,408L,414L,432L,433L,435L,437L,438L,447L,454L,467L,474L,477L,492L,499L,513L,518L,528L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102804Inst : IEnumerable<long>
{
public static readonly long[] Value=A102804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102804.Bytes);
public long this[int i]=>Value[i];

public static A102804Inst Instance=new A102804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102805
{
public static readonly long[] Value={ 126L,392L,402L,418L,439L,457L,464L,502L,538L,577L,587L,602L,612L,638L,657L,722L,793L,812L,822L,838L,863L,1007L,1062L,1198L,1408L,1423L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102805Inst : IEnumerable<long>
{
public static readonly long[] Value=A102805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102805.Bytes);
public long this[int i]=>Value[i];

public static A102805Inst Instance=new A102805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102806
{
public static readonly long[] Value={ 2L,3L,6L,7L,8L,9L,12L,13L,16L,17L,18L,19L,22L,23L,26L,27L,28L,29L,32L,33L,37L,38L,41L,42L,43L,44L,47L,48L,51L,52L,53L,54L,58L,62L,63L,64L,68L,72L,73L,74L,75L,78L,79L,82L,83L,93L,97L,100L,103L,107L,110L,113L,117L,127L,128L,132L,136L,137L,138L,142L,146L,147L,148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102806Inst : IEnumerable<long>
{
public static readonly long[] Value=A102806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102806.Bytes);
public long this[int i]=>Value[i];

public static A102806Inst Instance=new A102806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102807
{
public static readonly BigInteger[] Value={ 1L,16L,1156L,111556L,11115556L,1111155556L,111111555556L,11111115555556L,1111111155555556L,111111111555555556L,11111111115555555556UL,BigInteger.Parse("1111111111155555555556"),BigInteger.Parse("111111111111555555555556"),BigInteger.Parse("11111111111115555555555556"),BigInteger.Parse("1111111111111155555555555556"),BigInteger.Parse("111111111111111555555555555556") };
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
public class A102807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102807Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A102807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102807.Bytes);
public BigInteger this[int i]=>Value[i];

public static A102807Inst Instance=new A102807Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102808
{
public static readonly long[] Value={ 1L,2L,3L,7L,10L,11L,16L,17L,26L,59L,118L,178L,353L,411L,505L,535L,545L,702L,941L,8738L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102808Inst : IEnumerable<long>
{
public static readonly long[] Value=A102808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102808.Bytes);
public long this[int i]=>Value[i];

public static A102808Inst Instance=new A102808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102809
{
public static readonly long[] Value={ -6L,-12L,10L,105L,-20L,-154L,15L,4403L,-40L,-30L,364L,-4921L,21L,440L,24339L,33L,-42L,-101639L,272510L,28L,5003773320L,-2736L,19866L,-230L,-56L,25312L,-3712351475L,36L,1171388655L,740L,156L,1100L,-4277L,45L,551048889L,4554L,228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102809Inst : IEnumerable<long>
{
public static readonly long[] Value=A102809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102809.Bytes);
public long this[int i]=>Value[i];

public static A102809Inst Instance=new A102809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102810
{
public static readonly long[] Value={ 643266L,6127598L,9017291L,10371970L,10582732L,11357913L,13177036L,14860382L,30277278L,31675266L,41311665L,49626317L,50618743L,78805352L,86522154L,93614849L,106262424L,113388731L,117041604L,118113837L,140649556L,141178396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102810Inst : IEnumerable<long>
{
public static readonly long[] Value=A102810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102810.Bytes);
public long this[int i]=>Value[i];

public static A102810Inst Instance=new A102810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102811
{
public static readonly long[] Value={ 1L,3L,44L,62178L,643266L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102811Inst : IEnumerable<long>
{
public static readonly long[] Value=A102811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102811.Bytes);
public long this[int i]=>Value[i];

public static A102811Inst Instance=new A102811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102812
{
public static readonly long[] Value={ 1L,1L,2L,6L,25L,136L,927L,7690L,75913L,876026L,11649009L,176389234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102812Inst : IEnumerable<long>
{
public static readonly long[] Value=A102812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102812.Bytes);
public long this[int i]=>Value[i];

public static A102812Inst Instance=new A102812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102813
{
public static readonly long[] Value={ 17L,35L,36L,39L,42L,48L,50L,74L,80L,92L,95L,105L,120L,122L,128L,135L,141L,170L,171L,203L,206L,218L,239L,249L,255L,263L,276L,284L,287L,300L,311L,332L,333L,338L,351L,386L,398L,401L,414L,417L,419L,449L,450L,468L,483L,486L,498L,507L,512L,515L,524L,531L,534L,569L,575L,576L,581L,615L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102813Inst : IEnumerable<long>
{
public static readonly long[] Value=A102813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102813.Bytes);
public long this[int i]=>Value[i];

public static A102813Inst Instance=new A102813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102814
{
public static readonly long[] Value={ 1L,1L,2L,4L,11L,30L,103L,354L,1440L,5911L,27651L,131062L,690543L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102814Inst : IEnumerable<long>
{
public static readonly long[] Value=A102814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102814.Bytes);
public long this[int i]=>Value[i];

public static A102814Inst Instance=new A102814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102815
{
public static readonly long[] Value={ 11L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,90L,91L,92L,93L,94L,95L,96L,97L,98L,99L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102815Inst : IEnumerable<long>
{
public static readonly long[] Value=A102815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102815.Bytes);
public long this[int i]=>Value[i];

public static A102815Inst Instance=new A102815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102816
{
public static readonly long[] Value={ 14L,17L,31L,35L,40L,53L,58L,73L,77L,94L,95L,101L,109L,116L,142L,149L,164L,196L,218L,226L,227L,233L,236L,253L,256L,257L,266L,268L,281L,295L,302L,311L,340L,341L,355L,359L,374L,385L,415L,418L,421L,428L,442L,443L,466L,469L,491L,542L,563L,571L,583L,599L,604L,614L,632L,656L,665L,667L,668L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102816Inst : IEnumerable<long>
{
public static readonly long[] Value=A102816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102816.Bytes);
public long this[int i]=>Value[i];

public static A102816Inst Instance=new A102816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102817
{
public static readonly long[] Value={ 2L,1L,7L,9L,9L,9L,9L,7L,6L,4L,4L,9L,9L,9L,8L,8L,1L,4L,6L,8L,6L,2L,8L,8L,1L,3L,9L,5L,7L,7L,9L,3L,6L,0L,9L,8L,9L,0L,7L,2L,6L,7L,9L,7L,8L,9L,0L,9L,7L,3L,0L,0L,5L,6L,5L,4L,8L,3L,2L,8L,8L,5L,2L,1L,2L,2L,4L,0L,4L,2L,3L,7L,7L,2L,0L,9L,6L,4L,2L,6L,1L,4L,9L,8L,3L,9L,2L,3L,1L,1L,2L,6L,8L,1L,5L,0L,7L,1L,6L,5L,3L,3L,0L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102817Inst : IEnumerable<long>
{
public static readonly long[] Value=A102817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102817.Bytes);
public long this[int i]=>Value[i];

public static A102817Inst Instance=new A102817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102818
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,1L,3L,4L,4L,1L,3L,4L,4L,1L,3L,4L,4L,1L,3L,4L,4L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,5L,2L,3L,5L,1L,3L,5L,2L,3L,5L,1L,3L,5L,2L,1L,3L,3L,3L,7L,7L,3L,3L,7L,7L,3L,3L,7L,7L,3L,3L,1L,3L,1L,3L,1L,0L,4L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102818Inst : IEnumerable<long>
{
public static readonly long[] Value=A102818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102818.Bytes);
public long this[int i]=>Value[i];

public static A102818Inst Instance=new A102818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102819
{
public static readonly long[] Value={ 9L,9L,9L,9L,3L,3L,6L,7L,3L,1L,3L,3L,2L,0L,1L,6L,7L,4L,0L,2L,2L,4L,9L,5L,5L,3L,6L,8L,8L,2L,7L,8L,6L,4L,9L,5L,2L,6L,6L,5L,5L,8L,2L,5L,4L,4L,2L,5L,8L,8L,7L,9L,2L,1L,2L,8L,5L,7L,6L,8L,6L,6L,8L,0L,4L,7L,5L,1L,5L,1L,4L,6L,2L,0L,4L,1L,0L,5L,2L,4L,8L,6L,5L,4L,6L,0L,1L,9L,7L,5L,2L,7L,1L,6L,7L,5L,0L,2L,8L,4L,7L,0L,3L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102819Inst : IEnumerable<long>
{
public static readonly long[] Value=A102819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102819.Bytes);
public long this[int i]=>Value[i];

public static A102819Inst Instance=new A102819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102820
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,2L,1L,2L,2L,2L,3L,1L,1L,1L,3L,3L,0L,2L,2L,0L,3L,1L,2L,4L,2L,0L,1L,0L,1L,6L,1L,3L,1L,3L,0L,3L,1L,1L,1L,3L,1L,3L,1L,1L,1L,4L,4L,1L,1L,2L,1L,1L,3L,2L,2L,0L,1L,1L,1L,1L,3L,6L,2L,0L,1L,6L,1L,3L,0L,1L,1L,3L,2L,2L,1L,2L,1L,1L,2L,4L,1L,3L,1L,1L,2L,1L,2L,1L,0L,1L,4L,2L,1L,3L,0L,2L,5L,0L,5L,3L,3L,2L,1L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102820Inst : IEnumerable<long>
{
public static readonly long[] Value=A102820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102820.Bytes);
public long this[int i]=>Value[i];

public static A102820Inst Instance=new A102820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102821
{
public static readonly long[] Value={ 2L,4L,5L,8L,9L,13L,14L,15L,19L,20L,23L,27L,28L,30L,35L,36L,37L,38L,39L,46L,49L,56L,57L,67L,68L,69L,71L,81L,83L,86L,93L,94L,96L,98L,107L,108L,109L,111L,112L,113L,114L,124L,128L,138L,139L,142L,144L,155L,156L,157L,158L,159L,160L,161L,162L,173L,178L,182L,192L,195L,196L,199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102821Inst : IEnumerable<long>
{
public static readonly long[] Value=A102821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102821.Bytes);
public long this[int i]=>Value[i];

public static A102821Inst Instance=new A102821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102822
{
public static readonly long[] Value={ 3L,4L,5L,7L,9L,12L,16L,22L,31L,43L,60L,84L,118L,166L,234L,330L,466L,659L,931L,1316L,1861L,2631L,3720L,5260L,7438L,10518L,14874L,21035L,29747L,42068L,59493L,84135L,118984L,168268L,237966L,336534L,475930L,673066L,951859L,1346131L,1903716L,2692260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102822Inst : IEnumerable<long>
{
public static readonly long[] Value=A102822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102822.Bytes);
public long this[int i]=>Value[i];

public static A102822Inst Instance=new A102822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102823
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,13L,14L,15L,16L,17L,18L,19L,20L,23L,24L,25L,26L,27L,28L,29L,30L,34L,35L,36L,37L,38L,39L,40L,45L,46L,47L,48L,49L,50L,56L,57L,58L,59L,60L,67L,68L,69L,70L,78L,79L,80L,89L,90L,100L,102L,103L,104L,105L,106L,107L,108L,109L,112L,113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102823Inst : IEnumerable<long>
{
public static readonly long[] Value=A102823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102823.Bytes);
public long this[int i]=>Value[i];

public static A102823Inst Instance=new A102823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102824
{
public static readonly long[] Value={ 0L,1L,2L,4L,7L,8L,14L,16L,23L,26L,30L,32L,42L,48L,56L,62L,64L,75L,82L,89L,96L,101L,109L,116L,122L,126L,128L,142L,150L,158L,164L,174L,180L,188L,194L,204L,212L,220L,226L,234L,240L,248L,254L,256L,272L,286L,294L,304L,316L,324L,336L,345L,355L,364L,372L,380L,386L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102824Inst : IEnumerable<long>
{
public static readonly long[] Value=A102824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102824.Bytes);
public long this[int i]=>Value[i];

public static A102824Inst Instance=new A102824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102825
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,9L,11L,14L,17L,18L,24L,25L,27L,31L,38L,41L,42L,45L,50L,51L,54L,63L,68L,69L,72L,78L,81L,88L,94L,98L,104L,108L,110L,113L,116L,122L,125L,129L,132L,135L,143L,147L,150L,153L,159L,162L,174L,180L,188L,192L,198L,204L,207L,213L,216L,225L,231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102825Inst : IEnumerable<long>
{
public static readonly long[] Value=A102825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102825.Bytes);
public long this[int i]=>Value[i];

public static A102825Inst Instance=new A102825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102826
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,8L,11L,12L,16L,18L,19L,22L,23L,26L,27L,31L,32L,39L,40L,43L,44L,48L,55L,56L,60L,64L,69L,70L,74L,75L,79L,86L,87L,90L,91L,95L,96L,103L,104L,107L,108L,112L,119L,120L,124L,128L,138L,139L,143L,151L,152L,155L,156L,160L,163L,167L,171L,172L,176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102826Inst : IEnumerable<long>
{
public static readonly long[] Value=A102826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102826.Bytes);
public long this[int i]=>Value[i];

public static A102826Inst Instance=new A102826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102827
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,12L,13L,14L,15L,16L,17L,18L,19L,22L,23L,24L,25L,26L,27L,28L,29L,33L,34L,35L,36L,37L,38L,39L,44L,45L,46L,47L,48L,49L,55L,56L,57L,58L,59L,66L,67L,68L,69L,77L,78L,79L,88L,89L,99L,111L,112L,113L,114L,115L,116L,117L,118L,119L,122L,123L,124L,125L,126L,127L,128L,129L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102827Inst : IEnumerable<long>
{
public static readonly long[] Value=A102827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102827.Bytes);
public long this[int i]=>Value[i];

public static A102827Inst Instance=new A102827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102828
{
public static readonly long[] Value={ 1L,3L,7L,13L,19L,25L,31L,41L,47L,57L,65L,69L,75L,83L,91L,101L,109L,119L,131L,137L,143L,153L,161L,167L,177L,185L,195L,203L,213L,223L,237L,249L,261L,267L,275L,283L,293L,301L,311L,323L,331L,341L,351L,365L,377L,389L,397L,407L,419L,429L,441L,453L,463L,477L,491L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102828Inst : IEnumerable<long>
{
public static readonly long[] Value=A102828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102828.Bytes);
public long this[int i]=>Value[i];

public static A102828Inst Instance=new A102828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102829
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,13L,14L,17L,23L,29L,32L,35L,41L,44L,50L,56L,62L,67L,74L,76L,82L,88L,92L,95L,98L,104L,110L,113L,116L,122L,125L,131L,137L,143L,152L,161L,173L,179L,188L,193L,202L,206L,215L,223L,226L,232L,238L,244L,250L,256L,263L,269L,274L,278L,284L,287L,293L,299L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102829Inst : IEnumerable<long>
{
public static readonly long[] Value=A102829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102829.Bytes);
public long this[int i]=>Value[i];

public static A102829Inst Instance=new A102829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102830
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,10L,11L,15L,21L,22L,23L,26L,27L,31L,38L,39L,43L,47L,55L,62L,66L,70L,71L,74L,75L,79L,86L,87L,90L,91L,95L,102L,103L,107L,111L,119L,126L,130L,135L,139L,143L,151L,155L,159L,167L,171L,175L,183L,191L,203L,210L,214L,218L,223L,226L,234L,237L,241L,245L,250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102830Inst : IEnumerable<long>
{
public static readonly long[] Value=A102830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102830.Bytes);
public long this[int i]=>Value[i];

public static A102830Inst Instance=new A102830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102831
{
public static readonly long[] Value={ 2L,2L,2L,4L,8L,14L,25L,43L,78L,139L,246L,437L,779L,1384L,2461L,4376L,7783L,13840L,24612L,43765L,77828L,138400L,246114L,437658L,778280L,1383998L,2461136L,4376586L,7782795L,13839982L,24611356L,43765867L,77827942L,138399825L,246113559L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102831Inst : IEnumerable<long>
{
public static readonly long[] Value=A102831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102831.Bytes);
public long this[int i]=>Value[i];

public static A102831Inst Instance=new A102831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102832
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,3L,21L,78L,302L,1139L,4156L,14791L,52529L,183565L,635691L,2183533L,7314869L,25303217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102832Inst : IEnumerable<long>
{
public static readonly long[] Value=A102832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102832.Bytes);
public long this[int i]=>Value[i];

public static A102832Inst Instance=new A102832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102833
{
public static readonly long[] Value={ 113L,141L,316L,346L,359L,427L,443L,506L,537L,568L,659L,681L,730L,745L,873L,892L,899L,940L,997L,1016L,1025L,1090L,1149L,1157L,1171L,1213L,1304L,1305L,1342L,1367L,1373L,1478L,1522L,1639L,1646L,1737L,1753L,1772L,1811L,1841L,1897L,1907L,1954L,2024L,2143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102833Inst : IEnumerable<long>
{
public static readonly long[] Value=A102833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102833.Bytes);
public long this[int i]=>Value[i];

public static A102833Inst Instance=new A102833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102834
{
public static readonly long[] Value={ 8L,27L,32L,72L,108L,125L,128L,200L,216L,243L,288L,343L,392L,432L,500L,512L,648L,675L,800L,864L,968L,972L,1000L,1125L,1152L,1323L,1331L,1352L,1372L,1568L,1728L,1800L,1944L,2000L,2048L,2187L,2197L,2312L,2592L,2700L,2744L,2888L,3087L,3125L,3200L,3267L,3375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102834Inst : IEnumerable<long>
{
public static readonly long[] Value=A102834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102834.Bytes);
public long this[int i]=>Value[i];

public static A102834Inst Instance=new A102834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102835
{
public static readonly long[] Value={ 18L,50L,75L,98L,147L,242L,245L,338L,363L,507L,578L,605L,722L,845L,847L,867L,1058L,1083L,1183L,1445L,1587L,1682L,1805L,1859L,1922L,2023L,2250L,2523L,2527L,2645L,2738L,2883L,3179L,3362L,3698L,3703L,3757L,3971L,4107L,4205L,4418L,4693L,4805L,5043L,5547L,5618L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102835Inst : IEnumerable<long>
{
public static readonly long[] Value=A102835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102835.Bytes);
public long this[int i]=>Value[i];

public static A102835Inst Instance=new A102835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102836
{
public static readonly long[] Value={ 18L,50L,75L,98L,147L,242L,245L,338L,363L,507L,578L,605L,722L,845L,847L,867L,1058L,1083L,1183L,1445L,1587L,1682L,1805L,1859L,1922L,2023L,2523L,2527L,2645L,2738L,2883L,3179L,3362L,3698L,3703L,3757L,3971L,4107L,4205L,4418L,4693L,4805L,5043L,5547L,5618L,5819L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102836Inst : IEnumerable<long>
{
public static readonly long[] Value=A102836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102836.Bytes);
public long this[int i]=>Value[i];

public static A102836Inst Instance=new A102836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102837
{
public static readonly long[] Value={ 1L,4L,9L,10L,18L,40L,46L,52L,61L,63L,90L,94L,100L,108L,112L,136L,144L,184L,196L,400L,406L,414L,432L,448L,478L,502L,522L,562L,601L,603L,619L,625L,657L,667L,900L,904L,916L,928L,952L,972L,1000L,1008L,1012L,1036L,1044L,1084L,1096L,1152L,1168L,1240L,1260L,1348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102837Inst : IEnumerable<long>
{
public static readonly long[] Value=A102837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102837.Bytes);
public long this[int i]=>Value[i];

public static A102837Inst Instance=new A102837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102838
{
public static readonly long[] Value={ 54L,250L,375L,686L,1029L,1715L,2662L,3993L,4394L,6591L,6655L,9317L,9826L,10985L,13718L,14739L,15379L,20577L,24167L,24334L,24565L,34295L,34391L,36501L,48013L,48778L,54043L,59582L,60835L,63869L,73167L,75449L,85169L,89167L,89373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102838Inst : IEnumerable<long>
{
public static readonly long[] Value=A102838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102838.Bytes);
public long this[int i]=>Value[i];

public static A102838Inst Instance=new A102838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102839
{
public static readonly long[] Value={ 0L,1L,3L,12L,40L,135L,441L,1428L,4572L,14535L,45925L,144408L,452244L,1411501L,4392675L,13636080L,42237792L,130580451L,403009209L,1241912580L,3821849640L,11746816389L,36064532427L,110610649548L,338928124500L,1037636534025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102839Inst : IEnumerable<long>
{
public static readonly long[] Value=A102839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102839.Bytes);
public long this[int i]=>Value[i];

public static A102839Inst Instance=new A102839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102840
{
public static readonly long[] Value={ 0L,1L,3L,0L,-20L,-45L,21L,308L,540L,-585L,-4235L,-5676L,11232L,54145L,51975L,-182400L,-654160L,-380205L,2680425L,7516400L,1320900L,-36753255L,-82175665L,24032700L,477852900L,850446025L,-749925189L,-5944471092L,-8220606800L,14049061455L,71102953305L,71989187536L,-220682377872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102840Inst : IEnumerable<long>
{
public static readonly long[] Value=A102840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102840.Bytes);
public long this[int i]=>Value[i];

public static A102840Inst Instance=new A102840Inst();

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