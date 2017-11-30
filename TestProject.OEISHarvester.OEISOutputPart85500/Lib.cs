using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A105141
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,3L,2L,1L,2L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,3L,2L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,3L,2L,1L,2L,1L,1L,2L,1L,2L,3L,2L,1L,2L,1L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,3L,2L,3L,1L,3L,2L,3L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,3L,2L,1L,2L,1L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105141Inst : IEnumerable<long>
{
public static readonly long[] Value=A105141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105141.Bytes);
public long this[int i]=>Value[i];

public static A105141Inst Instance=new A105141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105142
{
public static readonly long[] Value={ 2L,6L,34L,46L,142L,174L,204L,238L,312L,466L,550L,616L,690L,730L,1136L,1280L,1302L,1330L,1486L,1586L,1610L,1638L,1644L,1652L,1688L,1706L,1772L,1934L,1952L,1972L,2040L,2102L,2108L,2142L,2192L,2238L,2250L,2376L,2400L,2554L,2612L,2646L,3006L,3094L,3550L,3642L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105142Inst : IEnumerable<long>
{
public static readonly long[] Value=A105142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105142.Bytes);
public long this[int i]=>Value[i];

public static A105142Inst Instance=new A105142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105143
{
public static readonly long[] Value={ 1L,4L,8L,14L,24L,45L,94L,205L,440L,912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105143Inst : IEnumerable<long>
{
public static readonly long[] Value=A105143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105143.Bytes);
public long this[int i]=>Value[i];

public static A105143Inst Instance=new A105143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105144
{
public static readonly long[] Value={ 1L,0L,8L,4L,9L,9L,8L,7L,7L,8L,2L,2L,7L,8L,7L,1L,9L,3L,3L,5L,8L,3L,3L,3L,8L,8L,6L,4L,4L,6L,6L,5L,0L,7L,8L,0L,5L,2L,8L,7L,7L,6L,1L,1L,4L,0L,2L,7L,5L,6L,5L,7L,3L,9L,8L,6L,8L,9L,4L,7L,7L,9L,5L,8L,3L,3L,8L,2L,9L,3L,7L,9L,7L,2L,8L,3L,8L,1L,6L,2L,9L,7L,2L,8L,1L,4L,3L,0L,8L,1L,9L,0L,6L,5L,8L,4L,6L,9L,4L,6L,8L,4L,4L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105144Inst : IEnumerable<long>
{
public static readonly long[] Value=A105144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105144.Bytes);
public long this[int i]=>Value[i];

public static A105144Inst Instance=new A105144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105145
{
public static readonly long[] Value={ 18L,21L,30L,32L,39L,71L,72L,78L,84L,86L,89L,93L,95L,98L,107L,108L,135L,143L,150L,152L,159L,161L,165L,170L,173L,177L,179L,180L,192L,198L,203L,221L,243L,245L,248L,261L,269L,281L,282L,294L,302L,306L,315L,320L,329L,336L,338L,347L,369L,374L,378L,395L,399L,423L,425L,443L,446L,449L,456L,458L,471L,500L,504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105145Inst : IEnumerable<long>
{
public static readonly long[] Value=A105145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105145.Bytes);
public long this[int i]=>Value[i];

public static A105145Inst Instance=new A105145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105146
{
public static readonly long[] Value={ 2L,6L,17L,23L,26L,38L,39L,42L,59L,63L,83L,89L,96L,102L,107L,117L,135L,144L,146L,153L,159L,174L,179L,182L,185L,189L,191L,192L,194L,201L,206L,230L,233L,237L,240L,245L,248L,249L,251L,252L,270L,279L,285L,287L,293L,299L,300L,318L,321L,329L,335L,339L,345L,350L,354L,356L,378L,387L,392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105146Inst : IEnumerable<long>
{
public static readonly long[] Value=A105146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105146.Bytes);
public long this[int i]=>Value[i];

public static A105146Inst Instance=new A105146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105147
{
public static readonly long[] Value={ 1L,1L,1L,3L,0L,1L,6L,1L,0L,1L,13L,2L,0L,0L,1L,27L,3L,1L,0L,0L,1L,56L,5L,2L,0L,0L,0L,1L,115L,9L,2L,1L,0L,0L,0L,1L,235L,15L,3L,2L,0L,0L,0L,0L,1L,478L,25L,5L,2L,1L,0L,0L,0L,0L,1L,969L,42L,8L,2L,2L,0L,0L,0L,0L,0L,1L,1959L,70L,12L,3L,2L,1L,0L,0L,0L,0L,0L,1L,3952L,116L,18L,5L,2L,2L,0L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105147Inst : IEnumerable<long>
{
public static readonly long[] Value=A105147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105147.Bytes);
public long this[int i]=>Value[i];

public static A105147Inst Instance=new A105147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105148
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,7L,10L,9L,14L,14L,19L,19L,24L,27L,32L,30L,41L,36L,44L,47L,55L,56L,62L,64L,69L,78L,77L,85L,90L,95L,107L,103L,109L,122L,118L,138L,133L,149L,142L,157L,168L,171L,177L,178L,193L,201L,214L,211L,220L,231L,243L,241L,253L,262L,272L,294L,288L,286L,308L,322L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105148Inst : IEnumerable<long>
{
public static readonly long[] Value=A105148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105148.Bytes);
public long this[int i]=>Value[i];

public static A105148Inst Instance=new A105148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105149
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,2L,2L,1L,3L,2L,3L,3L,2L,4L,2L,3L,3L,4L,5L,1L,6L,3L,5L,3L,4L,4L,5L,4L,6L,5L,5L,3L,6L,5L,7L,6L,4L,6L,5L,7L,6L,5L,6L,6L,8L,8L,5L,6L,8L,7L,6L,5L,9L,9L,7L,10L,6L,7L,8L,5L,10L,6L,10L,9L,8L,8L,10L,8L,11L,5L,9L,9L,13L,10L,9L,9L,9L,8L,8L,10L,12L,7L,11L,12L,12L,10L,10L,12L,10L,12L,10L,10L,10L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105149Inst : IEnumerable<long>
{
public static readonly long[] Value=A105149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105149.Bytes);
public long this[int i]=>Value[i];

public static A105149Inst Instance=new A105149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105150
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,5L,8L,1L,2L,3L,5L,8L,1L,2L,3L,5L,8L,1L,2L,3L,5L,8L,1L,2L,3L,5L,8L,1L,2L,3L,5L,8L,1L,2L,3L,5L,8L,1L,2L,3L,5L,8L,1L,2L,3L,5L,8L,1L,2L,3L,5L,8L,1L,2L,3L,5L,8L,1L,2L,3L,5L,8L,1L,2L,3L,5L,8L,1L,2L,3L,5L,8L,1L,2L,3L,5L,8L,1L,2L,3L,5L,8L,1L,2L,3L,5L,8L,1L,2L,3L,5L,8L,1L,2L,3L,5L,8L,1L,2L,3L,5L,8L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105150Inst : IEnumerable<long>
{
public static readonly long[] Value=A105150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105150.Bytes);
public long this[int i]=>Value[i];

public static A105150Inst Instance=new A105150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105151
{
public static readonly BigInteger[] Value={ 1L,3L,11L,48L,253L,1576L,11331L,92467L,845064L,8554195L,95032146L,1149773923L,15050556403L,211951761735L,3195468293093L,51354400809456L,876431092504915L,15830294577832786L,301703171661686235L,6050766978392127541L,BigInteger.Parse("127383588868883838996"),BigInteger.Parse("2808790552014917701633") };
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
public class A105151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105151Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105151.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105151Inst Instance=new A105151Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105152
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,4L,9L,13L,25L,52L,94L,195L,354L,691L,1341L,2514L,4746L,8984L,16639L,31031L,57421L,105091L,192266L,349765L,632223L,1138114L,2043082L,3642712L,6474196L,11462149L,20189285L,35427948L,61987644L,107928280L,187336851L,324080969L,558451251L,959214488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105152Inst : IEnumerable<long>
{
public static readonly long[] Value=A105152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105152.Bytes);
public long this[int i]=>Value[i];

public static A105152Inst Instance=new A105152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105153
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,2L,1L,2L,4L,2L,2L,4L,4L,2L,2L,4L,4L,1L,4L,4L,4L,1L,4L,4L,4L,1L,4L,4L,4L,1L,4L,4L,4L,4L,8L,4L,4L,4L,4L,8L,4L,4L,8L,4L,4L,4L,4L,8L,4L,4L,8L,4L,4L,4L,4L,8L,4L,4L,8L,4L,4L,4L,4L,8L,2L,16L,8L,4L,2L,4L,8L,16L,2L,16L,8L,4L,2L,4L,8L,16L,2L,16L,8L,4L,2L,4L,8L,16L,2L,16L,8L,4L,2L,4L,8L,16L,2L,16L,8L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105153Inst : IEnumerable<long>
{
public static readonly long[] Value=A105153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105153.Bytes);
public long this[int i]=>Value[i];

public static A105153Inst Instance=new A105153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105154
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,1L,2L,1L,4L,2L,2L,4L,4L,2L,2L,4L,4L,4L,1L,4L,4L,4L,1L,4L,4L,4L,1L,4L,4L,4L,1L,4L,8L,4L,4L,4L,4L,8L,4L,4L,8L,4L,4L,4L,4L,8L,4L,4L,8L,4L,4L,4L,4L,8L,4L,4L,8L,4L,4L,4L,4L,8L,4L,4L,16L,8L,4L,2L,4L,8L,16L,2L,16L,8L,4L,2L,4L,8L,16L,2L,16L,8L,4L,2L,4L,8L,16L,2L,16L,8L,4L,2L,4L,8L,16L,2L,16L,8L,4L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105154Inst : IEnumerable<long>
{
public static readonly long[] Value=A105154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105154.Bytes);
public long this[int i]=>Value[i];

public static A105154Inst Instance=new A105154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105155
{
public static readonly long[] Value={ 10L,6L,9L,4L,6L,10L,14L,21L,35L,49L,22L,33L,55L,77L,121L,26L,39L,65L,91L,143L,169L,34L,51L,85L,119L,187L,221L,289L,38L,57L,95L,133L,209L,247L,323L,361L,46L,69L,115L,161L,253L,299L,391L,437L,529L,58L,87L,145L,203L,319L,377L,493L,551L,667L,841L,62L,93L,155L,217L,341L,403L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105155Inst : IEnumerable<long>
{
public static readonly long[] Value=A105155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105155.Bytes);
public long this[int i]=>Value[i];

public static A105155Inst Instance=new A105155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105156
{
public static readonly long[] Value={ 10L,15L,20L,119L,308L,533L,986L,1463L,2300L,3741L,4960L,7289L,9758L,12083L,15416L,20193L,25960L,30561L,38056L,45369L,51976L,62489L,72542L,85707L,102820L,117261L,130192L,146697L,161320L,180009L,218440L,242481L,272356L,295653L,339124L,366477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105156Inst : IEnumerable<long>
{
public static readonly long[] Value=A105156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105156.Bytes);
public long this[int i]=>Value[i];

public static A105156Inst Instance=new A105156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105157
{
public static readonly long[] Value={ 6L,10L,70L,85L,364L,451L,1102L,1309L,2900L,2967L,5920L,6107L,10234L,11521L,17384L,17907L,26840L,29559L,40328L,42813L,56248L,57743L,77786L,79929L,107060L,112617L,135248L,141213L,167240L,173637L,225320L,235077L,276332L,291399L,343676L,361623L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105157Inst : IEnumerable<long>
{
public static readonly long[] Value=A105157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105157.Bytes);
public long this[int i]=>Value[i];

public static A105157Inst Instance=new A105157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105158
{
public static readonly long[] Value={ 0L,3L,3L,6L,2L,6L,5L,5L,5L,15L,4L,8L,4L,28L,15L,7L,7L,9L,23L,61L,10L,6L,10L,8L,18L,44L,126L,9L,17L,9L,11L,17L,39L,93L,251L,8L,12L,8L,14L,16L,34L,76L,190L,504L,11L,11L,19L,13L,19L,33L,71L,157L,379L,1017L,14L,10L,14L,12L,22L,32L,66L,140L,318L,760L,2042L,13L,13L,13L,23L,21L,35L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105158Inst : IEnumerable<long>
{
public static readonly long[] Value=A105158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105158.Bytes);
public long this[int i]=>Value[i];

public static A105158Inst Instance=new A105158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105159
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,3L,3L,3L,3L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,3L,1L,9L,1L,9L,3L,1L,9L,3L,1L,9L,3L,1L,9L,3L,1L,9L,3L,1L,9L,3L,1L,9L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105159Inst : IEnumerable<long>
{
public static readonly long[] Value=A105159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105159.Bytes);
public long this[int i]=>Value[i];

public static A105159Inst Instance=new A105159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105160
{
public static readonly long[] Value={ 6L,4L,6L,14L,21L,35L,10L,15L,25L,35L,26L,39L,65L,91L,143L,22L,33L,55L,77L,121L,143L,38L,57L,95L,133L,209L,247L,323L,34L,51L,85L,119L,187L,221L,289L,323L,58L,87L,145L,203L,319L,377L,493L,551L,667L,46L,69L,115L,161L,253L,299L,391L,437L,529L,667L,74L,111L,185L,259L,407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105160Inst : IEnumerable<long>
{
public static readonly long[] Value=A105160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105160.Bytes);
public long this[int i]=>Value[i];

public static A105160Inst Instance=new A105160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105161
{
public static readonly long[] Value={ 3L,2L,3L,4L,3L,6L,5L,6L,5L,4L,3L,6L,5L,6L,5L,4L,3L,6L,5L,10L,9L,8L,7L,8L,7L,6L,5L,4L,3L,8L,7L,10L,9L,8L,7L,6L,5L,6L,5L,4L,3L,6L,5L,10L,9L,8L,7L,12L,11L,10L,9L,8L,7L,8L,7L,6L,5L,4L,3L,8L,7L,10L,9L,8L,7L,6L,5L,6L,5L,4L,3L,8L,7L,10L,9L,8L,7L,6L,5L,10L,9L,8L,7L,14L,13L,12L,11L,10L,9L,12L,11L,10L,9L,8L,7L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105161Inst : IEnumerable<long>
{
public static readonly long[] Value=A105161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105161.Bytes);
public long this[int i]=>Value[i];

public static A105161Inst Instance=new A105161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105162
{
public static readonly long[] Value={ 10L,1L,8L,27L,40L,55L,228L,175L,336L,455L,450L,741L,770L,861L,1274L,1377L,2080L,1595L,2622L,2145L,2840L,3315L,3564L,4275L,5148L,4655L,5454L,5777L,6440L,6327L,9030L,7625L,10564L,9135L,13330L,9425L,14628L,11431L,16224L,13167L,18870L,13825L,20720L,15471L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105162Inst : IEnumerable<long>
{
public static readonly long[] Value=A105162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105162.Bytes);
public long this[int i]=>Value[i];

public static A105162Inst Instance=new A105162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105163
{
public static readonly long[] Value={ 1L,1L,3L,8L,17L,31L,51L,78L,113L,157L,211L,276L,353L,443L,547L,666L,801L,953L,1123L,1312L,1521L,1751L,2003L,2278L,2577L,2901L,3251L,3628L,4033L,4467L,4931L,5426L,5953L,6513L,7107L,7736L,8401L,9103L,9843L,10622L,11441L,12301L,13203L,14148L,15137L,16171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105163Inst : IEnumerable<long>
{
public static readonly long[] Value=A105163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105163.Bytes);
public long this[int i]=>Value[i];

public static A105163Inst Instance=new A105163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105164
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,3L,1L,2L,2L,3L,2L,3L,3L,4L,1L,2L,2L,3L,2L,3L,3L,4L,2L,3L,3L,4L,3L,4L,4L,5L,1L,2L,2L,3L,2L,3L,3L,4L,2L,3L,3L,4L,3L,4L,4L,5L,2L,3L,3L,4L,3L,4L,4L,5L,3L,4L,4L,5L,4L,5L,5L,5L,9L,7L,6L,1L,2L,2L,3L,2L,3L,3L,4L,2L,3L,3L,4L,3L,4L,4L,5L,2L,3L,3L,4L,3L,4L,4L,5L,3L,4L,4L,5L,4L,5L,5L,5L,9L,7L,6L,2L,3L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105164Inst : IEnumerable<long>
{
public static readonly long[] Value=A105164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105164.Bytes);
public long this[int i]=>Value[i];

public static A105164Inst Instance=new A105164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105165
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105165Inst : IEnumerable<long>
{
public static readonly long[] Value=A105165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105165.Bytes);
public long this[int i]=>Value[i];

public static A105165Inst Instance=new A105165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105166
{
public static readonly long[] Value={ 1L,1L,1L,2L,0L,2L,0L,1L,2L,1L,1L,1L,0L,0L,1L,0L,0L,2L,0L,0L,0L,0L,2L,0L,1L,2L,0L,0L,1L,1L,1L,0L,0L,1L,2L,0L,1L,0L,1L,0L,0L,0L,1L,0L,2L,0L,1L,1L,1L,2L,1L,0L,0L,0L,2L,0L,2L,1L,1L,0L,1L,1L,2L,0L,2L,0L,2L,0L,1L,0L,2L,1L,0L,1L,2L,1L,2L,0L,0L,0L,0L,1L,1L,0L,2L,0L,0L,0L,1L,0L,0L,0L,2L,1L,1L,2L,1L,2L,0L,2L,0L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105166Inst : IEnumerable<long>
{
public static readonly long[] Value=A105166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105166.Bytes);
public long this[int i]=>Value[i];

public static A105166Inst Instance=new A105166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105167
{
public static readonly long[] Value={ 7L,7L,0L,0L,5L,9L,8L,5L,6L,5L,3L,3L,7L,9L,4L,0L,1L,4L,2L,9L,7L,8L,6L,1L,8L,7L,7L,4L,5L,0L,3L,5L,8L,4L,8L,4L,6L,1L,4L,3L,0L,4L,8L,8L,3L,8L,6L,3L,4L,5L,9L,1L,0L,5L,4L,4L,2L,4L,1L,1L,4L,0L,4L,2L,2L,5L,7L,1L,9L,2L,1L,8L,4L,6L,9L,7L,3L,0L,7L,8L,8L,1L,2L,4L,0L,9L,5L,2L,2L,1L,4L,4L,0L,2L,5L,9L,8L,9L,6L,8L,2L,1L,0L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105167Inst : IEnumerable<long>
{
public static readonly long[] Value=A105167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105167.Bytes);
public long this[int i]=>Value[i];

public static A105167Inst Instance=new A105167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105168
{
public static readonly long[] Value={ 1L,7L,3L,9L,8L,9L,8L,9L,4L,9L,6L,8L,1L,8L,0L,9L,0L,0L,4L,9L,1L,1L,4L,7L,5L,8L,6L,9L,9L,7L,8L,1L,1L,1L,5L,1L,9L,3L,2L,9L,6L,8L,0L,0L,9L,3L,5L,6L,2L,4L,7L,5L,7L,4L,6L,9L,5L,8L,8L,1L,7L,1L,4L,7L,5L,6L,3L,6L,2L,7L,0L,2L,0L,6L,5L,4L,3L,7L,3L,0L,0L,1L,8L,2L,7L,4L,5L,4L,3L,4L,1L,8L,9L,5L,0L,8L,6L,9L,2L,2L,9L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105168Inst : IEnumerable<long>
{
public static readonly long[] Value=A105168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105168.Bytes);
public long this[int i]=>Value[i];

public static A105168Inst Instance=new A105168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105169
{
public static readonly long[] Value={ 1L,1L,4L,7L,9L,6L,5L,3L,8L,5L,5L,2L,7L,7L,5L,5L,0L,3L,2L,9L,2L,9L,5L,6L,5L,8L,6L,8L,6L,8L,0L,9L,3L,5L,1L,0L,3L,0L,3L,9L,0L,8L,0L,7L,9L,5L,5L,8L,2L,9L,7L,1L,9L,7L,9L,7L,6L,3L,2L,6L,1L,1L,4L,5L,6L,0L,2L,1L,8L,0L,1L,5L,9L,0L,7L,7L,6L,4L,3L,8L,8L,9L,0L,0L,6L,4L,2L,1L,4L,9L,2L,1L,7L,9L,5L,2L,0L,4L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105169Inst : IEnumerable<long>
{
public static readonly long[] Value=A105169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105169.Bytes);
public long this[int i]=>Value[i];

public static A105169Inst Instance=new A105169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105170
{
public static readonly long[] Value={ 11L,17L,29L,41L,59L,67L,71L,73L,89L,97L,103L,127L,137L,149L,151L,163L,173L,179L,181L,191L,193L,197L,223L,227L,229L,233L,239L,241L,257L,263L,271L,277L,311L,317L,331L,347L,349L,353L,359L,367L,373L,379L,389L,397L,409L,419L,433L,443L,461L,463L,467L,479L,487L,499L,503L,541L,547L,557L,563L,571L,577L,587L,593L,599L,607L,613L,617L,619L,631L,641L,647L,653L,659L,661L,677L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105170Inst : IEnumerable<long>
{
public static readonly long[] Value=A105170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105170.Bytes);
public long this[int i]=>Value[i];

public static A105170Inst Instance=new A105170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105171
{
public static readonly long[] Value={ 1L,1L,0L,0L,9L,3L,2L,6L,6L,5L,1L,9L,3L,6L,2L,6L,6L,0L,7L,6L,5L,4L,9L,7L,5L,8L,8L,0L,2L,6L,1L,4L,0L,8L,3L,6L,0L,8L,4L,1L,1L,8L,4L,8L,2L,8L,0L,1L,9L,4L,6L,5L,1L,6L,1L,8L,1L,3L,6L,2L,0L,7L,4L,5L,6L,8L,5L,9L,9L,6L,8L,1L,4L,5L,2L,0L,6L,2L,4L,9L,7L,6L,1L,7L,1L,2L,5L,2L,1L,4L,4L,8L,5L,7L,0L,5L,0L,1L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105171Inst : IEnumerable<long>
{
public static readonly long[] Value=A105171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105171.Bytes);
public long this[int i]=>Value[i];

public static A105171Inst Instance=new A105171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105172
{
public static readonly long[] Value={ 9L,2L,8L,3L,8L,0L,7L,9L,9L,2L,5L,8L,9L,7L,4L,0L,2L,9L,5L,1L,4L,6L,5L,6L,0L,4L,4L,6L,6L,1L,2L,0L,7L,0L,1L,5L,1L,7L,7L,8L,3L,7L,0L,0L,6L,2L,8L,4L,4L,7L,0L,4L,2L,3L,6L,8L,0L,2L,1L,4L,8L,4L,0L,3L,3L,0L,5L,9L,4L,2L,4L,7L,0L,6L,9L,5L,9L,3L,7L,6L,7L,7L,2L,2L,1L,7L,7L,6L,8L,4L,8L,8L,9L,9L,0L,8L,0L,4L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105172Inst : IEnumerable<long>
{
public static readonly long[] Value=A105172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105172.Bytes);
public long this[int i]=>Value[i];

public static A105172Inst Instance=new A105172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105173
{
public static readonly long[] Value={ 3L,7L,8L,15L,16L,23L,24L,32L,39L,40L,47L,48L,55L,56L,63L,64L,71L,79L,80L,87L,95L,103L,104L,111L,112L,119L,120L,128L,135L,136L,143L,151L,152L,159L,167L,175L,176L,183L,199L,208L,216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105173Inst : IEnumerable<long>
{
public static readonly long[] Value=A105173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105173.Bytes);
public long this[int i]=>Value[i];

public static A105173Inst Instance=new A105173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105174
{
public static readonly long[] Value={ 8L,15L,23L,24L,71L,80L,104L,128L,159L,216L,231L,264L,288L,303L,336L,344L,455L,495L,528L,543L,560L,608L,624L,680L,744L,816L,840L,879L,896L,1016L,1104L,1311L,1415L,1440L,1464L,1520L,1584L,1599L,1751L,1871L,1896L,1920L,1976L,2015L,2016L,2055L,2088L,2103L,2175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105174Inst : IEnumerable<long>
{
public static readonly long[] Value=A105174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105174.Bytes);
public long this[int i]=>Value[i];

public static A105174Inst Instance=new A105174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105175
{
public static readonly BigInteger[] Value={ 0L,0L,9235919L,14984879L,447402699579360L,725891508817440L,BigInteger.Parse("21672901717138141202159"),BigInteger.Parse("35163344661747893105039"),BigInteger.Parse("1049869992475115099179547651520"),BigInteger.Parse("1703368606439836689249786415680"),BigInteger.Parse("50857380127742528965284060018658947599"),BigInteger.Parse("82513897278978744922944413386362572399") };
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
public class A105175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105175Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105175.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105175Inst Instance=new A105175Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105176
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,17L,23L,34L,201L,706L,1413L,2265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105176Inst : IEnumerable<long>
{
public static readonly long[] Value=A105176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105176.Bytes);
public long this[int i]=>Value[i];

public static A105176Inst Instance=new A105176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105177
{
public static readonly long[] Value={ 3L,1L,4L,5L,9L,2L,6L,8L,7L,0L,31L,14L,41L,15L,59L,92L,26L,65L,53L,35L,58L,89L,97L,79L,93L,32L,23L,38L,84L,46L,62L,64L,43L,33L,83L,27L,95L,50L,28L,88L,19L,71L,16L,69L,39L,99L,37L,75L,51L,10L,82L,20L,74L,49L,94L,44L,45L,30L,78L,81L,40L,86L,98L,80L,34L,48L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105177Inst : IEnumerable<long>
{
public static readonly long[] Value=A105177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105177.Bytes);
public long this[int i]=>Value[i];

public static A105177Inst Instance=new A105177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105178
{
public static readonly long[] Value={ 2L,7L,1L,8L,4L,5L,9L,0L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105178Inst : IEnumerable<long>
{
public static readonly long[] Value=A105178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105178.Bytes);
public long this[int i]=>Value[i];

public static A105178Inst Instance=new A105178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105179
{
public static readonly long[] Value={ 1L,11L,15L,20L,25L,31L,40L,41L,45L,60L,61L,71L,75L,80L,100L,101L,105L,120L,121L,125L,131L,135L,140L,143L,151L,160L,165L,175L,180L,181L,187L,191L,195L,200L,209L,211L,220L,225L,240L,241L,251L,253L,255L,260L,271L,275L,280L,281L,285L,300L,311L,315L,319L,320L,325L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105179Inst : IEnumerable<long>
{
public static readonly long[] Value=A105179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105179.Bytes);
public long this[int i]=>Value[i];

public static A105179Inst Instance=new A105179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105180
{
public static readonly long[] Value={ 1L,2L,3L,5L,9L,25L,34L,36L,42L,52L,176L,262L,269L,283L,284L,289L,372L,392L,486L,596L,999L,1022L,1097L,1105L,2329L,2663L,3037L,3363L,3853L,5167L,6305L,7164L,7283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105180Inst : IEnumerable<long>
{
public static readonly long[] Value=A105180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105180.Bytes);
public long this[int i]=>Value[i];

public static A105180Inst Instance=new A105180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105181
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,10L,14L,22L,38L,42L,71L,118L,128L,159L,179L,214L,484L,951L,1148L,1162L,1427L,1532L,1692L,1861L,2261L,3760L,4575L,6974L,7295L,8367L,8463L,8600L,14878L,16165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105181Inst : IEnumerable<long>
{
public static readonly long[] Value=A105181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105181.Bytes);
public long this[int i]=>Value[i];

public static A105181Inst Instance=new A105181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105182
{
public static readonly long[] Value={ 1L,5L,9L,49L,61L,81L,149L,413L,485L,661L,709L,1337L,2885L,2925L,3013L,7213L,9669L,10245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105182Inst : IEnumerable<long>
{
public static readonly long[] Value=A105182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105182.Bytes);
public long this[int i]=>Value[i];

public static A105182Inst Instance=new A105182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105183
{
public static readonly BigInteger[] Value={ 2L,7L,57L,3307L,10939557L,119673918295807L,BigInteger.Parse("14321846720271609085072077057"),BigInteger.Parse("205115293478954645768397227034180943592279329877217858307"),BigInteger.Parse("42072283618957694230389567430137958296609066493047345973782287300661413651741392431587718724877522268597146764557") };
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
public class A105183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105183Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105183.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105183Inst Instance=new A105183Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105184
{
public static readonly long[] Value={ 23L,37L,53L,73L,113L,137L,173L,193L,197L,211L,223L,229L,233L,241L,271L,283L,293L,311L,313L,317L,331L,337L,347L,353L,359L,367L,373L,379L,383L,389L,397L,433L,523L,541L,547L,571L,593L,613L,617L,673L,677L,719L,733L,743L,761L,773L,797L,977L,1013L,1033L,1093L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105184Inst : IEnumerable<long>
{
public static readonly long[] Value=A105184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105184.Bytes);
public long this[int i]=>Value[i];

public static A105184Inst Instance=new A105184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105185
{
public static readonly long[] Value={ 1L,4L,3L,8L,10L,30L,84L,56L,18L,100L,198L,108L,351L,42L,375L,128L,136L,450L,551L,600L,966L,66L,552L,336L,2125L,780L,594L,2576L,348L,2520L,4867L,288L,726L,1802L,5740L,2664L,6438L,722L,4446L,1080L,4674L,3150L,559L,1628L,8955L,3358L,15933L,576L,1764L,1700L,5763L,2652L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105185Inst : IEnumerable<long>
{
public static readonly long[] Value=A105185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105185.Bytes);
public long this[int i]=>Value[i];

public static A105185Inst Instance=new A105185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105186
{
public static readonly long[] Value={ 0L,1L,2L,0L,1L,2L,0L,1L,2L,9L,10L,11L,9L,10L,11L,9L,10L,11L,18L,19L,20L,18L,19L,20L,18L,19L,20L,0L,1L,2L,0L,1L,2L,0L,1L,2L,9L,10L,11L,9L,10L,11L,9L,10L,11L,18L,19L,20L,18L,19L,20L,18L,19L,20L,0L,1L,2L,0L,1L,2L,0L,1L,2L,9L,10L,11L,9L,10L,11L,9L,10L,11L,18L,19L,20L,18L,19L,20L,18L,19L,20L,81L,82L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105186Inst : IEnumerable<long>
{
public static readonly long[] Value=A105186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105186.Bytes);
public long this[int i]=>Value[i];

public static A105186Inst Instance=new A105186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105187
{
public static readonly BigInteger[] Value={ 1L,24L,720L,28800L,1512000L,101606400L,8534937600L,877879296000L,108637562880000L,15933509222400000L,2734190182563840000L,BigInteger.Parse("542861032610856960000"),BigInteger.Parse("123500884918969958400000") };
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
public class A105187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105187Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105187.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105187Inst Instance=new A105187Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105188
{
public static readonly BigInteger[] Value={ 1L,120L,21600L,6048000L,2540160000L,1536288768000L,1290482565120000L,1460088845107200000L,BigInteger.Parse("2168231934984192000000"),BigInteger.Parse("4134095556036526080000000"),BigInteger.Parse("9931751163822150254592000000"),BigInteger.Parse("29578560738801240212766720000000") };
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
public class A105188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105188Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105188.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105188Inst Instance=new A105188Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105189
{
public static readonly long[] Value={ 14L,17L,24L,51L,54L,62L,89L,114L,116L,147L,159L,167L,170L,173L,180L,201L,233L,240L,249L,252L,254L,270L,285L,296L,317L,332L,350L,353L,362L,369L,371L,390L,399L,410L,423L,431L,446L,468L,479L,485L,497L,536L,543L,551L,564L,570L,573L,581L,585L,608L,609L,612L,654L,656L,683L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105189Inst : IEnumerable<long>
{
public static readonly long[] Value=A105189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105189.Bytes);
public long this[int i]=>Value[i];

public static A105189Inst Instance=new A105189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105190
{
public static readonly long[] Value={ 4L,4L,2L,2L,4L,2L,4L,3L,3L,3L,6L,4L,2L,4L,1L,3L,3L,1L,3L,4L,2L,4L,5L,3L,1L,4L,2L,4L,3L,4L,2L,3L,3L,3L,3L,2L,4L,2L,2L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105190Inst : IEnumerable<long>
{
public static readonly long[] Value=A105190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105190.Bytes);
public long this[int i]=>Value[i];

public static A105190Inst Instance=new A105190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105191
{
public static readonly long[] Value={ 24L,16L,6L,4L,16L,4L,16L,16L,12L,8L,64L,16L,4L,16L,2L,8L,12L,2L,8L,16L,4L,16L,32L,8L,2L,24L,4L,16L,8L,16L,4L,8L,8L,8L,36L,4L,16L,4L,4L,16L,16L,8L,4L,24L,32L,8L,64L,16L,4L,4L,4L,2L,72L,4L,2L,8L,4L,48L,8L,4L,16L,64L,2L,4L,8L,4L,8L,4L,16L,16L,12L,4L,4L,16L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105191Inst : IEnumerable<long>
{
public static readonly long[] Value=A105191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105191.Bytes);
public long this[int i]=>Value[i];

public static A105191Inst Instance=new A105191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105192
{
public static readonly long[] Value={ 2L,4L,4L,4L,4L,2L,2L,8L,2L,4L,16L,4L,2L,8L,4L,2L,6L,6L,4L,4L,2L,2L,8L,4L,8L,6L,4L,4L,16L,2L,4L,8L,4L,4L,10L,4L,4L,8L,4L,4L,4L,4L,2L,6L,2L,8L,12L,8L,4L,8L,2L,4L,12L,2L,2L,4L,2L,8L,8L,4L,2L,16L,8L,4L,8L,2L,12L,4L,8L,4L,6L,4L,2L,12L,2L,8L,4L,2L,2L,24L,4L,2L,4L,2L,4L,8L,4L,8L,16L,2L,4L,4L,4L,4L,8L,2L,4L,6L,2L,4L,8L,16L,2L,4L,4L,4L,6L,2L,4L,8L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105192Inst : IEnumerable<long>
{
public static readonly long[] Value=A105192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105192.Bytes);
public long this[int i]=>Value[i];

public static A105192Inst Instance=new A105192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105193
{
public static readonly long[] Value={ 8L,8L,2L,4L,8L,2L,2L,24L,2L,8L,8L,4L,2L,8L,4L,4L,16L,4L,2L,4L,8L,8L,16L,2L,4L,9L,8L,4L,8L,4L,6L,8L,4L,4L,6L,8L,2L,4L,2L,8L,8L,2L,8L,20L,8L,4L,8L,4L,2L,16L,2L,2L,24L,4L,2L,16L,9L,2L,8L,4L,4L,12L,4L,8L,8L,4L,4L,4L,2L,2L,16L,2L,4L,8L,2L,2L,16L,32L,4L,12L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105193Inst : IEnumerable<long>
{
public static readonly long[] Value=A105193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105193.Bytes);
public long this[int i]=>Value[i];

public static A105193Inst Instance=new A105193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105194
{
public static readonly long[] Value={ 1L,2L,1L,2L,2L,2L,2L,2L,3L,1L,2L,1L,1L,4L,2L,1L,3L,1L,2L,2L,2L,2L,2L,2L,2L,3L,1L,1L,3L,1L,1L,2L,2L,2L,3L,3L,2L,3L,2L,2L,3L,2L,2L,3L,2L,1L,2L,2L,2L,2L,1L,2L,2L,2L,1L,3L,1L,2L,4L,2L,2L,2L,2L,2L,3L,2L,3L,2L,3L,1L,2L,1L,1L,3L,2L,1L,2L,1L,3L,3L,1L,2L,3L,3L,1L,4L,2L,2L,3L,1L,1L,2L,3L,3L,2L,1L,2L,4L,4L,2L,2L,1L,2L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105194Inst : IEnumerable<long>
{
public static readonly long[] Value=A105194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105194.Bytes);
public long this[int i]=>Value[i];

public static A105194Inst Instance=new A105194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105195
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,4L,4L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,7L,6L,7L,7L,7L,7L,7L,7L,8L,7L,7L,7L,8L,8L,7L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105195Inst : IEnumerable<long>
{
public static readonly long[] Value=A105195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105195.Bytes);
public long this[int i]=>Value[i];

public static A105195Inst Instance=new A105195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105196
{
public static readonly long[] Value={ 1L,1L,4L,2L,12L,27L,6L,44L,162L,256L,24L,200L,945L,2560L,3125L,120L,1096L,6075L,21760L,46875L,46656L,720L,7056L,43848L,188160L,546875L,979776L,823543L,5040L,52272L,354564L,1732864L,6125000L,15023232L,23059204L,16777216L,40320L,438336L,3189348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105196Inst : IEnumerable<long>
{
public static readonly long[] Value=A105196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105196.Bytes);
public long this[int i]=>Value[i];

public static A105196Inst Instance=new A105196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105197
{
public static readonly long[] Value={ 1L,1L,4L,1L,12L,27L,1L,28L,162L,256L,1L,60L,675L,2560L,3125L,1L,124L,2430L,16640L,46875L,46656L,1L,252L,8127L,89600L,437500L,979776L,823543L,1L,508L,26082L,435456L,3281250L,12410496L,23059204L,16777216L,1L,1020L,81675L,1989120L,21721875L,123451776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105197Inst : IEnumerable<long>
{
public static readonly long[] Value=A105197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105197.Bytes);
public long this[int i]=>Value[i];

public static A105197Inst Instance=new A105197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105198
{
public static readonly long[] Value={ 0L,1L,3L,2L,2L,3L,1L,0L,0L,1L,3L,2L,2L,3L,1L,0L,0L,1L,3L,2L,2L,3L,1L,0L,0L,1L,3L,2L,2L,3L,1L,0L,0L,1L,3L,2L,2L,3L,1L,0L,0L,1L,3L,2L,2L,3L,1L,0L,0L,1L,3L,2L,2L,3L,1L,0L,0L,1L,3L,2L,2L,3L,1L,0L,0L,1L,3L,2L,2L,3L,1L,0L,0L,1L,3L,2L,2L,3L,1L,0L,0L,1L,3L,2L,2L,3L,1L,0L,0L,1L,3L,2L,2L,3L,1L,0L,0L,1L,3L,2L,2L,3L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105198Inst : IEnumerable<long>
{
public static readonly long[] Value=A105198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105198.Bytes);
public long this[int i]=>Value[i];

public static A105198Inst Instance=new A105198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105199
{
public static readonly long[] Value={ 1L,1L,0L,7L,1L,4L,8L,7L,1L,7L,7L,9L,4L,0L,9L,0L,5L,0L,3L,0L,1L,7L,0L,6L,5L,4L,6L,0L,1L,7L,8L,5L,3L,7L,0L,4L,0L,0L,7L,0L,0L,4L,7L,6L,4L,5L,4L,0L,1L,4L,3L,2L,6L,4L,6L,6L,7L,6L,5L,3L,9L,2L,0L,7L,4L,3L,3L,7L,1L,0L,3L,3L,8L,9L,7L,7L,3L,6L,2L,7L,9L,4L,0L,1L,3L,4L,1L,7L,1L,2L,8L,6L,8L,6L,1L,7L,0L,6L,4L,1L,4L,3L,4L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105199Inst : IEnumerable<long>
{
public static readonly long[] Value=A105199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105199.Bytes);
public long this[int i]=>Value[i];

public static A105199Inst Instance=new A105199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105200
{
public static readonly long[] Value={ 1L,1L,4L,3L,13L,16L,41L,64L,154L,261L,560L,1049L,2176L,4169L,8474L,16614L,33477L,66178L,132776L,263969L,528519L,1053483L,2107772L,4207680L,8415341L,16812773L,33622527L,67203682L,134391649L,268686218L,537318189L,1074403625L,2148636672L,4296709932L,8592918851L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105200Inst : IEnumerable<long>
{
public static readonly long[] Value=A105200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105200.Bytes);
public long this[int i]=>Value[i];

public static A105200Inst Instance=new A105200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105201
{
public static readonly long[] Value={ 0L,1L,0L,5L,3L,16L,23L,64L,102L,251L,464L,999L,1920L,4023L,7910L,16154L,32059L,64894L,129368L,260319L,520057L,1043669L,2086532L,4180928L,8361875L,16741659L,33486337L,67014046L,134043807L,268184694L,536423635L,1073080023L,2146330624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105201Inst : IEnumerable<long>
{
public static readonly long[] Value=A105201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105201.Bytes);
public long this[int i]=>Value[i];

public static A105201Inst Instance=new A105201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105202
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,2L,1L,2L,3L,2L,1L,2L,1L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,3L,2L,3L,1L,3L,2L,3L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,3L,2L,3L,1L,3L,2L,3L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,3L,2L,3L,1L,3L,2L,3L,2L,3L,1L,3L,1L,2L,1L,3L,1L,3L,2L,3L,2L,3L,1L,3L,2L,3L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105202Inst : IEnumerable<long>
{
public static readonly long[] Value=A105202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105202.Bytes);
public long this[int i]=>Value[i];

public static A105202Inst Instance=new A105202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105203
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,3L,2L,3L,1L,3L,2L,3L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,3L,2L,3L,1L,3L,2L,3L,2L,3L,1L,3L,1L,2L,1L,3L,1L,3L,2L,3L,2L,3L,1L,3L,2L,3L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,3L,2L,3L,1L,3L,2L,3L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,3L,2L,3L,1L,3L,2L,3L,2L,3L,1L,3L,1L,2L,1L,3L,1L,3L,2L,3L,2L,3L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105203Inst : IEnumerable<long>
{
public static readonly long[] Value=A105203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105203.Bytes);
public long this[int i]=>Value[i];

public static A105203Inst Instance=new A105203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105204
{
public static readonly long[] Value={ 0L,1L,0L,2L,3L,8L,13L,27L,51L,105L,210L,424L,848L,1702L,3405L,6818L,13638L,27274L,54525L,109000L,217886L,435562L,870738L,1740829L,3480614L,6959663L,13917156L,27831708L,55661156L,111322666L,222653729L,445335854L,890744837L,1781656704L,3563668755L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105204Inst : IEnumerable<long>
{
public static readonly long[] Value=A105204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105204.Bytes);
public long this[int i]=>Value[i];

public static A105204Inst Instance=new A105204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105205
{
public static readonly long[] Value={ 1L,1L,4L,6L,13L,24L,51L,101L,205L,407L,814L,1624L,3248L,6490L,12979L,25950L,51898L,103798L,207619L,415288L,830690L,1661590L,3323566L,6647779L,13296602L,26594769L,53191708L,106386020L,212774300L,425548246L,851088094L,1702147791L,3404222451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105205Inst : IEnumerable<long>
{
public static readonly long[] Value=A105205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105205.Bytes);
public long this[int i]=>Value[i];

public static A105205Inst Instance=new A105205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105206
{
public static readonly long[] Value={ 3L,5L,6L,8L,9L,10L,12L,13L,14L,15L,16L,17L,19L,20L,21L,22L,23L,24L,25L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105206Inst : IEnumerable<long>
{
public static readonly long[] Value=A105206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105206.Bytes);
public long this[int i]=>Value[i];

public static A105206Inst Instance=new A105206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105207
{
public static readonly long[] Value={ 1L,2L,4L,8L,12L,32L,36L,40L,48L,160L,396L,2268L,2560L,3696L,9000L,15936L,17640L,22848L,29160L,38640L,81216L,91872L,153120L,225280L,228960L,410112L,494592L,540672L,619920L,900000L,1111968L,1282176L,1350720L,1932000L,2153088L,4093440L,5634720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105207Inst : IEnumerable<long>
{
public static readonly long[] Value=A105207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105207.Bytes);
public long this[int i]=>Value[i];

public static A105207Inst Instance=new A105207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105208
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,9L,11L,12L,13L,14L,26L,30L,33L,41L,52L,67L,69L,78L,80L,105L,122L,123L,139L,145L,201L,208L,216L,242L,312L,313L,337L,348L,354L,414L,528L,569L,599L,779L,783L,878L,925L,992L,1024L,1103L,1106L,1270L,1283L,1306L,1315L,1508L,1839L,2223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105208Inst : IEnumerable<long>
{
public static readonly long[] Value=A105208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105208.Bytes);
public long this[int i]=>Value[i];

public static A105208Inst Instance=new A105208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105209
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105209Inst : IEnumerable<long>
{
public static readonly long[] Value=A105209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105209.Bytes);
public long this[int i]=>Value[i];

public static A105209Inst Instance=new A105209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105210
{
public static readonly long[] Value={ 393L,528L,545L,660L,682L,727L,728L,751L,752L,802L,1206L,1279L,1280L,1288L,1321L,1322L,1986L,2323L,2448L,2471L,2832L,2897L,2898L,2934L,3103L,3240L,3251L,3252L,3529L,3530L,3891L,5192L,5265L,5287L,5616L,5635L,5671L,5832L,5838L,5990L,6597L,7334L,7549L,7550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105210Inst : IEnumerable<long>
{
public static readonly long[] Value=A105210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105210.Bytes);
public long this[int i]=>Value[i];

public static A105210Inst Instance=new A105210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105211
{
public static readonly long[] Value={ 412L,518L,565L,684L,709L,710L,789L,1056L,1073L,1140L,1170L,1194L,1399L,1400L,1415L,1704L,1781L,1932L,1968L,2015L,2065L,2137L,2138L,3210L,3328L,3344L,3377L,3696L,3720L,3762L,3798L,4015L,4105L,4932L,5075L,5117L,5185L,5269L,5760L,5771L,6000L,6011L,6012L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105211Inst : IEnumerable<long>
{
public static readonly long[] Value=A105211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105211.Bytes);
public long this[int i]=>Value[i];

public static A105211Inst Instance=new A105211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105212
{
public static readonly long[] Value={ 668L,838L,1260L,1278L,1355L,1632L,1655L,1992L,2081L,2082L,2435L,2928L,2995L,3600L,3611L,3792L,3877L,3878L,4165L,4195L,5040L,5058L,5345L,6420L,6538L,7015L,7105L,7147L,8176L,8259L,11016L,11039L,11149L,11150L,11381L,12000L,12011L,12012L,12049L,12050L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105212Inst : IEnumerable<long>
{
public static readonly long[] Value=A105212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105212.Bytes);
public long this[int i]=>Value[i];

public static A105212Inst Instance=new A105212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105213
{
public static readonly long[] Value={ 932L,1168L,1244L,1558L,1621L,1622L,2436L,2478L,2550L,2578L,3870L,3924L,4039L,4624L,4644L,4693L,4726L,4885L,5868L,6037L,6038L,9060L,9222L,9310L,9344L,9420L,9588L,9658L,10111L,10112L,10194L,11899L,12136L,12217L,12880L,12918L,15077L,15078L,15450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105213Inst : IEnumerable<long>
{
public static readonly long[] Value=A105213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105213.Bytes);
public long this[int i]=>Value[i];

public static A105213Inst Instance=new A105213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105214
{
public static readonly long[] Value={ 1L,2L,3L,6L,4L,46L,5L,10L,7L,22L,8L,50L,9L,14L,11L,18L,12L,54L,13L,26L,21L,30L,15L,58L,16L,34L,17L,42L,19L,62L,20L,38L,25L,70L,31L,66L,23L,74L,29L,78L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105214Inst : IEnumerable<long>
{
public static readonly long[] Value=A105214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105214.Bytes);
public long this[int i]=>Value[i];

public static A105214Inst Instance=new A105214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105215
{
public static readonly long[] Value={ 1L,3L,9L,37L,183L,1089L,7507L,59261L,525432L,5185027L,56276118L,667218665L,8572665529L,118743064065L,1763010417987L,27944432899993L,470820846422697L,8404897200626691L,158440099278231667L,3145660094900520781L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105215Inst : IEnumerable<long>
{
public static readonly long[] Value=A105215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105215.Bytes);
public long this[int i]=>Value[i];

public static A105215Inst Instance=new A105215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105216
{
public static readonly BigInteger[] Value={ 1L,2L,7L,31L,164L,1021L,7340L,59899L,547423L,5541311L,61560751L,744810564L,9749580487L,137299957892L,2069988277027L,33266800950301L,567742165061876L,10254686071781119L,195439907769223706L,3919618523321600065L,BigInteger.Parse("82517650453354285621"),BigInteger.Parse("1819502802723019762607") };
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
public class A105216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105216Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105216.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105216Inst Instance=new A105216Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105217
{
public static readonly BigInteger[] Value={ 2L,3L,11L,61L,431L,3626L,35124L,383783L,4662223L,62276683L,906637753L,14280356652L,241859495794L,4381438966659L,84512370607339L,1728802226304029L,37374059917912351L,851227845700838002L,BigInteger.Parse("20368894028832161532") };
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
public class A105217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105217Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105217.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105217Inst Instance=new A105217Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105218
{
public static readonly BigInteger[] Value={ 0L,1L,12L,117L,1168L,12525L,145836L,1844017L,25238592L,372320793L,5894109100L,99712850061L,1795703361552L,34303011804997L,692863434782988L,14754105717057225L,330351159979499776L,7758672154410196017L,BigInteger.Parse("190717243734190845132"),BigInteger.Parse("4896738903385469500453") };
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
public class A105218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105218Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105218.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105218Inst Instance=new A105218Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105219
{
public static readonly long[] Value={ 0L,1L,8L,63L,544L,5225L,55656L,653023L,8379008L,116780049L,1757211400L,28394129951L,490371506208L,9013522796473L,175679564492264L,3618800515187775L,78547755741723136L,1791704327280481313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105219Inst : IEnumerable<long>
{
public static readonly long[] Value=A105219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105219.Bytes);
public long this[int i]=>Value[i];

public static A105219Inst Instance=new A105219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105220
{
public static readonly long[] Value={ 1L,2L,1L,2L,2L,2L,1L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,1L,2L,2L,2L,1L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,1L,2L,2L,2L,1L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,1L,2L,2L,2L,1L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105220Inst : IEnumerable<long>
{
public static readonly long[] Value=A105220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105220.Bytes);
public long this[int i]=>Value[i];

public static A105220Inst Instance=new A105220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105221
{
public static readonly long[] Value={ 0L,0L,0L,2L,0L,5L,0L,2L,3L,7L,0L,5L,0L,9L,8L,2L,0L,5L,0L,7L,10L,13L,0L,5L,5L,15L,3L,9L,0L,10L,0L,2L,14L,19L,12L,5L,0L,21L,16L,7L,0L,12L,0L,13L,8L,25L,0L,5L,7L,7L,20L,15L,0L,5L,16L,9L,22L,31L,0L,10L,0L,33L,10L,2L,18L,16L,0L,19L,26L,14L,0L,5L,0L,39L,8L,21L,18L,18L,0L,7L,3L,43L,0L,12L,22L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105221Inst : IEnumerable<long>
{
public static readonly long[] Value=A105221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105221.Bytes);
public long this[int i]=>Value[i];

public static A105221Inst Instance=new A105221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105222
{
public static readonly long[] Value={ 2L,3L,2L,5L,2L,7L,2L,9L,8L,11L,2L,13L,2L,15L,4L,17L,2L,19L,2L,21L,8L,23L,2L,25L,7L,27L,26L,9L,2L,31L,2L,33L,10L,35L,6L,37L,2L,39L,14L,41L,2L,43L,2L,45L,8L,47L,2L,49L,18L,51L,16L,9L,2L,55L,21L,57L,20L,59L,2L,61L,2L,63L,8L,65L,8L,25L,2L,69L,22L,11L,2L,73L,2L,75L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105222Inst : IEnumerable<long>
{
public static readonly long[] Value=A105222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105222.Bytes);
public long this[int i]=>Value[i];

public static A105222Inst Instance=new A105222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105223
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,4L,3L,3L,4L,4L,3L,4L,4L,4L,4L,4L,4L,5L,4L,5L,5L,5L,5L,5L,5L,6L,6L,5L,5L,6L,6L,6L,5L,5L,6L,7L,6L,6L,6L,6L,6L,7L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,9L,8L,8L,8L,9L,9L,9L,9L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,10L,10L,9L,10L,10L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105223Inst : IEnumerable<long>
{
public static readonly long[] Value=A105223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105223.Bytes);
public long this[int i]=>Value[i];

public static A105223Inst Instance=new A105223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105224
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,4L,4L,4L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105224Inst : IEnumerable<long>
{
public static readonly long[] Value=A105224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105224.Bytes);
public long this[int i]=>Value[i];

public static A105224Inst Instance=new A105224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105225
{
public static readonly long[] Value={ 1L,-1L,-2L,1L,6L,5L,-6L,-15L,-2L,29L,34L,-23L,-90L,-43L,138L,225L,-50L,-499L,-398L,601L,1398L,197L,-2598L,-2991L,2206L,8189L,3778L,-12599L,-20154L,5045L,45354L,35265L,-55442L,-125971L,-15086L,236857L,267030L,-206683L,-740742L,-327375L,1154110L,1808861L,-499358L,-4117079L,-3118362L,5115797L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105225Inst : IEnumerable<long>
{
public static readonly long[] Value=A105225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105225.Bytes);
public long this[int i]=>Value[i];

public static A105225Inst Instance=new A105225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105226
{
public static readonly BigInteger[] Value={ 2L,3L,11L,13L,157L,8209L,31231L,1608697L,112328569L,10247900863L,21926946241L,1256492087941L,101017938127207L,10019534732186179L,BigInteger.Parse("103820246231814111793"),BigInteger.Parse("6892441533761699205127"),BigInteger.Parse("125403143123000002762783"),BigInteger.Parse("1008021783580817338005763") };
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
public class A105226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105226Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105226.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105226Inst Instance=new A105226Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105227
{
public static readonly long[] Value={ 1L,1L,3L,12L,60L,355L,2380L,17430L,134190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105227Inst : IEnumerable<long>
{
public static readonly long[] Value=A105227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105227.Bytes);
public long this[int i]=>Value[i];

public static A105227Inst Instance=new A105227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105228
{
public static readonly long[] Value={ 1L,4L,7L,6L,5L,16L,11L,10L,9L,12L,15L,14L,29L,24L,19L,18L,17L,20L,23L,22L,21L,32L,27L,26L,25L,28L,31L,62L,45L,40L,35L,34L,33L,36L,39L,38L,37L,48L,43L,42L,41L,44L,47L,46L,61L,56L,51L,50L,49L,52L,55L,54L,53L,64L,59L,58L,57L,60L,127L,94L,77L,72L,67L,66L,65L,68L,71L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105228Inst : IEnumerable<long>
{
public static readonly long[] Value=A105228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105228.Bytes);
public long this[int i]=>Value[i];

public static A105228Inst Instance=new A105228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105229
{
public static readonly long[] Value={ 0L,3L,4L,9L,26L,59L,112L,245L,502L,1015L,2036L,4081L,8178L,16355L,32744L,65517L,131054L,262127L,524268L,1048553L,2097130L,4194283L,8388576L,16777189L,33554406L,67108839L,134217700L,268435425L,536870850L,1073741779L,2147483608L,4294967261L,8589934558L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105229Inst : IEnumerable<long>
{
public static readonly long[] Value=A105229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105229.Bytes);
public long this[int i]=>Value[i];

public static A105229Inst Instance=new A105229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105230
{
public static readonly long[] Value={ 1L,5L,151L,60879L,4292660729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105230Inst : IEnumerable<long>
{
public static readonly long[] Value=A105230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105230.Bytes);
public long this[int i]=>Value[i];

public static A105230Inst Instance=new A105230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105231
{
public static readonly long[] Value={ 1L,2L,12L,347L,1226525L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105231Inst : IEnumerable<long>
{
public static readonly long[] Value=A105231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105231.Bytes);
public long this[int i]=>Value[i];

public static A105231Inst Instance=new A105231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105232
{
public static readonly long[] Value={ 1L,2L,8L,172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105232Inst : IEnumerable<long>
{
public static readonly long[] Value=A105232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105232.Bytes);
public long this[int i]=>Value[i];

public static A105232Inst Instance=new A105232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105233
{
public static readonly long[] Value={ 1L,393L,412L,668L,932L,1096L,1425L,1676L,1706L,1959L,2258L,2476L,2590L,3819L,4162L,4359L,4363L,4569L,4707L,5314L,5462L,5503L,5547L,5949L,6002L,6110L,6207L,6393L,6429L,6484L,6500L,7226L,7706L,8151L,8654L,9566L,9586L,9759L,10085L,10141L,10455L,10774L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105233Inst : IEnumerable<long>
{
public static readonly long[] Value=A105233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105233.Bytes);
public long this[int i]=>Value[i];

public static A105233Inst Instance=new A105233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105234
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105234Inst : IEnumerable<long>
{
public static readonly long[] Value=A105234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105234.Bytes);
public long this[int i]=>Value[i];

public static A105234Inst Instance=new A105234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105235
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,5L,5L,6L,7L,8L,8L,9L,10L,11L,11L,12L,13L,14L,15L,16L,17L,18L,18L,19L,20L,21L,21L,22L,23L,24L,24L,25L,26L,27L,27L,28L,29L,30L,30L,31L,32L,33L,33L,34L,35L,36L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,47L,48L,49L,50L,50L,51L,52L,53L,53L,54L,55L,56L,56L,57L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105235Inst : IEnumerable<long>
{
public static readonly long[] Value=A105235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105235.Bytes);
public long this[int i]=>Value[i];

public static A105235Inst Instance=new A105235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105236
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,3L,5L,11L,41L,233L,689L,5337L,49081L,458299L,3603685L,93208147L,1476087601L,27470407569L,816413467841L,43620306030449L,1172020019840081L,70063780891581107L,5804382690927311525L,BigInteger.Parse("511286588817798535899") };
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
public class A105236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105236Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105236.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105236Inst Instance=new A105236Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105237
{
public static readonly long[] Value={ 2L,22L,108L,126L,180L,256L,336L,490L,630L,652L,660L,682L,708L,760L,828L,862L,882L,1030L,1038L,1128L,1162L,1216L,1318L,1450L,1612L,1930L,1950L,2010L,2236L,2268L,2380L,2436L,2658L,2752L,2800L,2962L,2998L,3036L,3048L,3318L,3672L,3922L,4152L,4396L,4506L,4816L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105237Inst : IEnumerable<long>
{
public static readonly long[] Value=A105237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105237.Bytes);
public long this[int i]=>Value[i];

public static A105237Inst Instance=new A105237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105238
{
public static readonly long[] Value={ 23252729L,77798183L,115117119121L,197199201203L,211213215217L,221223225227L,227229231233L,265267269271L,281283285287L,311313315317L,317319321323L,343345347349L,373375377379L,397399401403L,403405407409L,433435437439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105238Inst : IEnumerable<long>
{
public static readonly long[] Value=A105238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105238.Bytes);
public long this[int i]=>Value[i];

public static A105238Inst Instance=new A105238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105239
{
public static readonly long[] Value={ 1L,2L,1L,4L,3L,4L,1L,2L,1L,3L,4L,3L,2L,1L,2L,3L,4L,3L,1L,2L,1L,4L,3L,4L,1L,2L,1L,2L,1L,2L,3L,4L,3L,2L,1L,2L,4L,3L,4L,1L,2L,1L,4L,3L,4L,2L,1L,2L,3L,4L,3L,2L,1L,2L,1L,2L,1L,4L,3L,4L,1L,2L,1L,3L,4L,3L,2L,1L,2L,3L,4L,3L,1L,2L,1L,4L,3L,4L,1L,2L,1L,4L,3L,4L,1L,2L,1L,4L,3L,4L,2L,1L,2L,3L,4L,3L,2L,1L,2L,4L,3L,4L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105239Inst : IEnumerable<long>
{
public static readonly long[] Value=A105239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105239.Bytes);
public long this[int i]=>Value[i];

public static A105239Inst Instance=new A105239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105240
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,2L,2L,2L,4L,1L,1L,1L,2L,2L,2L,2L,4L,1L,1L,1L,2L,2L,2L,2L,4L,2L,2L,2L,4L,4L,4L,4L,8L,1L,1L,1L,2L,2L,2L,2L,4L,2L,2L,2L,4L,4L,4L,4L,8L,1L,1L,1L,2L,2L,2L,2L,4L,2L,2L,2L,4L,4L,4L,4L,8L,2L,2L,2L,4L,4L,4L,4L,8L,4L,4L,4L,8L,8L,8L,8L,16L,1L,1L,1L,2L,2L,2L,2L,4L,2L,2L,2L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105240Inst : IEnumerable<long>
{
public static readonly long[] Value=A105240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105240.Bytes);
public long this[int i]=>Value[i];

public static A105240Inst Instance=new A105240Inst();

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