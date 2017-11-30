using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A190761
{
public static readonly BigInteger[] Value={ 1L,1L,3L,14L,84L,592L,4670L,40108L,368670L,3586321L,36632763L,390694000L,4332131804L,49777965585L,591173511887L,7241437905916L,91331043654080L,1184322726542850L,15770586926609276L,215423253906689779L,3015794930248824111L,BigInteger.Parse("43233248160139146114") };
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
public class A190761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190761Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190761.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190761Inst Instance=new A190761Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190762
{
public static readonly long[] Value={ 2L,1L,0L,2L,1L,1L,2L,2L,1L,0L,2L,1L,1L,2L,1L,1L,0L,2L,1L,0L,2L,1L,1L,2L,2L,1L,0L,2L,1L,1L,2L,1L,1L,0L,2L,1L,1L,2L,1L,1L,2L,2L,1L,0L,2L,1L,1L,2L,2L,1L,0L,2L,1L,1L,2L,1L,1L,0L,2L,1L,0L,2L,1L,1L,2L,2L,1L,0L,2L,1L,1L,2L,1L,1L,0L,2L,1L,1L,2L,1L,1L,2L,2L,1L,0L,2L,1L,1L,2L,1L,1L,0L,2L,1L,1L,2L,1L,1L,0L,2L,1L,0L,2L,1L,1L,2L,2L,1L,0L,2L,1L,1L,2L,1L,1L,0L,2L,1L,0L,2L,1L,1L,2L,2L,1L,0L,2L,1L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190762Inst : IEnumerable<long>
{
public static readonly long[] Value=A190762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190762.Bytes);
public long this[int i]=>Value[i];

public static A190762Inst Instance=new A190762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190763
{
public static readonly long[] Value={ 3L,10L,17L,20L,27L,34L,44L,51L,58L,61L,68L,75L,85L,92L,99L,102L,109L,116L,119L,126L,133L,143L,150L,157L,160L,167L,174L,184L,191L,198L,201L,208L,215L,225L,232L,242L,249L,256L,259L,266L,273L,283L,290L,297L,300L,307L,314L,324L,331L,338L,341L,348L,355L,358L,365L,372L,382L,389L,396L,399L,406L,413L,423L,430L,437L,440L,447L,454L,464L,471L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190763Inst : IEnumerable<long>
{
public static readonly long[] Value=A190763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190763.Bytes);
public long this[int i]=>Value[i];

public static A190763Inst Instance=new A190763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191260
{
public static readonly long[] Value={ 4L,12L,21L,29L,35L,39L,47L,56L,64L,68L,76L,84L,93L,101L,107L,111L,119L,128L,136L,144L,153L,161L,170L,178L,184L,188L,196L,205L,213L,217L,225L,233L,242L,250L,256L,260L,268L,277L,285L,294L,302L,308L,312L,320L,329L,337L,343L,347L,355L,364L,372L,376L,384L,392L,401L,409L,415L,419L,427L,436L,444L,452L,461L,469L,478L,486L,492L,496L,504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191260Inst : IEnumerable<long>
{
public static readonly long[] Value=A191260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191260.Bytes);
public long this[int i]=>Value[i];

public static A191260Inst Instance=new A191260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191261
{
public static readonly long[] Value={ 0L,1L,0L,0L,2L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,2L,0L,1L,0L,0L,2L,0L,1L,0L,0L,2L,0L,1L,0L,0L,2L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,2L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,2L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,2L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,2L,0L,1L,0L,0L,2L,0L,1L,0L,0L,2L,0L,1L,0L,0L,2L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,2L,0L,1L,0L,0L,2L,0L,1L,0L,0L,2L,0L,1L,0L,0L,2L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,2L,0L,1L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191261Inst : IEnumerable<long>
{
public static readonly long[] Value=A191261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191261.Bytes);
public long this[int i]=>Value[i];

public static A191261Inst Instance=new A191261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191262
{
public static readonly long[] Value={ 1L,3L,4L,6L,8L,10L,12L,14L,15L,17L,19L,20L,22L,24L,25L,27L,29L,30L,32L,34L,36L,38L,40L,41L,43L,45L,47L,49L,51L,52L,54L,56L,58L,60L,62L,63L,65L,67L,69L,71L,73L,74L,76L,78L,79L,81L,83L,84L,86L,88L,89L,91L,93L,95L,97L,99L,100L,102L,104L,105L,107L,109L,110L,112L,114L,115L,117L,119L,121L,123L,125L,126L,128L,130L,131L,133L,135L,136L,138L,140L,141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191262Inst : IEnumerable<long>
{
public static readonly long[] Value=A191262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191262.Bytes);
public long this[int i]=>Value[i];

public static A191262Inst Instance=new A191262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191263
{
public static readonly long[] Value={ 2L,7L,9L,11L,13L,18L,23L,28L,33L,35L,37L,39L,44L,46L,48L,50L,55L,57L,59L,61L,66L,68L,70L,72L,77L,82L,87L,92L,94L,96L,98L,103L,108L,113L,118L,120L,122L,124L,129L,134L,139L,144L,146L,148L,150L,155L,160L,165L,170L,172L,174L,176L,181L,183L,185L,187L,192L,194L,196L,198L,203L,205L,207L,209L,214L,219L,224L,229L,231L,233L,235L,240L,242L,244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191263Inst : IEnumerable<long>
{
public static readonly long[] Value=A191263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191263.Bytes);
public long this[int i]=>Value[i];

public static A191263Inst Instance=new A191263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191264
{
public static readonly long[] Value={ 5L,16L,21L,26L,31L,42L,53L,64L,75L,80L,85L,90L,101L,106L,111L,116L,127L,132L,137L,142L,153L,158L,163L,168L,179L,190L,201L,212L,217L,222L,227L,238L,249L,260L,271L,276L,281L,286L,297L,308L,319L,330L,335L,340L,345L,356L,367L,378L,389L,394L,399L,404L,415L,420L,425L,430L,441L,446L,451L,456L,467L,472L,477L,482L,493L,504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191264Inst : IEnumerable<long>
{
public static readonly long[] Value=A191264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191264.Bytes);
public long this[int i]=>Value[i];

public static A191264Inst Instance=new A191264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191265
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,0L,0L,2L,0L,0L,1L,0L,0L,1L,0L,0L,2L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,2L,0L,0L,1L,0L,0L,1L,0L,0L,2L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,2L,0L,0L,1L,0L,0L,1L,0L,0L,2L,0L,0L,1L,0L,0L,2L,0L,0L,1L,0L,0L,1L,0L,0L,2L,0L,0L,1L,0L,0L,1L,0L,0L,2L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,2L,0L,0L,1L,0L,0L,1L,0L,0L,2L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191265Inst : IEnumerable<long>
{
public static readonly long[] Value=A191265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191265.Bytes);
public long this[int i]=>Value[i];

public static A191265Inst Instance=new A191265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191266
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,10L,11L,13L,14L,16L,17L,19L,20L,22L,23L,25L,27L,28L,30L,31L,33L,34L,36L,37L,39L,40L,42L,43L,45L,46L,48L,49L,51L,53L,54L,56L,57L,59L,60L,62L,63L,65L,66L,68L,69L,71L,72L,74L,75L,77L,78L,80L,81L,83L,84L,86L,87L,89L,90L,92L,93L,95L,96L,98L,99L,101L,103L,104L,106L,107L,109L,110L,112L,113L,115L,116L,118L,119L,121L,122L,124L,125L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191266Inst : IEnumerable<long>
{
public static readonly long[] Value=A191266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191266.Bytes);
public long this[int i]=>Value[i];

public static A191266Inst Instance=new A191266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191267
{
public static readonly long[] Value={ 3L,6L,12L,15L,21L,24L,26L,29L,32L,38L,41L,47L,50L,52L,55L,58L,64L,67L,73L,79L,82L,88L,91L,97L,100L,102L,105L,108L,114L,117L,123L,126L,128L,131L,134L,140L,143L,149L,155L,158L,164L,167L,173L,176L,178L,181L,184L,190L,193L,199L,202L,204L,207L,210L,216L,219L,221L,224L,227L,233L,236L,242L,245L,247L,250L,253L,259L,262L,268L,271L,273L,276L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191267Inst : IEnumerable<long>
{
public static readonly long[] Value=A191267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191267.Bytes);
public long this[int i]=>Value[i];

public static A191267Inst Instance=new A191267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191268
{
public static readonly long[] Value={ 9L,18L,35L,44L,61L,70L,76L,85L,94L,111L,120L,137L,146L,152L,161L,170L,187L,196L,213L,230L,239L,256L,265L,282L,291L,297L,306L,315L,332L,341L,358L,367L,373L,382L,391L,408L,417L,434L,451L,460L,477L,486L,503L,512L,518L,527L,536L,553L,562L,579L,588L,594L,603L,612L,629L,638L,644L,653L,662L,679L,688L,705L,714L,720L,729L,738L,755L,764L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191268Inst : IEnumerable<long>
{
public static readonly long[] Value=A191268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191268.Bytes);
public long this[int i]=>Value[i];

public static A191268Inst Instance=new A191268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191269
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,0L,2L,0L,0L,1L,0L,0L,1L,0L,2L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,2L,0L,0L,1L,0L,0L,1L,0L,2L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,2L,0L,0L,1L,0L,2L,0L,0L,1L,0L,0L,1L,0L,2L,0L,0L,1L,0L,0L,1L,0L,2L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,2L,0L,0L,1L,0L,0L,1L,0L,2L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,2L,0L,0L,1L,0L,2L,0L,0L,1L,0L,0L,1L,0L,2L,0L,0L,1L,0L,0L,1L,0L,2L,0L,0L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191269Inst : IEnumerable<long>
{
public static readonly long[] Value=A191269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191269.Bytes);
public long this[int i]=>Value[i];

public static A191269Inst Instance=new A191269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191270
{
public static readonly long[] Value={ 3L,6L,11L,14L,19L,21L,24L,27L,32L,35L,40L,42L,45L,48L,53L,58L,61L,66L,69L,74L,76L,79L,82L,87L,90L,95L,97L,100L,103L,108L,113L,116L,121L,124L,129L,131L,134L,137L,142L,144L,147L,150L,155L,158L,163L,165L,168L,171L,176L,179L,184L,186L,189L,192L,197L,202L,205L,210L,213L,218L,220L,223L,226L,231L,234L,239L,241L,244L,247L,252L,257L,260L,265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191270Inst : IEnumerable<long>
{
public static readonly long[] Value=A191270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191270.Bytes);
public long this[int i]=>Value[i];

public static A191270Inst Instance=new A191270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191271
{
public static readonly long[] Value={ 8L,16L,29L,37L,50L,55L,63L,71L,84L,92L,105L,110L,118L,126L,139L,152L,160L,173L,181L,194L,199L,207L,215L,228L,236L,249L,254L,262L,270L,283L,296L,304L,317L,325L,338L,343L,351L,359L,372L,377L,385L,393L,406L,414L,427L,432L,440L,448L,461L,469L,482L,487L,495L,503L,516L,529L,537L,550L,558L,571L,576L,584L,592L,605L,613L,626L,631L,639L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191271Inst : IEnumerable<long>
{
public static readonly long[] Value=A191271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191271.Bytes);
public long this[int i]=>Value[i];

public static A191271Inst Instance=new A191271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191272
{
public static readonly long[] Value={ 0L,4L,17L,63L,256L,1025L,4095L,16384L,65537L,262143L,1048576L,4194305L,16777215L,67108864L,268435457L,1073741823L,4294967296L,17179869185L,68719476735L,274877906944L,1099511627777L,4398046511103L,17592186044416L,70368744177665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191272Inst : IEnumerable<long>
{
public static readonly long[] Value=A191272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191272.Bytes);
public long this[int i]=>Value[i];

public static A191272Inst Instance=new A191272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191273
{
public static readonly BigInteger[] Value={ 1L,4L,9L,25L,168L,1360L,12423L,197679L,4404447L,124898323L,5318804048L,324994451931L,26856733887752L,3172635060583667L,535764786560787509L,BigInteger.Parse("125858757883842762915"),BigInteger.Parse("41716808217942795412293") };
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
public class A191273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191273Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191273.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191273Inst Instance=new A191273Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191274
{
public static readonly BigInteger[] Value={ 1L,1L,2L,3L,8L,35L,208L,1147L,10098L,106904L,1615656L,31267328L,833655362L,29769092579L,1422289731681L,88322500448612L,7254260374065120L,782791757341222545L,BigInteger.Parse("111845565903325791194"),BigInteger.Parse("21080332457396845047136") };
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
public class A191274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191274Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191274.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191274Inst Instance=new A191274Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191275
{
public static readonly long[] Value={ 0L,1L,3L,5L,7L,9L,11L,12L,13L,15L,17L,19L,21L,23L,24L,25L,27L,29L,31L,33L,35L,36L,37L,39L,41L,43L,45L,47L,48L,49L,51L,53L,55L,57L,59L,60L,61L,63L,65L,67L,69L,71L,72L,73L,75L,77L,79L,81L,83L,84L,85L,87L,89L,91L,93L,95L,96L,97L,99L,101L,103L,105L,107L,108L,109L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191275Inst : IEnumerable<long>
{
public static readonly long[] Value=A191275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191275.Bytes);
public long this[int i]=>Value[i];

public static A191275Inst Instance=new A191275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191804
{
public static readonly BigInteger[] Value={ 1L,1L,7L,82L,1221L,20718L,382315L,7489683L,153551487L,3264643144L,71545452946L,1609541143713L,37065029428453L,872037022019930L,20935244357544798L,512498682139660135L,12790021472251565047UL,BigInteger.Parse("325439165493879484025") };
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
public class A191804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191804Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191804.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191804Inst Instance=new A191804Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191805
{
public static readonly BigInteger[] Value={ 1L,1L,2L,11L,83L,809L,9503L,130107L,2056768L,37137351L,761543233L,17637050418L,458225405825L,13265643258608L,424971569670808L,14963974979730138L,575619170223815326L,BigInteger.Parse("24056794697473352763"),BigInteger.Parse("1087014831018615150024") };
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
public class A191805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191805Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191805.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191805Inst Instance=new A191805Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191806
{
public static readonly BigInteger[] Value={ 1L,1L,2L,19L,253L,5256L,153121L,5793349L,292530822L,18658710139L,1476004466687L,143228682526672L,16603062548806759L,2272210780577578355L,BigInteger.Parse("363396388117576899042"),BigInteger.Parse("67028665570181029621005"),BigInteger.Parse("14142153576677394736652147") };
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
public class A191806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191806Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191806.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191806Inst Instance=new A191806Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191807
{
public static readonly BigInteger[] Value={ 1L,1L,2L,35L,839L,39817L,3186197L,350165095L,60551444146L,14198688038403L,4371837596384520L,1810022601411867232L,BigInteger.Parse("944544112975598084882"),BigInteger.Parse("612407529661033348265928"),BigInteger.Parse("494617108638856876638563800") };
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
public class A191807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191807Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191807.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191807Inst Instance=new A191807Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191808
{
public static readonly BigInteger[] Value={ 1L,1L,2L,67L,2941L,327868L,75504909L,23827165139L,14250056009694L,12425294009958329L,14645969719539739213UL,BigInteger.Parse("26039632087532302145593"),BigInteger.Parse("61861506372519998418244631"),BigInteger.Parse("188885323588779065057458593218") };
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
public class A191808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191808Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191808.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191808Inst Instance=new A191808Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191809
{
public static readonly ulong[] Value={ 1L,1L,2L,7L,32L,174L,1071L,7281L,53943L,432555L,3743146L,34934853L,351853883L,3827477399L,44985837602L,570985992828L,7814212692498L,115024461077654L,1815588345261996L,30628743324667923L,550414603283527315L,10503650627005928698UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191809Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A191809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191809.Bytes);
public ulong this[int i]=>Value[i];

public static A191809Inst Instance=new A191809Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191810
{
public static readonly BigInteger[] Value={ 1L,1L,2L,8L,44L,305L,2521L,24389L,273990L,3569531L,53944055L,944215131L,19065096323L,441174226355L,11609627641798L,344702951590401L,11463058468995522L,424180616752269732L,17366249924363207650UL,BigInteger.Parse("782666399665891947949") };
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
public class A191810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191810Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191810.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191810Inst Instance=new A191810Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191811
{
public static readonly BigInteger[] Value={ 1L,1L,2L,9L,58L,501L,5452L,74211L,1257414L,26480393L,689598502L,21957924255L,844532153323L,38719749230469L,2091808065954023L,131835936103587004L,9607988537163939224UL,BigInteger.Parse("803620426590302536069"),BigInteger.Parse("76622443259122023510169") };
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
public class A191811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191811Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191811.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191811Inst Instance=new A191811Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191812
{
public static readonly BigInteger[] Value={ 1L,1L,2L,10L,74L,782L,10982L,206346L,5142544L,168789842L,7201158787L,391194813232L,26651992683511L,2239377066821882L,229147222941318059L,BigInteger.Parse("28241058833042859637"),BigInteger.Parse("4149246030879282392144"),BigInteger.Parse("720738467750916348374860"),BigInteger.Parse("146838784937226592635807695") };
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
public class A191812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191812Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191812.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191812Inst Instance=new A191812Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191813
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,10L,46L,166L,504L,1425L,4256L,14594L,55783L,220903L,873199L,3436817L,13569556L,53929244L,215352055L,861477251L,3446980935L,13792641374L,55203566064L,221112089602L,887538377345L,3580304912835L,14573568107348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191813Inst : IEnumerable<long>
{
public static readonly long[] Value=A191813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191813.Bytes);
public long this[int i]=>Value[i];

public static A191813Inst Instance=new A191813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191814
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,18L,154L,970L,4862L,20879L,83672L,353281L,1773612L,11060634L,84779040L,772415014L,7726721969L,77774342729L,747754441850L,6734769291340L,56695273838174L,448350981091266L,3357088027977272L,24017325363442968L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191814Inst : IEnumerable<long>
{
public static readonly long[] Value=A191814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191814.Bytes);
public long this[int i]=>Value[i];

public static A191814Inst Instance=new A191814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191815
{
public static readonly long[] Value={ 1L,9L,5L,9L,4L,0L,5L,1L,1L,6L,0L,2L,0L,7L,9L,9L,2L,8L,0L,4L,4L,1L,7L,5L,9L,7L,7L,8L,4L,1L,2L,6L,3L,8L,6L,9L,6L,6L,8L,1L,9L,1L,5L,4L,4L,0L,4L,8L,9L,9L,4L,6L,8L,9L,7L,3L,7L,2L,6L,9L,9L,0L,9L,4L,1L,5L,9L,2L,6L,9L,7L,6L,6L,0L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191815Inst : IEnumerable<long>
{
public static readonly long[] Value=A191815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191815.Bytes);
public long this[int i]=>Value[i];

public static A191815Inst Instance=new A191815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191816
{
public static readonly long[] Value={ 0L,1L,1L,1L,23L,1L,1L,1L,2L,1L,2L,3L,5L,2L,1L,30L,18L,1L,2L,1L,2L,4L,2L,399L,2L,2L,3L,1L,2L,1L,4L,1L,1L,4L,2L,1L,2L,2L,12L,1L,3L,1L,3L,1L,2L,6L,1L,1L,1L,43L,1L,1L,1L,4L,1L,1L,16L,16L,1L,8L,1L,3L,3L,7L,1L,4L,25L,1L,4L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191816Inst : IEnumerable<long>
{
public static readonly long[] Value=A191816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191816.Bytes);
public long this[int i]=>Value[i];

public static A191816Inst Instance=new A191816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191817
{
public static readonly BigInteger[] Value={ 0L,1L,-1L,-1L,12L,-36L,-120L,2148L,-9744L,-64572L,1454220L,-8208828L,-96161472L,2479373064L,-15862726152L,-295638678072L,8425875692160L,-56585105164080L,-1653901130160720L,50485379331780720L,-336548011774484160L,BigInteger.Parse("-14999134695936065280"),BigInteger.Parse("482781746150042834880"),BigInteger.Parse("-2963015696186375016960") };
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
public class A191817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191817Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191817.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191817Inst Instance=new A191817Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191818
{
public static readonly long[] Value={ 0L,3L,1L,4L,3L,0L,1L,1L,0L,3L,4L,3L,4L,3L,0L,3L,1L,0L,1L,1L,0L,1L,1L,0L,3L,1L,4L,3L,0L,3L,4L,3L,4L,3L,0L,3L,4L,3L,4L,3L,0L,3L,1L,4L,3L,0L,1L,1L,0L,3L,1L,0L,1L,1L,0L,1L,1L,0L,3L,1L,0L,1L,1L,0L,1L,1L,0L,3L,1L,4L,3L,0L,1L,1L,0L,3L,4L,3L,4L,3L,0L,3L,1L,4L,3L,0L,3L,4L,3L,4L,3L,0L,3L,4L,3L,4L,3L,0L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191818Inst : IEnumerable<long>
{
public static readonly long[] Value=A191818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191818.Bytes);
public long this[int i]=>Value[i];

public static A191818Inst Instance=new A191818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191819
{
public static readonly long[] Value={ 137174L,137175L,137184L,137186L,137195L,137196L,137274L,137275L,137294L,137297L,137305L,137307L,137384L,137386L,137394L,137397L,137416L,137417L,137495L,137496L,137505L,137507L,137516L,137517L,138174L,138175L,138184L,138186L,138195L,138196L,138374L,138375L,138404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191819Inst : IEnumerable<long>
{
public static readonly long[] Value=A191819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191819.Bytes);
public long this[int i]=>Value[i];

public static A191819Inst Instance=new A191819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191852
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,9L,10L,11L,12L,15L,17L,18L,19L,24L,27L,29L,30L,31L,39L,44L,47L,49L,50L,51L,63L,71L,76L,79L,81L,82L,83L,102L,115L,123L,128L,131L,133L,134L,135L,165L,186L,199L,207L,212L,215L,217L,218L,219L,267L,301L,322L,335L,343L,348L,351L,353L,354L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191852Inst : IEnumerable<long>
{
public static readonly long[] Value=A191852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191852.Bytes);
public long this[int i]=>Value[i];

public static A191852Inst Instance=new A191852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191853
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,17L,18L,19L,21L,22L,23L,24L,26L,27L,29L,30L,31L,34L,35L,37L,39L,43L,44L,47L,49L,50L,51L,55L,57L,60L,63L,69L,71L,76L,77L,79L,81L,82L,83L,85L,89L,92L,97L,102L,112L,115L,123L,124L,128L,131L,132L,133L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191853Inst : IEnumerable<long>
{
public static readonly long[] Value=A191853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191853.Bytes);
public long this[int i]=>Value[i];

public static A191853Inst Instance=new A191853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191854
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,1L,7L,1L,2L,4L,3L,2L,1L,7L,1L,5L,11L,17L,1L,2L,3L,1L,6L,11L,5L,23L,1L,4L,1L,2L,11L,7L,3L,1L,15L,1L,31L,1L,2L,4L,23L,5L,8L,1L,1L,19L,7L,26L,1L,3L,1L,2L,1L,9L,23L,3L,47L,19L,1L,49L,1L,2L,5L,1L,27L,1L,10L,3L,7L,1L,2L,4L,9L,2L,1L,31L,1L,14L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191854Inst : IEnumerable<long>
{
public static readonly long[] Value=A191854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191854.Bytes);
public long this[int i]=>Value[i];

public static A191854Inst Instance=new A191854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191855
{
public static readonly long[] Value={ 2L,5L,3L,10L,4L,13L,2L,17L,9L,5L,7L,11L,26L,4L,29L,6L,3L,2L,37L,19L,13L,41L,7L,4L,9L,2L,50L,13L,53L,27L,5L,8L,19L,58L,4L,61L,2L,65L,33L,17L,3L,14L,9L,73L,74L,4L,11L,3L,82L,28L,85L,43L,89L,10L,4L,31L,2L,5L,97L,2L,101L,51L,21L,106L,4L,109L,11L,37L,16L,113L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191855Inst : IEnumerable<long>
{
public static readonly long[] Value=A191855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191855.Bytes);
public long this[int i]=>Value[i];

public static A191855Inst Instance=new A191855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191856
{
public static readonly long[] Value={ 1L,7L,2L,1L,3L,1L,23L,4L,1L,31L,16L,5L,2L,1L,47L,6L,1L,1L,7L,1L,71L,25L,79L,8L,1L,3L,4L,13L,48L,9L,103L,2L,1L,5L,119L,10L,1L,127L,64L,1L,27L,34L,1L,11L,151L,4L,3L,80L,1L,167L,12L,1L,7L,22L,1L,1L,191L,96L,13L,199L,2L,8L,1L,43L,4L,73L,223L,14L,1L,3L,2L,5L,239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191856Inst : IEnumerable<long>
{
public static readonly long[] Value=A191856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191856.Bytes);
public long this[int i]=>Value[i];

public static A191856Inst Instance=new A191856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191857
{
public static readonly long[] Value={ 3L,1L,4L,11L,5L,19L,1L,6L,27L,1L,2L,7L,20L,43L,1L,8L,51L,59L,9L,67L,1L,3L,1L,10L,83L,29L,22L,7L,2L,11L,1L,52L,107L,23L,1L,12L,123L,1L,2L,131L,5L,4L,139L,13L,1L,38L,53L,2L,163L,1L,14L,171L,25L,8L,179L,187L,1L,2L,15L,1L,100L,26L,211L,5L,54L,3L,1L,16L,227L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191857Inst : IEnumerable<long>
{
public static readonly long[] Value=A191857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191857.Bytes);
public long this[int i]=>Value[i];

public static A191857Inst Instance=new A191857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191858
{
public static readonly long[] Value={ 0L,1051L,6776941L,50904310155L,833954771945899L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191858Inst : IEnumerable<long>
{
public static readonly long[] Value=A191858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191858.Bytes);
public long this[int i]=>Value[i];

public static A191858Inst Instance=new A191858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191859
{
public static readonly long[] Value={ 2L,3L,23L,347L,349L,311L,391627L,3471331L,384067L,2310175897L,239111323273399L,23167L,3784097136227L,235983149249L,3428116271L,37111677121283L,23293L,3471949133311L,231314228398154359L,378112153101159371L,2379127163381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191859Inst : IEnumerable<long>
{
public static readonly long[] Value=A191859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191859.Bytes);
public long this[int i]=>Value[i];

public static A191859Inst Instance=new A191859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191860
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,1L,18L,4L,4L,13L,1L,3L,5L,5L,3L,70L,1L,1L,6L,6L,3L,3L,32L,59L,3L,4L,7L,7L,9L,182L,11L,2L,1L,5L,23L,1L,29718L,8L,8L,221L,2L,13L,7L,1L,1068L,1L,39L,5L,9L,9L,3L,378L,7L,500L,11L,5L,45L,151L,1L,5604L,10L,10L,5L,2L,31L,5L,8890182L,1L,7L,3L,776L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191860Inst : IEnumerable<long>
{
public static readonly long[] Value=A191860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191860.Bytes);
public long this[int i]=>Value[i];

public static A191860Inst Instance=new A191860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191861
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,1L,5L,4L,1L,3L,1L,2L,5L,1L,4L,13L,3L,2L,6L,1L,1L,1L,5L,9L,5L,3L,7L,1L,5L,25L,3L,3L,1L,2L,3L,2L,3805L,8L,1L,27L,1L,36L,59L,1L,125L,3L,85L,4L,9L,1L,1L,41L,3L,53L,15L,12L,14L,732L,5L,569L,10L,1L,1L,1L,3L,13L,851525L,1L,2L,2L,73L,7L,13L,5L,11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191861Inst : IEnumerable<long>
{
public static readonly long[] Value=A191861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191861.Bytes);
public long this[int i]=>Value[i];

public static A191861Inst Instance=new A191861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191862
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,2L,7L,1L,5L,1L,7L,1L,2L,1L,23L,1L,7L,99L,1L,4L,5L,43L,1L,1L,9L,51L,3L,1L,1L,1L,5L,47L,4005L,16L,277L,1L,11L,4L,193L,57L,191L,3L,1L,1L,2L,3383L,7L,21L,70L,20621L,1L,13L,5L,17L,20L,25L,51L,217L,1L,7L,9041L,5L,1L,416941L,1L,251L,1L,1L,15L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191862Inst : IEnumerable<long>
{
public static readonly long[] Value=A191862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191862.Bytes);
public long this[int i]=>Value[i];

public static A191862Inst Instance=new A191862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191863
{
public static readonly long[] Value={ 1L,1L,3L,1L,2L,1L,3L,5L,1L,1L,39L,3L,1L,1L,78L,7L,1L,13L,4L,1L,3L,5L,3L,9L,1L,11L,1L,1L,2L,5L,1L,477L,389L,3L,51L,11L,1L,5L,2175L,5L,33L,7L,2L,6L,1L,41571L,44L,5L,11L,3201L,13L,1L,11L,9L,3L,11L,37L,2999L,7L,1L,127539L,8L,1L,57003L,3L,17L,5L,15L,1L,1L,1L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191863Inst : IEnumerable<long>
{
public static readonly long[] Value=A191863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191863.Bytes);
public long this[int i]=>Value[i];

public static A191863Inst Instance=new A191863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191864
{
public static readonly BigInteger[] Value={ 1L,2L,3L,4L,5L,7L,10L,28L,99L,1908L,136178L,246396654L,33083692025310L,BigInteger.Parse("8147205746460109635768"),BigInteger.Parse("269537638338486762080764802762484576"),BigInteger.Parse("2195978587041305889551144566841383797948181151148527903340") };
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
public class A191864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191864Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191864.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191864Inst Instance=new A191864Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191865
{
public static readonly long[] Value={ 17L,563L,67559L,758677727L,5639788283L,12519315713L,228317617103L,2215267259747L,2458514680949L,5331791014853L,9754511753219L,11469661520567L,60568409162663L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191865Inst : IEnumerable<long>
{
public static readonly long[] Value=A191865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191865.Bytes);
public long this[int i]=>Value[i];

public static A191865Inst Instance=new A191865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191866
{
public static readonly long[] Value={ 14L,33L,39L,60L,84L,95L,110L,138L,155L,189L,217L,248L,258L,259L,315L,360L,390L,399L,473L,504L,530L,539L,564L,584L,663L,754L,770L,819L,869L,885L,897L,1005L,1008L,1053L,1110L,1139L,1278L,1292L,1360L,1378L,1425L,1463L,1580L,1615L,1743L,1802L,1840L,1884L,1914L,1919L,1974L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191866Inst : IEnumerable<long>
{
public static readonly long[] Value=A191866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191866.Bytes);
public long this[int i]=>Value[i];

public static A191866Inst Instance=new A191866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191867
{
public static readonly long[] Value={ 41L,116L,125L,136L,149L,164L,169L,181L,369L,416L,425L,436L,449L,464L,481L,641L,916L,925L,936L,949L,964L,981L,1009L,1225L,1256L,1289L,1361L,1576L,1616L,1625L,1636L,1649L,1664L,1681L,1961L,2516L,2525L,2536L,2549L,2561L,2564L,2581L,3616L,3625L,3636L,3649L,3664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191867Inst : IEnumerable<long>
{
public static readonly long[] Value=A191867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191867.Bytes);
public long this[int i]=>Value[i];

public static A191867Inst Instance=new A191867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192044
{
public static readonly long[] Value={ 3L,7L,0L,8L,2L,2L,8L,3L,1L,9L,6L,1L,1L,8L,1L,5L,4L,4L,6L,2L,2L,7L,9L,5L,6L,9L,7L,6L,0L,4L,7L,6L,2L,9L,0L,3L,1L,4L,1L,4L,4L,4L,7L,8L,0L,1L,5L,1L,4L,7L,0L,4L,6L,7L,1L,2L,4L,7L,2L,4L,0L,2L,3L,9L,9L,5L,4L,0L,8L,0L,1L,9L,6L,5L,8L,7L,3L,7L,9L,3L,6L,4L,3L,9L,8L,5L,9L,4L,2L,2L,6L,1L,1L,6L,1L,6L,0L,6L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192044Inst : IEnumerable<long>
{
public static readonly long[] Value=A192044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192044.Bytes);
public long this[int i]=>Value[i];

public static A192044Inst Instance=new A192044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192045
{
public static readonly long[] Value={ 8L,14L,17L,18L,23L,24L,26L,27L,29L,32L,36L,38L,41L,44L,47L,48L,53L,56L,58L,59L,64L,67L,68L,69L,74L,76L,88L,89L,92L,93L,99L,102L,107L,109L,111L,122L,123L,142L,144L,146L,148L,154L,156L,157L,161L,166L,176L,177L,178L,196L,199L,231L,232L,233L,238L,243L,244L,247L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192045Inst : IEnumerable<long>
{
public static readonly long[] Value=A192045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192045.Bytes);
public long this[int i]=>Value[i];

public static A192045Inst Instance=new A192045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192046
{
public static readonly long[] Value={ 0L,1L,4L,6L,7L,13L,16L,18L,19L,28L,32L,34L,39L,49L,51L,52L,67L,72L,82L,83L,86L,106L,121L,126L,134L,136L,138L,173L,193L,208L,213L,217L,223L,224L,279L,314L,334L,349L,351L,354L,362L,364L,452L,507L,542L,562L,568L,577L,582L,586L,592L,731L,821L,876L,911L,919L,931L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192046Inst : IEnumerable<long>
{
public static readonly long[] Value=A192046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192046.Bytes);
public long this[int i]=>Value[i];

public static A192046Inst Instance=new A192046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192047
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,8L,11L,12L,14L,17L,18L,22L,23L,26L,29L,32L,34L,36L,43L,46L,47L,52L,57L,58L,69L,76L,78L,81L,87L,91L,94L,112L,123L,124L,133L,136L,142L,148L,152L,181L,199L,202L,214L,223L,226L,232L,239L,246L,293L,322L,326L,347L,359L,368L,371L,377L,387L,398L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192047Inst : IEnumerable<long>
{
public static readonly long[] Value=A192047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192047.Bytes);
public long this[int i]=>Value[i];

public static A192047Inst Instance=new A192047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192048
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,8L,11L,12L,13L,14L,16L,17L,18L,19L,22L,23L,26L,28L,29L,32L,34L,36L,39L,43L,46L,47L,49L,51L,52L,57L,58L,67L,69L,72L,76L,78L,81L,82L,83L,86L,87L,91L,94L,106L,112L,121L,123L,124L,126L,133L,134L,136L,138L,142L,148L,152L,173L,181L,193L,199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192048Inst : IEnumerable<long>
{
public static readonly long[] Value=A192048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192048.Bytes);
public long this[int i]=>Value[i];

public static A192048Inst Instance=new A192048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192049
{
public static readonly long[] Value={ 9L,17L,19L,21L,24L,27L,31L,32L,33L,36L,39L,43L,47L,48L,49L,51L,59L,63L,64L,67L,71L,77L,79L,83L,87L,92L,94L,99L,102L,106L,107L,118L,121L,127L,131L,134L,136L,149L,151L,157L,161L,162L,171L,173L,189L,193L,203L,206L,208L,217L,223L,239L,243L,247L,251L,261L,263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192049Inst : IEnumerable<long>
{
public static readonly long[] Value=A192049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192049.Bytes);
public long this[int i]=>Value[i];

public static A192049Inst Instance=new A192049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192050
{
public static readonly long[] Value={ 0L,1L,7L,8L,9L,11L,13L,17L,23L,24L,26L,29L,37L,39L,43L,52L,57L,61L,67L,69L,81L,96L,98L,101L,111L,112L,133L,153L,159L,168L,173L,181L,183L,214L,249L,257L,269L,284L,289L,293L,299L,347L,402L,416L,437L,457L,472L,474L,477L,487L,561L,651L,673L,706L,741L,761L,767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192050Inst : IEnumerable<long>
{
public static readonly long[] Value=A192050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192050.Bytes);
public long this[int i]=>Value[i];

public static A192050Inst Instance=new A192050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192051
{
public static readonly long[] Value={ 0L,1L,3L,4L,7L,8L,11L,16L,18L,19L,23L,27L,29L,31L,39L,43L,46L,47L,51L,62L,73L,74L,76L,78L,86L,101L,117L,119L,123L,129L,133L,141L,163L,191L,192L,199L,207L,219L,223L,231L,264L,308L,311L,322L,336L,352L,364L,368L,376L,427L,499L,503L,521L,543L,571L,587L,599L,603L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192051Inst : IEnumerable<long>
{
public static readonly long[] Value=A192051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192051.Bytes);
public long this[int i]=>Value[i];

public static A192051Inst Instance=new A192051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192052
{
public static readonly long[] Value={ 0L,1L,3L,4L,7L,8L,9L,11L,13L,16L,17L,18L,19L,23L,24L,26L,27L,29L,31L,37L,39L,43L,46L,47L,51L,52L,57L,61L,62L,67L,69L,73L,74L,76L,78L,81L,86L,96L,98L,101L,111L,112L,117L,119L,123L,129L,133L,141L,153L,159L,163L,168L,173L,181L,183L,191L,192L,199L,207L,214L,219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192052Inst : IEnumerable<long>
{
public static readonly long[] Value=A192052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192052.Bytes);
public long this[int i]=>Value[i];

public static A192052Inst Instance=new A192052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192053
{
public static readonly long[] Value={ 1L,2L,5L,15L,47L,159L,543L,1931L,6879L,25118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192053Inst : IEnumerable<long>
{
public static readonly long[] Value=A192053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192053.Bytes);
public long this[int i]=>Value[i];

public static A192053Inst Instance=new A192053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192054
{
public static readonly long[] Value={ 0L,1L,9L,57L,307L,1517L,7103L,32117L,141711L,614429L,2629495L,11141893L,46846671L,195760429L,813970695L,3370693013L,13910890431L,57246635581L,235011903671L,962772769829L,3937069121647L,16074491903309L,65538899349479L,266887332403125L,1085630844057375L,4411756408116573L,17912600251244567L,72670852531322949L,294610539143446735L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192054Inst : IEnumerable<long>
{
public static readonly long[] Value=A192054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192054.Bytes);
public long this[int i]=>Value[i];

public static A192054Inst Instance=new A192054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192055
{
public static readonly BigInteger[] Value={ 1L,1L,5L,85L,3969L,459281L,125569153L,79212732481L,113540993392641L,365157835665133825L,BigInteger.Parse("2606331667566896138241"),BigInteger.Parse("40900559102224525035430913"),BigInteger.Parse("1399954043998218670311054016513"),BigInteger.Parse("103806413322828910929240793184636929") };
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
public class A192055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192055Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A192055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192055.Bytes);
public BigInteger this[int i]=>Value[i];

public static A192055Inst Instance=new A192055Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192056
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,2L,2L,2L,2L,1L,3L,1L,2L,2L,3L,3L,2L,1L,3L,4L,2L,6L,2L,1L,8L,3L,3L,6L,2L,1L,3L,3L,1L,5L,7L,5L,4L,4L,3L,3L,6L,3L,3L,6L,3L,5L,3L,7L,5L,7L,6L,4L,5L,1L,8L,8L,2L,4L,6L,1L,5L,2L,4L,9L,8L,3L,6L,7L,3L,5L,5L,5L,3L,3L,5L,9L,4L,13L,6L,5L,9L,7L,7L,3L,10L,9L,8L,9L,7L,4L,7L,13L,5L,7L,10L,4L,4L,11L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192056Inst : IEnumerable<long>
{
public static readonly long[] Value=A192056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192056.Bytes);
public long this[int i]=>Value[i];

public static A192056Inst Instance=new A192056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192057
{
public static readonly BigInteger[] Value={ 1L,0L,0L,-4L,0L,0L,-64L,0L,0L,-2432L,0L,0L,-125952L,0L,0L,-8086016L,0L,0L,-598302720L,0L,0L,-49260396544L,0L,0L,-4408078761984L,0L,0L,-422207049695232L,0L,0L,-42827137857617920L,0L,0L,-4566145737838034944L,0L,0L,BigInteger.Parse("-508866683185248862208") };
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
public class A192057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192057Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A192057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192057.Bytes);
public BigInteger this[int i]=>Value[i];

public static A192057Inst Instance=new A192057Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192058
{
public static readonly BigInteger[] Value={ 0L,2L,0L,0L,8L,0L,0L,256L,0L,0L,13312L,0L,0L,868352L,0L,0L,65436672L,0L,0L,5467537408L,0L,0L,494982725632L,0L,0L,47850676551680L,0L,0L,4890933182070784L,0L,0L,524842319048867840L,0L,0L,BigInteger.Parse("58818757243307032576"),0L,0L,BigInteger.Parse("6856543871374119141376") };
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
public class A192058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192058Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A192058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192058.Bytes);
public BigInteger this[int i]=>Value[i];

public static A192058Inst Instance=new A192058Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192059
{
public static readonly BigInteger[] Value={ 1L,0L,0L,-8L,0L,0L,-64L,0L,0L,-2432L,0L,0L,-119808L,0L,0L,-7774208L,0L,0L,-578314240L,0L,0L,-47951675392L,0L,0L,-4311368204288L,0L,0L,-414374348980224L,0L,0L,-42136339579142144L,0L,0L,-4500840888508874752L,0L,0L,BigInteger.Parse("-502320056591861153792") };
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
public class A192059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192059Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A192059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192059.Bytes);
public BigInteger this[int i]=>Value[i];

public static A192059Inst Instance=new A192059Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192092
{
public static readonly long[] Value={ 1L,13L,156L,196L,238L,325L,450L,827L,1404L,2828L,4603L,7890L,12475L,20396L,34708L,57979L,102658L,170075L,292948L,482036L,812571L,1365010L,2293755L,3918292L,6555468L,11171195L,18648162L,31563547L,53005132L,89383740L,151102715L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192092Inst : IEnumerable<long>
{
public static readonly long[] Value=A192092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192092.Bytes);
public long this[int i]=>Value[i];

public static A192092Inst Instance=new A192092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192093
{
public static readonly long[] Value={ 1L,21L,357L,406L,490L,584L,827L,1090L,1914L,3262L,6228L,10226L,17114L,25534L,41034L,61778L,102644L,163334L,278554L,446898L,747274L,1175494L,1926612L,3021594L,4960170L,7880334L,13028058L,20841466L,34355316L,54835150L,89785130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192093Inst : IEnumerable<long>
{
public static readonly long[] Value=A192093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192093.Bytes);
public long this[int i]=>Value[i];

public static A192093Inst Instance=new A192093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192094
{
public static readonly long[] Value={ 1L,34L,821L,852L,922L,1165L,1404L,1914L,2562L,4618L,7450L,14979L,22803L,38778L,54826L,85506L,123690L,191034L,298131L,470051L,773762L,1207994L,1972850L,3009562L,4793090L,7277059L,11448307L,17673010L,27794938L,43769170L,68676058L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192094Inst : IEnumerable<long>
{
public static readonly long[] Value=A192094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192094.Bytes);
public long this[int i]=>Value[i];

public static A192094Inst Instance=new A192094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192095
{
public static readonly long[] Value={ 1L,2L,2L,2L,4L,4L,2L,2L,4L,6L,8L,6L,4L,2L,2L,4L,6L,12L,12L,8L,12L,12L,6L,4L,2L,2L,4L,6L,12L,18L,20L,18L,16L,16L,18L,20L,18L,12L,6L,4L,2L,2L,4L,6L,12L,18L,28L,34L,32L,32L,28L,28L,28L,28L,32L,32L,34L,28L,18L,12L,6L,4L,2L,2L,4L,6L,12L,18L,28L,44L,52L,54L,60L,58L,52L,54L,48L,40L,48L,54L,52L,58L,60L,54L,52L,44L,28L,18L,12L,6L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192095Inst : IEnumerable<long>
{
public static readonly long[] Value=A192095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192095.Bytes);
public long this[int i]=>Value[i];

public static A192095Inst Instance=new A192095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192096
{
public static readonly long[] Value={ 2L,4L,6L,12L,18L,28L,44L,64L,92L,132L,186L,256L,352L,476L,638L,852L,1124L,1472L,1920L,2484L,3196L,4096L,5216L,6612L,8350L,10496L,13140L,16396L,20380L,25244L,31178L,38380L,47104L,57660L,70380L,85684L,104068L,126080L,152396L,183808L,221208L,265664L,318432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192096Inst : IEnumerable<long>
{
public static readonly long[] Value=A192096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192096.Bytes);
public long this[int i]=>Value[i];

public static A192096Inst Instance=new A192096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192097
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,8L,16L,28L,40L,80L,144L,252L,456L,840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192097Inst : IEnumerable<long>
{
public static readonly long[] Value=A192097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192097.Bytes);
public long this[int i]=>Value[i];

public static A192097Inst Instance=new A192097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192098
{
public static readonly long[] Value={ 5684L,23772L,69272L,183960L,391356L,696178L,941088L,1182888L,1150520L,1165416L,815640L,780570L,413840L,369180L,178080L,115780L,43512L,20734L,6860L,7098L,3508L,574L,840L,665L,476L,210L,28L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192098Inst : IEnumerable<long>
{
public static readonly long[] Value=A192098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192098.Bytes);
public long this[int i]=>Value[i];

public static A192098Inst Instance=new A192098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192099
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,2L,1L,2L,3L,2L,3L,2L,3L,2L,1L,2L,3L,2L,3L,4L,3L,2L,3L,2L,3L,4L,3L,2L,3L,2L,1L,2L,3L,2L,3L,4L,3L,2L,3L,4L,3L,4L,3L,4L,3L,2L,3L,2L,3L,4L,3L,4L,3L,4L,3L,2L,3L,4L,3L,2L,3L,2L,1L,2L,3L,2L,3L,4L,3L,2L,3L,4L,3L,4L,3L,4L,3L,2L,3L,4L,3L,4L,5L,4L,3L,4L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192099Inst : IEnumerable<long>
{
public static readonly long[] Value=A192099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192099.Bytes);
public long this[int i]=>Value[i];

public static A192099Inst Instance=new A192099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192100
{
public static readonly long[] Value={ 1L,3L,6L,1L,12L,30L,32L,24L,6L,1L,50L,150L,280L,300L,240L,220L,60L,15L,10L,1L,225L,780L,1720L,3360L,3426L,4100L,2400L,2700L,1075L,471L,150L,35L,45L,15L,1L,1092L,4200L,10885L,25200L,42672L,56889L,60165L,57750L,46585L,31374L,24528L,14140L,4725L,1890L,1302L,252L,210L,140L,105L,21L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192100Inst : IEnumerable<long>
{
public static readonly long[] Value=A192100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192100.Bytes);
public long this[int i]=>Value[i];

public static A192100Inst Instance=new A192100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192101
{
public static readonly long[] Value={ 1L,2L,5L,20L,83L,594L,2641L,10856L,43623L,305766L,1354341L,5548644L,22325859L,89434722L,357870241L,1431612752L,5726580047L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192101Inst : IEnumerable<long>
{
public static readonly long[] Value=A192101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192101.Bytes);
public long this[int i]=>Value[i];

public static A192101Inst Instance=new A192101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192102
{
public static readonly long[] Value={ 31572L,141624L,452508L,1341648L,3266172L,7234374L,12259368L,18992502L,23324140L,28129626L,26605908L,26190612L,21568932L,17119818L,13040280L,8948079L,6244308L,3679032L,2431044L,1250109L,640908L,315828L,197568L,57288L,46116L,30366L,25732L,7695L,4104L,2226L,3780L,2205L,1344L,378L,36L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192102Inst : IEnumerable<long>
{
public static readonly long[] Value=A192102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192102.Bytes);
public long this[int i]=>Value[i];

public static A192102Inst Instance=new A192102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192103
{
public static readonly long[] Value={ 186300L,887220L,3060360L,9883440L,26969040L,67288830L,141778440L,256463820L,399874640L,547907454L,670419540L,742419510L,744780330L,701747010L,607809750L,520591950L,377521875L,312082260L,198307620L,158606532L,87210930L,63688410L,33243120L,25703205L,11343906L,6764940L,3272500L,2003805L,1532340L,757080L,211410L,212625L,198345L,138600L,82512L,21080L,16200L,15750L,14910L,13545L,7245L,3270L,630L,45L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192103Inst : IEnumerable<long>
{
public static readonly long[] Value=A192103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192103.Bytes);
public long this[int i]=>Value[i];

public static A192103Inst Instance=new A192103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192104
{
public static readonly long[] Value={ 1163085L,5835060L,21482340L,74471760L,222185304L,612903720L,1469224350L,3164268690L,5762811670L,9538994388L,13513772745L,18112131840L,20675910420L,23653643310L,22677991578L,22923998460L,19287053775L,17554312490L,13495597225L,11143736604L,8029798920L,6035010960L,4254456690L,2872892550L,1924619235L,1215058680L,789847190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192104Inst : IEnumerable<long>
{
public static readonly long[] Value=A192104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192104.Bytes);
public long this[int i]=>Value[i];

public static A192104Inst Instance=new A192104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192105
{
public static readonly long[] Value={ 7654350L,40209840L,156637140L,576841320L,1851589872L,5544758076L,14686598520L,35723706480L,75818872580L,144536922420L,242305860072L,370664737190L,506699655660L,643405035240L,746030515164L,812426918688L,833352979140L,795923308950L,741556189440L,644098507272L,547387431756L,444670121610L,349922192400L,268690544925L,197063378424L,147497181678L,99290917440L,73672276095L,45746253960L,32550841950L,19313040780L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192105Inst : IEnumerable<long>
{
public static readonly long[] Value=A192105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192105.Bytes);
public long this[int i]=>Value[i];

public static A192105Inst Instance=new A192105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192106
{
public static readonly long[] Value={ 1L,0L,0L,9L,9L,5L,0L,4L,9L,3L,8L,3L,6L,2L,0L,7L,7L,9L,5L,3L,3L,6L,3L,3L,8L,5L,9L,1L,7L,0L,6L,9L,6L,0L,0L,7L,1L,0L,6L,0L,3L,8L,9L,8L,9L,6L,4L,4L,7L,9L,6L,1L,2L,9L,4L,1L,8L,5L,3L,0L,2L,4L,7L,6L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192106Inst : IEnumerable<long>
{
public static readonly long[] Value=A192106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192106.Bytes);
public long this[int i]=>Value[i];

public static A192106Inst Instance=new A192106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192107
{
public static readonly BigInteger[] Value={ 25L,1375L,69375L,3471875L,173609375L,8680546875L,434027734375L,21701388671875L,1085069443359375L,54253472216796875L,2712673611083984375L,BigInteger.Parse("135633680555419921875"),BigInteger.Parse("6781684027777099609375"),BigInteger.Parse("339084201388885498046875"),BigInteger.Parse("16954210069444427490234375") };
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
public class A192107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192107Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A192107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192107.Bytes);
public BigInteger this[int i]=>Value[i];

public static A192107Inst Instance=new A192107Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192140
{
public static readonly long[] Value={ 2L,3L,4L,5L,7L,8L,9L,11L,101L,121L,131L,151L,181L,191L,313L,343L,353L,373L,383L,727L,747L,757L,787L,797L,919L,929L,1331L,10001L,10201L,10301L,10501L,10601L,11311L,11411L,12421L,12721L,12821L,13331L,13831L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192140Inst : IEnumerable<long>
{
public static readonly long[] Value=A192140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192140.Bytes);
public long this[int i]=>Value[i];

public static A192140Inst Instance=new A192140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192141
{
public static readonly long[] Value={ 2L,3L,2L,5L,7L,2L,3L,11L,101L,11L,131L,151L,181L,191L,313L,7L,353L,373L,383L,727L,383L,757L,787L,797L,919L,929L,11L,73137L,101L,10301L,10501L,10601L,11311L,11411L,12421L,12721L,12821L,13331L,13831L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192141Inst : IEnumerable<long>
{
public static readonly long[] Value=A192141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192141.Bytes);
public long this[int i]=>Value[i];

public static A192141Inst Instance=new A192141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192142
{
public static readonly long[] Value={ 0L,3L,10L,36L,99L,254L,598L,1339L,2872L,5966L,12071L,23908L,46516L,89155L,168702L,315712L,585163L,1075442L,1961754L,3554715L,6402780L,11470778L,20450255L,36297576L,64164744L,113006019L,198345298L,347033724L,605414067L,1053307526L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192142Inst : IEnumerable<long>
{
public static readonly long[] Value=A192142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192142.Bytes);
public long this[int i]=>Value[i];

public static A192142Inst Instance=new A192142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192143
{
public static readonly long[] Value={ 1L,1L,16L,44L,134L,332L,787L,1747L,3736L,7726L,15580L,30760L,59685L,114117L,215472L,402464L,744674L,1366484L,2489175L,4504695L,8104536L,14504226L,25833336L,45811344L,80916169L,142400137L,249760912L,436706132L,761385086L,1323910556L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192143Inst : IEnumerable<long>
{
public static readonly long[] Value=A192143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192143.Bytes);
public long this[int i]=>Value[i];

public static A192143Inst Instance=new A192143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192144
{
public static readonly long[] Value={ 0L,6L,21L,77L,212L,542L,1270L,2830L,6043L,12503L,25208L,49772L,96572L,184646L,348641L,651201L,1204908L,2211018L,4027570L,7288750L,13113415L,23468331L,41799216L,74124312L,130925112L,230408262L,404121645L,706605365L,1231946948L,2142132278L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192144Inst : IEnumerable<long>
{
public static readonly long[] Value=A192144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192144.Bytes);
public long this[int i]=>Value[i];

public static A192144Inst Instance=new A192144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192145
{
public static readonly long[] Value={ 1L,1L,13L,35L,105L,258L,608L,1344L,2865L,5910L,11894L,23444L,45427L,86755L,163645L,305397L,564647L,1035446L,1885050L,3409610L,6131441L,10968416L,19528188L,34617960L,61125685L,107540053L,188567053L,329625719L,574558965L,998836650L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192145Inst : IEnumerable<long>
{
public static readonly long[] Value=A192145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192145.Bytes);
public long this[int i]=>Value[i];

public static A192145Inst Instance=new A192145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192146
{
public static readonly long[] Value={ 0L,5L,17L,61L,166L,421L,981L,2177L,4634L,9564L,19244L,37934L,73502L,140373L,264783L,494143L,913618L,1675387L,3050075L,5516865L,9920880L,17747270L,31597272L,56013036L,98903436L,174003461L,305107901L,533345617L,929655934L,1616151649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192146Inst : IEnumerable<long>
{
public static readonly long[] Value=A192146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192146.Bytes);
public long this[int i]=>Value[i];

public static A192146Inst Instance=new A192146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192147
{
public static readonly long[] Value={ 0L,2L,5L,8L,11L,17L,23L,26L,65L,77L,80L,179L,227L,239L,242L,473L,665L,713L,725L,728L,1163L,1931L,2123L,2171L,2183L,2186L,2465L,3299L,5537L,6305L,6497L,6545L,6557L,6560L,15587L,18659L,19427L,19619L,19667L,19679L,19682L,42665L,54953L,58025L,58793L,58985L,59033L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192147Inst : IEnumerable<long>
{
public static readonly long[] Value=A192147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192147.Bytes);
public long this[int i]=>Value[i];

public static A192147Inst Instance=new A192147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192148
{
public static readonly long[] Value={ 0L,1L,3L,7L,13L,15L,37L,55L,61L,63L,175L,229L,247L,253L,255L,295L,781L,943L,997L,1015L,1021L,1023L,1909L,3367L,3853L,4015L,4069L,4087L,4093L,4095L,6487L,9823L,14197L,15655L,16141L,16303L,16357L,16375L,16381L,16383L,45853L,58975L,63349L,64807L,65293L,65455L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192148Inst : IEnumerable<long>
{
public static readonly long[] Value=A192148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192148.Bytes);
public long this[int i]=>Value[i];

public static A192148Inst Instance=new A192148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192149
{
public static readonly long[] Value={ 0L,2L,4L,8L,22L,26L,56L,76L,80L,104L,118L,218L,238L,242L,604L,704L,724L,728L,1562L,2062L,2162L,2182L,2186L,3436L,4058L,5936L,6436L,6536L,6556L,6560L,16558L,19058L,19558L,19658L,19678L,19682L,43424L,55924L,58424L,58924L,59024L,59044L,59048L,99022L,140816L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192149Inst : IEnumerable<long>
{
public static readonly long[] Value=A192149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192149.Bytes);
public long this[int i]=>Value[i];

public static A192149Inst Instance=new A192149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192150
{
public static readonly long[] Value={ 0L,2L,4L,16L,22L,24L,44L,98L,116L,122L,124L,382L,544L,598L,616L,622L,624L,938L,2396L,2882L,3044L,3098L,3116L,3122L,3124L,9064L,13438L,14896L,15382L,15544L,15598L,15616L,15622L,15624L,19076L,58442L,71564L,75938L,77396L,77882L,78044L,78098L,78116L,78122L,78124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192150Inst : IEnumerable<long>
{
public static readonly long[] Value=A192150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192150.Bytes);
public long this[int i]=>Value[i];

public static A192150Inst Instance=new A192150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192151
{
public static readonly long[] Value={ 0L,2L,3L,8L,21L,26L,27L,45L,75L,80L,207L,237L,242L,513L,693L,723L,728L,891L,1971L,2151L,2181L,2186L,5265L,6345L,6525L,6555L,6560L,11907L,12393L,18387L,19467L,19647L,19677L,19682L,51273L,57753L,58833L,59013L,59043L,59048L,130491L,169371L,175851L,176931L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192151Inst : IEnumerable<long>
{
public static readonly long[] Value=A192151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192151.Bytes);
public long this[int i]=>Value[i];

public static A192151Inst Instance=new A192151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192152
{
public static readonly long[] Value={ 0L,3L,5L,9L,27L,33L,35L,135L,189L,207L,213L,215L,567L,1053L,1215L,1269L,1287L,1293L,1295L,5589L,7047L,7533L,7695L,7749L,7767L,7773L,7775L,26973L,40095L,44469L,45927L,46413L,46575L,46629L,46647L,46653L,46655L,85293L,102789L,220887L,260253L,273375L,277749L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192152Inst : IEnumerable<long>
{
public static readonly long[] Value=A192152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192152.Bytes);
public long this[int i]=>Value[i];

public static A192152Inst Instance=new A192152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192153
{
public static readonly long[] Value={ 0L,2L,8L,20L,26L,32L,74L,80L,194L,236L,242L,386L,680L,722L,728L,1844L,2138L,2180L,2186L,2876L,4160L,6218L,6512L,6554L,6560L,17282L,19340L,19634L,19676L,19682L,42242L,56648L,58706L,59000L,59042L,59048L,59498L,160340L,174746L,176804L,177098L,177140L,177146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192153Inst : IEnumerable<long>
{
public static readonly long[] Value=A192153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192153.Bytes);
public long this[int i]=>Value[i];

public static A192153Inst Instance=new A192153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192154
{
public static readonly long[] Value={ 0L,4L,6L,22L,40L,46L,48L,100L,214L,262L,316L,334L,340L,342L,1672L,2158L,2320L,2374L,2392L,2398L,2400L,10246L,14620L,16078L,16564L,16726L,16780L,16798L,16804L,16806L,58600L,97966L,111088L,115462L,116920L,117406L,117568L,117622L,117640L,117646L,117648L,292102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192154Inst : IEnumerable<long>
{
public static readonly long[] Value=A192154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192154.Bytes);
public long this[int i]=>Value[i];

public static A192154Inst Instance=new A192154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192155
{
public static readonly long[] Value={ 0L,1L,2L,8L,17L,19L,26L,73L,80L,179L,217L,235L,242L,665L,721L,728L,1675L,2123L,2179L,2186L,2465L,6049L,6497L,6553L,6560L,15587L,19171L,19619L,19675L,19682L,26281L,54953L,58537L,58985L,59041L,59048L,144379L,173051L,176635L,177083L,177139L,177146L,269297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192155Inst : IEnumerable<long>
{
public static readonly long[] Value=A192155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192155.Bytes);
public long this[int i]=>Value[i];

public static A192155Inst Instance=new A192155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192204
{
public static readonly ulong[] Value={ 1L,2L,13L,109L,1099L,12283L,147620L,1869346L,24633344L,334916467L,4669887745L,66481991644L,963096090267L,14160279233964L,210870471771803L,3175275874056722L,48281516978747396L,740504452581897112L,11444972742343813815UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192204Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A192204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192204.Bytes);
public ulong this[int i]=>Value[i];

public static A192204Inst Instance=new A192204Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}