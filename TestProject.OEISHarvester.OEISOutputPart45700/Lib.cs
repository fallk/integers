using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A053245
{
public static readonly long[] Value={ 20L,49L,56L,79L,108L,132L,145L,170L,177L,230L,253L,277L,289L,307L,347L,382L,405L,412L,424L,437L,495L,548L,585L,592L,633L,645L,704L,734L,752L,764L,789L,802L,841L,854L,930L,943L,967L,974L,1005L,1012L,1053L,1066L,1130L,1154L,1179L,1186L,1216L,1223L,1264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053245Inst : IEnumerable<long>
{
public static readonly long[] Value=A053245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053245.Bytes);
public long this[int i]=>Value[i];

public static A053245Inst Instance=new A053245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053246
{
public static readonly long[] Value={ 0L,0L,2L,-2L,5L,-5L,6L,-3L,4L,-7L,15L,-15L,9L,-1L,6L,-14L,20L,-20L,21L,-11L,3L,-13L,35L,-30L,10L,-3L,15L,-27L,41L,-41L,30L,-16L,5L,-7L,42L,-54L,21L,-5L,33L,-49L,53L,-53L,39L,-7L,-7L,-25L,75L,-68L,35L,-22L,25L,-45L,65L,-49L,47L,-41L,9L,-31L,107L,-107L,33L,7L,22L,-44L,59L,-77L,57L,-31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053246Inst : IEnumerable<long>
{
public static readonly long[] Value=A053246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053246.Bytes);
public long this[int i]=>Value[i];

public static A053246Inst Instance=new A053246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053247
{
public static readonly long[] Value={ 2L,7L,11L,7L,22L,24L,7L,34L,41L,14L,48L,40L,18L,68L,71L,21L,49L,75L,38L,102L,92L,100L,103L,47L,110L,96L,50L,138L,140L,15L,103L,134L,78L,195L,161L,6L,116L,194L,70L,182L,140L,72L,234L,178L,56L,156L,227L,76L,229L,218L,226L,276L,160L,260L,162L,26L,252L,280L,74L,224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053247Inst : IEnumerable<long>
{
public static readonly long[] Value=A053247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053247.Bytes);
public long this[int i]=>Value[i];

public static A053247Inst Instance=new A053247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053248
{
public static readonly long[] Value={ 1L,4L,10L,9L,11L,30L,10L,20L,40L,32L,16L,65L,13L,42L,82L,46L,12L,96L,26L,82L,106L,46L,18L,143L,57L,70L,114L,88L,40L,214L,26L,66L,136L,88L,120L,244L,30L,60L,160L,171L,47L,256L,36L,150L,266L,96L,40L,286L,88L,176L,226L,124L,12L,24L,342L,170L,230L,222L,94L,34L,443L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053248Inst : IEnumerable<long>
{
public static readonly long[] Value=A053248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053248.Bytes);
public long this[int i]=>Value[i];

public static A053248Inst Instance=new A053248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053249
{
public static readonly long[] Value={ 4L,4L,8L,8L,12L,8L,8L,4L,6L,12L,10L,4L,16L,12L,8L,8L,8L,12L,16L,8L,8L,16L,16L,16L,16L,8L,16L,8L,16L,4L,16L,16L,16L,12L,24L,12L,16L,8L,16L,16L,8L,16L,16L,12L,16L,16L,16L,16L,12L,12L,12L,16L,16L,40L,16L,16L,32L,12L,24L,32L,24L,16L,16L,24L,24L,4L,24L,16L,64L,24L,16L,8L,16L,16L,16L,24L,32L,32L,20L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053249Inst : IEnumerable<long>
{
public static readonly long[] Value=A053249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053249.Bytes);
public long this[int i]=>Value[i];

public static A053249Inst Instance=new A053249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053250
{
public static readonly long[] Value={ 1L,1L,0L,-1L,1L,1L,-1L,-1L,0L,2L,0L,-2L,1L,1L,-1L,-2L,1L,3L,-1L,-2L,1L,2L,-2L,-3L,1L,4L,0L,-4L,2L,3L,-2L,-4L,1L,5L,-2L,-5L,3L,5L,-3L,-5L,2L,7L,-2L,-7L,3L,6L,-4L,-8L,3L,9L,-2L,-9L,5L,9L,-5L,-10L,3L,12L,-4L,-12L,5L,11L,-6L,-13L,6L,16L,-6L,-15L,7L,15L,-8L,-17L,7L,19L,-6L,-20L,9L,19L,-10L,-22L,8L,25L,-9L,-25L,12L,25L,-12L,-27L,11L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053250Inst : IEnumerable<long>
{
public static readonly long[] Value=A053250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053250.Bytes);
public long this[int i]=>Value[i];

public static A053250Inst Instance=new A053250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053251
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,2L,3L,3L,4L,5L,5L,6L,7L,8L,9L,11L,12L,13L,16L,17L,19L,22L,24L,27L,31L,34L,37L,42L,46L,51L,57L,62L,68L,76L,83L,91L,101L,109L,120L,132L,143L,156L,171L,186L,202L,221L,239L,259L,283L,306L,331L,360L,388L,420L,455L,490L,529L,572L,616L,663L,716L,769L,827L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053251Inst : IEnumerable<long>
{
public static readonly long[] Value=A053251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053251.Bytes);
public long this[int i]=>Value[i];

public static A053251Inst Instance=new A053251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053252
{
public static readonly long[] Value={ 1L,1L,1L,0L,0L,0L,1L,1L,0L,0L,-1L,0L,1L,1L,1L,-1L,0L,0L,0L,1L,0L,0L,-1L,0L,1L,1L,1L,0L,-1L,-1L,1L,1L,0L,-1L,-1L,0L,1L,2L,1L,-1L,-1L,0L,1L,1L,0L,-1L,-2L,0L,1L,2L,1L,-1L,-1L,-1L,1L,2L,1L,-1L,-2L,-1L,2L,2L,1L,-1L,-2L,-1L,1L,2L,0L,-1L,-3L,0L,2L,3L,2L,-2L,-2L,-1L,2L,3L,0L,-2L,-3L,-1L,2L,3L,2L,-3L,-3L,-1L,2L,4L,1L,-2L,-4L,-1L,3L,4L,2L,-2L,-4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053252Inst : IEnumerable<long>
{
public static readonly long[] Value=A053252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053252.Bytes);
public long this[int i]=>Value[i];

public static A053252Inst Instance=new A053252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053253
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,10L,14L,18L,22L,29L,36L,44L,56L,68L,82L,101L,122L,146L,176L,210L,248L,296L,350L,410L,484L,566L,660L,772L,896L,1038L,1204L,1391L,1602L,1846L,2120L,2428L,2784L,3182L,3628L,4138L,4708L,5347L,6072L,6880L,7784L,8804L,9940L,11208L,12630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053253Inst : IEnumerable<long>
{
public static readonly long[] Value=A053253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053253.Bytes);
public long this[int i]=>Value[i];

public static A053253Inst Instance=new A053253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053254
{
public static readonly long[] Value={ 1L,-1L,2L,-2L,2L,-3L,4L,-4L,5L,-6L,6L,-8L,10L,-10L,12L,-14L,15L,-18L,20L,-22L,26L,-29L,32L,-36L,40L,-44L,50L,-56L,60L,-68L,76L,-82L,92L,-101L,110L,-122L,134L,-146L,160L,-176L,191L,-210L,230L,-248L,272L,-296L,320L,-350L,380L,-410L,446L,-484L,522L,-566L,612L,-660L,715L,-772L,830L,-896L,966L,-1038L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053254Inst : IEnumerable<long>
{
public static readonly long[] Value=A053254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053254.Bytes);
public long this[int i]=>Value[i];

public static A053254Inst Instance=new A053254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053255
{
public static readonly long[] Value={ 1L,-1L,0L,1L,0L,-1L,1L,-1L,0L,1L,-1L,0L,2L,-1L,-1L,1L,-1L,-1L,2L,-1L,0L,2L,-1L,-1L,2L,-2L,-1L,3L,-2L,-1L,3L,-2L,-1L,3L,-2L,-1L,4L,-3L,-1L,4L,-2L,-2L,4L,-3L,-2L,5L,-4L,-2L,6L,-3L,-2L,6L,-4L,-2L,7L,-5L,-2L,7L,-5L,-3L,8L,-6L,-3L,9L,-6L,-3L,10L,-6L,-4L,10L,-7L,-4L,12L,-8L,-4L,13L,-8L,-5L,13L,-9L,-5L,15L,-10L,-5L,16L,-11L,-6L,17L,-12L,-7L,19L,-13L,-6L,21L,-13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053255Inst : IEnumerable<long>
{
public static readonly long[] Value=A053255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053255.Bytes);
public long this[int i]=>Value[i];

public static A053255Inst Instance=new A053255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053256
{
public static readonly long[] Value={ 1L,1L,-1L,1L,0L,0L,-1L,1L,0L,1L,-2L,1L,-1L,2L,-2L,2L,-1L,1L,-3L,2L,-1L,3L,-3L,2L,-2L,3L,-4L,3L,-3L,4L,-5L,5L,-3L,5L,-7L,5L,-5L,6L,-7L,7L,-6L,7L,-9L,9L,-7L,9L,-11L,9L,-9L,11L,-13L,12L,-11L,13L,-15L,15L,-13L,16L,-19L,17L,-17L,19L,-21L,21L,-20L,22L,-26L,25L,-23L,27L,-30L,29L,-28L,32L,-35L,34L,-34L,36L,-41L,40L,-38L,44L,-48L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053256Inst : IEnumerable<long>
{
public static readonly long[] Value=A053256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053256.Bytes);
public long this[int i]=>Value[i];

public static A053256Inst Instance=new A053256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053257
{
public static readonly long[] Value={ 1L,0L,1L,-1L,1L,-1L,2L,-2L,1L,-1L,2L,-2L,2L,-2L,2L,-3L,3L,-2L,3L,-4L,4L,-4L,4L,-5L,5L,-4L,5L,-6L,6L,-6L,7L,-8L,7L,-7L,8L,-9L,10L,-9L,10L,-12L,11L,-11L,13L,-14L,14L,-15L,16L,-17L,17L,-16L,19L,-21L,20L,-21L,23L,-25L,25L,-25L,27L,-29L,30L,-30L,32L,-35L,35L,-35L,39L,-41L,41L,-43L,45L,-49L,50L,-49L,53L,-57L,58L,-59L,63L,-67L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053257Inst : IEnumerable<long>
{
public static readonly long[] Value=A053257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053257.Bytes);
public long this[int i]=>Value[i];

public static A053257Inst Instance=new A053257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053258
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,2L,2L,1L,2L,2L,1L,2L,2L,2L,2L,2L,2L,3L,2L,2L,3L,3L,3L,2L,3L,3L,3L,3L,3L,4L,4L,3L,4L,4L,3L,4L,4L,5L,4L,4L,5L,5L,5L,5L,6L,6L,5L,5L,6L,6L,6L,6L,7L,7L,7L,6L,7L,8L,7L,8L,8L,9L,9L,8L,9L,10L,9L,9L,10L,11L,10L,10L,11L,11L,11L,11L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053258Inst : IEnumerable<long>
{
public static readonly long[] Value=A053258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053258.Bytes);
public long this[int i]=>Value[i];

public static A053258Inst Instance=new A053258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053259
{
public static readonly long[] Value={ 0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,2L,1L,0L,1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,2L,2L,1L,2L,3L,2L,2L,3L,3L,2L,2L,2L,3L,3L,2L,3L,4L,2L,2L,4L,4L,3L,3L,4L,4L,4L,3L,4L,5L,4L,4L,5L,5L,4L,4L,5L,6L,5L,4L,6L,7L,5L,5L,6L,7L,6L,6L,7L,7L,7L,6L,8L,9L,7L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053259Inst : IEnumerable<long>
{
public static readonly long[] Value=A053259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053259.Bytes);
public long this[int i]=>Value[i];

public static A053259Inst Instance=new A053259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053260
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,2L,1L,2L,2L,2L,3L,3L,2L,3L,3L,3L,3L,4L,4L,4L,5L,4L,5L,5L,5L,6L,6L,6L,7L,7L,7L,8L,9L,8L,9L,10L,9L,11L,11L,11L,12L,13L,13L,14L,15L,15L,16L,17L,17L,18L,19L,19L,21L,22L,22L,24L,25L,25L,27L,28L,29L,30L,32L,32L,34L,36L,36L,39L,40L,41L,44L,45L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053260Inst : IEnumerable<long>
{
public static readonly long[] Value=A053260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053260.Bytes);
public long this[int i]=>Value[i];

public static A053260Inst Instance=new A053260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053261
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,4L,4L,4L,4L,5L,5L,5L,6L,6L,6L,7L,7L,7L,8L,8L,9L,10L,10L,10L,11L,11L,12L,13L,13L,14L,15L,16L,16L,17L,18L,19L,20L,20L,21L,23L,24L,25L,26L,27L,28L,30L,31L,32L,34L,35L,37L,39L,40L,41L,44L,45L,47L,50L,51L,53L,56L,58L,60L,63L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053261Inst : IEnumerable<long>
{
public static readonly long[] Value=A053261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053261.Bytes);
public long this[int i]=>Value[i];

public static A053261Inst Instance=new A053261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053262
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,3L,2L,3L,3L,5L,3L,6L,5L,7L,7L,9L,7L,12L,11L,13L,13L,17L,15L,21L,20L,24L,24L,29L,28L,36L,35L,40L,42L,50L,48L,58L,58L,67L,70L,80L,79L,93L,95L,106L,111L,125L,127L,145L,149L,166L,172L,191L,196L,222L,229L,250L,262L,289L,298L,330L,343L,373L,391L,427L,442L,486L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053262Inst : IEnumerable<long>
{
public static readonly long[] Value=A053262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053262.Bytes);
public long this[int i]=>Value[i];

public static A053262Inst Instance=new A053262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053263
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,4L,4L,6L,5L,7L,8L,9L,9L,12L,12L,15L,15L,18L,19L,23L,23L,27L,30L,33L,34L,41L,42L,49L,51L,57L,61L,69L,72L,81L,87L,96L,100L,113L,119L,132L,140L,153L,163L,180L,188L,208L,221L,240L,253L,278L,294L,319L,339L,366L,388L,422L,443L,481L,510L,549L,580L,626L,662L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053263Inst : IEnumerable<long>
{
public static readonly long[] Value=A053263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053263.Bytes);
public long this[int i]=>Value[i];

public static A053263Inst Instance=new A053263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053264
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,1L,1L,2L,2L,2L,3L,3L,3L,4L,4L,4L,5L,6L,6L,7L,8L,8L,10L,11L,11L,13L,14L,15L,17L,18L,19L,22L,24L,25L,28L,30L,32L,36L,39L,41L,45L,49L,52L,57L,61L,65L,71L,76L,81L,88L,94L,100L,109L,116L,123L,133L,142L,151L,163L,174L,184L,198L,211L,224L,240L,255L,271L,290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053264Inst : IEnumerable<long>
{
public static readonly long[] Value=A053264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053264.Bytes);
public long this[int i]=>Value[i];

public static A053264Inst Instance=new A053264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053265
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,3L,3L,3L,4L,4L,5L,6L,6L,7L,8L,9L,10L,11L,12L,13L,15L,16L,18L,20L,21L,24L,26L,28L,31L,34L,37L,40L,44L,47L,51L,56L,60L,65L,71L,76L,82L,89L,95L,103L,111L,119L,128L,138L,148L,158L,171L,182L,195L,210L,223L,239L,256L,273L,292L,312L,332L,354L,378L,402L,428L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053265Inst : IEnumerable<long>
{
public static readonly long[] Value=A053265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053265.Bytes);
public long this[int i]=>Value[i];

public static A053265Inst Instance=new A053265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053266
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,2L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,8L,8L,9L,10L,12L,12L,14L,15L,17L,18L,20L,21L,25L,26L,29L,31L,35L,36L,41L,43L,48L,51L,56L,59L,66L,70L,76L,81L,89L,94L,103L,109L,119L,126L,137L,144L,158L,167L,180L,191L,207L,218L,236L,250L,269L,285L,306L,323L,349L,368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053266Inst : IEnumerable<long>
{
public static readonly long[] Value=A053266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053266.Bytes);
public long this[int i]=>Value[i];

public static A053266Inst Instance=new A053266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053267
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,1L,1L,2L,1L,2L,2L,3L,2L,4L,3L,4L,4L,5L,5L,7L,6L,8L,8L,9L,9L,12L,11L,14L,14L,16L,16L,20L,19L,23L,24L,27L,27L,32L,32L,37L,38L,43L,44L,51L,51L,58L,61L,67L,69L,78L,80L,89L,93L,102L,106L,118L,121L,134L,140L,153L,159L,175L,181L,198L,207L,224L,234L,256L,265L,288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053267Inst : IEnumerable<long>
{
public static readonly long[] Value=A053267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053267.Bytes);
public long this[int i]=>Value[i];

public static A053267Inst Instance=new A053267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053268
{
public static readonly long[] Value={ 1L,-1L,2L,-1L,1L,-3L,3L,-3L,4L,-4L,6L,-6L,5L,-9L,11L,-10L,11L,-15L,17L,-16L,19L,-22L,26L,-29L,29L,-36L,42L,-42L,46L,-55L,60L,-64L,71L,-79L,90L,-95L,101L,-117L,131L,-137L,148L,-169L,184L,-195L,211L,-234L,258L,-276L,295L,-327L,360L,-379L,409L,-453L,489L,-522L,563L,-612L,666L,-710L,757L,-829L,898L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053268Inst : IEnumerable<long>
{
public static readonly long[] Value=A053268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053268.Bytes);
public long this[int i]=>Value[i];

public static A053268Inst Instance=new A053268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053269
{
public static readonly long[] Value={ 0L,1L,-1L,1L,-2L,3L,-2L,2L,-4L,5L,-5L,5L,-7L,9L,-8L,9L,-12L,14L,-15L,16L,-20L,23L,-23L,25L,-31L,36L,-37L,40L,-47L,54L,-56L,60L,-71L,79L,-84L,91L,-103L,115L,-121L,131L,-149L,164L,-174L,188L,-210L,232L,-245L,264L,-294L,321L,-343L,368L,-406L,443L,-470L,505L,-554L,602L,-641L,687L,-751L,813L,-863L,925L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053269Inst : IEnumerable<long>
{
public static readonly long[] Value=A053269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053269.Bytes);
public long this[int i]=>Value[i];

public static A053269Inst Instance=new A053269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053270
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,11L,14L,18L,24L,30L,38L,47L,58L,72L,88L,108L,130L,156L,188L,225L,268L,318L,376L,444L,522L,612L,716L,834L,972L,1129L,1308L,1512L,1744L,2010L,2310L,2652L,3038L,3474L,3968L,4524L,5152L,5857L,6650L,7542L,8540L,9660L,10912L,12312L,13878L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053270Inst : IEnumerable<long>
{
public static readonly long[] Value=A053270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053270.Bytes);
public long this[int i]=>Value[i];

public static A053270Inst Instance=new A053270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053271
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,3L,5L,7L,8L,11L,14L,17L,22L,28L,33L,41L,51L,60L,74L,89L,105L,127L,151L,177L,210L,248L,289L,340L,398L,461L,537L,624L,719L,832L,960L,1101L,1267L,1453L,1660L,1899L,2167L,2465L,2807L,3190L,3614L,4097L,4638L,5237L,5915L,6671L,7507L,8450L,9498L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053271Inst : IEnumerable<long>
{
public static readonly long[] Value=A053271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053271.Bytes);
public long this[int i]=>Value[i];

public static A053271Inst Instance=new A053271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053272
{
public static readonly long[] Value={ 1L,-1L,3L,-5L,6L,-7L,11L,-16L,18L,-21L,30L,-40L,47L,-56L,72L,-92L,108L,-125L,156L,-193L,225L,-263L,318L,-383L,444L,-513L,612L,-724L,834L,-963L,1129L,-1320L,1512L,-1730L,2010L,-2325L,2652L,-3022L,3474L,-3988L,4524L,-5129L,5857L,-6673L,7542L,-8515L,9660L,-10943L,12312L,-13842L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053272Inst : IEnumerable<long>
{
public static readonly long[] Value=A053272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053272.Bytes);
public long this[int i]=>Value[i];

public static A053272Inst Instance=new A053272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053273
{
public static readonly long[] Value={ 1L,2L,-3L,4L,-4L,6L,-11L,14L,-15L,22L,-31L,34L,-41L,56L,-69L,82L,-98L,120L,-152L,178L,-204L,254L,-308L,354L,-415L,496L,-587L,680L,-785L,922L,-1084L,1248L,-1427L,1664L,-1935L,2202L,-2517L,2906L,-3336L,3798L,-4315L,4930L,-5636L,6380L,-7202L,8194L,-9305L,10474L,-11801L,13342L,-15050L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053273Inst : IEnumerable<long>
{
public static readonly long[] Value=A053273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053273.Bytes);
public long this[int i]=>Value[i];

public static A053273Inst Instance=new A053273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053274
{
public static readonly long[] Value={ 1L,1L,-1L,0L,2L,-2L,-1L,3L,-2L,0L,3L,-4L,-1L,5L,-3L,-1L,6L,-6L,-2L,7L,-6L,0L,9L,-8L,-3L,11L,-9L,-2L,13L,-13L,-3L,17L,-12L,-3L,19L,-18L,-5L,22L,-19L,-3L,27L,-24L,-7L,33L,-26L,-5L,36L,-34L,-9L,44L,-35L,-9L,51L,-45L,-11L,58L,-49L,-9L,68L,-59L,-16L,78L,-65L,-15L,88L,-79L,-19L,104L,-84L,-19L,117L,-102L,-26L,133L,-112L,-24L,152L,-131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053274Inst : IEnumerable<long>
{
public static readonly long[] Value=A053274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053274.Bytes);
public long this[int i]=>Value[i];

public static A053274Inst Instance=new A053274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053275
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,0L,2L,1L,2L,1L,2L,1L,3L,2L,3L,3L,3L,2L,5L,3L,5L,4L,6L,5L,7L,5L,7L,7L,9L,7L,11L,9L,11L,11L,13L,12L,15L,13L,17L,16L,19L,17L,23L,21L,24L,23L,27L,26L,32L,29L,34L,34L,38L,37L,44L,42L,48L,48L,54L,52L,60L,58L,66L,67L,73L,72L,82L,81L,90L,90L,100L,99L,111L,110L,121L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053275Inst : IEnumerable<long>
{
public static readonly long[] Value=A053275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053275.Bytes);
public long this[int i]=>Value[i];

public static A053275Inst Instance=new A053275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053276
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,2L,2L,2L,3L,3L,2L,4L,4L,4L,4L,6L,5L,6L,6L,7L,8L,9L,8L,10L,11L,11L,12L,14L,13L,16L,16L,18L,19L,21L,20L,24L,25L,26L,28L,31L,31L,35L,36L,39L,41L,45L,45L,50L,53L,55L,58L,64L,65L,71L,73L,79L,83L,89L,90L,99L,103L,109L,114L,123L,126L,135L,141L,149L,157L,167L,171L,185L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053276Inst : IEnumerable<long>
{
public static readonly long[] Value=A053276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053276.Bytes);
public long this[int i]=>Value[i];

public static A053276Inst Instance=new A053276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053277
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,3L,2L,3L,3L,4L,4L,5L,4L,6L,5L,7L,7L,8L,8L,10L,9L,11L,11L,13L,13L,16L,15L,17L,18L,21L,20L,23L,23L,27L,27L,31L,31L,35L,35L,39L,41L,45L,45L,51L,51L,57L,59L,64L,66L,73L,74L,81L,83L,91L,93L,102L,104L,113L,117L,126L,130L,141L,144L,156L,162L,174L,178L,192L,198L,212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053277Inst : IEnumerable<long>
{
public static readonly long[] Value=A053277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053277.Bytes);
public long this[int i]=>Value[i];

public static A053277Inst Instance=new A053277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053278
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,3L,3L,4L,4L,4L,4L,5L,5L,6L,6L,7L,7L,8L,8L,9L,10L,11L,11L,13L,13L,14L,15L,16L,17L,19L,19L,21L,22L,24L,25L,28L,29L,31L,32L,35L,36L,40L,41L,44L,46L,49L,51L,56L,58L,62L,65L,69L,72L,77L,80L,86L,90L,95L,99L,106L,110L,117L,122L,130L,135L,144L,149L,158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053278Inst : IEnumerable<long>
{
public static readonly long[] Value=A053278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053278.Bytes);
public long this[int i]=>Value[i];

public static A053278Inst Instance=new A053278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053279
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,3L,2L,3L,2L,3L,3L,4L,3L,4L,4L,5L,5L,6L,5L,7L,6L,8L,7L,9L,8L,10L,10L,11L,11L,13L,12L,15L,14L,17L,16L,19L,18L,21L,21L,23L,23L,27L,26L,30L,29L,33L,33L,37L,36L,41L,41L,46L,46L,51L,51L,56L,57L,62L,63L,69L,69L,77L,77L,84L,85L,93L,94L,102L,104L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053279Inst : IEnumerable<long>
{
public static readonly long[] Value=A053279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053279.Bytes);
public long this[int i]=>Value[i];

public static A053279Inst Instance=new A053279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053280
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,2L,1L,2L,2L,2L,2L,3L,2L,3L,3L,3L,3L,5L,4L,4L,5L,6L,5L,6L,6L,7L,7L,8L,8L,10L,9L,10L,11L,12L,11L,14L,13L,15L,16L,17L,17L,20L,19L,21L,22L,24L,24L,27L,27L,30L,31L,33L,34L,38L,37L,41L,43L,46L,46L,51L,52L,56L,58L,62L,63L,69L,70L,75L,78L,83L,85L,92L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053280Inst : IEnumerable<long>
{
public static readonly long[] Value=A053280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053280.Bytes);
public long this[int i]=>Value[i];

public static A053280Inst Instance=new A053280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053281
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,4L,6L,7L,8L,10L,12L,14L,16L,20L,22L,26L,31L,34L,40L,46L,52L,60L,68L,76L,87L,98L,110L,124L,140L,156L,174L,196L,216L,242L,270L,298L,332L,368L,406L,449L,496L,546L,602L,664L,728L,800L,880L,962L,1056L,1156L,1262L,1381L,1508L,1644L,1794L,1956L,2128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053281Inst : IEnumerable<long>
{
public static readonly long[] Value=A053281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053281.Bytes);
public long this[int i]=>Value[i];

public static A053281Inst Instance=new A053281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053282
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,2L,4L,4L,4L,6L,7L,8L,10L,11L,12L,16L,18L,20L,24L,26L,30L,36L,40L,44L,52L,58L,64L,74L,82L,91L,104L,116L,128L,144L,159L,176L,198L,218L,240L,268L,294L,324L,360L,394L,432L,478L,524L,572L,630L,688L,752L,826L,900L,980L,1072L,1168L,1270L,1386L,1505L,1634L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053282Inst : IEnumerable<long>
{
public static readonly long[] Value=A053282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053282.Bytes);
public long this[int i]=>Value[i];

public static A053282Inst Instance=new A053282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053283
{
public static readonly long[] Value={ 1L,-1L,1L,0L,1L,-2L,1L,-1L,1L,-2L,3L,-1L,2L,-4L,3L,-2L,3L,-5L,4L,-4L,5L,-6L,7L,-5L,6L,-9L,9L,-7L,9L,-12L,11L,-11L,12L,-15L,16L,-14L,16L,-21L,20L,-18L,22L,-25L,26L,-25L,28L,-33L,34L,-33L,35L,-42L,43L,-41L,47L,-53L,53L,-54L,57L,-65L,69L,-67L,73L,-83L,85L,-83L,92L,-102L,104L,-106L,114L,-125L,130L,-130L,139L,-154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053283Inst : IEnumerable<long>
{
public static readonly long[] Value=A053283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053283.Bytes);
public long this[int i]=>Value[i];

public static A053283Inst Instance=new A053283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053284
{
public static readonly long[] Value={ 0L,1L,-1L,1L,-2L,2L,-1L,2L,-3L,3L,-3L,3L,-4L,4L,-4L,5L,-6L,7L,-6L,7L,-9L,8L,-8L,10L,-12L,13L,-13L,13L,-16L,17L,-16L,19L,-21L,22L,-23L,25L,-28L,29L,-30L,33L,-37L,39L,-39L,42L,-48L,49L,-50L,55L,-60L,64L,-66L,70L,-77L,81L,-82L,89L,-97L,101L,-105L,112L,-121L,126L,-131L,140L,-151L,159L,-163L,173L,-187L,194L,-202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053284Inst : IEnumerable<long>
{
public static readonly long[] Value=A053284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053284.Bytes);
public long this[int i]=>Value[i];

public static A053284Inst Instance=new A053284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053285
{
public static readonly long[] Value={ 1L,2L,4L,6L,16L,20L,48L,84L,256L,324L,800L,1364L,3840L,5460L,12544L,19800L,65536L,87380L,186624L,349524L,986880L,1365336L,3345408L,5592404L,16515072L,20250000L,52306176L,84768120L,252645120L,351847488L,760320000L,1431655764L,4288266240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053285Inst : IEnumerable<long>
{
public static readonly long[] Value=A053285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053285.Bytes);
public long this[int i]=>Value[i];

public static A053285Inst Instance=new A053285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053286
{
public static readonly long[] Value={ 1L,1L,3L,1L,13L,17L,45L,1L,189L,225L,685L,257L,2733L,3841L,12969L,1L,43693L,75521L,174765L,61697L,731817L,848897L,2796205L,262145L,13304433L,14802689L,49449609L,15790337L,185023425L,313421825L,715827885L,6701057L,2957312961L,3551128577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053286Inst : IEnumerable<long>
{
public static readonly long[] Value=A053286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053286.Bytes);
public long this[int i]=>Value[i];

public static A053286Inst Instance=new A053286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053287
{
public static readonly long[] Value={ 1L,2L,6L,8L,30L,36L,126L,128L,432L,600L,1936L,1728L,8190L,10584L,27000L,32768L,131070L,139968L,524286L,480000L,1778112L,2640704L,8210080L,6635520L,32400000L,44717400L,113467392L,132765696L,533826432L,534600000L,2147483646L,2147483648L,6963536448L,11452896600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053287Inst : IEnumerable<long>
{
public static readonly long[] Value=A053287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053287.Bytes);
public long this[int i]=>Value[i];

public static A053287Inst Instance=new A053287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053288
{
public static readonly long[] Value={ 0L,1L,1L,7L,1L,27L,1L,127L,79L,423L,111L,2367L,1L,5799L,5767L,32767L,1L,122175L,1L,568575L,319039L,1553599L,178527L,10141695L,1154431L,22391463L,20750335L,135669759L,3044479L,539141823L,1L,2147483647L,1626398143L,5726972583L,1835106367L,42598088703L,616318399L,91627367079L,84561979327L,625809227775L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053288Inst : IEnumerable<long>
{
public static readonly long[] Value=A053288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053288.Bytes);
public long this[int i]=>Value[i];

public static A053288Inst Instance=new A053288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053289
{
public static readonly long[] Value={ 3L,4L,1L,7L,9L,2L,5L,4L,13L,15L,17L,19L,21L,4L,3L,16L,25L,27L,20L,9L,18L,13L,33L,35L,19L,18L,39L,41L,43L,28L,17L,47L,49L,51L,53L,55L,57L,59L,61L,39L,24L,65L,67L,69L,71L,35L,38L,75L,77L,79L,81L,47L,36L,85L,87L,89L,23L,68L,71L,10L,12L,95L,97L,99L,101L,103L,40L,65L,107L,109L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053289Inst : IEnumerable<long>
{
public static readonly long[] Value=A053289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053289.Bytes);
public long this[int i]=>Value[i];

public static A053289Inst Instance=new A053289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053290
{
public static readonly BigInteger[] Value={ 1L,2L,48L,11232L,24261120L,475566474240L,84129611558952960L,BigInteger.Parse("134068444202678083338240"),BigInteger.Parse("1923442429811445711790394572800"),BigInteger.Parse("248381049201184165590947520186915225600") };
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
public class A053290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053290Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053290.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053290Inst Instance=new A053290Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053291
{
public static readonly BigInteger[] Value={ 1L,3L,180L,181440L,2961100800L,775476766310400L,BigInteger.Parse("3251791214634074112000"),BigInteger.Parse("218210695042457748180566016000"),BigInteger.Parse("234298374547168764346587444978647040000") };
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
public class A053291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053291Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053291.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053291Inst Instance=new A053291Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053292
{
public static readonly BigInteger[] Value={ 1L,4L,480L,1488000L,116064000000L,226614960000000000L,BigInteger.Parse("11064475422000000000000000"),BigInteger.Parse("13506266841692625000000000000000000"),BigInteger.Parse("412177498341354683437500000000000000000000000") };
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
public class A053292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053292Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053292.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053292Inst Instance=new A053292Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053293
{
public static readonly BigInteger[] Value={ 1L,6L,2016L,33784128L,27811094169600L,BigInteger.Parse("1122211189922928537600"),BigInteger.Parse("2218959336124989671614429593600"),BigInteger.Parse("214992513152176999576908105619651923148800") };
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
public class A053293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053293Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053293.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053293Inst Instance=new A053293Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053294
{
public static readonly BigInteger[] Value={ 1L,1L,2L,9L,170L,57978L,6722955416L,BigInteger.Parse("90396259057770600841") };
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
public class A053294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053294Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053294.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053294Inst Instance=new A053294Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053295
{
public static readonly long[] Value={ 1L,7L,29L,92L,247L,591L,1300L,2683L,5270L,9955L,18228L,32551L,56967L,98086L,166681L,280271L,467301L,773906L,1274856L,2091266L,3419252L,5576298L,9076280L,14750858L,23945893L,38839257L,62955061L,101995694L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053295Inst : IEnumerable<long>
{
public static readonly long[] Value=A053295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053295.Bytes);
public long this[int i]=>Value[i];

public static A053295Inst Instance=new A053295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053296
{
public static readonly long[] Value={ 1L,8L,37L,129L,376L,967L,2267L,4950L,10220L,20175L,38403L,70954L,127921L,226007L,392688L,672959L,1140260L,1914166L,3189022L,5280288L,8699540L,14275838L,23352118L,38102976L,62048869L,100888126L,163843187L,265838881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053296Inst : IEnumerable<long>
{
public static readonly long[] Value=A053296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053296.Bytes);
public long this[int i]=>Value[i];

public static A053296Inst Instance=new A053296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053297
{
public static readonly long[] Value={ 1L,5L,22L,92L,372L,1468L,5688L,21728L,82064L,307088L,1140320L,4206912L,15434048L,56350912L,204875648L,742104064L,2679197952L,9644109056L,34623075840L,124001176576L,443136848896L,1580464036864L,5626501838848L,19996918849536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053297Inst : IEnumerable<long>
{
public static readonly long[] Value=A053297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053297.Bytes);
public long this[int i]=>Value[i];

public static A053297Inst Instance=new A053297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053298
{
public static readonly long[] Value={ 1L,8L,34L,107L,281L,654L,1397L,2801L,5353L,9859L,17643L,30869L,53062L,89951L,150833L,250780L,414210L,680665L,1114160L,1818310L,2960806L,4813018L,7814074L,12674542L,20544191L,33283434L,53902532L,87272241L,141273663L,228658744L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053298Inst : IEnumerable<long>
{
public static readonly long[] Value=A053298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053298.Bytes);
public long this[int i]=>Value[i];

public static A053298Inst Instance=new A053298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053299
{
public static readonly long[] Value={ 2L,23L,139L,1831L,30593L,162143L,1100977L,10343761L,147684137L,1202442089L,12109172293L,156798792223L,1051602787181L,20761252261751L,110526670235599L,1271309838631957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053299Inst : IEnumerable<long>
{
public static readonly long[] Value=A053299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053299.Bytes);
public long this[int i]=>Value[i];

public static A053299Inst Instance=new A053299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053300
{
public static readonly long[] Value={ 1L,1L,1L,3L,31L,1L,145L,1L,4L,2L,8L,1L,6L,1L,2L,3L,1L,4L,1L,5L,1L,41L,1L,2L,3L,7L,1L,1L,1L,27L,1L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,49L,2L,1L,4L,3L,6L,2L,1L,3L,3L,17L,1L,3L,2L,1L,6L,3L,1L,6L,26L,3L,1L,1L,3L,4L,3L,2L,14L,11L,1L,4L,1L,1L,5L,2L,8L,8L,2L,80L,1L,1L,22L,2L,11L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053300Inst : IEnumerable<long>
{
public static readonly long[] Value=A053300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053300.Bytes);
public long this[int i]=>Value[i];

public static A053300Inst Instance=new A053300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053301
{
public static readonly long[] Value={ 1L,6L,10L,16L,38L,66L,94L,142L,186L,254L,316L,388L,482L,590L,688L,796L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053301Inst : IEnumerable<long>
{
public static readonly long[] Value=A053301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053301.Bytes);
public long this[int i]=>Value[i];

public static A053301Inst Instance=new A053301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053302
{
public static readonly long[] Value={ 7L,89L,887L,9551L,31397L,492113L,4652353L,47326693L,436273009L,4302407359L,42652618343L,738832927927L,7177162611713L,90874329411493L,218209405436543L,1693182318746371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053302Inst : IEnumerable<long>
{
public static readonly long[] Value=A053302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053302.Bytes);
public long this[int i]=>Value[i];

public static A053302Inst Instance=new A053302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053303
{
public static readonly long[] Value={ 4L,8L,20L,36L,72L,114L,154L,220L,282L,354L,464L,540L,674L,804L,906L,1132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053303Inst : IEnumerable<long>
{
public static readonly long[] Value=A053303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053303.Bytes);
public long this[int i]=>Value[i];

public static A053303Inst Instance=new A053303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053304
{
public static readonly long[] Value={ 1L,1L,3L,6L,16L,34L,90L,211L,515L,1229L,2960L,6893L,15753L,34450L,72235L,143477L,269186L,473945L,781713L,1203617L,1728192L,2310376L,2874232L,3325215L,3576980L,3576980L,3325215L,2874232L,2310376L,1728192L,1203617L,781713L,473945L,269186L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053304Inst : IEnumerable<long>
{
public static readonly long[] Value=A053304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053304.Bytes);
public long this[int i]=>Value[i];

public static A053304Inst Instance=new A053304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053305
{
public static readonly long[] Value={ 1L,1L,3L,6L,16L,34L,90L,211L,558L,1371L,3601L,9209L,24110L,61740L,157559L,390832L,946490L,2206364L,4948194L,10591141L,21606125L,41821936L,76738813L,133157386L,218402867L,338187004L,494330780L,681660841L,886842587L,1088201827L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053305Inst : IEnumerable<long>
{
public static readonly long[] Value=A053305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053305.Bytes);
public long this[int i]=>Value[i];

public static A053305Inst Instance=new A053305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053306
{
public static readonly long[] Value={ 2L,4L,4L,5L,5L,4L,4L,4L,4L,3L,4L,4L,5L,7L,6L,8L,8L,8L,8L,5L,7L,9L,9L,10L,10L,9L,9L,9L,9L,6L,9L,11L,11L,12L,12L,11L,11L,11L,11L,7L,10L,12L,12L,13L,13L,12L,12L,12L,12L,9L,12L,14L,14L,15L,15L,14L,14L,14L,14L,7L,10L,12L,12L,13L,13L,12L,12L,12L,12L,7L,10L,12L,12L,13L,13L,12L,12L,12L,12L,7L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053306Inst : IEnumerable<long>
{
public static readonly long[] Value=A053306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053306.Bytes);
public long this[int i]=>Value[i];

public static A053306Inst Instance=new A053306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053307
{
public static readonly long[] Value={ 1L,1L,4L,5L,11L,14L,24L,30L,45L,55L,76L,91L,119L,140L,176L,204L,249L,285L,340L,385L,451L,506L,584L,650L,741L,819L,924L,1015L,1135L,1240L,1376L,1496L,1649L,1785L,1956L,2109L,2299L,2470L,2680L,2870L,3101L,3311L,3564L,3795L,4071L,4324L,4624L,4900L,5225L,5525L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053307Inst : IEnumerable<long>
{
public static readonly long[] Value=A053307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053307.Bytes);
public long this[int i]=>Value[i];

public static A053307Inst Instance=new A053307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053308
{
public static readonly long[] Value={ 1L,9L,46L,175L,551L,1518L,3785L,8735L,18955L,39130L,77533L,148487L,276408L,502415L,895103L,1568062L,2708322L,4622488L,7811510L,13091798L,21791338L,36067176L,59419294L,97522270L,159571139L,260459265L,424302452L,690141333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053308Inst : IEnumerable<long>
{
public static readonly long[] Value=A053308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053308.Bytes);
public long this[int i]=>Value[i];

public static A053308Inst Instance=new A053308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053309
{
public static readonly long[] Value={ 1L,10L,56L,231L,782L,2300L,6085L,14820L,33775L,72905L,150438L,298925L,575333L,1077748L,1972851L,3540913L,6249235L,10871723L,18683233L,31775031L,53566369L,89633545L,149052839L,246575109L,406146248L,666605513L,1090907965L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053309Inst : IEnumerable<long>
{
public static readonly long[] Value=A053309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053309.Bytes);
public long this[int i]=>Value[i];

public static A053309Inst Instance=new A053309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053310
{
public static readonly long[] Value={ 1L,12L,75L,330L,1155L,3432L,9009L,21450L,47190L,97240L,189618L,352716L,629850L,1085280L,1812030L,2941884L,4657983L,7210500L,10935925L,16280550L,23828805L,34337160L,48774375L,68368950L,94664700L,129585456L,175509972L,235358200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053310Inst : IEnumerable<long>
{
public static readonly long[] Value=A053310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053310.Bytes);
public long this[int i]=>Value[i];

public static A053310Inst Instance=new A053310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053311
{
public static readonly long[] Value={ 1L,5L,10L,19L,33L,56L,93L,153L,250L,407L,661L,1072L,1737L,2813L,4554L,7371L,11929L,19304L,31237L,50545L,81786L,132335L,214125L,346464L,560593L,907061L,1467658L,2374723L,3842385L,6217112L,10059501L,16276617L,26336122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053311Inst : IEnumerable<long>
{
public static readonly long[] Value=A053311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053311.Bytes);
public long this[int i]=>Value[i];

public static A053311Inst Instance=new A053311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053312
{
public static readonly ulong[] Value={ 2L,12L,112L,2112L,22112L,122112L,2122112L,12122112L,212122112L,1212122112L,11212122112L,111212122112L,1111212122112L,11111212122112L,211111212122112L,1211111212122112L,11211111212122112L,111211111212122112L,2111211111212122112L,12111211111212122112UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053312Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A053312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053312.Bytes);
public ulong this[int i]=>Value[i];

public static A053312Inst Instance=new A053312Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053313
{
public static readonly long[] Value={ 2L,92L,992L,2992L,92992L,292992L,2292992L,22292992L,222292992L,2222292992L,22222292992L,922222292992L,9922222292992L,29922222292992L,929922222292992L,9929922222292992L,99929922222292992L,999929922222292992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053313Inst : IEnumerable<long>
{
public static readonly long[] Value=A053313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053313.Bytes);
public long this[int i]=>Value[i];

public static A053313Inst Instance=new A053313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053314
{
public static readonly long[] Value={ 4L,44L,144L,4144L,14144L,414144L,1414144L,41414144L,441414144L,1441414144L,11441414144L,411441414144L,4411441414144L,44411441414144L,444411441414144L,1444411441414144L,41444411441414144L,441444411441414144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053314Inst : IEnumerable<long>
{
public static readonly long[] Value=A053314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053314.Bytes);
public long this[int i]=>Value[i];

public static A053314Inst Instance=new A053314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053315
{
public static readonly long[] Value={ 4L,44L,544L,4544L,44544L,444544L,4444544L,54444544L,454444544L,5454444544L,45454444544L,545454444544L,5545454444544L,55545454444544L,555545454444544L,4555545454444544L,44555545454444544L,544555545454444544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053315Inst : IEnumerable<long>
{
public static readonly long[] Value=A053315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053315.Bytes);
public long this[int i]=>Value[i];

public static A053315Inst Instance=new A053315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053316
{
public static readonly long[] Value={ 2L,32L,232L,3232L,23232L,223232L,2223232L,32223232L,232223232L,3232223232L,23232223232L,323232223232L,3323232223232L,23323232223232L,323323232223232L,3323323232223232L,33323323232223232L,333323323232223232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053316Inst : IEnumerable<long>
{
public static readonly long[] Value=A053316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053316.Bytes);
public long this[int i]=>Value[i];

public static A053316Inst Instance=new A053316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053317
{
public static readonly long[] Value={ 2L,52L,552L,5552L,55552L,255552L,5255552L,55255552L,255255552L,2255255552L,22255255552L,222255255552L,5222255255552L,55222255255552L,255222255255552L,2255222255255552L,22255222255255552L,222255222255255552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053317Inst : IEnumerable<long>
{
public static readonly long[] Value=A053317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053317.Bytes);
public long this[int i]=>Value[i];

public static A053317Inst Instance=new A053317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053318
{
public static readonly long[] Value={ 2L,72L,272L,2272L,22272L,222272L,7222272L,27222272L,727222272L,2727222272L,72727222272L,772727222272L,7772727222272L,77772727222272L,277772727222272L,2277772727222272L,72277772727222272L,272277772727222272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053318Inst : IEnumerable<long>
{
public static readonly long[] Value=A053318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053318.Bytes);
public long this[int i]=>Value[i];

public static A053318Inst Instance=new A053318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053319
{
public static readonly long[] Value={ 2L,6L,6L,12L,12L,18L,12L,30L,6L,30L,12L,30L,12L,6L,30L,12L,30L,12L,30L,36L,72L,12L,30L,60L,48L,30L,18L,24L,18L,150L,12L,6L,30L,24L,138L,12L,18L,12L,30L,60L,78L,48L,12L,12L,18L,108L,24L,30L,6L,120L,12L,48L,30L,24L,66L,84L,6L,54L,18L,48L,30L,54L,6L,24L,18L,12L,96L,30L,42L,30L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053319Inst : IEnumerable<long>
{
public static readonly long[] Value=A053319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053319.Bytes);
public long this[int i]=>Value[i];

public static A053319Inst Instance=new A053319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053320
{
public static readonly long[] Value={ 4L,6L,6L,18L,6L,24L,12L,18L,6L,6L,18L,36L,30L,30L,6L,48L,30L,6L,36L,30L,18L,42L,18L,6L,24L,12L,114L,30L,30L,66L,18L,12L,54L,30L,6L,18L,6L,24L,30L,30L,42L,78L,6L,120L,66L,18L,6L,120L,6L,18L,36L,6L,60L,18L,12L,18L,12L,54L,30L,90L,84L,6L,120L,6L,84L,54L,66L,36L,30L,24L,54L,30L,12L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053320Inst : IEnumerable<long>
{
public static readonly long[] Value=A053320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053320.Bytes);
public long this[int i]=>Value[i];

public static A053320Inst Instance=new A053320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053321
{
public static readonly long[] Value={ 8L,16L,6L,8L,12L,10L,48L,20L,6L,10L,6L,60L,18L,6L,6L,8L,60L,22L,14L,6L,10L,50L,10L,60L,38L,16L,6L,8L,16L,6L,8L,6L,40L,6L,24L,50L,6L,18L,190L,6L,24L,6L,14L,22L,20L,30L,34L,6L,14L,6L,58L,6L,30L,6L,8L,52L,8L,30L,40L,6L,66L,20L,40L,50L,10L,48L,12L,8L,36L,84L,6L,6L,24L,84L,40L,6L,66L,14L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053321Inst : IEnumerable<long>
{
public static readonly long[] Value=A053321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053321.Bytes);
public long this[int i]=>Value[i];

public static A053321Inst Instance=new A053321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053322
{
public static readonly long[] Value={ 270L,30L,12L,48L,30L,12L,192L,18L,18L,24L,18L,150L,18L,54L,126L,54L,30L,180L,66L,84L,36L,12L,162L,90L,156L,24L,150L,60L,30L,30L,186L,72L,78L,54L,36L,42L,102L,36L,30L,102L,30L,168L,12L,228L,42L,132L,78L,18L,162L,408L,60L,234L,168L,192L,108L,120L,18L,210L,174L,120L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053322Inst : IEnumerable<long>
{
public static readonly long[] Value=A053322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053322.Bytes);
public long this[int i]=>Value[i];

public static A053322Inst Instance=new A053322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053323
{
public static readonly long[] Value={ 42L,60L,42L,54L,72L,12L,126L,30L,54L,60L,18L,78L,24L,18L,90L,102L,18L,12L,102L,18L,78L,150L,72L,156L,72L,24L,78L,78L,138L,12L,24L,36L,54L,378L,126L,72L,12L,36L,120L,30L,84L,108L,252L,156L,30L,24L,12L,126L,60L,54L,30L,348L,18L,12L,12L,18L,12L,54L,12L,24L,120L,180L,198L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053323Inst : IEnumerable<long>
{
public static readonly long[] Value=A053323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053323.Bytes);
public long this[int i]=>Value[i];

public static A053323Inst Instance=new A053323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053324
{
public static readonly long[] Value={ 12L,256L,42L,110L,42L,136L,200L,204L,36L,70L,152L,40L,12L,20L,178L,80L,22L,78L,180L,30L,198L,102L,48L,132L,42L,156L,150L,122L,18L,102L,22L,68L,72L,16L,152L,60L,100L,272L,58L,90L,20L,298L,12L,140L,130L,12L,110L,76L,42L,120L,48L,110L,64L,158L,88L,320L,100L,174L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053324Inst : IEnumerable<long>
{
public static readonly long[] Value=A053324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053324.Bytes);
public long this[int i]=>Value[i];

public static A053324Inst Instance=new A053324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053325
{
public static readonly long[] Value={ 180L,24L,456L,66L,24L,90L,456L,174L,264L,192L,318L,66L,210L,120L,66L,120L,84L,570L,84L,102L,54L,30L,276L,354L,324L,72L,84L,180L,156L,24L,336L,270L,114L,666L,324L,150L,90L,324L,96L,24L,126L,186L,108L,126L,24L,150L,162L,528L,186L,54L,120L,90L,300L,456L,120L,150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053325Inst : IEnumerable<long>
{
public static readonly long[] Value=A053325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053325.Bytes);
public long this[int i]=>Value[i];

public static A053325Inst Instance=new A053325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053326
{
public static readonly long[] Value={ 102L,180L,108L,30L,342L,210L,318L,252L,18L,42L,210L,414L,54L,456L,54L,402L,258L,342L,258L,756L,126L,78L,42L,450L,84L,576L,588L,66L,366L,228L,420L,246L,366L,240L,354L,90L,240L,156L,150L,198L,510L,246L,96L,828L,156L,60L,36L,870L,180L,114L,54L,660L,600L,522L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053326Inst : IEnumerable<long>
{
public static readonly long[] Value=A053326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053326.Bytes);
public long this[int i]=>Value[i];

public static A053326Inst Instance=new A053326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053327
{
public static readonly long[] Value={ 546L,190L,122L,378L,154L,248L,342L,358L,942L,86L,270L,214L,50L,40L,140L,100L,30L,326L,150L,274L,528L,218L,222L,78L,52L,38L,540L,192L,42L,40L,26L,162L,262L,308L,570L,348L,184L,456L,200L,244L,498L,62L,378L,1488L,52L,50L,42L,160L,60L,780L,78L,42L,128L,22L,270L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053327Inst : IEnumerable<long>
{
public static readonly long[] Value=A053327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053327.Bytes);
public long this[int i]=>Value[i];

public static A053327Inst Instance=new A053327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053328
{
public static readonly long[] Value={ 2L,3L,5L,6L,7L,11L,13L,14L,15L,21L,23L,29L,30L,35L,38L,42L,47L,53L,62L,69L,77L,83L,87L,93L,110L,138L,143L,165L,167L,173L,182L,195L,213L,215L,227L,237L,255L,285L,293L,318L,357L,398L,413L,437L,447L,453L,483L,635L,717L,930L,957L,1077L,1085L,1133L,1253L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053328Inst : IEnumerable<long>
{
public static readonly long[] Value=A053328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053328.Bytes);
public long this[int i]=>Value[i];

public static A053328Inst Instance=new A053328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053329
{
public static readonly long[] Value={ 2L,3L,5L,6L,7L,11L,13L,14L,17L,21L,23L,29L,33L,37L,38L,41L,47L,53L,61L,62L,69L,77L,83L,93L,101L,133L,141L,149L,157L,167L,173L,197L,213L,227L,237L,269L,293L,317L,341L,398L,413L,437L,453L,461L,509L,557L,573L,677L,717L,773L,797L,917L,941L,1013L,1077L,1133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053329Inst : IEnumerable<long>
{
public static readonly long[] Value=A053329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053329.Bytes);
public long this[int i]=>Value[i];

public static A053329Inst Instance=new A053329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053330
{
public static readonly long[] Value={ 10L,15L,26L,30L,34L,35L,39L,42L,51L,65L,66L,78L,85L,87L,95L,102L,105L,110L,119L,122L,123L,138L,143L,146L,165L,182L,194L,203L,205L,215L,221L,222L,230L,258L,285L,287L,318L,327L,357L,362L,365L,395L,402L,429L,447L,482L,485L,527L,533L,623L,629L,635L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053330Inst : IEnumerable<long>
{
public static readonly long[] Value=A053330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053330.Bytes);
public long this[int i]=>Value[i];

public static A053330Inst Instance=new A053330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053331
{
public static readonly long[] Value={ 750L,1452L,324L,534L,1770L,186L,84L,816L,846L,594L,300L,240L,84L,390L,966L,210L,234L,360L,66L,84L,270L,150L,60L,210L,120L,1140L,294L,228L,438L,90L,1296L,1470L,576L,288L,342L,312L,156L,222L,822L,708L,42L,816L,1284L,276L,186L,1230L,348L,270L,102L,114L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053331Inst : IEnumerable<long>
{
public static readonly long[] Value=A053331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053331.Bytes);
public long this[int i]=>Value[i];

public static A053331Inst Instance=new A053331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053332
{
public static readonly long[] Value={ 4L,44L,744L,7744L,47744L,447744L,4447744L,44447744L,444447744L,4444447744L,74444447744L,474444447744L,4474444447744L,44474444447744L,444474444447744L,7444474444447744L,77444474444447744L,477444474444447744L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053332Inst : IEnumerable<long>
{
public static readonly long[] Value=A053332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053332.Bytes);
public long this[int i]=>Value[i];

public static A053332Inst Instance=new A053332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053333
{
public static readonly long[] Value={ 4L,44L,944L,4944L,94944L,994944L,4994944L,94994944L,494994944L,9494994944L,49494994944L,449494994944L,9449494994944L,99449494994944L,499449494994944L,9499449494994944L,49499449494994944L,949499449494994944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053333Inst : IEnumerable<long>
{
public static readonly long[] Value=A053333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053333.Bytes);
public long this[int i]=>Value[i];

public static A053333Inst Instance=new A053333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053334
{
public static readonly long[] Value={ 6L,16L,616L,1616L,11616L,111616L,6111616L,16111616L,616111616L,1616111616L,61616111616L,661616111616L,1661616111616L,61661616111616L,661661616111616L,6661661616111616L,66661661616111616L,666661661616111616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053334Inst : IEnumerable<long>
{
public static readonly long[] Value=A053334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053334.Bytes);
public long this[int i]=>Value[i];

public static A053334Inst Instance=new A053334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053335
{
public static readonly long[] Value={ 6L,36L,336L,6336L,66336L,366336L,6366336L,36366336L,636366336L,3636366336L,33636366336L,333636366336L,3333636366336L,33333636366336L,633333636366336L,3633333636366336L,33633333636366336L,333633333636366336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053335Inst : IEnumerable<long>
{
public static readonly long[] Value=A053335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053335.Bytes);
public long this[int i]=>Value[i];

public static A053335Inst Instance=new A053335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053336
{
public static readonly long[] Value={ 6L,56L,656L,6656L,66656L,566656L,6566656L,66566656L,666566656L,6666566656L,56666566656L,656666566656L,6656666566656L,66656666566656L,566656666566656L,6566656666566656L,56566656666566656L,556566656666566656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053336Inst : IEnumerable<long>
{
public static readonly long[] Value=A053336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053336.Bytes);
public long this[int i]=>Value[i];

public static A053336Inst Instance=new A053336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053337
{
public static readonly long[] Value={ 6L,76L,776L,7776L,67776L,667776L,6667776L,66667776L,766667776L,6766667776L,66766667776L,666766667776L,7666766667776L,77666766667776L,777666766667776L,7777666766667776L,77777666766667776L,777777666766667776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053337Inst : IEnumerable<long>
{
public static readonly long[] Value=A053337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053337.Bytes);
public long this[int i]=>Value[i];

public static A053337Inst Instance=new A053337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053338
{
public static readonly long[] Value={ 6L,96L,696L,9696L,69696L,669696L,6669696L,96669696L,696669696L,9696669696L,69696669696L,969696669696L,9969696669696L,69969696669696L,969969696669696L,9969969696669696L,99969969696669696L,999969969696669696L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053338Inst : IEnumerable<long>
{
public static readonly long[] Value=A053338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053338.Bytes);
public long this[int i]=>Value[i];

public static A053338Inst Instance=new A053338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053339
{
public static readonly long[] Value={ 255L,435L,455L,561L,595L,665L,705L,795L,805L,885L,957L,1001L,1105L,1295L,1309L,1335L,1463L,1495L,1551L,1605L,1615L,1645L,1729L,1749L,1855L,1885L,1947L,1955L,2001L,2055L,2065L,2091L,2093L,2185L,2235L,2345L,2387L,2405L,2465L,2555L,2703L,2717L,2755L,2821L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053339Inst : IEnumerable<long>
{
public static readonly long[] Value=A053339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053339.Bytes);
public long this[int i]=>Value[i];

public static A053339Inst Instance=new A053339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053340
{
public static readonly long[] Value={ 5865L,8645L,10005L,10465L,13685L,15045L,15295L,16269L,18285L,20445L,22015L,24871L,26845L,27965L,28405L,28815L,29733L,30705L,31031L,31255L,33215L,35245L,36105L,37037L,37145L,37365L,37765L,37995L,38985L,39831L,40579L,41041L,43435L,44135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053340Inst : IEnumerable<long>
{
public static readonly long[] Value=A053340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053340.Bytes);
public long this[int i]=>Value[i];

public static A053340Inst Instance=new A053340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053341
{
public static readonly long[] Value={ 3L,5L,7L,17L,19L,151L,163L,257L,487L,751L,1459L,1471L,39367L,65537L,72031L,279511L,33820711L,86093443L,258280327L,372027811L,4092305911L,11149928791L,42638305711L,209481995953231L,411782264189299L,3561193931204911L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053341Inst : IEnumerable<long>
{
public static readonly long[] Value=A053341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053341.Bytes);
public long this[int i]=>Value[i];

public static A053341Inst Instance=new A053341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053342
{
public static readonly long[] Value={ 41L,1L,1L,2L,1L,1L,2L,1L,2L,1L,8L,1L,1L,27L,5L,6L,5L,27L,1L,1L,8L,1L,2L,1L,2L,1L,1L,2L,1L,1L,82L,1L,1L,2L,1L,1L,2L,1L,2L,1L,8L,1L,1L,27L,5L,6L,5L,27L,1L,1L,8L,1L,2L,1L,2L,1L,1L,2L,1L,1L,82L,1L,1L,2L,1L,1L,2L,1L,2L,1L,8L,1L,1L,27L,5L,6L,5L,27L,1L,1L,8L,1L,2L,1L,2L,1L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053342Inst : IEnumerable<long>
{
public static readonly long[] Value=A053342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053342.Bytes);
public long this[int i]=>Value[i];

public static A053342Inst Instance=new A053342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053343
{
public static readonly long[] Value={ 15L,33L,35L,51L,65L,77L,87L,91L,95L,119L,123L,143L,161L,177L,185L,209L,213L,215L,217L,221L,247L,259L,287L,303L,321L,329L,335L,341L,371L,377L,395L,403L,407L,411L,427L,437L,447L,469L,473L,485L,511L,515L,527L,533L,537L,545L,551L,573L,581L,591L,611L,629L,635L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053343Inst : IEnumerable<long>
{
public static readonly long[] Value=A053343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053343.Bytes);
public long this[int i]=>Value[i];

public static A053343Inst Instance=new A053343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053344
{
public static readonly long[] Value={ 1L,2L,3L,4L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,2L,3L,4L,5L,6L,2L,3L,4L,5L,6L,1L,2L,3L,4L,5L,2L,3L,4L,5L,6L,2L,3L,4L,5L,6L,3L,4L,5L,6L,7L,3L,4L,5L,6L,7L,2L,3L,4L,5L,6L,3L,4L,5L,6L,7L,3L,4L,5L,6L,7L,4L,5L,6L,7L,8L,4L,5L,6L,7L,8L,3L,4L,5L,6L,7L,4L,5L,6L,7L,8L,4L,5L,6L,7L,8L,5L,6L,7L,8L,9L,5L,6L,7L,8L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053344Inst : IEnumerable<long>
{
public static readonly long[] Value=A053344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053344.Bytes);
public long this[int i]=>Value[i];

public static A053344Inst Instance=new A053344Inst();

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