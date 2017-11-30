using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A013577
{
public static readonly long[] Value={ 17L,34L,49L,64L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013577Inst : IEnumerable<long>
{
public static readonly long[] Value=A013577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013577.Bytes);
public long this[int i]=>Value[i];

public static A013577Inst Instance=new A013577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013578
{
public static readonly long[] Value={ 1L,2L,4L,5L,10L,13L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013578Inst : IEnumerable<long>
{
public static readonly long[] Value=A013578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013578.Bytes);
public long this[int i]=>Value[i];

public static A013578Inst Instance=new A013578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013579
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,0L,3L,0L,18L,143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013579Inst : IEnumerable<long>
{
public static readonly long[] Value=A013579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013579.Bytes);
public long this[int i]=>Value[i];

public static A013579Inst Instance=new A013579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013580
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,4L,4L,1L,1L,5L,9L,5L,1L,1L,6L,14L,14L,6L,1L,1L,7L,20L,29L,20L,7L,1L,1L,8L,27L,49L,49L,27L,8L,1L,1L,9L,35L,76L,99L,76L,35L,9L,1L,1L,10L,44L,111L,175L,175L,111L,44L,10L,1L,1L,11L,54L,155L,286L,351L,286L,155L,54L,11L,1L,1L,12L,65L,209L,441L,637L,637L,441L,209L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013580Inst : IEnumerable<long>
{
public static readonly long[] Value=A013580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013580.Bytes);
public long this[int i]=>Value[i];

public static A013580Inst Instance=new A013580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013581
{
public static readonly long[] Value={ 1L,3L,9L,15L,33L,75L,90L,105L,165L,213L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013581Inst : IEnumerable<long>
{
public static readonly long[] Value=A013581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013581.Bytes);
public long this[int i]=>Value[i];

public static A013581Inst Instance=new A013581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013582
{
public static readonly long[] Value={ 1L,4L,25L,124L,574L,2156L,8258L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013582Inst : IEnumerable<long>
{
public static readonly long[] Value=A013582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013582.Bytes);
public long this[int i]=>Value[i];

public static A013582Inst Instance=new A013582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013583
{
public static readonly long[] Value={ 1L,3L,8L,16L,24L,37L,58L,63L,97L,105L,152L,160L,168L,249L,257L,270L,406L,401L,435L,448L,440L,647L,1011L,673L,723L,715L,1066L,1058L,1050L,1092L,1160L,1147L,1694L,1155L,1710L,1702L,2647L,1846L,1765L,1854L,2736L,1867L,2757L,2744L,2841L,2990L,2752L,2854L,2985L,3019L,4511L,3032L,6967L,4456L,3024L,4477L,4616L,4451L,7349L,4629L,7218L,4917L,4621L,4854L,4904L,7179L,7166L,4896L,7200L,7247L,7310L,7213L,7831L,8187L,7488L,7205L,11614L,7480L,7815L,7857L,7925L,11593L,18154L,7912L,11813L,11682L,11653L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013583Inst : IEnumerable<long>
{
public static readonly long[] Value=A013583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013583.Bytes);
public long this[int i]=>Value[i];

public static A013583Inst Instance=new A013583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013584
{
public static readonly long[] Value={ 1L,2L,0L,3L,4L,0L,6L,0L,0L,4L,6L,0L,0L,6L,0L,0L,5L,0L,7L,0L,0L,6L,7L,0L,0L,0L,0L,0L,0L,0L,12L,0L,0L,5L,0L,0L,22L,7L,0L,0L,16L,0L,0L,0L,0L,7L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,55L,12L,0L,0L,0L,0L,0L,0L,0L,0L,54L,0L,42L,22L,0L,0L,6L,0L,0L,0L,0L,16L,0L,0L,0L,0L,0L,0L,24L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013584Inst : IEnumerable<long>
{
public static readonly long[] Value=A013584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013584.Bytes);
public long this[int i]=>Value[i];

public static A013584Inst Instance=new A013584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013585
{
public static readonly long[] Value={ 1L,2L,0L,0L,3L,4L,0L,0L,5L,0L,0L,12L,0L,7L,19L,0L,4L,0L,24L,0L,32L,19L,0L,0L,0L,5L,20L,0L,0L,0L,0L,0L,0L,20L,12L,0L,7L,0L,0L,57L,7L,0L,0L,19L,0L,0L,0L,0L,6L,8L,83L,0L,0L,15L,33L,24L,0L,0L,0L,0L,12L,32L,0L,38L,19L,9L,0L,0L,0L,23L,0L,0L,0L,0L,70L,71L,5L,0L,57L,20L,0L,17L,0L,0L,0L,0L,26L,0L,0L,0L,0L,0L,0L,0L,0L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013585Inst : IEnumerable<long>
{
public static readonly long[] Value=A013585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013585.Bytes);
public long this[int i]=>Value[i];

public static A013585Inst Instance=new A013585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013586
{
public static readonly long[] Value={ 2L,2L,2L,0L,3L,3L,3L,0L,0L,5L,7L,0L,13L,7L,5L,0L,17L,0L,7L,0L,7L,11L,23L,0L,0L,13L,0L,0L,5L,5L,5L,0L,11L,17L,7L,0L,23L,19L,13L,0L,41L,7L,43L,0L,0L,23L,47L,0L,0L,0L,17L,0L,19L,0L,11L,0L,19L,29L,13L,0L,17L,31L,0L,0L,13L,11L,67L,0L,23L,7L,71L,0L,53L,37L,0L,0L,11L,13L,29L,0L,0L,41L,83L,0L,17L,43L,29L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013586Inst : IEnumerable<long>
{
public static readonly long[] Value=A013586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013586.Bytes);
public long this[int i]=>Value[i];

public static A013586Inst Instance=new A013586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013587
{
public static readonly BigInteger[] Value={ 1L,1L,12L,620L,87304L,26312976L,14616808192L,13525751027392L,19385778269260800L,BigInteger.Parse("40739017561997799680"),BigInteger.Parse("120278021410937387514880"),BigInteger.Parse("482113680618029292368686080"),BigInteger.Parse("2551154673732472157928033617920") };
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
public class A013587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013587Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013587.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013587Inst Instance=new A013587Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013588
{
public static readonly long[] Value={ 2L,2L,3L,4L,6L,10L,19L,41L,103L,269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013588Inst : IEnumerable<long>
{
public static readonly long[] Value=A013588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013588.Bytes);
public long this[int i]=>Value[i];

public static A013588Inst Instance=new A013588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013589
{
public static readonly BigInteger[] Value={ 4L,10L,55L,1540L,1186570L,703974775735L,BigInteger.Parse("247790242435923759782980"),BigInteger.Parse("30700002123226936025189367747945843590228731690"),BigInteger.Parse("471245065183069190019624521318729501785547966685566656416776916445985874756815447988119493895") };
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
public class A013589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013589Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013589.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013589Inst Instance=new A013589Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013590
{
public static readonly long[] Value={ 105L,165L,195L,210L,255L,273L,285L,315L,330L,345L,357L,385L,390L,420L,429L,455L,495L,510L,525L,546L,555L,561L,570L,585L,595L,609L,615L,627L,630L,645L,660L,665L,690L,705L,714L,715L,735L,759L,765L,770L,777L,780L,795L,805L,819L,825L,840L,855L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013590Inst : IEnumerable<long>
{
public static readonly long[] Value=A013590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013590.Bytes);
public long this[int i]=>Value[i];

public static A013590Inst Instance=new A013590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013591
{
public static readonly long[] Value={ 385L,595L,665L,770L,935L,1155L,1190L,1235L,1309L,1330L,1365L,1463L,1495L,1540L,1729L,1785L,1855L,1870L,1925L,1955L,1995L,2065L,2145L,2261L,2310L,2380L,2415L,2431L,2465L,2470L,2618L,2660L,2665L,2695L,2717L,2730L,2737L,2795L,2805L,2821L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013591Inst : IEnumerable<long>
{
public static readonly long[] Value=A013591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013591.Bytes);
public long this[int i]=>Value[i];

public static A013591Inst Instance=new A013591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013592
{
public static readonly long[] Value={ 1365L,1785L,1995L,2145L,2415L,2431L,2717L,2730L,2737L,2805L,2849L,3003L,3135L,3255L,3315L,3553L,3570L,3689L,3705L,3795L,3885L,3927L,3990L,4081L,4095L,4147L,4199L,4290L,4305L,4485L,4515L,4543L,4641L,4785L,4830L,4845L,4862L,4991L,5005L,5115L,5187L,5291L,5313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013592Inst : IEnumerable<long>
{
public static readonly long[] Value=A013592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013592.Bytes);
public long this[int i]=>Value[i];

public static A013592Inst Instance=new A013592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013593
{
public static readonly long[] Value={ 1785L,2145L,2717L,2805L,3135L,3570L,3705L,3795L,3885L,3927L,4290L,4641L,4785L,4845L,5005L,5115L,5187L,5291L,5313L,5355L,5434L,5610L,5655L,6270L,6279L,6435L,6545L,6699L,6765L,6783L,7035L,7095L,7140L,7215L,7293L,7315L,7410L,7455L,7590L,7735L,7770L,7854L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013593Inst : IEnumerable<long>
{
public static readonly long[] Value=A013593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013593.Bytes);
public long this[int i]=>Value[i];

public static A013593Inst Instance=new A013593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013594
{
public static readonly long[] Value={ 0L,105L,385L,1365L,1785L,2805L,3135L,6545L,6545L,10465L,10465L,10465L,10465L,10465L,11305L,11305L,11305L,11305L,11305L,11305L,11305L,15015L,11305L,17255L,17255L,20615L,20615L,26565L,26565L,26565L,26565L,26565L,26565L,26565L,26565L,26565L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013594Inst : IEnumerable<long>
{
public static readonly long[] Value=A013594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013594.Bytes);
public long this[int i]=>Value[i];

public static A013594Inst Instance=new A013594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013595
{
public static readonly long[] Value={ 0L,1L,-1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,-1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,-1L,1L,-1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,-1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,-1L,1L,-1L,1L,-1L,1L,1L,-1L,0L,1L,-1L,1L,0L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013595Inst : IEnumerable<long>
{
public static readonly long[] Value=A013595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013595.Bytes);
public long this[int i]=>Value[i];

public static A013595Inst Instance=new A013595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013596
{
public static readonly long[] Value={ 1L,0L,1L,-1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,-1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,-1L,1L,-1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,-1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,-1L,1L,-1L,1L,-1L,1L,1L,-1L,0L,1L,-1L,1L,0L,-1L,1L,1L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013596Inst : IEnumerable<long>
{
public static readonly long[] Value=A013596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013596.Bytes);
public long this[int i]=>Value[i];

public static A013596Inst Instance=new A013596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013597
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,5L,3L,3L,1L,9L,7L,5L,3L,17L,27L,3L,1L,29L,3L,21L,7L,17L,15L,9L,43L,35L,15L,29L,3L,11L,3L,11L,15L,17L,25L,53L,31L,9L,7L,23L,15L,27L,15L,29L,7L,59L,15L,5L,21L,69L,55L,21L,21L,5L,159L,3L,81L,9L,69L,131L,33L,15L,135L,29L,13L,131L,9L,3L,33L,29L,25L,11L,15L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013597Inst : IEnumerable<long>
{
public static readonly long[] Value=A013597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013597.Bytes);
public long this[int i]=>Value[i];

public static A013597Inst Instance=new A013597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013614
{
public static readonly long[] Value={ 1L,1L,7L,1L,14L,49L,1L,21L,147L,343L,1L,28L,294L,1372L,2401L,1L,35L,490L,3430L,12005L,16807L,1L,42L,735L,6860L,36015L,100842L,117649L,1L,49L,1029L,12005L,84035L,352947L,823543L,823543L,1L,56L,1372L,19208L,168070L,941192L,3294172L,6588344L,5764801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013614Inst : IEnumerable<long>
{
public static readonly long[] Value=A013614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013614.Bytes);
public long this[int i]=>Value[i];

public static A013614Inst Instance=new A013614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013615
{
public static readonly long[] Value={ 1L,1L,8L,1L,16L,64L,1L,24L,192L,512L,1L,32L,384L,2048L,4096L,1L,40L,640L,5120L,20480L,32768L,1L,48L,960L,10240L,61440L,196608L,262144L,1L,56L,1344L,17920L,143360L,688128L,1835008L,2097152L,1L,64L,1792L,28672L,286720L,1835008L,7340032L,16777216L,16777216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013615Inst : IEnumerable<long>
{
public static readonly long[] Value=A013615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013615.Bytes);
public long this[int i]=>Value[i];

public static A013615Inst Instance=new A013615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013616
{
public static readonly long[] Value={ 1L,1L,9L,1L,18L,81L,1L,27L,243L,729L,1L,36L,486L,2916L,6561L,1L,45L,810L,7290L,32805L,59049L,1L,54L,1215L,14580L,98415L,354294L,531441L,1L,63L,1701L,25515L,229635L,1240029L,3720087L,4782969L,1L,72L,2268L,40824L,459270L,3306744L,14880348L,38263752L,43046721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013616Inst : IEnumerable<long>
{
public static readonly long[] Value=A013616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013616.Bytes);
public long this[int i]=>Value[i];

public static A013616Inst Instance=new A013616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013617
{
public static readonly long[] Value={ 1L,1L,10L,1L,20L,100L,1L,30L,300L,1000L,1L,40L,600L,4000L,10000L,1L,50L,1000L,10000L,50000L,100000L,1L,60L,1500L,20000L,150000L,600000L,1000000L,1L,70L,2100L,35000L,350000L,2100000L,7000000L,10000000L,1L,80L,2800L,56000L,700000L,5600000L,28000000L,80000000L,100000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013617Inst : IEnumerable<long>
{
public static readonly long[] Value=A013617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013617.Bytes);
public long this[int i]=>Value[i];

public static A013617Inst Instance=new A013617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013618
{
public static readonly long[] Value={ 1L,1L,11L,1L,22L,121L,1L,33L,363L,1331L,1L,44L,726L,5324L,14641L,1L,55L,1210L,13310L,73205L,161051L,1L,66L,1815L,26620L,219615L,966306L,1771561L,1L,77L,2541L,46585L,512435L,3382071L,12400927L,19487171L,1L,88L,3388L,74536L,1024870L,9018856L,49603708L,155897368L,214358881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013618Inst : IEnumerable<long>
{
public static readonly long[] Value=A013618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013618.Bytes);
public long this[int i]=>Value[i];

public static A013618Inst Instance=new A013618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013619
{
public static readonly long[] Value={ 1L,1L,12L,1L,24L,144L,1L,36L,432L,1728L,1L,48L,864L,6912L,20736L,1L,60L,1440L,17280L,103680L,248832L,1L,72L,2160L,34560L,311040L,1492992L,2985984L,1L,84L,3024L,60480L,725760L,5225472L,20901888L,35831808L,1L,96L,4032L,96768L,1451520L,13934592L,83607552L,286654464L,429981696L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013619Inst : IEnumerable<long>
{
public static readonly long[] Value=A013619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013619.Bytes);
public long this[int i]=>Value[i];

public static A013619Inst Instance=new A013619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013620
{
public static readonly long[] Value={ 1L,2L,3L,4L,12L,9L,8L,36L,54L,27L,16L,96L,216L,216L,81L,32L,240L,720L,1080L,810L,243L,64L,576L,2160L,4320L,4860L,2916L,729L,128L,1344L,6048L,15120L,22680L,20412L,10206L,2187L,256L,3072L,16128L,48384L,90720L,108864L,81648L,34992L,6561L,512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013620Inst : IEnumerable<long>
{
public static readonly long[] Value=A013620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013620.Bytes);
public long this[int i]=>Value[i];

public static A013620Inst Instance=new A013620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013621
{
public static readonly long[] Value={ 1L,2L,5L,4L,20L,25L,8L,60L,150L,125L,16L,160L,600L,1000L,625L,32L,400L,2000L,5000L,6250L,3125L,64L,960L,6000L,20000L,37500L,37500L,15625L,128L,2240L,16800L,70000L,175000L,262500L,218750L,78125L,256L,5120L,44800L,224000L,700000L,1400000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013621Inst : IEnumerable<long>
{
public static readonly long[] Value=A013621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013621.Bytes);
public long this[int i]=>Value[i];

public static A013621Inst Instance=new A013621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013622
{
public static readonly long[] Value={ 1L,3L,5L,9L,30L,25L,27L,135L,225L,125L,81L,540L,1350L,1500L,625L,243L,2025L,6750L,11250L,9375L,3125L,729L,7290L,30375L,67500L,84375L,56250L,15625L,2187L,25515L,127575L,354375L,590625L,590625L,328125L,78125L,6561L,87480L,510300L,1701000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013622Inst : IEnumerable<long>
{
public static readonly long[] Value=A013622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013622.Bytes);
public long this[int i]=>Value[i];

public static A013622Inst Instance=new A013622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013623
{
public static readonly long[] Value={ 1L,2L,7L,4L,28L,49L,8L,84L,294L,343L,16L,224L,1176L,2744L,2401L,32L,560L,3920L,13720L,24010L,16807L,64L,1344L,11760L,54880L,144060L,201684L,117649L,128L,3136L,32928L,192080L,672280L,1411788L,1647086L,823543L,256L,7168L,87808L,614656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013623Inst : IEnumerable<long>
{
public static readonly long[] Value=A013623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013623.Bytes);
public long this[int i]=>Value[i];

public static A013623Inst Instance=new A013623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013624
{
public static readonly long[] Value={ 1L,3L,7L,9L,42L,49L,27L,189L,441L,343L,81L,756L,2646L,4116L,2401L,243L,2835L,13230L,30870L,36015L,16807L,729L,10206L,59535L,185220L,324135L,302526L,117649L,2187L,35721L,250047L,972405L,2268945L,3176523L,2470629L,823543L,6561L,122472L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013624Inst : IEnumerable<long>
{
public static readonly long[] Value=A013624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013624.Bytes);
public long this[int i]=>Value[i];

public static A013624Inst Instance=new A013624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013625
{
public static readonly long[] Value={ 1L,4L,7L,16L,56L,49L,64L,336L,588L,343L,256L,1792L,4704L,5488L,2401L,1024L,8960L,31360L,54880L,48020L,16807L,4096L,43008L,188160L,439040L,576240L,403368L,117649L,16384L,200704L,1053696L,3073280L,5378240L,5647152L,3294172L,823543L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013625Inst : IEnumerable<long>
{
public static readonly long[] Value=A013625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013625.Bytes);
public long this[int i]=>Value[i];

public static A013625Inst Instance=new A013625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013626
{
public static readonly long[] Value={ 1L,5L,7L,25L,70L,49L,125L,525L,735L,343L,625L,3500L,7350L,6860L,2401L,3125L,21875L,61250L,85750L,60025L,16807L,15625L,131250L,459375L,857500L,900375L,504210L,117649L,78125L,765625L,3215625L,7503125L,10504375L,8823675L,4117715L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013626Inst : IEnumerable<long>
{
public static readonly long[] Value=A013626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013626.Bytes);
public long this[int i]=>Value[i];

public static A013626Inst Instance=new A013626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013627
{
public static readonly long[] Value={ 1L,6L,7L,36L,84L,49L,216L,756L,882L,343L,1296L,6048L,10584L,8232L,2401L,7776L,45360L,105840L,123480L,72030L,16807L,46656L,326592L,952560L,1481760L,1296540L,605052L,117649L,279936L,2286144L,8001504L,15558480L,18151560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013627Inst : IEnumerable<long>
{
public static readonly long[] Value=A013627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013627.Bytes);
public long this[int i]=>Value[i];

public static A013627Inst Instance=new A013627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013628
{
public static readonly long[] Value={ 1L,4L,5L,16L,40L,25L,64L,240L,300L,125L,256L,1280L,2400L,2000L,625L,1024L,6400L,16000L,20000L,12500L,3125L,4096L,30720L,96000L,160000L,150000L,75000L,15625L,16384L,143360L,537600L,1120000L,1400000L,1050000L,437500L,78125L,65536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013628Inst : IEnumerable<long>
{
public static readonly long[] Value=A013628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013628.Bytes);
public long this[int i]=>Value[i];

public static A013628Inst Instance=new A013628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013629
{
public static readonly long[] Value={ 14L,21L,25L,30L,32L,37L,40L,43L,48L,49L,52L,56L,59L,60L,65L,67L,69L,72L,75L,77L,79L,82L,84L,87L,88L,92L,94L,95L,98L,101L,103L,105L,107L,111L,111L,114L,116L,118L,121L,122L,124L,127L,129L,131L,133L,134L,138L,139L,141L,143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013629Inst : IEnumerable<long>
{
public static readonly long[] Value=A013629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013629.Bytes);
public long this[int i]=>Value[i];

public static A013629Inst Instance=new A013629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013630
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,8L,22L,8L,1L,1L,34L,295L,565L,295L,34L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013630Inst : IEnumerable<long>
{
public static readonly long[] Value=A013630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013630.Bytes);
public long this[int i]=>Value[i];

public static A013630Inst Instance=new A013630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013631
{
public static readonly long[] Value={ 1L,4L,1L,18L,1L,1L,1L,4L,1L,9L,9L,2L,1L,1L,1L,2L,7L,1L,1L,7L,11L,1L,1L,1L,3L,1L,6L,1L,30L,1L,4L,1L,1L,4L,1L,3L,1L,2L,7L,1L,3L,1L,2L,2L,1L,16L,1L,1L,3L,3L,1L,2L,2L,1L,6L,1L,1L,1L,6L,1L,1L,4L,428L,5L,1L,1L,3L,1L,1L,11L,2L,4L,4L,5L,4L,1L,5L,14L,1L,3L,1L,2L,19L,1L,2L,5L,1L,7L,1L,1L,1L,1L,1L,57L,3L,2L,14L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013631Inst : IEnumerable<long>
{
public static readonly long[] Value=A013631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013631.Bytes);
public long this[int i]=>Value[i];

public static A013631Inst Instance=new A013631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013632
{
public static readonly long[] Value={ 2L,1L,1L,2L,1L,2L,1L,4L,3L,2L,1L,2L,1L,4L,3L,2L,1L,2L,1L,4L,3L,2L,1L,6L,5L,4L,3L,2L,1L,2L,1L,6L,5L,4L,3L,2L,1L,4L,3L,2L,1L,2L,1L,4L,3L,2L,1L,6L,5L,4L,3L,2L,1L,6L,5L,4L,3L,2L,1L,2L,1L,6L,5L,4L,3L,2L,1L,4L,3L,2L,1L,2L,1L,6L,5L,4L,3L,2L,1L,4L,3L,2L,1L,6L,5L,4L,3L,2L,1L,8L,7L,6L,5L,4L,3L,2L,1L,4L,3L,2L,1L,2L,1L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013632Inst : IEnumerable<long>
{
public static readonly long[] Value=A013632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013632.Bytes);
public long this[int i]=>Value[i];

public static A013632Inst Instance=new A013632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013633
{
public static readonly long[] Value={ 3L,2L,4L,2L,6L,4L,4L,4L,6L,2L,6L,4L,4L,4L,6L,2L,6L,4L,4L,4L,10L,6L,6L,6L,6L,6L,8L,2L,8L,6L,6L,6L,6L,6L,10L,4L,4L,4L,6L,2L,6L,4L,4L,4L,10L,6L,6L,6L,6L,6L,12L,6L,6L,6L,6L,6L,8L,2L,8L,6L,6L,6L,6L,6L,10L,4L,4L,4L,6L,2L,8L,6L,6L,6L,6L,6L,10L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013633Inst : IEnumerable<long>
{
public static readonly long[] Value=A013633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013633.Bytes);
public long this[int i]=>Value[i];

public static A013633Inst Instance=new A013633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013634
{
public static readonly long[] Value={ 2L,3L,5L,8L,9L,12L,13L,18L,19L,20L,21L,24L,25L,30L,31L,32L,33L,36L,37L,42L,43L,44L,45L,52L,53L,54L,55L,56L,57L,60L,61L,68L,69L,70L,71L,72L,73L,78L,79L,80L,81L,84L,85L,90L,91L,92L,93L,100L,101L,102L,103L,104L,105L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013634Inst : IEnumerable<long>
{
public static readonly long[] Value=A013634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013634.Bytes);
public long this[int i]=>Value[i];

public static A013634Inst Instance=new A013634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013635
{
public static readonly long[] Value={ 5L,7L,8L,11L,12L,15L,16L,17L,18L,23L,24L,27L,28L,29L,30L,35L,36L,39L,40L,41L,42L,47L,48L,49L,50L,51L,52L,59L,60L,63L,64L,65L,66L,67L,68L,75L,76L,77L,78L,83L,84L,87L,88L,89L,90L,95L,96L,97L,98L,99L,100L,107L,108L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013635Inst : IEnumerable<long>
{
public static readonly long[] Value=A013635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013635.Bytes);
public long this[int i]=>Value[i];

public static A013635Inst Instance=new A013635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013636
{
public static readonly long[] Value={ 0L,2L,6L,15L,20L,35L,42L,77L,88L,99L,110L,143L,156L,221L,238L,255L,272L,323L,342L,437L,460L,483L,506L,667L,696L,725L,754L,783L,812L,899L,930L,1147L,1184L,1221L,1258L,1295L,1332L,1517L,1558L,1599L,1640L,1763L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013636Inst : IEnumerable<long>
{
public static readonly long[] Value=A013636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013636.Bytes);
public long this[int i]=>Value[i];

public static A013636Inst Instance=new A013636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013637
{
public static readonly long[] Value={ 6L,12L,15L,30L,35L,56L,63L,70L,77L,132L,143L,182L,195L,208L,221L,306L,323L,380L,399L,418L,437L,552L,575L,598L,621L,644L,667L,870L,899L,992L,1023L,1054L,1085L,1116L,1147L,1406L,1443L,1480L,1517L,1722L,1763L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013637Inst : IEnumerable<long>
{
public static readonly long[] Value=A013637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013637.Bytes);
public long this[int i]=>Value[i];

public static A013637Inst Instance=new A013637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013638
{
public static readonly long[] Value={ 10L,15L,21L,35L,55L,77L,77L,77L,91L,143L,187L,221L,221L,221L,247L,323L,391L,437L,437L,437L,551L,667L,667L,667L,667L,667L,713L,899L,1073L,1147L,1147L,1147L,1147L,1147L,1271L,1517L,1517L,1517L,1591L,1763L,1927L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013638Inst : IEnumerable<long>
{
public static readonly long[] Value=A013638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013638.Bytes);
public long this[int i]=>Value[i];

public static A013638Inst Instance=new A013638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013639
{
public static readonly BigInteger[] Value={ 1L,2L,3L,5L,22L,14887L,6199216184L,BigInteger.Parse("18181934572391120000418841557") };
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
public class A013639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013639Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013639.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013639Inst Instance=new A013639Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013640
{
public static readonly long[] Value={ 1L,4203045807626L,84060916163336L,798578704207074L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013640Inst : IEnumerable<long>
{
public static readonly long[] Value=A013640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013640.Bytes);
public long this[int i]=>Value[i];

public static A013640Inst Instance=new A013640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013641
{
public static readonly long[] Value={ 1L,1320L,869619L,24650747L,342491792L,3070918789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013641Inst : IEnumerable<long>
{
public static readonly long[] Value=A013641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013641.Bytes);
public long this[int i]=>Value[i];

public static A013641Inst Instance=new A013641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013642
{
public static readonly long[] Value={ 3L,6L,8L,11L,12L,15L,18L,20L,24L,27L,30L,35L,38L,39L,40L,42L,48L,51L,56L,63L,66L,68L,72L,80L,83L,84L,87L,90L,99L,102L,104L,105L,110L,120L,123L,132L,143L,146L,147L,148L,150L,152L,156L,168L,171L,182L,195L,198L,200L,203L,210L,224L,227L,228L,230L,231L,235L,240L,255L,258L,260L,264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013642Inst : IEnumerable<long>
{
public static readonly long[] Value=A013642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013642.Bytes);
public long this[int i]=>Value[i];

public static A013642Inst Instance=new A013642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013643
{
public static readonly long[] Value={ 41L,130L,269L,370L,458L,697L,986L,1313L,1325L,1613L,1714L,2153L,2642L,2834L,3181L,3770L,4409L,4778L,4933L,5098L,5837L,5954L,6626L,7465L,7610L,8354L,9293L,10282L,10865L,11257L,11321L,12410L,13033L,13549L,14698L,14738L,15977L,17266L,17989L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013643Inst : IEnumerable<long>
{
public static readonly long[] Value=A013643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013643.Bytes);
public long this[int i]=>Value[i];

public static A013643Inst Instance=new A013643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013644
{
public static readonly long[] Value={ 7L,14L,23L,28L,32L,33L,34L,47L,55L,60L,62L,75L,78L,79L,95L,96L,98L,119L,126L,128L,136L,138L,140L,141L,142L,155L,167L,174L,176L,180L,189L,192L,194L,215L,219L,220L,222L,223L,248L,252L,254L,266L,287L,299L,300L,305L,312L,315L,318L,320L,321L,322L,335L,359L,368L,377L,390L,392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013644Inst : IEnumerable<long>
{
public static readonly long[] Value=A013644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013644.Bytes);
public long this[int i]=>Value[i];

public static A013644Inst Instance=new A013644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013645
{
public static readonly long[] Value={ 1L,2L,3L,7L,13L,19L,31L,43L,46L,94L,139L,151L,166L,211L,331L,421L,526L,571L,604L,631L,751L,886L,919L,1291L,1324L,1366L,1516L,1621L,1726L,2011L,2311L,2566L,2671L,3004L,3019L,3334L,3691L,3931L,4174L,4846L,5119L,6211L,6451L,6679L,6694L,7606L,8254L,8779L,8941L,9739L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013645Inst : IEnumerable<long>
{
public static readonly long[] Value=A013645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013645.Bytes);
public long this[int i]=>Value[i];

public static A013645Inst Instance=new A013645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013662
{
public static readonly long[] Value={ 1L,0L,8L,2L,3L,2L,3L,2L,3L,3L,7L,1L,1L,1L,3L,8L,1L,9L,1L,5L,1L,6L,0L,0L,3L,6L,9L,6L,5L,4L,1L,1L,6L,7L,9L,0L,2L,7L,7L,4L,7L,5L,0L,9L,5L,1L,9L,1L,8L,7L,2L,6L,9L,0L,7L,6L,8L,2L,9L,7L,6L,2L,1L,5L,4L,4L,4L,1L,2L,0L,6L,1L,6L,1L,8L,6L,9L,6L,8L,8L,4L,6L,5L,5L,6L,9L,0L,9L,6L,3L,5L,9L,4L,1L,6L,9L,9L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013662Inst : IEnumerable<long>
{
public static readonly long[] Value=A013662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013662.Bytes);
public long this[int i]=>Value[i];

public static A013662Inst Instance=new A013662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013663
{
public static readonly long[] Value={ 1L,0L,3L,6L,9L,2L,7L,7L,5L,5L,1L,4L,3L,3L,6L,9L,9L,2L,6L,3L,3L,1L,3L,6L,5L,4L,8L,6L,4L,5L,7L,0L,3L,4L,1L,6L,8L,0L,5L,7L,0L,8L,0L,9L,1L,9L,5L,0L,1L,9L,1L,2L,8L,1L,1L,9L,7L,4L,1L,9L,2L,6L,7L,7L,9L,0L,3L,8L,0L,3L,5L,8L,9L,7L,8L,6L,2L,8L,1L,4L,8L,4L,5L,6L,0L,0L,4L,3L,1L,0L,6L,5L,5L,7L,1L,3L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013663Inst : IEnumerable<long>
{
public static readonly long[] Value=A013663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013663.Bytes);
public long this[int i]=>Value[i];

public static A013663Inst Instance=new A013663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013664
{
public static readonly long[] Value={ 1L,0L,1L,7L,3L,4L,3L,0L,6L,1L,9L,8L,4L,4L,4L,9L,1L,3L,9L,7L,1L,4L,5L,1L,7L,9L,2L,9L,7L,9L,0L,9L,2L,0L,5L,2L,7L,9L,0L,1L,8L,1L,7L,4L,9L,0L,0L,3L,2L,8L,5L,3L,5L,6L,1L,8L,4L,2L,4L,0L,8L,6L,6L,4L,0L,0L,4L,3L,3L,2L,1L,8L,2L,9L,0L,1L,9L,5L,7L,8L,9L,7L,8L,8L,2L,7L,7L,3L,9L,7L,7L,9L,3L,8L,5L,3L,5L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013664Inst : IEnumerable<long>
{
public static readonly long[] Value=A013664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013664.Bytes);
public long this[int i]=>Value[i];

public static A013664Inst Instance=new A013664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013665
{
public static readonly long[] Value={ 1L,0L,0L,8L,3L,4L,9L,2L,7L,7L,3L,8L,1L,9L,2L,2L,8L,2L,6L,8L,3L,9L,7L,9L,7L,5L,4L,9L,8L,4L,9L,7L,9L,6L,7L,5L,9L,5L,9L,9L,8L,6L,3L,5L,6L,0L,5L,6L,5L,2L,3L,8L,7L,0L,6L,4L,1L,7L,2L,8L,3L,1L,3L,6L,5L,7L,1L,6L,0L,1L,4L,7L,8L,3L,1L,7L,3L,5L,5L,7L,3L,5L,3L,4L,6L,0L,9L,6L,9L,6L,8L,9L,1L,3L,8L,5L,1L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013665Inst : IEnumerable<long>
{
public static readonly long[] Value=A013665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013665.Bytes);
public long this[int i]=>Value[i];

public static A013665Inst Instance=new A013665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013666
{
public static readonly long[] Value={ 1L,0L,0L,4L,0L,7L,7L,3L,5L,6L,1L,9L,7L,9L,4L,4L,3L,3L,9L,3L,7L,8L,6L,8L,5L,2L,3L,8L,5L,0L,8L,6L,5L,2L,4L,6L,5L,2L,5L,8L,9L,6L,0L,7L,9L,0L,6L,4L,9L,8L,5L,0L,0L,2L,0L,3L,2L,9L,1L,1L,0L,2L,0L,2L,6L,5L,2L,5L,8L,2L,9L,5L,2L,5L,7L,4L,7L,4L,8L,8L,1L,4L,3L,9L,5L,2L,8L,7L,2L,3L,0L,3L,7L,2L,3L,7L,1L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013666Inst : IEnumerable<long>
{
public static readonly long[] Value=A013666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013666.Bytes);
public long this[int i]=>Value[i];

public static A013666Inst Instance=new A013666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013667
{
public static readonly long[] Value={ 1L,0L,0L,2L,0L,0L,8L,3L,9L,2L,8L,2L,6L,0L,8L,2L,2L,1L,4L,4L,1L,7L,8L,5L,2L,7L,6L,9L,2L,3L,2L,4L,1L,2L,0L,6L,0L,4L,8L,5L,6L,0L,5L,8L,5L,1L,3L,9L,4L,8L,8L,8L,7L,5L,6L,5L,4L,8L,5L,9L,6L,6L,1L,5L,9L,0L,9L,7L,8L,5L,0L,5L,3L,3L,9L,0L,2L,5L,8L,3L,9L,8L,9L,5L,0L,3L,9L,3L,0L,6L,9L,1L,2L,7L,1L,6L,9L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013667Inst : IEnumerable<long>
{
public static readonly long[] Value=A013667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013667.Bytes);
public long this[int i]=>Value[i];

public static A013667Inst Instance=new A013667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013668
{
public static readonly long[] Value={ 1L,0L,0L,0L,9L,9L,4L,5L,7L,5L,1L,2L,7L,8L,1L,8L,0L,8L,5L,3L,3L,7L,1L,4L,5L,9L,5L,8L,9L,0L,0L,3L,1L,9L,0L,1L,7L,0L,0L,6L,0L,1L,9L,5L,3L,1L,5L,6L,4L,4L,7L,7L,5L,1L,7L,2L,5L,7L,7L,8L,8L,9L,9L,4L,6L,3L,6L,2L,9L,1L,4L,6L,5L,1L,5L,1L,9L,1L,2L,9L,5L,4L,3L,9L,7L,0L,4L,1L,9L,6L,8L,6L,1L,0L,3L,8L,5L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013668Inst : IEnumerable<long>
{
public static readonly long[] Value=A013668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013668.Bytes);
public long this[int i]=>Value[i];

public static A013668Inst Instance=new A013668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013669
{
public static readonly long[] Value={ 1L,0L,0L,0L,4L,9L,4L,1L,8L,8L,6L,0L,4L,1L,1L,9L,4L,6L,4L,5L,5L,8L,7L,0L,2L,2L,8L,2L,5L,2L,6L,4L,6L,9L,9L,3L,6L,4L,6L,8L,6L,0L,6L,4L,3L,5L,7L,5L,8L,2L,0L,8L,6L,1L,7L,1L,1L,9L,1L,4L,1L,4L,3L,6L,1L,0L,0L,0L,5L,4L,0L,5L,9L,7L,9L,8L,2L,1L,9L,8L,1L,4L,7L,0L,2L,5L,9L,1L,8L,4L,3L,0L,2L,3L,5L,6L,0L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013669Inst : IEnumerable<long>
{
public static readonly long[] Value=A013669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013669.Bytes);
public long this[int i]=>Value[i];

public static A013669Inst Instance=new A013669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013670
{
public static readonly long[] Value={ 1L,0L,0L,0L,2L,4L,6L,0L,8L,6L,5L,5L,3L,3L,0L,8L,0L,4L,8L,2L,9L,8L,6L,3L,7L,9L,9L,8L,0L,4L,7L,7L,3L,9L,6L,7L,0L,9L,6L,0L,4L,1L,6L,0L,8L,8L,4L,5L,8L,0L,0L,3L,4L,0L,4L,5L,3L,3L,0L,4L,0L,9L,5L,2L,1L,3L,3L,2L,5L,2L,0L,1L,9L,6L,8L,1L,9L,4L,0L,9L,1L,3L,0L,4L,9L,0L,4L,2L,8L,0L,8L,5L,5L,1L,9L,0L,0L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013670Inst : IEnumerable<long>
{
public static readonly long[] Value=A013670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013670.Bytes);
public long this[int i]=>Value[i];

public static A013670Inst Instance=new A013670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013671
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,2L,2L,7L,1L,3L,3L,4L,7L,5L,7L,8L,4L,8L,9L,1L,4L,6L,7L,5L,1L,8L,3L,6L,5L,2L,6L,3L,5L,7L,3L,9L,5L,7L,1L,4L,2L,7L,5L,1L,0L,5L,8L,9L,5L,5L,0L,9L,8L,4L,5L,1L,3L,6L,7L,0L,2L,6L,7L,1L,6L,2L,0L,8L,9L,6L,7L,2L,6L,8L,2L,9L,8L,4L,4L,2L,0L,9L,8L,1L,2L,8L,9L,2L,7L,1L,3L,9L,5L,3L,2L,6L,8L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013671Inst : IEnumerable<long>
{
public static readonly long[] Value=A013671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013671.Bytes);
public long this[int i]=>Value[i];

public static A013671Inst Instance=new A013671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013672
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,6L,1L,2L,4L,8L,1L,3L,5L,0L,5L,8L,7L,0L,4L,8L,2L,9L,2L,5L,8L,5L,4L,5L,1L,0L,5L,1L,3L,5L,3L,3L,3L,7L,4L,7L,4L,8L,1L,6L,9L,6L,1L,6L,9L,1L,5L,4L,5L,4L,9L,4L,8L,2L,7L,5L,5L,2L,0L,2L,2L,5L,2L,8L,6L,2L,9L,4L,1L,0L,2L,3L,1L,7L,7L,4L,2L,0L,8L,7L,6L,6L,5L,9L,7L,8L,2L,9L,7L,1L,9L,9L,8L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013672Inst : IEnumerable<long>
{
public static readonly long[] Value=A013672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013672.Bytes);
public long this[int i]=>Value[i];

public static A013672Inst Instance=new A013672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013673
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,3L,0L,5L,8L,8L,2L,3L,6L,3L,0L,7L,0L,2L,0L,4L,9L,3L,5L,5L,1L,7L,2L,8L,5L,1L,0L,6L,4L,5L,0L,6L,2L,5L,8L,7L,6L,2L,7L,9L,4L,8L,7L,0L,6L,8L,5L,8L,1L,7L,7L,5L,0L,6L,5L,6L,9L,9L,3L,2L,8L,9L,3L,3L,3L,2L,2L,6L,7L,1L,5L,6L,3L,4L,2L,2L,7L,9L,5L,7L,3L,0L,7L,2L,3L,3L,4L,3L,4L,7L,0L,1L,7L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013673Inst : IEnumerable<long>
{
public static readonly long[] Value=A013673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013673.Bytes);
public long this[int i]=>Value[i];

public static A013673Inst Instance=new A013673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013674
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,5L,2L,8L,2L,2L,5L,9L,4L,0L,8L,6L,5L,1L,8L,7L,1L,7L,3L,2L,5L,7L,1L,4L,8L,7L,6L,3L,6L,7L,2L,2L,0L,2L,3L,2L,3L,7L,3L,8L,8L,9L,9L,0L,4L,7L,1L,5L,3L,1L,1L,5L,3L,1L,0L,5L,2L,0L,3L,5L,8L,8L,7L,8L,7L,0L,8L,7L,0L,2L,7L,9L,5L,3L,1L,5L,1L,7L,8L,6L,2L,8L,5L,6L,0L,4L,8L,4L,6L,3L,2L,2L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013674Inst : IEnumerable<long>
{
public static readonly long[] Value=A013674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013674.Bytes);
public long this[int i]=>Value[i];

public static A013674Inst Instance=new A013674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013675
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,7L,6L,3L,7L,1L,9L,7L,6L,3L,7L,8L,9L,9L,7L,6L,2L,2L,7L,3L,6L,0L,0L,2L,9L,3L,5L,6L,3L,0L,2L,9L,2L,1L,3L,0L,8L,8L,2L,4L,9L,0L,9L,0L,2L,6L,2L,6L,7L,9L,0L,9L,5L,3L,7L,9L,8L,4L,3L,9L,7L,2L,9L,3L,5L,6L,4L,3L,2L,9L,0L,2L,8L,2L,4L,5L,9L,3L,4L,2L,0L,8L,1L,7L,3L,8L,6L,3L,6L,9L,1L,6L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013675Inst : IEnumerable<long>
{
public static readonly long[] Value=A013675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013675.Bytes);
public long this[int i]=>Value[i];

public static A013675Inst Instance=new A013675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013676
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,3L,8L,1L,7L,2L,9L,3L,2L,6L,4L,9L,9L,9L,8L,3L,9L,8L,5L,6L,4L,6L,1L,6L,4L,4L,6L,2L,1L,9L,3L,9L,7L,3L,0L,4L,5L,4L,6L,9L,7L,2L,1L,8L,9L,5L,3L,3L,3L,1L,1L,4L,3L,1L,7L,4L,4L,2L,9L,9L,8L,7L,6L,3L,0L,0L,3L,9L,5L,4L,2L,6L,5L,0L,0L,4L,5L,6L,3L,8L,0L,0L,1L,9L,6L,8L,6L,6L,8L,9L,8L,9L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013676Inst : IEnumerable<long>
{
public static readonly long[] Value=A013676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013676.Bytes);
public long this[int i]=>Value[i];

public static A013676Inst Instance=new A013676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013677
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,1L,9L,0L,8L,2L,1L,2L,7L,1L,6L,5L,5L,3L,9L,3L,8L,9L,2L,5L,6L,5L,6L,9L,5L,7L,7L,9L,5L,1L,0L,1L,3L,5L,3L,2L,5L,8L,5L,7L,1L,1L,4L,4L,8L,3L,8L,6L,3L,0L,2L,3L,5L,9L,3L,3L,0L,4L,6L,7L,6L,1L,8L,2L,3L,9L,4L,9L,7L,0L,5L,3L,4L,1L,3L,0L,9L,3L,1L,2L,6L,6L,4L,2L,2L,7L,1L,1L,8L,0L,7L,6L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013677Inst : IEnumerable<long>
{
public static readonly long[] Value=A013677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013677.Bytes);
public long this[int i]=>Value[i];

public static A013677Inst Instance=new A013677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013678
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,9L,5L,3L,9L,6L,2L,0L,3L,3L,8L,7L,2L,7L,9L,6L,1L,1L,3L,1L,5L,2L,0L,3L,8L,6L,8L,3L,4L,4L,9L,3L,4L,5L,9L,4L,3L,7L,9L,4L,1L,8L,7L,4L,1L,0L,5L,9L,5L,7L,5L,0L,0L,5L,6L,4L,8L,9L,8L,5L,1L,1L,3L,7L,5L,1L,3L,7L,3L,1L,1L,4L,3L,9L,0L,0L,2L,5L,7L,8L,3L,6L,0L,9L,7L,9L,7L,6L,3L,8L,7L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013678Inst : IEnumerable<long>
{
public static readonly long[] Value=A013678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013678.Bytes);
public long this[int i]=>Value[i];

public static A013678Inst Instance=new A013678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013679
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,2L,4L,7L,1L,4L,2L,3L,4L,10L,1L,2L,1L,1L,1L,15L,1L,3L,6L,1L,1L,2L,1L,1L,1L,2L,2L,3L,1L,3L,1L,1L,5L,1L,2L,2L,1L,1L,6L,27L,20L,3L,97L,105L,1L,1L,1L,1L,1L,45L,2L,8L,19L,1L,4L,1L,1L,3L,1L,2L,1L,1L,1L,5L,1L,1L,2L,3L,6L,1L,1L,1L,2L,1L,5L,1L,1L,2L,9L,5L,3L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013679Inst : IEnumerable<long>
{
public static readonly long[] Value=A013679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013679.Bytes);
public long this[int i]=>Value[i];

public static A013679Inst Instance=new A013679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013680
{
public static readonly long[] Value={ 1L,12L,6L,1L,3L,1L,4L,183L,1L,1L,2L,1L,3L,1L,1L,5L,4L,2L,7L,23L,1L,1L,1L,1L,3L,2L,4L,2L,2L,22L,1L,13L,5L,1L,4L,2L,1L,3L,1L,1L,1L,6L,11L,40L,1L,7L,5L,2L,4L,1L,2L,3L,14L,9L,1L,33L,78L,1L,12L,4L,1L,2L,551L,1L,1L,1L,1L,1L,1L,2L,1L,9L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013680Inst : IEnumerable<long>
{
public static readonly long[] Value=A013680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013680.Bytes);
public long this[int i]=>Value[i];

public static A013680Inst Instance=new A013680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013681
{
public static readonly long[] Value={ 1L,27L,12L,1L,1L,15L,1L,5L,1L,2L,19L,1L,1L,32L,1L,13L,1L,1L,1L,3L,1L,3L,2L,16L,1L,12L,4L,1L,5L,1L,1L,1L,1L,1L,2L,2L,6L,1L,8L,8L,6L,2L,3L,2L,2L,1L,30L,1L,17L,116L,1L,7L,1L,1L,1L,1L,1L,1L,2L,2L,12L,1L,4L,1L,1L,94L,1L,1L,3L,3L,6L,6L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013681Inst : IEnumerable<long>
{
public static readonly long[] Value=A013681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013681.Bytes);
public long this[int i]=>Value[i];

public static A013681Inst Instance=new A013681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013682
{
public static readonly long[] Value={ 1L,57L,1L,1L,1L,15L,1L,6L,3L,61L,1L,5L,3L,1L,6L,1L,3L,3L,6L,1L,10L,1L,3L,2L,1L,4L,1L,1L,5L,1L,61L,1L,3L,1L,2L,1L,3L,2L,1L,3L,1L,2L,2L,28L,1L,2L,18L,53L,2L,1L,17L,11L,3L,4L,3L,5L,2L,1L,27L,9L,8L,3L,3L,3L,9L,5L,1L,3L,29L,1L,4L,1L,2L,40L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013682Inst : IEnumerable<long>
{
public static readonly long[] Value=A013682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013682.Bytes);
public long this[int i]=>Value[i];

public static A013682Inst Instance=new A013682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013683
{
public static readonly long[] Value={ 1L,119L,1L,3L,2L,1L,2L,1L,39L,2L,3L,12L,3L,1L,1L,1L,2L,6L,5L,1L,5L,1L,2L,1L,23L,2L,1L,5L,34L,2L,1L,1L,3L,47L,2L,1L,8L,16L,1L,4L,1L,2L,1L,1L,1L,10L,72L,1L,1L,1L,1L,1L,2L,3L,13L,1L,2L,1L,5L,1L,27L,2L,9283L,1L,36L,1L,1L,1L,1L,3L,3L,23L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013683Inst : IEnumerable<long>
{
public static readonly long[] Value=A013683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013683.Bytes);
public long this[int i]=>Value[i];

public static A013683Inst Instance=new A013683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013684
{
public static readonly long[] Value={ 1L,245L,3L,1L,8L,4L,2L,3L,2L,1L,1L,4L,1L,3L,12L,2L,2L,34L,1L,1L,1L,1L,4L,9L,1L,56L,3L,38L,1L,1L,6L,1L,1L,1L,1L,3L,2L,1L,1L,5L,9L,3L,1L,11L,2L,3L,1L,5L,2L,2L,1L,4L,1L,27L,2L,2L,1L,2L,1L,1L,2L,1L,1L,1L,1L,2L,72L,17L,1L,36L,1L,5L,6L,1L,4L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013684Inst : IEnumerable<long>
{
public static readonly long[] Value=A013684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013684.Bytes);
public long this[int i]=>Value[i];

public static A013684Inst Instance=new A013684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013685
{
public static readonly long[] Value={ 1L,497L,1L,10L,5L,1L,1L,8L,3L,2L,2L,1L,2L,1L,2L,5L,4L,2L,49L,1L,3L,3L,1L,1L,2L,1L,2L,30L,4L,1L,17L,3L,8L,2L,1L,2L,1L,1L,10L,6L,9L,2L,3L,1L,22L,1L,2L,1L,1L,2L,1L,1L,2L,18L,1L,1L,1L,9L,1L,2L,9L,1L,5L,2L,4L,1L,5L,1L,2L,2L,2L,6L,1L,8L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013685Inst : IEnumerable<long>
{
public static readonly long[] Value=A013685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013685.Bytes);
public long this[int i]=>Value[i];

public static A013685Inst Instance=new A013685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013686
{
public static readonly long[] Value={ 1L,1005L,2L,4L,1L,98L,7L,11L,2L,1L,1L,6L,2L,3L,28L,1L,37L,1L,2L,7L,9L,13L,85L,4L,3L,34L,5L,3L,7L,4L,7L,1L,3L,2L,1L,22L,1L,1L,1L,1L,3L,15L,1L,9L,12L,1L,3L,3L,3L,1L,3L,2L,1L,2L,1L,1L,2L,10L,8L,2L,2L,11L,54L,4L,5L,1L,2L,2L,1L,3L,2L,1L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013686Inst : IEnumerable<long>
{
public static readonly long[] Value=A013686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013686.Bytes);
public long this[int i]=>Value[i];

public static A013686Inst Instance=new A013686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013687
{
public static readonly long[] Value={ 1L,2023L,1L,1L,12L,1L,2L,2L,1L,102L,1L,44L,1L,2L,2L,1L,2L,3L,1L,5L,2L,1L,1L,2L,1L,13L,4L,14L,2L,5L,1L,5L,1L,6L,1L,2L,9L,1L,1L,1L,1L,7L,1L,2L,3L,1L,39L,3L,119L,12L,1L,1L,5L,1L,1L,151L,3L,4L,1L,2L,4L,98L,29L,6L,2L,1L,3L,9L,1L,1L,1L,5L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013687Inst : IEnumerable<long>
{
public static readonly long[] Value=A013687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013687.Bytes);
public long this[int i]=>Value[i];

public static A013687Inst Instance=new A013687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013688
{
public static readonly long[] Value={ 1L,4063L,1L,1L,1L,1L,3L,14L,4L,5L,1L,8L,3L,1L,142L,1L,2L,1L,2L,2L,24L,1L,3L,20L,1L,1L,1L,60L,4L,1L,12L,1L,1L,1L,4L,23L,12L,1L,3L,11L,1L,2L,1L,13L,3L,16L,1L,91L,2L,2L,8L,1L,1L,1L,62L,1L,7L,1L,2L,15L,2L,5L,4L,1L,8L,1L,1L,20L,2L,2L,1L,1L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013688Inst : IEnumerable<long>
{
public static readonly long[] Value=A013688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013688.Bytes);
public long this[int i]=>Value[i];

public static A013688Inst Instance=new A013688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013689
{
public static readonly long[] Value={ 1L,8149L,13L,1L,2L,1L,6L,23L,3L,1L,7L,1L,1L,5L,1L,1L,4L,1L,1L,1L,4L,1L,1L,2L,2L,8L,1L,29L,32L,22L,2L,123L,1L,2L,1L,10L,1L,2L,2L,1L,4L,1L,13L,5L,8L,34L,2L,1L,7L,1L,2L,1L,3L,20L,8L,1L,4L,1L,5L,1L,59L,3L,7L,1L,1L,3L,2L,6L,1L,1L,2L,9L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013689Inst : IEnumerable<long>
{
public static readonly long[] Value=A013689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013689.Bytes);
public long this[int i]=>Value[i];

public static A013689Inst Instance=new A013689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013690
{
public static readonly long[] Value={ 1L,16327L,36L,19L,2L,1L,35L,1L,4L,7L,5L,1L,1L,1L,3L,1L,2L,3L,2L,1L,3L,3L,1L,1L,2L,1L,3L,1L,1L,7L,1L,4L,7L,4L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,4L,9L,2L,2L,1L,23L,6L,1L,2L,1L,2L,1L,1L,10L,1L,19L,7L,1L,1L,42L,1L,15L,1L,1L,4L,1L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013690Inst : IEnumerable<long>
{
public static readonly long[] Value=A013690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013690.Bytes);
public long this[int i]=>Value[i];

public static A013690Inst Instance=new A013690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013691
{
public static readonly long[] Value={ 1L,32692L,3L,3L,1L,4L,1L,2L,3L,2L,1L,1L,1L,1L,1L,3L,1L,5L,1L,4L,1L,54L,1L,5L,5L,1L,20L,57L,5L,8L,1L,2L,26L,1L,1L,1L,1L,10L,1L,12L,1L,1L,7L,1L,2L,4L,1L,4L,1L,3L,5L,1L,1L,1L,1L,2L,4L,1L,18L,2L,2L,4L,1L,7L,4L,5L,1L,4L,2L,1L,1L,3L,1L,5L,1L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013691Inst : IEnumerable<long>
{
public static readonly long[] Value=A013691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013691.Bytes);
public long this[int i]=>Value[i];

public static A013691Inst Instance=new A013691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013692
{
public static readonly long[] Value={ 1L,65435L,2L,1L,5L,1L,4L,1L,3L,3L,1L,7L,1L,2L,6L,2L,1L,7L,1L,1L,2L,1L,4L,4L,2L,3L,13L,1L,2L,1L,5L,1L,1L,8L,1L,5L,1L,1L,1L,4L,1L,2L,2L,2L,1L,44L,1L,2L,1L,2L,4L,2L,1L,6L,153L,41L,1L,26L,1L,4L,1L,3L,3L,1L,1L,1L,5L,6L,15L,4L,7L,1L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013692Inst : IEnumerable<long>
{
public static readonly long[] Value=A013692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013692.Bytes);
public long this[int i]=>Value[i];

public static A013692Inst Instance=new A013692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013693
{
public static readonly long[] Value={ 1L,130938L,12L,2L,2L,8L,1L,6L,2L,3L,4L,2L,6L,1L,1L,7L,3L,10L,1L,5L,1L,2L,1L,2L,33L,3L,1L,4L,1L,1L,7L,5L,7L,1L,4L,1L,6L,1L,1L,2L,1L,1L,1L,5L,1L,1L,4L,1L,1L,1L,3L,1L,1L,3L,8L,2L,2L,2L,5L,5L,4L,2L,7L,2L,45L,5L,6L,2L,1L,1L,53L,1L,1L,1L,4L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013693Inst : IEnumerable<long>
{
public static readonly long[] Value=A013693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013693.Bytes);
public long this[int i]=>Value[i];

public static A013693Inst Instance=new A013693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013694
{
public static readonly long[] Value={ 1L,261965L,1L,2L,1L,1L,1L,4L,3L,4L,3L,1L,1L,2L,1L,2L,2L,1L,1L,1L,1L,1L,1L,4L,1L,3L,3L,1L,2L,5L,1L,2L,3L,6L,1L,8L,3L,9L,1L,1L,1L,2L,3L,1L,1L,2L,1L,3L,1L,1L,1L,9L,1L,1L,21L,1L,3L,1L,3L,3L,3L,1L,1L,6L,4L,3L,5L,2L,1L,1L,26L,21L,6L,1L,11L,24L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013694Inst : IEnumerable<long>
{
public static readonly long[] Value=A013694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013694.Bytes);
public long this[int i]=>Value[i];

public static A013694Inst Instance=new A013694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013695
{
public static readonly long[] Value={ 1L,524050L,1L,1L,2L,3L,1L,1L,1L,1L,3L,1L,2L,5L,14L,1L,5L,1L,3L,1L,3L,1L,3L,2L,1L,1L,1L,4L,1L,9L,1L,2L,1L,6L,2L,1L,1L,1L,76L,85L,1L,8L,1L,1L,7L,12L,7L,2L,1L,2L,4L,1L,3L,1L,22L,1L,3L,6L,1L,1L,1L,1L,1L,4L,1L,11L,1L,3L,1L,2L,1L,6L,1L,9L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013695Inst : IEnumerable<long>
{
public static readonly long[] Value=A013695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013695.Bytes);
public long this[int i]=>Value[i];

public static A013695Inst Instance=new A013695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013696
{
public static readonly long[] Value={ 1L,1048259L,1L,2L,1L,18L,3L,1L,9L,7L,1L,1L,2L,1L,13L,3L,1L,1L,1L,2L,4L,2L,10L,2L,1L,1L,2L,8L,1L,1L,1L,3L,1L,3L,9L,2L,1L,2L,1L,1L,4L,2L,2L,56L,2L,2L,1L,1L,1L,6L,5L,2L,15L,1L,5L,2L,2L,1L,5L,1L,1L,39L,1L,6L,2L,6L,1L,1L,1L,3L,24L,11L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013696Inst : IEnumerable<long>
{
public static readonly long[] Value=A013696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013696.Bytes);
public long this[int i]=>Value[i];

public static A013696Inst Instance=new A013696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013697
{
public static readonly long[] Value={ 1L,4L,12L,27L,57L,119L,245L,497L,1005L,2023L,4063L,8149L,16327L,32692L,65435L,130938L,261965L,524050L,1048259L,2096730L,4193742L,8387859L,16776218L,33553102L,67107091L,134215364L,268432305L,536866711L,1073736223L,2147476180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013697Inst : IEnumerable<long>
{
public static readonly long[] Value=A013697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013697.Bytes);
public long this[int i]=>Value[i];

public static A013697Inst Instance=new A013697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013698
{
public static readonly long[] Value={ 1L,8L,55L,364L,2380L,15504L,100947L,657800L,4292145L,28048800L,183579396L,1203322288L,7898654920L,51915526432L,341643774795L,2250829575120L,14844575908435L,97997533741800L,647520696018735L,4282083008118300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013698Inst : IEnumerable<long>
{
public static readonly long[] Value=A013698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013698.Bytes);
public long this[int i]=>Value[i];

public static A013698Inst Instance=new A013698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013699
{
public static readonly long[] Value={ 1L,32L,610L,9842L,147798L,2145600L,30664890L,435668420L,6186432967L,88066807556L,1258885297696L,18084694597452L,261164661944060L,3791317346771584L,55316720239735242L,810944384733610356L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013699Inst : IEnumerable<long>
{
public static readonly long[] Value=A013699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013699.Bytes);
public long this[int i]=>Value[i];

public static A013699Inst Instance=new A013699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013700
{
public static readonly BigInteger[] Value={ 1L,128L,6765L,265720L,9112264L,290926848L,8916942687L,266668876540L,7853149169635L,228982270335000L,6632994268595136L,191292945772217856L,5500214758962096400L,BigInteger.Parse("157819424038439232000"),BigInteger.Parse("4521902974531722618723") };
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
public class A013700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013700Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013700.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013700Inst Instance=new A013700Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013701
{
public static readonly BigInteger[] Value={ 1L,512L,75025L,7174454L,562110290L,39541748736L,2610763825782L,165745451110910L,10262482704258873L,625250747214775916L,BigInteger.Parse("37701606156514031251"),BigInteger.Parse("2258713106034310399852"),BigInteger.Parse("134810129909509070121060") };
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
public class A013701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013701Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013701.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013701Inst Instance=new A013701Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013702
{
public static readonly BigInteger[] Value={ 1L,2048L,832040L,193710244L,34673583028L,5372862566400L,763562937059280L,102703589621825280L,13319075453502743045UL,BigInteger.Parse("1684658996331320739600"),BigInteger.Parse("209381188023138094045641"),BigInteger.Parse("25698882980999585848747760") };
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
public class A013702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013702Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013702.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013702Inst Instance=new A013702Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013703
{
public static readonly BigInteger[] Value={ 1L,2L,-6L,38L,-370L,4874L,-81046L,1628710L,-38393538L,1038795658L,-31730277062L,1080038539942L,-40538501660306L,1663428036271754L,-74080097240364918L,3558651343664651174L,BigInteger.Parse("-183423140013051563746"),BigInteger.Parse("10097324775041880827402"),BigInteger.Parse("-591270189493633774009510") };
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
public class A013703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013703Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013703.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013703Inst Instance=new A013703Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013704
{
public static readonly long[] Value={ 2L,12L,44L,100L,203L,344L,558L,824L,1189L,1620L,2176L,2812L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013704Inst : IEnumerable<long>
{
public static readonly long[] Value=A013704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013704.Bytes);
public long this[int i]=>Value[i];

public static A013704Inst Instance=new A013704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013705
{
public static readonly long[] Value={ 3L,1L,4L,1L,5L,9L,0L,6L,5L,3L,5L,8L,9L,7L,9L,3L,2L,4L,0L,4L,6L,2L,6L,4L,3L,3L,8L,3L,2L,6L,9L,5L,0L,2L,8L,8L,4L,1L,9L,7L,2L,9L,1L,3L,9L,9L,3L,7L,5L,1L,0L,3L,0L,5L,0L,9L,7L,4L,9L,4L,4L,6L,9L,3L,3L,4L,9L,8L,1L,6L,4L,0L,0L,8L,8L,0L,6L,8L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013705Inst : IEnumerable<long>
{
public static readonly long[] Value=A013705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013705.Bytes);
public long this[int i]=>Value[i];

public static A013705Inst Instance=new A013705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013706
{
public static readonly long[] Value={ 1L,5L,7L,0L,7L,8L,6L,3L,2L,6L,7L,9L,4L,8L,9L,7L,6L,1L,9L,2L,3L,1L,3L,2L,1L,1L,9L,1L,6L,3L,9L,7L,5L,2L,0L,5L,2L,0L,9L,8L,5L,8L,3L,3L,1L,4L,6L,8L,7L,5L,5L,7L,9L,6L,2L,5L,8L,7L,4L,4L,5L,2L,6L,8L,5L,0L,4L,1L,0L,7L,5L,6L,4L,1L,2L,2L,1L,6L,5L,3L,4L,8L,1L,2L,3L,5L,6L,6L,2L,0L,9L,0L,5L,5L,0L,9L,7L,3L,5L,2L,6L,8L,8L,4L,3L,6L,3L,2L,7L,4L,2L,5L,0L,9L,3L,7L,0L,4L,8L,2L,5L,0L,6L,1L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013706Inst : IEnumerable<long>
{
public static readonly long[] Value=A013706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013706.Bytes);
public long this[int i]=>Value[i];

public static A013706Inst Instance=new A013706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013707
{
public static readonly long[] Value={ 6L,9L,3L,1L,3L,7L,1L,8L,0L,6L,5L,9L,9L,4L,5L,3L,0L,9L,3L,9L,7L,2L,3L,2L,1L,2L,1L,4L,7L,4L,1L,7L,6L,5L,6L,8L,0L,4L,8L,3L,0L,0L,1L,3L,4L,4L,3L,9L,6L,1L,5L,2L,5L,3L,7L,6L,6L,8L,8L,8L,0L,1L,1L,7L,3L,0L,2L,1L,9L,2L,0L,2L,9L,3L,2L,1L,2L,1L,8L,0L,5L,4L,7L,1L,2L,0L,3L,3L,9L,4L,1L,0L,7L,9L,5L,6L,9L,1L,9L,3L,2L,1L,5L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013707Inst : IEnumerable<long>
{
public static readonly long[] Value=A013707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013707.Bytes);
public long this[int i]=>Value[i];

public static A013707Inst Instance=new A013707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013708
{
public static readonly long[] Value={ 3L,27L,243L,2187L,19683L,177147L,1594323L,14348907L,129140163L,1162261467L,10460353203L,94143178827L,847288609443L,7625597484987L,68630377364883L,617673396283947L,5559060566555523L,50031545098999707L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013708Inst : IEnumerable<long>
{
public static readonly long[] Value=A013708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013708.Bytes);
public long this[int i]=>Value[i];

public static A013708Inst Instance=new A013708Inst();

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