using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A208457
{
public static readonly long[] Value={ 0L,1L,-1L,-2L,0L,3L,2L,-4L,0L,5L,-1L,-8L,0L,7L,4L,-8L,0L,9L,-8L,-10L,0L,14L,6L,-12L,0L,16L,-6L,-14L,0L,15L,8L,-20L,0L,17L,-14L,-18L,0L,19L,10L,-24L,0L,26L,-1L,-22L,0L,23L,16L,-28L,0L,25L,-20L,-32L,0L,32L,14L,-28L,0L,29L,-12L,-30L,0L,38L,16L,-32L,0L,33L,-31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208457Inst : IEnumerable<long>
{
public static readonly long[] Value=A208457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208457.Bytes);
public long this[int i]=>Value[i];

public static A208457Inst Instance=new A208457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208458
{
public static readonly BigInteger[] Value={ 1L,22L,353L,5656L,90496L,1447939L,23167027L,370672441L,5930759064L,94892145032L,1518274320519L,24292389128308L,388678226052937L,6218851616847000L,99501625869552009L,1592026013912832148L,BigInteger.Parse("25472416222605314376"),BigInteger.Parse("407558659561685030020"),BigInteger.Parse("6520938552986960480328") };
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
public class A208458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208458Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208458.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208458.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208458Inst Instance=new A208458Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208459
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,1L,0L,1L,0L,-1L,0L,1L,0L,1L,2L,0L,1L,0L,2L,0L,-3L,0L,1L,0L,3L,-1L,0L,5L,0L,1L,0L,4L,-2L,3L,2L,-8L,0L,1L,0L,5L,-3L,7L,-2L,-5L,13L,0L,1L,0L,6L,-4L,12L,-8L,2L,12L,-21L,0L,1L,0L,7L,-5L,18L,-16L,15L,3L,-25L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208459Inst : IEnumerable<long>
{
public static readonly long[] Value=A208459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208459.Bytes);
public long this[int i]=>Value[i];

public static A208459Inst Instance=new A208459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208460
{
public static readonly long[] Value={ 1L,2L,3L,2L,4L,5L,4L,3L,6L,7L,6L,4L,8L,6L,9L,8L,5L,10L,11L,10L,9L,8L,6L,12L,13L,12L,7L,14L,12L,10L,15L,14L,12L,8L,16L,17L,16L,15L,12L,9L,18L,19L,18L,16L,15L,10L,20L,18L,14L,21L,20L,11L,22L,23L,22L,21L,20L,18L,16L,12L,24L,20L,25L,24L,13L,26L,24L,18L,27L,26L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208460Inst : IEnumerable<long>
{
public static readonly long[] Value=A208460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208460.Bytes);
public long this[int i]=>Value[i];

public static A208460Inst Instance=new A208460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208461
{
public static readonly BigInteger[] Value={ 1L,15L,20746L,10318694804L,4585512913250157737L,BigInteger.Parse("3787532222733253394267947322830"),BigInteger.Parse("10658767342117292737413813034097966371526603430") };
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
public class A208461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208461Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208461.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208461.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208461Inst Instance=new A208461Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208462
{
public static readonly BigInteger[] Value={ 5L,198L,20746L,4150760L,1366230232L,675203938944L,470798015742024L,442649055938121520L,BigInteger.Parse("542162635236824518416"),BigInteger.Parse("841853575796382626351008"),BigInteger.Parse("1621152906552533388717492544"),BigInteger.Parse("3801835656372944848040523715264") };
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
public class A208462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208462Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208462.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208462.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208462Inst Instance=new A208462Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208463
{
public static readonly BigInteger[] Value={ 15L,4041L,4132120L,10318694804L,51074630353994L,441285917587055633L,BigInteger.Parse("6105599904286957450405"),BigInteger.Parse("127076755601333057601660992"),BigInteger.Parse("3793882208792084308313815728802"),BigInteger.Parse("156506565477239116898837571013067198") };
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
public class A208463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208463Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208463.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208463.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208463Inst Instance=new A208463Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208464
{
public static readonly BigInteger[] Value={ 52L,113458L,1358524513L,50996571454200L,4585512913250157737L,BigInteger.Parse("838683310903953794594668"),BigInteger.Parse("279322601688949336349340289673"),BigInteger.Parse("156351438264428644652281607036854772") };
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
public class A208464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208464Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208464.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208464.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208464Inst Instance=new A208464Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208465
{
public static readonly BigInteger[] Value={ 203L,4132120L,671329819215L,440379403449903222L,BigInteger.Parse("838156242834826375910795"),BigInteger.Parse("3787532222733253394267947322830"),BigInteger.Parse("35487456577214016192433880229514302813"),BigInteger.Parse("625053889686420860521751650397504301747811997") };
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
public class A208465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208465Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208465.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208465.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208465Inst Instance=new A208465Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208466
{
public static readonly long[] Value={ 1L,2L,2L,5L,15L,5L,15L,198L,203L,15L,52L,4041L,20746L,4140L,52L,203L,113458L,4132120L,4150760L,115975L,203L,877L,4132120L,1358524513L,10318694804L,1366230232L,4213597L,877L,4140L,187612143L,671329819215L,50996571454200L,51074630353994L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208466Inst : IEnumerable<long>
{
public static readonly long[] Value=A208466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208466.Bytes);
public long this[int i]=>Value[i];

public static A208466Inst Instance=new A208466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208467
{
public static readonly BigInteger[] Value={ 2L,15L,198L,4041L,113458L,4132120L,187612143L,10318694804L,672619407731L,51074630353994L,4455159144290726L,441285917587055633L,BigInteger.Parse("49152543937083199076"),BigInteger.Parse("6105599904286957450405"),BigInteger.Parse("839738743273230043872218") };
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
public class A208467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208467Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208467.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208467.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208467Inst Instance=new A208467Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208468
{
public static readonly BigInteger[] Value={ 5L,203L,20746L,4132120L,1358524513L,671329819215L,468215145028629L,440379520700561467L,BigInteger.Parse("539586833002472556426"),BigInteger.Parse("838156377510207185078132"),BigInteger.Parse("1614568986664304552415637091"),BigInteger.Parse("3787532565162728522045725351515") };
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
public class A208468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208468Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208468.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208468.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208468Inst Instance=new A208468Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208469
{
public static readonly BigInteger[] Value={ 15L,4140L,4150760L,10318694804L,50996571454200L,440379403449903222L,BigInteger.Parse("6092197983646590702604") };
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
public class A208469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208469Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208469.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208469.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208469Inst Instance=new A208469Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208470
{
public static readonly BigInteger[] Value={ 52L,115975L,1366230232L,51074630353994L,4585512913250157737L,BigInteger.Parse("838156242834826375910795") };
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
public class A208470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208470Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208470.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208470.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208470Inst Instance=new A208470Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208471
{
public static readonly BigInteger[] Value={ 203L,4213597L,675203938944L,441285917587055633L,BigInteger.Parse("838683310903953794594668"),BigInteger.Parse("3787532222733253394267947322830") };
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
public class A208471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208471Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208471.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208471.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208471Inst Instance=new A208471Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208472
{
public static readonly BigInteger[] Value={ 877L,190899322L,470798015742024L,BigInteger.Parse("6105599904286957450405"),BigInteger.Parse("279322601688949336349340289673"),BigInteger.Parse("35487456577214016192433880229514302813"),BigInteger.Parse("10658767342117292737413813034097966371526603430") };
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
public class A208472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208472Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208472.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208472.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208472Inst Instance=new A208472Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208473
{
public static readonly BigInteger[] Value={ 1L,6L,78L,1100L,16310L,248724L,3863244L,60784152L,965571750L,15451970820L,248731275364L,4022998982184L,65326505787452L,1064336612493000L,17390322931354200L,284844148339840560L,4675649304522319110L,BigInteger.Parse("76895312195988615780") };
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
public class A208473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208473Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208473.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208473.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208473Inst Instance=new A208473Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208474
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,7L,7L,13L,16L,24L,30L,46L,55L,79L,100L,136L,169L,229L,282L,374L,462L,598L,737L,947L,1158L,1466L,1794L,2246L,2733L,3399L,4116L,5076L,6133L,7503L,9033L,10993L,13177L,15943L,19061L,22939L,27327L,32749L,38883L,46395L,54938L,65278L,77070L,91270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208474Inst : IEnumerable<long>
{
public static readonly long[] Value=A208474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208474.Bytes);
public long this[int i]=>Value[i];

public static A208474Inst Instance=new A208474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208475
{
public static readonly long[] Value={ 1L,2L,2L,7L,2L,3L,10L,10L,3L,4L,23L,12L,11L,4L,5L,36L,30L,17L,14L,5L,6L,65L,40L,35L,18L,17L,6L,7L,94L,82L,49L,44L,22L,20L,7L,8L,160L,110L,93L,58L,48L,26L,23L,8L,9L,230L,190L,133L,108L,70L,56L,30L,26L,9L,10L,356L,260L,217L,148L,124L,76L,64L,34L,29L,10L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208475Inst : IEnumerable<long>
{
public static readonly long[] Value=A208475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208475.Bytes);
public long this[int i]=>Value[i];

public static A208475Inst Instance=new A208475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208476
{
public static readonly long[] Value={ 1L,1L,2L,5L,0L,3L,3L,8L,0L,4L,13L,2L,8L,0L,5L,13L,18L,6L,10L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208476Inst : IEnumerable<long>
{
public static readonly long[] Value=A208476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208476.Bytes);
public long this[int i]=>Value[i];

public static A208476Inst Instance=new A208476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208477
{
public static readonly long[] Value={ 0L,1L,0L,5L,0L,11L,6L,25L,12L,50L,40L,96L,80L,173L,170L,320L,316L,545L,590L,930L,1020L,1552L,1760L,2537L,2900L,4066L,4736L,6450L,7540L,10045L,11856L,15482L,18280L,23555L,27920L,35461L,42032L,52805L,62662L,77955L,92380L,113963L,135040L,165295L,195540L,237866L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208477Inst : IEnumerable<long>
{
public static readonly long[] Value=A208477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208477.Bytes);
public long this[int i]=>Value[i];

public static A208477Inst Instance=new A208477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208478
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,2L,1L,2L,1L,3L,1L,3L,2L,1L,5L,2L,4L,4L,2L,1L,6L,3L,5L,6L,4L,2L,1L,10L,5L,7L,9L,7L,4L,2L,1L,13L,7L,9L,11L,11L,7L,4L,2L,1L,19L,11L,12L,15L,16L,12L,7L,4L,2L,1L,25L,16L,15L,19L,22L,18L,12L,7L,4L,2L,1L,35L,24L,20L,26L,29L,27L,19L,12L,7L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208478Inst : IEnumerable<long>
{
public static readonly long[] Value=A208478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208478.Bytes);
public long this[int i]=>Value[i];

public static A208478Inst Instance=new A208478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208479
{
public static readonly long[] Value={ 0L,2L,3L,6L,10L,18L,27L,45L,65L,99L,141L,206L,285L,403L,549L,754L,1011L,1364L,1800L,2388L,3116L,4072L,5257L,6791L,8678L,11093L,14058L,17800L,22380L,28111L,35087L,43748L,54256L,67189L,82831L,101962L,124997L,153011L,186632L,227281L,275905L,334418L,404159L,487714L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208479Inst : IEnumerable<long>
{
public static readonly long[] Value=A208479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208479.Bytes);
public long this[int i]=>Value[i];

public static A208479Inst Instance=new A208479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208480
{
public static readonly long[] Value={ 1L,3L,10L,55L,196L,2730L,10032L,108999L,973258L,20780331L,79309308L,2614200602L,10073335754L,288845706742L,11805287917646L,254331289285523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208480Inst : IEnumerable<long>
{
public static readonly long[] Value=A208480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208480.Bytes);
public long this[int i]=>Value[i];

public static A208480Inst Instance=new A208480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208481
{
public static readonly long[] Value={ 1L,2L,6L,19L,60L,188L,589L,1846L,5786L,18135L,56840L,178152L,558377L,1750106L,5485310L,17192459L,53885860L,168892996L,529356757L,1659148590L,5200224626L,16298923631L,51085276240L,160115201936L,501844754065L,1572918462066L,4929955864374L,15451827549123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208481Inst : IEnumerable<long>
{
public static readonly long[] Value=A208481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208481.Bytes);
public long this[int i]=>Value[i];

public static A208481Inst Instance=new A208481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208482
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,1L,4L,1L,2L,1L,7L,1L,3L,2L,1L,12L,2L,5L,4L,2L,1L,18L,3L,6L,6L,4L,2L,1L,29L,6L,9L,10L,7L,4L,2L,1L,42L,9L,11L,13L,11L,7L,4L,2L,1L,63L,16L,15L,19L,17L,12L,7L,4L,2L,1L,89L,24L,18L,25L,24L,18L,12L,7L,4L,2L,1L,128L,39L,24L,36L,34L,28L,19L,12L,7L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208482Inst : IEnumerable<long>
{
public static readonly long[] Value=A208482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208482.Bytes);
public long this[int i]=>Value[i];

public static A208482Inst Instance=new A208482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208483
{
public static readonly long[] Value={ 0L,2L,4L,8L,14L,26L,40L,68L,100L,156L,224L,334L,466L,668L,920L,1278L,1726L,2356L,3130L,4190L,5508L,7254L,9422L,12268L,15764L,20284L,25852L,32934L,41616L,52578L,65938L,82648L,102976L,128144L,158660L,196222L,241534L,296946L,363632L,444650L,541794L,659268L,799606L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208483Inst : IEnumerable<long>
{
public static readonly long[] Value=A208483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208483.Bytes);
public long this[int i]=>Value[i];

public static A208483Inst Instance=new A208483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208484
{
public static readonly BigInteger[] Value={ 152L,33416L,43689232L,343092183768L,16261866249456960L,BigInteger.Parse("4664832940178290442768"),BigInteger.Parse("8112174131718066295245481744"),BigInteger.Parse("85615997981426512072932676873435656") };
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
public class A208484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208484Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208484.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208484.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208484Inst Instance=new A208484Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208485
{
public static readonly long[] Value={ 152L,1448L,13800L,131528L,1253608L,11948296L,113880744L,1085412040L,10345202024L,98601453704L,939783162408L,8957194434632L,85372174507240L,813693197494792L,7755414729341352L,73917857257827784L,704520623625326696L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208485Inst : IEnumerable<long>
{
public static readonly long[] Value=A208485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208485.Bytes);
public long this[int i]=>Value[i];

public static A208485Inst Instance=new A208485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208486
{
public static readonly BigInteger[] Value={ 1448L,33416L,773288L,17903016L,414522184L,9597910280L,222232271912L,5145622169576L,119143055140232L,2758668946684232L,63874930914742632L,1478976595260586280L,BigInteger.Parse("34244604867749825992"),BigInteger.Parse("792908397874578443656") };
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
public class A208486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208486Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208486.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208486.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208486Inst Instance=new A208486Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208487
{
public static readonly BigInteger[] Value={ 13800L,773288L,43689232L,2473041560L,140051200968L,7932164084608L,449271828443912L,25446613122575176L,1441290961315589072L,BigInteger.Parse("81634469371271854648"),BigInteger.Parse("4623762824135968860328"),BigInteger.Parse("261889170973575575061248") };
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
public class A208487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208487Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208487.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208487.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208487Inst Instance=new A208487Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208488
{
public static readonly BigInteger[] Value={ 131528L,17903016L,2473041560L,343092183768L,47661128330328L,6623652903138136L,920635760474340792L,BigInteger.Parse("127966524262127129240"),BigInteger.Parse("17787331338639722204888"),BigInteger.Parse("2472447761007115783120024"),BigInteger.Parse("343671940357621953613048984") };
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
public class A208488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208488Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208488.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208488.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208488Inst Instance=new A208488Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208489
{
public static readonly BigInteger[] Value={ 1253608L,414522184L,140051200968L,47661128330328L,16261866249456960L,5553852092522802280L,BigInteger.Parse("1897470416545860341536"),BigInteger.Parse("648358115644067172499256"),BigInteger.Parse("221552861024287017431767352"),BigInteger.Parse("75709141973276719446226452336") };
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
public class A208489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208489Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208489.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208489.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208489Inst Instance=new A208489Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208490
{
public static readonly BigInteger[] Value={ 11948296L,9597910280L,7932164084608L,6623652903138136L,5553852092522802280L,BigInteger.Parse("4664832940178290442768"),BigInteger.Parse("3920972889443714995894776"),BigInteger.Parse("3296755941450923874944187224"),BigInteger.Parse("2772285061723585066493554850800") };
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
public class A208490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208490Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208490.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208490.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208490Inst Instance=new A208490Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208491
{
public static readonly BigInteger[] Value={ 113880744L,222232271912L,449271828443912L,920635760474340792L,BigInteger.Parse("1897470416545860341536"),BigInteger.Parse("3920972889443714995894776"),BigInteger.Parse("8112174131718066295245481744"),BigInteger.Parse("16792956299828228584347524939848") };
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
public class A208491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208491Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208491.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208491.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208491Inst Instance=new A208491Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208492
{
public static readonly long[] Value={ 152L,1448L,1448L,13800L,33416L,13800L,131528L,773288L,773288L,131528L,1253608L,17903016L,43689232L,17903016L,1253608L,11948296L,414522184L,2473041560L,2473041560L,414522184L,11948296L,113880744L,9597910280L,140051200968L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208492Inst : IEnumerable<long>
{
public static readonly long[] Value=A208492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208492.Bytes);
public long this[int i]=>Value[i];

public static A208492Inst Instance=new A208492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208493
{
public static readonly long[] Value={ 0L,0L,1L,3L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208493Inst : IEnumerable<long>
{
public static readonly long[] Value=A208493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208493.Bytes);
public long this[int i]=>Value[i];

public static A208493Inst Instance=new A208493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208494
{
public static readonly long[] Value={ 2L,2L,3L,7L,10L,13L,13L,13L,31L,37L,37L,37L,61L,61L,61L,83L,83L,83L,127L,127L,127L,127L,127L,179L,179L,179L,179L,179L,193L,193L,193L,193L,193L,193L,193L,193L,277L,277L,277L,277L,277L,277L,383L,383L,383L,383L,383L,479L,479L,479L,479L,479L,479L,479L,541L,541L,541L,541L,541L,541L,541L,541L,541L,641L,641L,641L,641L,641L,641L,641L,641L,641L,877L,877L,877L,877L,877L,877L,877L,877L,877L,877L,877L,877L,877L,877L,877L,877L,877L,877L,877L,877L,877L,877L,877L,877L,877L,877L,877L,1013L,1013L,1013L,1013L,1013L,1013L,1013L,1013L,1013L,1013L,1013L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208494Inst : IEnumerable<long>
{
public static readonly long[] Value=A208494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208494.Bytes);
public long this[int i]=>Value[i];

public static A208494Inst Instance=new A208494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208495
{
public static readonly BigInteger[] Value={ 2L,16L,60L,324L,1794L,12654L,111328L,1037300L,13597800L,200667632L,3402101520L,81763293780L,1957289927740L,66305181080964L,2590637896086730L,114679284980561840L,7286860676676341916L,BigInteger.Parse("454949245195033857996") };
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
public class A208495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208495Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208495.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208495.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208495Inst Instance=new A208495Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208496
{
public static readonly long[] Value={ 6L,36L,60L,126L,234L,456L,896L,1722L,3360L,6512L,12642L,24570L,47644L,92568L,179690L,348800L,677340L,1314846L,2552850L,4956336L,9622272L,18681842L,36269696L,70416640L,136712226L,265421170L,515308500L,1000454184L,1942349698L,3771013664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208496Inst : IEnumerable<long>
{
public static readonly long[] Value=A208496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208496.Bytes);
public long this[int i]=>Value[i];

public static A208496Inst Instance=new A208496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208497
{
public static readonly long[] Value={ 10L,100L,144L,324L,650L,1406L,3024L,6150L,13560L,28688L,59598L,128520L,274230L,576520L,1218560L,2621232L,5546520L,11635076L,24984990L,53176014L,111623072L,237955858L,508611568L,1072136960L,2270141058L,4856035380L,10288291950L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208497Inst : IEnumerable<long>
{
public static readonly long[] Value=A208497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208497.Bytes);
public long this[int i]=>Value[i];

public static A208497Inst Instance=new A208497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208498
{
public static readonly long[] Value={ 16L,256L,324L,828L,1794L,4104L,9912L,21976L,52560L,121264L,279930L,662256L,1518514L,3571988L,8299060L,19262480L,45164520L,104532130L,244409310L,568980936L,1322673264L,3089796934L,7178968320L,16741713920L,38997040062L,90747250860L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208498Inst : IEnumerable<long>
{
public static readonly long[] Value=A208498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208498.Bytes);
public long this[int i]=>Value[i];

public static A208498Inst Instance=new A208498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208499
{
public static readonly long[] Value={ 26L,676L,756L,2124L,4992L,12654L,33488L,79376L,214560L,539792L,1340052L,3550932L,8928264L,22884596L,58320710L,150426976L,386485092L,969138898L,2534260860L,6476490918L,16314573968L,42371558268L,108544182448L,275738199040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208499Inst : IEnumerable<long>
{
public static readonly long[] Value=A208499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208499.Bytes);
public long this[int i]=>Value[i];

public static A208499Inst Instance=new A208499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208500
{
public static readonly long[] Value={ 42L,1764L,1728L,5436L,13806L,37430L,111328L,286754L,844200L,2336928L,6407688L,18684540L,50681028L,145645192L,408090270L,1135228896L,3261392100L,8999952300L,25648313760L,72191962584L,201563085152L,574718422958L,1602200548928L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208500Inst : IEnumerable<long>
{
public static readonly long[] Value=A208500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208500.Bytes);
public long this[int i]=>Value[i];

public static A208500Inst Instance=new A208500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208501
{
public static readonly long[] Value={ 2L,4L,4L,6L,16L,6L,10L,36L,36L,9L,16L,100L,60L,81L,13L,26L,256L,144L,126L,169L,19L,42L,676L,324L,324L,234L,361L,28L,68L,1764L,756L,828L,650L,456L,784L,41L,110L,4624L,1728L,2124L,1794L,1406L,896L,1681L,60L,178L,12100L,3996L,5436L,4992L,4104L,3024L,1722L,3600L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208501Inst : IEnumerable<long>
{
public static readonly long[] Value=A208501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208501.Bytes);
public long this[int i]=>Value[i];

public static A208501Inst Instance=new A208501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208502
{
public static readonly long[] Value={ 9L,81L,126L,324L,828L,2124L,5436L,13932L,35676L,91404L,234108L,599724L,1536156L,3935052L,10079676L,25819884L,66138588L,169418124L,433972476L,1111644972L,2847534876L,7294114764L,18684254268L,47860713324L,122597730396L,314040583692L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208502Inst : IEnumerable<long>
{
public static readonly long[] Value=A208502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208502.Bytes);
public long this[int i]=>Value[i];

public static A208502Inst Instance=new A208502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208503
{
public static readonly long[] Value={ 13L,169L,234L,650L,1794L,4992L,13806L,38376L,106236L,295074L,817362L,2269098L,6288048L,17450550L,48371544L,134210700L,372088314L,1032237882L,2862135666L,7939298016L,22015398366L,61064779464L,169339275612L,469681757298L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208503Inst : IEnumerable<long>
{
public static readonly long[] Value=A208503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208503.Bytes);
public long this[int i]=>Value[i];

public static A208503Inst Instance=new A208503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208504
{
public static readonly long[] Value={ 19L,361L,456L,1406L,4104L,12654L,37430L,114494L,341012L,1037552L,3103650L,9410776L,28227958L,85405038L,256622854L,775344932L,2332325696L,7040506202L,21193626760L,63940325966L,192562547974L,580744761326L,1749471290612L,5274981085968L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208504Inst : IEnumerable<long>
{
public static readonly long[] Value=A208504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208504.Bytes);
public long this[int i]=>Value[i];

public static A208504Inst Instance=new A208504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208505
{
public static readonly long[] Value={ 28L,784L,896L,3024L,9912L,33488L,111328L,374416L,1249472L,4192384L,14013664L,46966976L,157118976L,526293824L,1761299456L,5898133248L,19742507904L,66103688448L,221286062592L,740881883392L,2480260385792L,8303825768448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208505Inst : IEnumerable<long>
{
public static readonly long[] Value=A208505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208505.Bytes);
public long this[int i]=>Value[i];

public static A208505Inst Instance=new A208505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208506
{
public static readonly BigInteger[] Value={ 17L,145L,23401L,7861953L,3881436747409L,4731091158953433L,BigInteger.Parse("16248996011806421522977"),BigInteger.Parse("42832853457545958193355601"),BigInteger.Parse("535823088031930481975544151644865"),BigInteger.Parse("81325936178163422902293018227199467668020601") };
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
public class A208506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208506Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208506.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208506.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208506Inst Instance=new A208506Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208507
{
public static readonly long[] Value={ 1L,2L,6L,4L,3L,10L,12L,8L,5L,14L,18L,9L,7L,20L,24L,16L,22L,11L,26L,28L,36L,13L,34L,40L,48L,32L,17L,38L,54L,27L,19L,44L,50L,25L,46L,23L,52L,56L,72L,58L,29L,62L,31L,68L,80L,96L,64L,74L,76L,108L,37L,82L,88L,100L,41L,86L,98L,49L,43L,92L,94L,47L,104L,112L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208507Inst : IEnumerable<long>
{
public static readonly long[] Value=A208507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208507.Bytes);
public long this[int i]=>Value[i];

public static A208507Inst Instance=new A208507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208508
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,9L,1L,1L,16L,6L,1L,25L,20L,1L,1L,36L,50L,8L,1L,49L,105L,35L,1L,1L,64L,196L,112L,10L,1L,81L,336L,294L,54L,1L,1L,100L,540L,672L,210L,12L,1L,121L,825L,1386L,660L,77L,1L,1L,144L,1210L,2640L,1782L,352L,14L,1L,169L,1716L,4719L,4290L,1287L,104L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208508Inst : IEnumerable<long>
{
public static readonly long[] Value=A208508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208508.Bytes);
public long this[int i]=>Value[i];

public static A208508Inst Instance=new A208508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208509
{
public static readonly long[] Value={ 1L,3L,5L,1L,7L,5L,9L,14L,1L,11L,30L,7L,13L,55L,27L,1L,15L,91L,77L,9L,17L,140L,182L,44L,1L,19L,204L,378L,156L,11L,21L,285L,714L,450L,65L,1L,23L,385L,1254L,1122L,275L,13L,25L,506L,2079L,2508L,935L,90L,1L,27L,650L,3289L,5148L,2717L,442L,15L,29L,819L,5005L,9867L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208509Inst : IEnumerable<long>
{
public static readonly long[] Value=A208509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208509.Bytes);
public long this[int i]=>Value[i];

public static A208509Inst Instance=new A208509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208510
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,5L,4L,1L,1L,7L,9L,5L,1L,1L,9L,16L,14L,6L,1L,1L,11L,25L,30L,20L,7L,1L,1L,13L,36L,55L,50L,27L,8L,1L,1L,15L,49L,91L,105L,77L,35L,9L,1L,1L,17L,64L,140L,196L,182L,112L,44L,10L,1L,1L,19L,81L,204L,336L,378L,294L,156L,54L,11L,1L,1L,21L,100L,285L,540L,714L,672L,450L,210L,65L,12L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208510Inst : IEnumerable<long>
{
public static readonly long[] Value=A208510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208510.Bytes);
public long this[int i]=>Value[i];

public static A208510Inst Instance=new A208510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208511
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,1L,5L,7L,4L,1L,7L,14L,16L,8L,1L,9L,23L,37L,36L,16L,1L,11L,34L,69L,94L,80L,32L,1L,13L,47L,114L,195L,232L,176L,64L,1L,15L,62L,174L,354L,528L,560L,384L,128L,1L,17L,79L,251L,588L,1041L,1384L,1328L,832L,256L,1L,19L,98L,347L,916L,1863L,2938L,3536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208511Inst : IEnumerable<long>
{
public static readonly long[] Value=A208511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208511.Bytes);
public long this[int i]=>Value[i];

public static A208511Inst Instance=new A208511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208512
{
public static readonly long[] Value={ 1L,2L,2L,2L,5L,4L,2L,7L,12L,8L,2L,9L,21L,28L,16L,2L,11L,32L,58L,64L,32L,2L,13L,45L,101L,152L,144L,64L,2L,15L,60L,159L,296L,384L,320L,128L,2L,17L,77L,234L,513L,824L,944L,704L,256L,2L,19L,96L,328L,822L,1554L,2208L,2272L,1536L,512L,2L,21L,117L,443L,1244L,2685L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208512Inst : IEnumerable<long>
{
public static readonly long[] Value=A208512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208512.Bytes);
public long this[int i]=>Value[i];

public static A208512Inst Instance=new A208512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208513
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,9L,6L,1L,1L,16L,20L,8L,1L,1L,25L,50L,35L,10L,1L,1L,36L,105L,112L,54L,12L,1L,1L,49L,196L,294L,210L,77L,14L,1L,1L,64L,336L,672L,660L,352L,104L,16L,1L,1L,81L,540L,1386L,1782L,1287L,546L,135L,18L,1L,1L,100L,825L,2640L,4290L,4004L,2275L,800L,170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208513Inst : IEnumerable<long>
{
public static readonly long[] Value=A208513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208513.Bytes);
public long this[int i]=>Value[i];

public static A208513Inst Instance=new A208513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208514
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,3L,4L,3L,1L,4L,6L,7L,5L,1L,5L,8L,12L,13L,8L,1L,6L,10L,18L,24L,23L,13L,1L,7L,12L,25L,38L,46L,41L,21L,1L,8L,14L,33L,55L,78L,88L,72L,34L,1L,9L,16L,42L,75L,120L,158L,165L,126L,55L,1L,10L,18L,52L,98L,173L,255L,313L,307L,219L,89L,1L,11L,20L,63L,124L,238L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208514Inst : IEnumerable<long>
{
public static readonly long[] Value=A208514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208514.Bytes);
public long this[int i]=>Value[i];

public static A208514Inst Instance=new A208514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208515
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,2L,4L,5L,1L,2L,5L,8L,8L,1L,2L,6L,11L,15L,13L,1L,2L,7L,14L,23L,28L,21L,1L,2L,8L,17L,32L,47L,51L,34L,1L,2L,9L,20L,42L,70L,93L,92L,55L,1L,2L,10L,23L,53L,97L,148L,181L,164L,89L,1L,2L,11L,26L,65L,128L,217L,306L,346L,290L,144L,1L,2L,12L,29L,78L,163L,301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208515Inst : IEnumerable<long>
{
public static readonly long[] Value=A208515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208515.Bytes);
public long this[int i]=>Value[i];

public static A208515Inst Instance=new A208515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208516
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,1L,3L,6L,7L,1L,4L,9L,15L,17L,1L,5L,12L,24L,39L,41L,1L,6L,15L,34L,66L,100L,99L,1L,7L,18L,45L,98L,178L,256L,239L,1L,8L,21L,57L,135L,276L,478L,653L,577L,1L,9L,24L,70L,177L,395L,772L,1275L,1661L,1393L,1L,10L,27L,84L,224L,536L,1145L,2139L,3383L,4214L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208516Inst : IEnumerable<long>
{
public static readonly long[] Value=A208516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208516.Bytes);
public long this[int i]=>Value[i];

public static A208516Inst Instance=new A208516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208517
{
public static readonly long[] Value={ 1L,1L,3L,1L,3L,7L,1L,3L,8L,17L,1L,3L,9L,22L,41L,1L,3L,10L,27L,59L,99L,1L,3L,11L,32L,78L,157L,239L,1L,3L,12L,37L,98L,222L,414L,577L,1L,3L,13L,42L,119L,294L,622L,1084L,1393L,1L,3L,14L,47L,141L,373L,864L,1722L,2821L,3363L,1L,3L,15L,52L,164L,459L,1141L,2500L,4719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208517Inst : IEnumerable<long>
{
public static readonly long[] Value=A208517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208517.Bytes);
public long this[int i]=>Value[i];

public static A208517Inst Instance=new A208517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208518
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,1L,6L,7L,3L,1L,10L,16L,14L,5L,1L,15L,30L,40L,28L,8L,1L,21L,50L,90L,93L,53L,13L,1L,28L,77L,175L,238L,203L,99L,21L,1L,36L,112L,308L,518L,588L,428L,181L,34L,1L,45L,156L,504L,1008L,1428L,1380L,873L,327L,55L,1L,55L,210L,780L,1806L,3066L,3690L,3105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208518Inst : IEnumerable<long>
{
public static readonly long[] Value=A208518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208518.Bytes);
public long this[int i]=>Value[i];

public static A208518Inst Instance=new A208518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208519
{
public static readonly long[] Value={ 1L,2L,2L,3L,5L,3L,4L,9L,11L,5L,5L,14L,26L,23L,8L,6L,20L,50L,65L,45L,13L,7L,27L,85L,145L,150L,86L,21L,8L,35L,133L,280L,385L,329L,160L,34L,9L,44L,196L,490L,840L,952L,692L,293L,55L,10L,54L,276L,798L,1638L,2310L,2232L,1413L,529L,89L,11L,65L,375L,1230L,2940L,4956L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208519Inst : IEnumerable<long>
{
public static readonly long[] Value=A208519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208519.Bytes);
public long this[int i]=>Value[i];

public static A208519Inst Instance=new A208519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208520
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,1L,6L,6L,2L,1L,10L,12L,10L,4L,1L,15L,20L,30L,20L,4L,1L,21L,30L,70L,60L,28L,8L,1L,28L,42L,140L,140L,112L,56L,8L,1L,36L,56L,252L,280L,336L,224L,72L,16L,1L,45L,72L,420L,504L,840L,672L,360L,144L,16L,1L,55L,90L,660L,840L,1848L,1680L,1320L,720L,176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208520Inst : IEnumerable<long>
{
public static readonly long[] Value=A208520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208520.Bytes);
public long this[int i]=>Value[i];

public static A208520Inst Instance=new A208520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208521
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,2L,4L,6L,8L,4L,5L,8L,20L,16L,4L,6L,10L,40L,40L,24L,8L,7L,12L,70L,80L,84L,48L,8L,8L,14L,112L,140L,224L,168L,64L,16L,9L,16L,168L,224L,504L,448L,288L,128L,16L,10L,18L,240L,336L,1008L,1008L,960L,576L,160L,32L,11L,20L,330L,480L,1848L,2016L,2640L,1920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208521Inst : IEnumerable<long>
{
public static readonly long[] Value=A208521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208521.Bytes);
public long this[int i]=>Value[i];

public static A208521Inst Instance=new A208521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208522
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,1L,3L,6L,5L,1L,4L,9L,12L,11L,1L,5L,12L,21L,30L,21L,1L,6L,15L,32L,57L,64L,43L,1L,7L,18L,45L,92L,133L,146L,85L,1L,8L,21L,60L,135L,232L,329L,316L,171L,1L,9L,24L,77L,186L,365L,612L,765L,694L,341L,1L,10L,27L,96L,245L,536L,1015L,1512L,1801L,1496L,683L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208522Inst : IEnumerable<long>
{
public static readonly long[] Value=A208522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208522.Bytes);
public long this[int i]=>Value[i];

public static A208522Inst Instance=new A208522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208523
{
public static readonly long[] Value={ 1L,1L,3L,1L,3L,5L,1L,3L,7L,11L,1L,3L,9L,19L,21L,1L,3L,11L,27L,43L,43L,1L,3L,13L,35L,69L,103L,85L,1L,3L,15L,43L,99L,183L,231L,171L,1L,3L,17L,51L,133L,283L,449L,523L,341L,1L,3L,19L,59L,171L,403L,747L,1107L,1155L,683L,1L,3L,21L,67L,213L,543L,1133L,1971L,2637L,2543L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208523Inst : IEnumerable<long>
{
public static readonly long[] Value=A208523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208523.Bytes);
public long this[int i]=>Value[i];

public static A208523Inst Instance=new A208523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208524
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,3L,1L,6L,10L,5L,1L,10L,22L,23L,11L,1L,15L,40L,65L,60L,21L,1L,21L,65L,145L,195L,137L,43L,1L,28L,98L,280L,490L,518L,322L,85L,1L,36L,140L,490L,1050L,1484L,1372L,723L,171L,1L,45L,192L,798L,2016L,3570L,4368L,3447L,1624L,341L,1L,55L,255L,1230L,3570L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208524Inst : IEnumerable<long>
{
public static readonly long[] Value=A208524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208524.Bytes);
public long this[int i]=>Value[i];

public static A208524Inst Instance=new A208524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208525
{
public static readonly long[] Value={ 1L,2L,3L,3L,7L,5L,4L,12L,18L,11L,5L,18L,42L,49L,21L,6L,25L,80L,135L,116L,43L,7L,33L,135L,295L,381L,279L,85L,8L,42L,210L,560L,966L,1050L,638L,171L,9L,52L,308L,966L,2086L,2996L,2724L,1453L,341L,10L,63L,432L,1554L,4032L,7182L,8688L,6921L,3240L,683L,11L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208525Inst : IEnumerable<long>
{
public static readonly long[] Value=A208525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208525.Bytes);
public long this[int i]=>Value[i];

public static A208525Inst Instance=new A208525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208526
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,4L,1L,3L,8L,10L,1L,4L,12L,22L,28L,1L,5L,16L,36L,68L,76L,1L,6L,20L,52L,120L,200L,208L,1L,7L,24L,70L,184L,376L,592L,568L,1L,8L,28L,90L,260L,608L,1184L,1736L,1552L,1L,9L,32L,112L,348L,900L,2016L,3672L,5072L,4240L,1L,10L,36L,136L,448L,1256L,3120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208526Inst : IEnumerable<long>
{
public static readonly long[] Value=A208526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208526.Bytes);
public long this[int i]=>Value[i];

public static A208526Inst Instance=new A208526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208527
{
public static readonly long[] Value={ 1L,1L,4L,1L,4L,10L,1L,4L,12L,28L,1L,4L,14L,40L,76L,1L,4L,16L,52L,124L,208L,1L,4L,18L,64L,176L,384L,568L,1L,4L,20L,76L,232L,592L,1168L,1552L,1L,4L,22L,88L,292L,832L,1936L,3520L,4240L,1L,4L,24L,100L,356L,1104L,2880L,6240L,10512L,11584L,1L,4L,26L,112L,424L,1408L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208527Inst : IEnumerable<long>
{
public static readonly long[] Value=A208527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208527.Bytes);
public long this[int i]=>Value[i];

public static A208527Inst Instance=new A208527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208528
{
public static readonly BigInteger[] Value={ 0L,4L,16L,72L,384L,2400L,17280L,141120L,1290240L,13063680L,145152000L,1756339200L,22992076800L,323805081600L,4881984307200L,78460462080000L,1339058552832000L,24186745110528000L,460970906812416000L,9245027631071232000UL,BigInteger.Parse("194632160654131200000") };
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
public class A208528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208528Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208528.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208528.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208528Inst Instance=new A208528Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208529
{
public static readonly BigInteger[] Value={ 2L,2L,4L,12L,48L,240L,1440L,10080L,80640L,725760L,7257600L,79833600L,958003200L,12454041600L,174356582400L,2615348736000L,41845579776000L,711374856192000L,12804747411456000L,243290200817664000L,4865804016353280000L,BigInteger.Parse("102181884343418880000") };
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
public class A208529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208529Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208529.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208529.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208529Inst Instance=new A208529Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208530
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,14L,15L,21L,22L,28L,29L,35L,36L,43L,50L,57L,64L,71L,78L,85L,92L,671L,678L,685L,1356L,1363L,2034L,2041L,2719L,3397L,4075L,4753L,5431L,18412L,19090L,19768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208530Inst : IEnumerable<long>
{
public static readonly long[] Value=A208530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208530.Bytes);
public long this[int i]=>Value[i];

public static A208530Inst Instance=new A208530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208531
{
public static readonly long[] Value={ 2L,4L,8L,16L,28L,52L,89L,147L,224L,324L,445L,589L,758L,954L,1179L,1435L,1724L,2048L,2409L,2809L,3250L,3734L,4263L,4839L,5464L,6140L,6869L,7653L,8494L,9394L,10355L,11379L,12468L,13624L,14849L,16145L,17514L,18958L,20479L,22079L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208531Inst : IEnumerable<long>
{
public static readonly long[] Value=A208531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208531.Bytes);
public long this[int i]=>Value[i];

public static A208531Inst Instance=new A208531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208532
{
public static readonly long[] Value={ 1L,2L,1L,3L,4L,2L,4L,9L,10L,4L,5L,16L,28L,24L,8L,6L,25L,60L,80L,56L,16L,7L,36L,110L,200L,216L,128L,32L,8L,49L,182L,420L,616L,560L,288L,64L,9L,64L,280L,784L,1456L,1792L,1408L,640L,128L,10L,81L,408L,1344L,3024L,4704L,4992L,3456L,1408L,256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208532Inst : IEnumerable<long>
{
public static readonly long[] Value=A208532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208532.Bytes);
public long this[int i]=>Value[i];

public static A208532Inst Instance=new A208532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208533
{
public static readonly BigInteger[] Value={ 1L,1L,2L,24L,204L,2635L,39990L,720916L,14913192L,348684381L,9090909090L,261535848376L,8230246567620L,281241174889207L,10371206370593250L,410525522392242720L,17361641481138401520UL,BigInteger.Parse("781282469565908953017"),BigInteger.Parse("37275544492386193492506"),BigInteger.Parse("1879498672877604463254424") };
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
public class A208533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208533Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208533.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208533.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208533Inst Instance=new A208533Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208534
{
public static readonly long[] Value={ 7L,21L,70L,336L,1554L,7826L,39990L,210126L,1119790L,6047412L,32981550L,181402676L,1004668770L,5597460306L,31345666730L,176319474366L,995685849690L,5642220380006L,32071565263710L,182807925027504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208534Inst : IEnumerable<long>
{
public static readonly long[] Value=A208534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208534.Bytes);
public long this[int i]=>Value[i];

public static A208534Inst Instance=new A208534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208535
{
public static readonly long[] Value={ 1L,2L,0L,3L,1L,0L,4L,3L,0L,0L,5L,6L,2L,1L,0L,6L,10L,8L,6L,0L,0L,7L,15L,20L,24L,6L,1L,0L,8L,21L,40L,70L,48L,14L,0L,0L,9L,28L,70L,165L,204L,130L,18L,1L,0L,10L,36L,112L,336L,624L,700L,312L,36L,0L,0L,11L,45L,168L,616L,1554L,2635L,2340L,834L,58L,1L,0L,12L,55L,240L,1044L,3360L,7826L,11160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208535Inst : IEnumerable<long>
{
public static readonly long[] Value=A208535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208535.Bytes);
public long this[int i]=>Value[i];

public static A208535Inst Instance=new A208535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208536
{
public static readonly long[] Value={ 0L,0L,6L,48L,204L,624L,1554L,3360L,6552L,11808L,19998L,32208L,49764L,74256L,107562L,151872L,209712L,283968L,377910L,495216L,639996L,816816L,1030722L,1287264L,1592520L,1953120L,2376270L,2869776L,3442068L,4102224L,4859994L,5725824L,6710880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208536Inst : IEnumerable<long>
{
public static readonly long[] Value=A208536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208536.Bytes);
public long this[int i]=>Value[i];

public static A208536Inst Instance=new A208536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208537
{
public static readonly long[] Value={ 0L,0L,18L,312L,2340L,11160L,39990L,117648L,299592L,683280L,1428570L,2783880L,5118828L,8964072L,15059070L,24408480L,38347920L,58619808L,87460002L,127695960L,182857140L,257298360L,356336838L,486403632L,655210200L,871930800L,1147401450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208537Inst : IEnumerable<long>
{
public static readonly long[] Value=A208537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208537.Bytes);
public long this[int i]=>Value[i];

public static A208537Inst Instance=new A208537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208538
{
public static readonly BigInteger[] Value={ 1L,1L,1L,21L,102L,1505L,19995L,365260L,7456596L,174489813L,4545454545L,130773238871L,4115123283810L,140620807064413L,5185603185296625L,205262771447683860L,8680820740569200760L,BigInteger.Parse("390641235316599920745"),BigInteger.Parse("18637772246193096746253"),BigInteger.Parse("939749336469457562916217") };
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
public class A208538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208538Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208538.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208538.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208538Inst Instance=new A208538Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208539
{
public static readonly long[] Value={ 3L,3L,1L,6L,3L,13L,9L,30L,29L,78L,93L,224L,315L,687L,1095L,2250L,3855L,7685L,13797L,27012L,49939L,96909L,182361L,352698L,671091L,1296858L,2485533L,4806078L,9256395L,17920860L,34636833L,67159050L,130150587L,252745368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208539Inst : IEnumerable<long>
{
public static readonly long[] Value=A208539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208539.Bytes);
public long this[int i]=>Value[i];

public static A208539Inst Instance=new A208539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208540
{
public static readonly long[] Value={ 4L,6L,4L,21L,24L,92L,156L,498L,1096L,3210L,8052L,22913L,61320L,173088L,478316L,1351983L,3798240L,10781954L,30585828L,87230157L,249056136L,713387076L,2046590844L,5884491500L,16945772208L,48883660146L,141214768972L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208540Inst : IEnumerable<long>
{
public static readonly long[] Value=A208540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208540.Bytes);
public long this[int i]=>Value[i];

public static A208540Inst Instance=new A208540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208541
{
public static readonly long[] Value={ 5L,10L,10L,55L,102L,430L,1170L,4435L,14570L,53764L,190650L,704370L,2581110L,9608050L,35791470L,134301715L,505290270L,1909209550L,7233629130L,27489127708L,104715393910L,399827748310L,1529755308210L,5864083338770L,22517998136934L,86607770318380L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208541Inst : IEnumerable<long>
{
public static readonly long[] Value=A208541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208541.Bytes);
public long this[int i]=>Value[i];

public static A208541Inst Instance=new A208541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208542
{
public static readonly long[] Value={ 6L,15L,20L,120L,312L,1505L,5580L,25395L,108520L,493131L,2219460L,10196680L,46950120L,218102685L,1017252828L,4768969770L,22439395680L,105966797755L,501933850740L,2384200683816L,11353265675240L,54186115056825L,259150629458220L,1241763804134805L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208542Inst : IEnumerable<long>
{
public static readonly long[] Value=A208542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208542.Bytes);
public long this[int i]=>Value[i];

public static A208542Inst Instance=new A208542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208543
{
public static readonly long[] Value={ 7L,21L,35L,231L,777L,4291L,19995L,107331L,559895L,3037314L,16490775L,90782986L,502334385L,2799220041L,15672833365L,88162676511L,497842924845L,2821127825971L,16035782631855L,91404068329560L,522308348593785L,2991403003191771L,17168048327252235L,98716281736491076L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208543Inst : IEnumerable<long>
{
public static readonly long[] Value=A208543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208543.Bytes);
public long this[int i]=>Value[i];

public static A208543Inst Instance=new A208543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208544
{
public static readonly long[] Value={ 1L,2L,0L,3L,1L,0L,4L,3L,0L,0L,5L,6L,1L,1L,0L,6L,10L,4L,6L,0L,0L,7L,15L,10L,21L,3L,1L,0L,8L,21L,20L,55L,24L,13L,0L,0L,9L,28L,35L,120L,102L,92L,9L,1L,0L,10L,36L,56L,231L,312L,430L,156L,30L,0L,0L,11L,45L,84L,406L,777L,1505L,1170L,498L,29L,1L,0L,12L,55L,120L,666L,1680L,4291L,5580L,4435L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208544Inst : IEnumerable<long>
{
public static readonly long[] Value=A208544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208544.Bytes);
public long this[int i]=>Value[i];

public static A208544Inst Instance=new A208544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208545
{
public static readonly long[] Value={ 0L,0L,9L,156L,1170L,5580L,19995L,58824L,149796L,341640L,714285L,1391940L,2559414L,4482036L,7529535L,12204240L,19173960L,29309904L,43730001L,63847980L,91428570L,128649180L,178168419L,243201816L,327605100L,435965400L,573700725L,747168084L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208545Inst : IEnumerable<long>
{
public static readonly long[] Value=A208545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208545.Bytes);
public long this[int i]=>Value[i];

public static A208545Inst Instance=new A208545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208546
{
public static readonly long[] Value={ 1L,1L,0L,-1L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208546Inst : IEnumerable<long>
{
public static readonly long[] Value=A208546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208546.Bytes);
public long this[int i]=>Value[i];

public static A208546Inst Instance=new A208546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208547
{
public static readonly long[] Value={ 1L,2L,6L,3L,10L,5L,14L,7L,15L,30L,22L,11L,21L,26L,42L,13L,34L,17L,38L,19L,33L,66L,46L,23L,35L,39L,78L,70L,58L,29L,62L,31L,51L,102L,57L,74L,114L,37L,55L,82L,110L,41L,86L,43L,69L,138L,94L,47L,65L,210L,130L,105L,106L,53L,87L,174L,118L,59L,77L,93L,122L,186L,154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208547Inst : IEnumerable<long>
{
public static readonly long[] Value=A208547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208547.Bytes);
public long this[int i]=>Value[i];

public static A208547Inst Instance=new A208547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208548
{
public static readonly long[] Value={ 2L,1L,2L,1L,4L,3L,6L,5L,4L,10L,7L,11L,14L,13L,12L,14L,20L,17L,21L,24L,21L,25L,24L,24L,31L,34L,33L,36L,35L,26L,41L,40L,46L,39L,50L,47L,49L,53L,52L,54L,60L,53L,64L,63L,66L,57L,61L,73L,76L,75L,74L,80L,73L,80L,82L,84L,90L,87L,91L,94L,87L,86L,101L,104L,103L,94L,107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208548Inst : IEnumerable<long>
{
public static readonly long[] Value=A208548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208548.Bytes);
public long this[int i]=>Value[i];

public static A208548Inst Instance=new A208548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208549
{
public static readonly long[] Value={ 2189L,7208L,20538L,69632L,127790L,265375L,341267L,461849L,621457L,1453179L,1700469L,1828994L,1837608L,2114852L,2222674L,2354838L,2826692L,2905552L,2933084L,3162302L,3466663L,3972552L,3996543L,4535984L,5382039L,6192528L,6392223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208549Inst : IEnumerable<long>
{
public static readonly long[] Value=A208549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208549.Bytes);
public long this[int i]=>Value[i];

public static A208549Inst Instance=new A208549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208550
{
public static readonly BigInteger[] Value={ 2L,16L,90L,1089L,10080L,150544L,1913940L,33930625L,544003170L,11177987076L,215177010048L,5033386477441L,112708053008152L,2958949185458176L,75387859827570360L,2195709810260687361L,BigInteger.Parse("62623865365172370000") };
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
public class A208550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208550Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A208550.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A208550.Bytes);
public BigInteger this[int i]=>Value[i];

public static A208550Inst Instance=new A208550Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208551
{
public static readonly long[] Value={ 10L,100L,330L,1089L,2508L,5776L,11020L,21025L,35670L,60516L,94710L,148225L,218680L,322624L,454968L,641601L,873090L,1188100L,1570690L,2076481L,2680260L,3459600L,4376580L,5536609L,6884878L,8561476L,10489710L,12852225L,15544560L,18800896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208551Inst : IEnumerable<long>
{
public static readonly long[] Value=A208551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208551.Bytes);
public long this[int i]=>Value[i];

public static A208551Inst Instance=new A208551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208552
{
public static readonly long[] Value={ 16L,256L,1008L,3969L,10080L,25600L,52000L,105625L,187200L,331776L,536256L,866761L,1310848L,1982464L,2851200L,4100625L,5670000L,7840000L,10502800L,14070001L,18364896L,23970816L,30614688L,39100009L,49023520L,61465600L,75852000L,93605625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208552Inst : IEnumerable<long>
{
public static readonly long[] Value=A208552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208552.Bytes);
public long this[int i]=>Value[i];

public static A208552Inst Instance=new A208552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208553
{
public static readonly long[] Value={ 26L,676L,3354L,16641L,50052L,150544L,351140L,819025L,1634430L,3261636L,5853246L,10504081L,17449544L,28987456L,45403272L,71115489L,106340130L,159012100L,229010210L,329821921L,460490316L,642926736L,874503084L,1189491121L,1582286342L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208553Inst : IEnumerable<long>
{
public static readonly long[] Value=A208553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208553.Bytes);
public long this[int i]=>Value[i];

public static A208553Inst Instance=new A208553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208554
{
public static readonly long[] Value={ 42L,1764L,10710L,65025L,221340L,753424L,1913940L,4862025L,10332630L,21958596L,41363322L,77915929L,134523480L,232257600L,375406920L,606784689L,931373730L,1429596100L,2104920510L,3099260241L,4409811252L,6274540944L,8675694300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208554Inst : IEnumerable<long>
{
public static readonly long[] Value=A208554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208554.Bytes);
public long this[int i]=>Value[i];

public static A208554Inst Instance=new A208554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208555
{
public static readonly long[] Value={ 2L,4L,4L,6L,16L,6L,10L,36L,36L,9L,16L,100L,90L,81L,12L,26L,256L,330L,225L,144L,16L,42L,676L,1008L,1089L,420L,256L,20L,68L,1764L,3354L,3969L,2508L,784L,400L,25L,110L,4624L,10710L,16641L,10080L,5776L,1260L,625L,30L,178L,12100L,34884L,65025L,50052L,25600L,11020L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208555Inst : IEnumerable<long>
{
public static readonly long[] Value=A208555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208555.Bytes);
public long this[int i]=>Value[i];

public static A208555Inst Instance=new A208555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A208556
{
public static readonly long[] Value={ 9L,81L,225L,1089L,3969L,16641L,65025L,263169L,1046529L,4198401L,16769025L,67125249L,268402689L,1073807361L,4294836225L,17180131329L,68718952449L,274878955521L,1099509530625L,4398050705409L,17592177655809L,70368760954881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A208556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A208556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A208556Inst : IEnumerable<long>
{
public static readonly long[] Value=A208556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A208556.Bytes);
public long this[int i]=>Value[i];

public static A208556Inst Instance=new A208556Inst();

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