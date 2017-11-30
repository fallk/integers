using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A283667
{
public static readonly long[] Value={ 1L,3L,13L,64L,334L,1802L,9933L,55575L,314362L,1793126L,10295625L,59430043L,344559826L,2005026610L,11703965955L,68503652100L,401892122682L,2362629703214L,13914547415998L,82081163986020L,484893156220356L,2868234297838092L,16986185485228431L,100703275233924096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283667Inst : IEnumerable<long>
{
public static readonly long[] Value=A283667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283667.Bytes);
public long this[int i]=>Value[i];

public static A283667Inst Instance=new A283667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283668
{
public static readonly long[] Value={ 1L,3L,6L,11L,22L,25L,31L,35L,36L,39L,49L,51L,58L,65L,67L,69L,81L,85L,86L,92L,97L,99L,100L,110L,115L,119L,125L,126L,133L,135L,142L,144L,149L,150L,153L,161L,164L,165L,167L,169L,172L,174L,175L,176L,186L,194L,199L,201L,206L,208L,210L,214L,217L,224L,231L,235L,236L,239L,240L,242L,244L,247L,251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283668Inst : IEnumerable<long>
{
public static readonly long[] Value=A283668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283668.Bytes);
public long this[int i]=>Value[i];

public static A283668Inst Instance=new A283668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283669
{
public static readonly long[] Value={ 0L,-1L,-1L,0L,-1L,-1L,0L,0L,0L,0L,-2L,0L,0L,-1L,0L,-1L,-1L,0L,0L,0L,0L,0L,-2L,2L,0L,0L,0L,0L,0L,-1L,1L,0L,-1L,1L,2L,0L,-1L,0L,-1L,-1L,0L,0L,0L,0L,0L,0L,-4L,3L,-2L,-4L,2L,2L,-2L,0L,0L,-2L,0L,0L,0L,0L,0L,-1L,3L,4L,-3L,1L,-1L,0L,3L,4L,2L,1L,-2L,-1L,2L,-2L,1L,-1L,0L,1L,1L,0L,-2L,1L,-1L,-1L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283669Inst : IEnumerable<long>
{
public static readonly long[] Value=A283669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283669.Bytes);
public long this[int i]=>Value[i];

public static A283669Inst Instance=new A283669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283670
{
public static readonly long[] Value={ 4L,4L,9L,4L,4L,9L,4L,4L,25L,9L,4L,4L,4L,4L,9L,4L,49L,25L,4L,9L,4L,4L,9L,4L,4L,25L,4L,4L,9L,4L,4L,9L,4L,4L,49L,9L,4L,4L,4L,9L,4L,121L,4L,25L,9L,4L,4L,9L,4L,4L,49L,4L,25L,4L,9L,4L,4L,9L,4L,4L,169L,9L,4L,25L,4L,4L,4L,9L,4L,9L,4L,9L,4L,4L,4L,4L,4L,4L,9L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283670Inst : IEnumerable<long>
{
public static readonly long[] Value=A283670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283670.Bytes);
public long this[int i]=>Value[i];

public static A283670Inst Instance=new A283670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283671
{
public static readonly long[] Value={ 2L,2L,3L,2L,2L,3L,2L,2L,5L,3L,2L,2L,2L,2L,3L,2L,7L,5L,2L,3L,2L,2L,3L,2L,2L,5L,2L,2L,3L,2L,2L,3L,2L,2L,7L,3L,2L,2L,2L,3L,2L,11L,2L,5L,3L,2L,2L,3L,2L,2L,7L,2L,5L,2L,3L,2L,2L,3L,2L,2L,13L,3L,2L,5L,2L,2L,2L,3L,2L,3L,2L,3L,2L,2L,2L,2L,2L,2L,3L,2L,2L,11L,3L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283671Inst : IEnumerable<long>
{
public static readonly long[] Value=A283671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283671.Bytes);
public long this[int i]=>Value[i];

public static A283671Inst Instance=new A283671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283672
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,3L,3L,3L,4L,1L,4L,5L,1L,5L,1L,1L,6L,6L,6L,6L,8L,2L,2L,8L,8L,8L,8L,10L,1L,1L,10L,1L,1L,1L,11L,1L,11L,1L,1L,12L,12L,12L,12L,12L,16L,2L,1L,2L,4L,2L,2L,2L,14L,16L,2L,16L,16L,16L,16L,20L,1L,1L,1L,1L,1L,1L,20L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,22L,1L,1L,23L,1L,1L,1L,1L,23L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283672Inst : IEnumerable<long>
{
public static readonly long[] Value=A283672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283672.Bytes);
public long this[int i]=>Value[i];

public static A283672Inst Instance=new A283672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283673
{
public static readonly long[] Value={ 1L,2L,2L,2L,6L,6L,3L,3L,3L,4L,15L,4L,5L,20L,5L,30L,30L,6L,6L,6L,6L,8L,24L,24L,8L,8L,8L,8L,10L,72L,72L,10L,110L,90L,99L,11L,110L,11L,132L,132L,12L,12L,12L,12L,12L,16L,70L,154L,112L,48L,84L,112L,112L,14L,16L,112L,16L,16L,16L,16L,20L,272L,238L,357L,304L,272L,380L,20L,340L,357L,399L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283673Inst : IEnumerable<long>
{
public static readonly long[] Value=A283673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283673.Bytes);
public long this[int i]=>Value[i];

public static A283673Inst Instance=new A283673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283674
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,5L,3L,1L,1L,17L,32L,5L,1L,1L,65L,746L,298L,7L,1L,1L,257L,19748L,66418L,3531L,11L,1L,1L,1025L,531698L,16799044L,9843707L,51609L,15L,1L,1L,4097L,14349932L,4295531890L,30535636881L,2187941520L,894834L,22L,1L,1L,16385L,387424586L,1099526502508L,95371863221411L,101591759812967L,680615139257L,17980052L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283674Inst : IEnumerable<long>
{
public static readonly long[] Value=A283674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283674.Bytes);
public long this[int i]=>Value[i];

public static A283674Inst Instance=new A283674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283675
{
public static readonly long[] Value={ 1L,1L,-1L,1L,-1L,-1L,1L,-1L,-4L,0L,1L,-1L,-16L,-23L,0L,1L,-1L,-64L,-713L,-223L,1L,1L,-1L,-256L,-19619L,-64687L,-2767L,0L,1L,-1L,-1024L,-531185L,-16755517L,-9688545L,-42268L,1L,1L,-1L,-4096L,-14347883L,-4294403215L,-30499543213L,-2165715003L,-759008L,0L,1L,-1L,-16384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283675Inst : IEnumerable<long>
{
public static readonly long[] Value=A283675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283675.Bytes);
public long this[int i]=>Value[i];

public static A283675Inst Instance=new A283675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283676
{
public static readonly long[] Value={ 0L,1L,9L,15L,47L,89L,357L,537L,697L,1037L,1257L,1643L,1723L,1995L,2333L,2357L,2863L,3395L,3593L,4795L,5187L,5349L,5469L,5759L,5859L,6339L,6573L,8097L,8653L,8683L,8773L,8827L,8947L,10213L,10609L,10959L,11407L,12325L,13365L,14109L,15549L,18589L,18639L,19343L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283676Inst : IEnumerable<long>
{
public static readonly long[] Value=A283676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283676.Bytes);
public long this[int i]=>Value[i];

public static A283676Inst Instance=new A283676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283677
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,2L,6L,3L,12L,12L,4L,4L,4L,4L,20L,5L,30L,35L,35L,42L,24L,24L,56L,56L,56L,8L,8L,8L,8L,8L,72L,9L,90L,99L,36L,36L,60L,130L,70L,70L,154L,165L,165L,60L,60L,60L,195L,208L,208L,112L,112L,112L,240L,240L,240L,240L,16L,16L,16L,16L,16L,16L,272L,17L,306L,323L,340L,357L,357L,126L,198L,414L,72L,72L,456L,475L,494L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283677Inst : IEnumerable<long>
{
public static readonly long[] Value=A283677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283677.Bytes);
public long this[int i]=>Value[i];

public static A283677Inst Instance=new A283677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283678
{
public static readonly BigInteger[] Value={ 1L,2L,54L,4500L,771750L,225042300L,99843767100L,62673358948200L,52880646612543750L,BigInteger.Parse("57733914846094987500"),BigInteger.Parse("79199384385873103852500"),BigInteger.Parse("133357363417740148141455000"),BigInteger.Parse("270426506783940730406180497500"),BigInteger.Parse("650063718230626755784087734375000"),BigInteger.Parse("1827886309419060919156885553671875000") };
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
public class A283678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283678Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A283678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283678.Bytes);
public BigInteger this[int i]=>Value[i];

public static A283678Inst Instance=new A283678Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283679
{
public static readonly long[] Value={ 0L,1L,3L,12L,48L,197L,815L,3391L,14153L,59185L,247791L,1038186L,4351706L,18245861L,76514483L,320899470L,1345931153L,5645394769L,23679726926L,99326654214L,416638208001L,1747652017025L,7330817809523L,30750407615699L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283679Inst : IEnumerable<long>
{
public static readonly long[] Value=A283679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283679.Bytes);
public long this[int i]=>Value[i];

public static A283679Inst Instance=new A283679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283680
{
public static readonly long[] Value={ 1L,3L,5L,7L,11L,13L,15L,17L,21L,23L,25L,27L,33L,35L,37L,39L,43L,45L,47L,53L,55L,57L,63L,65L,67L,69L,73L,75L,77L,85L,87L,91L,93L,95L,97L,103L,105L,107L,113L,115L,117L,123L,127L,133L,135L,137L,143L,145L,147L,153L,155L,157L,163L,165L,167L,173L,175L,177L,183L,185L,187L,193L,195L,203L,205L,207L,209L,213L,215L,217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283680Inst : IEnumerable<long>
{
public static readonly long[] Value=A283680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283680.Bytes);
public long this[int i]=>Value[i];

public static A283680Inst Instance=new A283680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283681
{
public static readonly long[] Value={ 1L,2L,2L,2L,4L,3L,2L,4L,6L,4L,4L,4L,6L,8L,5L,3L,8L,6L,8L,10L,6L,2L,6L,12L,8L,10L,12L,7L,4L,4L,9L,16L,10L,12L,14L,8L,6L,8L,6L,12L,20L,12L,14L,16L,9L,4L,12L,12L,8L,15L,24L,14L,16L,18L,10L,4L,8L,18L,16L,10L,18L,28L,16L,18L,20L,11L,4L,8L,12L,24L,20L,12L,21L,32L,18L,20L,22L,12L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283681Inst : IEnumerable<long>
{
public static readonly long[] Value=A283681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283681.Bytes);
public long this[int i]=>Value[i];

public static A283681Inst Instance=new A283681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283794
{
public static readonly long[] Value={ 1L,4L,6L,9L,10L,13L,15L,16L,19L,21L,24L,25L,26L,29L,31L,34L,35L,38L,40L,41L,42L,45L,47L,50L,51L,54L,56L,57L,60L,62L,65L,66L,67L,68L,71L,73L,76L,77L,80L,82L,83L,86L,88L,91L,92L,93L,96L,98L,101L,102L,105L,107L,108L,109L,110L,113L,115L,118L,119L,122L,124L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283794Inst : IEnumerable<long>
{
public static readonly long[] Value=A283794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283794.Bytes);
public long this[int i]=>Value[i];

public static A283794Inst Instance=new A283794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283795
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,6L,6L,1L,1L,8L,14L,8L,1L,1L,20L,40L,40L,20L,1L,1L,12L,42L,44L,42L,12L,1L,1L,42L,126L,210L,210L,126L,42L,1L,1L,32L,136L,224L,350L,224L,136L,32L,1L,1L,54L,216L,546L,756L,756L,546L,216L,54L,1L,1L,40L,260L,480L,1200L,1032L,1200L,480L,260L,40L,1L,1L,110L,550L,1650L,3300L,4620L,4620L,3300L,1650L,550L,110L,1L,1L,48L,324L,992L,2538L,3168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283795Inst : IEnumerable<long>
{
public static readonly long[] Value=A283795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283795.Bytes);
public long this[int i]=>Value[i];

public static A283795Inst Instance=new A283795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283796
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,4L,4L,1L,1L,6L,6L,6L,1L,1L,6L,12L,12L,6L,1L,1L,8L,18L,22L,18L,8L,1L,1L,8L,24L,38L,38L,24L,8L,1L,1L,16L,38L,80L,86L,80L,38L,16L,1L,1L,10L,40L,88L,132L,132L,88L,40L,10L,1L,1L,12L,50L,128L,220L,262L,220L,128L,50L,12L,1L,1L,12L,60L,170L,340L,472L,472L,340L,170L,60L,12L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283796Inst : IEnumerable<long>
{
public static readonly long[] Value=A283796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283796.Bytes);
public long this[int i]=>Value[i];

public static A283796Inst Instance=new A283796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283797
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,3L,3L,1L,1L,0L,8L,0L,1L,1L,15L,30L,30L,15L,1L,1L,0L,15L,0L,15L,0L,1L,1L,35L,105L,175L,175L,105L,35L,1L,1L,0L,64L,0L,192L,0L,64L,0L,1L,1L,27L,108L,390L,378L,378L,390L,108L,27L,1L,1L,0L,135L,0L,570L,0L,570L,0L,135L,0L,1L,1L,99L,495L,1485L,2970L,4158L,4158L,2970L,1485L,495L,99L,1L,1L,0L,72L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283797Inst : IEnumerable<long>
{
public static readonly long[] Value=A283797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283797.Bytes);
public long this[int i]=>Value[i];

public static A283797Inst Instance=new A283797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283798
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,3L,3L,1L,1L,0L,4L,0L,1L,1L,5L,10L,10L,5L,1L,1L,0L,9L,0L,9L,0L,1L,1L,7L,21L,35L,35L,21L,7L,1L,1L,0L,16L,0L,44L,0L,16L,0L,1L,1L,9L,36L,84L,126L,126L,84L,36L,9L,1L,1L,0L,25L,0L,100L,0L,100L,0L,25L,0L,1L,1L,11L,55L,165L,330L,462L,462L,330L,165L,55L,11L,1L,1L,0L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283798Inst : IEnumerable<long>
{
public static readonly long[] Value=A283798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283798.Bytes);
public long this[int i]=>Value[i];

public static A283798Inst Instance=new A283798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283799
{
public static readonly long[] Value={ 1L,2L,5L,12L,36L,90L,286L,728L,2380L,6120L,20349L,52668L,177100L,460460L,1560780L,4071600L,13884156L,36312408L,124403620L,326023280L,1121099408L,2942885946L,10150595910L,26681566392L,92263734836L,242799302200L,841392966470L,2216352204360L,7694644696200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283799Inst : IEnumerable<long>
{
public static readonly long[] Value=A283799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283799.Bytes);
public long this[int i]=>Value[i];

public static A283799Inst Instance=new A283799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283800
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,11L,15L,17L,19L,21L,23L,25L,27L,29L,33L,35L,43L,45L,47L,49L,51L,53L,55L,57L,59L,61L,63L,65L,69L,71L,73L,75L,77L,79L,81L,83L,87L,89L,95L,97L,99L,101L,105L,107L,113L,127L,129L,133L,135L,137L,139L,141L,143L,145L,147L,151L,153L,155L,157L,159L,161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283800Inst : IEnumerable<long>
{
public static readonly long[] Value=A283800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283800.Bytes);
public long this[int i]=>Value[i];

public static A283800Inst Instance=new A283800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283801
{
public static readonly BigInteger[] Value={ 9L,915L,91521L,9152125L,915212527L,91521252733L,9152125273335L,915212527333539L,91521252733353945L,9152125273335394549L,BigInteger.Parse("915212527333539454951"),BigInteger.Parse("91521252733353945495155"),BigInteger.Parse("9152125273335394549515557"),BigInteger.Parse("915212527333539454951555763"),BigInteger.Parse("91521252733353945495155576365") };
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
public class A283801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283801Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A283801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283801.Bytes);
public BigInteger this[int i]=>Value[i];

public static A283801Inst Instance=new A283801Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283802
{
public static readonly long[] Value={ 21L,73L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283802Inst : IEnumerable<long>
{
public static readonly long[] Value=A283802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283802.Bytes);
public long this[int i]=>Value[i];

public static A283802Inst Instance=new A283802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283803
{
public static readonly BigInteger[] Value={ 1L,-1L,-256L,-531185L,-4294403215L,-95363000657073L,-4738284730302658391L,BigInteger.Parse("-459981771468075494207385"),BigInteger.Parse("-79227701254823507875355278590"),BigInteger.Parse("-22528320196093613328344381426130010"),BigInteger.Parse("-9999977451048811940735941180766259658078") };
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
public class A283803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283803Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A283803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283803.Bytes);
public BigInteger this[int i]=>Value[i];

public static A283803Inst Instance=new A283803Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283804
{
public static readonly long[] Value={ 38L,110L,175L,212L,245L,290L,410L,434L,470L,539L,595L,610L,670L,830L,890L,902L,962L,1110L,1190L,1220L,1460L,1972L,2010L,2090L,2166L,2210L,2670L,2812L,3020L,3185L,3260L,4030L,4270L,4690L,4780L,5420L,5525L,5790L,6140L,6290L,6340L,6740L,6890L,7310L,7460L,7532L,7550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283804Inst : IEnumerable<long>
{
public static readonly long[] Value=A283804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283804.Bytes);
public long this[int i]=>Value[i];

public static A283804Inst Instance=new A283804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283805
{
public static readonly long[] Value={ 14L,102L,110L,164L,212L,290L,434L,595L,1060L,1068L,1110L,1112L,1190L,1220L,1284L,1356L,1448L,1460L,1572L,1668L,1804L,1884L,1938L,2090L,2108L,2892L,3185L,3770L,3972L,5358L,9790L,10010L,10020L,10040L,10100L,10136L,10220L,10448L,10536L,10664L,10668L,10868L,10998L,11052L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283805Inst : IEnumerable<long>
{
public static readonly long[] Value=A283805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283805.Bytes);
public long this[int i]=>Value[i];

public static A283805Inst Instance=new A283805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283806
{
public static readonly long[] Value={ 3L,5L,17L,29L,41L,53L,59L,65L,89L,97L,119L,137L,163L,179L,185L,191L,193L,209L,217L,219L,221L,223L,233L,239L,247L,253L,269L,281L,305L,307L,311L,343L,359L,389L,403L,407L,415L,419L,427L,431L,457L,491L,505L,521L,533L,545L,547L,557L,569L,575L,581L,583L,597L,613L,637L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283806Inst : IEnumerable<long>
{
public static readonly long[] Value=A283806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283806.Bytes);
public long this[int i]=>Value[i];

public static A283806Inst Instance=new A283806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283807
{
public static readonly long[] Value={ 2L,3L,7L,47L,97L,241L,5051L,204329L,217069L,29002021L,190346677L,3568762019L,221167421L,18725346527L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283807Inst : IEnumerable<long>
{
public static readonly long[] Value=A283807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283807.Bytes);
public long this[int i]=>Value[i];

public static A283807Inst Instance=new A283807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283808
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,10L,12L,14L,16L,18L,20L,24L,28L,32L,36L,40L,48L,54L,56L,64L,72L,80L,96L,108L,112L,128L,144L,160L,162L,192L,216L,224L,256L,288L,320L,324L,384L,432L,448L,486L,512L,576L,640L,648L,768L,864L,896L,972L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283808Inst : IEnumerable<long>
{
public static readonly long[] Value=A283808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283808.Bytes);
public long this[int i]=>Value[i];

public static A283808Inst Instance=new A283808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283809
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,10L,17L,23L,30L,33L,38L,47L,58L,70L,77L,87L,95L,103L,107L,110L,137L,138L,143L,170L,177L,182L,205L,213L,215L,217L,238L,247L,278L,283L,287L,298L,313L,322L,347L,355L,357L,373L,385L,390L,397L,443L,455L,465L,467L,542L,543L,555L,562L,565L,577L,590L,593L,597L,642L,653L,655L,667L,670L,682L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283809Inst : IEnumerable<long>
{
public static readonly long[] Value=A283809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283809.Bytes);
public long this[int i]=>Value[i];

public static A283809Inst Instance=new A283809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283842
{
public static readonly long[] Value={ 0L,0L,0L,2L,15L,75L,319L,1256L,4754L,17624L,64613L,235465L,855293L,3101198L,11233632L,40670374L,147200107L,532681447L,1927472251L,6974085108L,25233326446L,91296730996L,330318071345L,1195108798917L,4323957832185L,15644253554970L,56601495391164L,204786242735426L,740923803830199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283842Inst : IEnumerable<long>
{
public static readonly long[] Value=A283842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283842.Bytes);
public long this[int i]=>Value[i];

public static A283842Inst Instance=new A283842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283843
{
public static readonly long[] Value={ 3L,3L,5L,5L,9L,13L,21L,33L,61L,105L,189L,345L,633L,1173L,2193L,4097L,7713L,14573L,27597L,52433L,99881L,190653L,364725L,699073L,1342185L,2581113L,4971069L,9586985L,18512793L,35791473L,69273669L,134217729L,260301177L,505290273L,981706833L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283843Inst : IEnumerable<long>
{
public static readonly long[] Value=A283843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283843.Bytes);
public long this[int i]=>Value[i];

public static A283843Inst Instance=new A283843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283844
{
public static readonly long[] Value={ 3L,5L,13L,33L,105L,345L,1173L,4097L,14573L,52433L,190653L,699073L,2581113L,9586985L,35791473L,134217729L,505290273L,1908874585L,7233629133L,27487790721L,104715393913L,399822410105L,1529755308213L,5864062017537L,22517998136937L,86607685141745L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283844Inst : IEnumerable<long>
{
public static readonly long[] Value=A283844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283844.Bytes);
public long this[int i]=>Value[i];

public static A283844Inst Instance=new A283844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283845
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,3L,2L,2L,3L,5L,3L,2L,3L,5L,8L,5L,3L,3L,5L,8L,13L,8L,5L,3L,5L,8L,13L,21L,13L,8L,5L,5L,8L,13L,21L,34L,21L,13L,8L,5L,8L,13L,21L,34L,55L,34L,21L,13L,8L,8L,13L,21L,34L,55L,89L,55L,34L,21L,13L,8L,13L,21L,34L,55L,89L,144L,89L,55L,34L,21L,13L,13L,21L,34L,55L,89L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283845Inst : IEnumerable<long>
{
public static readonly long[] Value=A283845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283845.Bytes);
public long this[int i]=>Value[i];

public static A283845Inst Instance=new A283845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283846
{
public static readonly long[] Value={ 10L,31L,68L,226L,650L,2259L,7542L,27036L,96350L,352786L,1294652L,4806366L,17912120L,67160083L,252710672L,954641186L,3617076710L,13744708060L,52358745532L,199914446106L,764881848410L,2932043941394L,11259015845684L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283846Inst : IEnumerable<long>
{
public static readonly long[] Value=A283846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283846.Bytes);
public long this[int i]=>Value[i];

public static A283846Inst Instance=new A283846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283847
{
public static readonly long[] Value={ 2L,8L,36L,140L,522L,1920L,7030L,25704L,94302L,347488L,1286460L,4785300L,17879352L,67076096L,252579600L,954306220L,3616552422L,13743371072L,52356648380L,199909107900L,764873459802L,2932022620160L,11258982291252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283847Inst : IEnumerable<long>
{
public static readonly long[] Value=A283847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283847.Bytes);
public long this[int i]=>Value[i];

public static A283847Inst Instance=new A283847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283848
{
public static readonly long[] Value={ 8L,23L,32L,86L,128L,339L,512L,1332L,2048L,5298L,8192L,21066L,32768L,83987L,131072L,334966L,524288L,1336988L,2097152L,5338206L,8388608L,21321234L,33554432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283848Inst : IEnumerable<long>
{
public static readonly long[] Value=A283848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283848.Bytes);
public long this[int i]=>Value[i];

public static A283848Inst Instance=new A283848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283849
{
public static readonly ulong[] Value={ 1L,11L,111L,1111L,11101L,111111L,1110111L,11111111L,111011101L,1111111111L,11101111011L,111111111011L,1110111011111L,11111111111111L,111011110110111L,1111111111111111L,11101110111111111L,111111111111111111L,1110111101101111111L,11111111111111111111UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283849Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A283849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283849.Bytes);
public ulong this[int i]=>Value[i];

public static A283849Inst Instance=new A283849Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283850
{
public static readonly ulong[] Value={ 1L,11L,111L,1111L,10111L,111111L,1110111L,11111111L,101110111L,1111111111L,11011110111L,110111111111L,1111101110111L,11111111111111L,111011011110111L,1111111111111111L,11111111101110111L,111111111111111111L,1111111011011110111L,11111111111111111111UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283850Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A283850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283850.Bytes);
public ulong this[int i]=>Value[i];

public static A283850Inst Instance=new A283850Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283851
{
public static readonly BigInteger[] Value={ 2L,16L,409L,35373L,10741381L,10634931992L,35481195059121L,402875332003637009L,BigInteger.Parse("15356708293578353570000"),BigInteger.Parse("1967963796346049662173630851"),BigInteger.Parse("850722520813357296311553404161550") };
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
public class A283851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283851Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A283851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283851.Bytes);
public BigInteger this[int i]=>Value[i];

public static A283851Inst Instance=new A283851Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283852
{
public static readonly long[] Value={ 8L,61L,409L,2837L,19776L,137459L,955680L,6645662L,46211001L,321328965L,2234376733L,15536845232L,108036163039L,751234447860L,5223743482218L,36323541679065L,252577425569649L,1756308801126965L,12212574412144160L,84920700547463563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283852Inst : IEnumerable<long>
{
public static readonly long[] Value=A283852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283852.Bytes);
public long this[int i]=>Value[i];

public static A283852Inst Instance=new A283852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283853
{
public static readonly long[] Value={ 16L,233L,2776L,35373L,448490L,5676420L,71903903L,910712188L,11534678940L,146094562780L,1850383484231L,23436321812180L,296836434645831L,3759628625285727L,47618168759118637L,603115420174313641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283853Inst : IEnumerable<long>
{
public static readonly long[] Value=A283853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283853.Bytes);
public long this[int i]=>Value[i];

public static A283853Inst Instance=new A283853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283854
{
public static readonly BigInteger[] Value={ 32L,896L,19220L,456316L,10741381L,252014450L,5921518755L,139111379622L,3268007622399L,76773433462839L,1803586222018838L,42370441245079992L,995380616617115988L,BigInteger.Parse("23383813210579507551"),BigInteger.Parse("549340337215663375578") };
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
public class A283854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283854Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A283854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283854.Bytes);
public BigInteger this[int i]=>Value[i];

public static A283854Inst Instance=new A283854Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283855
{
public static readonly BigInteger[] Value={ 64L,3444L,131617L,5742620L,247708452L,10634931992L,457711375590L,19691576356912L,847128290367194L,36444929121796824L,1567908124985085704L,BigInteger.Parse("67453445523667228919"),BigInteger.Parse("2901937047259631494910"),BigInteger.Parse("124845166900328034875120") };
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
public class A283855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283855Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A283855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283855.Bytes);
public BigInteger this[int i]=>Value[i];

public static A283855Inst Instance=new A283855Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283856
{
public static readonly BigInteger[] Value={ 128L,13225L,901397L,72394838L,5724272337L,449942735521L,35481195059121L,2796411775700471L,220385420596755894L,17369615762718616468UL,BigInteger.Parse("1368959249299809499467"),BigInteger.Parse("107892485834872661402986") };
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
public class A283856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283856Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A283856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283856.Bytes);
public BigInteger this[int i]=>Value[i];

public static A283856Inst Instance=new A283856Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283857
{
public static readonly long[] Value={ 2L,4L,4L,8L,16L,8L,16L,61L,64L,16L,32L,233L,409L,256L,32L,64L,896L,2776L,2837L,1024L,64L,128L,3444L,19220L,35373L,19776L,4096L,128L,256L,13225L,131617L,456316L,448490L,137459L,16384L,256L,512L,50789L,901397L,5742620L,10741381L,5676420L,955680L,65536L,512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283857Inst : IEnumerable<long>
{
public static readonly long[] Value=A283857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283857.Bytes);
public long this[int i]=>Value[i];

public static A283857Inst Instance=new A283857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283906
{
public static readonly ulong[] Value={ 1L,1L,11L,101L,1111L,10111L,111011L,1010101L,11111111L,101111111L,1110111111L,10101011111L,111111101111L,1011111010111L,11101110111011L,101010101010101L,1111111111111111L,10111111111111111L,111011111111111111L,1010101111111111111L,11111110111111111111UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283906Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A283906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283906.Bytes);
public ulong this[int i]=>Value[i];

public static A283906Inst Instance=new A283906Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283907
{
public static readonly ulong[] Value={ 1L,10L,110L,1010L,11110L,111010L,1101110L,10101010L,111111110L,1111111010L,11111101110L,111110101010L,1111011111110L,11101011111010L,110111011101110L,1010101010101010L,11111111111111110L,111111111111111010L,1111111111111101110L,11111111111110101010UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283907Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A283907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283907.Bytes);
public ulong this[int i]=>Value[i];

public static A283907Inst Instance=new A283907Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283908
{
public static readonly long[] Value={ 1L,1L,3L,5L,15L,23L,59L,85L,255L,383L,959L,1375L,4079L,6103L,15291L,21845L,65535L,98303L,245759L,352255L,1044479L,1562623L,3914751L,5592575L,16776959L,25165183L,62913471L,90174815L,267382767L,400021463L,1002159035L,1431655765L,4294967295L,6442450943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283908Inst : IEnumerable<long>
{
public static readonly long[] Value=A283908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283908.Bytes);
public long this[int i]=>Value[i];

public static A283908Inst Instance=new A283908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283909
{
public static readonly long[] Value={ 1L,2L,6L,10L,30L,58L,110L,170L,510L,1018L,2030L,4010L,7934L,15098L,28398L,43690L,131070L,262138L,524270L,1048490L,2096894L,4193018L,8384238L,16755370L,33488894L,66781178L,133103598L,262864810L,520027902L,989526778L,1861152494L,2863311530L,8589934590L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283909Inst : IEnumerable<long>
{
public static readonly long[] Value=A283909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283909.Bytes);
public long this[int i]=>Value[i];

public static A283909Inst Instance=new A283909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283910
{
public static readonly ulong[] Value={ 1L,11L,101L,1101L,10001L,111011L,1010001L,11011011L,100000001L,1110000011L,10101000101L,110101100101L,1000100000101L,11101110001101L,101000101000001L,1101101101100011L,10000000000000101L,111000000000001101L,1010100000000010001L,11010110000000111011UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283910Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A283910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283910.Bytes);
public ulong this[int i]=>Value[i];

public static A283910Inst Instance=new A283910Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283911
{
public static readonly ulong[] Value={ 1L,11L,101L,1011L,10001L,110111L,1000101L,11011011L,100000001L,1100000111L,10100010101L,101001101011L,1010000010001L,10110001110111L,100000101000101L,1100011011011011L,10100000000000001L,101100000000000111L,1000100000000010101L,11011100000001101011UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283911Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A283911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283911.Bytes);
public ulong this[int i]=>Value[i];

public static A283911Inst Instance=new A283911Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283912
{
public static readonly long[] Value={ 1L,3L,5L,13L,17L,59L,81L,219L,257L,899L,1349L,3429L,4357L,15245L,20801L,56163L,65541L,229389L,344081L,876603L,1114113L,3899395L,5324805L,14376965L,16781317L,58734605L,88100865L,224450563L,285279237L,998476813L,1363476993L,3681354499L,4295065733L,15032402245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283912Inst : IEnumerable<long>
{
public static readonly long[] Value=A283912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283912.Bytes);
public long this[int i]=>Value[i];

public static A283912Inst Instance=new A283912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283913
{
public static readonly long[] Value={ 1L,3L,5L,11L,17L,55L,69L,219L,257L,775L,1301L,2667L,5137L,11383L,16709L,50907L,81921L,180231L,278549L,901227L,1048593L,3145847L,5243205L,10487515L,20975617L,46166023L,67129365L,201437291L,335810577L,739012727L,1075859781L,3233855195L,5402460161L,10905714695L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283913Inst : IEnumerable<long>
{
public static readonly long[] Value=A283913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283913.Bytes);
public long this[int i]=>Value[i];

public static A283913Inst Instance=new A283913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283914
{
public static readonly long[] Value={ 1L,0L,1L,0L,111L,111L,10101L,1000L,1100001L,1001100L,100001101L,1001100L,11100001101L,11001101100L,1011001011101L,111000010100L,110101001000001L,101000000010100L,10000011011000001L,101001011010100L,1110010000111101001L,1100000000100000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283914Inst : IEnumerable<long>
{
public static readonly long[] Value=A283914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283914.Bytes);
public long this[int i]=>Value[i];

public static A283914Inst Instance=new A283914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283915
{
public static readonly BigInteger[] Value={ 1L,0L,100L,0L,11100L,111000L,1010100L,10000L,100001100L,11001000L,10110000100L,1100100000L,1011000011100L,110110011000L,101110100110100L,10100001110000L,10000010010101100L,1010000000101000L,1000001101100000100L,101011010010100000L,BigInteger.Parse("100101111000010011100") };
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
public class A283915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283915Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A283915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283915.Bytes);
public BigInteger this[int i]=>Value[i];

public static A283915Inst Instance=new A283915Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283916
{
public static readonly long[] Value={ 1L,0L,1L,0L,7L,7L,21L,8L,97L,76L,269L,76L,1805L,1644L,5725L,3604L,27201L,20500L,67265L,21204L,467433L,393472L,1464445L,924444L,6971221L,5255552L,17216949L,5405680L,119556629L,100860096L,375016085L,236454912L,1784410613L,1346036016L,4406938645L,1380720960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283916Inst : IEnumerable<long>
{
public static readonly long[] Value=A283916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283916.Bytes);
public long this[int i]=>Value[i];

public static A283916Inst Instance=new A283916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283917
{
public static readonly long[] Value={ 1L,0L,4L,0L,28L,56L,84L,16L,268L,200L,1412L,800L,5660L,3480L,23860L,10352L,66732L,41000L,269060L,177312L,1241244L,8216L,6229300L,3725424L,22410412L,405544L,91056900L,16639136L,352993436L,12595224L,1420373300L,2103408L,5890880684L,840790056L,22574377732L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283917Inst : IEnumerable<long>
{
public static readonly long[] Value=A283917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283917.Bytes);
public long this[int i]=>Value[i];

public static A283917Inst Instance=new A283917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283918
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,1L,5L,9L,53L,529L,28565L,15139445L,86494677165L,145497982245073197L,BigInteger.Parse("237449075542565847670095797"),BigInteger.Parse("65308811677507188262439443927593494833685"),BigInteger.Parse("542885242695872953856134304668084060854561472461643166998594129") };
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
public class A283918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283918Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A283918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283918.Bytes);
public BigInteger this[int i]=>Value[i];

public static A283918Inst Instance=new A283918Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283919
{
public static readonly long[] Value={ 4L,4L,9L,4L,4L,9L,4L,4L,25L,9L,4L,4L,4L,4L,4L,9L,4L,49L,25L,4L,9L,4L,4L,9L,4L,4L,4L,25L,4L,4L,9L,4L,4L,9L,4L,4L,49L,9L,4L,4L,4L,4L,4L,9L,4L,121L,4L,25L,9L,4L,4L,9L,4L,4L,4L,49L,4L,25L,4L,9L,4L,4L,9L,4L,4L,169L,9L,4L,25L,4L,4L,4L,4L,9L,4L,4L,9L,4L,4L,9L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283919Inst : IEnumerable<long>
{
public static readonly long[] Value=A283919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283919.Bytes);
public long this[int i]=>Value[i];

public static A283919Inst Instance=new A283919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283920
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,7L,13L,103L,1441L,149863L,216102445L,32385976817479L,BigInteger.Parse("6998688806356507453627"),BigInteger.Parse("32379910490774089036757549734714267"),BigInteger.Parse("17432070546354327896489623045874879995780253657133907303") };
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
public class A283920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283920Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A283920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283920.Bytes);
public BigInteger this[int i]=>Value[i];

public static A283920Inst Instance=new A283920Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283921
{
public static readonly BigInteger[] Value={ 1L,1L,-179L,515L,-216383L,-183781L,4644828197L,153375307L,-371224706507L,959290541L,575134377343021L,-14855426650259L,BigInteger.Parse("-29106619674489691525729"),225456132288901603L,BigInteger.Parse("263567702701300558681"),-355061945309358701L,BigInteger.Parse("-1432477558547377054456843733") };
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
public class A283921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283921Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A283921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283921.Bytes);
public BigInteger this[int i]=>Value[i];

public static A283921Inst Instance=new A283921Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284034
{
public static readonly long[] Value={ 3L,5L,11L,19L,29L,79L,101L,349L,409L,449L,521L,569L,571L,661L,739L,991L,1091L,1129L,1181L,1459L,1489L,1531L,1901L,2269L,2281L,2341L,2351L,2389L,2549L,2659L,2671L,2719L,2729L,2731L,3109L,4049L,4349L,5279L,5431L,5471L,5531L,5591L,5669L,6329L,6359L,6871L,7559L,7741L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284034Inst : IEnumerable<long>
{
public static readonly long[] Value=A284034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284034.Bytes);
public long this[int i]=>Value[i];

public static A284034Inst Instance=new A284034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284035
{
public static readonly long[] Value={ 5L,13L,61L,181L,421L,3121L,5101L,60901L,83641L,100801L,135721L,161881L,163021L,218461L,273061L,491041L,595141L,637321L,697381L,1064341L,1108561L,1171981L,1806901L,2574181L,2601481L,2740141L,2763601L,2853661L,3248701L,3535141L,3567121L,3696481L,3723721L,3729181L,4832941L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284035Inst : IEnumerable<long>
{
public static readonly long[] Value=A284035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284035.Bytes);
public long this[int i]=>Value[i];

public static A284035Inst Instance=new A284035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284036
{
public static readonly long[] Value={ 3L,5L,11L,19L,25L,29L,65L,79L,101L,205L,209L,221L,245L,275L,289L,299L,349L,371L,409L,415L,449L,521L,535L,569L,571L,575L,595L,649L,661L,695L,739L,781L,791L,935L,949L,991L,1081L,1091L,1099L,1129L,1181L,1225L,1241L,1285L,1345L,1349L,1459L,1489L,1531L,1541L,1615L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284036Inst : IEnumerable<long>
{
public static readonly long[] Value=A284036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284036.Bytes);
public long this[int i]=>Value[i];

public static A284036Inst Instance=new A284036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284037
{
public static readonly long[] Value={ 11L,13L,19L,23L,37L,47L,53L,73L,97L,107L,163L,193L,383L,487L,577L,863L,1153L,2593L,2917L,4373L,8747L,995327L,1492993L,1990657L,5308417L,28311553L,86093443L,6879707137L,1761205026817L,2348273369087L,5566277615617L,7421703487487L,21422803359743L,79164837199873L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284037Inst : IEnumerable<long>
{
public static readonly long[] Value=A284037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284037.Bytes);
public long this[int i]=>Value[i];

public static A284037Inst Instance=new A284037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284038
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,10L,12L,9L,15L,18L,21L,24L,27L,30L,16L,20L,28L,32L,36L,40L,44L,48L,52L,5L,25L,35L,45L,50L,55L,60L,65L,70L,75L,80L,42L,54L,66L,72L,78L,84L,90L,96L,102L,108L,114L,120L,126L,7L,14L,49L,56L,63L,77L,91L,98L,105L,112L,119L,133L,140L,147L,154L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284038Inst : IEnumerable<long>
{
public static readonly long[] Value=A284038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284038.Bytes);
public long this[int i]=>Value[i];

public static A284038Inst Instance=new A284038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284040
{
public static readonly BigInteger[] Value={ 1L,11L,110L,111L,11000L,1111L,1111000L,11111L,111100000L,1111111L,11110000000L,111111111L,1111000000000L,11111111111L,111111110000000L,111100111111111L,11001111000000000L,11110011111111111L,1100111100000000000L,111001111111111111L,BigInteger.Parse("111111100000000000000") };
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
public class A284040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284040Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A284040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284040.Bytes);
public BigInteger this[int i]=>Value[i];

public static A284040Inst Instance=new A284040Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284041
{
public static readonly long[] Value={ 1L,3L,3L,14L,3L,60L,15L,248L,15L,1016L,15L,4088L,15L,16376L,255L,65438L,243L,262046L,243L,1048476L,127L,4194200L,255L,16776966L,1019L,67108358L,1019L,268434686L,899L,1073741054L,62335L,4294941888L,63359L,17179838656L,63295L,68719471814L,54139L,274877901958L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284041Inst : IEnumerable<long>
{
public static readonly long[] Value=A284041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284041.Bytes);
public long this[int i]=>Value[i];

public static A284041Inst Instance=new A284041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284042
{
public static readonly long[] Value={ 1L,3L,6L,7L,24L,15L,120L,31L,480L,127L,1920L,511L,7680L,2047L,32640L,31231L,105984L,124927L,423936L,237567L,2080768L,425983L,8355840L,6356991L,29327360L,25296895L,117309440L,133431295L,406323200L,533725183L,2137489408L,54132735L,8554151936L,206045183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284042Inst : IEnumerable<long>
{
public static readonly long[] Value=A284042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284042.Bytes);
public long this[int i]=>Value[i];

public static A284042Inst Instance=new A284042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284043
{
public static readonly long[] Value={ 41L,41L,122L,162L,299L,326L,326L,1064L,1064L,1064L,1064L,1064L,5664L,5664L,5664L,5664L,9265L,9265L,9265L,22818L,22818L,37784L,37784L,47494L,100202L,100202L,100202L,167628L,167628L,167628L,167628L,167628L,167628L,167628L,167628L,176956L,176956L,176956L,1081297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284043Inst : IEnumerable<long>
{
public static readonly long[] Value=A284043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284043.Bytes);
public long this[int i]=>Value[i];

public static A284043Inst Instance=new A284043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284044
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,3L,2L,1L,1L,2L,1L,1L,1L,4L,3L,3L,1L,2L,2L,2L,2L,3L,3L,2L,3L,2L,2L,2L,2L,5L,1L,2L,1L,2L,2L,1L,2L,3L,3L,2L,2L,2L,2L,1L,2L,4L,2L,2L,1L,3L,2L,3L,1L,3L,1L,1L,2L,2L,2L,2L,2L,6L,1L,2L,3L,2L,2L,2L,1L,3L,2L,2L,2L,2L,2L,2L,4L,4L,4L,1L,1L,2L,1L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284044Inst : IEnumerable<long>
{
public static readonly long[] Value=A284044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284044.Bytes);
public long this[int i]=>Value[i];

public static A284044Inst Instance=new A284044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284045
{
public static readonly long[] Value={ 1L,25L,30L,40L,45L,70L,95L,215L,220L,385L,425L,455L,560L,565L,710L,775L,975L,980L,1060L,1130L,1500L,1540L,1605L,1755L,1815L,1995L,2280L,2305L,2335L,2425L,2705L,2775L,3010L,3020L,3090L,3190L,3230L,3600L,3640L,3895L,3945L,4455L,4480L,4615L,4900L,5045L,5495L,5525L,5750L,5880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284045Inst : IEnumerable<long>
{
public static readonly long[] Value=A284045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284045.Bytes);
public long this[int i]=>Value[i];

public static A284045Inst Instance=new A284045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284046
{
public static readonly long[] Value={ 1L,2L,3L,11L,26L,111L,1111L,11111L,105462L,111111L,460688L,753576L,1111111L,2806538L,3513626L,5858612L,11111111L,23335688L,111111111L,674874474L,8226042716L,2131535935501L,81655720279388L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284046Inst : IEnumerable<long>
{
public static readonly long[] Value=A284046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284046.Bytes);
public long this[int i]=>Value[i];

public static A284046Inst Instance=new A284046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284047
{
public static readonly long[] Value={ 1L,2L,3L,8L,5L,6L,11L,20L,23L,18L,35L,24L,19L,10L,7L,12L,17L,42L,25L,4L,9L,14L,15L,22L,57L,32L,27L,52L,37L,30L,13L,28L,33L,40L,39L,34L,45L,16L,31L,70L,69L,80L,21L,26L,41L,56L,51L,50L,53L,48L,65L,36L,71L,60L,29L,44L,59L,54L,85L,46L,81L,100L,49L,90L,61L,76L,91L,66L,101L,96L,55L,58L,73L,108L,43L,120L,79L,84L,145L,78L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284047Inst : IEnumerable<long>
{
public static readonly long[] Value=A284047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284047.Bytes);
public long this[int i]=>Value[i];

public static A284047Inst Instance=new A284047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284048
{
public static readonly long[] Value={ 1L,3L,5L,4L,12L,13L,14L,2L,6L,10L,15L,17L,8L,19L,30L,34L,47L,74L,7L,9L,16L,11L,21L,28L,36L,45L,76L,49L,32L,89L,39L,25L,24L,40L,41L,23L,26L,38L,43L,78L,50L,31L,18L,46L,35L,29L,20L,44L,37L,27L,22L,42L,79L,90L,153L,103L,66L,55L,70L,51L,77L,48L,33L,88L,81L,162L,94L,75L,53L,68L,57L,64L,61L,60L,65L,56L,69L,52L,73L,96L,147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284048Inst : IEnumerable<long>
{
public static readonly long[] Value=A284048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284048.Bytes);
public long this[int i]=>Value[i];

public static A284048Inst Instance=new A284048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284049
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,9L,8L,11L,12L,13L,10L,15L,14L,17L,20L,21L,16L,25L,18L,19L,22L,27L,26L,23L,24L,29L,30L,31L,28L,33L,34L,37L,36L,35L,32L,39L,40L,41L,38L,43L,46L,51L,50L,47L,42L,55L,48L,49L,52L,45L,44L,53L,54L,59L,62L,63L,58L,67L,60L,61L,64L,57L,56L,65L,66L,71L,68L,69L,70L,79L,72L,77L,74L,75L,76L,73L,78L,85L,82L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284049Inst : IEnumerable<long>
{
public static readonly long[] Value=A284049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284049.Bytes);
public long this[int i]=>Value[i];

public static A284049Inst Instance=new A284049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284050
{
public static readonly long[] Value={ 2L,3L,1L,1L,2L,2L,1L,1L,2L,1L,1L,4L,2L,2L,1L,1L,2L,1L,1L,4L,2L,1L,1L,4L,1L,1L,2L,2L,6L,2L,1L,1L,4L,1L,1L,2L,4L,1L,1L,2L,1L,1L,4L,2L,2L,1L,1L,2L,1L,1L,4L,4L,1L,1L,2L,1L,1L,2L,2L,6L,2L,2L,1L,1L,4L,1L,1L,2L,4L,1L,1L,2L,1L,1L,2L,2L,4L,1L,1L,2L,1L,1L,4L,2L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284050Inst : IEnumerable<long>
{
public static readonly long[] Value=A284050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284050.Bytes);
public long this[int i]=>Value[i];

public static A284050Inst Instance=new A284050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284067
{
public static readonly long[] Value={ 6L,66L,67L,68L,69L,76L,86L,96L,666L,667L,668L,669L,676L,677L,678L,679L,686L,687L,688L,689L,696L,697L,698L,699L,766L,767L,768L,769L,776L,786L,796L,866L,867L,868L,869L,876L,886L,896L,966L,967L,968L,969L,976L,986L,996L,6666L,6667L,6668L,6669L,6676L,6677L,6678L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284067Inst : IEnumerable<long>
{
public static readonly long[] Value=A284067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284067.Bytes);
public long this[int i]=>Value[i];

public static A284067Inst Instance=new A284067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284068
{
public static readonly long[] Value={ 7L,77L,78L,79L,87L,97L,777L,778L,779L,787L,788L,789L,797L,798L,799L,877L,878L,879L,887L,897L,977L,978L,979L,987L,997L,7777L,7778L,7779L,7787L,7788L,7789L,7797L,7798L,7799L,7877L,7878L,7879L,7887L,7888L,7889L,7897L,7898L,7899L,7977L,7978L,7979L,7987L,7988L,7989L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284068Inst : IEnumerable<long>
{
public static readonly long[] Value=A284068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284068.Bytes);
public long this[int i]=>Value[i];

public static A284068Inst Instance=new A284068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284069
{
public static readonly long[] Value={ 8L,88L,89L,98L,888L,889L,898L,899L,988L,989L,998L,8888L,8889L,8898L,8899L,8988L,8989L,8998L,8999L,9888L,9889L,9898L,9899L,9988L,9989L,9998L,88888L,88889L,88898L,88899L,88988L,88989L,88998L,88999L,89888L,89889L,89898L,89899L,89988L,89989L,89998L,89999L,98888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284069Inst : IEnumerable<long>
{
public static readonly long[] Value=A284069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284069.Bytes);
public long this[int i]=>Value[i];

public static A284069Inst Instance=new A284069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284070
{
public static readonly long[] Value={ 0L,1L,15L,314L,3764L,37557L,353608L,3178404L,27582216L,233397609L,1936592863L,15815427428L,127479709618L,1016314018380L,8026733559938L,62881710177968L,489133088311108L,3781016346686269L,29064881546033136L,222309716942266766L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284070Inst : IEnumerable<long>
{
public static readonly long[] Value=A284070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284070.Bytes);
public long this[int i]=>Value[i];

public static A284070Inst Instance=new A284070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284071
{
public static readonly BigInteger[] Value={ 0L,6L,275L,7302L,151310L,2816826L,48994058L,812565760L,13024726520L,203381556682L,3110591645279L,46778444063114L,693678151593038L,10165365611526554L,147460852901201771L,2120338836015983926L,BigInteger.Parse("30254039436750997085") };
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
public class A284071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284071Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A284071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284071.Bytes);
public BigInteger this[int i]=>Value[i];

public static A284071Inst Instance=new A284071Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284072
{
public static readonly BigInteger[] Value={ 0L,33L,3174L,147864L,5555954L,188451507L,6011835223L,183456426810L,5420265572272L,156205777797592L,4413231997830430L,122681753540269744L,3364621054582473645L,BigInteger.Parse("91226318376089628842"),BigInteger.Parse("2449248911517215357307") };
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
public class A284072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284072Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A284072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284072.Bytes);
public BigInteger this[int i]=>Value[i];

public static A284072Inst Instance=new A284072Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284073
{
public static readonly BigInteger[] Value={ 0L,176L,31898L,2696970L,189363893L,11888242488L,700044712076L,39370013834758L,2141147641452532L,113490297082082382L,5893425866145396208L,BigInteger.Parse("300965611491917463584"),BigInteger.Parse("15157259115401323272094"),BigInteger.Parse("754409157482198595586778") };
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
public class A284073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284073Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A284073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284073.Bytes);
public BigInteger this[int i]=>Value[i];

public static A284073Inst Instance=new A284073Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284074
{
public static readonly BigInteger[] Value={ 0L,858L,300008L,45973823L,5950703039L,690497721277L,74965549398304L,7768358494151582L,777826092240727932L,BigInteger.Parse("75850300642037184690"),BigInteger.Parse("7242483614668041755074"),BigInteger.Parse("679759485223346193229835") };
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
public class A284074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284074Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A284074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284074.Bytes);
public BigInteger this[int i]=>Value[i];

public static A284074Inst Instance=new A284074Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284075
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,6L,15L,0L,0L,0L,33L,275L,314L,0L,0L,0L,176L,3174L,7302L,3764L,0L,0L,0L,858L,31898L,147864L,151310L,37557L,0L,0L,0L,4000L,300008L,2696970L,5555954L,2816826L,353608L,0L,0L,0L,18298L,2695374L,45973823L,189363893L,188451507L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284075Inst : IEnumerable<long>
{
public static readonly long[] Value=A284075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284075.Bytes);
public long this[int i]=>Value[i];

public static A284075Inst Instance=new A284075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284076
{
public static readonly long[] Value={ 0L,0L,1L,6L,33L,176L,858L,4000L,18298L,82176L,363027L,1584090L,6844659L,29327056L,124752876L,527398452L,2217568396L,9279837664L,38668567653L,160517532910L,664042452165L,2738524464624L,11261702650622L,46191451640392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284076Inst : IEnumerable<long>
{
public static readonly long[] Value=A284076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284076.Bytes);
public long this[int i]=>Value[i];

public static A284076Inst Instance=new A284076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284077
{
public static readonly long[] Value={ 0L,0L,15L,275L,3174L,31898L,300008L,2695374L,23315931L,196337438L,1619907608L,13142006271L,105144896153L,831492737200L,6510374422284L,50537297389064L,389357648148684L,2979896274369314L,22671924767160815L,171584668641301626L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284077Inst : IEnumerable<long>
{
public static readonly long[] Value=A284077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284077.Bytes);
public long this[int i]=>Value[i];

public static A284077Inst Instance=new A284077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284078
{
public static readonly BigInteger[] Value={ 0L,0L,314L,7302L,147864L,2696970L,45973823L,754541156L,11967618472L,185031284250L,2806789996272L,41897592713742L,617056516191321L,8986059093265166L,129599934394187822L,1853438708093687988L,BigInteger.Parse("26311359259223459474") };
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
public class A284078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284078Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A284078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284078.Bytes);
public BigInteger this[int i]=>Value[i];

public static A284078Inst Instance=new A284078Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284079
{
public static readonly BigInteger[] Value={ 0L,0L,3764L,151310L,5555954L,189363893L,5950703039L,179626388248L,5253391972116L,149652592411017L,4179730258147543L,114862577200241849L,3113589884348674543L,BigInteger.Parse("83433784755736562747"),BigInteger.Parse("2213775189247310840942"),BigInteger.Parse("58236047517496756337041") };
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
public class A284079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284079Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A284079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284079.Bytes);
public BigInteger this[int i]=>Value[i];

public static A284079Inst Instance=new A284079Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284080
{
public static readonly BigInteger[] Value={ 0L,0L,37557L,2816826L,188451507L,11888242488L,690497721277L,38373427448124L,2066968333513522L,108420537349373668L,5571748174347914144L,BigInteger.Parse("281628555096973980684"),BigInteger.Parse("14037532233093064300116"),BigInteger.Parse("691473229181393813694060") };
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
public class A284080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284080Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A284080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284080.Bytes);
public BigInteger this[int i]=>Value[i];

public static A284080Inst Instance=new A284080Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284081
{
public static readonly BigInteger[] Value={ 0L,0L,353608L,48994058L,6011835223L,700044712076L,74965549398304L,7663959789277668L,759541318384819140L,BigInteger.Parse("73293744586522740828"),BigInteger.Parse("6926137628336309991716"),BigInteger.Parse("643615455040297408956707") };
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
public class A284081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284081Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A284081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284081.Bytes);
public BigInteger this[int i]=>Value[i];

public static A284081Inst Instance=new A284081Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284082
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,1L,3L,2L,2L,1L,1L,1L,3L,2L,4L,1L,1L,1L,1L,0L,5L,1L,1L,2L,6L,3L,1L,1L,2L,1L,5L,0L,4L,2L,2L,1L,9L,0L,1L,1L,3L,1L,8L,5L,11L,1L,2L,2L,2L,8L,4L,1L,5L,0L,1L,0L,14L,1L,2L,1L,5L,0L,6L,2L,5L,1L,0L,7L,9L,1L,0L,1L,18L,10L,2L,0L,0L,1L,0L,4L,10L,1L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284082Inst : IEnumerable<long>
{
public static readonly long[] Value=A284082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284082.Bytes);
public long this[int i]=>Value[i];

public static A284082Inst Instance=new A284082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284099
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,9L,1L,1L,1L,1L,1L,1L,16L,9L,1L,1L,1L,1L,1L,23L,1L,9L,1L,1L,1L,1L,30L,16L,1L,9L,1L,1L,1L,37L,1L,1L,1L,9L,1L,1L,44L,23L,16L,1L,1L,9L,1L,51L,1L,1L,1L,1L,1L,9L,58L,30L,1L,16L,1L,1L,1L,73L,1L,23L,1L,1L,1L,1L,72L,45L,1L,1L,16L,1L,1L,79L,1L,9L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284099Inst : IEnumerable<long>
{
public static readonly long[] Value=A284099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284099.Bytes);
public long this[int i]=>Value[i];

public static A284099Inst Instance=new A284099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284100
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,10L,1L,1L,1L,1L,1L,1L,1L,18L,10L,1L,1L,1L,1L,1L,1L,26L,1L,10L,1L,1L,1L,1L,1L,34L,18L,1L,10L,1L,1L,1L,1L,42L,1L,1L,1L,10L,1L,1L,1L,50L,26L,18L,1L,1L,10L,1L,1L,58L,1L,1L,1L,1L,1L,10L,1L,66L,34L,1L,18L,1L,1L,1L,10L,74L,1L,26L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284100Inst : IEnumerable<long>
{
public static readonly long[] Value=A284100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284100.Bytes);
public long this[int i]=>Value[i];

public static A284100Inst Instance=new A284100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284101
{
public static readonly long[] Value={ 19725473L,19725479L,40727657L,40962983L,40962989L,44291297L,45404537L,45404543L,54470123L,54470147L,63846089L,63846119L,68208599L,68208611L,68364221L,90007661L,93602507L,99492971L,99492977L,99579647L,99579671L,117585977L,117585983L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284101Inst : IEnumerable<long>
{
public static readonly long[] Value=A284101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284101.Bytes);
public long this[int i]=>Value[i];

public static A284101Inst Instance=new A284101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284102
{
public static readonly long[] Value={ 6504L,12946L,12990L,19052L,19764L,21490L,31638L,35604L,41300L,42364L,45212L,52528L,58104L,60034L,63400L,66662L,67858L,69880L,74090L,74824L,78542L,88844L,96256L,96346L,97818L,104584L,106970L,111122L,113120L,117540L,125384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284102Inst : IEnumerable<long>
{
public static readonly long[] Value=A284102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284102.Bytes);
public long this[int i]=>Value[i];

public static A284102Inst Instance=new A284102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284103
{
public static readonly long[] Value={ 0L,0L,0L,4L,0L,0L,0L,4L,9L,0L,0L,4L,0L,14L,0L,4L,0L,9L,19L,4L,0L,0L,0L,28L,0L,0L,9L,18L,29L,0L,0L,4L,0L,34L,0L,13L,0L,19L,39L,4L,0L,14L,0L,48L,9L,0L,0L,28L,49L,0L,0L,4L,0L,63L,0L,18L,19L,29L,59L,4L,0L,0L,9L,68L,0L,0L,0L,38L,69L,14L,0L,37L,0L,74L,0L,23L,0L,39L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284103Inst : IEnumerable<long>
{
public static readonly long[] Value=A284103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284103.Bytes);
public long this[int i]=>Value[i];

public static A284103Inst Instance=new A284103Inst();

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