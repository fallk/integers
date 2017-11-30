using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A278162
{
public static readonly long[] Value={ 1L,2L,2L,6L,2L,6L,2L,12L,6L,6L,2L,6L,6L,30L,2L,6L,2L,30L,12L,6L,2L,30L,6L,30L,2L,6L,2L,30L,6L,6L,6L,30L,12L,30L,6L,6L,2L,30L,12L,6L,2L,12L,6L,60L,6L,6L,6L,210L,6L,6L,6L,6L,6L,30L,2L,30L,2L,120L,6L,6L,6L,6L,6L,30L,6L,6L,2L,30L,24L,6L,12L,6L,30L,210L,2L,30L,6L,30L,6L,6L,6L,30L,12L,210L,2L,6L,6L,30L,6L,30L,2L,30L,6L,60L,2L,6L,6L,30L,30L,60L,6L,6L,6L,30L,6L,30L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278162Inst : IEnumerable<long>
{
public static readonly long[] Value=A278162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278162.Bytes);
public long this[int i]=>Value[i];

public static A278162Inst Instance=new A278162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278163
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278163Inst : IEnumerable<long>
{
public static readonly long[] Value=A278163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278163.Bytes);
public long this[int i]=>Value[i];

public static A278163Inst Instance=new A278163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278164
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,2L,3L,0L,1L,2L,3L,4L,5L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278164Inst : IEnumerable<long>
{
public static readonly long[] Value=A278164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278164.Bytes);
public long this[int i]=>Value[i];

public static A278164Inst Instance=new A278164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278165
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,6L,2L,6L,12L,6L,2L,210L,2L,6L,30L,30L,2L,420L,2L,420L,30L,30L,2L,30030L,30L,6L,120L,2310L,6L,30030L,2L,210L,210L,6L,210L,19399380L,6L,6L,30L,60060L,6L,60060L,2L,30030L,4620L,30L,6L,223092870L,6L,30030L,2310L,30030L,6L,120120L,420L,510510L,210L,2310L,30L,401120980260L,2L,6L,4620L,30030L,2310L,9699690L,6L,30030L,210L,9699690L,6L,14841476269620L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278165Inst : IEnumerable<long>
{
public static readonly long[] Value=A278165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278165.Bytes);
public long this[int i]=>Value[i];

public static A278165Inst Instance=new A278165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278166
{
public static readonly long[] Value={ 1L,3L,3L,5L,7L,9L,9L,11L,12L,14L,15L,18L,19L,22L,23L,26L,29L,31L,34L,37L,42L,46L,47L,51L,54L,58L,60L,64L,68L,70L,74L,78L,82L,85L,88L,92L,95L,99L,104L,109L,114L,118L,122L,128L,134L,137L,140L,149L,153L,158L,164L,173L,177L,183L,187L,191L,199L,205L,210L,217L,222L,231L,236L,241L,248L,256L,262L,273L,278L,287L,291L,298L,307L,316L,322L,332L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278166Inst : IEnumerable<long>
{
public static readonly long[] Value=A278166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278166.Bytes);
public long this[int i]=>Value[i];

public static A278166Inst Instance=new A278166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278167
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,3L,5L,6L,7L,7L,9L,10L,12L,12L,15L,17L,17L,20L,20L,22L,22L,23L,27L,29L,32L,34L,38L,40L,40L,43L,46L,48L,53L,56L,60L,63L,66L,69L,71L,75L,77L,79L,83L,86L,89L,92L,98L,101L,102L,105L,109L,111L,117L,120L,123L,125L,130L,135L,140L,145L,149L,152L,159L,163L,167L,173L,177L,179L,183L,189L,194L,199L,204L,208L,215L,219L,223L,230L,234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278167Inst : IEnumerable<long>
{
public static readonly long[] Value=A278167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278167.Bytes);
public long this[int i]=>Value[i];

public static A278167Inst Instance=new A278167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278168
{
public static readonly long[] Value={ 0L,1L,1L,3L,4L,5L,5L,8L,10L,13L,15L,16L,17L,19L,20L,23L,25L,28L,29L,31L,35L,39L,40L,42L,45L,47L,49L,52L,56L,59L,62L,66L,69L,73L,76L,78L,82L,87L,92L,96L,100L,103L,107L,112L,116L,120L,123L,127L,133L,137L,143L,151L,155L,159L,162L,167L,174L,177L,184L,186L,192L,198L,202L,209L,216L,220L,225L,232L,236L,244L,250L,254L,258L,261L,267L,278L,282L,287L,292L,301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278168Inst : IEnumerable<long>
{
public static readonly long[] Value=A278168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278168.Bytes);
public long this[int i]=>Value[i];

public static A278168Inst Instance=new A278168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278169
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278169Inst : IEnumerable<long>
{
public static readonly long[] Value=A278169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278169.Bytes);
public long this[int i]=>Value[i];

public static A278169Inst Instance=new A278169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278170
{
public static readonly BigInteger[] Value={ 0L,2L,18L,1476L,396024L,408355632L,1580935773900L,23184238421031934L,BigInteger.Parse("1286347795694708130944"),BigInteger.Parse("270105371559062140434880346"),BigInteger.Parse("214634588261090465589376419637454") };
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
public class A278170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278170Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278170.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278170Inst Instance=new A278170Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278171
{
public static readonly long[] Value={ 0L,2L,5L,13L,43L,137L,436L,1394L,4458L,14258L,45607L,145888L,466673L,1492823L,4775347L,15275728L,48865129L,156313412L,500027005L,1599523726L,5116675993L,16367605483L,52357919474L,167486425305L,535768092953L,1713855012003L,5482407483581L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278171Inst : IEnumerable<long>
{
public static readonly long[] Value=A278171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278171.Bytes);
public long this[int i]=>Value[i];

public static A278171Inst Instance=new A278171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278172
{
public static readonly long[] Value={ 0L,5L,18L,126L,737L,4551L,27692L,169131L,1032173L,6300804L,38460963L,234775180L,1433121527L,8748112011L,53400529535L,325969389167L,1989793771357L,12146168927085L,74143070289741L,452586729708259L,2762695786609647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278172Inst : IEnumerable<long>
{
public static readonly long[] Value=A278172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278172.Bytes);
public long this[int i]=>Value[i];

public static A278172Inst Instance=new A278172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278173
{
public static readonly long[] Value={ 0L,13L,126L,1476L,17396L,205363L,2419304L,28515138L,336046126L,3960336818L,46672710626L,550039863065L,6482242131027L,76393487374019L,900300354854882L,10610076292064874L,125040180523981545L,1473603611859143248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278173Inst : IEnumerable<long>
{
public static readonly long[] Value=A278173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278173.Bytes);
public long this[int i]=>Value[i];

public static A278173Inst Instance=new A278173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278174
{
public static readonly BigInteger[] Value={ 0L,43L,737L,17396L,396024L,9120939L,209105063L,4797179760L,110034231906L,2523955236624L,57893739618179L,1327951316712237L,30460184207856087L,698687420488831794L,16026301711146587408UL,BigInteger.Parse("367606943763824641516") };
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
public class A278174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278174Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278174.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278174Inst Instance=new A278174Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278175
{
public static readonly BigInteger[] Value={ 0L,137L,4551L,205363L,9120939L,408355632L,18218081491L,813097394374L,36285966496008L,1619341940295084L,72266408849439553L,3225035964623559710L,BigInteger.Parse("143923783835527234449"),BigInteger.Parse("6422891413398861709329"),BigInteger.Parse("286634583241796971035956") };
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
public class A278175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278175Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278175.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278175Inst Instance=new A278175Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278176
{
public static readonly BigInteger[] Value={ 0L,436L,27692L,2419304L,209105063L,18218081491L,1580935773900L,137264328312479L,11916307472109969L,1034507705866421424L,BigInteger.Parse("89809589733457630488"),BigInteger.Parse("7796723202173710849973"),BigInteger.Parse("676863948079571480111201") };
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
public class A278176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278176Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278176.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278176Inst Instance=new A278176Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278177
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,0L,0L,5L,5L,0L,0L,13L,18L,13L,0L,0L,43L,126L,126L,43L,0L,0L,137L,737L,1476L,737L,137L,0L,0L,436L,4551L,17396L,17396L,4551L,436L,0L,0L,1394L,27692L,205363L,396024L,205363L,27692L,1394L,0L,0L,4458L,169131L,2419304L,9120939L,9120939L,2419304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278177Inst : IEnumerable<long>
{
public static readonly long[] Value=A278177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278177.Bytes);
public long this[int i]=>Value[i];

public static A278177Inst Instance=new A278177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278178
{
public static readonly BigInteger[] Value={ 7L,1225L,1816871L,7723802625L,8591613499103635L,BigInteger.Parse("23107999588635836875"),BigInteger.Parse("446563431744711553183786875"),BigInteger.Parse("17418085137491657842253233328125"),BigInteger.Parse("1311214792748795041469921338623972253125"),BigInteger.Parse("169160593483166517029276275055903719700625000"),BigInteger.Parse("9261817633933021190882924368962406588490587588265625") };
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
public class A278178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278178Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278178.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278178Inst Instance=new A278178Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278179
{
public static readonly long[] Value={ 240L,144L,48L,8L,96L,1L,32L,1L,32L,1L,8L,1L,16L,1L,64L,1L,32L,1L,32L,1L,64L,1L,16L,1L,16L,1L,8L,1L,16L,1L,128L,1L,32L,1L,32L,1L,64L,1L,64L,1L,64L,1L,4L,1L,8L,1L,32L,1L,16L,1L,16L,1L,32L,1L,16L,1L,16L,1L,8L,1L,16L,1L,256L,1L,32L,1L,32L,1L,64L,1L,64L,1L,64L,1L,16L,1L,32L,1L,128L,1L,64L,1L,64L,1L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278179Inst : IEnumerable<long>
{
public static readonly long[] Value=A278179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278179.Bytes);
public long this[int i]=>Value[i];

public static A278179Inst Instance=new A278179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278180
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,7L,8L,15L,16L,17L,33L,35L,37L,72L,76L,80L,84L,164L,172L,180L,188L,368L,384L,401L,418L,435L,853L,888L,925L,962L,999L,1961L,2037L,2117L,2201L,2285L,2369L,4654L,4826L,5006L,5194L,5382L,5570L,10952L,11336L,11737L,12155L,12590L,13025L,13460L,26485L,27373L,28298L,29260L,30259L,31258L,32257L,63515L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278180Inst : IEnumerable<long>
{
public static readonly long[] Value=A278180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278180.Bytes);
public long this[int i]=>Value[i];

public static A278180Inst Instance=new A278180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278181
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,7L,8L,9L,12L,14L,19L,22L,29L,33L,42L,47L,59L,74L,82L,99L,108L,129L,155L,169L,202L,243L,265L,316L,378L,411L,486L,575L,622L,728L,861L,1017L,1099L,1280L,1487L,1595L,1832L,2116L,2440L,2609L,2980L,3425L,3933L,4198L,4779L,5473L,6262L,6673L,7570L,8631L,9828L,10450L,11800L,13389L,15267L,17383L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278181Inst : IEnumerable<long>
{
public static readonly long[] Value=A278181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278181.Bytes);
public long this[int i]=>Value[i];

public static A278181Inst Instance=new A278181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278182
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,0L,1L,2L,3L,4L,0L,1L,2L,3L,4L,0L,1L,2L,3L,4L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,2L,3L,4L,5L,6L,2L,3L,4L,5L,6L,2L,3L,4L,5L,6L,2L,3L,4L,5L,6L,3L,4L,5L,6L,7L,3L,4L,5L,6L,7L,3L,4L,5L,6L,7L,3L,4L,5L,6L,7L,4L,5L,6L,7L,8L,4L,5L,6L,7L,8L,4L,5L,6L,7L,8L,4L,5L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278182Inst : IEnumerable<long>
{
public static readonly long[] Value=A278182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278182.Bytes);
public long this[int i]=>Value[i];

public static A278182Inst Instance=new A278182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278183
{
public static readonly long[] Value={ 0L,3L,28L,200L,1532L,11794L,90538L,695252L,5339294L,41003018L,314882364L,2418138526L,18570087298L,142608927356L,1095164819630L,8410314860218L,64586987065356L,495995568270926L,3808996439085090L,29251176423848812L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278183Inst : IEnumerable<long>
{
public static readonly long[] Value=A278183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278183.Bytes);
public long this[int i]=>Value[i];

public static A278183Inst Instance=new A278183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278184
{
public static readonly BigInteger[] Value={ 0L,19L,544L,13720L,347116L,8803344L,223230876L,5660949042L,143557203008L,3640498372990L,92320193797850L,2341167983288042L,59370190792031534L,1505581649925192516L,BigInteger.Parse("38180374263992817136"),BigInteger.Parse("968224459304580152320") };
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
public class A278184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278184Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278184.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278184Inst Instance=new A278184Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278185
{
public static readonly BigInteger[] Value={ 0L,136L,13012L,1075258L,91270219L,7737459027L,656008970388L,55620335387114L,4715820197535009L,399835065589298715L,BigInteger.Parse("33900377809514573711"),BigInteger.Parse("2874274212652455298123"),BigInteger.Parse("243697940183994435905588") };
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
public class A278185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278185Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278185.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278185Inst Instance=new A278185Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278186
{
public static readonly BigInteger[] Value={ 0L,935L,295190L,81691958L,23124026160L,6545874548694L,1852662745588838L,524386828923495662L,BigInteger.Parse("148424784547109672280"),BigInteger.Parse("42010806495461042971956"),BigInteger.Parse("11890925205860266718183950"),BigInteger.Parse("3365660260074301506275917454") };
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
public class A278186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278186Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278186.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278186Inst Instance=new A278186Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278187
{
public static readonly BigInteger[] Value={ 0L,6381L,6715738L,6196345742L,5858713218010L,5537142857552112L,5232919178331757631L,BigInteger.Parse("4945638025497366239942"),BigInteger.Parse("4674127103296221122266834"),BigInteger.Parse("4417520697715221210576165981") };
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
public class A278187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278187Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278187.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278187Inst Instance=new A278187Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278188
{
public static readonly long[] Value={ 0L,0L,0L,0L,3L,0L,0L,19L,28L,0L,0L,136L,544L,200L,0L,0L,935L,13012L,13720L,1532L,0L,0L,6381L,295190L,1075258L,347116L,11794L,0L,0L,43478L,6715738L,81691958L,91270219L,8803344L,90538L,0L,0L,296105L,152540636L,6196345742L,23124026160L,7737459027L,223230876L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278188Inst : IEnumerable<long>
{
public static readonly long[] Value=A278188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278188.Bytes);
public long this[int i]=>Value[i];

public static A278188Inst Instance=new A278188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278189
{
public static readonly long[] Value={ 0L,3L,19L,136L,935L,6381L,43478L,296105L,2016307L,13729364L,93484479L,636542307L,4334257038L,29512224731L,200950553535L,1368284654492L,9316734157423L,63438214373401L,431954692843542L,2941205998493005L,20026852048660187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278189Inst : IEnumerable<long>
{
public static readonly long[] Value=A278189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278189.Bytes);
public long this[int i]=>Value[i];

public static A278189Inst Instance=new A278189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278190
{
public static readonly BigInteger[] Value={ 0L,28L,544L,13012L,295190L,6715738L,152540636L,3464413662L,78677378754L,1786751336003L,40576751391716L,921488781267445L,20926797071937044L,475242697298621311L,10792651081336090474UL,BigInteger.Parse("245098594252284069018") };
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
public class A278190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278190Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278190.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278190Inst Instance=new A278190Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278191
{
public static readonly BigInteger[] Value={ 0L,200L,13720L,1075258L,81691958L,6196345742L,469577175712L,35577034730206L,2695338849906758L,204197662339944373L,15469874074262345128UL,BigInteger.Parse("1171986102689397728682"),BigInteger.Parse("88788773705648773915186") };
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
public class A278191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278191Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278191.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278191Inst Instance=new A278191Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278192
{
public static readonly BigInteger[] Value={ 0L,1532L,347116L,91270219L,23124026160L,5858713218010L,1482450100931615L,375049865320978231L,BigInteger.Parse("94879541460515598902"),BigInteger.Parse("24002203229663363493985"),BigInteger.Parse("6071950545418789283104046"),BigInteger.Parse("1536048854453696521513657702") };
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
public class A278192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278192Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278192.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278192Inst Instance=new A278192Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278193
{
public static readonly BigInteger[] Value={ 0L,11794L,8803344L,7737459027L,6545874548694L,5537142857552112L,4678308031001778581L,BigInteger.Parse("3951925612543275997042"),BigInteger.Parse("3338154929554215989823146"),BigInteger.Parse("2819671588394426773289855424"),BigInteger.Parse("2381712111047192598048356777986") };
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
public class A278193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278193Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278193.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278193Inst Instance=new A278193Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278194
{
public static readonly BigInteger[] Value={ 0L,0L,1L,-14L,336L,-1408L,256256L,14746368L,1766772736L,242121048064L,41267065061376L,8461792420167680L,2057680174397259776L,BigInteger.Parse("585429994601202057216"),BigInteger.Parse("192659868531986620481536") };
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
public class A278194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278194Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278194.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278194Inst Instance=new A278194Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278195
{
public static readonly BigInteger[] Value={ 0L,0L,0L,1L,-28L,882L,-17116L,803803L,13713336L,3671012164L,506128123928L,96524822605365L,21542790273363260L,5676618945053498806L,BigInteger.Parse("1739246268204447115932"),BigInteger.Parse("613255488134158250903887"),BigInteger.Parse("246554708506039690689322544"),BigInteger.Parse("112115693433705109495581088008") };
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
public class A278195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278195Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278195.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278195Inst Instance=new A278195Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278196
{
public static readonly long[] Value={ 2436L,5604L,451276L,715220L,831820L,1300156L,7089500L,12132164L,15796476L,26543660L,190569292L,483502844L,761002156L,851376628L,1327710076L,2841940500L,3519222692L,9035836076L,54770336324L,1280011042268L,1820701100652L,3972999029388L,6085253859260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278196Inst : IEnumerable<long>
{
public static readonly long[] Value=A278196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278196.Bytes);
public long this[int i]=>Value[i];

public static A278196Inst Instance=new A278196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278197
{
public static readonly long[] Value={ 56L,792L,8118264L,92669720L,150198136L,1188908248L,1844349560L,3163127352L,4351078600L,5371315400L,7346629512L,11097645016L,16670689208L,18440293320L,684957390936L,6622987708040L,51820051838712L,77195892663512L,133978259344888L,197726516681672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278197Inst : IEnumerable<long>
{
public static readonly long[] Value=A278197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278197.Bytes);
public long this[int i]=>Value[i];

public static A278197Inst Instance=new A278197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278198
{
public static readonly BigInteger[] Value={ 176L,384276336L,2291320912L,5964539504L,10015581680L,290726957916112L,6486674127079088L,60105349839666544L,134819180623301520L,2332821198543892336L,14023788883518847344UL,BigInteger.Parse("126891542690981418000"),BigInteger.Parse("320103136152993290544"),BigInteger.Parse("5852110108921301661040") };
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
public class A278198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278198Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278198.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278198Inst Instance=new A278198Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278199
{
public static readonly BigInteger[] Value={ 4087968L,625846753120L,576672674947168L,1896564103591584L,BigInteger.Parse("21424521360255636320"),BigInteger.Parse("61382395164161775318496"),BigInteger.Parse("25744258930034131533263392"),BigInteger.Parse("54951205445179608281719072"),BigInteger.Parse("1317709210896221493178043552"),BigInteger.Parse("172557592110602218633091543840"),BigInteger.Parse("6647848746214407376439536432805536") };
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
public class A278199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278199Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278199.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278199Inst Instance=new A278199Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278200
{
public static readonly BigInteger[] Value={ 2323520L,37027355200L,8030248384943040L,BigInteger.Parse("55733465144636286656"),BigInteger.Parse("134508188001572923840"),BigInteger.Parse("6179690078238084808000"),BigInteger.Parse("975509982873756796925504"),BigInteger.Parse("69523232218023552371152320"),BigInteger.Parse("638864582333908382360557376"),BigInteger.Parse("1151097146124113726578727360"),BigInteger.Parse("1204186073016375022219516992") };
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
public class A278200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278200Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278200.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278200Inst Instance=new A278200Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278201
{
public static readonly BigInteger[] Value={ 541946240L,47826239745920L,BigInteger.Parse("49760750604354432757376"),BigInteger.Parse("18426207875324210441995136"),BigInteger.Parse("914345304752746677204951178080640"),BigInteger.Parse("377394877138559089794329589034333523822720"),BigInteger.Parse("33381228189530831120385246576357623531476650368"),BigInteger.Parse("23951815370456759593096244705083096637451017834880") };
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
public class A278201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278201Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278201.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278201Inst Instance=new A278201Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278202
{
public static readonly BigInteger[] Value={ 0L,3L,97L,8242L,3295771L,5306819216L,33056811286568L,812312404546266967L,BigInteger.Parse("78877646007318566942149"),BigInteger.Parse("30229204386668969418436705255"),BigInteger.Parse("45720403850059908972915757270717926") };
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
public class A278202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278202Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278202.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278202Inst Instance=new A278202Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278203
{
public static readonly long[] Value={ 0L,15L,97L,666L,4827L,34869L,251260L,1811189L,13056663L,94122538L,678506791L,4891196693L,35259493158L,254177432493L,1832305613593L,13208662283862L,95218154664535L,686405389318065L,4948135785116200L,35669952667919773L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278203Inst : IEnumerable<long>
{
public static readonly long[] Value=A278203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278203.Bytes);
public long this[int i]=>Value[i];

public static A278203Inst Instance=new A278203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278204
{
public static readonly long[] Value={ 0L,46L,666L,8242L,117088L,1674402L,23732454L,336380248L,4770344900L,67648850802L,959306211222L,13603641359640L,192909619956550L,2735599405114814L,38792794983910750L,550110139019848618L,7800963216380203384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278204Inst : IEnumerable<long>
{
public static readonly long[] Value=A278204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278204.Bytes);
public long this[int i]=>Value[i];

public static A278204Inst Instance=new A278204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278205
{
public static readonly BigInteger[] Value={ 0L,161L,4827L,117088L,3295771L,93838003L,2644587148L,74502577363L,2100207846025L,59204820850114L,1668914682945041L,47044781998461473L,1326141579240041036L,BigInteger.Parse("37382494487271576091"),BigInteger.Parse("1053771855874680878859"),BigInteger.Parse("29704682675479642221344") };
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
public class A278205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278205Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278205.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278205Inst Instance=new A278205Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278206
{
public static readonly BigInteger[] Value={ 0L,601L,34869L,1674402L,93838003L,5306819216L,297169006604L,16636687338399L,931945034345185L,52205261260655693L,2924300169544392520L,BigInteger.Parse("163806092390120341088"),BigInteger.Parse("9175698877050626080778"),BigInteger.Parse("513982345733812946152984") };
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
public class A278206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278206Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278206.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278206Inst Instance=new A278206Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278207
{
public static readonly BigInteger[] Value={ 0L,2208L,251260L,23732454L,2644587148L,297169006604L,33056811286568L,3676498268449668L,409137247202506544L,BigInteger.Parse("45530553691308851854"),BigInteger.Parse("5066646847508250491070"),BigInteger.Parse("563817868393293695820130") };
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
public class A278207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278207Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278207.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278207Inst Instance=new A278207Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278208
{
public static readonly long[] Value={ 0L,0L,0L,0L,3L,0L,0L,15L,15L,0L,0L,46L,97L,46L,0L,0L,161L,666L,666L,161L,0L,0L,601L,4827L,8242L,4827L,601L,0L,0L,2208L,34869L,117088L,117088L,34869L,2208L,0L,0L,8053L,251260L,1674402L,3295771L,1674402L,251260L,8053L,0L,0L,29415L,1811189L,23732454L,93838003L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278208Inst : IEnumerable<long>
{
public static readonly long[] Value=A278208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278208.Bytes);
public long this[int i]=>Value[i];

public static A278208Inst Instance=new A278208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278209
{
public static readonly long[] Value={ 1L,2L,3L,11L,30L,9L,73L,26L,56L,32L,202L,55L,41L,86L,45L,55L,54L,58L,43L,70L,107L,224L,92L,98L,110L,173L,73L,115L,102L,73L,140L,128L,335L,97L,132L,129L,109L,128L,129L,113L,133L,207L,253L,301L,310L,239L,180L,244L,122L,152L,178L,245L,249L,351L,536L,262L,252L,314L,202L,310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278209Inst : IEnumerable<long>
{
public static readonly long[] Value=A278209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278209.Bytes);
public long this[int i]=>Value[i];

public static A278209Inst Instance=new A278209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278210
{
public static readonly long[] Value={ 0L,0L,0L,0L,4L,0L,6L,4L,8L,9L,10L,4L,6L,6L,4L,12L,0L,8L,10L,8L,6L,10L,18L,16L,21L,13L,16L,27L,24L,19L,27L,8L,10L,26L,29L,18L,25L,16L,0L,28L,27L,6L,32L,21L,19L,33L,13L,13L,13L,21L,0L,18L,23L,48L,28L,16L,26L,34L,26L,4L,33L,35L,4L,40L,52L,10L,65L,34L,62L,16L,40L,12L,66L,48L,21L,18L,6L,13L,72L,46L,19L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278210Inst : IEnumerable<long>
{
public static readonly long[] Value=A278210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278210.Bytes);
public long this[int i]=>Value[i];

public static A278210Inst Instance=new A278210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278211
{
public static readonly long[] Value={ 0L,4L,12L,28L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278211Inst : IEnumerable<long>
{
public static readonly long[] Value=A278211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278211.Bytes);
public long this[int i]=>Value[i];

public static A278211Inst Instance=new A278211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278212
{
public static readonly long[] Value={ 0L,2L,8L,20L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278212Inst : IEnumerable<long>
{
public static readonly long[] Value=A278212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278212.Bytes);
public long this[int i]=>Value[i];

public static A278212Inst Instance=new A278212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278213
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,1L,0L,0L,4L,6L,8L,8L,8L,8L,6L,4L,0L,0L,5L,10L,13L,16L,17L,18L,19L,20L,19L,18L,17L,16L,12L,8L,4L,0L,0L,8L,14L,20L,24L,28L,30L,32L,34L,35L,36L,38L,38L,38L,37L,36L,36L,32L,28L,24L,20L,16L,12L,8L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278213Inst : IEnumerable<long>
{
public static readonly long[] Value=A278213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278213.Bytes);
public long this[int i]=>Value[i];

public static A278213Inst Instance=new A278213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278214
{
public static readonly long[] Value={ 0L,0L,0L,3L,4L,3L,0L,0L,8L,12L,16L,17L,16L,14L,12L,8L,0L,0L,11L,20L,29L,36L,38L,40L,40L,40L,38L,36L,34L,32L,24L,16L,8L,0L,0L,16L,28L,40L,52L,64L,67L,70L,73L,74L,75L,76L,74L,72L,72L,72L,72L,64L,56L,48L,40L,32L,24L,16L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278214Inst : IEnumerable<long>
{
public static readonly long[] Value=A278214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278214.Bytes);
public long this[int i]=>Value[i];

public static A278214Inst Instance=new A278214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278215
{
public static readonly long[] Value={ 0L,0L,0L,2L,4L,2L,0L,0L,4L,8L,12L,12L,12L,9L,6L,4L,0L,0L,6L,12L,18L,24L,26L,28L,26L,24L,22L,20L,18L,16L,12L,8L,4L,0L,0L,8L,16L,24L,32L,40L,44L,48L,48L,48L,46L,44L,44L,42L,40L,38L,36L,32L,28L,24L,20L,16L,12L,8L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278215Inst : IEnumerable<long>
{
public static readonly long[] Value=A278215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278215.Bytes);
public long this[int i]=>Value[i];

public static A278215Inst Instance=new A278215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278216
{
public static readonly long[] Value={ 4L,0L,0L,4L,0L,0L,1L,0L,3L,1L,0L,3L,0L,0L,0L,2L,2L,0L,2L,2L,0L,1L,0L,0L,4L,0L,0L,3L,0L,0L,2L,0L,2L,0L,0L,4L,0L,0L,1L,2L,1L,1L,0L,3L,0L,1L,0L,0L,3L,0L,1L,3L,0L,1L,1L,0L,3L,0L,0L,3L,0L,0L,0L,3L,1L,0L,2L,2L,0L,0L,1L,1L,2L,1L,1L,2L,0L,0L,1L,0L,3L,1L,0L,3L,0L,1L,0L,1L,3L,0L,1L,2L,0L,1L,0L,1L,2L,0L,0L,4L,0L,0L,2L,0L,2L,1L,0L,3L,1L,0L,0L,2L,1L,0L,1L,3L,0L,1L,0L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278216Inst : IEnumerable<long>
{
public static readonly long[] Value=A278216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278216.Bytes);
public long this[int i]=>Value[i];

public static A278216Inst Instance=new A278216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278217
{
public static readonly long[] Value={ 1L,2L,2L,4L,6L,2L,4L,8L,12L,6L,2L,6L,12L,4L,8L,16L,24L,12L,6L,30L,6L,2L,6L,12L,36L,12L,4L,12L,24L,8L,16L,32L,48L,24L,12L,60L,30L,6L,30L,60L,12L,6L,2L,6L,30L,6L,12L,24L,72L,36L,12L,60L,12L,4L,12L,36L,72L,24L,8L,24L,48L,16L,32L,64L,96L,48L,24L,120L,60L,12L,60L,180L,60L,30L,6L,30L,210L,30L,60L,120L,24L,12L,6L,30L,6L,2L,6L,12L,60L,30L,6L,30L,60L,12L,24L,48L,144L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278217Inst : IEnumerable<long>
{
public static readonly long[] Value=A278217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278217.Bytes);
public long this[int i]=>Value[i];

public static A278217Inst Instance=new A278217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278218
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,4L,6L,4L,1L,1L,2L,6L,6L,2L,1L,1L,6L,6L,12L,6L,6L,1L,1L,2L,6L,6L,6L,6L,2L,1L,1L,8L,12L,24L,30L,24L,12L,8L,1L,1L,4L,36L,60L,60L,60L,60L,36L,4L,1L,1L,6L,12L,120L,210L,180L,210L,120L,12L,6L,1L,1L,2L,6L,30L,210L,210L,210L,210L,30L,6L,2L,1L,1L,12L,30L,60L,60L,360L,420L,360L,60L,60L,30L,12L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278218Inst : IEnumerable<long>
{
public static readonly long[] Value=A278218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278218.Bytes);
public long this[int i]=>Value[i];

public static A278218Inst Instance=new A278218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278219
{
public static readonly long[] Value={ 1L,2L,4L,2L,4L,8L,6L,2L,4L,12L,16L,8L,6L,12L,6L,2L,4L,12L,36L,12L,16L,32L,24L,8L,6L,30L,24L,12L,6L,12L,6L,2L,4L,12L,36L,12L,36L,72L,60L,12L,16L,48L,64L,32L,24L,72L,24L,8L,6L,30L,60L,30L,24L,48L,60L,12L,6L,30L,24L,12L,6L,12L,6L,2L,4L,12L,36L,12L,36L,72L,60L,12L,36L,180L,144L,72L,60L,180L,60L,12L,16L,48L,144L,48L,64L,128L,96L,32L,24L,120L,216L,72L,24L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278219Inst : IEnumerable<long>
{
public static readonly long[] Value=A278219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278219.Bytes);
public long this[int i]=>Value[i];

public static A278219Inst Instance=new A278219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278220
{
public static readonly long[] Value={ 1L,2L,4L,2L,8L,4L,16L,2L,6L,8L,32L,4L,64L,16L,12L,2L,128L,6L,256L,8L,24L,32L,512L,4L,12L,64L,6L,16L,1024L,12L,2048L,2L,48L,128L,36L,6L,4096L,256L,96L,8L,8192L,24L,16384L,32L,12L,512L,32768L,4L,24L,12L,192L,64L,65536L,6L,72L,16L,384L,1024L,131072L,12L,262144L,2048L,24L,2L,144L,48L,524288L,128L,768L,36L,1048576L,6L,2097152L,4096L,30L,256L,72L,96L,4194304L,8L,6L,8192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278220Inst : IEnumerable<long>
{
public static readonly long[] Value=A278220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278220.Bytes);
public long this[int i]=>Value[i];

public static A278220Inst Instance=new A278220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278221
{
public static readonly long[] Value={ 1L,2L,4L,2L,8L,6L,16L,2L,4L,12L,32L,6L,64L,24L,12L,2L,128L,6L,256L,12L,36L,48L,512L,6L,8L,96L,4L,24L,1024L,30L,2048L,2L,72L,192L,24L,6L,4096L,384L,144L,12L,8192L,60L,16384L,48L,12L,768L,32768L,6L,16L,12L,288L,96L,65536L,6L,72L,24L,576L,1536L,131072L,30L,262144L,3072L,36L,2L,216L,120L,524288L,192L,1152L,60L,1048576L,6L,2097152L,6144L,12L,384L,48L,240L,4194304L,12L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278221Inst : IEnumerable<long>
{
public static readonly long[] Value=A278221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278221.Bytes);
public long this[int i]=>Value[i];

public static A278221Inst Instance=new A278221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278222
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,6L,4L,8L,2L,6L,6L,12L,4L,12L,8L,16L,2L,6L,6L,12L,6L,30L,12L,24L,4L,12L,12L,36L,8L,24L,16L,32L,2L,6L,6L,12L,6L,30L,12L,24L,6L,30L,30L,60L,12L,60L,24L,48L,4L,12L,12L,36L,12L,60L,36L,72L,8L,24L,24L,72L,16L,48L,32L,64L,2L,6L,6L,12L,6L,30L,12L,24L,6L,30L,30L,60L,12L,60L,24L,48L,6L,30L,30L,60L,30L,210L,60L,120L,12L,60L,60L,180L,24L,120L,48L,96L,4L,12L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278222Inst : IEnumerable<long>
{
public static readonly long[] Value=A278222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278222.Bytes);
public long this[int i]=>Value[i];

public static A278222Inst Instance=new A278222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278223
{
public static readonly long[] Value={ 1L,2L,2L,2L,4L,2L,2L,6L,2L,2L,6L,2L,4L,8L,2L,2L,6L,6L,2L,6L,2L,2L,12L,2L,4L,6L,2L,6L,6L,2L,2L,12L,6L,2L,6L,2L,2L,12L,6L,2L,16L,2L,6L,6L,2L,6L,6L,6L,2L,12L,2L,2L,30L,2L,2L,6L,2L,6L,12L,6L,4L,6L,8L,2L,6L,2L,6L,24L,2L,2L,6L,6L,6L,12L,2L,2L,12L,6L,2L,6L,6L,2L,30L,2L,4L,12L,2L,12L,6L,2L,2L,6L,6L,6L,24L,2L,2L,30L,2L,2L,6L,6L,6L,12L,6L,2L,6L,6L,6L,6L,6L,2L,36L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278223Inst : IEnumerable<long>
{
public static readonly long[] Value=A278223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278223.Bytes);
public long this[int i]=>Value[i];

public static A278223Inst Instance=new A278223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278224
{
public static readonly long[] Value={ 1L,2L,2L,2L,4L,8L,6L,6L,2L,2L,2L,2L,4L,2L,12L,2L,6L,6L,12L,32L,12L,12L,6L,12L,4L,6L,12L,12L,16L,2L,2L,6L,6L,2L,6L,2L,6L,6L,2L,6L,6L,2L,24L,2L,24L,12L,8L,6L,2L,6L,48L,6L,30L,12L,6L,2L,6L,2L,2L,6L,6L,24L,30L,6L,60L,12L,36L,6L,2L,12L,2L,12L,24L,6L,6L,24L,72L,128L,30L,12L,2L,6L,12L,24L,2L,2L,30L,48L,4L,2L,6L,2L,6L,48L,16L,96L,6L,30L,2L,6L,12L,6L,24L,30L,2L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278224Inst : IEnumerable<long>
{
public static readonly long[] Value=A278224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278224.Bytes);
public long this[int i]=>Value[i];

public static A278224Inst Instance=new A278224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278225
{
public static readonly long[] Value={ 2L,4L,12L,8L,12L,8L,60L,36L,24L,16L,24L,16L,60L,24L,24L,16L,36L,16L,60L,24L,36L,16L,24L,16L,420L,180L,180L,72L,180L,72L,120L,72L,48L,32L,48L,32L,120L,48L,48L,32L,72L,32L,120L,48L,72L,32L,48L,32L,420L,180L,120L,48L,120L,48L,120L,72L,48L,32L,48L,32L,180L,72L,48L,32L,72L,32L,180L,72L,72L,32L,48L,32L,420L,120L,120L,48L,180L,48L,180L,72L,48L,32L,72L,32L,120L,48L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278225Inst : IEnumerable<long>
{
public static readonly long[] Value=A278225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278225.Bytes);
public long this[int i]=>Value[i];

public static A278225Inst Instance=new A278225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278226
{
public static readonly long[] Value={ 1L,2L,2L,6L,4L,12L,2L,6L,6L,30L,12L,60L,4L,12L,12L,60L,36L,180L,8L,24L,24L,120L,72L,360L,16L,48L,48L,240L,144L,720L,2L,6L,6L,30L,12L,60L,6L,30L,30L,210L,60L,420L,12L,60L,60L,420L,180L,1260L,24L,120L,120L,840L,360L,2520L,48L,240L,240L,1680L,720L,5040L,4L,12L,12L,60L,36L,180L,12L,60L,60L,420L,180L,1260L,36L,180L,180L,1260L,900L,6300L,72L,360L,360L,2520L,1800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278226Inst : IEnumerable<long>
{
public static readonly long[] Value=A278226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278226.Bytes);
public long this[int i]=>Value[i];

public static A278226Inst Instance=new A278226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278227
{
public static readonly long[] Value={ 1L,2L,4L,6L,6L,12L,16L,12L,6L,12L,30L,36L,24L,30L,6L,12L,6L,60L,30L,30L,72L,30L,6L,24L,96L,36L,30L,6L,72L,48L,60L,30L,24L,30L,12L,60L,60L,48L,6L,12L,6L,180L,30L,192L,36L,60L,210L,30L,6L,60L,24L,30L,240L,24L,256L,6L,12L,120L,60L,120L,30L,12L,60L,30L,120L,12L,210L,240L,6L,60L,96L,6L,30L,60L,120L,6L,12L,180L,144L,120L,30L,420L,30L,432L,30L,30L,192L,120L,60L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278227Inst : IEnumerable<long>
{
public static readonly long[] Value=A278227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278227.Bytes);
public long this[int i]=>Value[i];

public static A278227Inst Instance=new A278227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278228
{
public static readonly long[] Value={ 2L,4L,6L,8L,12L,6L,12L,12L,24L,30L,32L,6L,30L,12L,48L,24L,60L,6L,12L,72L,6L,48L,60L,60L,12L,30L,24L,72L,30L,30L,128L,60L,30L,60L,60L,24L,6L,12L,120L,30L,180L,30L,192L,6L,60L,72L,12L,96L,60L,30L,60L,240L,12L,180L,30L,120L,120L,48L,6L,30L,12L,60L,60L,120L,6L,30L,12L,12L,60L,60L,30L,360L,48L,30L,60L,384L,210L,6L,30L,30L,420L,6L,432L,30L,120L,60L,180L,6L,210L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278228Inst : IEnumerable<long>
{
public static readonly long[] Value=A278228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278228.Bytes);
public long this[int i]=>Value[i];

public static A278228Inst Instance=new A278228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278229
{
public static readonly long[] Value={ 2L,2L,4L,2L,6L,4L,6L,2L,12L,6L,2L,2L,16L,6L,6L,30L,12L,4L,6L,6L,6L,2L,30L,6L,2L,6L,6L,6L,6L,36L,6L,12L,30L,2L,24L,6L,2L,12L,12L,30L,30L,4L,6L,30L,6L,2L,2L,6L,6L,2L,30L,12L,6L,6L,24L,60L,6L,2L,6L,30L,6L,60L,2L,24L,16L,6L,2L,2L,60L,6L,30L,6L,2L,6L,2L,60L,30L,6L,12L,6L,24L,4L,30L,6L,2L,30L,30L,6L,6L,12L,6L,30L,6L,12L,2L,30L,12L,6L,30L,6L,2L,30L,72L,6L,6L,2L,30L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278229Inst : IEnumerable<long>
{
public static readonly long[] Value=A278229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278229.Bytes);
public long this[int i]=>Value[i];

public static A278229Inst Instance=new A278229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278230
{
public static readonly long[] Value={ 2L,2L,2L,6L,2L,8L,6L,6L,2L,2L,12L,12L,2L,6L,6L,2L,6L,6L,24L,6L,12L,6L,2L,2L,30L,6L,12L,6L,6L,2L,30L,2L,12L,12L,6L,6L,60L,6L,6L,2L,2L,12L,2L,12L,6L,30L,12L,6L,30L,24L,2L,2L,30L,2L,6L,6L,12L,6L,30L,2L,48L,2L,30L,6L,30L,6L,30L,72L,6L,6L,6L,2L,60L,12L,30L,6L,6L,30L,6L,60L,2L,6L,2L,12L,6L,2L,6L,30L,6L,12L,30L,6L,60L,2L,24L,6L,2L,6L,6L,12L,30L,6L,12L,6L,12L,210L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278230Inst : IEnumerable<long>
{
public static readonly long[] Value=A278230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278230.Bytes);
public long this[int i]=>Value[i];

public static A278230Inst Instance=new A278230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278231
{
public static readonly long[] Value={ 1L,2L,2L,2L,4L,6L,2L,6L,6L,12L,2L,6L,2L,4L,8L,2L,16L,12L,2L,12L,6L,2L,6L,30L,2L,2L,12L,8L,6L,24L,4L,6L,12L,48L,4L,24L,6L,2L,12L,60L,2L,12L,6L,6L,24L,6L,2L,6L,6L,6L,32L,6L,6L,36L,2L,12L,12L,6L,2L,24L,2L,2L,30L,6L,60L,6L,6L,48L,16L,2L,6L,60L,6L,2L,24L,6L,6L,12L,6L,12L,6L,2L,30L,6L,64L,30L,2L,12L,6L,72L,2L,30L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278231Inst : IEnumerable<long>
{
public static readonly long[] Value=A278231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278231.Bytes);
public long this[int i]=>Value[i];

public static A278231Inst Instance=new A278231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278232
{
public static readonly long[] Value={ 2L,6L,12L,12L,6L,30L,6L,30L,6L,24L,6L,6L,30L,30L,60L,6L,30L,6L,30L,6L,4L,8L,6L,144L,24L,48L,6L,30L,30L,30L,6L,210L,6L,30L,30L,12L,12L,24L,6L,120L,6L,30L,60L,6L,6L,30L,6L,210L,60L,6L,30L,6L,30L,30L,210L,6L,30L,30L,30L,30L,30L,30L,6L,210L,6L,30L,96L,30L,210L,60L,30L,210L,60L,6L,6L,30L,30L,30L,30L,30L,420L,30L,60L,30L,6L,30L,30L,24L,120L,30L,12L,12L,30L,6L,30L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278232Inst : IEnumerable<long>
{
public static readonly long[] Value=A278232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278232.Bytes);
public long this[int i]=>Value[i];

public static A278232Inst Instance=new A278232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278233
{
public static readonly long[] Value={ 1L,2L,2L,4L,4L,6L,2L,8L,6L,12L,2L,12L,2L,6L,8L,16L,16L,30L,2L,36L,4L,6L,6L,24L,2L,6L,12L,12L,6L,24L,2L,32L,6L,48L,6L,60L,2L,6L,12L,72L,2L,12L,6L,12L,24L,30L,2L,48L,6L,6L,32L,12L,6L,60L,2L,24L,12L,30L,2L,72L,2L,6L,12L,64L,36L,30L,2L,144L,4L,30L,6L,120L,2L,6L,24L,12L,6L,60L,6L,144L,4L,6L,30L,36L,64L,30L,2L,24L,6L,120L,2L,60L,6L,6L,12L,96L,2L,30L,12L,12L,30L,96L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278233Inst : IEnumerable<long>
{
public static readonly long[] Value=A278233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278233.Bytes);
public long this[int i]=>Value[i];

public static A278233Inst Instance=new A278233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278234
{
public static readonly long[] Value={ 1L,2L,2L,6L,2L,4L,2L,6L,6L,30L,6L,12L,2L,6L,4L,12L,6L,12L,2L,4L,6L,12L,4L,8L,2L,6L,6L,30L,6L,12L,6L,30L,30L,210L,30L,60L,6L,30L,12L,60L,30L,60L,6L,12L,30L,60L,12L,24L,2L,6L,6L,30L,6L,12L,4L,12L,12L,60L,12L,36L,6L,30L,12L,60L,30L,60L,6L,12L,30L,60L,12L,24L,2L,6L,4L,12L,6L,12L,6L,30L,12L,60L,30L,60L,4L,12L,8L,24L,12L,36L,6L,12L,12L,36L,12L,24L,2L,4L,6L,12L,4L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278234Inst : IEnumerable<long>
{
public static readonly long[] Value=A278234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278234.Bytes);
public long this[int i]=>Value[i];

public static A278234Inst Instance=new A278234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278235
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,6L,2L,4L,4L,8L,6L,12L,2L,6L,6L,12L,4L,12L,2L,6L,6L,12L,6L,30L,2L,4L,4L,8L,6L,12L,4L,8L,8L,16L,12L,24L,6L,12L,12L,24L,12L,36L,6L,12L,12L,24L,30L,60L,2L,6L,6L,12L,4L,12L,6L,12L,12L,24L,12L,36L,4L,12L,12L,36L,8L,24L,6L,30L,30L,60L,12L,60L,2L,6L,6L,12L,6L,30L,6L,12L,12L,24L,30L,60L,6L,30L,30L,60L,12L,60L,4L,12L,12L,36L,12L,60L,2L,6L,6L,12L,6L,30L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278235Inst : IEnumerable<long>
{
public static readonly long[] Value=A278235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278235.Bytes);
public long this[int i]=>Value[i];

public static A278235Inst Instance=new A278235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278236
{
public static readonly long[] Value={ 1L,2L,2L,6L,4L,12L,2L,6L,6L,30L,12L,60L,4L,12L,12L,60L,36L,180L,8L,24L,24L,120L,72L,360L,2L,6L,6L,30L,12L,60L,6L,30L,30L,210L,60L,420L,12L,60L,60L,420L,180L,1260L,24L,120L,120L,840L,360L,2520L,4L,12L,12L,60L,36L,180L,12L,60L,60L,420L,180L,1260L,36L,180L,180L,1260L,900L,6300L,72L,360L,360L,2520L,1800L,12600L,8L,24L,24L,120L,72L,360L,24L,120L,120L,840L,360L,2520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278236Inst : IEnumerable<long>
{
public static readonly long[] Value=A278236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278236.Bytes);
public long this[int i]=>Value[i];

public static A278236Inst Instance=new A278236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278237
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,6L,2L,8L,4L,6L,2L,12L,2L,6L,6L,16L,4L,12L,2L,12L,6L,6L,2L,24L,2L,6L,8L,12L,6L,30L,2L,64L,6L,6L,2L,36L,2L,6L,6L,24L,2L,30L,4L,12L,12L,6L,2L,48L,2L,30L,12L,12L,2L,24L,2L,24L,6L,6L,6L,60L,2L,6L,12L,32L,2L,30L,2L,12L,6L,12L,6L,72L,6L,6L,6L,12L,2L,30L,2L,48L,16L,6L,2L,60L,2L,30L,30L,24L,6L,60L,6L,12L,6L,6L,2L,192L,6L,6L,12L,36L,2L,30L,2L,48L,6L,30L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278237Inst : IEnumerable<long>
{
public static readonly long[] Value=A278237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278237.Bytes);
public long this[int i]=>Value[i];

public static A278237Inst Instance=new A278237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278238
{
public static readonly long[] Value={ 1L,4L,4L,16L,16L,36L,4L,64L,36L,144L,4L,144L,4L,36L,64L,256L,256L,900L,4L,1296L,16L,36L,36L,576L,4L,36L,144L,144L,36L,576L,4L,1024L,36L,2304L,36L,3600L,4L,36L,144L,5184L,4L,144L,36L,144L,576L,900L,4L,2304L,36L,36L,1024L,144L,36L,3600L,4L,576L,144L,900L,4L,5184L,4L,36L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278238Inst : IEnumerable<long>
{
public static readonly long[] Value=A278238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278238.Bytes);
public long this[int i]=>Value[i];

public static A278238Inst Instance=new A278238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278239
{
public static readonly long[] Value={ 1L,4L,6L,16L,12L,60L,6L,64L,30L,180L,6L,240L,12L,60L,24L,256L,240L,420L,6L,720L,12L,60L,30L,960L,6L,180L,60L,240L,30L,360L,30L,1024L,30L,5040L,30L,1680L,6L,60L,360L,2880L,30L,180L,210L,240L,120L,420L,6L,3840L,60L,60L,96L,720L,210L,1260L,6L,960L,60L,420L,30L,2160L,12L,420L,60L,4096L,180L,420L,30L,45360L,60L,420L,30L,6720L,30L,60L,840L,240L,30L,12600L,30L,11520L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278239Inst : IEnumerable<long>
{
public static readonly long[] Value=A278239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278239.Bytes);
public long this[int i]=>Value[i];

public static A278239Inst Instance=new A278239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278240
{
public static readonly long[] Value={ 1L,2L,2L,6L,2L,12L,2L,30L,6L,30L,6L,420L,2L,30L,30L,210L,2L,840L,2L,4620L,60L,210L,6L,60060L,30L,30L,30L,30030L,30L,60060L,2L,2310L,210L,30L,210L,38798760L,6L,30L,210L,1021020L,6L,180180L,30L,510510L,30030L,210L,30L,446185740L,6L,510510L,2310L,510510L,30L,240240L,30030L,9699690L,210L,30030L,6L,1203362940780L,2L,30L,60060L,510510L,30L,19399380L,6L,510510L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278240Inst : IEnumerable<long>
{
public static readonly long[] Value=A278240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278240.Bytes);
public long this[int i]=>Value[i];

public static A278240Inst Instance=new A278240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278241
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,2L,2L,6L,6L,30L,30L,24L,6L,2L,24L,48L,30L,24L,30L,60L,30L,360L,30L,6L,180L,30L,420L,210L,60L,30L,60L,30L,60L,180L,30L,60L,2L,30L,60L,1680L,420L,210L,30L,240L,60L,30L,210L,420L,30L,60L,30L,60L,2310L,60L,2310L,420L,30L,30L,420L,4620L,30L,2310L,420L,30L,2310L,6L,6720L,6L,420L,30L,3360L,30L,30L,30L,2520L,120120L,6L,2L,420L,420L,1260L,6L,840L,30L,4620L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278241Inst : IEnumerable<long>
{
public static readonly long[] Value=A278241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278241.Bytes);
public long this[int i]=>Value[i];

public static A278241Inst Instance=new A278241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278242
{
public static readonly long[] Value={ 2L,2L,2L,4L,2L,6L,6L,6L,2L,24L,12L,6L,6L,6L,30L,60L,2L,6L,210L,6L,6L,60L,30L,6L,30L,210L,210L,240L,6L,30L,4620L,6L,6L,420L,210L,2310L,210L,30L,210L,60L,6L,30L,30030L,6L,30L,9240L,2310L,30L,30L,30L,9240L,4620L,30L,30L,30030L,4620L,30L,420L,30L,210L,210L,6L,2310L,9240L,6L,30030L,30030L,30L,60L,420L,60060L,30L,2310L,30L,2310L,60060L,210L,30030L,446185740L,6L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278242Inst : IEnumerable<long>
{
public static readonly long[] Value=A278242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278242.Bytes);
public long this[int i]=>Value[i];

public static A278242Inst Instance=new A278242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278243
{
public static readonly long[] Value={ 1L,2L,2L,6L,2L,12L,6L,30L,2L,60L,12L,120L,6L,180L,30L,210L,2L,420L,60L,1080L,12L,2160L,120L,2520L,6L,2520L,180L,7560L,30L,6300L,210L,2310L,2L,4620L,420L,37800L,60L,90720L,1080L,75600L,12L,226800L,2160L,544320L,120L,453600L,2520L,138600L,6L,138600L,2520L,756000L,180L,2268000L,7560L,831600L,30L,415800L,6300L,2079000L,210L,485100L,2310L,30030L,2L,60060L,4620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278243Inst : IEnumerable<long>
{
public static readonly long[] Value=A278243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278243.Bytes);
public long this[int i]=>Value[i];

public static A278243Inst Instance=new A278243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278244
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,2L,6L,2L,6L,2L,6L,6L,2L,6L,2L,6L,6L,2L,6L,2L,4L,12L,2L,30L,2L,2L,6L,6L,24L,2L,2L,6L,2L,6L,2L,2L,30L,6L,6L,2L,6L,30L,2L,6L,6L,6L,12L,2L,6L,12L,2L,6L,6L,12L,6L,6L,6L,6L,12L,6L,2L,30L,6L,6L,6L,2L,30L,6L,6L,2L,2L,12L,2L,6L,6L,6L,6L,6L,60L,2L,6L,6L,2L,6L,2L,2L,30L,2L,30L,6L,2L,30L,6L,30L,6L,30L,24L,2L,6L,2L,2L,30L,2L,12L,2L,6L,30L,6L,30L,2L,2L,6L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278244Inst : IEnumerable<long>
{
public static readonly long[] Value=A278244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278244.Bytes);
public long this[int i]=>Value[i];

public static A278244Inst Instance=new A278244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278245
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,8L,2L,6L,6L,6L,2L,144L,2L,6L,30L,30L,2L,120L,6L,210L,30L,6L,2L,10080L,12L,6L,210L,210L,2L,9240L,6L,210L,30L,6L,30L,166320L,30L,30L,30L,30030L,6L,9240L,2L,2310L,2310L,30L,2L,2882880L,30L,4620L,30L,210L,6L,120120L,210L,60060L,2310L,30L,6L,232792560L,6L,30L,2310L,30030L,30L,9240L,30L,2310L,2310L,510510L,6L,1396755360L,6L,210L,4620L,2310L,210L,120120L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278245Inst : IEnumerable<long>
{
public static readonly long[] Value=A278245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278245.Bytes);
public long this[int i]=>Value[i];

public static A278245Inst Instance=new A278245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278246
{
public static readonly long[] Value={ 2L,2L,4L,6L,12L,8L,6L,12L,24L,6L,6L,60L,24L,6L,24L,24L,30L,24L,6L,30L,180L,12L,6L,144L,60L,6L,48L,30L,48L,60L,6L,240L,120L,6L,30L,120L,60L,6L,60L,60L,30L,120L,6L,30L,1080L,12L,12L,360L,60L,12L,48L,210L,60L,48L,30L,60L,420L,6L,6L,840L,96L,30L,120L,96L,210L,60L,30L,30L,360L,30L,6L,1800L,30L,30L,180L,30L,840L,96L,6L,120L,480L,30L,6L,420L,420L,6L,120L,420L,30L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278246Inst : IEnumerable<long>
{
public static readonly long[] Value=A278246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278246.Bytes);
public long this[int i]=>Value[i];

public static A278246Inst Instance=new A278246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278247
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,2L,6L,2L,2L,2L,2L,6L,2L,6L,2L,2L,6L,6L,2L,2L,2L,6L,6L,2L,6L,2L,6L,2L,6L,2L,2L,6L,6L,6L,2L,8L,6L,2L,2L,6L,2L,12L,6L,2L,2L,2L,30L,2L,6L,2L,6L,30L,2L,2L,2L,2L,6L,6L,2L,2L,6L,30L,6L,2L,2L,2L,6L,2L,6L,2L,6L,6L,6L,6L,6L,2L,6L,6L,6L,30L,6L,6L,2L,12L,2L,2L,6L,6L,2L,6L,6L,30L,2L,2L,6L,2L,6L,6L,6L,2L,2L,30L,2L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,2L,2L,6L,30L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278247Inst : IEnumerable<long>
{
public static readonly long[] Value=A278247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278247.Bytes);
public long this[int i]=>Value[i];

public static A278247Inst Instance=new A278247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278248
{
public static readonly long[] Value={ 2L,0L,2L,2L,2L,2L,2L,2L,6L,12L,2L,6L,2L,6L,6L,12L,60L,6L,6L,6L,2L,2L,96L,60L,2L,30L,6L,6L,6L,840L,30L,6L,30L,6L,2L,6L,6L,60L,2L,420L,1260L,30L,30L,420L,210L,30L,30L,210L,6L,30L,30L,12L,6L,2310L,30L,840L,6L,240L,6L,30L,6L,420L,6L,6L,30L,420L,6L,210L,6L,6L,6L,4620L,60L,210L,30030L,2L,6L,30L,2310L,13860L,60L,210L,6L,6L,6L,120L,6L,2310L,210L,210L,6L,210L,30L,60L,4620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278248Inst : IEnumerable<long>
{
public static readonly long[] Value=A278248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278248.Bytes);
public long this[int i]=>Value[i];

public static A278248Inst Instance=new A278248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278249
{
public static readonly long[] Value={ 1L,2L,4L,6L,6L,6L,12L,6L,36L,6L,60L,6L,6L,30L,60L,6L,6L,30L,12L,210L,210L,180L,12L,30L,12L,30L,900L,60L,6L,6L,60L,30L,12L,210L,720L,30L,420L,30L,60L,6L,12L,30L,60L,6L,6L,60L,60L,30L,60L,210L,2520L,210L,210L,30L,180L,210L,60L,120L,60L,210L,6L,30L,60L,30L,6L,30L,60L,30L,6L,30L,12L,30L,60L,30L,420L,210L,60L,30L,420L,60L,6L,30L,2520L,30L,30L,210L,12L,210L,60L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278249Inst : IEnumerable<long>
{
public static readonly long[] Value=A278249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278249.Bytes);
public long this[int i]=>Value[i];

public static A278249Inst Instance=new A278249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278250
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,6L,2L,2L,6L,12L,12L,6L,2L,2L,60L,30L,2L,6L,120L,6L,6L,180L,2L,12L,30L,210L,6L,2L,2L,30L,210L,6L,30L,900900L,30L,180L,24L,210L,60060L,210L,13860L,120L,210L,210L,210L,96L,30L,60060L,6126120L,2310L,30L,60L,2310L,2310L,30L,4620L,210L,240L,210L,120L,30L,60L,2L,1260L,30L,30L,2310L,2310L,60L,18480L,30L,2310L,420L,30L,2310L,18480L,30L,3360L,210L,2L,420L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278250Inst : IEnumerable<long>
{
public static readonly long[] Value=A278250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278250.Bytes);
public long this[int i]=>Value[i];

public static A278250Inst Instance=new A278250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278251
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,6L,2L,2L,6L,2L,6L,6L,6L,2L,6L,2L,2L,30L,2L,8L,6L,2L,2L,12L,6L,2L,30L,6L,2L,6L,6L,12L,6L,6L,2L,6L,6L,6L,30L,2L,6L,6L,2L,6L,6L,6L,6L,30L,6L,6L,30L,2L,6L,6L,6L,2L,30L,6L,2L,30L,2L,6L,30L,2L,6L,30L,6L,2L,60L,12L,2L,6L,2L,6L,6L,30L,2L,6L,2L,2L,60L,2L,30L,6L,6L,6L,6L,6L,30L,30L,2L,2L,6L,6L,6L,30L,6L,6L,6L,6L,2L,210L,2L,30L,6L,6L,2L,30L,30L,6L,30L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278251Inst : IEnumerable<long>
{
public static readonly long[] Value=A278251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278251.Bytes);
public long this[int i]=>Value[i];

public static A278251Inst Instance=new A278251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278252
{
public static readonly long[] Value={ 1L,4L,6L,12L,6L,24L,60L,120L,30L,60L,30L,60L,30L,240L,120L,240L,30L,420L,210L,420L,30L,120L,180L,360L,180L,1260L,420L,420L,30L,480L,240L,480L,210L,4620L,2310L,420L,30L,840L,420L,840L,30L,420L,2310L,4620L,210L,240L,360L,3600L,180L,1260L,210L,1260L,420L,27720L,4620L,840L,30L,420L,210L,420L,210L,6720L,36960L,6720L,210L,420L,210L,4620L,210L,9240L,420L,840L,60L,1260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278252Inst : IEnumerable<long>
{
public static readonly long[] Value=A278252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278252.Bytes);
public long this[int i]=>Value[i];

public static A278252Inst Instance=new A278252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278253
{
public static readonly long[] Value={ 1L,2L,6L,6L,6L,6L,12L,36L,12L,6L,30L,30L,6L,30L,120L,24L,12L,12L,30L,210L,30L,6L,60L,180L,12L,24L,120L,30L,30L,30L,48L,240L,30L,30L,420L,60L,6L,30L,420L,60L,30L,30L,30L,420L,60L,6L,120L,360L,36L,60L,210L,30L,24L,120L,420L,420L,30L,6L,210L,210L,6L,60L,1440L,480L,210L,30L,30L,210L,210L,30L,180L,180L,6L,60L,420L,210L,210L,30L,120L,2160L,48L,6L,210L,2310L,30L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278253Inst : IEnumerable<long>
{
public static readonly long[] Value=A278253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278253.Bytes);
public long this[int i]=>Value[i];

public static A278253Inst Instance=new A278253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278254
{
public static readonly long[] Value={ 1L,4L,4L,16L,4L,36L,4L,64L,16L,36L,4L,144L,4L,36L,36L,256L,4L,144L,4L,144L,36L,36L,4L,576L,16L,36L,64L,144L,4L,900L,4L,1024L,36L,36L,36L,1296L,4L,36L,36L,576L,4L,900L,4L,144L,144L,36L,4L,2304L,16L,144L,36L,144L,4L,576L,36L,576L,36L,36L,4L,3600L,4L,36L,144L,4096L,36L,900L,4L,144L,36L,900L,4L,5184L,4L,36L,144L,144L,36L,900L,4L,2304L,256L,36L,4L,3600L,36L,36L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278254Inst : IEnumerable<long>
{
public static readonly long[] Value=A278254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278254.Bytes);
public long this[int i]=>Value[i];

public static A278254Inst Instance=new A278254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278255
{
public static readonly long[] Value={ 1L,2L,12L,6L,6L,6L,30L,12L,12L,6L,48L,210L,6L,6L,210L,24L,12L,12L,60L,30L,30L,30L,30L,60L,12L,30L,1080L,30L,6L,30L,30L,240L,60L,6L,420L,60L,30L,6L,210L,420L,6L,120L,192L,30L,60L,6L,210L,840L,12L,12L,420L,210L,6L,120L,210L,60L,210L,6L,120L,210L,30L,30L,420L,96L,30L,30L,180L,210L,30L,210L,30L,1260L,6L,30L,5040L,30L,210L,30L,30L,120L,144L,60L,60L,210L,30L,6L,2310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278255Inst : IEnumerable<long>
{
public static readonly long[] Value=A278255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278255.Bytes);
public long this[int i]=>Value[i];

public static A278255Inst Instance=new A278255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278256
{
public static readonly long[] Value={ 2L,6L,12L,12L,30L,30L,24L,72L,60L,30L,60L,60L,30L,210L,240L,48L,60L,60L,60L,420L,210L,30L,120L,360L,60L,120L,360L,60L,210L,210L,96L,480L,210L,210L,1260L,180L,30L,210L,840L,120L,210L,210L,60L,1260L,420L,30L,240L,720L,180L,420L,420L,60L,120L,840L,840L,840L,210L,30L,420L,420L,30L,420L,2880L,960L,2310L,210L,60L,420L,2310L,210L,360L,360L,30L,420L,1260L,420L,2310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278256Inst : IEnumerable<long>
{
public static readonly long[] Value=A278256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278256.Bytes);
public long this[int i]=>Value[i];

public static A278256Inst Instance=new A278256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278257
{
public static readonly long[] Value={ 1L,2L,4L,2L,8L,6L,2L,6L,16L,12L,2L,6L,2L,4L,6L,2L,32L,6L,6L,6L,6L,2L,30L,6L,2L,4L,12L,2L,24L,24L,6L,12L,64L,30L,2L,30L,2L,2L,6L,30L,2L,16L,6L,6L,6L,24L,2L,6L,6L,2L,12L,2L,30L,24L,30L,2L,30L,48L,2L,12L,12L,6L,120L,2L,128L,30L,2L,6L,24L,2L,30L,6L,6L,6L,6L,2L,60L,24L,12L,6L,6L,6L,48L,30L,6L,120L,4L,2L,30L,48L,6L,180L,2L,6L,24L,30L,2L,2L,6L,2L,60L,72L,6L,6L,6L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278257Inst : IEnumerable<long>
{
public static readonly long[] Value=A278257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278257.Bytes);
public long this[int i]=>Value[i];

public static A278257Inst Instance=new A278257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278258
{
public static readonly long[] Value={ 1L,1L,2L,2L,6L,30L,60L,30L,210L,210L,420L,2310L,4620L,13860L,360360L,60060L,1021020L,9699690L,58198140L,223092870L,446185740L,446185740L,892371480L,1338557220L,1338557220L,6692786100L,2677114440L,12939386460L,802241960520L,802241960520L,1604483921040L,200560490130L,14841476269620L,608500527054420L,608500527054420L,304250263527210L,608500527054420L,608500527054420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278258Inst : IEnumerable<long>
{
public static readonly long[] Value=A278258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278258.Bytes);
public long this[int i]=>Value[i];

public static A278258Inst Instance=new A278258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278259
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,4L,12L,16L,12L,4L,30L,36L,30L,4L,24L,64L,72L,16L,60L,36L,30L,4L,60L,144L,60L,4L,30L,36L,210L,36L,240L,256L,48L,4L,60L,144L,60L,4L,60L,144L,420L,36L,210L,36L,30L,4L,120L,576L,360L,16L,60L,36L,120L,64L,360L,144L,60L,4L,210L,900L,210L,4L,96L,1024L,480L,36L,210L,36L,210L,36L,1260L,1296L,180L,4L,30L,36L,210L,36L,840L,576L,120L,4L,210L,900L,210L,4L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278259Inst : IEnumerable<long>
{
public static readonly long[] Value=A278259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278259.Bytes);
public long this[int i]=>Value[i];

public static A278259Inst Instance=new A278259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278260
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,6L,2L,2L,6L,6L,2L,2L,2L,12L,6L,6L,2L,6L,6L,2L,6L,6L,6L,6L,2L,30L,6L,2L,2L,6L,2L,2L,30L,30L,2L,12L,8L,6L,6L,2L,2L,30L,2L,6L,12L,30L,6L,2L,2L,6L,30L,2L,6L,30L,2L,6L,6L,6L,6L,6L,12L,30L,6L,12L,6L,30L,2L,6L,6L,6L,6L,2L,6L,30L,30L,12L,2L,6L,6L,2L,6L,12L,2L,6L,6L,60L,6L,6L,6L,6L,6L,6L,30L,210L,6L,6L,6L,6L,30L,6L,2L,6L,6L,6L,6L,30L,6L,2L,2L,30L,30L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278260Inst : IEnumerable<long>
{
public static readonly long[] Value=A278260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278260.Bytes);
public long this[int i]=>Value[i];

public static A278260Inst Instance=new A278260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278261
{
public static readonly long[] Value={ 1L,8L,2L,8L,24L,24L,2L,64L,24L,24L,192L,72L,24L,24L,4L,8L,24L,96L,24L,72L,96L,24L,72L,192L,24L,3456L,192L,24L,3456L,24L,2L,216L,192L,24L,1080L,72L,24L,8640L,576L,192L,8640L,3456L,24L,1080L,3456L,192L,1080L,120L,72L,96L,120L,24L,96L,360L,72L,576L,360L,24L,192L,120L,24L,72L,6L,8L,24L,1080L,24L,5400L,8640L,24L,72L,1080L,24L,432000L,8640L,24L,3456L,12288L,24L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278261Inst : IEnumerable<long>
{
public static readonly long[] Value=A278261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278261.Bytes);
public long this[int i]=>Value[i];

public static A278261Inst Instance=new A278261Inst();

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