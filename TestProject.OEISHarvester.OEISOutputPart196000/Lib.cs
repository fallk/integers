using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A226457
{
public static readonly long[] Value={ 1L,1L,4L,2L,5L,8L,9L,5L,8L,11L,12L,15L,16L,17L,18L,12L,15L,18L,19L,22L,23L,24L,25L,28L,29L,30L,31L,32L,33L,34L,35L,27L,30L,33L,34L,37L,38L,39L,40L,43L,44L,45L,46L,47L,48L,49L,50L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,58L,61L,64L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226457Inst : IEnumerable<long>
{
public static readonly long[] Value=A226457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226457.Bytes);
public long this[int i]=>Value[i];

public static A226457Inst Instance=new A226457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226458
{
public static readonly BigInteger[] Value={ 1L,1L,2L,8L,41L,547L,3193L,104733L,1159483L,29990445L,431859113L,24050995053L,272382000003L,21806033497537L,362394321610042L,15956110448082190L,592910703485329797L,BigInteger.Parse("46410258555248498805"),BigInteger.Parse("775743319456458483203"),BigInteger.Parse("99472768731785230089041") };
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
public class A226458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226458Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A226458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226458.Bytes);
public BigInteger this[int i]=>Value[i];

public static A226458Inst Instance=new A226458Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226459
{
public static readonly BigInteger[] Value={ 1L,3L,19L,131L,2501L,15573L,705895L,8388739L,258280345L,4000002503L,259374246011L,2972033498453L,279577021469773L,4762288640230761L,233543408203127519L,9223372036863164547UL,BigInteger.Parse("778579070010669895697"),BigInteger.Parse("13115469358432437487707"),BigInteger.Parse("1874292305362402347591139") };
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
public class A226459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226459Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A226459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226459.Bytes);
public BigInteger this[int i]=>Value[i];

public static A226459Inst Instance=new A226459Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226460
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,2L,1L,2L,0L,1L,0L,3L,2L,2L,1L,1L,1L,3L,0L,1L,2L,1L,0L,4L,2L,1L,0L,2L,1L,4L,2L,2L,0L,2L,0L,2L,2L,3L,1L,3L,1L,2L,1L,3L,1L,1L,0L,5L,2L,0L,0L,2L,2L,2L,1L,3L,2L,0L,1L,5L,3L,3L,1L,1L,2L,2L,0L,2L,1L,3L,0L,4L,2L,3L,0L,2L,1L,2L,1L,4L,2L,0L,0L,6L,1L,1L,0L,3L,1L,3L,1L,3L,3L,1L,0L,4L,3L,2L,1L,2L,2L,1L,0L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226460Inst : IEnumerable<long>
{
public static readonly long[] Value=A226460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226460.Bytes);
public long this[int i]=>Value[i];

public static A226460Inst Instance=new A226460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226461
{
public static readonly long[] Value={ 6L,2100L,20586L,669054L,745590L,6556122L,9317496L,10190796L,15648732L,18215196L,25561410L,35613990L,36710652L,38649066L,41124594L,41711874L,46576524L,48701400L,49406358L,59278296L,70038948L,74993808L,75553092L,83606418L,84182154L,88000374L,92527764L,98969052L,100691976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226461Inst : IEnumerable<long>
{
public static readonly long[] Value=A226461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226461.Bytes);
public long this[int i]=>Value[i];

public static A226461Inst Instance=new A226461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226462
{
public static readonly long[] Value={ 0L,2L,5L,11L,23L,47L,83L,167L,179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226462Inst : IEnumerable<long>
{
public static readonly long[] Value=A226462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226462.Bytes);
public long this[int i]=>Value[i];

public static A226462Inst Instance=new A226462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226463
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,1L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226463Inst : IEnumerable<long>
{
public static readonly long[] Value=A226463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226463.Bytes);
public long this[int i]=>Value[i];

public static A226463Inst Instance=new A226463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226464
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226464Inst : IEnumerable<long>
{
public static readonly long[] Value=A226464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226464.Bytes);
public long this[int i]=>Value[i];

public static A226464Inst Instance=new A226464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226465
{
public static readonly long[] Value={ 21L,210L,765L,9876L,2109876L,7654321L,76543210L,4321098765L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226465Inst : IEnumerable<long>
{
public static readonly long[] Value=A226465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226465.Bytes);
public long this[int i]=>Value[i];

public static A226465Inst Instance=new A226465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226466
{
public static readonly BigInteger[] Value={ 1L,3L,14L,54L,306L,918L,4524L,25560L,168828L,1315764L,11998584L,125358192L,1466062200L,18835528104L,262376016912L,3927709053792L,62795044663056L,1067217284481840L,19208039592749472L,364940846656681536L,7298740111856220576L,BigInteger.Parse("153273039685710932448"),BigInteger.Parse("3372003538678423189440") };
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
public class A226466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226466Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A226466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226466.Bytes);
public BigInteger this[int i]=>Value[i];

public static A226466Inst Instance=new A226466Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226467
{
public static readonly long[] Value={ 1L,11L,22L,33L,44L,55L,66L,77L,88L,99L,111L,199L,446L,464L,555L,644L,666L,919L,991L,1111L,1199L,1919L,1991L,2228L,2282L,2822L,2888L,3337L,3373L,3733L,3777L,4444L,4466L,4646L,4664L,5555L,6446L,6464L,6644L,6666L,7333L,7377L,7737L,7773L,8222L,8288L,8828L,8882L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226467Inst : IEnumerable<long>
{
public static readonly long[] Value=A226467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226467.Bytes);
public long this[int i]=>Value[i];

public static A226467Inst Instance=new A226467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226468
{
public static readonly long[] Value={ 11L,22L,33L,44L,55L,66L,77L,88L,99L,505L,550L,5005L,5050L,5500L,5555L,50005L,50050L,50500L,50555L,55000L,55055L,55505L,55550L,500005L,500050L,500500L,500555L,505000L,505055L,505505L,505550L,550000L,550055L,550505L,550550L,555005L,555050L,555500L,555555L,1111116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226468Inst : IEnumerable<long>
{
public static readonly long[] Value=A226468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226468.Bytes);
public long this[int i]=>Value[i];

public static A226468Inst Instance=new A226468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226469
{
public static readonly long[] Value={ 3L,2L,3L,8L,0L,5L,1L,1L,8L,9L,4L,5L,9L,5L,7L,4L,2L,9L,8L,2L,3L,6L,0L,0L,9L,8L,0L,9L,8L,7L,9L,7L,7L,2L,9L,0L,6L,0L,4L,5L,1L,0L,3L,3L,6L,0L,4L,8L,2L,5L,3L,8L,5L,5L,4L,1L,4L,2L,0L,3L,5L,9L,9L,4L,7L,0L,9L,8L,5L,0L,0L,7L,6L,9L,2L,5L,8L,3L,8L,0L,5L,2L,5L,7L,9L,5L,2L,2L,5L,8L,5L,8L,4L,1L,9L,7L,4L,6L,6L,1L,3L,8L,4L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226469Inst : IEnumerable<long>
{
public static readonly long[] Value=A226469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226469.Bytes);
public long this[int i]=>Value[i];

public static A226469Inst Instance=new A226469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226470
{
public static readonly long[] Value={ 0L,0L,7L,15L,26L,22L,49L,45L,100L,124L,83L,59L,222L,242L,173L,153L,392L,440L,495L,471L,322L,350L,281L,773L,876L,820L,1019L,931L,646L,762L,597L,561L,1552L,1648L,1751L,1727L,1930L,2022L,1857L,1789L,1396L,1484L,1379L,1163L,1102L,994L,3197L,3273L,3480L,3496L,3391L,3847L,4082L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226470Inst : IEnumerable<long>
{
public static readonly long[] Value=A226470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226470.Bytes);
public long this[int i]=>Value[i];

public static A226470Inst Instance=new A226470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226471
{
public static readonly long[] Value={ 0L,1L,3L,7L,15L,25L,31L,63L,113L,127L,189L,200L,255L,381L,481L,499L,511L,765L,1004L,1011L,1023L,1533L,1785L,1808L,1985L,2023L,2035L,2047L,3069L,3199L,3255L,3577L,3810L,4071L,4083L,4095L,4446L,6141L,6399L,7161L,8065L,8135L,8167L,8179L,8191L,12285L,12799L,14279L,14280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226471Inst : IEnumerable<long>
{
public static readonly long[] Value=A226471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226471.Bytes);
public long this[int i]=>Value[i];

public static A226471Inst Instance=new A226471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226472
{
public static readonly long[] Value={ 0L,1L,6L,8L,4086L,24136L,162297L,7868054L,29792904L,22666693375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226472Inst : IEnumerable<long>
{
public static readonly long[] Value=A226472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226472.Bytes);
public long this[int i]=>Value[i];

public static A226472Inst Instance=new A226472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226473
{
public static readonly long[] Value={ 109L,556L,1327L,3296L,5380L,10343L,11767L,19202L,19361L,19371L,24121L,42863L,58243L,59453L,59473L,152959L,155809L,155863L,155893L,175594L,175618L,230393L,298545L,298557L,298974L,298986L,299277L,300072L,300135L,302547L,355093L,355111L,463171L,909917L,910219L,993762L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226473Inst : IEnumerable<long>
{
public static readonly long[] Value=A226473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226473.Bytes);
public long this[int i]=>Value[i];

public static A226473Inst Instance=new A226473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226474
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226474Inst : IEnumerable<long>
{
public static readonly long[] Value=A226474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226474.Bytes);
public long this[int i]=>Value[i];

public static A226474Inst Instance=new A226474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226475
{
public static readonly long[] Value={ 75L,113L,295L,533L,686L,2130L,14805L,26966L,30235L,35095L,135653L,355675L,432996L,590138L,1214588L,2692853L,2952064L,3375195L,3486795L,5973014L,6880351L,7334956L,22266602L,25841659L,30483834L,37416582L,38390010L,40952513L,41109593L,57242145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226475Inst : IEnumerable<long>
{
public static readonly long[] Value=A226475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226475.Bytes);
public long this[int i]=>Value[i];

public static A226475Inst Instance=new A226475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226476
{
public static readonly long[] Value={ 1L,6L,24L,28L,120L,496L,672L,2016L,4320L,4680L,8128L,8190L,26208L,30240L,32760L,42336L,45864L,392448L,523776L,714240L,1571328L,2178540L,8910720L,17428320L,20427264L,23569920L,29795040L,33550336L,34369920L,45532800L,61900800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226476Inst : IEnumerable<long>
{
public static readonly long[] Value=A226476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226476.Bytes);
public long this[int i]=>Value[i];

public static A226476Inst Instance=new A226476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226477
{
public static readonly long[] Value={ 1L,3L,9L,11L,33L,99L,27L,37L,111L,333L,999L,101L,303L,909L,1111L,3333L,9999L,41L,123L,271L,369L,813L,2439L,11111L,33333L,99999L,7L,13L,21L,39L,63L,77L,91L,117L,143L,189L,231L,259L,273L,297L,351L,407L,429L,481L,693L,777L,819L,1001L,1221L,1287L,1443L,2079L,2331L,2457L,2849L,3003L,3367L,3663L,3861L,4329L,5291L,6993L,8547L,9009L,10101L,10989L,12987L,15873L,25641L,27027L,30303L,37037L,47619L,76923L,90909L,111111L,142857L,333333L,999999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226477Inst : IEnumerable<long>
{
public static readonly long[] Value=A226477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226477.Bytes);
public long this[int i]=>Value[i];

public static A226477Inst Instance=new A226477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226478
{
public static readonly long[] Value={ 1L,4L,1L,15L,1L,3L,1L,2L,57L,1L,3L,1L,2L,9L,1L,3L,1L,2L,5L,1L,2L,4L,221L,1L,3L,1L,2L,9L,1L,3L,1L,2L,5L,1L,2L,4L,29L,1L,3L,1L,2L,9L,1L,3L,1L,2L,5L,1L,2L,4L,13L,1L,3L,1L,2L,5L,1L,2L,4L,9L,1L,2L,4L,8L,869L,1L,3L,1L,2L,9L,1L,3L,1L,2L,5L,1L,2L,4L,29L,1L,3L,1L,2L,9L,1L,3L,1L,2L,5L,1L,2L,4L,13L,1L,3L,1L,2L,5L,1L,2L,4L,9L,1L,2L,4L,8L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226478Inst : IEnumerable<long>
{
public static readonly long[] Value=A226478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226478.Bytes);
public long this[int i]=>Value[i];

public static A226478Inst Instance=new A226478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226479
{
public static readonly long[] Value={ 22446139L,26116291L,28097023L,30236557L,31090489L,31124341L,39618558L,41628195L,49941589L,51777957L,61137673L,62224039L,66960589L,71096795L,71334867L,71585139L,72304400L,82266591L,83045869L,92346023L,92837591L,105183961L,114762567L,117908994L,123563821L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226479Inst : IEnumerable<long>
{
public static readonly long[] Value=A226479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226479.Bytes);
public long this[int i]=>Value[i];

public static A226479Inst Instance=new A226479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226480
{
public static readonly long[] Value={ 22446139L,26116291L,28097023L,30236557L,31090489L,31124341L,49941589L,61137673L,62224039L,66960589L,71334867L,71585139L,82266591L,83045869L,92346023L,92837591L,105183961L,114762567L,123563821L,130399138L,131494219L,134156197L,134867722L,135095767L,136026037L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226480Inst : IEnumerable<long>
{
public static readonly long[] Value=A226480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226480.Bytes);
public long this[int i]=>Value[i];

public static A226480Inst Instance=new A226480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226481
{
public static readonly long[] Value={ 1L,3L,2L,2L,1L,2L,1L,4L,2L,2L,1L,3L,1L,2L,1L,4L,1L,3L,2L,2L,1L,4L,1L,2L,1L,2L,1L,4L,2L,6L,2L,2L,1L,3L,3L,5L,1L,2L,1L,4L,1L,2L,2L,1L,3L,3L,2L,2L,1L,4L,1L,1L,4L,1L,2L,2L,1L,2L,1L,4L,2L,2L,1L,1L,4L,1L,1L,4L,2L,2L,1L,3L,3L,2L,2L,2L,2L,1L,1L,3L,1L,2L,1L,4L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226481Inst : IEnumerable<long>
{
public static readonly long[] Value=A226481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226481.Bytes);
public long this[int i]=>Value[i];

public static A226481Inst Instance=new A226481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226482
{
public static readonly long[] Value={ 1L,1L,3L,3L,5L,5L,7L,5L,7L,9L,11L,11L,13L,13L,15L,13L,13L,15L,19L,17L,17L,21L,27L,23L,21L,23L,29L,31L,27L,29L,33L,27L,29L,33L,39L,35L,35L,35L,41L,41L,33L,37L,41L,39L,45L,43L,45L,43L,45L,41L,53L,59L,51L,53L,57L,57L,55L,55L,65L,61L,59L,61L,71L,63L,55L,57L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226482Inst : IEnumerable<long>
{
public static readonly long[] Value=A226482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226482.Bytes);
public long this[int i]=>Value[i];

public static A226482Inst Instance=new A226482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226483
{
public static readonly long[] Value={ 3L,1L,6L,7L,53L,32L,11L,36L,99L,13L,42L,15L,38L,291L,71L,56L,79L,28L,68L,70L,31L,54L,235L,41L,164L,33L,277L,64L,35L,67L,86L,227L,124L,72L,81L,161L,191L,85L,83L,163L,57L,59L,84L,196L,330L,61L,159L,69L,94L,295L,465L,228L,76L,439L,186L,126L,121L,194L,198L,168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226483Inst : IEnumerable<long>
{
public static readonly long[] Value=A226483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226483.Bytes);
public long this[int i]=>Value[i];

public static A226483Inst Instance=new A226483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226484
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,11L,13L,21L,27L,33L,37L,45L,51L,61L,127L,351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226484Inst : IEnumerable<long>
{
public static readonly long[] Value=A226484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226484.Bytes);
public long this[int i]=>Value[i];

public static A226484Inst Instance=new A226484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226485
{
public static readonly long[] Value={ 2L,6L,8L,12L,14L,18L,20L,26L,30L,32L,32L,36L,42L,42L,44L,48L,50L,54L,56L,62L,68L,72L,72L,74L,78L,84L,86L,90L,92L,92L,96L,98L,102L,102L,110L,110L,114L,116L,120L,128L,132L,132L,134L,138L,140L,144L,146L,152L,152L,156L,158L,162L,162L,168L,174L,176L,182L,182L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226485Inst : IEnumerable<long>
{
public static readonly long[] Value=A226485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226485.Bytes);
public long this[int i]=>Value[i];

public static A226485Inst Instance=new A226485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226486
{
public static readonly long[] Value={ 1L,4L,5L,9L,535L,979L,46264L,59195L,73637L,77477L,99999L,467764L,8683868L,23911932L,398989893L,559555955L,769646967L,972464279L,992868299L,21348884312L,49612121694L,450197791054L,9475082805749L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226486Inst : IEnumerable<long>
{
public static readonly long[] Value=A226486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226486.Bytes);
public long this[int i]=>Value[i];

public static A226486Inst Instance=new A226486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226487
{
public static readonly long[] Value={ 7L,8L,818L,2662L,9669L,39193L,94349L,99699L,985589L,988890L,5065605L,6609066L,7193917L,7390937L,8316138L,43488434L,563303365L,799929997L,1149559411L,68088588086L,85367376358L,208532235802L,991964469199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226487Inst : IEnumerable<long>
{
public static readonly long[] Value=A226487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226487.Bytes);
public long this[int i]=>Value[i];

public static A226487Inst Instance=new A226487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226488
{
public static readonly long[] Value={ 0L,2L,17L,45L,86L,140L,207L,287L,380L,486L,605L,737L,882L,1040L,1211L,1395L,1592L,1802L,2025L,2261L,2510L,2772L,3047L,3335L,3636L,3950L,4277L,4617L,4970L,5336L,5715L,6107L,6512L,6930L,7361L,7805L,8262L,8732L,9215L,9711L,10220L,10742L,11277L,11825L,12386L,12960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226488Inst : IEnumerable<long>
{
public static readonly long[] Value=A226488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226488.Bytes);
public long this[int i]=>Value[i];

public static A226488Inst Instance=new A226488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226489
{
public static readonly long[] Value={ 0L,2L,19L,51L,98L,160L,237L,329L,436L,558L,695L,847L,1014L,1196L,1393L,1605L,1832L,2074L,2331L,2603L,2890L,3192L,3509L,3841L,4188L,4550L,4927L,5319L,5726L,6148L,6585L,7037L,7504L,7986L,8483L,8995L,9522L,10064L,10621L,11193L,11780L,12382L,12999L,13631L,14278L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226489Inst : IEnumerable<long>
{
public static readonly long[] Value=A226489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226489.Bytes);
public long this[int i]=>Value[i];

public static A226489Inst Instance=new A226489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226490
{
public static readonly long[] Value={ 0L,2L,23L,63L,122L,200L,297L,413L,548L,702L,875L,1067L,1278L,1508L,1757L,2025L,2312L,2618L,2943L,3287L,3650L,4032L,4433L,4853L,5292L,5750L,6227L,6723L,7238L,7772L,8325L,8897L,9488L,10098L,10727L,11375L,12042L,12728L,13433L,14157L,14900L,15662L,16443L,17243L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226490Inst : IEnumerable<long>
{
public static readonly long[] Value=A226490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226490.Bytes);
public long this[int i]=>Value[i];

public static A226490Inst Instance=new A226490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226491
{
public static readonly long[] Value={ 0L,2L,25L,69L,134L,220L,327L,455L,604L,774L,965L,1177L,1410L,1664L,1939L,2235L,2552L,2890L,3249L,3629L,4030L,4452L,4895L,5359L,5844L,6350L,6877L,7425L,7994L,8584L,9195L,9827L,10480L,11154L,11849L,12565L,13302L,14060L,14839L,15639L,16460L,17302L,18165L,19049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226491Inst : IEnumerable<long>
{
public static readonly long[] Value=A226491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226491.Bytes);
public long this[int i]=>Value[i];

public static A226491Inst Instance=new A226491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226492
{
public static readonly long[] Value={ 0L,3L,17L,42L,78L,125L,183L,252L,332L,423L,525L,638L,762L,897L,1043L,1200L,1368L,1547L,1737L,1938L,2150L,2373L,2607L,2852L,3108L,3375L,3653L,3942L,4242L,4553L,4875L,5208L,5552L,5907L,6273L,6650L,7038L,7437L,7847L,8268L,8700L,9143L,9597L,10062L,10538L,11025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226492Inst : IEnumerable<long>
{
public static readonly long[] Value=A226492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226492.Bytes);
public long this[int i]=>Value[i];

public static A226492Inst Instance=new A226492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226493
{
public static readonly long[] Value={ 0L,12L,24L,84L,240L,732L,2184L,6564L,19680L,59052L,177144L,531444L,1594320L,4782972L,14348904L,43046724L,129140160L,387420492L,1162261464L,3486784404L,10460353200L,31381059612L,94143178824L,282429536484L,847288609440L,2541865828332L,7625597484984L,22876792454964L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226493Inst : IEnumerable<long>
{
public static readonly long[] Value=A226493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226493.Bytes);
public long this[int i]=>Value[i];

public static A226493Inst Instance=new A226493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226494
{
public static readonly long[] Value={ 6L,10L,14L,15L,22L,26L,33L,34L,38L,46L,58L,62L,82L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226494Inst : IEnumerable<long>
{
public static readonly long[] Value=A226494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226494.Bytes);
public long this[int i]=>Value[i];

public static A226494Inst Instance=new A226494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226495
{
public static readonly long[] Value={ 2L,8L,34L,134L,615L,2813L,13415L,65162L,323858L,1626844L,8268241L,42417710L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226495Inst : IEnumerable<long>
{
public static readonly long[] Value=A226495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226495.Bytes);
public long this[int i]=>Value[i];

public static A226495Inst Instance=new A226495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226496
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,6L,9L,13L,21L,34L,50L,77L,121L,191L,292L,458L,727L,1164L,1840L,2904L,4650L,7429L,11869L,19087L,30760L,49474L,79971L,129226L,209823L,340347L,552722L,898655L,1461698L,2381041L,3883079L,6338935L,10357549L,16935173L,27712338L,45381521L,51559329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226496Inst : IEnumerable<long>
{
public static readonly long[] Value=A226496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226496.Bytes);
public long this[int i]=>Value[i];

public static A226496Inst Instance=new A226496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226497
{
public static readonly long[] Value={ 2L,6L,28L,121L,583L,2724L,13175L,64551L,322110L,1621929L,8254127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226497Inst : IEnumerable<long>
{
public static readonly long[] Value=A226497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226497.Bytes);
public long this[int i]=>Value[i];

public static A226497Inst Instance=new A226497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226498
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,5L,7L,11L,17L,28L,43L,67L,108L,173L,272L,434L,690L,1115L,1772L,2815L,4528L,7267L,11646L,18799L,30378L,48956L,79270L,128267L,208509L,338533L,550262L,895284L,1457111L,2374753L,3874445L,6327042L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226498Inst : IEnumerable<long>
{
public static readonly long[] Value=A226498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226498.Bytes);
public long this[int i]=>Value[i];

public static A226498Inst Instance=new A226498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226499
{
public static readonly long[] Value={ 0L,1L,6L,4851L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226499Inst : IEnumerable<long>
{
public static readonly long[] Value=A226499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226499.Bytes);
public long this[int i]=>Value[i];

public static A226499Inst Instance=new A226499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226500
{
public static readonly BigInteger[] Value={ 0L,3L,300L,29403L,2881200L,282328203L,27665282700L,2710915376403L,265642041604800L,26030209161894003L,2550694855824007500L,BigInteger.Parse("249942065661590841003"),BigInteger.Parse("24491771739980078410800"),BigInteger.Parse("2399943688452386093417403"),BigInteger.Parse("235169989696593857076494700"),BigInteger.Parse("23044259046577745607403063203") };
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
public class A226500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226500Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A226500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226500.Bytes);
public BigInteger this[int i]=>Value[i];

public static A226500Inst Instance=new A226500Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226501
{
public static readonly long[] Value={ 25200L,97020L,145530L,499500L,673380L,749700L,839160L,1185030L,1445850L,1786995L,1873080L,2031120L,2049300L,2162160L,2821500L,3444000L,3646350L,4250070L,4573800L,4915680L,4991220L,5364450L,5512860L,6193440L,11594520L,11763675L,12748725L,13857480L,14340690L,15481830L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226501Inst : IEnumerable<long>
{
public static readonly long[] Value=A226501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226501.Bytes);
public long this[int i]=>Value[i];

public static A226501Inst Instance=new A226501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226502
{
public static readonly long[] Value={ 11L,34L,36L,96L,60L,144L,160L,162L,360L,198L,320L,336L,352L,494L,460L,720L,378L,560L,718L,450L,972L,1020L,938L,1002L,816L,420L,864L,1752L,960L,2596L,810L,2204L,576L,2404L,1220L,1606L,1980L,1694L,1420L,2876L,744L,2694L,780L,3160L,2810L,3520L,3170L,1824L,1840L,1422L,3836L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226502Inst : IEnumerable<long>
{
public static readonly long[] Value=A226502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226502.Bytes);
public long this[int i]=>Value[i];

public static A226502Inst Instance=new A226502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226503
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,2L,3L,3L,4L,5L,5L,7L,8L,9L,12L,13L,16L,20L,22L,28L,33L,38L,48L,55L,66L,81L,93L,114L,136L,159L,195L,229L,273L,331L,388L,468L,560L,661L,799L,948L,1129L,1359L,1609L,1928L,2307L,2738L,3287L,3916L,4666L,5594L,6654L,7953L,9510L,11320L,13547L,16164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226503Inst : IEnumerable<long>
{
public static readonly long[] Value=A226503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226503.Bytes);
public long this[int i]=>Value[i];

public static A226503Inst Instance=new A226503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226504
{
public static readonly long[] Value={ 1L,1L,2L,4L,1L,8L,4L,3L,16L,12L,13L,9L,2L,32L,32L,42L,42L,35L,12L,8L,64L,80L,120L,145L,159L,133L,86L,52L,32L,6L,128L,192L,320L,440L,559L,600L,591L,440L,380L,248L,164L,48L,30L,256L,448L,816L,1240L,1745L,2154L,2503L,2529L,2358L,2112L,1828L,1314L,944L,468L,258L,150L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226504Inst : IEnumerable<long>
{
public static readonly long[] Value=A226504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226504.Bytes);
public long this[int i]=>Value[i];

public static A226504Inst Instance=new A226504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226505
{
public static readonly long[] Value={ 1L,1L,2L,5L,14L,1L,42L,9L,1L,132L,55L,14L,2L,429L,286L,120L,35L,6L,1L,1430L,1365L,819L,364L,119L,35L,7L,1L,4862L,6188L,4900L,2940L,1394L,586L,203L,59L,13L,2L,16796L,27132L,26928L,20400L,12576L,6846L,3246L,1358L,493L,153L,38L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226505Inst : IEnumerable<long>
{
public static readonly long[] Value=A226505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226505.Bytes);
public long this[int i]=>Value[i];

public static A226505Inst Instance=new A226505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226506
{
public static readonly BigInteger[] Value={ 0L,0L,2L,12L,62L,320L,1712L,9604L,56674L,351792L,2293862L,15682216L,112179608L,837905016L,6522165834L,52807401908L,443962338894L,3869376656384L,34908008426360L,325530083655692L,3133830448212442L,31106728455899128L,318009567467999574L,3344865730200667832L,BigInteger.Parse("36161434396223563504") };
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
public class A226506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226506Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A226506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226506.Bytes);
public BigInteger this[int i]=>Value[i];

public static A226506Inst Instance=new A226506Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226507
{
public static readonly BigInteger[] Value={ 0L,0L,0L,1L,16L,177L,1726L,15912L,143148L,1279939L,11504326L,104686659L,968808308L,9144180028L,88184565504L,869867691833L,8781919559956L,90765497635245L,960434143555986L,10403548856756708L,115336464546432180L,1308260884070774299L,15177980646442995698UL,BigInteger.Parse("180036437138753006607"),BigInteger.Parse("2182526416321158803528") };
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
public class A226507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226507Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A226507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226507.Bytes);
public BigInteger this[int i]=>Value[i];

public static A226507Inst Instance=new A226507Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226508
{
public static readonly long[] Value={ 3L,33L,315L,2889L,26163L,235953L,2125035L,19129689L,172180323L,1549662273L,13947078555L,125524061289L,1129717614483L,10167461718993L,91507165036875L,823564514029689L,7412080712360643L,66708726669526113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226508Inst : IEnumerable<long>
{
public static readonly long[] Value=A226508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226508.Bytes);
public long this[int i]=>Value[i];

public static A226508Inst Instance=new A226508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226509
{
public static readonly long[] Value={ 3L,3L,3L,8L,9L,12L,16L,23L,29L,41L,56L,79L,110L,158L,225L,325L,469L,682L,991L,1446L,2110L,3085L,4511L,6603L,9666L,14157L,20736L,30380L,44511L,65223L,95575L,140060L,205253L,300800L,440828L,646051L,946817L,1387613L,2033628L,2980411L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226509Inst : IEnumerable<long>
{
public static readonly long[] Value=A226509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226509.Bytes);
public long this[int i]=>Value[i];

public static A226509Inst Instance=new A226509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226510
{
public static readonly long[] Value={ 1L,1L,2L,6L,20L,66L,221L,757L,2647L,9402L,33813L,122876L,450543L,1664835L,6193553L,23178525L,87199503L,329592705L,1251029482L,4766563155L,18223733493L,69892469057L,268824143700L,1036690445777L,4007586822784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226510Inst : IEnumerable<long>
{
public static readonly long[] Value=A226510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226510.Bytes);
public long this[int i]=>Value[i];

public static A226510Inst Instance=new A226510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226511
{
public static readonly long[] Value={ 0L,3L,24L,147L,816L,4323L,22344L,113907L,576096L,2900163L,14559864L,72976467L,365413776L,1828663203L,9148098984L,45754843827L,228817265856L,1144215469443L,5721464767704L,28608486099987L,143045917284336L,715240046774883L,3576231614934024L,17881252217848947L,89406543518781216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226511Inst : IEnumerable<long>
{
public static readonly long[] Value=A226511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226511.Bytes);
public long this[int i]=>Value[i];

public static A226511Inst Instance=new A226511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226512
{
public static readonly long[] Value={ 1L,3L,7L,7L,21L,13L,43L,15L,25L,31L,111L,31L,157L,57L,147L,31L,273L,43L,343L,71L,85L,133L,507L,67L,121L,183L,79L,157L,813L,177L,931L,63L,777L,307L,903L,111L,1333L,381L,235L,163L,1641L,183L,1807L,377L,525L,553L,2163L,127L,337L,171L,1911L,287L,2757L,133L,331L,351L,457L,871L,3423L,211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226512Inst : IEnumerable<long>
{
public static readonly long[] Value=A226512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226512.Bytes);
public long this[int i]=>Value[i];

public static A226512Inst Instance=new A226512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226513
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,1L,3L,8L,13L,1L,4L,15L,44L,75L,1L,5L,24L,99L,308L,541L,1L,6L,35L,184L,807L,2612L,4683L,1L,7L,48L,305L,1704L,7803L,25988L,47293L,1L,8L,63L,468L,3155L,18424L,87135L,296564L,545835L,1L,9L,80L,679L,5340L,37625L,227304L,1102419L,3816548L,7087261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226513Inst : IEnumerable<long>
{
public static readonly long[] Value=A226513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226513.Bytes);
public long this[int i]=>Value[i];

public static A226513Inst Instance=new A226513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226514
{
public static readonly long[] Value={ 13L,44L,99L,184L,305L,468L,679L,944L,1269L,1660L,2123L,2664L,3289L,4004L,4815L,5728L,6749L,7884L,9139L,10520L,12033L,13684L,15479L,17424L,19525L,21788L,24219L,26824L,29609L,32580L,35743L,39104L,42669L,46444L,50435L,54648L,59089L,63764L,68679L,73840L,79253L,84924L,90859L,97064L,103545L,110308L,117359L,124704L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226514Inst : IEnumerable<long>
{
public static readonly long[] Value=A226514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226514.Bytes);
public long this[int i]=>Value[i];

public static A226514Inst Instance=new A226514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226515
{
public static readonly BigInteger[] Value={ 1L,3L,15L,99L,807L,7803L,87135L,1102419L,15575127L,242943723L,4145495055L,76797289539L,1534762643847L,32907617073243L,753473367606975L,18347287182129459L,473409784213526967L,12902366605394652363UL,BigInteger.Parse("370357953441110390895"),BigInteger.Parse("11167936445234485414179") };
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
public class A226515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226515Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A226515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226515.Bytes);
public BigInteger this[int i]=>Value[i];

public static A226515Inst Instance=new A226515Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226516
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,2L,3L,3L,4L,4L,6L,5L,8L,6L,10L,8L,13L,11L,17L,15L,23L,20L,31L,26L,41L,34L,54L,45L,71L,60L,94L,80L,125L,106L,166L,140L,220L,185L,291L,245L,385L,325L,510L,431L,676L,571L,896L,756L,1187L,1001L,1572L,1326L,2082L,1757L,2758L,2328L,3654L,3084L,4841L,4085L,6413L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226516Inst : IEnumerable<long>
{
public static readonly long[] Value=A226516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226516.Bytes);
public long this[int i]=>Value[i];

public static A226516Inst Instance=new A226516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226517
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,1L,1L,2L,1L,2L,1L,3L,2L,4L,3L,6L,4L,8L,5L,11L,7L,15L,10L,21L,14L,29L,19L,40L,26L,55L,36L,76L,50L,105L,69L,145L,95L,200L,131L,276L,181L,381L,250L,526L,345L,726L,476L,1002L,657L,1383L,907L,1909L,1252L,2635L,1728L,3637L,2385L,5020L,3292L,6929L,4544L,9564L,6272L,13201L,8657L,18221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226517Inst : IEnumerable<long>
{
public static readonly long[] Value=A226517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226517.Bytes);
public long this[int i]=>Value[i];

public static A226517Inst Instance=new A226517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226518
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,0L,1L,0L,-1L,0L,0L,1L,2L,1L,2L,1L,0L,0L,1L,0L,1L,2L,3L,2L,1L,0L,1L,0L,0L,1L,0L,1L,2L,1L,0L,-1L,-2L,-1L,0L,-1L,0L,0L,1L,2L,1L,2L,1L,0L,-1L,0L,1L,0L,-1L,-2L,-1L,-2L,-1L,0L,0L,1L,0L,-1L,0L,1L,2L,3L,2L,3L,2L,3L,2L,1L,0L,-1L,0L,1L,0L,0L,1L,2L,3L,4L,3L,4L,3L,4L,5L,4L,3L,4L,5L,4L,3L,4L,3L,4L,3L,2L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226518Inst : IEnumerable<long>
{
public static readonly long[] Value=A226518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226518.Bytes);
public long this[int i]=>Value[i];

public static A226518Inst Instance=new A226518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226519
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,-1L,0L,1L,2L,1L,2L,1L,0L,1L,0L,1L,2L,3L,2L,1L,0L,1L,0L,1L,0L,1L,2L,1L,0L,-1L,-2L,-1L,0L,-1L,0L,1L,2L,1L,2L,1L,0L,-1L,0L,1L,0L,-1L,-2L,-1L,-2L,-1L,0L,1L,0L,-1L,0L,1L,2L,3L,2L,3L,2L,3L,2L,1L,0L,-1L,0L,1L,0L,1L,2L,3L,4L,3L,4L,3L,4L,5L,4L,3L,4L,5L,4L,3L,4L,3L,4L,3L,2L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226519Inst : IEnumerable<long>
{
public static readonly long[] Value=A226519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226519.Bytes);
public long this[int i]=>Value[i];

public static A226519Inst Instance=new A226519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226520
{
public static readonly long[] Value={ 0L,1L,0L,1L,-1L,0L,1L,-1L,-1L,1L,0L,1L,1L,-1L,1L,-1L,-1L,0L,1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,-1L,0L,1L,-1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,-1L,1L,0L,1L,1L,-1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,-1L,1L,-1L,1L,1L,0L,1L,-1L,-1L,1L,1L,1L,1L,-1L,1L,-1L,1L,-1L,-1L,-1L,-1L,1L,1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226520Inst : IEnumerable<long>
{
public static readonly long[] Value=A226520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226520.Bytes);
public long this[int i]=>Value[i];

public static A226520Inst Instance=new A226520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226521
{
public static readonly long[] Value={ 3L,7L,2L,5L,0L,3L,11L,2L,3L,19L,7L,0L,0L,0L,5L,29L,2L,3L,11L,5L,13L,17L,0L,3L,0L,5L,0L,7L,19L,2L,0L,13L,5L,0L,7L,17L,11L,0L,3L,0L,0L,0L,7L,0L,19L,23L,2L,3L,37L,5L,17L,7L,19L,31L,43L,13L,0L,0L,0L,5L,0L,7L,0L,0L,0L,11L,53L,2L,3L,17L,5L,19L,7L,47L,61L,23L,11L,103L,29L,0L,3L,0L,5L,0L,0L,0L,23L,0L,11L,0L,13L,31L,2L,0L,19L,0L,0L,7L,23L,0L,0L,11L,0L,13L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226521Inst : IEnumerable<long>
{
public static readonly long[] Value=A226521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226521.Bytes);
public long this[int i]=>Value[i];

public static A226521Inst Instance=new A226521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226522
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,3L,7L,1L,3L,7L,1L,3L,7L,13L,1L,3L,7L,15L,22L,1L,3L,7L,15L,24L,37L,1L,3L,7L,15L,26L,39L,1L,3L,7L,15L,29L,42L,63L,1L,3L,7L,15L,29L,46L,69L,91L,1L,3L,7L,15L,29L,51L,75L,108L,133L,1L,3L,7L,15L,29L,57L,82L,123L,156L,197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226522Inst : IEnumerable<long>
{
public static readonly long[] Value=A226522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226522.Bytes);
public long this[int i]=>Value[i];

public static A226522Inst Instance=new A226522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226523
{
public static readonly long[] Value={ 0L,-1L,-1L,1L,-1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,-1L,-1L,-1L,1L,1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,-1L,-1L,1L,-1L,-1L,-1L,1L,1L,-1L,1L,-1L,1L,-1L,-1L,1L,1L,1L,-1L,1L,1L,-1L,1L,-1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,1L,1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226523Inst : IEnumerable<long>
{
public static readonly long[] Value=A226523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226523.Bytes);
public long this[int i]=>Value[i];

public static A226523Inst Instance=new A226523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226524
{
public static readonly long[] Value={ 8L,216L,21952L,74088L,373248L,4251528L,5268024L,10648000L,10941048L,12812904L,14886936L,16003008L,25934336L,40707584L,54872000L,59319000L,114791256L,132651000L,199176704L,209584584L,259694072L,269586136L,306182024L,345948408L,373248000L,543338496L,567663552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226524Inst : IEnumerable<long>
{
public static readonly long[] Value=A226524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226524.Bytes);
public long this[int i]=>Value[i];

public static A226524Inst Instance=new A226524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226525
{
public static readonly long[] Value={ 2L,2L,2L,5L,2L,3L,2L,7L,3L,19L,11L,3L,23L,5L,61L,29L,31L,3L,29L,31L,13L,19L,5L,7L,23L,47L,3L,53L,47L,19L,13L,7L,41L,53L,2L,43L,7L,103L,2L,61L,59L,71L,17L,59L,79L,43L,167L,71L,97L,7L,151L,37L,103L,83L,127L,103L,11L,53L,29L,7L,67L,83L,151L,107L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226525Inst : IEnumerable<long>
{
public static readonly long[] Value=A226525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226525.Bytes);
public long this[int i]=>Value[i];

public static A226525Inst Instance=new A226525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226526
{
public static readonly BigInteger[] Value={ 4L,6L,9L,10L,14L,15L,21L,22L,25L,26L,33L,34L,35L,38L,39L,46L,69L,1497L,259465L,4852747709L,3429487924785490781L,BigInteger.Parse("305153651313989042415043589313598477"),BigInteger.Parse("21932475414742921908206321699222250910796483151080020353252738457741771") };
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
public class A226526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226526Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A226526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226526.Bytes);
public BigInteger this[int i]=>Value[i];

public static A226526Inst Instance=new A226526Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226527
{
public static readonly BigInteger[] Value={ 8L,12L,18L,20L,27L,28L,30L,42L,44L,45L,50L,52L,63L,66L,68L,70L,75L,76L,78L,92L,98L,99L,102L,105L,110L,114L,116L,117L,124L,125L,130L,138L,147L,148L,153L,154L,164L,165L,170L,171L,172L,174L,175L,182L,186L,188L,190L,195L,207L,212L,222L,230L,231L,236L,238L,242L,244L,245L,246L,255L,258L,261L,266L,268L,273L,275L,279L,282L,284L,285L,286L,290L,292L,310L,316L,318L,322L,325L,332L,333L,338L,343L,345L,354L,356L,357L,363L,366L,369L,370L,374L,385L,387L,388L,399L,402L,404L,406L,410L,412L,418L,423L,425L,426L,428L,429L,430L,434L,435L,436L,8662L,44335708L,1251938572491943L,BigInteger.Parse("1505273212784203338150808798466"),BigInteger.Parse("680617602541158152398258079780439819108542271775727566330763") };
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
public class A226527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226527Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A226527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226527.Bytes);
public BigInteger this[int i]=>Value[i];

public static A226527Inst Instance=new A226527Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226528
{
public static readonly long[] Value={ 1L,30406L,71852L,85654L,111850L,126308L,134492L,144642L,147942L,150152L,165894L,176206L,180924L,201170L,212724L,222764L,225174L,241600L,241860L,248744L,268032L,270674L,302368L,316970L,326260L,347962L,350830L,397468L,410938L,416010L,424584L,425848L,426338L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226528Inst : IEnumerable<long>
{
public static readonly long[] Value=A226528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226528.Bytes);
public long this[int i]=>Value[i];

public static A226528Inst Instance=new A226528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226529
{
public static readonly long[] Value={ 1L,67234L,101830L,114024L,133858L,162192L,165306L,210714L,216968L,229310L,232798L,422666L,426690L,449732L,462470L,468144L,498904L,506664L,509622L,528614L,572934L,581424L,638980L,641762L,656210L,698480L,704930L,730352L,795810L,840796L,908086L,975248L,976914L,990908L,1007874L,1037748L,1039970L,1067896L,1082054L,1097352L,1102754L,1132526L,1162996L,1171010L,1177808L,1181388L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226529Inst : IEnumerable<long>
{
public static readonly long[] Value=A226529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226529.Bytes);
public long this[int i]=>Value[i];

public static A226529Inst Instance=new A226529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226530
{
public static readonly long[] Value={ 1L,70906L,167176L,204462L,249830L,321164L,330716L,332554L,429370L,499310L,524552L,553602L,743788L,825324L,831648L,855124L,999236L,1041870L,1074542L,1096382L,1113768L,1161054L,1167528L,1169486L,1171824L,1210354L,1217284L,1277444L,1519380L,1755378L,1909372L,1922592L,1986700L,2034902L,2147196L,2167350L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226530Inst : IEnumerable<long>
{
public static readonly long[] Value=A226530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226530.Bytes);
public long this[int i]=>Value[i];

public static A226530Inst Instance=new A226530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226531
{
public static readonly long[] Value={ 27L,3375L,4096L,4913L,35937L,97336L,110592L,148877L,421875L,681472L,1191016L,1442897L,1560896L,2628072L,3241792L,3581577L,3869893L,4741632L,5359375L,8998912L,10218313L,12649337L,16777216L,16974593L,21253933L,26730899L,31255875L,32157432L,43986977L,45882712L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226531Inst : IEnumerable<long>
{
public static readonly long[] Value=A226531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226531.Bytes);
public long this[int i]=>Value[i];

public static A226531Inst Instance=new A226531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226532
{
public static readonly long[] Value={ 1L,2L,6L,4L,30L,3L,210L,8L,36L,15L,2310L,24L,30030L,105L,5L,16L,510510L,72L,9699690L,120L,35L,1155L,223092870L,12L,900L,15015L,216L,840L,6469693230L,10L,200560490130L,32L,385L,255255L,7L,9L,7420738134810L,4849845L,5005L,60L,304250263527210L,70L,13082761331670030L,9240L,1080L,111546435L,614889782588491410L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226532Inst : IEnumerable<long>
{
public static readonly long[] Value=A226532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226532.Bytes);
public long this[int i]=>Value[i];

public static A226532Inst Instance=new A226532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226533
{
public static readonly long[] Value={ 5L,6L,2L,150L,22L,82L,2L,258L,70L,30L,42L,18L,2L,12L,262L,58L,460L,36L,552L,24L,318L,344L,450L,54L,274L,88L,36L,92L,90L,188L,554L,20L,404L,700L,240L,6L,136L,262L,578L,222L,2182L,276L,162L,60L,142L,326L,176L,198L,930L,1116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226533Inst : IEnumerable<long>
{
public static readonly long[] Value=A226533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226533.Bytes);
public long this[int i]=>Value[i];

public static A226533Inst Instance=new A226533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226534
{
public static readonly long[] Value={ 0L,1L,2L,2L,2L,4L,2L,1L,2L,2L,4L,2L,2L,4L,1L,6L,2L,1L,2L,2L,4L,1L,3L,5L,2L,2L,4L,2L,1L,14L,2L,1L,2L,1L,2L,6L,4L,4L,3L,1L,2L,8L,2L,4L,2L,6L,4L,4L,2L,1L,2L,2L,7L,3L,1L,6L,2L,1L,2L,2L,3L,14L,2L,2L,4L,2L,2L,1L,2L,1L,4L,5L,4L,2L,1L,1L,2L,2L,8L,2L,2L,4L,2L,3L,1L,2L,5L,2L,2L,4L,9L,2L,2L,8L,1L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226534Inst : IEnumerable<long>
{
public static readonly long[] Value=A226534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226534.Bytes);
public long this[int i]=>Value[i];

public static A226534Inst Instance=new A226534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226535
{
public static readonly long[] Value={ 1L,3L,0L,-6L,-3L,0L,0L,6L,0L,-6L,0L,0L,6L,6L,0L,0L,-3L,0L,0L,6L,0L,-12L,0L,0L,0L,3L,0L,-6L,-6L,0L,0L,6L,0L,0L,0L,0L,6L,6L,0L,-12L,0L,0L,0L,6L,0L,0L,0L,0L,6L,9L,0L,0L,-6L,0L,0L,0L,0L,-12L,0L,0L,0L,6L,0L,-12L,-3L,0L,0L,6L,0L,0L,0L,0L,0L,6L,0L,-6L,-6L,0L,0L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226535Inst : IEnumerable<long>
{
public static readonly long[] Value=A226535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226535.Bytes);
public long this[int i]=>Value[i];

public static A226535Inst Instance=new A226535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226536
{
public static readonly long[] Value={ 828L,18281L,818L,28182L,8281828L,828L,353L,747L,66L,2662L,77L,757L,99L,999L,99L,959L,595L,66L,9669L,696L,676L,77L,2772L,66L,303L,353L,535L,525L,66L,66L,919L,39193L,0L,30L,99L,181L,66L,0L,33L,595L,323L,232L,434L,94349L,323L,33L,88L,525L,101L,11L,383L,70L,99L,88L,4884L,44L,606L,66L,808L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226536Inst : IEnumerable<long>
{
public static readonly long[] Value=A226536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226536.Bytes);
public long this[int i]=>Value[i];

public static A226536Inst Instance=new A226536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226537
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,32L,34L,37L,42L,43L,48L,53L,61L,67L,77L,82L,208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226537Inst : IEnumerable<long>
{
public static readonly long[] Value=A226537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226537.Bytes);
public long this[int i]=>Value[i];

public static A226537Inst Instance=new A226537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226538
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,6L,7L,11L,12L,19L,20L,32L,33L,53L,54L,87L,88L,142L,143L,231L,232L,375L,376L,608L,609L,985L,986L,1595L,1596L,2582L,2583L,4179L,4180L,6763L,6764L,10944L,10945L,17709L,17710L,28655L,28656L,46366L,46367L,75023L,75024L,121391L,121392L,196416L,196417L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226538Inst : IEnumerable<long>
{
public static readonly long[] Value=A226538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226538.Bytes);
public long this[int i]=>Value[i];

public static A226538Inst Instance=new A226538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226539
{
public static readonly long[] Value={ 338L,410L,578L,650L,890L,1010L,1130L,1490L,1730L,1802L,1898L,1970L,2330L,2378L,2738L,3050L,3170L,3530L,3650L,3842L,3890L,4010L,4658L,4850L,5018L,5090L,5162L,5402L,5450L,5570L,5618L,5690L,5858L,6170L,6410L,6530L,6698L,7010L,7178L,7202L,7250L,7850L,7970L,8090L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226539Inst : IEnumerable<long>
{
public static readonly long[] Value=A226539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226539.Bytes);
public long this[int i]=>Value[i];

public static A226539Inst Instance=new A226539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226540
{
public static readonly long[] Value={ 1L,3L,5L,5L,7L,14L,18L,15L,11L,33L,39L,13L,35L,60L,68L,51L,57L,95L,105L,77L,23L,138L,150L,65L,117L,189L,203L,145L,155L,248L,264L,187L,119L,315L,333L,37L,247L,390L,410L,287L,301L,473L,495L,345L,47L,564L,588L,245L,425L,663L,689L,477L,495L,770L,798L,551L,59L,885L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226540Inst : IEnumerable<long>
{
public static readonly long[] Value=A226540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226540.Bytes);
public long this[int i]=>Value[i];

public static A226540Inst Instance=new A226540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226541
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,1L,2L,3L,5L,7L,11L,16L,24L,34L,51L,71L,102L,143L,201L,276L,384L,522L,714L,964L,1301L,1739L,2328L,3084L,4085L,5377L,7064L,9226L,12036L,15616L,20228L,26092L,33584L,43067L,55125L,70308L,89502L,113598L,143889L,181755L,229160L,288186L,361750L,453046L,566346L,706464L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226541Inst : IEnumerable<long>
{
public static readonly long[] Value=A226541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226541.Bytes);
public long this[int i]=>Value[i];

public static A226541Inst Instance=new A226541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226542
{
public static readonly long[] Value={ 11L,19L,37L,43L,67L,103L,131L,137L,199L,239L,293L,331L,397L,439L,463L,521L,547L,661L,683L,727L,859L,911L,991L,1033L,1093L,1171L,1291L,1301L,1543L,1549L,1951L,2053L,2081L,2341L,2731L,2861L,3079L,3121L,3251L,3511L,3613L,3823L,4099L,4129L,4229L,4903L,5419L,6151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226542Inst : IEnumerable<long>
{
public static readonly long[] Value=A226542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226542.Bytes);
public long this[int i]=>Value[i];

public static A226542Inst Instance=new A226542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226543
{
public static readonly BigInteger[] Value={ 1L,1L,55L,595L,11012L,168925L,2760690L,44159095L,711479843L,11435477118L,183947396032L,2958142131138L,47575298963072L,765124447990418L,12305134306097753L,197897152964385186L,3182680323964197938L,BigInteger.Parse("51185438892782012288"),BigInteger.Parse("823189555932846017125") };
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
public class A226543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226543Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A226543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226543.Bytes);
public BigInteger this[int i]=>Value[i];

public static A226543Inst Instance=new A226543Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226544
{
public static readonly BigInteger[] Value={ 1L,1L,89L,1278L,33636L,715072L,16350693L,364647622L,8201909757L,183947396032L,4129523869606L,92675094208964L,2080048909984067L,46684042670495080L,1047776070980376086L,BigInteger.Parse("23516183336037445861"),BigInteger.Parse("527795545850035568780"),BigInteger.Parse("11845801476106616135344") };
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
public class A226544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226544Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A226544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226544.Bytes);
public BigInteger this[int i]=>Value[i];

public static A226544Inst Instance=new A226544Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226545
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,2L,2L,0L,0L,3L,5L,3L,0L,0L,4L,12L,12L,4L,0L,0L,5L,25L,34L,25L,5L,0L,0L,6L,50L,98L,98L,50L,6L,0L,0L,7L,96L,256L,386L,256L,96L,7L,0L,0L,8L,180L,654L,1402L,1402L,654L,180L,8L,0L,0L,9L,331L,1625L,4938L,6940L,4938L,1625L,331L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226545Inst : IEnumerable<long>
{
public static readonly long[] Value=A226545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226545.Bytes);
public long this[int i]=>Value[i];

public static A226545Inst Instance=new A226545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226546
{
public static readonly long[] Value={ 0L,3L,12L,34L,98L,256L,654L,1625L,3964L,9533L,22662L,53373L,124728L,289572L,668514L,1535869L,3513614L,8008090L,18191184L,41200568L,93064834L,209710139L,471520566L,1058065647L,2369890254L,5299215579L,11830941840L,26375563624L,58722396932L,130576680919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226546Inst : IEnumerable<long>
{
public static readonly long[] Value=A226546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226546.Bytes);
public long this[int i]=>Value[i];

public static A226546Inst Instance=new A226546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226547
{
public static readonly long[] Value={ 0L,4L,25L,98L,386L,1402L,4938L,16936L,57020L,189172L,620397L,2015456L,6496391L,20801576L,66231279L,209847980L,662049349L,2080850248L,6518383898L,20358327362L,63413001935L,197042859318L,610922240964L,1890331512546L,5838350817615L,18001432735438L,55417333344241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226547Inst : IEnumerable<long>
{
public static readonly long[] Value=A226547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226547.Bytes);
public long this[int i]=>Value[i];

public static A226547Inst Instance=new A226547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226548
{
public static readonly long[] Value={ 0L,5L,50L,256L,1402L,6940L,33502L,157279L,725080L,3293575L,14789640L,65785991L,290341336L,1272947979L,5549535668L,24075671345L,104002776564L,447586575256L,1919810662952L,8210002538205L,35015688030978L,148980204943747L,632466650426456L,2679623444793841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226548Inst : IEnumerable<long>
{
public static readonly long[] Value=A226548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226548.Bytes);
public long this[int i]=>Value[i];

public static A226548Inst Instance=new A226548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226549
{
public static readonly long[] Value={ 0L,6L,96L,654L,4938L,33502L,221672L,1426734L,9014839L,56128696L,345447208L,2106033948L,12739126739L,76548375758L,457375097789L,2719454021744L,16100269337597L,94961606031670L,558226473615469L,3271710478901046L,19123726111508773L,111510459865449832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226549Inst : IEnumerable<long>
{
public static readonly long[] Value=A226549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226549.Bytes);
public long this[int i]=>Value[i];

public static A226549Inst Instance=new A226549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226550
{
public static readonly ulong[] Value={ 0L,7L,180L,1625L,16936L,157279L,1426734L,12582472L,108971358L,929801662L,7842704798L,65526395993L,543197940936L,4473218574611L,36628689696182L,298465716569236L,2421637058537566L,19574314969125483L,157692516088571216L,1266593481935599039L,10146033357194978996UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226550Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A226550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226550.Bytes);
public ulong this[int i]=>Value[i];

public static A226550Inst Instance=new A226550Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226551
{
public static readonly BigInteger[] Value={ 0L,8L,331L,3964L,57020L,725080L,9014839L,108971358L,1293374998L,15124830042L,174840029210L,2002005705582L,22744617716405L,256690848493684L,2880580641585200L,32167728035568302L,357685528356070536L,3962274174725426092L,BigInteger.Parse("43745566808355289539"),BigInteger.Parse("481531500069734159312") };
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
public class A226551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226551Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A226551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226551.Bytes);
public BigInteger this[int i]=>Value[i];

public static A226551Inst Instance=new A226551Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226552
{
public static readonly BigInteger[] Value={ 0L,9L,600L,9533L,189172L,3293575L,56128696L,929801662L,15124830042L,242394178200L,3840094402532L,60260456120659L,938232581234924L,14511287055938491L,223171309100257664L,3415393756038359269L,BigInteger.Parse("52045507693324954598"),BigInteger.Parse("790109733965301854764"),BigInteger.Parse("11954668671384269574304") };
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
public class A226552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226552Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A226552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226552.Bytes);
public BigInteger this[int i]=>Value[i];

public static A226552Inst Instance=new A226552Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226553
{
public static readonly BigInteger[] Value={ 0L,10L,1075L,22662L,620397L,14789640L,345447208L,7842704798L,174840029210L,3840094402532L,83374069529638L,1793032417310974L,38258855867496327L,810946250319425068L,17091823996687603541UL,BigInteger.Parse("358471079107730527328"),BigInteger.Parse("7486164704687228583214"),BigInteger.Parse("155749229838447601172926") };
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
public class A226553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226553Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A226553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226553.Bytes);
public BigInteger this[int i]=>Value[i];

public static A226553Inst Instance=new A226553Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226554
{
public static readonly BigInteger[] Value={ 0L,1L,5L,34L,386L,6940L,221672L,12582472L,1293374998L,242394178200L,83374069529638L,52845726291860344L,BigInteger.Parse("61928161880183204434"),BigInteger.Parse("134499571879749571406816"),BigInteger.Parse("542432658409586214809714176"),BigInteger.Parse("4068438590479352629770422328000"),BigInteger.Parse("56820656114941381799512710314429768") };
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
public class A226554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226554Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A226554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226554.Bytes);
public BigInteger this[int i]=>Value[i];

public static A226554Inst Instance=new A226554Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226555
{
public static readonly long[] Value={ 1L,5L,4L,13L,7L,25L,10L,33L,17L,45L,16L,69L,19L,65L,38L,81L,25L,109L,28L,125L,55L,105L,34L,177L,53L,125L,68L,181L,43L,241L,46L,193L,89L,165L,100L,301L,55L,185L,106L,321L,61L,349L,64L,293L,167L,225L,70L,433L,109L,341L,140L,349L,79L,433L,162L,465L,157L,285L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226555Inst : IEnumerable<long>
{
public static readonly long[] Value=A226555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226555.Bytes);
public long this[int i]=>Value[i];

public static A226555Inst Instance=new A226555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226556
{
public static readonly long[] Value={ 1L,1L,1L,0L,-1L,-1L,-1L,-1L,0L,1L,2L,3L,2L,0L,-2L,-4L,-4L,-3L,-1L,3L,6L,7L,5L,0L,-5L,-9L,-10L,-7L,-1L,7L,14L,16L,11L,1L,-11L,-20L,-22L,-16L,-2L,15L,29L,33L,23L,2L,-23L,-41L,-45L,-32L,-4L,30L,57L,64L,45L,4L,-43L,-78L,-86L,-60L,-7L,57L,107L,119L,83L,8L,-79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226556Inst : IEnumerable<long>
{
public static readonly long[] Value=A226556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226556.Bytes);
public long this[int i]=>Value[i];

public static A226556Inst Instance=new A226556Inst();

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