using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A124841
{
public static readonly long[] Value={ 1L,-1L,2L,-3L,3L,0L,-10L,35L,-90L,200L,-400L,726L,-1188L,1716L,-2080L,1820L,-312L,-2704L,5408L,455L,-39195L,170313L,-523029L,1352078L,-3114774L,6548074L,-12668578L,22492886L,-36020998L,49549110L,-49549110L,0L,182029056L,-670853984L,1809734560L,-4242470755L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124841Inst : IEnumerable<long>
{
public static readonly long[] Value=A124841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124841.Bytes);
public long this[int i]=>Value[i];

public static A124841Inst Instance=new A124841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124842
{
public static readonly long[] Value={ 1L,1L,-1L,1L,-2L,2L,1L,-3L,6L,-3L,1L,-4L,12L,-12L,3L,1L,-5L,20L,-30L,15L,0L,1L,-6L,30L,-60L,45L,0L,-10L,1L,-7L,42L,-105L,105L,0L,-70L,35L,1L,-8L,56L,-168L,210L,0L,-280L,280L,-90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124842Inst : IEnumerable<long>
{
public static readonly long[] Value=A124842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124842.Bytes);
public long this[int i]=>Value[i];

public static A124842Inst Instance=new A124842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124843
{
public static readonly long[] Value={ 1L,8L,34L,122L,502L,2098L,8980L,38928L,170382L,750722L,3323554L,14763438L,65736004L,293186252L,1309156946L,5850527002L,26160514526L,117022825786L,523619082772L,2343388805944L,10488943094022L,46952619517170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124843Inst : IEnumerable<long>
{
public static readonly long[] Value=A124843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124843.Bytes);
public long this[int i]=>Value[i];

public static A124843Inst Instance=new A124843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124844
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,-1L,1L,6L,-3L,3L,1L,8L,-6L,12L,-4L,1L,10L,-10L,30L,-20L,7L,1L,12L,-15L,60L,-60L,42L,-11L,1L,14L,-21L,105L,-140L,147L,-77L,18L,1L,16L,-28L,168L,-280L,392L,-308L,144L,-29L,1L,18L,-36L,252L,-504L,882L,-924L,648L,-261L,47L,1L,20L,-45L,360L,-840L,1764L,-2310L,2160L,-1305L,470L,-76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124844Inst : IEnumerable<long>
{
public static readonly long[] Value=A124844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124844.Bytes);
public long this[int i]=>Value[i];

public static A124844Inst Instance=new A124844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124845
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,1L,1L,6L,3L,2L,1L,8L,6L,8L,1L,1L,10L,10L,20L,5L,2L,1L,12L,15L,40L,15L,12L,1L,1L,14L,21L,70L,35L,42L,7L,2L,1L,16L,28L,112L,70L,112L,28L,16L,1L,1L,18L,36L,168L,126L,252L,84L,72L,9L,2L,1L,20L,45L,240L,210L,504L,210L,240L,45L,20L,1L,1L,22L,55L,330L,330L,924L,462L,660L,165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124845Inst : IEnumerable<long>
{
public static readonly long[] Value=A124845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124845.Bytes);
public long this[int i]=>Value[i];

public static A124845Inst Instance=new A124845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124846
{
public static readonly long[] Value={ 1L,1L,3L,1L,6L,1L,1L,9L,3L,3L,1L,12L,6L,12L,1L,1L,15L,10L,30L,5L,3L,1L,18L,15L,60L,15L,18L,1L,1L,21L,21L,105L,35L,63L,7L,3L,1L,24L,28L,168L,70L,168L,28L,24L,1L,1L,27L,36L,252L,126L,378L,84L,108L,9L,3L,1L,30L,45L,360L,210L,756L,210L,360L,45L,30L,1L,1L,33L,55L,495L,330L,1386L,462L,990L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124846Inst : IEnumerable<long>
{
public static readonly long[] Value=A124846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124846.Bytes);
public long this[int i]=>Value[i];

public static A124846Inst Instance=new A124846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124847
{
public static readonly long[] Value={ 1L,1L,3L,1L,6L,6L,1L,9L,18L,10L,1L,12L,36L,40L,15L,1L,15L,60L,100L,75L,21L,1L,18L,90L,200L,225L,126L,28L,1L,21L,126L,350L,525L,441L,196L,36L,1L,24L,168L,560L,1050L,1176L,784L,288L,45L,1L,27L,216L,840L,1890L,2646L,2352L,1296L,405L,55L,1L,30L,270L,1200L,3150L,5292L,5880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124847Inst : IEnumerable<long>
{
public static readonly long[] Value=A124847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124847.Bytes);
public long this[int i]=>Value[i];

public static A124847Inst Instance=new A124847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124848
{
public static readonly long[] Value={ 1L,1L,4L,1L,8L,10L,1L,12L,30L,20L,1L,16L,60L,80L,35L,1L,20L,100L,200L,175L,56L,1L,24L,150L,400L,525L,336L,84L,1L,28L,210L,700L,1225L,1176L,588L,120L,1L,32L,280L,1120L,2450L,3136L,2352L,960L,165L,1L,36L,360L,1680L,4410L,7056L,7056L,4320L,1485L,220L,1L,40L,450L,2400L,7350L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124848Inst : IEnumerable<long>
{
public static readonly long[] Value=A124848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124848.Bytes);
public long this[int i]=>Value[i];

public static A124848Inst Instance=new A124848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124849
{
public static readonly long[] Value={ 0L,2L,4L,8L,10L,22L,32L,34L,40L,44L,50L,52L,58L,68L,74L,88L,92L,110L,122L,134L,142L,160L,164L,178L,188L,208L,212L,242L,250L,260L,268L,272L,304L,320L,334L,344L,352L,370L,374L,382L,388L,398L,424L,428L,440L,458L,464L,472L,484L,494L,508L,520L,524L,538L,550L,554L,572L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124849Inst : IEnumerable<long>
{
public static readonly long[] Value=A124849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124849.Bytes);
public long this[int i]=>Value[i];

public static A124849Inst Instance=new A124849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124850
{
public static readonly long[] Value={ 2L,5L,11L,17L,29L,37L,61L,67L,71L,89L,167L,191L,199L,229L,269L,277L,311L,331L,337L,347L,379L,389L,419L,431L,509L,541L,577L,587L,617L,631L,691L,709L,757L,797L,809L,821L,929L,941L,977L,991L,1069L,1091L,1117L,1129L,1217L,1277L,1279L,1289L,1291L,1367L,1439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124850Inst : IEnumerable<long>
{
public static readonly long[] Value=A124850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124850.Bytes);
public long this[int i]=>Value[i];

public static A124850Inst Instance=new A124850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124851
{
public static readonly long[] Value={ 1L,9L,39L,141L,587L,2479L,10731L,47063L,208547L,931047L,4180239L,18849103L,85269011L,386687375L,1756855951L,7993210831L,36405316227L,165940691695L,756832203759L,3453347063599L,15762537566627L,71964915505967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124851Inst : IEnumerable<long>
{
public static readonly long[] Value=A124851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124851.Bytes);
public long this[int i]=>Value[i];

public static A124851Inst Instance=new A124851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124852
{
public static readonly long[] Value={ 1L,10L,44L,160L,672L,2860L,12482L,55198L,246712L,1111372L,5037174L,22940158L,104870790L,480863770L,2210197754L,10178143810L,46942294232L,216761695840L,1001878336772L,4634206919128L,21448419453382L,99316222901062L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124852Inst : IEnumerable<long>
{
public static readonly long[] Value=A124852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124852.Bytes);
public long this[int i]=>Value[i];

public static A124852Inst Instance=new A124852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124853
{
public static readonly long[] Value={ 0L,2L,4L,8L,14L,16L,22L,32L,34L,44L,56L,58L,62L,74L,76L,86L,88L,92L,104L,118L,128L,146L,148L,154L,172L,196L,212L,218L,224L,232L,238L,256L,274L,284L,286L,308L,316L,322L,338L,364L,382L,386L,394L,428L,454L,476L,478L,494L,518L,526L,532L,536L,538L,568L,632L,664L,674L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124853Inst : IEnumerable<long>
{
public static readonly long[] Value=A124853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124853.Bytes);
public long this[int i]=>Value[i];

public static A124853Inst Instance=new A124853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124854
{
public static readonly long[] Value={ 2L,7L,11L,17L,29L,31L,37L,43L,59L,73L,109L,137L,191L,193L,197L,227L,239L,263L,269L,337L,367L,373L,401L,409L,449L,479L,499L,541L,557L,701L,743L,757L,823L,827L,857L,941L,983L,997L,1033L,1051L,1109L,1163L,1303L,1361L,1471L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124854Inst : IEnumerable<long>
{
public static readonly long[] Value=A124854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124854.Bytes);
public long this[int i]=>Value[i];

public static A124854Inst Instance=new A124854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124855
{
public static readonly long[] Value={ 1L,5L,11L,19L,25L,31L,41L,49L,59L,65L,89L,91L,109L,115L,121L,125L,151L,161L,179L,181L,205L,209L,229L,241L,245L,275L,305L,329L,331L,349L,355L,361L,371L,389L,415L,439L,509L,515L,521L,535L,551L,595L,599L,625L,661L,665L,671L,719L,725L,749L,755L,769L,779L,791L,839L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124855Inst : IEnumerable<long>
{
public static readonly long[] Value=A124855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124855.Bytes);
public long this[int i]=>Value[i];

public static A124855Inst Instance=new A124855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124968
{
public static readonly long[] Value={ 81L,89L,101L,125L,129L,134L,146L,149L,153L,161L,162L,170L,171L,173L,185L,189L,194L,198L,201L,206L,209L,221L,225L,230L,233L,234L,241L,242L,243L,245L,246L,249L,250L,251L,254L,257L,261L,266L,269L,270L,274L,278L,281L,285L,289L,290L,293L,294L,297L,299L,305L,306L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124968Inst : IEnumerable<long>
{
public static readonly long[] Value=A124968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124968.Bytes);
public long this[int i]=>Value[i];

public static A124968Inst Instance=new A124968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124969
{
public static readonly long[] Value={ 146L,153L,185L,194L,206L,209L,221L,225L,230L,234L,257L,261L,266L,269L,281L,290L,293L,297L,305L,306L,314L,321L,325L,326L,329L,338L,341L,342L,350L,353L,354L,362L,365L,369L,374L,377L,381L,386L,389L,398L,401L,402L,405L,409L,410L,413L,414L,419L,425L,426L,434L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124969Inst : IEnumerable<long>
{
public static readonly long[] Value=A124969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124969.Bytes);
public long this[int i]=>Value[i];

public static A124969Inst Instance=new A124969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124970
{
public static readonly long[] Value={ 7L,1L,9L,41L,81L,146L,194L,306L,369L,425L,594L,689L,866L,1109L,1161L,1154L,1361L,1634L,1781L,1889L,2141L,2729L,2609L,3626L,3366L,3566L,3449L,3506L,4241L,4289L,4826L,5066L,5381L,7034L,5561L,6254L,7229L,7829L,8186L,8069L,8126L,8609L,8921L,8774L,10386L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124970Inst : IEnumerable<long>
{
public static readonly long[] Value=A124970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124970.Bytes);
public long this[int i]=>Value[i];

public static A124970Inst Instance=new A124970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124971
{
public static readonly long[] Value={ 17L,25L,26L,33L,49L,50L,53L,61L,65L,68L,72L,73L,74L,81L,82L,85L,89L,97L,98L,99L,100L,101L,104L,105L,106L,107L,108L,109L,113L,116L,117L,121L,122L,125L,129L,130L,131L,136L,137L,138L,144L,145L,146L,149L,152L,153L,154L,157L,161L,164L,165L,169L,170L,173L,177L,178L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124971Inst : IEnumerable<long>
{
public static readonly long[] Value=A124971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124971.Bytes);
public long this[int i]=>Value[i];

public static A124971Inst Instance=new A124971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124972
{
public static readonly long[] Value={ 1L,-8L,20L,0L,-62L,0L,216L,0L,-641L,0L,1636L,0L,-3778L,0L,8248L,0L,-17277L,0L,34664L,0L,-66878L,0L,125312L,0L,-229252L,0L,409676L,0L,-716420L,0L,1230328L,0L,-2079227L,0L,3460416L,0L,-5677816L,0L,9198424L,0L,-14729608L,0L,23328520L,0L,-36567242L,0L,56774712L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124972Inst : IEnumerable<long>
{
public static readonly long[] Value=A124972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124972.Bytes);
public long this[int i]=>Value[i];

public static A124972Inst Instance=new A124972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124973
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,6L,11L,22L,42L,87L,174L,365L,745L,1587L,3303L,7103L,14974L,32477L,69284L,151172L,325077L,713400L,1545719L,3406989L,7423648L,16429555L,35992438L,79912474L,175785514L,391488688L,864591621L,1930333822L,4276537000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124973Inst : IEnumerable<long>
{
public static readonly long[] Value=A124973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124973.Bytes);
public long this[int i]=>Value[i];

public static A124973Inst Instance=new A124973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124974
{
public static readonly long[] Value={ 1L,3L,5L,9L,45L,99L,53559L,1143357L,2027985L,36806085L,1773607905L,3314574181L,1045463125509L,1226640523999L,3567404505159L,28726885591099L,39880799734039L,87977068273719L,106436400721299L,339966033494859L,999567363539883L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124974Inst : IEnumerable<long>
{
public static readonly long[] Value=A124974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124974.Bytes);
public long this[int i]=>Value[i];

public static A124974Inst Instance=new A124974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124975
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,7L,6L,7L,1L,1L,43L,25L,25L,43L,1L,1L,1807L,493L,350L,493L,1807L,1L,1L,3263443L,223657L,82449L,82449L,223657L,3263443L,1L,1L,10650056950807L,49621568893L,5454149449L,3495672702L,5454149449L,49621568893L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124975Inst : IEnumerable<long>
{
public static readonly long[] Value=A124975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124975.Bytes);
public long this[int i]=>Value[i];

public static A124975Inst Instance=new A124975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124976
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,4L,9L,4L,1L,1L,8L,60L,60L,8L,1L,1L,16L,648L,4225L,648L,16L,1L,1L,32L,12240L,2818530L,2818530L,12240L,32L,1L,1L,64L,427680L,34599304740L,7947815340969L,34599304740L,427680L,64L,1L,1L,128L,28641600L,14799779785070280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124976Inst : IEnumerable<long>
{
public static readonly long[] Value=A124976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124976.Bytes);
public long this[int i]=>Value[i];

public static A124976Inst Instance=new A124976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124977
{
public static readonly long[] Value={ 0L,4700063497L,19147L,25L,2228071L,262279L,95L,481L,45L,2873L,3175999L,555L,95921L,174934013L,777L,140039L,2463240427L,477L,91L,623L,2453L,55L,345119L,1131L,943L,21967L,135L,46979L,125L,3811L,23329L,155L,1064959L,245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124977Inst : IEnumerable<long>
{
public static readonly long[] Value=A124977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124977.Bytes);
public long this[int i]=>Value[i];

public static A124977Inst Instance=new A124977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124978
{
public static readonly long[] Value={ 1L,4L,18L,34L,50L,66L,82L,114L,90L,130L,150L,178L,162L,198L,318L,210L,250L,234L,322L,406L,465L,330L,306L,402L,462L,390L,474L,378L,490L,486L,654L,610L,522L,450L,778L,678L,642L,570L,666L,726L,594L,714L,770L,774L,986L,630L,738L,945L,1035L,850L,1222L,978L,1014L,918L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124978Inst : IEnumerable<long>
{
public static readonly long[] Value=A124978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124978.Bytes);
public long this[int i]=>Value[i];

public static A124978Inst Instance=new A124978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124979
{
public static readonly long[] Value={ 169L,221L,289L,338L,377L,442L,481L,493L,533L,578L,629L,676L,689L,697L,754L,793L,841L,884L,901L,949L,962L,986L,1037L,1066L,1073L,1156L,1157L,1189L,1241L,1258L,1261L,1313L,1352L,1369L,1378L,1394L,1417L,1469L,1508L,1513L,1517L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124979Inst : IEnumerable<long>
{
public static readonly long[] Value=A124979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124979.Bytes);
public long this[int i]=>Value[i];

public static A124979Inst Instance=new A124979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124980
{
public static readonly long[] Value={ 1L,25L,325L,1105L,4225L,5525L,203125L,27625L,71825L,138125L,2640625L,160225L,17850625L,1221025L,1795625L,801125L,1650390625L,2082925L,49591064453125L,4005625L,44890625L,2158203125L,30525625L,5928325L,303460625L,53955078125L,35409725L,100140625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124980Inst : IEnumerable<long>
{
public static readonly long[] Value=A124980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124980.Bytes);
public long this[int i]=>Value[i];

public static A124980Inst Instance=new A124980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124981
{
public static readonly long[] Value={ 3L,7L,11L,15L,19L,21L,23L,27L,31L,33L,35L,39L,43L,47L,51L,55L,57L,59L,63L,67L,69L,71L,75L,77L,79L,83L,87L,91L,93L,95L,99L,103L,105L,107L,111L,115L,119L,123L,127L,129L,131L,133L,135L,139L,141L,143L,147L,151L,155L,159L,161L,163L,165L,167L,171L,175L,177L,179L,183L,187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124981Inst : IEnumerable<long>
{
public static readonly long[] Value=A124981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124981.Bytes);
public long this[int i]=>Value[i];

public static A124981Inst Instance=new A124981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124982
{
public static readonly long[] Value={ 0L,1L,4L,8L,9L,10L,16L,18L,20L,26L,32L,34L,36L,40L,45L,49L,52L,58L,64L,68L,72L,74L,80L,81L,82L,90L,98L,104L,106L,116L,117L,121L,122L,128L,136L,144L,146L,148L,153L,160L,162L,164L,178L,180L,194L,196L,202L,208L,212L,218L,226L,232L,234L,242L,244L,245L,256L,261L,272L,274L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124982Inst : IEnumerable<long>
{
public static readonly long[] Value=A124982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124982.Bytes);
public long this[int i]=>Value[i];

public static A124982Inst Instance=new A124982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124983
{
public static readonly long[] Value={ 1L,9L,45L,49L,81L,117L,121L,153L,245L,261L,333L,361L,369L,405L,441L,477L,529L,549L,605L,637L,657L,729L,801L,833L,873L,909L,961L,981L,1017L,1053L,1089L,1233L,1341L,1377L,1413L,1421L,1557L,1573L,1629L,1737L,1773L,1805L,1813L,1849L,2009L,2057L,2061L,2097L,2169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124983Inst : IEnumerable<long>
{
public static readonly long[] Value=A124983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124983.Bytes);
public long this[int i]=>Value[i];

public static A124983Inst Instance=new A124983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125048
{
public static readonly BigInteger[] Value={ 0L,24L,48576L,73741824L,99511627776L,125899906842624L,152921504606846976L,BigInteger.Parse("180591620717411303424"),BigInteger.Parse("208925819614629174706176"),BigInteger.Parse("237940039285380274899124224"),BigInteger.Parse("267650600228229401496703205376") };
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
public class A125048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125048Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A125048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125048.Bytes);
public BigInteger this[int i]=>Value[i];

public static A125048Inst Instance=new A125048Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125049
{
public static readonly long[] Value={ 1L,3L,6L,13L,26L,53L,106L,213L,427L,855L,1711L,3423L,6847L,13695L,27391L,54783L,109567L,219134L,438269L,876539L,1753079L,3506159L,7012318L,14024637L,28049275L,56098551L,112197103L,224394207L,448788415L,897576831L,1795153663L,3590307326L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125049Inst : IEnumerable<long>
{
public static readonly long[] Value=A125049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125049.Bytes);
public long this[int i]=>Value[i];

public static A125049Inst Instance=new A125049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125050
{
public static readonly long[] Value={ 1L,2L,4L,9L,19L,38L,77L,155L,311L,622L,1245L,2491L,4983L,9967L,19934L,39869L,79738L,159477L,318955L,637911L,1275823L,2551646L,5103293L,10206587L,20413175L,40826351L,81652702L,163305405L,326610811L,653221623L,1306443247L,2612886495L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125050Inst : IEnumerable<long>
{
public static readonly long[] Value=A125050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125050.Bytes);
public long this[int i]=>Value[i];

public static A125050Inst Instance=new A125050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125051
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,5L,6L,7L,6L,7L,8L,6L,7L,8L,9L,7L,8L,9L,10L,8L,9L,10L,11L,7L,8L,9L,10L,11L,8L,9L,10L,11L,12L,9L,10L,11L,12L,13L,7L,8L,9L,10L,11L,8L,9L,10L,11L,12L,9L,10L,11L,12L,13L,10L,11L,12L,13L,14L,8L,9L,10L,11L,12L,13L,9L,10L,11L,12L,13L,14L,10L,11L,12L,13L,14L,15L,11L,12L,13L,14L,15L,16L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125051Inst : IEnumerable<long>
{
public static readonly long[] Value=A125051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125051.Bytes);
public long this[int i]=>Value[i];

public static A125051Inst Instance=new A125051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125052
{
public static readonly BigInteger[] Value={ 1L,2L,3L,9L,39L,252L,2361L,32077L,631058L,18035534L,751936149L,45973362492L,4144777181393L,554100538432001L,110435083963283354L,BigInteger.Parse("32981178674724868365") };
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
public class A125052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125052Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A125052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125052.Bytes);
public BigInteger this[int i]=>Value[i];

public static A125052Inst Instance=new A125052Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125053
{
public static readonly long[] Value={ 1L,1L,3L,1L,5L,15L,21L,15L,5L,61L,183L,285L,327L,285L,183L,61L,1385L,4155L,6681L,8475L,9129L,8475L,6681L,4155L,1385L,50521L,151563L,247065L,325947L,378105L,396363L,378105L,325947L,247065L,151563L,50521L,2702765L,8108295L,13311741L,17908935L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125053Inst : IEnumerable<long>
{
public static readonly long[] Value=A125053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125053.Bytes);
public long this[int i]=>Value[i];

public static A125053Inst Instance=new A125053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125054
{
public static readonly BigInteger[] Value={ 1L,3L,21L,327L,9129L,396363L,24615741L,2068052367L,225742096209L,31048132997523L,5252064083753061L,1071525520294178007L,BigInteger.Parse("259439870666594250489"),BigInteger.Parse("73542221109962636293083"),BigInteger.Parse("24125551094579137082039181"),BigInteger.Parse("9068240688454120376775401247"),BigInteger.Parse("3871645204706420218816959159969") };
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
public class A125054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125054Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A125054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125054.Bytes);
public BigInteger this[int i]=>Value[i];

public static A125054Inst Instance=new A125054Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125055
{
public static readonly BigInteger[] Value={ 1L,15L,285L,8475L,378105L,23823015L,2018820885L,221605991475L,30596648805105L,5189967817758015L,1061021392126671885L,BigInteger.Parse("257296819626005894475"),BigInteger.Parse("73023341368629447792105"),BigInteger.Parse("23978466652359211809453015") };
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
public class A125055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125055Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A125055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125055.Bytes);
public BigInteger this[int i]=>Value[i];

public static A125055Inst Instance=new A125055Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125056
{
public static readonly long[] Value={ 6L,12L,30L,48L,60L,72L,120L,96L,144L,180L,140L,240L,216L,252L,360L,336L,420L,224L,312L,480L,504L,540L,378L,720L,600L,840L,660L,672L,352L,364L,756L,780L,1080L,960L,1260L,864L,594L,924L,936L,1440L,1320L,1680L,1050L,1056L,1092L,1120L,1512L,1560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125056Inst : IEnumerable<long>
{
public static readonly long[] Value=A125056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125056.Bytes);
public long this[int i]=>Value[i];

public static A125056Inst Instance=new A125056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125057
{
public static readonly long[] Value={ 5L,4L,9L,3L,7L,5L,6L,11L,7L,4L,8L,6L,9L,5L,4L,16L,7L,4L,8L,7L,11L,5L,10L,7L,7L,8L,7L,12L,9L,6L,10L,8L,8L,8L,10L,6L,4L,7L,7L,15L,8L,4L,11L,11L,8L,12L,7L,11L,7L,9L,8L,8L,12L,14L,8L,12L,8L,8L,11L,5L,14L,7L,7L,9L,5L,8L,4L,13L,7L,8L,12L,10L,6L,9L,14L,11L,9L,8L,9L,12L,13L,8L,8L,9L,9L,10L,7L,11L,14L,3L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125057Inst : IEnumerable<long>
{
public static readonly long[] Value=A125057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125057.Bytes);
public long this[int i]=>Value[i];

public static A125057Inst Instance=new A125057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125058
{
public static readonly BigInteger[] Value={ 1L,2L,212L,2122212L,21222122122122212L,BigInteger.Parse("21222122122122212212221221222122122122212"),BigInteger.Parse("212221221221222122122212212221221221222122122212212212221221222122122122212212221221222122122122212") };
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
public class A125058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125058Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A125058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125058.Bytes);
public BigInteger this[int i]=>Value[i];

public static A125058Inst Instance=new A125058Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125059
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,3L,3L,3L,4L,5L,5L,6L,6L,7L,8L,8L,9L,9L,10L,11L,11L,12L,13L,13L,14L,15L,16L,16L,17L,18L,19L,19L,20L,21L,22L,22L,23L,24L,25L,26L,27L,27L,28L,29L,30L,31L,32L,32L,33L,34L,35L,36L,37L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125059Inst : IEnumerable<long>
{
public static readonly long[] Value=A125059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125059.Bytes);
public long this[int i]=>Value[i];

public static A125059Inst Instance=new A125059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125060
{
public static readonly long[] Value={ 1L,3L,2L,4L,5L,7L,9L,6L,8L,11L,12L,13L,17L,19L,23L,25L,10L,15L,16L,18L,20L,22L,24L,21L,27L,29L,31L,33L,35L,37L,39L,41L,14L,26L,28L,32L,34L,38L,43L,47L,49L,51L,53L,57L,59L,61L,30L,36L,40L,42L,45L,46L,48L,50L,52L,54L,56L,55L,65L,67L,71L,73L,77L,79L,83L,85L,89L,91L,95L,44L,58L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125060Inst : IEnumerable<long>
{
public static readonly long[] Value=A125060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125060.Bytes);
public long this[int i]=>Value[i];

public static A125060Inst Instance=new A125060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125061
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,2L,3L,0L,1L,1L,2L,0L,3L,2L,0L,6L,1L,2L,1L,0L,2L,0L,0L,0L,3L,3L,2L,3L,0L,2L,6L,0L,1L,0L,2L,0L,1L,2L,0L,6L,2L,2L,0L,0L,0L,2L,0L,0L,3L,1L,3L,6L,2L,2L,3L,0L,0L,0L,2L,0L,6L,2L,0L,0L,1L,4L,0L,0L,2L,0L,0L,0L,1L,2L,2L,9L,0L,0L,6L,0L,2L,1L,2L,0L,0L,4L,0L,6L,0L,2L,2L,0L,0L,0L,0L,0L,3L,2L,1L,0L,3L,2L,6L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125061Inst : IEnumerable<long>
{
public static readonly long[] Value=A125061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125061.Bytes);
public long this[int i]=>Value[i];

public static A125061Inst Instance=new A125061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125062
{
public static readonly long[] Value={ 1L,1L,4L,15L,68L,370L,2364L,17388L,144864L,1349136L,13894560L,156831840L,1925527680L,25550778240L,364416917760L,5559659078400L,90349397913600L,1558170228787200L,28423674336153600L,546807873520742400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125062Inst : IEnumerable<long>
{
public static readonly long[] Value=A125062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125062.Bytes);
public long this[int i]=>Value[i];

public static A125062Inst Instance=new A125062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125063
{
public static readonly long[] Value={ 62540982L,105161238L,258428648L,349211772L,544861170L,772363566L,887381138L,932216922L,1154093668L,4904108118L,5498022546L,5668317018L,6058655748L,6445210590L,6507811154L,6991709634L,7088831048L,7370532162L,7426318142L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125063Inst : IEnumerable<long>
{
public static readonly long[] Value=A125063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125063.Bytes);
public long this[int i]=>Value[i];

public static A125063Inst Instance=new A125063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125096
{
public static readonly long[] Value={ 1L,0L,2L,2L,0L,0L,0L,2L,3L,0L,2L,4L,0L,0L,0L,2L,2L,0L,2L,0L,0L,0L,0L,4L,1L,0L,4L,0L,0L,0L,0L,2L,4L,0L,0L,6L,0L,0L,0L,0L,2L,0L,2L,4L,0L,0L,0L,4L,1L,0L,4L,0L,0L,0L,0L,0L,4L,0L,2L,0L,0L,0L,0L,2L,0L,0L,2L,4L,0L,0L,0L,6L,2L,0L,2L,4L,0L,0L,0L,0L,5L,0L,2L,0L,0L,0L,0L,4L,2L,0L,0L,0L,0L,0L,0L,4L,2L,0L,6L,2L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125096Inst : IEnumerable<long>
{
public static readonly long[] Value=A125096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125096.Bytes);
public long this[int i]=>Value[i];

public static A125096Inst Instance=new A125096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125097
{
public static readonly long[] Value={ 123L,41L,5L,589L,347L,193L,471L,15L,419L,217L,863L,701L,25L,449L,487L,133L,731L,35L,679L,157L,3L,561L,45L,109L,227L,473L,191L,55L,739L,697L,543L,621L,65L,569L,567L,213L,851L,75L,599L,837L,483L,881L,85L,829L,507L,353L,711L,95L,259L,577L,823L,341L,105L,889L,47L,893L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125097Inst : IEnumerable<long>
{
public static readonly long[] Value=A125097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125097.Bytes);
public long this[int i]=>Value[i];

public static A125097Inst Instance=new A125097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125098
{
public static readonly long[] Value={ 0L,1L,10L,11L,12L,100L,101L,102L,110L,111L,112L,120L,121L,122L,123L,1000L,1001L,1002L,1010L,1011L,1012L,1020L,1021L,1022L,1023L,1100L,1101L,1102L,1110L,1111L,1112L,1120L,1121L,1122L,1123L,1200L,1201L,1202L,1203L,1210L,1211L,1212L,1213L,1220L,1221L,1222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125098Inst : IEnumerable<long>
{
public static readonly long[] Value=A125098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125098.Bytes);
public long this[int i]=>Value[i];

public static A125098Inst Instance=new A125098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125099
{
public static readonly long[] Value={ 10L,11L,101L,102L,110L,111L,120L,1000L,1001L,1002L,1010L,1011L,1020L,1021L,1022L,1100L,1101L,1110L,1111L,1112L,1120L,1121L,1202L,1210L,1211L,1212L,1220L,1221L,1230L,10001L,10002L,10010L,10011L,10020L,10021L,10022L,10100L,10101L,10110L,10111L,10112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125099Inst : IEnumerable<long>
{
public static readonly long[] Value=A125099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125099.Bytes);
public long this[int i]=>Value[i];

public static A125099Inst Instance=new A125099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125100
{
public static readonly long[] Value={ 1L,2L,1L,3L,4L,2L,4L,9L,9L,3L,5L,16L,24L,16L,5L,6L,25L,50L,50L,30L,8L,7L,36L,90L,120L,105L,54L,13L,8L,49L,147L,245L,280L,210L,98L,21L,9L,64L,224L,448L,630L,616L,420L,176L,34L,10L,81L,324L,756L,1260L,1512L,1344L,828L,315L,55L,11L,100L,450L,1200L,2310L,3276L,3570L,2880L,1620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125100Inst : IEnumerable<long>
{
public static readonly long[] Value=A125100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125100.Bytes);
public long this[int i]=>Value[i];

public static A125100Inst Instance=new A125100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125101
{
public static readonly long[] Value={ 1L,2L,2L,3L,5L,3L,4L,9L,11L,4L,5L,14L,26L,19L,5L,6L,20L,50L,55L,30L,6L,7L,27L,85L,125L,105L,44L,7L,8L,35L,133L,245L,280L,182L,62L,8L,9L,44L,196L,434L,630L,560L,300L,85L,9L,10L,54L,276L,714L,1260L,1428L,1056L,477L,115L,10L,11L,65L,375L,1110L,2310L,3192L,3030L,1905L,745L,155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125101Inst : IEnumerable<long>
{
public static readonly long[] Value=A125101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125101.Bytes);
public long this[int i]=>Value[i];

public static A125101Inst Instance=new A125101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125102
{
public static readonly long[] Value={ 1L,2L,2L,3L,6L,3L,4L,12L,10L,4L,5L,20L,22L,18L,5L,6L,30L,40L,50L,26L,6L,7L,42L,65L,110L,81L,38L,7L,8L,56L,98L,210L,196L,140L,50L,8L,9L,72L,140L,364L,406L,392L,204L,66L,9L,10L,90L,192L,588L,756L,924L,624L,306L,82L,10L,11L,110L,255L,900L,1302L,1932L,1590L,1050L,415L,102L,11L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125102Inst : IEnumerable<long>
{
public static readonly long[] Value=A125102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125102.Bytes);
public long this[int i]=>Value[i];

public static A125102Inst Instance=new A125102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125103
{
public static readonly long[] Value={ 1L,2L,1L,3L,4L,1L,4L,9L,7L,1L,5L,16L,22L,12L,1L,6L,25L,50L,50L,21L,1L,7L,36L,95L,140L,111L,38L,1L,8L,49L,161L,315L,371L,245L,71L,1L,9L,64L,252L,616L,966L,952L,540L,136L,1L,10L,81L,372L,1092L,2142L,2814L,2388L,1188L,265L,1L,11L,100L,525L,1800L,4242L,6972L,7890L,5880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125103Inst : IEnumerable<long>
{
public static readonly long[] Value=A125103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125103.Bytes);
public long this[int i]=>Value[i];

public static A125103Inst Instance=new A125103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125104
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,3L,1L,0L,1L,6L,1L,0L,0L,2L,13L,1L,0L,0L,1L,3L,27L,1L,0L,0L,0L,2L,5L,56L,1L,0L,0L,0L,1L,2L,9L,115L,1L,0L,0L,0L,0L,2L,3L,15L,235L,1L,0L,0L,0L,0L,1L,2L,5L,25L,478L,1L,0L,0L,0L,0L,0L,2L,2L,8L,42L,969L,1L,0L,0L,0L,0L,0L,1L,2L,3L,12L,70L,1959L,1L,0L,0L,0L,0L,0L,0L,2L,2L,5L,18L,116L,3952L,1L,0L,0L,0L,0L,0L,0L,1L,2L,2L,8L,27L,192L,7959L,1L,0L,0L,0L,0L,0L,0L,0L,2L,2L,3L,11L,41L,317L,16007L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125104Inst : IEnumerable<long>
{
public static readonly long[] Value=A125104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125104.Bytes);
public long this[int i]=>Value[i];

public static A125104Inst Instance=new A125104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125105
{
public static readonly long[] Value={ 1L,1L,4L,1L,12L,11L,1L,33L,47L,27L,1L,88L,185L,127L,63L,1L,232L,694L,563L,303L,143L,1L,609L,2526L,2400L,1394L,687L,319L,1L,1596L,9012L,9960L,6215L,3186L,1519L,703L,1L,4180L,31709L,40534L,27095L,14401L,7026L,3311L,1535L,1L,10945L,110469L,162538L,116143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125105Inst : IEnumerable<long>
{
public static readonly long[] Value=A125105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125105.Bytes);
public long this[int i]=>Value[i];

public static A125105Inst Instance=new A125105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125106
{
public static readonly long[] Value={ 1L,2L,1L,1L,3L,2L,1L,2L,2L,1L,1L,1L,4L,3L,1L,3L,2L,2L,1L,1L,3L,3L,2L,2L,1L,2L,2L,2L,1L,1L,1L,1L,5L,4L,1L,4L,2L,3L,1L,1L,4L,3L,3L,2L,1L,3L,2L,2L,2L,1L,1L,1L,4L,4L,3L,3L,1L,3L,3L,2L,2L,2L,1L,1L,3L,3L,3L,2L,2L,2L,1L,2L,2L,2L,2L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125106Inst : IEnumerable<long>
{
public static readonly long[] Value=A125106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125106.Bytes);
public long this[int i]=>Value[i];

public static A125106Inst Instance=new A125106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125107
{
public static readonly long[] Value={ 0L,0L,0L,1L,6L,26L,100L,365L,1302L,4606L,16284L,57762L,205964L,738804L,2666248L,9678461L,35324902L,129579254L,477507628L,1767001046L,6563596132L,24465218444L,91480466488L,343055419346L,1289895758716L,4861929624236L,18367319517720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125107Inst : IEnumerable<long>
{
public static readonly long[] Value=A125107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125107.Bytes);
public long this[int i]=>Value[i];

public static A125107Inst Instance=new A125107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125108
{
public static readonly long[] Value={ 1L,2L,4L,10L,26L,72L,202L,580L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125108Inst : IEnumerable<long>
{
public static readonly long[] Value=A125108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125108.Bytes);
public long this[int i]=>Value[i];

public static A125108Inst Instance=new A125108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125109
{
public static readonly long[] Value={ 766L,3194L,1800L,1362L,720L,1360L,1158L,140L,222L,198L,420L,280L,420L,420L,140L,700L,140L,280L,140L,840L,840L,280L,140L,280L,420L,140L,402L,298L,420L,420L,420L,140L,420L,280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125109Inst : IEnumerable<long>
{
public static readonly long[] Value=A125109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125109.Bytes);
public long this[int i]=>Value[i];

public static A125109Inst Instance=new A125109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125110
{
public static readonly long[] Value={ 0L,1L,8L,64L,125L,512L,729L,1000L,2197L,4096L,4913L,5832L,8000L,15625L,17576L,24389L,32768L,39304L,46656L,50653L,64000L,68921L,91125L,117649L,125000L,140608L,148877L,195112L,226981L,262144L,274625L,314432L,373248L,389017L,405224L,512000L,531441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125110Inst : IEnumerable<long>
{
public static readonly long[] Value=A125110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125110.Bytes);
public long this[int i]=>Value[i];

public static A125110Inst Instance=new A125110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125111
{
public static readonly long[] Value={ 27L,216L,343L,1331L,1728L,2744L,3375L,6859L,9261L,10648L,12167L,13824L,19683L,21952L,27000L,29791L,35937L,42875L,54872L,59319L,74088L,79507L,85184L,97336L,103823L,110592L,132651L,157464L,166375L,175616L,185193L,205379L,216000L,238328L,250047L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125111Inst : IEnumerable<long>
{
public static readonly long[] Value=A125111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125111.Bytes);
public long this[int i]=>Value[i];

public static A125111Inst Instance=new A125111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125176
{
public static readonly long[] Value={ 1L,3L,7L,14L,28L,56L,112L,224L,448L,896L,1792L,3584L,7168L,14336L,28672L,57344L,114688L,229376L,458752L,917504L,1835008L,3670016L,7340032L,14680064L,29360128L,58720256L,117440512L,234881024L,469762048L,939524096L,1879048192L,3758096384L,7516192768L,15032385536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125176Inst : IEnumerable<long>
{
public static readonly long[] Value=A125176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125176.Bytes);
public long this[int i]=>Value[i];

public static A125176Inst Instance=new A125176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125177
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,5L,4L,3L,1L,14L,9L,7L,4L,1L,42L,23L,16L,11L,5L,1L,132L,65L,39L,27L,16L,6L,1L,429L,197L,104L,66L,43L,22L,7L,1L,1430L,626L,301L,170L,109L,65L,29L,8L,1L,4862L,2056L,927L,471L,279L,174L,94L,37L,9L,1L,16796L,6918L,2983L,1398L,750L,453L,268L,131L,46L,10L,1L,58786L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125177Inst : IEnumerable<long>
{
public static readonly long[] Value=A125177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125177.Bytes);
public long this[int i]=>Value[i];

public static A125177Inst Instance=new A125177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125178
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,5L,4L,3L,1L,15L,9L,7L,4L,1L,52L,24L,16L,11L,5L,1L,203L,76L,40L,27L,16L,6L,1L,877L,279L,116L,67L,43L,22L,7L,1L,4140L,1156L,395L,183L,110L,65L,29L,8L,1L,21147L,5296L,1551L,578L,293L,175L,94L,37L,9L,1L,115975L,26443L,6847L,2129L,871L,468L,269L,131L,46L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125178Inst : IEnumerable<long>
{
public static readonly long[] Value=A125178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125178.Bytes);
public long this[int i]=>Value[i];

public static A125178Inst Instance=new A125178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125179
{
public static readonly long[] Value={ 2L,3L,2L,5L,5L,2L,7L,10L,7L,2L,11L,17L,17L,9L,2L,13L,28L,34L,26L,11L,2L,17L,41L,62L,60L,37L,13L,2L,19L,58L,103L,122L,97L,50L,15L,2L,23L,77L,161L,225L,219L,147L,65L,17L,2L,29L,100L,238L,386L,444L,366L,212L,82L,19L,2L,31L,129L,338L,624L,830L,810L,578L,294L,101L,21L,2L,37L,160L,467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125179Inst : IEnumerable<long>
{
public static readonly long[] Value=A125179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125179.Bytes);
public long this[int i]=>Value[i];

public static A125179Inst Instance=new A125179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125180
{
public static readonly long[] Value={ 2L,5L,12L,26L,56L,114L,232L,466L,936L,1878L,3758L,7522L,15048L,30098L,60200L,120406L,240818L,481638L,963282L,1926568L,3853138L,7706282L,15412568L,30825142L,61650292L,123300588L,246601178L,493202360L,986404722L,1972809448L,3945618910L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125180Inst : IEnumerable<long>
{
public static readonly long[] Value=A125180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125180.Bytes);
public long this[int i]=>Value[i];

public static A125180Inst Instance=new A125180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125181
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,4L,2L,6L,1L,1L,5L,5L,10L,10L,10L,1L,1L,6L,6L,15L,3L,30L,20L,5L,30L,15L,1L,1L,7L,7L,21L,7L,42L,35L,21L,21L,105L,35L,35L,70L,21L,1L,1L,8L,8L,28L,8L,56L,56L,4L,56L,28L,168L,70L,28L,84L,168L,280L,56L,14L,140L,140L,28L,1L,1L,9L,9L,36L,9L,72L,84L,9L,72L,36L,252L,126L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125181Inst : IEnumerable<long>
{
public static readonly long[] Value=A125181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125181.Bytes);
public long this[int i]=>Value[i];

public static A125181Inst Instance=new A125181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125182
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,1L,4L,12L,7L,1L,4L,38L,54L,23L,1L,8L,77L,248L,303L,83L,1L,6L,160L,824L,2008L,1636L,405L,1L,11L,285L,2320L,9449L,15789L,10352L,2113L,1L,10L,476L,5564L,37237L,102726L,133293L,70916L,12657L,1L,14L,799L,13172L,122708L,536900L,1158368L,1177168L,537373L,82297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125182Inst : IEnumerable<long>
{
public static readonly long[] Value=A125182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125182.Bytes);
public long this[int i]=>Value[i];

public static A125182Inst Instance=new A125182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125183
{
public static readonly long[] Value={ 1L,2L,0L,1L,5L,0L,3L,11L,6L,4L,1L,28L,55L,32L,4L,3L,69L,210L,330L,108L,0L,1L,102L,846L,2177L,1590L,324L,0L,4L,279L,2694L,11221L,17578L,7624L,888L,32L,1L,328L,7791L,54777L,135993L,123474L,37524L,2896L,96L,3L,961L,24032L,227906L,914364L,1427342L,839904L,182824L,11464L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125183Inst : IEnumerable<long>
{
public static readonly long[] Value=A125183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125183.Bytes);
public long this[int i]=>Value[i];

public static A125183Inst Instance=new A125183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125184
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,1L,0L,0L,1L,1L,2L,0L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,2L,1L,0L,1L,2L,1L,3L,1L,0L,0L,1L,1L,1L,2L,2L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,2L,1L,1L,0L,1L,2L,1L,1L,3L,3L,0L,0L,1L,2L,1L,4L,3L,0L,1L,3L,1L,1L,3L,2L,1L,0L,0L,0L,1L,1L,1L,2L,3L,1L,0L,1L,2L,2L,1L,3L,3L,1L,0L,0L,1L,1L,1L,1L,2L,2L,2L,0L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125184Inst : IEnumerable<long>
{
public static readonly long[] Value=A125184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125184.Bytes);
public long this[int i]=>Value[i];

public static A125184Inst Instance=new A125184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125185
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,3L,4L,10L,9L,4L,8L,24L,28L,16L,5L,16L,56L,80L,60L,25L,6L,32L,128L,216L,200L,110L,36L,7L,64L,288L,560L,616L,420L,182L,49L,8L,128L,640L,1408L,1792L,1456L,784L,280L,64L,9L,256L,1408L,3456L,4992L,4704L,3024L,1344L,408L,81L,10L,512L,3072L,8320L,13440L,14400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125185Inst : IEnumerable<long>
{
public static readonly long[] Value=A125185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125185.Bytes);
public long this[int i]=>Value[i];

public static A125185Inst Instance=new A125185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125186
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,3L,3L,4L,5L,5L,5L,6L,6L,6L,4L,7L,8L,9L,8L,10L,10L,10L,7L,11L,11L,12L,9L,12L,10L,10L,5L,11L,12L,15L,12L,17L,16L,17L,11L,18L,18L,20L,15L,20L,17L,17L,9L,18L,18L,22L,16L,23L,20L,21L,12L,21L,19L,22L,14L,20L,15L,15L,6L,16L,17L,23L,17L,27L,24L,27L,16L,29L,28L,33L,23L,33L,27L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125186Inst : IEnumerable<long>
{
public static readonly long[] Value=A125186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125186.Bytes);
public long this[int i]=>Value[i];

public static A125186Inst Instance=new A125186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125187
{
public static readonly long[] Value={ 1L,1L,3L,12L,52L,232L,1049L,4777L,21845L,100159L,460023L,2115350L,9735205L,44829766L,206526972L,951759621L,4387156587L,20226421380L,93264500832L,430091815527L,1983549213861L,9148582037193L,42197572190160L,194643215702835L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125187Inst : IEnumerable<long>
{
public static readonly long[] Value=A125187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125187.Bytes);
public long this[int i]=>Value[i];

public static A125187Inst Instance=new A125187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125188
{
public static readonly long[] Value={ 1L,1L,3L,12L,54L,259L,1294L,6655L,34986L,187149L,1015407L,5574829L,30915904L,172933249L,974605751L,5528804444L,31546576802L,180931023589L,1042503934315L,6031773336043L,35030156585236L,204135876541762L,1193291688154639L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125188Inst : IEnumerable<long>
{
public static readonly long[] Value=A125188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125188.Bytes);
public long this[int i]=>Value[i];

public static A125188Inst Instance=new A125188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125189
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,5L,7L,11L,17L,27L,42L,68L,107L,175L,278L,458L,733L,1215L,1956L,3258L,5271L,8815L,14321L,24031L,39181L,65937L,107840L,181936L,298367L,504473L,829307L,1404879L,2314453L,3927495L,6482788L,11017802L,18217839L,31004871L,51347351L,87497297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125189Inst : IEnumerable<long>
{
public static readonly long[] Value=A125189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125189.Bytes);
public long this[int i]=>Value[i];

public static A125189Inst Instance=new A125189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125190
{
public static readonly long[] Value={ 0L,1L,6L,32L,170L,912L,4942L,27008L,148626L,822560L,4573910L,25534368L,143027898L,803467056L,4524812190L,25537728000L,144411206178L,818017823808L,4640757865126L,26364054632480L,149959897539018L,853941394691792L,4867745532495086L,27773897706129792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125190Inst : IEnumerable<long>
{
public static readonly long[] Value=A125190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125190.Bytes);
public long this[int i]=>Value[i];

public static A125190Inst Instance=new A125190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125191
{
public static readonly BigInteger[] Value={ 2L,7L,37L,239L,241L,2521L,32341L,540539L,540541L,232792559L,232792561L,207030183359L,311671001662019L,BigInteger.Parse("41287621429375723111588738861"),BigInteger.Parse("5801527386969669153864265802424086050777441586253956297278498679") };
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
public class A125191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125191Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A125191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125191.Bytes);
public BigInteger this[int i]=>Value[i];

public static A125191Inst Instance=new A125191Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125224
{
public static readonly long[] Value={ 1L,1L,2L,6L,26L,148L,1016L,7978L,69453L,657225L,6670401L,71920229L,817945093L,9758974790L,121626871825L,1577990961146L,21252296024422L,296427097326849L,4273527067114321L,63574838609892291L,974520726668356856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125224Inst : IEnumerable<long>
{
public static readonly long[] Value=A125224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125224.Bytes);
public long this[int i]=>Value[i];

public static A125224Inst Instance=new A125224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125225
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,12L,16L,18L,20L,24L,28L,30L,32L,36L,40L,42L,48L,54L,56L,60L,64L,66L,70L,72L,78L,80L,84L,88L,90L,96L,100L,104L,108L,112L,120L,126L,128L,132L,140L,144L,150L,156L,160L,162L,168L,176L,180L,192L,196L,198L,200L,204L,208L,210L,216L,220L,224L,228L,234L,240L,252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125225Inst : IEnumerable<long>
{
public static readonly long[] Value=A125225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125225.Bytes);
public long this[int i]=>Value[i];

public static A125225Inst Instance=new A125225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125226
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,0L,0L,2L,2L,0L,0L,1L,4L,1L,0L,0L,0L,4L,4L,0L,0L,0L,0L,3L,9L,3L,0L,0L,0L,0L,1L,11L,11L,1L,0L,0L,0L,0L,0L,8L,21L,8L,0L,0L,0L,0L,0L,0L,4L,27L,27L,4L,0L,0L,0L,0L,0L,0L,1L,23L,52L,23L,1L,0L,0L,0L,0L,0L,0L,0L,13L,67L,67L,13L,0L,0L,0L,0L,0L,0L,0L,0L,5L,62L,127L,62L,5L,0L,0L,0L,0L,0L,0L,0L,0L,1L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125226Inst : IEnumerable<long>
{
public static readonly long[] Value=A125226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125226.Bytes);
public long this[int i]=>Value[i];

public static A125226Inst Instance=new A125226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125227
{
public static readonly long[] Value={ 1L,3L,7L,9L,21L,27L,49L,57L,63L,81L,147L,171L,189L,219L,243L,301L,343L,399L,441L,513L,567L,657L,729L,889L,903L,1029L,1083L,1197L,1323L,1533L,1539L,1701L,1971L,2107L,2187L,2359L,2401L,2667L,2709L,2793L,3087L,3249L,3591L,3969L,4161L,4401L,4599L,4617L,5103L,5913L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125227Inst : IEnumerable<long>
{
public static readonly long[] Value=A125227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125227.Bytes);
public long this[int i]=>Value[i];

public static A125227Inst Instance=new A125227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125228
{
public static readonly long[] Value={ 1L,7L,21L,39L,65L,93L,135L,179L,227L,285L,349L,415L,495L,573L,663L,759L,859L,963L,1071L,1199L,1325L,1457L,1591L,1735L,1891L,2049L,2207L,2383L,2557L,2735L,2929L,3123L,3327L,3529L,3739L,3955L,4191L,4427L,4665L,4901L,5159L,5413L,5681L,5951L,6231L,6515L,6799L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125228Inst : IEnumerable<long>
{
public static readonly long[] Value=A125228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125228.Bytes);
public long this[int i]=>Value[i];

public static A125228Inst Instance=new A125228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125229
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,2L,3L,4L,4L,5L,6L,7L,7L,8L,9L,9L,10L,11L,12L,12L,13L,14L,15L,15L,16L,17L,18L,18L,19L,20L,21L,21L,22L,23L,24L,25L,25L,26L,27L,28L,28L,29L,30L,31L,32L,32L,33L,34L,35L,35L,36L,37L,38L,39L,39L,40L,41L,42L,42L,43L,44L,45L,46L,46L,47L,48L,49L,50L,50L,51L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125229Inst : IEnumerable<long>
{
public static readonly long[] Value=A125229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125229.Bytes);
public long this[int i]=>Value[i];

public static A125229Inst Instance=new A125229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125230
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,6L,4L,1L,1L,10L,11L,5L,1L,1L,15L,25L,16L,6L,1L,1L,21L,50L,42L,22L,7L,1L,1L,28L,91L,98L,64L,29L,8L,1L,1L,36L,154L,210L,163L,93L,37L,9L,1L,1L,45L,246L,420L,381L,256L,130L,46L,10L,1L,1L,55L,375L,792L,837L,638L,386L,176L,56L,11L,1L,1L,66L,550L,1419L,1749L,1485L,1024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125230Inst : IEnumerable<long>
{
public static readonly long[] Value=A125230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125230.Bytes);
public long this[int i]=>Value[i];

public static A125230Inst Instance=new A125230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125231
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,3L,6L,2L,1L,4L,12L,8L,3L,1L,5L,20L,20L,15L,3L,1L,6L,30L,40L,45L,18L,4L,1L,7L,42L,70L,105L,63L,28L,4L,1L,8L,56L,112L,210L,168L,112L,32L,5L,1L,9L,72L,168L,378L,378L,336L,144L,45L,5L,1L,10L,90L,240L,630L,756L,840L,480L,225L,50L,6L,1L,11L,110L,330L,990L,1386L,1848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125231Inst : IEnumerable<long>
{
public static readonly long[] Value=A125231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125231.Bytes);
public long this[int i]=>Value[i];

public static A125231Inst Instance=new A125231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125232
{
public static readonly long[] Value={ 1L,5L,1L,12L,6L,1L,22L,18L,7L,1L,35L,40L,25L,8L,1L,51L,75L,65L,33L,9L,1L,70L,126L,140L,98L,42L,10L,1L,92L,196L,266L,238L,140L,52L,11L,1L,117L,288L,462L,504L,378L,192L,63L,12L,1L,145L,405L,750L,966L,882L,570L,255L,75L,13L,1L,176L,550L,1155L,1716L,1848L,1452L,825L,330L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125232Inst : IEnumerable<long>
{
public static readonly long[] Value=A125232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125232.Bytes);
public long this[int i]=>Value[i];

public static A125232Inst Instance=new A125232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125233
{
public static readonly long[] Value={ 1L,6L,1L,15L,7L,1L,28L,22L,8L,1L,45L,50L,30L,9L,1L,66L,95L,80L,39L,10L,1L,91L,161L,175L,119L,49L,11L,1L,120L,252L,336L,294L,168L,60L,12L,1L,153L,372L,588L,630L,462L,228L,72L,13L,1L,190L,525L,960L,1218L,1092L,690L,300L,85L,14L,1L,231L,715L,1485L,2178L,2310L,1782L,990L,385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125233Inst : IEnumerable<long>
{
public static readonly long[] Value=A125233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125233.Bytes);
public long this[int i]=>Value[i];

public static A125233Inst Instance=new A125233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125234
{
public static readonly long[] Value={ 1L,7L,1L,18L,8L,1L,34L,26L,9L,1L,55L,60L,35L,10L,1L,81L,115L,95L,45L,11L,1L,112L,196L,210L,140L,56L,12L,1L,148L,308L,406L,350L,196L,68L,13L,1L,189L,456L,714L,756L,546L,264L,81L,14L,1L,235L,645L,1170L,1470L,1302L,810L,345L,95L,15L,1L,286L,880L,1815L,2640L,2772L,2112L,1155L,440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125234Inst : IEnumerable<long>
{
public static readonly long[] Value=A125234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125234.Bytes);
public long this[int i]=>Value[i];

public static A125234Inst Instance=new A125234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125235
{
public static readonly long[] Value={ 1L,8L,1L,21L,9L,1L,40L,30L,10L,1L,65L,70L,40L,11L,1L,96L,135L,110L,51L,12L,1L,133L,231L,245L,161L,63L,13L,1L,176L,364L,476L,406L,224L,76L,14L,1L,225L,540L,840L,882L,630L,300L,90L,15L,1L,280L,765L,1380L,1722L,1512L,930L,390L,105L,16L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125235Inst : IEnumerable<long>
{
public static readonly long[] Value=A125235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125235.Bytes);
public long this[int i]=>Value[i];

public static A125235Inst Instance=new A125235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125236
{
public static readonly long[] Value={ 3L,5L,6L,7L,9L,10L,11L,14L,15L,17L,18L,22L,24L,26L,28L,29L,30L,31L,33L,34L,35L,44L,47L,50L,56L,58L,61L,65L,66L,67L,68L,69L,71L,72L,74L,75L,80L,85L,91L,94L,96L,97L,100L,101L,102L,104L,116L,118L,120L,121L,124L,125L,127L,131L,134L,136L,139L,144L,148L,149L,152L,164L,166L,170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125236Inst : IEnumerable<long>
{
public static readonly long[] Value=A125236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125236.Bytes);
public long this[int i]=>Value[i];

public static A125236Inst Instance=new A125236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125237
{
public static readonly long[] Value={ 3L,9L,10L,18L,50L,100L,104L,121L,136L,289L,464L,576L,650L,900L,5041L,6962L,7225L,10201L,14400L,55225L,65025L,87025L,102152L,147456L,171698L,174050L,179776L,182329L,189225L,201601L,222784L,291848L,312481L,380689L,410881L,469225L,481636L,488601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125237Inst : IEnumerable<long>
{
public static readonly long[] Value=A125237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125237.Bytes);
public long this[int i]=>Value[i];

public static A125237Inst Instance=new A125237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125238
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,2L,1L,1L,2L,1L,1L,2L,2L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,1L,1L,2L,2L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125238Inst : IEnumerable<long>
{
public static readonly long[] Value=A125238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125238.Bytes);
public long this[int i]=>Value[i];

public static A125238Inst Instance=new A125238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125239
{
public static readonly long[] Value={ 11L,31L,61L,101L,151L,211L,281L,19L,11L,19L,661L,11L,911L,1051L,1201L,1361L,1531L,29L,1901L,11L,2311L,2531L,11L,3001L,3251L,3511L,19L,31L,19L,4651L,11L,5281L,31L,11L,6301L,6661L,79L,7411L,29L,59L,79L,11L,9461L,9901L,11L,19L,29L,19L,12251L,41L,89L,13781L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125239Inst : IEnumerable<long>
{
public static readonly long[] Value=A125239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125239.Bytes);
public long this[int i]=>Value[i];

public static A125239Inst Instance=new A125239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125240
{
public static readonly long[] Value={ 1L,16L,36L,67L,95L,369L,383L,745L,1599L,2006L,2104L,2879L,3061L,9048L,9902L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125240Inst : IEnumerable<long>
{
public static readonly long[] Value=A125240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125240.Bytes);
public long this[int i]=>Value[i];

public static A125240Inst Instance=new A125240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125241
{
public static readonly long[] Value={ 1L,2L,6L,10L,11L,19L,28L,80L,123L,141L,147L,154L,198L,200L,346L,851L,887L,1038L,1329L,2045L,3228L,3274L,3588L,6794L,8045L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125241Inst : IEnumerable<long>
{
public static readonly long[] Value=A125241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125241.Bytes);
public long this[int i]=>Value[i];

public static A125241Inst Instance=new A125241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125242
{
public static readonly long[] Value={ 5L,71L,111L,187L,239L,247L,473L,628L,847L,1478L,2687L,3530L,5175L,9113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125242Inst : IEnumerable<long>
{
public static readonly long[] Value=A125242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125242.Bytes);
public long this[int i]=>Value[i];

public static A125242Inst Instance=new A125242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125243
{
public static readonly long[] Value={ 22L,86L,154L,160L,488L,705L,958L,975L,1262L,1932L,2845L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125243Inst : IEnumerable<long>
{
public static readonly long[] Value=A125243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125243.Bytes);
public long this[int i]=>Value[i];

public static A125243Inst Instance=new A125243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125244
{
public static readonly long[] Value={ 1L,7L,17L,22L,43L,343L,381L,461L,543L,923L,1045L,1182L,1486L,1839L,5643L,8260L,9009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125244Inst : IEnumerable<long>
{
public static readonly long[] Value=A125244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125244.Bytes);
public long this[int i]=>Value[i];

public static A125244Inst Instance=new A125244Inst();

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